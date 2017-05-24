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
                    <cw:CwSelectTextBox runat="server" ID="slbNom" NavigateUrl="~/Pages/PopUpContrat.aspx" LabelCells-Small="3" Cells- Small="6"  AutoPostBack="true" PostBackMode="Partial" Columns="5" WindowWidth="950"  MaxLength="10" Label="Nom" ></cw:CwSelectTextBox> 
                </cw:CwFormLayout>
            </cw:CwFrame>
	    </cw:CwFormLayout>
	</div>
	</form>
</body>
</html>
