<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="AccueilProprietaire.aspx.vb" Inherits="VITAL.PageAccueilProprietaire" %>
<!DOCTYPE html>


<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
	<title>Accueil propriétaire</title>
</head>
<body>
	<form id="frmData" runat="server">
	<div>
	<cw:CwFormLayout runat="server" ID="frmAnimx">
            <cw:CwFrame runat="server" ID="frmListAnimaux" text="Animaux" Collapsable="true" Kind="Primary">
                    <cw:CwDataGrid runat="server" ID="dtgAnimx" Title="{0} Animaux" Cells-ExtraSmall="12" LabelCells-ExtraSmall="1"></cw:CwDataGrid>
            </cw:CwFrame>
	    </cw:CwFormLayout>
        
        <cw:CwFormLayout runat="server" ID="frlDepenses">
            <cw:CwFrame runat="server" ID="frm" text="Dépenses" Collapsable="true" Kind="Success"  >
                <cw:CwFormLayout runat="server" ID="frlDtlDepenses">
                    <cw:CwTextBox runat="server" ID="txt4" Enabled="false" Text="TODO CHANGER 20€" Label="Avec une mutuelle vous auriez économisé " ></cw:CwTextBox>
                </cw:CwFormLayout>
            </cw:CwFrame>
	    </cw:CwFormLayout>
	</div>
	</form>
</body>
</html>
