<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Contrat.aspx.vb" Inherits="VITAL.PageContrat" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
	<title>Contrat</title>
</head>
<body>
	<form id="frmData" runat="server">
	<div>
	       <cw:CwFrame runat="server" ID="frameajoutclient" text="Informations du contrat" Collapsable="true" >
                <cw:CwFormLayout runat="server" ID="frlDtl" DefaultCells-Small="6" DefaultLabelCells-Small="6">
                    <cw:CwTextBox runat="server" Enabled="false"  ID="txtNumContrat" IsMandatory="true" Label="Numéro de contrat" ></cw:CwTextBox>
                    <cw:CwNumericTextBox Enabled="false"  Decimals="2" MaxValue="1" MinValue="0" runat="server" ID="ntbTxremb" IsMandatory="true" Suffix="%" Label="Taux de remboursement (ex : 0,30)"  ></cw:CwNumericTextBox>
                    <cw:CwDateTextBox Enabled="false"  runat="server" ID="DateDebut"  Label="Date de début"  IsMandatory="true" ></cw:CwDateTextBox>
                    <cw:CwTextBox Enabled="false"  runat="server" ID="txtMut" Label="Mutuelle"  ></cw:CwTextBox>
                    <cw:CwDateTextBox Enabled="false"  runat="server" ID="DateFin" IsMandatory="true" Label="Date de fin"  ></cw:CwDateTextBox>
                  </cw:CwFormLayout>
        
            </cw:CwFrame>
	</div>
	</form>
</body>
</html>
