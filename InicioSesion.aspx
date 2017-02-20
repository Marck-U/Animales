<%@ Page Title="" Language="C#" MasterPageFile="MasterPage.master" AutoEventWireup="true" CodeFile="InicioSesion.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
     <div class="container center">
        <div class="container">
            <div class="row l8">
                <div class="input-field col s12 m12 l8">
                    <i class="material-icons prefix">person</i>
                    <asp:TextBox runat="server" ID="txt_usuario" name="usuario" type="text" class="validate"></asp:TextBox>
                    <label for="account_circle">Usuario</label>
                </div>
            </div>
            <div class="row l4">
                <div class="input-field col s12 m12 l8 ">
                    <i class="material-icons prefix">https</i>
                    <asp:TextBox runat="server" ID="txt_pass" name="password" type="password" class="validate" length="50" OneClick="" OnTextChanged="txt_pass_TextChanged"></asp:TextBox>
                    <label for="account_circle">password</label>
                </div>
            </div>
            <div class="row l4">
                <div class="input-submit">
                    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                        <ContentTemplate>
                              <asp:Button runat="server" type="submit" ID="btn_insert" class="btn waves-effect waves-light deep-orange" name="action" Style="right: 15%" OnClick="btn_insert_Click" Text="Registro" CausesValidation="False" ValidateRequestMode="Disabled" /><br />
                            <div>
                             <asp:Label CssClass="orange-text" ID="lbl_Mensaje" runat="server" Text=""></asp:Label>
                            </div>   
                        </ContentTemplate>
                    </asp:UpdatePanel>
                </div>
            </div>
        </div>
    </div>
    
</asp:Content>

