using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Involys.DataAccess.Connectors;

namespace Involys.DataAccess.Services
{
    public abstract class ServiceMetier
    {
        public DbConnector Connector { get; set; }
    }
}
