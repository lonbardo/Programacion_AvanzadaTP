<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="Inscripcion.aspx.cs" Inherits="CapaPresentacion.Inscripción" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <table style="width: 100%">
            <tr>
                <td>
                    <asp:Label ID="lblId_Alumno" runat="server" Text="Id Alumno: "></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtId_Alumno" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblId_Curso" runat="server" Text="Curso: "></asp:Label><%--COMBO CON EL ID DEL ALUMNO--%>
                </td>
                <td>
                    <asp:TextBox ID="txtCruso" runat="server"></asp:TextBox><%--COMBO CON LOS CURSOS DISPONIBLES--%>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblObservacion" runat="server" Text="Observaciones: "></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtObservacion" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblProfesor" runat="server" Text="Nombre Profesor: "></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtProfesor" runat="server"></asp:TextBox>
                </td>-
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblFecha" runat="server" Text="Fecha de alta: "></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtFecha" runat="server" CssClass="form-control"  type="date"></asp:TextBox>
                    
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <br />
    </p>
    <p>
    </p>
    <p>
    </p>
</asp:Content>
