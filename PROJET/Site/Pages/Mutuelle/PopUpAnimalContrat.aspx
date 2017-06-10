<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="PopUpAnimalContrat.aspx.vb" Inherits="VITAL.PagePopUpAnimalContrat" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
	<title></title>
</head>
<body>
	<form id="frmData" runat="server">
	<div>
	    <cw:CwFormLayout runat="server" ID="frlGene">
        <cw:CwFrame runat="server" ID="frmGene" Text="Selectionner un animal">
            <cw:CwDataGrid runat="server" ID="dtgAnimalContrat" AllowAdding="true"></cw:CwDataGrid>
        </cw:CwFrame>
	    </cw:CwFormLayout>
	</div>
	</form>
</body>
</html>
