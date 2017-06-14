<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="ConsultationContratClient.aspx.vb" Inherits="VITAL.PageConsultationClient" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
	<title>ConsultationClient</title>
</head>
<body>
	<form id="frmData" runat="server">
	<div>
            <cw:CwFrame runat="server" ID="frameajoutclient" text="Contrats des clients" Collapsable="true" >
              
                    <cw:CwDataGrid runat="server" Id="dtgContratClient" Title="{0} contrat(s)"></cw:CwDataGrid> 
              
            </cw:CwFrame>
	</div>
	</form>
</body>
</html>