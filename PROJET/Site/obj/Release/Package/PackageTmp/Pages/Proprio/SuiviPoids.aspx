<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="SuiviPoids.aspx.vb" Inherits="VITAL.PageSuiviPoids" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
	<title>SuiviPoids</title>
</head>
<body>
	<form id="frmData" runat="server">
	<div>
	 <cw:CwFormLayout runat="server" ID="frlGeneral">
            <cw:CwFrame runat="server" ID="frmEvolution" text="Evolution du poids" Collapsable="true" >
                <cw:CwFormLayout runat="server" ID="frlPoids">
                    <cw:CwTextBox runat="server" ID="txtPoidsActuel" Label="Poids actuel" Enabled="false" ></cw:CwTextBox>
                   
                </cw:CwFormLayout>
            </cw:CwFrame>
	    </cw:CwFormLayout>
	</div>
        
	</form>
</body>
</html>
