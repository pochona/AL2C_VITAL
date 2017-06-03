<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Exemple.aspx.vb" Inherits="VITAL.PageExemple" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
	<title></title>
</head>
<body>
	<form id="frmData" runat="server">
	<div>
	<cw:CwFormLayout runat="server" ID="frlGeneral">
        <cw:CwFrame runat="server" ID="frmGenral" text="Informations générales" Collapsable="true" >
            <cw:CwFormLayout runat="server" ID="frlDtl">
                <cw:CwTextBox runat="server" ID="txtTest" Label="Nom"  ToolTip="Infos bulle"></cw:CwTextBox>
                <cw:CwTextBox runat="server" ID="txtTest1" Label="Nom de la race" Text="Text affiché" ToolTip="Infos bulle"></cw:CwTextBox>
        </cw:CwFormLayout>
        </cw:CwFrame>
	</cw:CwFormLayout>
    <cw:CwFormLayout runat="server" ID="frlGeneral2">
        <cw:CwFrame runat="server" ID="frmGenral2" text="Informations générales" Collapsable="true" Kind="Success"  >
            <cw:CwFormLayout runat="server" ID="frlDtl2"  DefaultCells-Small="6" DefaultLabelCells-Small="3">
                <cw:CwTextBox runat="server" ID="txtTest2" Label="Nom" Text="Text affiché" ToolTip="Infos bulle"></cw:CwTextBox>
                <cw:CwTextBox runat="server" ID="txtTest3" Label="Nom" Text="Text affiché" ToolTip="Infos bulle"></cw:CwTextBox>
                <cw:CwTextBox runat="server" ID="txtTest4" Label="Nom" Text="Text affiché" ToolTip="Infos bulle"></cw:CwTextBox>
                <cw:CwTextBox runat="server" ID="txtTest5" Label="Nom" Text="Text affiché" ToolTip="Infos bulle"></cw:CwTextBox>
       
            </cw:CwFormLayout>
        </cw:CwFrame>
	</cw:CwFormLayout>
    <cw:CwFormLayout runat="server" ID="CwFormLayout1">
        <cw:CwFrame runat="server" ID="CwFrame1" text="Informations générales" Collapsable="true" Kind="Primary"  >
            <cw:CwFormLayout runat="server" ID="CwFormLayout2"  DefaultCells-Small="6" DefaultLabelCells-Small="3">
                <cw:CwTextBox runat="server" ID="CwTextBox1" Label="Nom" Text="Text affiché" ToolTip="Infos bulle"></cw:CwTextBox>
                <cw:CwTextBox runat="server" ID="CwTextBox2" Label="Nom" Text="Text affiché" ToolTip="Infos bulle"></cw:CwTextBox>
                <cw:CwTextBox runat="server" ID="CwTextBox3" Label="Nom" Text="Text affiché" ToolTip="Infos bulle" ResetLayout="True"></cw:CwTextBox>
                <cw:CwTextBox runat="server" ID="CwTextBox4" Label="Nom" Text="Text affiché" ToolTip="Infos bulle" ResetLayout="True"></cw:CwTextBox>
       
            </cw:CwFormLayout>
        </cw:CwFrame>
	</cw:CwFormLayout>
         <cw:CwPanelButtons runat="server" ID="pnb">
            <cw:CwButton runat="server" ID="btn1" Text="Cliquez moi" Kind="Default"></cw:CwButton>
            <cw:CwButton runat="server" ID="btn2" Text="Cliquez moi" Kind="Info"></cw:CwButton>
            <cw:CwButton runat="server" ID="btn3" Text="Cliquez moi" Kind="Link"></cw:CwButton>
            <cw:CwButton runat="server" ID="btn4" Text="Cliquez moi" Kind="Warning"></cw:CwButton>
         </cw:CwPanelButtons>

	</div>
	</form>
</body>
</html>
