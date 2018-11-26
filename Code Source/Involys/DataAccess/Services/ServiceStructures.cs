using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Involys.DataAccess.Connectors;
using Involys.Pocos;
using Involys.Utility;
using System.Data;

namespace Involys.DataAccess.Services
{
    public class ServiceStructures:ServiceMetier
    {
        private ServiceEvenements servEvents;
        
        public ServiceStructures()
        {
            servEvents = new ServiceEvenements();
        }

        public List<Parametre> GetAll()
        {
            servEvents.Connector = Connector;
            var liste = new List<Parametre>();
            var allEvents = servEvents.GetAll();
            //try
            //{
                Parametre obj;
                var cmd = Connector.GetConnection().CreateCommand();
                cmd.CommandText = "select * from Structures";
                Connector.GetConnection().Open();
                var dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    obj = new Parametre();
                    //Linker les champs du DR avec un objet parametres
                    obj.Champs = dr[0].ToString();
                    obj.Type = dr[1].ToString();
                    obj.Taille = dr.GetInt32(2);
                    obj.NomFonctionnel = dr[3].ToString();
                    obj.Comptabiliser = dr.GetInt32(4);
                    obj.Critere = dr.GetInt32(5);
                    obj.Developper = dr.GetInt32(6);
                    obj.Date = dr.GetInt32(7);
                    obj.Cle = dr.GetInt32(8);
                    obj.DatMaj = dr.GetInt32(9);
                    obj.Impression = dr.GetInt32(10);
                    obj.Id = dr.GetInt32(11);
                    obj.Evenement = allEvents.Single(o => o.Code==dr.GetInt32(12));
                    //ajouter à la liste
                    liste.Add(obj);
                }
                return liste;
            //}
            //catch (Exception)
            //{ return null; }
        }

        public List<Parametre> GetByEvenement (int even)
        {
            servEvents.Connector = Connector;
            List<Parametre> liste = new List<Parametre>();
            var allEvents = servEvents.GetAll();
            //try
            //{
                Parametre obj;
                var cmd = Connector.GetConnection().CreateCommand();
                cmd.CommandText = "select * from Structures where Code_Table=@even";
                DatasUtility.AddParameterWithValue(cmd, "@even", even);
                Connector.GetConnection().Open();
                var dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    obj = new Parametre();
                    //Linker les champs du DR avec un objet parametres
                    obj.Champs = dr[0].ToString();
                    obj.Type = dr[1].ToString();
                    obj.Taille = dr.GetInt32(2); ;
                    obj.NomFonctionnel = dr[3].ToString();
                    obj.Comptabiliser = dr.GetInt32(4);
                    obj.Critere = dr.GetInt32(5);
                    obj.Developper = dr.GetInt32(6);
                    obj.Date = dr.GetInt32(7);
                    obj.Cle = dr.GetInt32(8);
                    obj.DatMaj = dr.GetInt32(9);
                    obj.Impression = dr.GetInt32(10);
                    obj.Id = dr.GetInt32(11);
                    obj.Evenement = allEvents.Single(o => o.Code==dr.GetInt32(12));
                    //ajouter à la liste
                    liste.Add(obj);
                }
                return liste;
            //}
            //catch (Exception)
            //{ return null; }
        }

        public int Ajouter(Parametre obj)
        {
            try
            {
                var cnx = Connector.GetConnection();
                var cmd = cnx.CreateCommand();
                cmd.CommandText = @"sp_addStruct";
                cmd.CommandType = CommandType.StoredProcedure;
                DatasUtility.AddParameterWithValue(cmd, "@champs", obj.Champs);
                DatasUtility.AddParameterWithValue(cmd, "@Type", obj.Type);
                DatasUtility.AddParameterWithValue(cmd, "@Taille", obj.Taille);
                DatasUtility.AddParameterWithValue(cmd, "@Comptabiliser", obj.Comptabiliser);
                DatasUtility.AddParameterWithValue(cmd, "@Critere", obj.Critere);
                DatasUtility.AddParameterWithValue(cmd, "@Developper", obj.Developper);
                DatasUtility.AddParameterWithValue(cmd, "@Date", obj.Date);
                DatasUtility.AddParameterWithValue(cmd, "@Cle", obj.Cle);
                DatasUtility.AddParameterWithValue(cmd, "@Date_Maj", obj.DatMaj);
                DatasUtility.AddParameterWithValue(cmd, "@Impression", obj.Impression);
                DatasUtility.AddParameterWithValue(cmd, "@Code_Table", obj.Evenement.Code);
                DatasUtility.AddParameterWithValue(cmd, "@Nom_Fonctionnel", obj.NomFonctionnel);
                cnx.Open();
                cmd.ExecuteNonQuery();
                cnx.Close();
                return 0;
            }
            catch (Exception)
            { return 1; }
        }

        public int Modifier(Parametre obj,Parametre ancien)
        {
            //try
            //{
                var cnx = Connector.GetConnection();
                var cmd = cnx.CreateCommand();
                cmd.CommandText = @"sp_editStruct";
                cmd.CommandType = CommandType.StoredProcedure;
                DatasUtility.AddParameterWithValue(cmd, "@ancienChamps",ancien.Champs);
                DatasUtility.AddParameterWithValue(cmd, "@ancienCode_Table", ancien.Evenement.Code);
                DatasUtility.AddParameterWithValue(cmd, "@champs", obj.Champs);
                DatasUtility.AddParameterWithValue(cmd, "@Type", obj.Type);
                DatasUtility.AddParameterWithValue(cmd, "@Taille", obj.Taille);
                DatasUtility.AddParameterWithValue(cmd, "@Comptabiliser", obj.Comptabiliser);
                DatasUtility.AddParameterWithValue(cmd, "@Critere", obj.Critere);
                DatasUtility.AddParameterWithValue(cmd, "@Developper", obj.Developper);
                DatasUtility.AddParameterWithValue(cmd, "@Date", obj.Date);
                DatasUtility.AddParameterWithValue(cmd, "@Cle", obj.Cle);
                DatasUtility.AddParameterWithValue(cmd, "@Date_Maj", obj.DatMaj);
                DatasUtility.AddParameterWithValue(cmd, "@Impression", obj.Impression);
                DatasUtility.AddParameterWithValue(cmd, "@Code_Table", obj.Evenement.Code);
                DatasUtility.AddParameterWithValue(cmd, "@Nom_Fonctionnel", obj.NomFonctionnel);
                cnx.Open();
                cmd.ExecuteNonQuery();
                cnx.Close();
                return 0;
            //}
            //catch (Exception)
            //{ return 1; }
        }

        public int Supprimer(Parametre obj)
        {
            try
            {
                var cnx = Connector.GetConnection();
                var cmd = cnx.CreateCommand();
                cmd.CommandText = @"sp_deleteStruct";
                cmd.CommandType = CommandType.StoredProcedure;
                DatasUtility.AddParameterWithValue(cmd, "@champs", obj.Champs);
                DatasUtility.AddParameterWithValue(cmd, "@Code_Table", obj.Evenement.Code);
                cnx.Open();
                cmd.ExecuteNonQuery();
                cnx.Close();
                return 0;
            }
            catch (Exception)
            { return 1; }
        }

        public int Clear()
        {
            //try
            //{
                var cnx = Connector.GetConnection();
                var cmd = cnx.CreateCommand();
                cmd.CommandText = "delete from Structures";
                cnx.Open();
                cmd.ExecuteNonQuery();
                cnx.Close();
                return 0;
            //}
            //catch (Exception)
            //{ return 1; }
        }
    }
}
