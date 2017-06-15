<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="histo_consultation.aspx.vb" Inherits="VITAL.Pagehisto_consultation" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
	<title>Historique consultations</title>
</head>
<body>
	<form id="frmData" runat="server">
	<div>
    <cw:CwFormLayout runat="server" ID="frlGeneral">
        <cw:CwFrame runat="server" ID="frmGenral" text="Dernières consultations" Collapsable="true" >
            <cw:CwFormLayout runat="server" ID="frlDtl">
                <cw:CwTextBox runat="server" ID="txtTest" Label="Vétérinaire" Enabled="false" Text="infosRecupBD" ToolTip="Infos bulle"></cw:CwTextBox>
                <cw:CwTextBox runat="server" ID="txtTest1" Label="Date" Enabled="false" ></cw:CwTextBox>
                <cw:CwTextBox runat="server" ID="txtTest2" Label="Coût" Enabled="false" Suffix="€"></cw:CwTextBox>
            </cw:CwFormLayout>
        </cw:CwFrame>
    </cw:CwFormLayout>

    <cw:CwFormLayout runat="server" ID="frlGeneral2">
        <cw:CwFrame runat="server" ID="frmGenral2" text="Historique" Collapsable="true" >
            <cw:CwFormLayout runat="server" ID="frlDtl2">
                <cw:CwDataGrid runat="server" ID="grdHistorique" />
            </cw:CwFormLayout>
        </cw:CwFrame>
    </cw:CwFormLayout>
	
	</div>
	</form>
</body>
</html>
