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
        <cw:CwFrame runat="server" ID="frmGeneral" Text="Détails">
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
         <cw:CwFrame runat="server" ID="frmTraitements" Width="100%" Text="Ajouter un traitement" Cells-Small="6" ResetLayout="False">
          <cw:CwFrame runat="server" ID="frmTraitmt" >
            <cw:CwFormLayout runat="server" ID="frlTraitmt">
                <cw:CwNumericTextBox runat="server" IsMandatory="true" Label="Durée" ID="ntbDureeTraitmt" Suffix="jours"></cw:CwNumericTextBox>
                <cw:CwDateTextBox runat="server" IsMandatory="true" label="Date début" ID="dtbTraitmt"></cw:CwDateTextBox>
                <cw:CwPanelButtons runat="server" ID="pbnTraitmt">
                    <cw:CwButton runat="server" ID="btnNewTraitmt" Text="Créer un nouveau traitement"></cw:CwButton>
                <cw:CwButton runat="server" ID="btnSaveTraitmt" Text="Enregistrer"></cw:CwButton>
                </cw:CwPanelButtons>
             </cw:CwFormLayout>
        </cw:CwFrame>
	    <cw:CwFrame runat="server" ID="frmMedoc" text="Ajouter un médicament" LabelCells-Small="1">
            <cw:CwFormLayout runat="server" ID="frlMedoc">
                <cw:CwComboBox runat="server" ID="cboMedoc" Label ="Médicament"></cw:CwComboBox>
                <cw:CwNumericTextBox runat="server" ID="ntbDuree" Label="Durée de prise du médicament" Suffix="jours" MinValue ="1" Decimals="0"></cw:CwNumericTextBox>
                <cw:CwTextBox runat="server" ID="txtPosologie" TextMode="MultiLine" Label="Posologie" MinValue ="1" Decimals="0"></cw:CwTextBox>        
            </cw:CwFormLayout>
            <cw:CwPanelButtons runat="server" ID="pnbBtnsMedoc">
                <cw:CwButton runat="server" ID="btnNewMedoc" Text="Ajouter le médicament au traitement"></cw:CwButton>
            </cw:CwPanelButtons>
            <cw:CwDataGrid runat="server" ID="dtgMedicament" Title="{0} médicament(s)"></cw:CwDataGrid>
           </cw:CwFrame> 
         
	  
         </cw:CwFrame>
         <cw:CwFrame runat="server" ID="frmVaccins" Width="100%" Text="Ajouter une vaccination" Cells-Small="6" ResetLayout="False">
                 <cw:CwFormLayout runat="server" ID="frlVaccination">
                    <cw:CwDateTextBox runat="server" IsMandatory="true" ID="dttxtNewVaccin" Label="Date"></cw:CwDateTextBox>
                    <cw:CwComboBox runat="server" IsMandatory="true"  ID="CboVaccin" Label="Vaccin"></cw:CwComboBox>
                </cw:CwFormLayout>
                <cw:CwPanelButtons runat="server" ID="pnbBtnsVaccin">
                    <cw:CwButton runat="server" ID="btnNewVaccin" Text="Ajouter"></cw:CwButton>
                </cw:CwPanelButtons>
         </cw:CwFrame>
	</cw:CwFormLayout>
	</div>
	</form>
</body>
</html>
