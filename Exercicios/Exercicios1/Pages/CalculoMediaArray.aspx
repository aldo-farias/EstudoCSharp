<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/MainPage.Master" AutoEventWireup="true" CodeBehind="CalculoMediaArray.aspx.cs" Inherits="Exercicios1.Pages.CalculoMediaArray" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="panel panel-default">
        <div class="panel-heading">Calculo de Media de Alunos</div>
        <div class="panel-body">
            <div class="row">
                <div class="col-md-2">
                    <p>
                        Nota Aluno1:
                    </p>
                </div>
                <div class="col-md-3">
                    <asp:TextBox ID="Txtnota1" runat="server" Class=" text-info" />

                </div>
            </div>
            <div class="row">
                <div class="col-md-2">
                    <p>
                        Nota Aluno2:
                    </p>
                </div>
                <div class="col-md-3">
                    <asp:TextBox ID="Txtnota2" runat="server" Class=" text-info" />

                </div>
            </div>
            <div class="row">
                <div class="col-md-2">
                    <p>
                        Nota Aluno3:
                    </p>
                </div>
                <div class="col-md-3">
                    <asp:TextBox ID="Txtnota3" runat="server" Class=" text-info" />

                </div>
            </div>

            <div class="row">
                <div class=" col-md-2">
                    <asp:LinkButton ID="LkbCalculaMedia" Text="Calcular Media Array" class="btn btn-info" runat="server" OnClick="CalcularMEdia" />

                </div>
                <div class="col-md-2">
                    <asp:LinkButton ID="LkbCalculaLista" Text="Calcular Media Lista" class="btn btn-info" runat="server" OnClick="LkbCalculaLista_Click" />
                </div>

            </div>
            <div class="row">
                <div class="col-md-12">
                    <asp:Label ID="LblMedia" runat="server" />
                </div>
            </div>
        </div>
    </div>


</asp:Content>
