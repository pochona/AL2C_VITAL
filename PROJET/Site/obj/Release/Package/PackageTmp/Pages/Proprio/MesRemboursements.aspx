﻿<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="MesRemboursements.aspx.vb" Inherits="VITAL.PageMesRemboursements" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
	<title>Mes remboursements</title>
</head>
<body>
	<form id="frmData" runat="server">
	<div>
	 <cw:CwFormLayout runat="server" ID="frlGeneral2">
        <cw:CwFrame runat="server" ID="frmGenral2" text="Historique" Collapsable="true" >
                <cw:CwDataGrid runat="server" ID="grdMesRemboursements" Title="{0} remboursement(s)" />
        </cw:CwFrame>
    </cw:CwFormLayout>
	</div>
	</form>
</body>
</html>
