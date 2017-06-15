<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="HistoVaccinTraitemt.aspx.vb" Inherits="VITAL.PageHistoVaccinTraitemt" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
	<title>Historique vaccins et traitements</title>
</head>
<body>
	<form id="frmData" runat="server">
	<div>
	
        <cw:CwFrame runat="server" ID="frmTraitements" Text="Historique des traitements">
            <cw:CwDataGrid runat="server" ID="dtgTraitements" Title="{0} traitement(s)"></cw:CwDataGrid>
        </cw:CwFrame>
         <cw:CwFrame runat="server" ID="frmVaccinations" Text="Historique des vaccinations">
            <cw:CwDataGrid runat="server" ID="dtgVaccins" Title="{0} vaccination(s)"></cw:CwDataGrid>
        </cw:CwFrame>
	</div>
	</form>
</body>
</html>
