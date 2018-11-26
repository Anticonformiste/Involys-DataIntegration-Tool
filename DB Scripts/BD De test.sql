use master;
go
if exists(select * from sys.databases where name='VECTIS')
	drop database VECTIS;
go
create database VECTIS;
go
use VECTIS;
set dateformat DMY;
go
create table Auth(id_auth int identity(1,1)
				  constraint pk_auth primary key,
				  username varchar(10) not null unique, 
				  mdp varchar(20) not null,
				  email varchar(255) not null unique
				  constraint ck_mail check(email like '%@%.%'));
go
create table Compte(id_compte int identity(1,1)
					constraint pk_compte primary key,
					date_creation date not null default convert(date,getdate()),
					auth int not null
					constraint fk_compte_auth foreign key references Auth(id_auth));
go
create table Client(id_client int identity(1,1)
					 constraint pk_client primary key,
					 num_contrat_cli int not null unique,
					 nom varchar(max) not null,
					 type varchar(15) not null
					 constraint ck_type_client check(type in('Entreprise','Etat')),
					 compte int not null
					 constraint fk_client_compte foreign key references Compte(id_compte));
go
create table Facture(ref_facture int identity(1,1)
					 constraint pk_facture primary key,
					 num_contrat_fact int not null unique,
					 dateFacture date not null default convert(date,getdate()),
					 client int
					 constraint fk_facture_client foreign key references Client(id_client));
go
create table DetailFacture(facture int
						   constraint pk_details primary key
						   constraint fk_fact_det foreign key references Facture(ref_facture),
						   qte int not null
						   constraint ck_qte check(qte > 0),
						   prix money not null,
						   tax money not null default 0
						   constraint ck_tax check(tax > 0));
go
create table Encaissement(facture int
						  constraint pk_encaissement primary key
						  constraint fk_fact_enc foreign key references Facture(ref_facture),
						  montant_paye money not null
						  constraint ck_mont_enc check(montant_paye>0),
						  date_operation date not null default convert(date, getdate()),
						  type_operation varchar(max) not null);
go
create table Paiment(facture int
					 constraint pk_paiment primary key
					 constraint fk_paim_fact foreign key references Facture(ref_facture),
					 date_paiment date not null default convert(date, getdate()),
					 montant_total money not null);
go