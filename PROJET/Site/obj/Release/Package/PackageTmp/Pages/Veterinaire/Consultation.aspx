<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Consultation.aspx.vb" Inherits="VITAL.PageConsultation" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
	<title>Consultation</title>
</head>
<body>
	<form id="frmData" runat="server">
	<div>
	<cw:CwFormLayout runat="server" ID="frlGeneral">
        <cw:CwFrame runat="server" ID="frmGeneral">
            <cw:CwFormLayout runat="server" ID="frlDtl">
                <cw:CwNumericTextBox runat="server" ID="ntbMontant" Label="Montant" Cells-Small="6" ResetLayout="True" Suffix="€"></cw:CwNumericTextBox>
                <cw:CwDateTextBox runat="server" ID="dtbDate" Label="Date"  Cells-Small="6" ResetLayout="True"></cw:CwDateTextBox>
                <cw:CwComboBox runat="server" Label="Vétérinaire" ID="cboVeterinaire" Cells-Small="6" ResetLayout="True" Enabled="False"></cw:CwComboBox>
                <cw:CwTextBox runat="server" Cells-Small="12" ID="txtComment" TextMode="MultiLine" ResetLayout="True" Label="Commentaires" LabelCells-Small="2" Height="200px"></cw:CwTextBox>
                
                
                <cw:CwPanelButtons runat="server" ID="pnbBoutons">
                    <cw:CwButton runat="server" ID="btnSave" Text="Créer la consultation" ImageName="floppy-disc"></cw:CwButton>
                </cw:CwPanelButtons>
            </cw:CwFormLayout>
        </cw:CwFrame>
	</cw:CwFormLayout>
	</div>
	</form>
</body>
</html>
