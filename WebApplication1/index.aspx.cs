using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
            }
        }

        protected void save_Click(object sender, EventArgs e)
        {
            StringBuilder shtml = new StringBuilder();
            shtml.Append("<ul>");
            if (Request.Form.AllKeys.Length != 0)
            {
                string[] formArray = Request.Form.AllKeys;
                foreach (string key in formArray) {
                    if (key.Contains("tag[")) {
                        shtml.Append( "<li>key:"+key+";value:"+Request.Form[key]+"</li>");
                    }
                }
            }
            shtml.Append("</ul>");
            Literal1.Text = shtml.ToString();
        }
    }
}