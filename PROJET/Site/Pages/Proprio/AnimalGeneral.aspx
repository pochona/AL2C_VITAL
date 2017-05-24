<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="AnimalGeneral.aspx.vb" Inherits="VITAL.PageAnimalGeneral" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
	<title></title>
</head>
<body>	<form id="frmData" runat="server">
	<div>
	    <cw:CwFormLayout runat="server" ID="layoutvet1">
            <cw:CwFrame runat="server" ID="frmAnimal" text="NomAnimal" Collapsable="true" >
                <cw:CwFormLayout runat="server" ID="frlDtl">
                    <cw:CwTextBox runat="server" ID="txtRace" Label="Race" Enabled="false" ></cw:CwTextBox>
                    <cw:CwTextBox runat="server" ID="txtPoids" Label="Poids" Enabled="false" ></cw:CwTextBox>
                    <cw:CwTextBox runat="server" ID="txtAge" Label="Age" Enabled="false" ></cw:CwTextBox>
                </cw:CwFormLayout>
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
