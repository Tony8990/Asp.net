<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="">
        <h1>Consorzio Vinicolo</h1>
        <p class="lead">Database Consorzio Vincolo Della Nazione Italiana</p>
         <p>Visione Delle Tabelle del DB</p>
        <div>

            <a href="Azienda.aspx">
             <button type="button" class="btn btn-warning btn-lg">Azienda</button>
            </a>
            <a href="Comune.aspx">
             <button type="button" class="btn btn-danger btn-lg">Comuni</button>
            </a>
            <a href="Produzione.aspx">
             <button type="button" class="btn btn-primary btn-lg">Produzione</button>
            </a>
        </div>
        
            
        
    </div>

    </asp:Content>
