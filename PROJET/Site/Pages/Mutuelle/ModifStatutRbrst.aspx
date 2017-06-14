<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="ModifStatutRbrst.aspx.vb" Inherits="VITAL.PageModifStatutRbrst" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
	<title>Modification remboursement</title>
</head>
<body>
	<form id="frmData" runat="server">
	<div>
	    <cw:CwFrame runat="server" ID="frmRbrst" text="Remboursements">
            <cw:CwFormLayout runat="server" ID="frlRbrst">
                <cw:CwDateTextBox runat="server" label="Date du remboursement" ID="dtbRbrst"></cw:CwDateTextBox>
                <cw:CwNumericTextBox runat="server" label="Taux de remboursement" ID="CwTxRbrst"></cw:CwNumericTextBox>
                <cw:CwNumericTextBox runat="server" label="Montant du remboursement" ID="CwMtRemb"></cw:CwNumericTextBox>
                <cw:CwTextBox runat="server" label="Nom du client" ID="CwTextNomClt"></cw:CwTextBox>
                <cw:CwTextBox runat="server" label="Prénom du client" ID="CwTextPrenomClt"></cw:CwTextBox>
                <cw:CwTextBox runat="server" label="Nom animal" ID="CwTextNomAnimal"></cw:CwTextBox>
                <cw:CwPanelButtons runat="server" ID="pbnTraitmt">
                    <cw:CwButton runat="server" ID="btnChgStatut" Text="Consultation payée"></cw:CwButton>
                </cw:CwPanelButtons>
             </cw:CwFormLayout>
        </cw:CwFrame>
	</div>
	</form>
</body>
</html>
