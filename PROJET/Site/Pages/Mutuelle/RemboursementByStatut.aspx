<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="RemboursementByStatut.aspx.vb" Inherits="VITAL.PageRemboursementByStatut" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
	<title>Recherche des remboursements</title>
</head>
<body>
	<form id="frmremboursementStatut" runat="server">
	<div>

        <cw:CwFormLayout runat="server" ID="layoutremboursementStatut">
            <cw:CwFrame runat="server" ID="frameremboursementStatut" text="Remboursements" Collapsable="true" >
                <cw:CwFormLayout runat="server" ID="frlayoutremboursementStatutlDtl2">
                 
                  <cw:CwRadioButtonList runat="server" ID="rblStatut" Label="Filtrer par statut" AutoPostBack="True"  >
                            <asp:ListItem Value="1" Text="En cours"></asp:ListItem>
                            <asp:ListItem Value="2" Text="Payé"></asp:ListItem>
                    </cw:CwRadioButtonList>
                </cw:CwFormLayout>
            </cw:CwFrame>
	    </cw:CwFormLayout>

  <cw:CwPanelButtons runat="server" ID="panelremboursementStatut">
           
            <cw:CwDataGrid runat="server" ID="grdtestmutu" Title="{0} Remboursement(s)" />
  </cw:CwPanelButtons>
	
	</div>
	</form>
</body>
</html>
