<%@ Page Language="C#" MasterPageFile="Pagina_Maestra/Home.Master" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="ADRIAN_GUTIERREZ_CARBALLO_EXAMEN_FINAL.Capa_Vistas.Inicio" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="CSS/StyleStart.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div class="start_fondo" style="height: 945px; width: 100%;">
            <section class="welcome">
                <article class="weltext" style="height: 244px; width: 774px;">
                    <h1 class="menu_title">Bienvenido al Sistema de aduanas</h1>
                    <br />
                    En esta aplicación WEB se pueden añadir, editar y borrar registro de viajes como de las entradas y salidas de la aduana.
                </article>
            </section>
        </div>
</asp:Content>