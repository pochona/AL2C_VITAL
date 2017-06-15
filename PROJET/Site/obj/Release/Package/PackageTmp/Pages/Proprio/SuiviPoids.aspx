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
            <cw:CwFrame runat="server" ID="frmEvolution" Kind="Primary" Width="100%" text="Evolution du poids"  Collapsable="true" Cells-Small="6" ResetLayout="False">
                <cw:CwFormLayout runat="server" ID="frlPoids" >
                    <cw:CwTextBox runat="server" ID="txtPoidsActuel"  Label="Poids actuel" Suffix="kg" Enabled="false" ></cw:CwTextBox>
                    <cw:CwFrame runat="server" ID="frmGraphPoids" Text="Graphique d'évolution (kg)"  width="100%"  ResetLayout="True">
                        <cw:CwFormLayout runat="server" ID="frlGraphPoids" >
                            <cw:CwLinearChart runat="server" ID="lnctPoids"/>
                        </cw:CwFormLayout>
                    </cw:CwFrame>
                </cw:CwFormLayout>
            </cw:CwFrame>

            <cw:CwFrame runat="server" ID="frmTaille" Kind="Primary" text="Evolution de la taille" Width="100%" Collapsable="true" Cells-Small="6" ResetLayout="False">
                <cw:CwFormLayout runat="server" ID="frlTaille" >
                    <cw:CwTextBox runat="server" ID="txtTaille" Label="Taille actuelle" Suffix="cm" Enabled="false" ></cw:CwTextBox>
                    <cw:CwFrame runat="server" ID="frmGraphTaille" Text="Graphique d'évolution (cm)"  width="100%" ResetLayout="True">
                        <cw:CwFormLayout runat="server" ID="frlGraphTaille" >
                            <cw:CwLinearChart runat="server" ID="lnctTaille"/>
                        </cw:CwFormLayout>
                    </cw:CwFrame>
                </cw:CwFormLayout>
            </cw:CwFrame>

            <cw:CwFrame runat="server" ID="frmConseilsDietétiq" text="Conseils diététiques" Collapsable="true" >
                <cw:CwFormLayout runat="server" ID="CwFormLayout1">
                    <cw:CwTextBox runat="server" ID="txtConseils" Label="Contenu du dernier conseil"  Enabled="false" ></cw:CwTextBox>
                    <cw:CwDateTextBox runat="server" Enabled="false" label="Date" ID="dtbLastConseil"></cw:CwDateTextBox>
                </cw:CwFormLayout>
            </cw:CwFrame>
	    </cw:CwFormLayout>
	</div>
        
	</form>
</body>
</html>
