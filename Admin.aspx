<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Admin.aspx.cs" Inherits="Admin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Bob's BookNook Administration Page</title>
	<style type="text/css">
		body {
       font-family: Arial, sans-serif;
            margin: 20px;
      background-color: #f4f4f4;
        }
        h1 {
  color: #333;
   text-align: center;
        }
        td {
      vertical-align: top;
            padding: 10px;
        }
        .container {
        background-color: white;
padding: 20px;
 border-radius: 8px;
            box-shadow: 0 2px 10px rgba(0,0,0,0.1);
    max-width: 1200px;
          margin: 0 auto;
}
 .section {
     margin-bottom: 20px;
     padding: 15px;
         border: 1px solid #ddd;
            border-radius: 5px;
            background-color: #fafafa;
        }
    .btn {
     padding: 8px 16px;
            margin: 5px;
   border: none;
       border-radius: 4px;
            cursor: pointer;
         font-size: 14px;
        }
        .btn-primary {
  background-color: #4CAF50;
            color: white;
        }
    .btn-danger {
     background-color: #f44336;
            color: white;
 }
        .btn-info {
       background-color: #2196F3;
 color: white;
        }
 .btn:hover {
   opacity: 0.8;
        }
   input[type="text"] {
       padding: 5px;
          border: 1px solid #ddd;
        border-radius: 4px;
        }
        .listbox {
width: 100%;
       height: 150px;
            border: 1px solid #ddd;
    border-radius: 4px;
        }
        .error-message {
    color: red;
            font-weight: bold;
     margin: 10px 0;
        }
	</style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h1>Bob's Book Nook - Administration</h1>
            
  <div class="section">
   <table>
        <tr>
  <td><strong>Owner ID:</strong></td>
      <td>
     <asp:TextBox ID="txtOwnerID" runat="server" Enabled="false"></asp:TextBox>
  </td>
         <td>
   <asp:Button ID="btnResetUser" runat="server" Text="Reset User" CssClass="btn btn-info" OnClick="btnResetUser_Click" />
    </td>
    </tr>
</table>
       </div>

 <div class="section">
     <h3>Progress Log</h3>
     <asp:ListBox ID="lstProgress" runat="server" CssClass="listbox"></asp:ListBox>
      </div>

      <div class="section">
      <h3>Database Management</h3>
    <asp:Button ID="btnClearDB" runat="server" Text="Clear Database" CssClass="btn btn-danger" OnClick="btnClearDatabase_Click" />
     </div>

  <div class="section">
         <h3>Upload Images</h3>
     <table>
        <tr>
        <td>
             <asp:FileUpload ID="FileUpload1" runat="server" />
     </td>
     <td>
             <asp:Button ID="btnLoadImages" runat="server" Text="Load Images" CssClass="btn btn-primary" OnClick="btnLoadImages_Click" />
 </td>
     </tr>
    </table>
            </div>

            <div class="section">
      <h3>Upload XML Data</h3>
                <table>
     <tr>
       <td>
      <asp:FileUpload ID="FileUpload2" runat="server" />
      </td>
       <td>
      <asp:Button ID="btnLoadXML" runat="server" Text="Load XML" CssClass="btn btn-primary" OnClick="btnLoadXML_Click" />
               </td>
   </tr>
         </table>
         </div>

            <div class="section">
       <asp:Label ID="lblErrorMessage" runat="server" CssClass="error-message"></asp:Label>
   </div>

        <div class="section">
       <asp:Button ID="btnViewInventory" runat="server" Text="View Inventory" CssClass="btn btn-info" OnClick="btnViewInventory_Click" />
            </div>

            <div class="section">
     <asp:GridView ID="gvDisplay" runat="server" AutoGenerateColumns="False" CellPadding="4" GridLines="None" Width="100%">
         <Columns>
<asp:TemplateField HeaderText="Image">
            <ItemTemplate>
         <asp:Image ID="Image1" runat="server" ImageUrl='<%# FormatImageUrl((string)Eval("Image")) %>' Height="100px" />
           </ItemTemplate>
       </asp:TemplateField>
        <asp:BoundField DataField="Title" HeaderText="Title" />
               <asp:BoundField DataField="Author" HeaderText="Author" />
           <asp:BoundField DataField="Category" HeaderText="Category" />
<asp:BoundField DataField="ISBN" HeaderText="ISBN" />
             <asp:BoundField DataField="Description" HeaderText="Description" />
      </Columns>
          <HeaderStyle BackColor="#4CAF50" ForeColor="White" Font-Bold="True" />
   <RowStyle BackColor="White" />
     <AlternatingRowStyle BackColor="#f9f9f9" />
       </asp:GridView>
            </div>

            <!-- Hidden ListBox for debugging -->
            <asp:ListBox ID="lstHidden" runat="server" Visible="false" CssClass="listbox"></asp:ListBox>
        </div>
    </form>
</body>
</html>
