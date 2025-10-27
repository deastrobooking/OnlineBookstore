using System;
using System.Web;
using System.Web.UI.WebControls;
using System.IO;
using System.Drawing;

public partial class Admin : System.Web.UI.Page
{
    string uploadPath;

	protected void Page_Load(object sender, EventArgs e)
	{
        // Check if user is logged in by reading ownerID file
    try
        {
     var data = File.ReadAllText(Server.MapPath("~/App_Data/ownerID.txt"));
            txtOwnerID.Text = data.ToString().Trim();
        }
     catch
        {
        Response.Redirect("Login.aspx");
        }

   uploadPath = Server.MapPath("~/Img/");

        // Check/create database table
        checkTables(txtOwnerID.Text + "BOOKS",
  "CREATE TABLE " + txtOwnerID.Text + "BOOKS (Title CHAR(64), ISBN CHAR(14) UNIQUE, Author CHAR(64), Category CHAR(48), Image CHAR(128), Description CHAR(255))");

 initLstProgress();
	}

    private void checkTables(string Table, string sqlStatement)
    {
        lblErrorMessage.Text = "";
        myDatabaseConnection.executeSQL("SELECT * FROM " + Table, ref gvDisplay, ref lblErrorMessage);

        gvDisplay.Visible = false;
        if (lblErrorMessage.Text.Length > 0)
     {
  lblErrorMessage.Text = "";
            myDatabaseConnection.executeSQL(sqlStatement, ref gvDisplay, ref lblErrorMessage);
        }
    }

 private void initLstProgress()
    {
   lstProgress.Items.Clear();
        lstProgress.Items.Add("Welcome to Bob's Book Nook Administration");
  lstProgress.Items.Add("Upload images first, then XML data");
      lstProgress.Items.Add("Ready to begin...");
    }

    protected void btnResetUser_Click(object sender, EventArgs e)
 {
     Response.Redirect("Login.aspx");
    }

    protected void btnClearDatabase_Click(object sender, EventArgs e)
    {
    string sqlCommand = "DROP TABLE " + txtOwnerID.Text + "BOOKS";
  myDatabaseConnection.executeSQL(sqlCommand, ref gvDisplay, ref lblErrorMessage);
 
        lstProgress.Items.Add("Database cleared");
        
        // Recreate the table
   checkTables(txtOwnerID.Text + "BOOKS",
        "CREATE TABLE " + txtOwnerID.Text + "BOOKS (Title CHAR(64), ISBN CHAR(14) UNIQUE, Author CHAR(64), Category CHAR(48), Image CHAR(128), Description CHAR(255))");
    }

    protected void btnLoadImages_Click(object sender, EventArgs e)
    {
    lstHidden.Items.Clear();

     if (!FileUpload1.HasFile)
 {
  lstProgress.Items.Add("Browse for files and select");
    lstProgress.Items.Add("an image from the directory.");
FileUpload1.Focus();
        }
  else
        {
            lstProgress.Items.Add("Processing Image File...");
    
    string fileName = Path.GetFileName(FileUpload1.FileName);
  FileUpload1.SaveAs(Server.MapPath("~/Img/") + fileName);
lstHidden.Items.Add(String.Format("{0}", fileName));
lstProgress.Items.Add("Uploaded: " + fileName);
 
            lstProgress.Items.Add("Image upload complete!");
     }
    }

protected void btnLoadXML_Click(object sender, EventArgs e)
{
  lstHidden.Items.Clear();
        lblErrorMessage.Text = null;

        if (!FileUpload2.HasFile)
        {
    lstProgress.Items.Add("[Browse] for the XML file");
        lstProgress.Items.Add("and select.");
FileUpload2.Focus();
        }
        else
        {
    lstProgress.Items.Add("Processing XML File...");

     string fileName = uploadPath + FileUpload2.FileName;
      lstProgress.Items.Add("File: " + FileUpload2.FileName);
     FileUpload2.SaveAs(fileName);

            try
      {
       if (File.Exists(fileName))
          {
  using (StreamReader sr = new StreamReader(fileName))
      {
      while (sr.Peek() >= 0)
         {
         lstHidden.Items.Add(sr.ReadLine());
 }
          }
  }
 }
            catch (Exception f)
       {
      Console.WriteLine("The process failed: {0}", f.ToString());
    lstProgress.Items.Add("Error reading XML file");
    }

          decode(lstHidden);
     lstProgress.Items.Add("XML data loaded successfully!");
}
    }

  private void decode(ListBox lstHidden)
    {
        string field;
   
        // Remove XML header lines
        lstHidden.Items.RemoveAt(0);
        lstHidden.Items.RemoveAt(0);

    while (lstHidden.Items.Count > 1)
  {
            string sqlStatement = "INSERT INTO " + txtOwnerID.Text + "BOOKS (Title, ISBN, Author, Category, Image, Description) VALUES (";
   
     // Remove opening <BOOK> tag
     lstHidden.Items.RemoveAt(0);

       // Process 6 fields: Title, ISBN, Author, Category, Image, Description
     for (int i = 0; i < 6; i++)
            {
          field = lstHidden.Items[0].ToString();
   field = stripTags(field);

         if (i == 4) // Image field
           {
       sqlStatement += "'" + "\\Img\\" + field + "'";
      }
              else
 {
  // Truncate description if too long
     if (i == 5 && field.Length >= 255)
      {
    field = field.Substring(0, 254);
            }

 // Escape single quotes
      field = field.Replace("'", "''");
        sqlStatement += " '" + field + "'";
 }

    if (i < 5)
      {
sqlStatement += ", ";
      }

       lstHidden.Items.RemoveAt(0);
    }

        sqlStatement += ")";
      
       // Execute SQL insert
            myDatabaseConnection.executeSQL(sqlStatement, ref gvDisplay, ref lblErrorMessage);
   
 // Remove closing </BOOK> tag
  lstHidden.Items.RemoveAt(0);
 }
    }

    private string stripTags(string field)
 {
        int x = field.IndexOf(">");
  field = field.Substring(x + 1);
    x = field.LastIndexOf("<");
  field = field.Substring(0, x);
return field;
    }

    protected void btnViewInventory_Click(object sender, EventArgs e)
    {
        string sqlCommand = "SELECT Title, ISBN, Author, Category, Image, Description FROM " + txtOwnerID.Text + "BOOKS";
  myDatabaseConnection.executeSQL(sqlCommand, ref gvDisplay, ref lblErrorMessage);
        
     if (gvDisplay.Visible)
      {
 lstProgress.Items.Add("Inventory displayed successfully");
        }
    }

 protected string FormatImageUrl(string url)
    {
if (url != null && url.Length > 0)
        {
     return ("~/" + url);
  }
        else
        {
  return null;
  }
    }
}
