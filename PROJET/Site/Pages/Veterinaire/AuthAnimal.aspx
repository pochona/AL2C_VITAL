<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="AuthAnimal.aspx.vb" Inherits="VITAL.PageAuthAnimal" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
	<title></title>
</head>
<body>
	<form id="frmData" runat="server">
	<div>
        <cw:CwFormLayout runat="server" ID="frlGeneral" >
            <cw:CwFrame runat="server" ID="frmSelectAnimal" Text="Sélectionner un animal" Kind="Primary">
                <cw:CwFormLayout runat="server" ID="frlSelectAnimal">
                    <cw:CwFrame runat="server" iD="frmSearchNFC" Text="Détection carte vitale" Collapsable="true" Cells-Small="6" ResetLayout="False" Width="100%" >
                        <cw:CwFormLayout runat="server" ID="frlNFC">
                            <cw:CwTextBox runat="server" ID="txtNumCarteNFC" Label="Numéro de carte" Enabled="False"></cw:CwTextBox>
                            <cw:CwPanelButtons runat="server" ID="pnlBtnNfc">
                                <cw:CwButton runat="server" ID="btnSearchNFC" Text="Lancer la recherche"></cw:CwButton>
                            </cw:CwPanelButtons>
                        </cw:CwFormLayout>
                    </cw:CwFrame>
                    <cw:CwFrame runat="server" iD="frmSearchGeneral" Text="Recherche selon critères" Collapsable="true" Cells-Small="6" ResetLayout="False" Width="100%">
                        <cw:CwFormLayout runat="server" ID="frlSearchAnimal">
                            <cw:CwTextBox runat="server" ID="txtNumCarte" Label="Numéro de carte" ></cw:CwTextBox>
                            <cw:CwTextBox runat="server" ID="txtNomAnimal" Label="Nom de l'animal" ></cw:CwTextBox>
                            <cw:CwTextBox runat="server" ID="txtNomProprio" Label="Nom du propriétaire" ></cw:CwTextBox>
                            <cw:CwTextBox runat="server" ID="txtPrenomProprio" Label="Prénom du propriétaire" ></cw:CwTextBox>
                            <cw:CwPanelButtons runat="server" ID="pbnBtnGene">
                                <cw:CwButton runat="server" ID="btnSearchAnimal" Text="Rechercher"></cw:CwButton>
                            </cw:CwPanelButtons>
                        </cw:CwFormLayout>
                    </cw:CwFrame>
                </cw:CwFormLayout>
            </cw:CwFrame>
            <cw:CwFrame runat="server" ID="frmResultats">
                 <cw:CwDataGrid runat="server" id="dtgResultats" Title="{0} animaux trouvés"></cw:CwDataGrid>
             </cw:CwFrame>
        </cw:CwFormLayout>
	</div>
	</form>
</body>
</html>
