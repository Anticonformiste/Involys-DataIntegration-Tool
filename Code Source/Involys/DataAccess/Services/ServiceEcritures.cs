using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Involys.DataAccess.Connectors;
using Involys.Pocos;
using Involys.Utility;

namespace Involys.DataAccess.Services
{
    public class ServiceEcritures:ServiceMetier
    {
        private ServiceStructures servStruct;

        public ServiceEcritures()
        {
            servStruct = new ServiceStructures();
        }


        public List<Ecriture> GetByEvent(Evenement evenement)
        {
            servStruct.Connector = this.Connector;
            var structures = servStruct.GetByEvenement(evenement.Code);
            List<Ecriture> liste = new List<Ecriture>();
            Ecriture obj;
            List<ColumnEcriture> colsEcr = new List<ColumnEcriture>();
            //try
            //{
                var cnx = Connector.GetConnection();
                var cmd = cnx.CreateCommand();
                cmd.CommandText = string.Format("select * from Ecritures_{0}",evenement.Libelle);
                Connector.GetConnection().Open();
                var dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    obj = new Ecriture();
                    obj.Cle = dr.GetInt32(0);
                    obj.Numero = dr.GetInt32(1);
                    obj.Condition = dr[2].ToString();
                    //Les colonnes
                    foreach (var item in structures)
                    {
                        colsEcr.Add(new ColumnEcriture{Champs=item, Requette=dr[item.Champs].ToString()});   
                    }
                    obj.Colonnes = colsEcr;
                    liste.Add(obj);
                }
                cnx.Close();
                return liste;
            //}
            //catch (Exception)
            //{ return null; }
        }

        public List<Ecriture> GetByCondition(Evenement evenement,Condition condi)
        {
            servStruct.Connector = this.Connector;
            var structures = servStruct.GetByEvenement(evenement.Code);
            List<Ecriture> liste = new List<Ecriture>();
            Ecriture obj;
            List<ColumnEcriture> colsEcr;
            //try
            //{
            var cnx = Connector.GetConnection();
            var cmd = cnx.CreateCommand();
            cmd.CommandText = string.Format("select * from Ecritures_{0} where numecrit={1}",
                              evenement.Libelle, condi.NumEcriture);
            cnx.Open();
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                obj = new Ecriture();
                colsEcr = new List<ColumnEcriture>();
                obj.Cle = dr.GetInt32(0);
                obj.Numero = dr.GetInt32(1);
                obj.Condition = dr[2].ToString();
                //Les colonnes
                foreach (var item in structures)
                {
                    colsEcr.Add(new ColumnEcriture { Champs = item, Requette = dr[item.Champs].ToString() });
                }
                obj.Colonnes = colsEcr;
                liste.Add(obj);
            }
            cnx.Close();
            return liste;
            //}
            //catch (Exception)
            //{ return null; }
        }

        public bool IsExist(Ecriture ecr, Evenement evenement)
        {
            var cnx = Connector.GetConnection();
            var cmd = cnx.CreateCommand();
            var sql = string.Format("select 1 from Ecritures_{0} where cleecrit=@cle", evenement.Libelle);
            DatasUtility.AddParameterWithValue(cmd,"@cle",ecr.Cle);
            cnx.Open();
            try
            {
                int rslt = (int)cmd.ExecuteScalar();
                cnx.Close(); return true;
            }
            catch (Exception)
            {
                cnx.Close(); return false;
            }
        }

        public int Ajouter(Ecriture obj, Evenement evenement)
        {
            //try
            //{
                var cnx = Connector.GetConnection();
                var cmd = cnx.CreateCommand();
                var sql = string.Format("insert into Ecritures_{0}(cleecrit,numecrit,condition",evenement.Libelle);
                StringBuilder sb = new StringBuilder();
                foreach (var item in obj.Colonnes)
                {
                    sb.Append(",");
                    sb.Append(item.Champs.Champs);
                }
                sb.Append(") values(@cleecrit,@numecrit,@condition");
                foreach (var item in obj.Colonnes)
                {
                    sb.Append(",");
                    sb.Append(string.Format("@{0}",item.Champs.Champs));
                }
                sb.Append(")");
                sql += sb.ToString();
                cmd.CommandText = sql;
                //remplissage des parametres
                DatasUtility.AddParameterWithValue(cmd, "@cleecrit",obj.Cle);
                DatasUtility.AddParameterWithValue(cmd, "@numecrit", obj.Numero);
                DatasUtility.AddParameterWithValue(cmd, "@condition", obj.Condition == null ? (object)DBNull.Value : obj.Condition);
                foreach (var item in obj.Colonnes)
                {
                    DatasUtility.AddParameterWithValue(cmd, string.Format("@{0}", item.Champs.Champs), item.Requette);   
                }
                cnx.Open();
                cmd.ExecuteNonQuery();
                cnx.Close();
                return 0;
            //}
            //catch (Exception)
            //{ return 1; }
        }

        //I'm here
        public int Modifier(Ecriture obj, Evenement evenement)
        {
            //try
            //{
            var cnx = Connector.GetConnection();
            var cmd = cnx.CreateCommand();
            var sql = string.Format("update Ecritures_{0} set condition=@condition", evenement.Libelle);
            StringBuilder sb = new StringBuilder();
            foreach (var item in obj.Colonnes)
            {
                sb.Append(",");
                sb.Append(item.Champs.Champs);
                sb.Append(string.Format("=@{0}",item.Champs.Champs));
            }
            sb.Append(" where cleecrit=@cleecrit and numecrit=@numecrit");
            sql += sb.ToString();
            cmd.CommandText = sql;
            //remplissage des parametres
            DatasUtility.AddParameterWithValue(cmd, "@cleecrit", obj.Cle);
            DatasUtility.AddParameterWithValue(cmd, "@numecrit", obj.Numero);
            DatasUtility.AddParameterWithValue(cmd, "@condition", obj.Condition);
            foreach (var item in obj.Colonnes)
            {
                DatasUtility.AddParameterWithValue(cmd, "@" + item.Champs.Champs, item.Requette);
            }
            cnx.Open();
                System.Windows.Forms.MessageBox.Show(cmd.CommandText);
            cnx.Close();
            return 0;
            //}
            //catch (Exception)
            //{ return 1; }
        }
    }
}
