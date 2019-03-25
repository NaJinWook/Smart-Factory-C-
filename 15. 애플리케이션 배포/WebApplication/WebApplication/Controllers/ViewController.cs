using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication.Modules;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication.Controllers
{
    public class ViewController : Controller
    {
        [Route("api/view")]
        [HttpGet]
        public ActionResult<string> view()
        {
            ArrayList list = new ArrayList();
            DataBase db = new DataBase(DataBaseInfo.TestDBInfo());
            string result = "";
            Hashtable resultMap = db.GetReader("select rNo, rName, rDesc from [Rule];");
            if (Convert.ToInt32(resultMap["MsgCode"]) == -1)
            {
                Console.WriteLine(resultMap["Msg"].ToString());
            }
            else
            {
                ArrayList resultList = (ArrayList)resultMap["Data"];
                foreach (string[] row in resultList)
                {
                    result += string.Format("rNo : {0}, rName : {1}, rDesc : {2}", row[0], row[1], row[2]);
                }
                Console.WriteLine(result);
            }
            return result;
        }
    }
}
