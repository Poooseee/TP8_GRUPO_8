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
            height: 30px;
        }
        .auto-style11 {
            width: 100%;
            margin-right: 0px;
        }
        .auto-style12 {
            width: 203px;
        }
        .auto-style13 {
            width: 203px;
            height: 30px;
        }
        .auto-style14 {
            width: 204px;
            height: 30px;
        }
        .auto-style15 {
            height: 30px;
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
                <td class="auto-style2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:HyperLink ID="hplListadoSucursales" runat="server" NavigateUrl="~/ListadoDeSucursales.aspx">Listado de Sucursales</asp:HyperLink>
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
                <td class="auto-style13">
                    <asp:Label ID="lblBusqueda" runat="server" Text="Busqueda Ingrese ID Sucursal:"></asp:Label>
                </td>
                <td class="auto-style14">
                    <asp:TextBox ID="txtSucursal" runat="server" Width="173px"></asp:TextBox>
                </td>
                <td class="auto-style10">
                    <asp:Button ID="btnFiltrar" runat="server" CssClass="auto-style8" Text="Filtrar" OnClick="btnFiltrar_Click" />
                </td>
                <td class="auto-style15">
                    <asp:Button ID="btnTodos" runat="server" CssClass="auto-style9" Text="Mostrar todos" OnClick="btnTodos_Click" />
                </td>
            </tr>
            <tr>
                <td class="auto-style12">
                    <asp:Label ID="LabelBusquedaProv" runat="server" Text="Seleccione una Provincia:"></asp:Label>
                </td>
                <td class="auto-style7">
                    <asp:DropDownList ID="ddlProvincia" runat="server" Height="16px" Width="191px">
                    </asp:DropDownList>
                </td>
                <td>

                    <asp:Label ID="lblDDL" runat="server"></asp:Label>

                </td>
            </tr>
        </table>
        <p>
            <asp:GridView ID="gvSucursales" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="Id_Sucursal" HeaderText="Id_Sucursal" />
                    <asp:BoundField DataField="NombreSucursal" HeaderText="Nombre" />
                    <asp:BoundField DataField="DescripcionSucursal" HeaderText="Descripcion" />
                    <asp:BoundField DataField="DescripcionProvincia" HeaderText="Provincia" />
                    <asp:BoundField DataField="DireccionSucursal" HeaderText="Direccion" />
                </Columns>
            </asp:GridView>
        </p>
    </form>
</body>
</html>
