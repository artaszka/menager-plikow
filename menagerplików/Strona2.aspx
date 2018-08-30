<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Strona2.aspx.cs" Inherits="menagerplików.Strona2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            height: 131px;
        }
        .style2
        {
            height: 48px;
        }
        .style3
        {
            height: 48px;
            width: 155px;
        }
        .style4
        {
            height: 131px;
            width: 155px;
        }
        .style5
        {
            width: 155px;
        }
        .style6
        {
            height: 48px;
            width: 607px;
        }
        .style7
        {
            height: 131px;
            width: 607px;
        }
        .style8
        {
            width: 607px;
        }
    </style>
</head>
<body bgcolor="#000000">
    <form id="form1" runat="server">
    <div>
       
            
        <table style="width: 100%;">
            <tr>
                <td class="style3">
                    <asp:Label ID="Label1" runat="server" 
            
            Text="Przeglądarka Zdjęć" Font-Bold="True" Font-Names="Comic Sans MS" 
            Font-Size="Medium" ForeColor="White"></asp:Label>
                    &nbsp;

                </td>
                <td class="style6">
                    <asp:Button ID="bStrona1" runat="server" onclick="bStrona1_Click" 
                    Text="Strona Główna" />
                </td>
                <td class="style2">
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td class="style4">
                    <asp:Button ID="bWczytaj" runat="server" 
                    Text="Wczytaj Zdjęcia" 
                    onclick="bWczytaj_Click" />
                    &nbsp;
                
                    &nbsp;
                </td>
                <td class="style7">
                    <asp:Panel ID="Panel1" runat="server"
                    BackColor="#3399FF" BorderStyle="Dashed" HorizontalAlign="Center">
                    </asp:Panel>
                </td>
                <td class="style1">
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td class="style5">
                    
                    &nbsp;
                </td>
                <td class="style8">
                    &nbsp;
                    <asp:Panel ID="Panel2" runat="server">
                    </asp:Panel>
                </td>
                <td>
                    &nbsp;
                </td>
            </tr>
        </table>
            
                
        
        <p>
            &nbsp;</p>
        
        
    </div>
    
    </form>
</body>
</html>
