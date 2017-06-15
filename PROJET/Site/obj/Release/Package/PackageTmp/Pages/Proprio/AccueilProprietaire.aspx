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
        
       
	</div>
	</form>
</body>
</html>
