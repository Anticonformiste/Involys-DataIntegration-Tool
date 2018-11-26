using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

using Involys.Pocos;
using Involys.DataAccess.Connectors;
using Involys.Utility;

namespace Involys.DataAccess.Services
{
    public class ServiceConnexionsSystemes:ServiceMetier
    {
        public List<ConnexionSysteme> GetAll()
        {
            var liste = new List<ConnexionSysteme>();
            //try
            //{
                ConnexionSysteme obj;
                var cnx = Connector.GetConnection();
                var cmd = cnx.CreateCommand();
                cmd.CommandText = "select * from Connexions_Systems";
                cnx.Open();
                var dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    obj = new ConnexionSysteme();
                    obj.Code = dr.GetInt32(0);
                    obj.Libelle = dr[1].ToString();
                    obj.ServerType = dr[2].ToString();
                    obj.CnxHelper.Server = dr[3].ToString();
                    obj.CnxHelper.Database = dr[4].ToString();
                    obj.CnxHelper.Username = dr[5].ToString();
                    obj.CnxHelper.Password = dr[6].ToString();
                    liste.Add(obj);
                }
                cnx.Close();
                return liste;
            //}
            //catch (Exception)
            //{return null;}
            
        }

        public ConnexionSysteme GetById(int id)
        {
            //try
            //{
                ConnexionSysteme obj = null;
                var cnx = Connector.GetConnection();
                var cmd = cnx.CreateCommand();
                cmd.CommandText = "select * from Connexions_Systems Where Code=@cd";
                DatasUtility.AddParameterWithValue(cmd, "@cd", id);
                cnx.Open();
                var dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    obj = new ConnexionSysteme();
                    obj.Code = dr.GetInt32(0);
                    obj.Libelle = dr[1].ToString();
                    obj.ServerType = dr[2].ToString();
                    obj.CnxHelper.Server = dr[3].ToString();
                    obj.CnxHelper.Database = dr[4].ToString();
                    obj.CnxHelper.Username = dr[5].ToString();
                    obj.CnxHelper.Password = dr[6].ToString();
                }
                return obj;
            //}
            //catch (Exception)
            //{}
            //return null;
        }

        public List<ConnexionSysteme> GetByServerType(string serverType)
        {
            var liste = new List<ConnexionSysteme>();
            ConnexionSysteme obj;
            var cnx = Connector.GetConnection();
            var cmd = cnx.CreateCommand();
            cmd.CommandText = "select * from Connexions_Systems Where TypeServeur=@ts";
            DatasUtility.AddParameterWithValue(cmd,"@ts",serverType);
            cnx.Open();
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                obj = new ConnexionSysteme();
                obj.Code = dr.GetInt32(0);
                obj.Libelle = dr[1].ToString();
                obj.ServerType = dr[2].ToString();
                obj.CnxHelper.Server = dr[3].ToString();
                obj.CnxHelper.Database = dr[4].ToString();
                obj.CnxHelper.Username = dr[5].ToString();
                obj.CnxHelper.Password = dr[6].ToString();
                liste.Add(obj);
            }
            cnx.Close();
            return liste;
        }

        public int Ajouter(ConnexionSysteme obj)
        {
            var cnx = Connector.GetConnection();
            var cmd = cnx.CreateCommand();
            cmd.CommandText = @"insert into Connexions_Systems values(
                                @lbl,@ts,@sr,@db,@user,@pass)";
            DatasUtility.AddParameterWithValue(cmd,"@lbl",obj.Libelle);
            DatasUtility.AddParameterWithValue(cmd, "@ts",obj.ServerType );
            DatasUtility.AddParameterWithValue(cmd, "@sr",obj.CnxHelper.Server );
            DatasUtility.AddParameterWithValue(cmd, "@db",obj.CnxHelper.Database );
            DatasUtility.AddParameterWithValue(cmd, "@user",obj.CnxHelper.Username );
            DatasUtility.AddParameterWithValue(cmd, "@pass", obj.CnxHelper.Password);
            cnx.Open();
            cmd.ExecuteNonQuery();
            cnx.Close();
            return 0;
        }

        public int Modifier(ConnexionSysteme obj)
        {
            try
            {
                var cnx = Connector.GetConnection();
                var cmd = cnx.CreateCommand();
                cmd.CommandText = @"update Connexions_Systems set Libelle=@lbl,
                                TypeServeur=@ts,Serveur=@sr,DB_Nom=@db,Username=@user,Password=@pass
                                Where  Code=@cd";
                DatasUtility.AddParameterWithValue(cmd, "@cd", obj.Code);
                DatasUtility.AddParameterWithValue(cmd, "@lbl", obj.Libelle);
                DatasUtility.AddParameterWithValue(cmd, "@ts", obj.ServerType);
                DatasUtility.AddParameterWithValue(cmd, "@sr", obj.CnxHelper.Server);
                DatasUtility.AddParameterWithValue(cmd, "@db", obj.CnxHelper.Database);
                DatasUtility.AddParameterWithValue(cmd, "@user", obj.CnxHelper.Username);
                DatasUtility.AddParameterWithValue(cmd, "@pass", obj.CnxHelper.Password);
                cnx.Open();
                cmd.ExecuteNonQuery();
                cnx.Close();
                return 0;
            }
            catch (Exception)
            {}
            return 1;
        }

        public int Supprimer(int id)
        {
            try
            {
                var cnx = Connector.GetConnection();
                var cmd = cnx.CreateCommand();
                cmd.CommandText = "delete from Connexions_Systems where Code=@cd";
                DatasUtility.AddParameterWithValue(cmd, "@cd", id);
                cnx.Open();
                cmd.ExecuteNonQuery();
                cnx.Close();
                return 0;
            }
            catch (Exception)
            {}
            return 1;
        }
    }
}
