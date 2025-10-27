<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Bob's Book Nook - Login</title>
	<style type="text/css">
        body {
     font-family: Arial, sans-serif;
     background-color: #f4f4f4;
       display: flex;
            justify-content: center;
            align-items: center;
            height: 100vh;
            margin: 0;
        }
.login-container {
   background-color: white;
    padding: 30px;
     border-radius: 8px;
box-shadow: 0 2px 10px rgba(0,0,0,0.1);
      width: 350px;
        }
        h2 {
 text-align: center;
     color: #333;
margin-bottom: 20px;
        }
        table {
            width: 100%;
        }
        td {
    padding: 10px 5px;
        }
        .label-cell {
         text-align: right;
      padding-right: 10px;
            font-weight: bold;
    }
   input[type="text"] {
  width: 100%;
            padding: 8px;
            border: 1px solid #ddd;
            border-radius: 4px;
       box-sizing: border-box;
   }
        .btn-submit {
            width: 100%;
       padding: 10px;
            background-color: #4CAF50;
            color: white;
            border: none;
            border-radius: 4px;
        cursor: pointer;
         font-size: 16px;
         margin-top: 10px;
        }
        .btn-submit:hover {
            background-color: #45a049;
  }
	</style>
</head>
<body>
 <form id="form1" runat="server">
        <div class="login-container">
     <h2>Bob's Book Nook</h2>
     <h3 style="text-align: center; color: #666;">Admin Login</h3>
  <table>
    <tr>
        <td class="label-cell">Enter your ownerID:</td>
  <td>
              <asp:TextBox ID="txtOwnerID" runat="server"></asp:TextBox>
     </td>
                </tr>
   <tr>
       <td class="label-cell">Re-enter ownerID:</td>
                    <td>
       <asp:TextBox ID="txtOwnerID0" runat="server"></asp:TextBox>
     </td>
     </tr>
         <tr>
       <td colspan="2">
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" CssClass="btn-submit" OnClick="btnSubmit_Click" />
         </td>
        </tr>
         </table>
        </div>
    </form>
</body>
</html>
