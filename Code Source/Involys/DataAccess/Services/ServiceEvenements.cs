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
    public class ServiceEvenements:ServiceMetier
    {
        private ServiceConnexionsSystemes servConSys;

        public ServiceEvenements()
        {
            servConSys = new ServiceConnexionsSystemes();
        }

        public List<Evenement> GetAll()
        {
            //try
            //{
                servConSys.Connector = Connector;
                var liste = new List<Evenement>();
                var allConSys = servConSys.GetAll();
                Evenement obj;
                var cnx = Connector.GetConnection();
                var cmd = cnx.CreateCommand();
                cmd.CommandText = "select * from Tables_Sorties";
                cnx.Open();
                var dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    obj = new Evenement();
                    obj.Code = dr.GetInt32(0);
                    obj.Libelle = dr[1].ToString();
                    obj.System = allConSys.Single(o => o.Code==dr.GetInt32(2));
                    liste.Add(obj);
                }
                return liste;
            //}
            //catch (Exception)
            //{ return null; }
        }

        public List<Evenement> GetBySystem(int sys)
        {
            //try
            //{
                servConSys.Connector = Connector;
                var liste = new List<Evenement>();
                var allConSys = servConSys.GetAll();
                Evenement obj;
                var cnx = Connector.GetConnection();
                var cmd = cnx.CreateCommand();
                cmd.CommandText = "select * from Tables_Sorties where system=@sys";
                DatasUtility.AddParameterWithValue(cmd, "@sys", sys);
                cnx.Open();
                var dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    obj = new Evenement();
                    obj.Code = dr.GetInt32(0);
                    obj.Libelle = dr[1].ToString();
                    obj.System = allConSys.Single(o => o.Code==dr.GetInt32(2));
                    liste.Add(obj);
                }
                return liste;
            //}
            //catch (Exception)
            //{ return null; }
        }

        public Evenement GetByCode(int code)
        {
            //try
            //{
                servConSys.Connector = Connector;
                Evenement obj=null;
                var allSystems = servConSys.GetAll();
                var cnx = Connector.GetConnection();
                var cmd = cnx.CreateCommand();
                cmd.CommandText = "select * from Tables_Sorties where code=@cd";
                DatasUtility.AddParameterWithValue(cmd, "@cd", code);
                cnx.Open();
                var dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    obj = new Evenement();
                    obj.Code = dr.GetInt32(0);
                    obj.Libelle = dr[1].ToString();
                    obj.System = allSystems.Single(o => o.Code == dr.GetInt32(0));
                }
                return obj;
            //}
            //catch (Exception)
            //{ return null; }
        }

        public int Ajouter(Evenement obj)
        {
            try
            {
                var cnx = Connector.GetConnection();
                var cmd = cnx.CreateCommand();
                cmd.CommandText = @"insert into Tables_Sorties values(@lbl,@sys)";
                DatasUtility.AddParameterWithValue(cmd, "@lbl", obj.Libelle);
                DatasUtility.AddParameterWithValue(cmd, "@sys", obj.System.Code);
                cnx.Open();
                cmd.ExecuteNonQuery();
                cnx.Close();
                return 0;
            }
            catch (Exception)
            { return 1; }
        }

        public int Modifier(Evenement obj)
        {
            try
            {
                var cnx = Connector.GetConnection();
                var cmd = cnx.CreateCommand();
                cmd.CommandText = @"update Tables_Sorties set Libelle=@lbl, System=@sys where code=@cd)";
                DatasUtility.AddParameterWithValue(cmd, "@cd", obj.Code);
                DatasUtility.AddParameterWithValue(cmd,"@lbl",obj.Libelle);
                DatasUtility.AddParameterWithValue(cmd, "@sys",obj.System.Code );
                cnx.Open();
                cmd.ExecuteNonQuery();
                cnx.Close();
                return 0;
            }
            catch (Exception)
            {return 1;}
        }

        public int Supprimer(int code)
        {
            try
            {
                var cnx = Connector.GetConnection();
                var cmd = cnx.CreateCommand();
                cmd.CommandText = @"delete from Tables_Sorties where code=@cd)";
                DatasUtility.AddParameterWithValue(cmd, "@cd", code);
                cnx.Open();
                cmd.ExecuteNonQuery();
                cnx.Close();
                return 0;
            }
            catch (Exception)
            { return 1; }
        }
    }
}
