<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Informations.aspx.vb" Inherits="VITAL.PageInformations" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
	<title>Mes Informations</title>
</head>
<body>
	<form id="frmData" runat="server">
	<div>
	<cw:CwFormLayout runat="server" ID="flyGeneral">
            <cw:CwFrame runat="server" ID="frmInfos" text="Mes informations" Collapsable="true" >
                <cw:CwFormLayout runat="server" ID="frlDtl">
                    <cw:CwTextBox runat="server" ID="txtNom" Label="Nom" Enabled="false" Text="infosRecupBD" ToolTip="Infos bulle"></cw:CwTextBox>
                    <cw:CwTextBox runat="server" ID="txtPrenom" Label="Prénom" Enabled="false" Text="infosRecupBD" ToolTip="Infos bulle"></cw:CwTextBox>
                    <cw:CwTextBox runat="server" ID="txtAdr" Label="Adresse" Enabled="false" Text="infosRecupBD" ToolTip="Infos bulle"></cw:CwTextBox>
                </cw:CwFormLayout>
            </cw:CwFrame>
	    </cw:CwFormLayout>
	</div>
	</form>
</body>
</html>
