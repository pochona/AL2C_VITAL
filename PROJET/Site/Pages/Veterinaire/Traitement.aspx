<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Traitement.aspx.vb" Inherits="VITAL.PageTraitement" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
	<title></title>
</head>
<body>
	<form id="frmData" runat="server">
	<div> 
       <cw:CwFrame runat="server" ID="frmTraitmt" text="Traitement">
            <cw:CwFormLayout runat="server" ID="frlTraitmt">
                <cw:CwNumericTextBox runat="server" IsMandatory="true" Label="Durée" ID="ntbDureeTraitmt" Suffix="jours"></cw:CwNumericTextBox>
                <cw:CwDateTextBox runat="server" IsMandatory="true" label="Date début" ID="dtbTraitmt"></cw:CwDateTextBox>
                <cw:CwPanelButtons runat="server" ID="pbnTraitmt">
                    <cw:CwButton runat="server" ID="btnNewTraitmt" Text="Créer un nouveau traitement"></cw:CwButton>
                <cw:CwButton runat="server" ID="btnSaveTraitmt" Text="Enregistrer"></cw:CwButton>
                </cw:CwPanelButtons>
             </cw:CwFormLayout>
        </cw:CwFrame>
	    <cw:CwFrame runat="server" ID="frmMedoc" text="Ajouter un médicament">
            <cw:CwFormLayout runat="server" ID="frlMedoc">
                <cw:CwComboBox runat="server" ID="cboMedoc" Label ="Médicament"></cw:CwComboBox>
                <cw:CwNumericTextBox runat="server" ID="ntbDuree" Label="Durée de prise du médicament" Suffix="jours" MinValue ="1" Decimals="0"></cw:CwNumericTextBox>
                <cw:CwTextBox runat="server" ID="txtPosologie" TextMode="MultiLine" Label="Posologie" MinValue ="1" Decimals="0"></cw:CwTextBox>        
            </cw:CwFormLayout>
            <cw:CwPanelButtons runat="server" ID="pnbBtnsMedoc">
                <cw:CwButton runat="server" ID="btnNewMedoc" Text="Ajouter le médicament au traitement"></cw:CwButton>
            </cw:CwPanelButtons>
           </cw:CwFrame> 
         <cw:CwDataGrid runat="server" ID="dtgMedicament" Title="{0} médicament(s)"></cw:CwDataGrid>
                
	   </div>
	</form>
</body>
</html>
