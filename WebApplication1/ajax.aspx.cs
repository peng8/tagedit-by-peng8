using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class ajax : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string action = string.Empty;
            action = Request["action"] != null ? Request["action"] : string.Empty;
            switch (action)
            {
                case "getData":
                    getData();
                    break;
                case "deleteData":
                    deleData();
                    break;
                default:
                    break;
            }
        }
        private void deleData() {
            
            Response.Write("{ \"success\":true, \"allowDelete\": true}");
            Response.End();
        }
        private void getData() {
            StringBuilder json = new StringBuilder();
            json.Append("[");
            for (int i = 1; i < 100; i++)
            {
                json.Append("{\"id\":\"" + i+ "\",\"label\":\"" + Request["term"].ToString()+ "--peng--" + i+ "\",\"value\":\"" + Request["term"].ToString() + "--peng--" + i + "\"}");
                if (i <99)
                {
                    json.Append(",");
                }
            }
            json.Append("]");
            Response.Write(json.ToString());
            Response.End();
        }
    }
}