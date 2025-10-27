using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

/// <summary>
/// Database connection class for Bob's Book Nook
/// </summary>
public static class myDatabaseConnection
{
    // Connection string for SQL Server LocalDB
    private static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\BobsBookNook.mdf;Integrated Security=True";

    /// <summary>
    /// Execute SQL command and bind results to GridView
    /// </summary>
    public static void executeSQL(string sqlCommand, ref GridView gvDisplay, ref Label lblErrorMessage)
    {
        try
     {
    using (SqlConnection connection = new SqlConnection(connectionString))
      {
    connection.Open();
 
           using (SqlCommand command = new SqlCommand(sqlCommand, connection))
     {
       // Check if this is a SELECT query
             if (sqlCommand.Trim().ToUpper().StartsWith("SELECT"))
         {
         SqlDataAdapter adapter = new SqlDataAdapter(command);
   DataTable dt = new DataTable();
   adapter.Fill(dt);
        
        gvDisplay.DataSource = dt;
       gvDisplay.DataBind();
      gvDisplay.Visible = true;
                 }
     else
          {
  // For INSERT, UPDATE, DELETE, CREATE, DROP commands
        command.ExecuteNonQuery();
            gvDisplay.Visible = false;
    }
          }
            }
 
            lblErrorMessage.Text = "";
     }
  catch (Exception ex)
 {
  lblErrorMessage.Text = ex.Message;
        gvDisplay.Visible = false;
        }
    }
}
