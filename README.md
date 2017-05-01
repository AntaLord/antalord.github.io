<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="StyleSheet.css" rel="stylesheet" />
    <link href="bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div class="block text-center">
        <span style="font-size:28px">Faça suas conversões para diegão!</span>
        <asp:TextBox CssClass="form-control" placeholder="digite um número!" TextMode="Number" min="0" ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <asp:Button CssClass="btn-success btn" ID="B1" runat="server" Text="Converter" OnClick="B1_Click" />
        <br />
    </div>
        <div class="block2 text-center">
            <asp:Label ID="Label1" runat="server" Text="oi"></asp:Label>
        </div>
    </form>
</body>
</html>
