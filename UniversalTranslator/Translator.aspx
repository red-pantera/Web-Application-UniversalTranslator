<% @Page Language="C#" AutoEventWireup="true" CodeBehind="Translator.aspx.cs" Inherits="UniversalTranslator.Translator" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Universal Translator" Font-Size="Large" Font-Bold="True"></asp:Label>
            
        
        <p>
            <asp:TextBox ID="txtSource" runat="server" TextMode="MultiLine"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="butTranslate" runat="server" Text="Translate" OnClick="butTranslate_Click" />
        </p>
        </div>
    </form>
</body>
</html>
