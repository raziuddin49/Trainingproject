<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="TEstApplication.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>First Name</td>
                    <td><asp:TextBox runat="server" ID="txtfname"></asp:TextBox> </td>
                </tr>
                 <tr>
     <td>Last Name</td>
     <td><asp:TextBox runat="server" ID="txtlname"></asp:TextBox> </td>
 </tr>
                 <tr>
     <td>Gender</td>
     <td><asp:RadioButtonList runat="server" ID="txtgender">
         <asp:ListItem Value="m">Male</asp:ListItem>
         <asp:ListItem Value="f">Female</asp:ListItem>
         </asp:RadioButtonList> </td>
 </tr>
                 <tr>
     <td>City</td>
     <td><asp:DropDownList runat="server" ID="ddlcity">
         <asp:ListItem Value="1">Azamgarh</asp:ListItem>
<asp:ListItem Value="2">Balia</asp:ListItem>
         <asp:ListItem Value="4">Mau</asp:ListItem>
<asp:ListItem Value="3">Delhi</asp:ListItem>
         </asp:DropDownList> </td>
 </tr>

                <tr>
                    <td>
                        <asp:Button runat="server" ID="btnsave" Text="SAVE" Onclick="btnsave_Click" />
                    </td>
                    <td>
                <asp:Button runat="server" ID="btnreset"  Text="Reset"/>
            </td>
                </tr>
            </table>
            <asp:Label runat="server" ID="lblmsg"></asp:Label>
            <div>
                <asp:GridView runat="server" ID="grduser" AutoGenerateColumns="false">
                    <Columns>
                        <asp:BoundField DataField="fname" HeaderText="First Name"/>
                        <asp:BoundField DataField="lname" HeaderText="Last Name"/>
                        <asp:BoundField DataField="gender" HeaderText="Gender"/>
                        <asp:BoundField DataField="cityid" HeaderText="City Id"/>
                        <asp:TemplateField HeaderText="Edit">
                            <ItemTemplate>
                                <asp:LinkButton runat="server" ID="editbtn" Text="Edit"></asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Delete">
                            <ItemTemplate>
                                <asp:LinkButton runat="server" ID="dltbtn" Text="Delete"></asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>

                    </Columns>

                </asp:GridView>
            </div>
        </div>
    </form>
</body>
</html>
