<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="registro_viajeros.aspx.cs" Inherits="ADRIAN_GUTIERREZ_CARBALLO_EXAMEN_FINAL.Capa_Vistas.registro_viajeros" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Registrar viajeros</title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="width: 1205px">
            <asp:GridView ID="GDcandi" runat="server"></asp:GridView>
            <header>
                <h2>Añadir Candidato</h2>
            </header>
            <section style="width: 806px; height: 451px">
                <article style="height: 318px">

                    <asp:Label ID="Lb_cedula" runat="server" Text="Cédula" CssClass="title_ced"></asp:Label>
                    <asp:TextBox ID="Txt_cedula" runat="server" CssClass="class_ced"></asp:TextBox>

                    <asp:Label ID="Lb_nombre" runat="server" Text="Nombre" CssClass="title_nom"></asp:Label>
                    <asp:TextBox ID="Txt_nombre" runat="server" CssClass="class_nom"></asp:TextBox>

                    <asp:Label ID="Lb_edad" runat="server" Text="Edad" CssClass="title_eda"></asp:Label>
                    <asp:TextBox ID="Txt_edad" runat="server" CssClass="class_eda"></asp:TextBox>

                    <asp:Label ID="Lb_nacion" runat="server" Text="Nación" CssClass="title_pla"></asp:Label>
                    <asp:TextBox ID="Txt_nacion" runat="server" CssClass="class_pla"></asp:TextBox>

                    <asp:Button ID="Boto_travelsend" runat="server" Text="Añadir" CssClass="b_candi" OnClick="Boto_candysend_Click"/>

                </article>
            </section>
        </div>
    </form>
</body>
</html>
