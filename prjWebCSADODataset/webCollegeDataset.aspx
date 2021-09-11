<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="webCollegeDataset.aspx.cs" Inherits="prjWebCSADODataset.webCollegeDataset" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 800px;
        }
        .auto-style2 {
            width: 137px;
        }
        .auto-style3 {
            text-align: justify;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <table align="center" class="auto-style1">
                <tr>
                    <td class="auto-style2">
                        <asp:ListBox ID="lstNumero" runat="server" AutoPostBack="True" Height="188px" OnSelectedIndexChanged="lstNumero_SelectedIndexChanged" Width="145px"></asp:ListBox>
                    </td>
                    <td>
                        <asp:Panel ID="Panel1" runat="server" Height="255px">
                            <div class="auto-style3">
                                <br />
                                <br />
                                <asp:Label ID="Label1" runat="server" Text="Numero:"></asp:Label>
                                &nbsp;&nbsp;&nbsp;
                                <asp:TextBox ID="txtNumero" runat="server" Width="300px"></asp:TextBox>
                                <br />
                                <asp:Label ID="Label2" runat="server" Text="Titre:"></asp:Label>
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:TextBox ID="txtTitre" runat="server" Width="300px"></asp:TextBox>
                                <br />
                                <asp:Label ID="Label3" runat="server" Text="Professeur:"></asp:Label>
                                <asp:TextBox ID="txtProf" runat="server" Width="300px"></asp:TextBox>
                                <br />
                                <asp:Label ID="Label4" runat="server" Text="Durée:"></asp:Label>
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:TextBox ID="txtDuree" runat="server" Width="300px"></asp:TextBox>
                                <br />
                            </div>
                        </asp:Panel>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:GridView ID="gridTable" runat="server" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2">
                            <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
                            <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
                            <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
                            <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
                            <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
                            <SortedAscendingCellStyle BackColor="#FFF1D4" />
                            <SortedAscendingHeaderStyle BackColor="#B95C30" />
                            <SortedDescendingCellStyle BackColor="#F1E5CE" />
                            <SortedDescendingHeaderStyle BackColor="#93451F" />
                        </asp:GridView>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
