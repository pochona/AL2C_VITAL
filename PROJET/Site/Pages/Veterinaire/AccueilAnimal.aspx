<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="AccueilAnimal.aspx.vb" Inherits="VITAL.PageAccueilAnimal" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
	<title>AccueilAnimal</title>
</head>
<body>
	<form id="frmData" runat="server">
	<div>
	
        <cw:CwFormLayout runat="server" ID="FrlTheBoss">
            <cw:CwFrame runat="server" ID="frmInfosAniml" Text="Informations" Width="100%" Cells-Small="8" ResetLayout="False">
                <cw:CwFormLayout runat="server" ID="frlInfosAniml">
                    <cw:CwTextBox runat="server" ID="txtNom" Label="Nom"  IsMandatory="true" ></cw:CwTextBox>
                    <cw:CwNumericTextBox runat="server" ID="ntbAge" Label="Age" Enabled="false" Suffix="année(s)"></cw:CwNumericTextBox>
                    <cw:CwNumericTextBox  runat="server" ID="ntbPoids" IsMandatory="true" Label="Poids" Suffix="kg"></cw:CwNumericTextBox>
                    <cw:CwNumericTextBox runat="server" ID="ntbTaille" IsMandatory="true" Label="Taille" Suffix="cm"></cw:CwNumericTextBox>
                    <cw:cwTextBox runat="server" ID="txtNumPuce" Label="Numéro de puce"></cw:cwTextBox>
                        <cw:CwUpdatePanel runat="server" ID="upnNumCarte" UpdateMode="Conditional"  >
                            <ContentTemplate>
                                <cw:CwFormLayout runat="server" ID="frlNumCarte">
                                    <cw:CwComboBox runat="server" ID="cboNumCarte" Label="Numéro de carte vitale" PostBackMode="Full"  AutoPostBack="True"></cw:CwComboBox> 
                                </cw:CwFormLayout>
                            </ContentTemplate>
                        </cw:CwUpdatePanel>
                    <cw:CwDateTextBox runat="server" ID="dtbNaiss" Label="Date naissance"  ></cw:CwDateTextBox>
                    <cw:CwDateTextBox runat="server" ID="dtbDeces" Label="Date décès" ></cw:CwDateTextBox>
                    <cw:CwComboBox runat="server" IsMandatory="true"  ID="cboType" RoleEdit="!*" Label="Type"></cw:CwComboBox>
                    <cw:CwComboBox runat="server" IsMandatory="true"  ID="cboRace" RoleEdit="!*" Label="Race"></cw:CwComboBox>
                    <cw:CwTextBox runat="server" ID="txtIdPropCache" IsMandatory="true" Visible="false" ></cw:CwTextBox>
                    <cw:CwSelectTextBox runat="server" ID="stbProprio" IsMandatory="true" AutoPostBack="true" PostBackMode="Full" NavigateUrl="~/Pages/Veterinaire/PopUpProprio.aspx" Label="Propriétaire" Enabled="True" ToolTip="Pour sélectionner un propriétaire, veuillez cliquer sur le bouton de droite."></cw:CwSelectTextBox>
                    <cw:CwPanelButtons runat="server" ID="pbnInfosAnimal">
                        <cw:CwButton runat="server" ImageName="pencil" ID="btnModifierInfoAnml" Text="Modifier"></cw:CwButton>
                        <cw:CwButton runat="server" ImageName="floppy-disc" ID="btnSaveInfoAnml" Text="Enregistrer"></cw:CwButton>
                        <cw:CwButton runat="server" ImageName="sq-plus-all" ID="btnNewCarte" Text="Créer une nouvelle carte"></cw:CwButton>
                    </cw:CwPanelButtons>
                </cw:CwFormLayout>
            </cw:CwFrame>
            <cw:CwFrame runat="server" ID="frmNewConsul" Text="Nouvelle consultation" Width="100%" Cells-Small="4" ResetLayout="False" >
                <cw:CwPanelButtons runat="server" ID="pbnNewConsult" PanelAlign="center">
                    <cw:CwButton runat="server" ID="btnNewConsult" ImageName="sq-plus" text="Créer une consultation"></cw:CwButton>
                </cw:CwPanelButtons>
            </cw:CwFrame>
            
            <cw:CwFrame runat="server" ID="frmListConsult" Text="Liste des consultations" Width="100%" Cells-Small="12" ResetLayout="true" >
                <cw:CwDataGrid runat="server" ID="dtgConsultations" Title="{0} consultation(s)"></cw:CwDataGrid>
            </cw:CwFrame>
            
            <cw:CwFrame runat="server" ID="frmListTraitements" Text="Traitements" Width="100%" Cells-Small="6" ResetLayout="False" >
                <cw:CwDataGrid runat="server" ID="dtgTraitements" Title="{0} traitement(s)"></cw:CwDataGrid>
            </cw:CwFrame>
            <cw:CwFrame runat="server" ID="frmListVaccins" Text="Vaccins" Width="100%" Cells-Small="6" ResetLayout="False" >
                <cw:CwDataGrid runat="server" ID="dtgVaccins" Title="{0} vaccin(s)"></cw:CwDataGrid>
            </cw:CwFrame>
            
            <cw:CwFrame runat="server" ID="frmListConseilDiet" Text="Conseils diététiques" Width="100%" Cells-Small="12" ResetLayout="False" >
                <cw:CwFormLayout runat="server" ID="frlDtlDiet">
                    <cw:CwTextBox runat="server" ID="txtNewConseil" Label="Nouveau conseil" ResetLayout="true" TextMode="MultiLine" Height="150px" LabelCells-Small="2"></cw:CwTextBox>
                </cw:CwFormLayout>
                <cw:CwPanelButtons runat="server" ID="pnbBtnsDiet">
                    <cw:CwButton runat="server" ID="btnNewConseil" Text="Ajouter"></cw:CwButton>
                </cw:CwPanelButtons>
                <cw:CwDataGrid runat="server" ID="dtgDietetiques" Title="{0} conseil(s) diététiques(s)"></cw:CwDataGrid>
            </cw:CwFrame>
        </cw:CwFormLayout>

	</div>
	</form>
</body>
</html>
