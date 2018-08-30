<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainPrzegladarka.aspx.cs" Inherits="menagerplików.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            height: 395px;
            width: 629px;
        }
        .style2
        {
            width: 629px;
        }
        #File1
        {
            z-index: 1;
            top: 81px;
            position: absolute;
            left: 205px;
        }
        .style3
        {
            width: 629px;
            height: 28px;
        }
    </style>
</head>
<body  style="height: 6px" bgcolor="#000000">
    <form id="form1" runat="server" clientidmode="Static" 
    style="background-color: #000000">
    
    <table  frame="void";  style="width:94%; margin-top: 13px; " bgcolor="Black">
        <tr>
            <td class="style3" bgcolor="Black"  > 
                </td>
        </tr>
        <tr>
            <td class="style1"  align="left">
                <asp:Panel ID="Panel1" runat="server" BorderColor="#66FFFF" 
                    BorderStyle="Double"
                    
                    style="z-index: 1; left: 13px; top: 1777px; position: static; height: 391px; width: 701px" 
                    BackColor="#3399FF">
                
                <asp:Label ID="InfoPlik" runat="server"
                    style="z-index: 1; left: 60px; top: 204px; position: absolute"></asp:Label>
                <asp:Label ID="lHelp" runat="server" align="center"
                    style="z-index: 1; left: 63px; top: 396px; position: absolute" 
                    Text="Label"></asp:Label>
                
                <asp:Button ID="bDodaj" runat="server" BackColor="Silver" Font-Bold="True" 
                    style="z-index: 1; left: 59px; top: 166px; position: absolute; width: 130px; right: 653px;" 
                    Text="dodaj zdjęcie" onclick="bDodaj_Click1" />
                <asp:Button ID="bZmien" runat="server" BackColor="Silver" Font-Bold="True" 
                    style="z-index: 1; left: 58px; top: 297px; position: absolute; width: 130px; " 
                    Text="zmień nazwę" onclick="bZmien_Click" />
                <asp:Button ID="bUsun" runat="server" BackColor="Silver" Font-Bold="True" 
                    style="z-index: 1; left: 59px; top: 248px; position: absolute; width: 130px" 
                    Text="usuń zdjęcie" onclick="bUsun_Click1" />
                <asp:ListBox ID="ListaPlikow" runat="server" BackColor="#FFFFCC"
                    
                    style="z-index: 1; left: 405px; top: 132px; position: absolute; height: 196px; width: 265px" 
                    AutoPostBack="True" CausesValidation="True" ClientIDMode="Predictable" 
                    onselectedindexchanged="ListaPlikow_SelectedIndexChanged" Rows="9">
                    
                </asp:ListBox>
                <asp:TextBox ID="tbZmien" runat="server" 
                    style="z-index: 1; left: 59px; top: 331px; position: absolute">Wpisz nazwę</asp:TextBox>
                
                <asp:FileUpload ID="FileUpload1" runat="server"
                    style="z-index: 1; left: 60px; top: 132px; position: absolute" />
                    
                <asp:Button ID="bDoGalerii" runat="server" onclick="bDoGalerii_Click" 
                    style="z-index: 1; left: 290px; top: 347px; position: absolute; width: 122px" 
                    Text="Przejdź do galerii" />
                    
                </asp:Panel>
                    
            </td>
        </tr>
        <tr>
            <td class="style2">
                &nbsp;</td>
        </tr>
    </table>
    </form>
</body>
</html>
