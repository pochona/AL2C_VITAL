<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="ConsultationContratClient.aspx.vb" Inherits="VITAL.PageConsultationClient" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
	<title>ConsultationClient</title>
</head>
<body>
	<form id="frmData" runat="server">
	<div>
	    <cw:CwFormLayout runat="server" ID="layoutajoutclient">
            <cw:CwFrame runat="server" ID="frameajoutclient" text="Propriétaire" Collapsable="true" >
                <cw:CwFormLayout runat="server" ID="frlDtl">
                    <cw:CwDataGrid runat="server" Id="dtgContratClient" Title="{0} contrat(s)"></cw:CwDataGrid> 
                </cw:CwFormLayout>
            </cw:CwFrame>
	    </cw:CwFormLayout>
	</div>
	</form>
</body>
</html>