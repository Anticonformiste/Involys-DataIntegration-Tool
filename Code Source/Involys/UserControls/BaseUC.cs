using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using MetroFramework.Controls;

using Involys.DataAccess.Connectors;

namespace Involys.UserControls
{
    public class BaseUC:MetroUserControl
    {
        public DbConnector Connector { get; set; }

        public virtual void Recharger() { }//Methode Pour invoker des chargement depuis les classes en associations
    }
}
