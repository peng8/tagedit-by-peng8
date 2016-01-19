using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class index2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string a1 ="<a href=\"www.peng8.net\">鹏吧</a>";
            string a2 = "<a href=\"www.peng8.net\" ><span title='我是码农'>我要开始搬砖了...</span></a>";

            Regex r = new Regex(@"<a[^>]+href=\s*(?:'(?<href>[^']+)'|""(?<href>[^""]+)""|(?<href>[^>\s]+))\s*[^>]*>(?<text>.*?)</a>", RegexOptions.IgnoreCase);
            MatchCollection matchs = r.Matches(a1+a2);
            string result = "";

            foreach (Match m in matchs) {
                if (m.Success)
                {
                    result+=(m.Groups["href"].Value+"," + m.Groups["text"].Value+"<br />");
                }
            }
            Response.Write(result);
               
        }
    }
}