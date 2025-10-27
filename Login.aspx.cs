using System;
using System.IO;

public partial class Login : System.Web.UI.Page
{
	protected void Page_Load(object sender, EventArgs e)
	{
	}

    protected void btnSubmit_Click(object sender, EventArgs e)
 {
        bool okFlag = true;

  // Check if either field is empty
        if ((txtOwnerID.Text == "") || (txtOwnerID0.Text == ""))
    {
 okFlag = false;
          txtOwnerID.Text = "";
      txtOwnerID0.Text = "";
        txtOwnerID.Focus();
    }

  // Check if both entries match
        if (txtOwnerID.Text != txtOwnerID0.Text)
        {
     okFlag = false;
       txtOwnerID.Text = "";
            txtOwnerID0.Text = "";
          txtOwnerID.Focus();
        }

        // Add underscore if not present
        if (!txtOwnerID.Text.EndsWith("_"))
        {
            txtOwnerID.Text += "_";
        }

   // If validation passes, save ownerID and redirect
        if (okFlag)
        {
            using (StreamWriter _writeFile = new StreamWriter(Server.MapPath("~/App_Data/ownerID.txt"), false))
        {
     _writeFile.WriteLine(txtOwnerID.Text);
          Response.Redirect("Admin.aspx");
         }
        }
    }
}