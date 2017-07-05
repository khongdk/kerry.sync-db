using Kerry.WebService.Common;
using Kerry.WebService.Model;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Kerry.WebService.Operation
{
    /// <summary>
    /// Summary description for VesselMgr
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class VesselMgr : System.Web.Services.WebService
    {
        private DBFactory _db = new DBFactory();

        [WebMethod]
        public string VesselM()
        {
            var result=GetVesselData(); 
            return "Hello World";
        }
        private List<VesselModel> GetVesselData()
        {
            var sql = "select vesselcode,vesselname,carriercode,regctry from fmvesselmaster  ";
            DbCommand dc = _db.DB_K3.GetSqlStringCommond(sql);
            var dt = _db.DB_K3.ExecuteDataTable(dc);
            List<VesselModel> models = EntityToModel(dt);
            return models;
        }
        private static List<VesselModel> EntityToModel(System.Data.DataTable dt)
        {
            var models = new List<VesselModel>();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                models.Add(
                    new VesselModel
                    {
                        vesselCode = dt.Rows[i]["VESSELCODE"].ToString(),
                        vesselName = dt.Rows[i]["VESSELNAME"].ToString(),
                        companyCode = dt.Rows[i]["CARRIERCODE"].ToString(),
                        regCountryCode = dt.Rows[i]["REGCTRY"].ToString(),
                    }
                    );
            }

            return models;
        }
    }
}
