using Kerry.Sync.Data.Constants;
using Kerry.Sync.Data.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kerry.WebService.Common
{
    public class DBFactory
    {
        public DBFactory()
        {
            this.DB_K3 = new DbHelper(SysConstants.K3_DB_CONNECTION, SysConstants.ORACE_PROVIDER);
            this.DB_K35 = new DbHelper(SysConstants.K35_DB_CONNECTION, SysConstants.MYSQL_PROVIDER);
        }
        public DbHelper DB_K3 { get; set; }
        public DbHelper DB_K35 { get; set; }
    }
}