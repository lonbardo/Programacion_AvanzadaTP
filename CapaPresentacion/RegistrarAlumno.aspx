<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="RegistrarAlumno.aspx.cs" Inherits="CapaPresentacion.RegistrarAlumno" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <%-- EN EL VIDEO AGREGA UN TABLA HTML, PORQUE NO SE PUEDE AGERGAR UNA DE ASP? --%>
    
    <br/>
     (*) Campos obligatorios.
    <br />
    <br />
    <table style="width: 100%">
        <tr>
            <td>
                <asp:Label ID="lblNombre" runat="server" Text="Nombre: *"></asp:Label>
                </td>
            <td>
                <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:Label ID="lblApellido" runat="server" Text="Apellido: *"></asp:Label>
                </td>
            <td>
                <asp:TextBox ID="txtApellido" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblDNI" runat="server" Text="DNI: *"></asp:Label>
                </td>
            <td>
                <asp:TextBox ID="txtDNI" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:Label ID="lblFechaNacimiento" runat="server" Text="Fecha de Nacimiento: *"></asp:Label>
                </td>
            <td>
                <asp:TextBox ID="txtFechaNac" runat="server" CssClass="form-control"  type="date"></asp:TextBox>
<%--            	<asp:RequiredFieldValidator runat="server" id="RequiredFieldValidator7" controltovalidate="txtFechaNac" errormessage="La fecha es requerida" />	                      --%>
                
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblDireccion" runat="server" Text="Dirección: *"></asp:Label>
                </td>
            <td>
                <asp:TextBox ID="txtDireccion" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:Label ID="lblMail" runat="server" Text="Mail: *"></asp:Label>
                </td>
            <td>
                <asp:TextBox ID="txtMail" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td class="right">
                <asp:Button ID="btnGuardar" runat="server" Text="Guardar" OnClick="btnGuardar_Click" />
            </td>
            <td>
    <asp:Label ID="lblAlerta" runat="server" style="width: 64px; height: 16px; position: absolute; top: 364px; left: 215px" Visible="False"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
    <br />
    <br />
    
    <br />
    <br />
    <br/>
    <hr/>
    <asp:Button ID="btnMostrarRegitsros" runat="server" Text="Mostrar Registros" OnClick="btnMostrarRegistros_Click" />
    <asp:GridView ID="GridView1" runat="server" Visible="False"></asp:GridView>
    
</asp:Content>
