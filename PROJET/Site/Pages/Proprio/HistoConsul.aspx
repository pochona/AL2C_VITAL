<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="HistoConsul.aspx.vb" Inherits="VITAL.PageHistoConsul" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
	<title>HistoConsul</title>
</head>
<body>
	<form id="frmData" runat="server">
	<div>
	 <cw:CwFormLayout runat="server" ID="frlGeneral">
            <cw:CwFrame runat="server" ID="frmLastConsul" text="Dernière consultation" Collapsable="true" >
                <cw:CwFormLayout runat="server" ID="frlDtl">
                    <cw:CwDateTextBox runat="server" ID="dtbConsul" Label="Date" Enabled="false" ></cw:CwDateTextBox>
                    <cw:CwNumericTextBox runat="server" ID="ntbMontant" Label="Montant" Enabled="false" ></cw:CwNumericTextBox>
                    <cw:CwTextBox runat="server" ID="txtComm" Label="Commentaire" Enabled="false" TextMode="MultiLine"></cw:CwTextBox>
                    <cw:CwTextBox runat="server" ID="txtVeto" Label="Vétérinaire" Enabled="false" ></cw:CwTextBox>
                </cw:CwFormLayout>
            </cw:CwFrame>
	    </cw:CwFormLayout>
	</div>
	</form>
</body>
</html>
