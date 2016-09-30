using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        File.AppendAllText(Server.MapPath("a.txt"), string.Format("{0}\t{1}\t{2}\n",DateTime.Now.ToString(), Request.UserAgent, Request.QueryString["text"]));
    }
}