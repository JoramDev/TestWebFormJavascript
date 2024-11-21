<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TestWebFormJavascript.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h1>Hola mundo!</h1>


    <script type="text/javascript">
        fetch('Default.aspx/Enviar_Indicador_Novo', {
            method: 'POST',
            headers: { 'Content-Type': 'application/json' },
            body: JSON.stringify({ Data: "Eduardo", Pilar: "Joel" })
        })
            .then(response => response.json())
            .then(data => console.log(data))
            // .then(message => {console.log(message)})
            .catch(error => {
                console.log(error)
            })
    </script>

</asp:Content>
