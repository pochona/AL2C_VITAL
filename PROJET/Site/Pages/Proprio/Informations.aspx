<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Informations.aspx.vb" Inherits="VITAL.PageInformations" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
	<title>Mes Informations</title>
</head>
<body>
	<form id="frmData" runat="server">
	<div>
	<cw:CwFormLayout runat="server" ID="flyGeneral">
            <cw:CwFrame runat="server" ID="frmInfos" text="Mes informations" Collapsable="true" >
                <cw:CwFormLayout runat="server" ID="frlDtl">
                    <cw:CwTextBox runat="server" ID="txtNom" Label="Nom" Enabled="false"></cw:CwTextBox>
                    <cw:CwTextBox runat="server" ID="txtPrenom" Label="Prénom" Enabled="false"></cw:CwTextBox>
                    <cw:CwTextBox runat="server" ID="txtAdresse" Label="Adresse" Enabled="false"></cw:CwTextBox>
                    <cw:CwTextBox runat="server" ID="txtTelephone" Label="Téléphone" Enabled="false"></cw:CwTextBox>
                    <cw:CwTextBox runat="server" ID="txtMail" Label="Mail" Enabled="false"></cw:CwTextBox>
                </cw:CwFormLayout>
                <cw:CwPanelButtons runat="server" ID="pbnBtnsInfos">
                    <cw:CwButton runat="server" ID="btnModif" Text="Modifier" Kind="Primary"></cw:CwButton>
                    <cw:CwButton runat="server" ID="btnSave" Text="Enregister" Kind="Success" ></cw:CwButton>
                </cw:CwPanelButtons>
            </cw:CwFrame>
	    </cw:CwFormLayout>
	</div>
	</form>
</body>
</html>
