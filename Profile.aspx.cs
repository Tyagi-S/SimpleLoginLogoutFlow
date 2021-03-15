using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoginLogoutProject
{
    public partial class Profile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string Name = Request.QueryString["Name"];
            Response.Write("Welcome " + Name);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("FirstPage.aspx");
        }
    }
}