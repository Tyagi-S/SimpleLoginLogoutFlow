using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoginLogoutProject
{
    public partial class FirstPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string Name = TextBox1.Text;
            if (TextBox2.Text.Equals("Tyagi"))
            {
                Response.Redirect("Profile.aspx?Name=" + Name);
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Invalid Password')", true);
            }
        }
    }
}