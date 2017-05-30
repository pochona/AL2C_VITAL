<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="AnimalGeneral.aspx.vb" Inherits="VITAL.PageAnimalGeneral" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
	<title></title>
</head>
<body>	
    <form id="frmData" runat="server">
	<div>
        <cw:CwFormLayout runat="server" ID="frlGeneAniml">
            <cw:CwFrame runat="server" ID="frmAnimal" text="NomAnimal" Collapsable="true" >
                <cw:CwFormLayout runat="server" ID="frlDtl" DefaultCells-ExtraSmall="6" DefaultLabelCells-ExtraSmall="1">
                    <cw:CwHtmlEditor ID="hmtlImageTest" runat="server" Cells-ExtraSmall="3" Height="300px" />
                    <cw:CwFormLayout runat="server" ID="frlInfos" DefaultCells-ExtraSmall="6">
                        <cw:CwTextBox runat="server" ID="txtNom" Label="Nom" Enabled="false" IsMandatory="true" visible="false" ></cw:CwTextBox>
                        <cw:CwNumericTextBox runat="server" ID="ntbAge" Label="Age" Enabled="false" Suffix="année(s)"></cw:CwNumericTextBox>
                        <cw:CwNumericTextBox  runat="server" ID="ntbPoids" Label="Poids" Enabled="false" Suffix="kg"></cw:CwNumericTextBox>
                        <cw:CwNumericTextBox runat="server" ID="ntbTaille" Label="Taille" Enabled="false" Suffix="cm"></cw:CwNumericTextBox>
                        <cw:CwTextBox runat="server" ID="txtNumPuce" Label="Numéro de puce" Enabled="false" ></cw:CwTextBox>
                        <cw:CwTextBox runat="server" ID="txtNumCarte" Label="Numéro de carte vitale" Enabled="false" ></cw:CwTextBox>
                        <cw:CwDateTextBox runat="server" ID="dtbNaiss" Label="Date naissance" Enabled="false" ></cw:CwDateTextBox>
                        <cw:CwDateTextBox runat="server" ID="dtbDeces" Label="Date décès" Visible="false" Enabled="false" ></cw:CwDateTextBox>
                        <cw:CwComboBox runat="server" IsMandatory="true"  ID="cboType" RoleEdit="!*" Label="Type"></cw:CwComboBox>
                        <cw:CwComboBox runat="server" IsMandatory="true"  ID="cboRace" RoleEdit="!*" Label="Race"></cw:CwComboBox>
                    </cw:CwFormLayout>
                </cw:CwFormLayout>
                <cw:CwPanelButtons runat="server" ID="pbnBtnsInfos">
                    <cw:CwButton runat="server" ID="btnModif" Text="Modifier" Kind="Primary"></cw:CwButton>
                    <cw:CwButton runat="server" ID="btnSave" Text="Enregister" Kind="Success" ></cw:CwButton>
                    <cw:CwButton runat="server" ID="btnImage"  Kind="Primary" ></cw:CwButton>
                </cw:CwPanelButtons>
            </cw:CwFrame>
	    </cw:CwFormLayout>
	    <cw:CwFormLayout runat="server" ID="CwFormLayout1">
            <cw:CwFrame runat="server" ID="frmDepenses" text="Dépenses" Collapsable="true" >
                <cw:CwFormLayout runat="server" ID="CwFormLayout2">
                    <cw:CwTextBox runat="server" ID="txtTotal" Label="Total" Enabled="false" Text="" ToolTip="Infos bulle"></cw:CwTextBox>
                    <cw:CwTextBox runat="server" ID="txtCourbe" Label="Courbe" Enabled="false" Text="" ToolTip="Infos bulle"></cw:CwTextBox>
                    <cw:CwTextBox runat="server" ID="txtMsgMut" Label="Découvrez ce que vous auriez économisé avec une mutelle  " Enabled="false" Text="" ></cw:CwTextBox>
                </cw:CwFormLayout>
            </cw:CwFrame>
	    </cw:CwFormLayout>

        <cw:CwPanelButtons runat="server" ID="pnbvet">
            <cw:CwButton runat="server" ID="btnvet1" Text="Consuler les consultations" Kind="Default"></cw:CwButton>
            <cw:CwButton runat="server" ID="btnvet2" Text="Ajouter des traitements" Kind="Default"></cw:CwButton>
            <cw:CwButton runat="server" ID="btnvet3" Text="Ajouter des vaccins" Kind="Default"></cw:CwButton>
         </cw:CwPanelButtons>
        
	</div>
	</form>
</body>
</html>
