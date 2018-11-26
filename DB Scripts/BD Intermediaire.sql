go
use master;
go
set dateformat DMY
go
if exists (select * from
		   sys.databases where name='INTERMEDIAIRE')
		   drop database INTERMEDIAIRE;
go
create database INTERMEDIAIRE;
go
use INTERMEDIAIRE;
go
SET ANSI_WARNINGS  OFF;
go
--Les Utilisateurs de l'application
create table [Authentication](
	id int identity(1,1)
	constraint pk_auth primary key,
	username nvarchar(10) not null unique,
	mdp nvarchar(255) not null
);
go
--Les chaines de connexions vers les BD system(Vectis,Praxix,..) dans les differents serveurs(oracle,mss)
create table Connexions_Systems(Code int identity(1,1) constraint pk_cnx_systems primary key,
								Libelle nvarchar(255) not null,
								[TypeServeur] nvarchar(20) not null
								constraint ck_server check([TypeServeur] in('MSSQLSERVER','ORACLE')),
								Serveur nvarchar(255) not null,
								DB_Nom nvarchar(255) not null,
								[Username] nvarchar(255),
								[Password] nvarchar(255));
go
create table Tables_Sorties(Code int identity(1,1) constraint pk_tables_sorties primary key,
							Libelle nvarchar(255) not null,
							[System] int constraint fk_tables_sorties_systems foreign key
							references Connexions_Systems(Code));
go
create table Structures(Champs nvarchar(255) not null,
						[Type] nvarchar(10) not null,
						Taille int not null,
						Nom_Fonctionnel nvarchar(255),
						Comptabiliser int default 0,
						Critere int default 0,
						Developper int default 0,
						[Date] int,
						Cle int default 0,
						Date_Maj int,
						Impression int,
						Id int not null,
						Code_Table int constraint fk_structure_tables_sorties
						references Tables_Sorties(Code),
						constraint pk_structures primary key(Champs,Code_Table));
go
create table Conditions(Ref_util int constraint pk_conditions primary key,
						Code_fils int not null,
						Libelle nvarchar(255) not null,
						Code_pere int,
						[Type] nvarchar(10)not null,
						Selection nvarchar(1) default '0',
						Niveau int not null,
						Req nvarchar(max),
						Valeur nvarchar(max),
						[TableTmp] nvarchar(max),
						Numecrit int,
						Cle nvarchar(255),
						Form nvarchar(max),
						Code_Table int
						constraint fk_conditions_tblSorties foreign key references Tables_Sorties(Code));
go
--Les tables Ecritures et MVT sont ecrit par les triggers de la creation d'une nouvelle table de sortie
--Deux trigger un sur Tables_Sortie et un autre sur la table Structures

--1er Trigger creation des tables avec les premiers colonnes communes
Create trigger Tr_Create_Ecrit_Mvt
on Tables_Sorties
after insert,update,delete
as
BEGIN
	IF exists(select * from inserted) and exists(select * from deleted)
	begin
		print'UPDATE tables_sorties'
		declare curs2 cursor for(select Libelle from inserted);
		declare curs3 cursor for(select	Libelle from deleted)
		open curs2;
		open curs3;
		declare @table2 nvarchar(max),@oldTbl nvarchar(max);
		fetch next from curs2--new values
		into @table2;
		fetch next from curs3--old values
		into @oldTbl;
		WHILE @@FETCH_STATUS = 0
		begin
			--Renommer les tables Ecritures
			declare @param1 nvarchar(max), @param2 nvarchar(max);
			set @param1 = 'dbo.[Ecritures_'+@oldTbl+']';
			set @param2 = 'Ecritures_'+@table2;
			exec sp_rename @param1,@param2;
			--Renommer les tables Mvt
			set @param1 = 'dbo.[Mvt_'+@oldTbl+']';
			set @param2 = 'Mvt_'+@table2;
			exec sp_rename @param1,@param2;
			--Fetching cursors
			fetch next from curs2
			into @table2;
			fetch next from curs3--old values
			into @oldTbl;
		end
		close curs2;deallocate curs2;
		close curs3;deallocate curs3;
	end
	ELSE IF exists(select * from inserted)
	begin
		print'insert tables_sortie'
		declare curs1 cursor for(select Libelle from inserted);
		open curs1;
		declare @sql nvarchar(max),@table nvarchar(max);
		fetch next from curs1
		into @table;
		WHILE @@FETCH_STATUS = 0
		begin
			--Creation de la table Ecriture_X
			set @sql = 'CREATE TABLE Ecritures_'+@table+'(';
			set @sql = @sql+ 'cleecrit int, numecrit int, condition nvarchar(max))';
			execute(@sql);
			--Creation de la table Mvt_X
			set @sql = 'CREATE TABLE Mvt_'+@table+'(';
			set @sql = @sql+ 'clemvt int identity(1,1), code_table nvarchar(max), ref_table nvarchar(max), etat_comptabilisation nvarchar(1))';
			execute(@sql);
			--Fetching cursor
			fetch next from curs1
			into @table;
		end
		close curs1;
		deallocate curs1;
	end
	ELSE IF exists(select * from deleted)
	begin
		print'delete tables_sorties'
		declare curs3 cursor for(select Libelle from deleted);
		open curs3;
		declare @sql2 nvarchar(max),@table3 nvarchar(max);
		fetch next from curs3
		into @table3;
		WHILE @@FETCH_STATUS = 0
		begin
			--Supression de la table Ecriture_X
			set @sql2 = 'DROP TABLE dbo.[Ecritures_'+@table3+']';
			execute(@sql2);
			--Supression de la table Mvt_X
			set @sql2 = 'DROP TABLE dbo.[Mvt_'+@table3+']';
			execute(@sql2);
			--Fetching Cursor
			fetch next from curs3
			into @table3;
		end
		close curs3;deallocate curs3;
	end
END
go
--2eme Trigger, Alter les tables pour ajouter,modifier ou supprimer des colonnes selon les champs ajputé dans la structure
Create trigger Tr_Columns_Ecrit_Mvt
on Structures
after insert,update,delete
as
BEGIN
	IF exists(select * from inserted) and exists(select * from deleted)
	begin
		print'update structures'
		declare @champs1 nvarchar(max),@tblNm1 nvarchar(max),@sqlUp nvarchar(max),@tab1 int;--Inserted
		declare @champs2 nvarchar(max),@tblNm2 nvarchar(max),@tab2 int;--Deleted
		declare cursUpIns cursor for(select Champs,Code_Table from inserted);
		declare cursUpDel cursor for(select Champs,Code_Table from deleted);
		open cursUpIns;
		open cursUpDel;
		fetch next from cursUpIns
		into @champs1,@tab1;
		fetch next from cursUpDel
		into @champs2,@tab2;
		WHILE @@FETCH_STATUS = 0
		begin
			set @tblNm1=(select Libelle from Tables_Sorties where Code=@tab1);--new
			set @tblNm2=(select Libelle from Tables_Sorties where Code=@tab2);--old
			IF (@champs1 != @champs2)
			begin
			--Table Ecritures_X
			set @sqlUp = 'ALTER TABLE Ecritures_'+@tblNm1+' ADD ['+@champs1+'] nvarchar(max)';
			execute(@sqlUp);--Ajouter la colonne à la nouvelle table
			set @sqlUp = 'INSERT INTO Ecritures_'+@tblNm1+'(['+@champs1+'])';
			set @sqlUp = @sqlUp + ' SELECT ['+@champs2+'] FROM Ecritures_'+@tblNm2;
			execute(@sqlUp);--Remplir la nouvelle colonne par les valeurs de l'ancienne
			set @sqlUp = 'ALTER TABLE Ecritures_'+@tblNm2+' DROP COLUMN ['+@champs2+']';
			execute(@sqlUp);--Suprimer la colonne depuis l'ancienne table
			--Table Mvt_X
			set @sqlUp = 'ALTER TABLE Mvt_'+@tblNm1+' ADD ['+@champs1+'] nvarchar(max)';
			execute(@sqlUp);--Ajouter la colonne à la nouvelle table
			set @sqlUp = 'INSERT INTO Mvt_'+@tblNm1+'(['+@champs1+'])';
			set @sqlUp = @sqlUp + ' SELECT ['+@champs2+'] FROM Mvt_'+@tblNm2;
			execute(@sqlUp);--Remplir la nouvelle colonne par les valeurs de l'ancienne
			set @sqlUp = 'ALTER TABLE Mvt_'+@tblNm2+' DROP COLUMN ['+@champs2+']';
			execute(@sqlUp);--Suprimer la colonne depuis l'ancienne table
			end
			--Fectiching Cursor
			fetch next from cursUpIns
			into @champs1,@tab1;
			fetch next from cursUpDel
			into @champs2,@tab2;
		end
		close cursUpIns;deallocate cursUpIns;
		close cursUpDel;deallocate cursUpDel;
	end
	ELSE IF exists(select * from inserted)
	begin
		print'insert structures'
		declare @champsIns nvarchar(max),@tblNmInse nvarchar(max),@sqlIns nvarchar(max),@tabIns int;
		declare cursIns cursor for(select Champs,Code_Table from inserted);
		open cursIns;
		fetch next from cursIns
		into @champsIns,@tabIns;
		WHILE @@FETCH_STATUS = 0
		begin
			set @tblNmInse=(select Libelle from Tables_Sorties where Code=@tabIns);
			--Alter Ecritures_X
			set @sqlIns='ALTER TABLE Ecritures_'+@tblNmInse+' ADD ['+@champsIns+'] nvarchar(max)';
			execute(@sqlIns);
			--Alter Mvt_X
			set @sqlIns='ALTER TABLE Mvt_'+@tblNmInse+' ADD ['+@champsIns+'] nvarchar(max)';
			execute(@sqlIns);
			--Fectiching Cursor
			fetch next from cursIns
			into @champsIns,@tabIns;
		end
		close cursIns;deallocate cursIns;
	end
	ELSE IF exists(select * from deleted)
	begin
		print'delete structures'
		declare @champsDel nvarchar(max),@tblNmDel nvarchar(max),@sqlDel nvarchar(max),@tabDel int;
		declare cursDel cursor for(select Champs,Code_Table from deleted);
		open cursDel;
		fetch next from cursDel
		into @champsDel,@tabDel;
		WHILE @@FETCH_STATUS = 0
		begin
			set @tblNmDel=(select Libelle from Tables_Sorties where Code=@tabDel);
			--Table Ecrtitures_X
			set @sqlDel='ALTER TABLE Ecritures_'+@tblNmDel+' DROP COLUMN ['+@champsDel+']';
			execute(@sqlDel);
			--Table Mvt_X
			set @sqlDel='ALTER TABLE Mvt_'+@tblNmDel+' DROP COLUMN ['+@champsDel+']';
			execute(@sqlDel)
			--Fetching cursor
			fetch next from cursDel
			into @champsDel,@tabDel;
		end
		close cursDel;deallocate cursDel;
	end
END
go
--Stored Procedures
Create procedure sp_addStruct --Ajouter via stored procedure pour le reglage d'ID(Structures)
(@champs varchar(255),@Type varchar(10),
@Taille int,@Comptabiliser int,
@Critere int,@Developper int,
@Date int,@Cle int,@Date_Maj int,
@Impression int,@Code_Table int,
@Nom_Fonctionnel nvarchar(255))
as
BEGIN
	declare @newId int=(select ISNULL(max(id)+1,1)from Structures where code_table=@Code_Table);
	insert into Structures values
	(@champs,@Type,@Taille,@Nom_Fonctionnel,@Comptabiliser,@Critere,@Developper,@Date,@Cle,@Date_Maj
	,@Impression,@newId,@Code_Table);
END
go
Create procedure sp_editStruct --modification du strcture
(@ancienChamps varchar(255),@ancienCode_Table int,
@champs varchar(255),@Type varchar(10),
@Taille int,@Comptabiliser int,
@Critere int,@Developper int,
@Date int,@Cle int,@Date_Maj int,
@Impression int,@Code_Table int,
@Nom_Fonctionnel nvarchar(255))
as
BEGIN
	IF @ancienCode_Table!=@Code_Table--si la table est changée
	begin
		declare @newId int=(select ISNULL(max(id)+1,1)from Structures where code_table=@Code_Table);
		update Structures set Champs=@champs,Type=@Type,Taille=@Taille,Comptabiliser=@Comptabiliser,
		Critere=@Critere,Developper=@Developper,Date=@Date,Cle=@Cle,Date_Maj=@Date_Maj,
		Impression=@Impression,Id=@newId,Code_Table=@Code_Table,Nom_Fonctionnel=@Nom_Fonctionnel
		where Champs=@ancienChamps and Code_Table=@ancienCode_Table;
	end
	ELSE
		update Structures set Champs=@champs,Type=@Type,Taille=@Taille,Comptabiliser=@Comptabiliser,
		Critere=@Critere,Developper=@Developper,Date=@Date,Cle=@Cle,Date_Maj=@Date_Maj,
		Impression=@Impression,Code_Table=@Code_Table,Nom_Fonctionnel=@Nom_Fonctionnel
		where Champs=@ancienChamps and Code_Table=@ancienCode_Table;
END
go
Create procedure sp_deleteStruct --Supression d'une structure
(@champs varchar(255),@Code_Table int)
as
BEGIN
	declare @itemId int=(select id from Structures where Champs=@champs and Code_Table=@Code_Table);
	--supprimmer la ligne et faire un retour en arriere au IDs pour tous les champs du meme table.
	delete from Structures where Champs=@champs and Code_Table=@Code_Table;
	update Structures set id-=1 where Code_Table=@Code_Table and Id>@itemId;
END
go
--Insertions
insert into Authentication values('user1','pass1');
insert into Authentication values('user2','pass2');
go
insert into Connexions_Systems values('Vectis','MSSQLSERVER','.','VECTIS','sa','tdi');
insert into Connexions_Systems values('Vectis Maintenance','MSSQLSERVER','192.168.1.50','VECTIS_MNT','sa','tdi');
insert into Connexions_Systems values('TestOrcl','ORACLE','/poste4/ac','praxis','system','123456');
go
insert into Tables_Sorties values('Facturations',1);
insert into Tables_Sorties values('Clients',1);
insert into Tables_Sorties values('Mouvement',2);
--Il manque les insertions des conditions, je l'ai fait par Excel
go
use INTERMEDIAIRE;
select * from Authentication;
select * from Connexions_Systems;
select * from Tables_Sorties;
select * from Structures order by Id;
select * from Conditions;
select * from Ecritures_Facturations;
select * from Mvt_Facturations;
--go
----insertion Creation des views pour les evenement
----l'evenement Facturation qui est disponible pour le moment qui est disponible
--use VECTIS;
--go
--create view vFacturations
--as
--select date_operation,dateFacture,date_paiment,id_client,montant_paye,montant_total,nom,num_contrat_cli,num_contrat_fact,
--	   prix,qte,ref_facture,tax,type,type_operation
--from Client cli,DetailFacture detFact,Encaissement enc,Paiment pmnt,Facture fact
--where cli.id_client=fact.client and fact.ref_facture=enc.facture and
--	  detFact.facture=fact.ref_facture and pmnt.facture=fact.ref_facture