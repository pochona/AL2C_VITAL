<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="AjoutTraitement.aspx.vb" Inherits="VITAL.PageAjoutTraitement" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
	<title>AjoutTraitement</title>
</head>
<body>
	<form id="frmData" runat="server">
	<div>
	<cw:CwFrame runat="server" ID="frmGene">
        <cw:CwFormLayout runat="server" ID="frlGene">
            <cw:CwDateTextBox runat="server" IsMandatory="true" ID="dtbMedoc"></cw:CwDateTextBox>
            <cw:CwComboBox runat="server" IsMandatory="true" ID="cboMedoc" Label="Medicament (anti-puce...)"></cw:CwComboBox>
        </cw:CwFormLayout>
        <cw:CwPanelButtons runat="server" ID="pnlBtns">
            <cw:CwButton runat="server" Text="Ajouter le traitement" ID="btnNewTraitement"></cw:CwButton>
        </cw:CwPanelButtons>
	</cw:CwFrame>
	</div>
	</form>
</body>
</html>
