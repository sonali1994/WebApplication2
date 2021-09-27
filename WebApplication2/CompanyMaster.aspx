<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CompanyMaster.aspx.cs" Inherits="WebApplication2.CompanyMaster" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <!DOCTYPE html>  
  
<html xmlns="http://www.w3.org/1999/xhtml">  

 
    <body>  
      <form>
       
            <table align="center">  
        
        
             
                <tr>  
                    <td>Name :</td>  
                    <td>  
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>  
                    </td>  
  
               </tr> 

               
      
            
                <tr>  
                    <th>Upload Multiple Documents Here</th>  
                </tr>  
                <tr>  
                    <td></td>  
                </tr>  
                <tr>  
                    <td>  
                        <asp:FileUpload ID="fileuplaod1" runat="server" AllowMultiple="true" Font-Bold="true"/>  
                    </td>  
                </tr>  
                <tr>  
                    <td>  
                        <asp:Button ID="button1" runat="server" Text="UPLOAD" Width="82px" OnClick="Upload"/>  
                    </td>  
                </tr>  
                <tr>  
                    <td></td>  
                </tr>  
                <tr>  
                    <td>  
                        <asp:Label ID="label1" runat="server" ForeColor="Green" Font-Size="Large" Font-Bold="true"></asp:Label><br />  
                    </td>  
                </tr>  
                <tr>  
                    <td></td>  
                </tr>  
                <tr>  
                    <td>  
                        <asp:Label ID="labbel2" runat="server" Font-Bold="true" ForeColor="Red" Font-Size="Large"></asp:Label><br />  
                    </td>  
                </tr>  
                <tr>  
                    <td>  
                        <asp:Label ID="label3" runat="server" Font-Bold="true" ForeColor="Black" Font-Size="Large"></asp:Label>  
                    </td>  
                </tr>  
            
       

          
      


           
                
              
                <tr>
                    <td align="center">
                        <asp:Button ID="btnsave" runat="server" ForeColor="SeaGreen" BorderColor="Black" Text="Submit" Font-Bold="true" OnClick="Btnsave_Click" />
                    </td>
                </tr>

             
               
      </table>
    </form>
    </body>
    </html>
</asp:Content>
