<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="ADRIAN_GUTIERREZ_CARBALLO_EXAMEN_FINAL.Capa_Vistas.Login.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="../CSS/StyleLogin.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
         <div>
            <section>
                <article class="logdatext">
                    
                    <asp:TextBox ID="Txt_nombre" runat="server" Height="27px" Width="448px" CssClass="nombrebox"></asp:TextBox>
                    
                    <asp:TextBox ID="Txt_email" runat="server" Height="27px" Width="448px" CssClass="emailbox"></asp:TextBox>
                    
                    <asp:TextBox ID="Txt_contra" runat="server" Height="27px" Width="448px" CssClass="contrabox"></asp:TextBox>

                    <asp:Button ID="Boto_enviar" runat="server" Text="" CssClass="enviarboto" />

                </article>
            </section>
        </div>
    </form>
</body>
</html>
