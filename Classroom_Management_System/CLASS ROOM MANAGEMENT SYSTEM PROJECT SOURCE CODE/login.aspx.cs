using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

public partial class login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        if (ddlType.SelectedIndex == 0) // faculty 
        {
            string facname = FacultyDAL.Login(txtLoginId.Text, txtPassword.Text);
            if (facname != null) // valid login 
            {
                Session.Add("facid", txtLoginId.Text);
                Session.Add("facname", facname);
                Session.Add("utype", "f");
                FormsAuthentication.RedirectFromLoginPage(txtLoginId.Text, false);
            }
            else
                lblMsg.Text = "Sorry!  Invalid Login. Try Again!";

        }
        else  // Student 
        {
            string studname = StudentDAL.Login(txtLoginId.Text, txtPassword.Text);
            if (studname != null) // valid login 
            {
                Session.Add("studid", txtLoginId.Text);
                Session.Add("studname", studname);
                Session.Add("utype", "s");
                FormsAuthentication.RedirectFromLoginPage(txtLoginId.Text, false);
            }
            else
                lblMsg.Text = "Sorry!  Invalid Login. Try Again!";
        }
    }
}