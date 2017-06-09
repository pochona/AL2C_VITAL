<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="ListeConsult.aspx.vb" Inherits="VITAL.PageListeConsult" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
	<title>Historique consultations</title>
</head>
<body>
	<form id="frmData" runat="server">
	<div>
    <cw:CwFormLayout runat="server" ID="frlGeneral">
        <cw:CwFrame runat="server" ID="frmGenral" text="Dernières consultations" Collapsable="true" >
            <cw:CwFormLayout runat="server" ID="frlDtl">
                <cw:CwNumericTextBox runat="server" ID="ntbMontant" Label="Montant" Suffix="€" Enabled="false" ></cw:CwNumericTextBox>
                <cw:CwTextBox runat="server" ID="txtNomAnimal" Label="Nom animal" Enabled="false" ></cw:CwTextBox>
               </cw:CwFormLayout>
        </cw:CwFrame>
    </cw:CwFormLayout>

    <cw:CwFormLayout runat="server" ID="frlGeneral2">
        <cw:CwFrame runat="server" ID="frmGenral2" text="Historique" Collapsable="true" >
             <cw:CwDataGrid runat="server" ID="grdHistorique" />
        </cw:CwFrame>
    </cw:CwFormLayout>
	
	</div>
	</form>
</body>
</html>
