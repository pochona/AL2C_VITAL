<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="CreerAnimal.aspx.vb" Inherits="VITAL.PageCreerAnimal" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
	<title>CreerAnimal</title>
</head>
<body>
	<form id="frmData" runat="server">
	<div>
	<cw:CwFormLayout runat="server" ID="frlGene">
        <cw:CwFrame runat="server" ID="frmGene" Text="Informations">
            <cw:CwFormLayout runat="server" ID="frlInfos">
                <cw:CwTextBox runat="server" ID="txtNom" Label="Nom" IsMandatory="true"></cw:CwTextBox>
                <cw:CwComboBox runat="server" ID="cboType" Label="Type" IsMandatory="true"></cw:CwComboBox>
                <cw:CwComboBox runat="server" ID="cboRace" Label="Race" IsMandatory="true"></cw:CwComboBox>
                <cw:CwNumericTextBox runat="server" ID="ntbPoids" Label="Poids" ></cw:CwNumericTextBox>
                <cw:CwNumericTextBox runat="server" ID="ntbTaille" Label="Taille" ></cw:CwNumericTextBox>
                <cw:CwTextBox runat="server" ID="txtPuce" Label="Numéro de puce" ></cw:CwTextBox>
                <cw:CwDateTextBox runat="server" ID="dtbNaiss" Label="Date de naissance" ></cw:CwDateTextBox>
                <cw:CwSuggestTextBox runat="server" ID="sgtProp" Label="Propriétaire"></cw:CwSuggestTextBox>
                <cw:CwPanelButtons runat="server" ID="pnbBtns">
                    <cw:CwButton runat="server" ID="btnSave"></cw:CwButton>
                </cw:CwPanelButtons>
            </cw:CwFormLayout>
        </cw:CwFrame>
	</cw:CwFormLayout>
	</div>
	</form>
</body>
</html>
