<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="PopUpAjoutAnimal.aspx.vb" Inherits="VITAL.PagePopUpAjoutAnimal" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
	<title>PopUpAjoutAnimal</title>
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
                <cw:CwCheckBox runat="server" ID="chkCarte" Label="Créer une carte vitale"/>
                <cw:CwPanelButtons runat="server" ID="pnbBtns">
                    <cw:CwButton runat="server" ID="btnSave" Text="Enregistrer"></cw:CwButton>
                </cw:CwPanelButtons>
            </cw:CwFormLayout>
        </cw:CwFrame>
	</cw:CwFormLayout>
	</div>
	</form>
</body>
</html>
