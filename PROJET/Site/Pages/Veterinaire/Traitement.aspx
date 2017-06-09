<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Traitement.aspx.vb" Inherits="VITAL.PageTraitement" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
	<title></title>
</head>
<body>
	<form id="frmData" runat="server">
	<div>
	    <cw:CwFrame runat="server" ID="frmmedicament">
            <cw:CwFormLayout runat="server" ID="frlDtlMedoc">
                <cw:CwComboBox runat="server" ID="cboMedoc" Label ="Médicament"></cw:CwComboBox>
                <cw:CwNumericTextBox runat="server" ID="ntbDuree" Label="Durée de prise du médicament" MinValue ="1" Decimals="0"></cw:CwNumericTextBox>
                <cw:CwNumericTextBox runat="server" ID="ntbPosologie" Label="Posologie" MinValue ="1" Decimals="0"></cw:CwNumericTextBox>        
            </cw:CwFormLayout>
            <cw:CwPanelButtons runat="server" ID="pnbBtnsMedoc">
                <cw:CwButton runat="server" ID="btnNewMedoc" Text="Ajouter"></cw:CwButton>
            </cw:CwPanelButtons>
            <cw:CwDataGrid runat="server" ID="dtgMedicament" Title="{0} médicament(s)"></cw:CwDataGrid>
	    </cw:CwFrame>
	</div>
	</form>
</body>
</html>
