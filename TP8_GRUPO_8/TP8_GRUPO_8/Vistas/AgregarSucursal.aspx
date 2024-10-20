<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AgregarSucursal.aspx.cs" Inherits="Vistas.AgregarSucursal" %>

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
            font-size: xx-large;
        }
        .auto-style6 {
            font-size: x-large;
        }
        .auto-style7 {
            width: 201px;
        }
        .auto-style8 {
            width: 581px;
        }
        .auto-style9 {
            width: 99%;
        }
        </style>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.6.0/jquery.min.js"></script>
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
            <br />
    <p class="auto-style5">
        <strong>GRUPO N°8</strong></p>
    <p class="auto-style6">
        <strong>Agregar Sucursal</strong></p>
            <table class="auto-style9">
                <tr>
                    <td class="auto-style7">
                        <asp:Label ID="lblNombreSucursal" runat="server" Text="Nombre de la Sucursal:"></asp:Label>
                    </td>
                    <td class="auto-style8">
                        <asp:TextBox ID="txtNombre" runat="server" Width="189px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvNombre" runat="server" ControlToValidate="txtNombre" ErrorMessage="RequiredFieldValidator">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style7">
                        <asp:Label ID="lblDescripcion" runat="server" Text="Descripcion:"></asp:Label>
                    </td>
                    <td class="auto-style8">
                        <asp:TextBox ID="txtDescripcion" runat="server" Height="71px" Width="186px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvDescripcion" runat="server" ControlToValidate="txtDescripcion" ErrorMessage="RequiredFieldValidator">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style7">
                        <asp:Label ID="lblProvincia" runat="server" Text="Provincia:"></asp:Label>
                    </td>
                    <td class="auto-style8">
                        <asp:DropDownList ID="ddlProvincia" runat="server" Height="16px" Width="191px">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style7">
                        <asp:Label ID="Direccion" runat="server" Text="Direccion:"></asp:Label>
                    </td>
                    <td class="auto-style8">
                        <asp:TextBox ID="txtDireccion" runat="server" Height="21px" Width="184px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvDireccion" runat="server" ControlToValidate="txtDireccion" ErrorMessage="RequiredFieldValidator">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style7">&nbsp;</td>
                    <td class="auto-style8">
                        <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" OnClick="btnAceptar_Click" />
                    &nbsp;&nbsp;&nbsp;
                        <asp:Label ID="lblMensaje" runat="server"></asp:Label>
                    </td>
                </tr>
            </table>
            <p class="auto-style6">
                &nbsp;</p>
        </div>
    </form>
</body>
</html>
