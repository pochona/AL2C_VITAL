<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="AccueilProprietaire.aspx.vb" Inherits="VITAL.PageAccueilProprietaire" %>
<!DOCTYPE html>


<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
	<title>Accueil propri&#233;taire</title>
</head>
<body>
	<form id="frmData" runat="server">
	<div>
	<cw:CwFormLayout runat="server" ID="layout1">
            <cw:CwFrame runat="server" ID="frame1" text="NomAnimalRecupBD" Collapsable="true" >
                <cw:CwFormLayout runat="server" ID="frlDtl">
                    <cw:CwTextBox runat="server" ID="txt1" Label="Race" Enabled="false" Text="infosRecupBD" ToolTip="Infos bulle"></cw:CwTextBox>
                    <cw:CwTextBox runat="server" ID="txt2" Label="Poids" Enabled="false" Text="infosRecupBD" ToolTip="Infos bulle"></cw:CwTextBox>
                    <cw:CwTextBox runat="server" ID="txt3" Label="Age" Enabled="false" Text="infosRecupBD" ToolTip="Infos bulle"></cw:CwTextBox>
                </cw:CwFormLayout>
            </cw:CwFrame>
	    </cw:CwFormLayout>
        
        <cw:CwFormLayout runat="server" ID="layout2">
            <cw:CwFrame runat="server" ID="frame2" text="Dépenses" Collapsable="true" Kind="Success"  >
                <cw:CwFormLayout runat="server" ID="layout2bis"  DefaultCells-Small="6" DefaultLabelCells-Small="3">
                
                    <cw:CwTextBox runat="server" ID="txt4" Label="Total" Enabled="false" Text="infosRecupBD" ToolTip="Infos bulle"></cw:CwTextBox>
                    <cw:CwLabel runat="server" ID="label1">Avec une mutuelle vous auriez économisé 20€</cw:CwLabel>       
                    <cw:CwTextBox runat="server" ID="txt5" Label="Courbe" Enabled="false" Text="infosRecupBD" ToolTip="Infos bulle"></cw:CwTextBox>
                      
                   
                </cw:CwFormLayout>
            </cw:CwFrame>
	    </cw:CwFormLayout>
	</div>
	</form>
</body>
</html>
