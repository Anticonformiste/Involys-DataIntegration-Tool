using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Involys.Pocos;
using Involys.DataAccess.Connectors;
using Involys.Utility;

namespace Involys.DataAccess.Services
{
    public class ServiceConditions : ServiceMetier
    {
        public List<Condition> GetAll()
        {
            var liste = new List<Condition>();
            try
            {
                var cnx = Connector.GetConnection();
                var cmd = cnx.CreateCommand();
                cmd.CommandText = @"select * from Conditions";
                cnx.Open();
                var dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    var obj = new Condition();
                    obj.Ref_Util = (!dr.IsDBNull(0)) ? dr.GetInt32(0) : 0;
                    obj.Code_Fils = (!dr.IsDBNull(1)) ? dr.GetInt32(1) : 0;
                    obj.Libelle = dr[2].ToString();
                    obj.Code_Pere = (!dr.IsDBNull(3))?dr.GetInt32(3):0;
                    obj.Type = dr[4].ToString();
                    obj.Selection = dr[5].ToString();
                    obj.Niveau = (!dr.IsDBNull(6)) ? dr.GetInt32(6) : 0;
                    obj.Requete = dr[7].ToString();
                    obj.Valeur = dr[8].ToString();
                    obj.TableTmp = dr[9].ToString();
                    obj.NumEcriture = (!dr.IsDBNull(10)) ? dr.GetInt32(10) : 0;
                    obj.Cle = dr[11].ToString();
                    obj.Form = dr[12].ToString();
                    obj.CodeTable = (!dr.IsDBNull(13)) ? dr.GetInt32(13) : 0;
                    liste.Add(obj);
                }
                cnx.Close();
                return liste;
            }
            catch (Exception)
            { return null; }
        }

        public List<Condition> GetByRef(int ref_util)
        {
            var liste = new List<Condition>();
            try
            {
                var cnx = Connector.GetConnection();
                var cmd = cnx.CreateCommand();
                cmd.CommandText = @"select * from Conditions where Ref_util=@ref";
                DatasUtility.AddParameterWithValue(cmd, "@ref", ref_util);
                cnx.Open();
                var dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    var obj = new Condition();
                    obj.Ref_Util = (!dr.IsDBNull(0)) ? dr.GetInt32(0) : 0;
                    obj.Code_Fils = (!dr.IsDBNull(1)) ? dr.GetInt32(1) : 0;
                    obj.Libelle = dr[2].ToString();
                    obj.Code_Pere = (!dr.IsDBNull(3)) ? dr.GetInt32(3) : 0;
                    obj.Type = dr[4].ToString();
                    obj.Selection = dr[5].ToString();
                    obj.Niveau = (!dr.IsDBNull(6)) ? dr.GetInt32(6) : 0;
                    obj.Requete = dr[7].ToString();
                    obj.Valeur = dr[8].ToString();
                    obj.TableTmp = dr[9].ToString();
                    obj.NumEcriture = (!dr.IsDBNull(10)) ? dr.GetInt32(10) : 0;
                    obj.Cle = dr[11].ToString();
                    obj.Form = dr[12].ToString();
                    obj.CodeTable = (!dr.IsDBNull(13)) ? dr.GetInt32(13) : 0;
                    liste.Add(obj);
                }
                cnx.Close();
                return liste;
            }
            catch (Exception)
            { return null; }
        }

        public List<Condition> GetByType(string type)
        {
            var liste = new List<Condition>();
            try
            {
                var cnx = Connector.GetConnection();
                var cmd = cnx.CreateCommand();
                cmd.CommandText = @"select * from Conditions where Type=@ty";
                DatasUtility.AddParameterWithValue(cmd, "@ty", type);
                cnx.Open();
                var dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    var obj = new Condition();
                    obj.Ref_Util = (!dr.IsDBNull(0)) ? dr.GetInt32(0) : 0;
                    obj.Code_Fils = (!dr.IsDBNull(1)) ? dr.GetInt32(1) : 0;
                    obj.Libelle = dr[2].ToString();
                    obj.Code_Pere = (!dr.IsDBNull(3)) ? dr.GetInt32(3) : 0;
                    obj.Type = dr[4].ToString();
                    obj.Selection = dr[5].ToString();
                    obj.Niveau = (!dr.IsDBNull(6)) ? dr.GetInt32(6) : 0;
                    obj.Requete = dr[7].ToString();
                    obj.Valeur = dr[8].ToString();
                    obj.TableTmp = dr[9].ToString();
                    obj.NumEcriture = (!dr.IsDBNull(10)) ? dr.GetInt32(10) : 0;
                    obj.Cle = dr[11].ToString();
                    obj.Form = dr[12].ToString();
                    obj.CodeTable = (!dr.IsDBNull(13)) ? dr.GetInt32(13) : 0;
                    liste.Add(obj);
                }
                cnx.Close();
                return liste;
            }
            catch (Exception)
            { return null; }
        }

        public List<Condition> GetByEvenement(int even)
        {
            var liste = new List<Condition>();
            try
            {
                var cnx = Connector.GetConnection();
                var cmd = cnx.CreateCommand();
                cmd.CommandText = @"select * from Conditions where Code_table=@ev";
                DatasUtility.AddParameterWithValue(cmd, "@ev", even);
                cnx.Open();
                var dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    var obj = new Condition();
                    obj.Ref_Util = (!dr.IsDBNull(0)) ? dr.GetInt32(0) : 0;
                    obj.Code_Fils = (!dr.IsDBNull(1)) ? dr.GetInt32(1) : 0;
                    obj.Libelle = dr[2].ToString();
                    obj.Code_Pere = (!dr.IsDBNull(3)) ? dr.GetInt32(3) : 0;
                    obj.Type = dr[4].ToString();
                    obj.Selection = dr[5].ToString();
                    obj.Niveau = (!dr.IsDBNull(6)) ? dr.GetInt32(6) : 0;
                    obj.Requete = dr[7].ToString();
                    obj.Valeur = dr[8].ToString();
                    obj.TableTmp = dr[9].ToString();
                    obj.NumEcriture = (!dr.IsDBNull(10)) ? dr.GetInt32(10) : 0;
                    obj.Cle = dr[11].ToString();
                    obj.Form = dr[12].ToString();
                    obj.CodeTable = (!dr.IsDBNull(13)) ? dr.GetInt32(13) : 0;
                    liste.Add(obj);
                }
                cnx.Close();
                return liste;
            }
            catch (Exception)
            { return null; }
        }

        public int Ajouter(Condition obj)
        {
            //try
            //{
                var cnx = Connector.GetConnection();
                var cmd = cnx.CreateCommand();
                cmd.CommandText = @"insert into Conditions values(
                                  @ref,@fils,@lbl,@pere,@typ,@sel,@niv,@req,@val,@tmp,@ecr,@cle,@frm,@tab)";
                DatasUtility.AddParameterWithValue(cmd, "@ref", obj.Ref_Util);
                DatasUtility.AddParameterWithValue(cmd, "@fils", obj.Code_Fils);
                DatasUtility.AddParameterWithValue(cmd, "@lbl", obj.Libelle);
                DatasUtility.AddParameterWithValue(cmd, "@pere", obj.Code_Pere);
                DatasUtility.AddParameterWithValue(cmd, "@typ", obj.Type);
                DatasUtility.AddParameterWithValue(cmd, "@sel", obj.Selection == null ? (object)DBNull.Value : obj.Selection);
                DatasUtility.AddParameterWithValue(cmd, "@niv", obj.Niveau);
                DatasUtility.AddParameterWithValue(cmd, "@req", obj.Requete == null ? (object)DBNull.Value : obj.Requete);
                DatasUtility.AddParameterWithValue(cmd, "@val", obj.Valeur == null ? (object)DBNull.Value : obj.Valeur);
                DatasUtility.AddParameterWithValue(cmd, "@tmp", obj.TableTmp == null ? (object)DBNull.Value : obj.TableTmp);
                DatasUtility.AddParameterWithValue(cmd, "@ecr", obj.NumEcriture);
                DatasUtility.AddParameterWithValue(cmd, "@cle", obj.Cle == null ? (object)DBNull.Value : obj.Cle);
                DatasUtility.AddParameterWithValue(cmd, "@frm", obj.Form == null ? (object)DBNull.Value : obj.Form);
                DatasUtility.AddParameterWithValue(cmd, "@tab", obj.CodeTable == 0 ? (object)DBNull.Value : obj.CodeTable);
                cnx.Open();
                cmd.ExecuteNonQuery();
                cnx.Close();
                return 0;
            //}
            //catch (Exception)
            //{ return -1; }
        }

        public int Modifier(Condition obj)
        {
            //try
            //{
                var cnx = Connector.GetConnection();
                var cmd = cnx.CreateCommand();
                cmd.CommandText = @"update Conditions set 
                Libelle=@lbl,Code_pere=@pere,Type=@typ,Selection=@sel,Niveau=@niv,Req=@req,
                Valeur=@val,TableTmp=@tmp,Numecrit=@ecr,Cle=@cle,Form=@frm,Code_Table=@tab 
                where Ref_util=@ref and Code_fils=@fils";
                DatasUtility.AddParameterWithValue(cmd, "@ref", obj.Ref_Util);
                DatasUtility.AddParameterWithValue(cmd, "@fils", obj.Code_Fils);
                DatasUtility.AddParameterWithValue(cmd, "@lbl", obj.Libelle);
                DatasUtility.AddParameterWithValue(cmd, "@pere", obj.Code_Pere);
                DatasUtility.AddParameterWithValue(cmd, "@typ", obj.Type);
                DatasUtility.AddParameterWithValue(cmd, "@sel", obj.Selection == null ? (object)DBNull.Value : obj.Selection);
                DatasUtility.AddParameterWithValue(cmd, "@niv", obj.Niveau);
                DatasUtility.AddParameterWithValue(cmd, "@req", obj.Requete == null ? (object)DBNull.Value : obj.Requete);
                DatasUtility.AddParameterWithValue(cmd, "@val", obj.Valeur == null ? (object)DBNull.Value : obj.Valeur);
                DatasUtility.AddParameterWithValue(cmd, "@tmp", obj.TableTmp == null ? (object)DBNull.Value : obj.TableTmp);
                DatasUtility.AddParameterWithValue(cmd, "@ecr", obj.NumEcriture);
                DatasUtility.AddParameterWithValue(cmd, "@cle", obj.Cle == null ? (object)DBNull.Value : obj.Cle);
                DatasUtility.AddParameterWithValue(cmd, "@frm", obj.Form == null ? (object)DBNull.Value : obj.Form);
                DatasUtility.AddParameterWithValue(cmd, "@tab", obj.CodeTable == 0 ? (object)DBNull.Value : obj.CodeTable);
                cnx.Open();
                cmd.ExecuteNonQuery();
                cnx.Close();
                return 0;
            //}
            //catch (Exception)
            //{ return -1; }
        }

        public int Supprimer(int ref_util)
        {
            //try
            //{
                var cnx = Connector.GetConnection();
                var cmd = cnx.CreateCommand();
                cmd.CommandText = @"delete from Conditions 
                where Ref_util=@ref";
                DatasUtility.AddParameterWithValue(cmd, "@ref", ref_util);
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
