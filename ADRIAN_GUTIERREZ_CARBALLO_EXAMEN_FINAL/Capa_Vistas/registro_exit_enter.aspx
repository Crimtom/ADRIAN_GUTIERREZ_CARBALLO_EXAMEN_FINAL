<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="registro_exit_enter.aspx.cs" Inherits="ADRIAN_GUTIERREZ_CARBALLO_EXAMEN_FINAL.Capa_Vistas.registro_exit_enter" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Registro de Entradas y Salidas</title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="width: 1205px">
     <asp:GridView ID="GDcandi" runat="server"></asp:GridView>
     <header>
         <h2>Añadir Entrada/Salida</h2>
     </header>
     <section style="width: 806px; height: 451px">
         <article style="height: 318px">

             <asp:Label ID="Lb_enter_exit" runat="server" Text="Entrada/Salida" CssClass="title_ced"></asp:Label>
             <asp:TextBox ID="Txt_enter_exit" runat="server" CssClass="class_ced"></asp:TextBox>

             <asp:Label ID="Lb_fecha" runat="server" Text="Fecha" CssClass="title_nom"></asp:Label>
             <asp:TextBox ID="Txt_fecha" runat="server" CssClass="class_nom"></asp:TextBox>

             <asp:Label ID="Lb_Destino" runat="server" Text="Destino" CssClass="title_eda"></asp:Label>
             <asp:TextBox ID="Txt_Destino" runat="server" CssClass="class_eda"></asp:TextBox>

             <asp:Button ID="Boto_entersend" runat="server" Text="Añadir" CssClass="b_candi" OnClick="Boto_candysend_Click"/>

         </article>
     </section>
 </div>
    </form>
</body>
</html>
