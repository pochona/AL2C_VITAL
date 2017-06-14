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
            <cw:CwFormLayout runat="server" ID="frlRbrst" DefaultCells-Small="6">
                <cw:CwDateTextBox Enabled="false"  runat="server" label="Date du remboursement" ID="dtbRbrst"></cw:CwDateTextBox>
                  <cw:CwTextBox Enabled="false" runat="server" label="Nom animal" ID="CwTextNomAnimal"></cw:CwTextBox>
          
                   <cw:CwNumericTextBox Enabled="false" runat="server" Suffix="%" MaxValue="1" MinValue="0" Decimals="2" label="Taux de remboursement" ID="CwTxRbrst"></cw:CwNumericTextBox>
                 <cw:CwTextBox Enabled="false" runat="server" label="Nom du client" ID="CwTextNomClt"></cw:CwTextBox>
             
                  <cw:CwNumericTextBox Enabled="false" runat="server" Suffix="€" label="Montant du remboursement" ID="CwMtRemb"></cw:CwNumericTextBox>
                <cw:CwTextBox Enabled="false" runat="server" label="Prénom du client" ID="CwTextPrenomClt"></cw:CwTextBox>
              
             </cw:CwFormLayout>
  <cw:CwPanelButtons runat="server" ID="pbnTraitmt">
                    <cw:CwButton runat="server" ID="btnChgStatut" Text="Consultation payée"></cw:CwButton>
                </cw:CwPanelButtons>
        </cw:CwFrame>
	</div>
	</form>
</body>
</html>
