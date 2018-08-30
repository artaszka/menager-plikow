<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Obraz.aspx.cs" Inherits="menagerplików.Obraz" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" 
            style="z-index: 1; left: 10px; top: 15px; position: absolute" 
            Text="Przeglądarka Zdjęć"></asp:Label>
        <br /><br />
        <asp:Button ID="Button1" runat="server"
         style="z-index: 1; left: 10px; top: 40px; position: absolute"
         Text="Powrót do Galerii" 
            onclick="Button1_Click" />
        <br /><br />
        <asp:Image ID="Image1" runat="server" />
        <br /><br />
        <asp:Button ID="Button2" runat="server" Text="Powrót do Galerii"
            onclick="Button1_Click" />

    </div>
    </form>
</body>
</html>
