<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="andyCalc.aspx.cs" Inherits="andyCalcApp.andyCalc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table class="nav-justified">
        <tr>
            <td>Number 1</td>
            <td>Operator</td>
            <td>Number 2</td>
            <td>&nbsp;</td>
            <td>Result</td>
        </tr>
        <tr>
            <td>
                <asp:TextBox ID="txtNumber1" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:DropDownList ID="ddlOperator" runat="server">
                    <asp:ListItem Value="+">Add</asp:ListItem>
                    <asp:ListItem Value="-">Subtract</asp:ListItem>
                    <asp:ListItem Value="*">Multiply</asp:ListItem>
                    <asp:ListItem Value="/">Divide</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>
                <asp:TextBox ID="txtNumber2" runat="server"></asp:TextBox>
                <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Submit" />
            </td>
            <td>&nbsp;</td>
            <td id="resultlabel">
                <asp:TextBox ID="txtResult" runat="server"></asp:TextBox>
            </td>
        </tr>
    </table>
</asp:Content>
