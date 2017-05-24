<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="AjoutContratClient.aspx.vb" Inherits="VITAL.PageAjoutContratClient" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
	<title>AjoutContratClient</title>
</head>
<body>
	<form id="frmData" runat="server">
	<div>
	    <cw:CwFormLayout runat="server" ID="layoutajoutclient">
            <cw:CwFrame runat="server" ID="frameajoutclient" text="Propriétaire" Collapsable="true" >
                <cw:CwFormLayout runat="server" ID="frlDtl">
                    <cw:CwTextBox runat="server" ID="NumContrat" Label="Numéro de contrat" Enabled="true" Text="" ToolTip="Infos bulle"></cw:CwTextBox>
                    <cw:CwDateTextBox runat="server" ID="DateDebut" Label="Date de début" Enabled="true" Text="" IsMandatory="true" ></cw:CwDateTextBox>
                    <cw:CwDateTextBox runat="server" ID="DateFin" Label="Date de fin" Enabled="true" Text="" ToolTip="Infos bulle"></cw:CwDateTextBox>
                    <cw:CwNumericTextBox runat="server" ID="IdAnimal" Label="ID de l'animal" Enabled="true" Text="" ToolTip="Infos bulle"></cw:CwNumericTextBox>
                    <cw:CwNumericTextBox runat="server" ID="IdProprio" Label="ID du propriétaire" Enabled="true" Text="" ToolTip="Infos bulle"></cw:CwNumericTextBox>
                    <cw:CwNumericTextBox runat="server" ID="IdAssurance" Label="ID de l'assurance" Enabled="true" Text="" ToolTip="Infos bulle"></cw:CwNumericTextBox>
                    <cw:CwLabel runat="server" ID="label1" Label="Label" Text=""></cw:CwLabel>
                </cw:CwFormLayout>
            </cw:CwFrame>
	    </cw:CwFormLayout>


        <cw:CwPanelButtons runat="server" ID="panelmut2">
            <cw:CwButton runat="server" ID="btnmut1" Text="AJOUTER LE CONTRAT" Kind="Default" OnClick="clicValider"></cw:CwButton>
            <cw:CwButton runat="server" ID="btnmut2" Text="ANNULER" Kind="Default" NavigateUrl="~/Pages/AccueilMutuelle.aspx"></cw:CwButton>
         </cw:CwPanelButtons>

	</div>
	</form>
</body>
</html>
