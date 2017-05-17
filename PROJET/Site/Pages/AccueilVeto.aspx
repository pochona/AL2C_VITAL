<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="AccueilVeto.aspx.vb" Inherits="VITAL.PageAccueilVeto" %>
<!DOCTYPE html>


<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
	<title>Accueil veterinaire</title>
</head>
<body>
	<form id="frmData" runat="server">
	<div>
	    <cw:CwFormLayout runat="server" ID="layoutvet1">
            <cw:CwFrame runat="server" ID="framevet1" text="NomAnimalRecupBD" Collapsable="true" >
                <cw:CwFormLayout runat="server" ID="frlDtl">
                    <cw:CwTextBox runat="server" ID="txtvet1" Label="Race" Enabled="false" Text="infosRecupBD" ToolTip="Infos bulle"></cw:CwTextBox>
                    <cw:CwTextBox runat="server" ID="txtvet2" Label="Poids" Enabled="false" Text="infosRecupBD" ToolTip="Infos bulle"></cw:CwTextBox>
                    <cw:CwTextBox runat="server" ID="txtvet3" Label="Age" Enabled="false" Text="infosRecupBD" ToolTip="Infos bulle"></cw:CwTextBox>
                </cw:CwFormLayout>
            </cw:CwFrame>
	    </cw:CwFormLayout>

        <cw:CwPanelButtons runat="server" ID="pnbvet">
            <cw:CwButton runat="server" ID="btnvet1" Text="Consuler les consultations" Kind="Default"></cw:CwButton>
            <cw:CwButton runat="server" ID="btnvet2" Text="Ajouter des traitements" Kind="Default"></cw:CwButton>
            <cw:CwButton runat="server" ID="btnvet3" Text="Ajouter des vaccins" Kind="Default"></cw:CwButton>
         </cw:CwPanelButtons>
        


	</div>
	</form>
</body>
</html>
