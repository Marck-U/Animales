<%@ Page Language="C#" AutoEventWireup="true" CodeFile="admin.aspx.cs" Inherits="admin" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <link href="css/materialize.min.css" rel="stylesheet" />
    <link href="http://fonts.googleapis.com/icon?family=Material+Icons" rel="stylesheet" />
    <link href="css/estiloInicio.css" rel="stylesheet" />
    <title>Admin</title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <div>
            <h1 class="center deep-orange-text">Bienvenido Administrador</h1>
            <div class="container center col s4">
                <div class="container">
                    <div class="col l8">
                        <div class="input-field col s12 m12 l8">
                            <i class="material-icons prefix">person</i>
                            <asp:TextBox runat="server" ID="txt_usuario" name="usuario" type="text" class="validate"></asp:TextBox>
                            <label for="account_circle">Usuario</label>
                        </div>
                    </div>
                    <div class="col l4">
                        <div class="input-field col s12 m12 l8 ">
                            <i class="material-icons prefix">https</i>
                            <asp:TextBox runat="server" ID="txt_pass" name="password" type="password" class="validate" length="50"></asp:TextBox>
                            <label for="account_circle">password</label>
                        </div>
                    </div>
                    <div class="col s6">
                        <div class="input-submit">
                            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                                <ContentTemplate>
                                    <asp:Button runat="server" type="submit" ID="btn_insert" class="btn waves-effect waves-light deep-orange" name="action" Style="right: 15%" Text="Registro" CausesValidation="False" ValidateRequestMode="Disabled" OnClick="btn_insert_Click" /><br />
                                    <asp:Label CssClass="orange-text" ID="lbl_Mensaje" runat="server" Text=""></asp:Label>
                                </ContentTemplate>
                            </asp:UpdatePanel>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </form>
    <script type="text/javascript" src="https://code.jquery.com/jquery-2.1.1.min.js"></script>
    <script src="js/materialize.min.js"></script>
</body>
</html>
