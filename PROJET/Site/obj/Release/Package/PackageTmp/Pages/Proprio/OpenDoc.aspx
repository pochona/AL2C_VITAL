<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="OpenDoc.aspx.vb" Inherits="VITAL.PageOpenDoc" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
	<title>OpenDoc</title>
</head>
<body>
	<form id="frmData" runat="server">
	<div>
	<cw:CwFormLayout ID="frlGene" runat="server" >
        <cw:cwframe runat="server" ID="frmGene" >
            <cw:CwFormLayout ID="frmDtl" runat="server" >
                <cw:CwTextBox runat="server" ID="txtNom" Enabled="false" Label="Nom"></cw:CwTextBox>
                <cw:CwTextBox runat="server" ID="txtChemin" Enabled="false" Label="Chemin"></cw:CwTextBox>
                <cw:CwPanelButtons ID="pnbBtn" runat="server" >
                    <cw:CwButton ID="btnOpen" Text="Télécharger" runat="server" Kind="Primary"></cw:CwButton>
                    <cw:CwButton ID="btnLoad" Text="Ouvrir dans un nouvel onglet" runat="server" Kind="Primary"></cw:CwButton>
                    <cw:CwButton ID="btnClose" Text="Fermer" runat="server" ></cw:CwButton>
                </cw:CwPanelButtons>
            </cw:CwFormLayout>
        </cw:cwframe>
	</cw:CwFormLayout>
	</div>
	</form>
</body>
</html>
