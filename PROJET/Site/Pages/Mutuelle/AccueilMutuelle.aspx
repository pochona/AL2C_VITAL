﻿<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="AccueilMutuelle.aspx.vb" Inherits="VITAL.PageAccueilMutuelle" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
	<title>Accueil mutuelle</title>
</head>
<body>
	<form id="frmData" runat="server">
	<div>
	
	    <cw:CwDataGrid runat="server" ID="consultClient" Title="{0} Consultation(s)" />
            
        

        <cw:CwPanelButtons runat="server" ID="panelmut1">
            <cw:CwButton runat="server" ID="btnmut1" Text="CONSULTER UN CLIENT" Kind="Default"></cw:CwButton>
            <cw:CwButton runat="server" ID="btnmut2" Text="AJOUTER UN CONTRAT CLIENT" Kind="Default"></cw:CwButton>
         </cw:CwPanelButtons>


	</div>
	</form>
</body>
</html>
