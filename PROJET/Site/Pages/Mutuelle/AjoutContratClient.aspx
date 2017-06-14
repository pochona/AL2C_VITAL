<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="AjoutContratClient.aspx.vb" Inherits="VITAL.PageAjoutContratClient" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
	<title>AjoutContratClient</title>
</head>
<body>
	<form id="frmData" runat="server">
	<div>
	    <cw:CwFormLayout runat="server" ID="layoutajoutclient">
            <cw:CwFrame runat="server" ID="frameajoutclient" text="Propriétaire" Collapsable="true" >
                <cw:CwFormLayout runat="server" ID="frlDtl" DefaultCells-Small="6" DefaultLabelCells-Small="6">
                    <cw:CwTextBox runat="server" ID="txtNumContrat" IsMandatory="true" Label="Numéro de contrat" ></cw:CwTextBox>
                      <cw:CwNumericTextBox Decimals="2" MaxValue="1" MinValue="0" runat="server" ID="ntbTxremb" IsMandatory="true" Suffix="%" Label="Taux de remboursement (ex : 0,30)"  ></cw:CwNumericTextBox>
                      <cw:CwDateTextBox runat="server" ID="DateDebut"  Label="Date de début"  IsMandatory="true" ></cw:CwDateTextBox>
                      <cw:CwTextBox runat="server" ID="txtIdPropCache"  Visible="false" ></cw:CwTextBox>
                      <cw:CwSelectTextBox runat="server" ID="stbProprio" IsMandatory="true" PostBackMode="Full" AutoPostBack="true" NavigateUrl="~/Pages/Mutuelle/PopUpProprioContrat.aspx" Enabled="True" ToolTip="Pour sélectionner un propriétaire, veuillez cliquer sur le bouton de droite." Label="Propriétaire"></cw:CwSelectTextBox>
                      <cw:CwDateTextBox runat="server" ID="DateFin" IsMandatory="true" Label="Date de fin"  ></cw:CwDateTextBox>
                      <cw:CwComboBox runat="server" ID="cboAnimal" IsMandatory="true" Label="Animal" ></cw:CwComboBox>
                 </cw:CwFormLayout>
            <cw:CwPanelButtons runat="server" ID="pnbBtnContrat">
                <cw:CwButton runat="server" ID="btnCreate" Text="Ajouter"></cw:CwButton>
                <cw:CwButton runat="server" ID="btnModifier" Text="Modifier"></cw:CwButton>
                  <cw:CwButton runat="server" ID="btnSave" Text="Sauvegarder"></cw:CwButton>
                
                  <cw:CwButton runat="server" ID="btnNewAnimal" Text="Créer un animal"></cw:CwButton>
          </cw:CwPanelButtons>
            </cw:CwFrame>
	    </cw:CwFormLayout>

	</div>
	</form>
</body>
</html>