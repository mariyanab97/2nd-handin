<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateAndFilterCustomers.aspx.cs" Inherits="_2ndHandInProgramming.CreateAndFilterCustomers" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="ListBoxCustomers" runat="server" Height="258px" OnSelectedIndexChanged="ListBoxCustomers_SelectedIndexChanged" Width="689px"></asp:ListBox>
            <br />
            <br />
            <asp:Label ID="LabelAllCustomers" runat="server" Text="All Customers"></asp:Label>
            <br />
            <br />
            <asp:Button ID="ButtonAllCustomers" runat="server" OnClick="ButtonAllCustomers_Click" Text="All" />
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="ButtonJutland" runat="server" Text="Jutland" OnClick="RegionButton_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="ButtonFunen" runat="server" Text="Funen" OnClick="RegionButton_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="ButtonZealand" runat="server" Text="Zealand" OnClick="RegionButton_Click" />
            <br />
            <br />
            <asp:TextBox ID="TextBoxFirstName" runat="server" OnTextChanged="All_TextBoxChanged" AutoPostBack="true" ></asp:TextBox>
&nbsp;&nbsp;
            <asp:Label ID="LabelFirstName" runat="server" Text="First name"></asp:Label>
            <br />
            <br />
            <asp:TextBox ID="TextBoxLastName" runat="server" OnTextChanged="All_TextBoxChanged" AutoPostBack="true"></asp:TextBox>
&nbsp;&nbsp;
            <asp:Label ID="LabelLastName" runat="server" Text="Last name"></asp:Label>
            <br />
            <br />
            <asp:TextBox ID="TextBoxZipCode" runat="server" OnTextChanged="All_TextBoxChanged" AutoPostBack="true"></asp:TextBox>
&nbsp;&nbsp;
            <asp:Label ID="LabelZipCode" runat="server" Text="Zip code"></asp:Label>
            <br />
            <br />
            <asp:DropDownList ID="DropDownListSelectRegion" runat="server" AutoPostBack="True" Height="16px" Width="165px" OnSelectedIndexChanged="DropDownListSelectRegion_SelectedIndexChanged">
                <asp:ListItem Value="Select">Select Region</asp:ListItem>
                <asp:ListItem>Jutland</asp:ListItem>
                <asp:ListItem>Funen</asp:ListItem>
                <asp:ListItem>Zealand</asp:ListItem>
            </asp:DropDownList>
&nbsp;&nbsp;
            <asp:Label ID="LabelRegion" runat="server" Text="Region"></asp:Label>
            <br />
            <br />
            <asp:TextBox ID="TextBoxAge" runat="server" OnTextChanged="All_TextBoxChanged"></asp:TextBox>
&nbsp;&nbsp;
            <asp:Label ID="LabelAge" runat="server" Text="Age"></asp:Label>
            <br />
            <br />
            <asp:TextBox ID="TextBoxPassword" runat="server" OnTextChanged="All_TextBoxChanged"></asp:TextBox>
&nbsp;&nbsp;
            <asp:Label ID="LabelPassword" runat="server" Text="Password"></asp:Label>
            <br />
            <br />
            <asp:Label ID="LabelMessages" runat="server" Text="No messages"></asp:Label>
            <br />
            <br />
        </div>
        <asp:Button ID="ButtonAddCustomer" runat="server" OnClick="ButtonAddCustomer_Click" Text="Add Customer" />
    </form>
</body>
</html>
