﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Involys.Properties {
    using System;
    
    
    /// <summary>
    ///   Une classe de ressource fortement typée destinée, entre autres, à la consultation des chaînes localisées.
    /// </summary>
    // Cette classe a été générée automatiquement par la classe StronglyTypedResourceBuilder
    // à l'aide d'un outil, tel que ResGen ou Visual Studio.
    // Pour ajouter ou supprimer un membre, modifiez votre fichier .ResX, puis réexécutez ResGen
    // avec l'option /str ou régénérez votre projet VS.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Retourne l'instance ResourceManager mise en cache utilisée par cette classe.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Involys.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Remplace la propriété CurrentUICulture du thread actuel pour toutes
        ///   les recherches de ressources à l'aide de cette classe de ressource fortement typée.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à IF NOT EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N&apos;[dbo].[$NmtempTable_Ajout]&apos;))
        ///Begin
        ///	declare @crTrg nvarchar(max)=&apos;CREATE TRIGGER [dbo].[$NmtempTable_Ajout] ON [dbo].[$NmtempTable] FOR INSERT AS
        ///	Begin
        ///		print&apos;&apos;Aucune Action, Il Va etre modifié&apos;&apos;;
        ///	End&apos;;
        ///	EXECUTE(@crTrg);
        ///End.
        /// </summary>
        internal static string checkTrigger {
            get {
                return ResourceManager.GetString("checkTrigger", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une ressource localisée de type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap inPic {
            get {
                object obj = ResourceManager.GetObject("inPic", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Recherche une ressource localisée de type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap logoApp {
            get {
                object obj = ResourceManager.GetObject("logoApp", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Recherche une ressource localisée de type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap outPic {
            get {
                object obj = ResourceManager.GetObject("outPic", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à ALTER TRIGGER [dbo].[$NmtempTable_Ajout] ON [dbo].[$NmtempTable] FOR INSERT AS
        ///BEGIN
        ///declare @codf nvarchar(10);
        ///
        ///declare @codf1 nvarchar(10);
        ///
        ///declare @req nvarchar(2000);
        ///
        ///declare @numecr nvarchar(20);
        ///
        ///declare @typ nvarchar(40);
        ///
        ///declare @v nvarchar(40);
        ///
        ///declare @i int;
        ///
        ///declare @nrow int;
        ///
        ///declare @curentrow int;
        ///
        ///declare @SEL nvarchar(6);
        ///
        ///declare @req1 nvarchar(2000);
        ///
        ///declare @req2 nvarchar(2000);
        ///
        ///declare @req3 nvarchar(2000);
        ///
        ///declare @req4 nvarchar(2000);
        ///
        ///declare @N [le reste de la chaîne a été tronqué]&quot;;.
        /// </summary>
        internal static string trigger {
            get {
                return ResourceManager.GetString("trigger", resourceCulture);
            }
        }
    }
}