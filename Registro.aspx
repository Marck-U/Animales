<%@ Page Title="" Language="C#" MasterPageFile="MasterPage.master" AutoEventWireup="true" CodeFile="Registro.aspx.cs" Inherits="Registo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">

    <h1 class="deep-green-text center">Formulario Inscripcion</h1>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <div class="container center">
        <div class="container">
            <div class="row">
                <div class="input-field col s12 m12 l8">
                    <i class="material-icons prefix">account_circle</i>
                    <asp:TextBox runat="Server" ID="txt_rut" name="rut" type="number" class="validate" length="8"></asp:TextBox>
                    <label for="account_circle">Rut</label>
                </div>
            </div>
            <div class="row">
                <div class="input-field col s12 m12 l8">
                    <i class=" material-icons prefix">account_circle</i>
                    <asp:TextBox runat="Server" ID="txt_nombre" name="nombre" type="text" class="validate" length="55"></asp:TextBox>
                    <label for="account_circle">nombre</label>
                </div>
            </div>
            <div class="row">
                <div class="input-field col s12 m12 l8">
                    <i class=" material-icons prefix">account_circle</i>
                    <asp:TextBox runat="Server" ID="txt_apellido" name="apellido" type="text" class="validate" length="55"></asp:TextBox>
                    <label for="account_circle">Apellido</label>
                </div>
            </div>
            <div class="row">
                <div class="input-field col s12 m12 l8">
                    <i class="material-icons prefix">person</i>
                    <asp:TextBox runat="Server" ID="txt_usuario" name="usuario" type="text" class="validate"></asp:TextBox>
                    <label for="account_circle">Usuario</label>
                </div>
            </div>
            <div class="row">
                <div class="input-field col s12 m12 l8">
                    <i class="material-icons prefix">https</i>
                    <asp:TextBox runat="Server" ID="txt_pass" name="password" type="password" class="validate"></asp:TextBox>
                    <label for="account_circle">pass</label>
                </div>
            </div>
            <div class="row">
                <div class="input-field col s12 m12 l8">
                    <i class="material-icons prefix">phone</i>
                    <asp:TextBox runat="Server" ID="txt_telefono" name="telefono" type="tel" class="validate" length="12"></asp:TextBox>
                    <label for="icon_telephone">Telefono</label>
                    <label for="tel" data-error="solo letras" data-success="right"></label>
                </div>
            </div>
            <div class="row">
                <div class="input-field col s12 m12 l8">
                    <i class="material-icons prefix">email</i>
                    <asp:TextBox runat="Server" ID="txt_correo" name="correo" type="email" class="validate"></asp:TextBox>
                    <label for="account_circle">Correo</label>
                </div>
            </div>
            <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                <ContentTemplate>
                    <p>
                        <p>
                            <label for="account_circle">Region</label>
                            <asp:DropDownList ID="DropDownList6" runat="server" OnSelectedIndexChanged="DropDownList6_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
                        </p>
                        <label for="account_circle">Provincia</label>
                        <asp:DropDownList ID="DropDownList5" runat="server" OnSelectedIndexChanged="DropDownList5_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
                    </p>
                    <p>
                        <label for="account_circle">Comuna</label>
                        <asp:DropDownList ID="DropDownList4" runat="server" >
                        </asp:DropDownList>
                    </p>
                </ContentTemplate>
            </asp:UpdatePanel>
            <div class="row">
                <div class="input-field col s12 m12 l12">
                    <i class="material-icons prefix">home</i>
                    <asp:TextBox runat="Server" ID="txt_direc" name="direccion" type="text" class="validate"></asp:TextBox>
                    <label for="account_circle">Direccion</label>
                </div>
            </div>
            <div class="row">
                <div class="input-submit">
                    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                        <ContentTemplate>
                            <asp:Button runat="server" type="submit" ID="btn_insert" class="btn waves-effect waves-light deep-orange" name="action" Style="right: 10%" OnClick="btn_insert_Click1" Text="Registro" />
                            <br />
                            <asp:Label ID="lbl_mensaje" runat="server" Text="" CssClass="orange-text"></asp:Label>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

