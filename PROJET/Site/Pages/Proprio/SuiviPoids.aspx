﻿<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="SuiviPoids.aspx.vb" Inherits="VITAL.PageSuiviPoids" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
	<title>SuiviPoids</title>
</head>
<body>
	<form id="frmData" runat="server">
	<div>
	 <cw:CwFormLayout runat="server" ID="frlGeneral">
            <cw:CwFrame runat="server" ID="frmEvolution" Kind="Primary" text="Evolution du poids" Collapsable="true" >
                <cw:CwFormLayout runat="server" ID="frlPoids" >
                    <cw:CwTextBox runat="server" ID="txtPoidsActuel" Cells-Small="4" Label="Poids actuel" Suffix="kg" Enabled="false" ></cw:CwTextBox>
                    <cw:CwFrame runat="server" ID="frmGraph" Text="Graphique d'évolution (kg)"  width="100%" Cells-Small="6" ResetLayout="True">
                        <cw:CwFormLayout runat="server" ID="frlGraph" >
                            <cw:CwLinearChart runat="server" ID="lnctPoids"/>
                        </cw:CwFormLayout>
                    </cw:CwFrame>
                </cw:CwFormLayout>
            </cw:CwFrame>
            <cw:CwFrame runat="server" ID="frmConseilsDietétiq" text="Conseils diététiques" Collapsable="true" >
                <cw:CwFormLayout runat="server" ID="CwFormLayout1">
                    <cw:CwTextBox runat="server" ID="txtConseils" Label="" Text="" Enabled="false" ></cw:CwTextBox>
                    <cw:CwDateTextBox runat="server" ID="dtbLastConseil"></cw:CwDateTextBox>
                </cw:CwFormLayout>
            </cw:CwFrame>
	    </cw:CwFormLayout>
	</div>
        
	</form>
</body>
</html>
