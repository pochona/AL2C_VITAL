<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="HistoriquePoids.aspx.vb" Inherits="VITAL.PageHistoriquePoids" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
	<title>Historique du poids</title>
</head>
<body>
	<form id="frmData" runat="server">
	<div>
        <cw:CwFormLayout runat="server" ID="CwFormRecap">
            <cw:CwFrame runat="server" ID="CwFrame2" text="Récapitulatif sur l'animal" Collapsable="true" Kind="Primary" >
                <cw:CwFormLayout runat="server" ID="CwFormLayout3">
                    <cw:CwTextBox runat="server" ID="CwNomAnimal" Label="Animal :" Text="Nom de l'animal"></cw:CwTextBox>
                    <cw:CwTextBox runat="server" ID="CwDerniereDate" Label="Dernier historique :" Text="Date historique"></cw:CwTextBox>
                    <cw:CwTextBox runat="server" ID="CwDernierPoids" Label="Dernier poids :" Text="Poids historique"></cw:CwTextBox>
                </cw:CwFormLayout>
            </cw:CwFrame>
        </cw:CwFormLayout>
	    <cw:CwFormLayout runat="server" ID="frlGeneral">
            <cw:CwFrame runat="server" ID="frmGenral" text="Nouvelle saisie" Collapsable="true" >
                <cw:CwFormLayout runat="server" ID="frlDtl">
                    <cw:CwTextBox runat="server" ID="txtTest" Label="Nom"  ToolTip="Infos bulle"></cw:CwTextBox>
                    <cw:CwTextBox runat="server" ID="txtTest1" Label="Nom de la race" Text="Text affiché" ToolTip="Infos bulle"></cw:CwTextBox>
            </cw:CwFormLayout>
            </cw:CwFrame>
	    </cw:CwFormLayout>
        <cw:CwFormLayout runat="server" ID="frlGeneral2">
            <cw:CwFrame runat="server" ID="frmGenral2" text="Graphique" Collapsable="true" Kind="Success"  >

            </cw:CwFrame>
	    </cw:CwFormLayout>
        <cw:CwFormLayout runat="server" ID="CwFormLayout1">
            <cw:CwFrame runat="server" ID="CwFrame1" text="Historiques" Collapsable="true" Kind="Primary"  >
                <cw:CwFormLayout runat="server" ID="CwFormLayout2"  DefaultCells-Small="6" DefaultLabelCells-Small="3">
                    <cw:CwTextBox runat="server" ID="CwTextBox1" Label="Nom" Text="Text affiché" ToolTip="Infos bulle"></cw:CwTextBox>
                    <cw:CwTextBox runat="server" ID="CwTextBox2" Label="Nom" Text="Text affiché" ToolTip="Infos bulle"></cw:CwTextBox>
                    <cw:CwTextBox runat="server" ID="CwTextBox3" Label="Nom" Text="Text affiché" ToolTip="Infos bulle" ResetLayout="True"></cw:CwTextBox>
                    <cw:CwTextBox runat="server" ID="CwTextBox4" Label="Nom" Text="Text affiché" ToolTip="Infos bulle" ResetLayout="True"></cw:CwTextBox>
       
                </cw:CwFormLayout>
            </cw:CwFrame>
	    </cw:CwFormLayout>
	</div>
	</form>
</body>
</html>
