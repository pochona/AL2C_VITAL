<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="NewCarte.aspx.vb" Inherits="VITAL.PageNewCarte" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
	<title>Création d'une carte vitale</title>
</head>
<body>
	<form id="frmData" runat="server">
	<div>
	<cw:CwFormLayout runat="server" ID="frlGene">
        <cw:CwFrame runat="server" ID="frmGene">
            <cw:CwFormLayout runat="server" ID="frlDtl">
                <cw:CwTextBox  runat="server" ID="txtNumCarte" IsMandatory="true" Label="Numéro de la carte"></cw:CwTextBox>
                <cw:CwTextBox  runat="server" ID="txtNFC" Label="NFC"></cw:CwTextBox>
                <cw:CwPanelButtons runat="server" ID="pnbGene">
                    <cw:CwButton runat="server" ID="btnSave" Text="Enregistrer"></cw:CwButton>
                </cw:CwPanelButtons>
            </cw:CwFormLayout>
        </cw:CwFrame>
	</cw:CwFormLayout>
	</div>
	</form>
</body>
</html>
