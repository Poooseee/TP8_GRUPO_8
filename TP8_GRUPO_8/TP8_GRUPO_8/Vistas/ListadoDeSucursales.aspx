<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListadoDeSucursales.aspx.cs" Inherits="Vistas.ListadoDeSucursales" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">

        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 256px;
            height: 23px;
        }
        .auto-style5 {
            font-size: x-large;
        }
        .auto-style7 {
            width: 204px;
        }
        .auto-style8 {
            margin-left: 117px;
        }
        .auto-style9 {
            margin-left: 0px;
        }
        .auto-style10 {
            width: 200px;
        }
        .auto-style11 {
            width: 100%;
            margin-right: 0px;
        }
        .auto-style12 {
            width: 203px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:HyperLink ID="hplAgregarSucursales" runat="server" NavigateUrl="~/AgregarSucursal.aspx">Agregar Sucursal</asp:HyperLink>
                </td>
                <td class="auto-style2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:HyperLink ID="hplListadoSucursales" runat="server" NavigateUrl="~/ListarSucursales.aspx">Listado de Sucursales</asp:HyperLink>
                &nbsp;</td>
                <td class="auto-style2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:HyperLink ID="hplEliminarSucursal" runat="server" NavigateUrl="~/EliminarSucursal.aspx">Eliminar Sucursal</asp:HyperLink>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
            </tr>
        </table>
            <strong class="auto-style5">
            <br />
            Listado de sucursales</strong><br />
            <br />
        </div>
        <table class="auto-style11">
            <tr>
                <td class="auto-style12">
                    <asp:Label ID="lblBusqueda" runat="server" Text="Busqueda Ingrese ID Sucursal:"></asp:Label>
                </td>
                <td class="auto-style7">
                    <asp:TextBox ID="txtSucursal" runat="server" Width="173px"></asp:TextBox>
                </td>
                <td class="auto-style10">
                    <asp:Button ID="Button1" runat="server" CssClass="auto-style8" Text="Button" />
                </td>
                <td>
                    <asp:Button ID="Button2" runat="server" CssClass="auto-style9" Text="Button" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
