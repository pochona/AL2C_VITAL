<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="InfoPartenaire.aspx.vb" Inherits="VITAL.PageInfoPartenaire" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
	<title>InfoPartenaire</title>
</head>
<body>
	<form id="frmData" runat="server">
	<div>
        <cw:CwFormLayout runat="server" ID="frlGene">
            <cw:CwFrame runat="server" ID="frmAnix">
                <cw:CwFormLayout runat="server" ID="frlAnix">
                    <cw:CwImage runat="server" ID="imgAnix" ImageUrl="~/Images/logo.png" />
                    <cw:CwTextBox runat="server" id="txtAnimx" Enabled="false" Text="" TextMode="MultiLine"></cw:CwTextBox>
                    <cw:CwPanelButtons runat="server" ID="pbnAnix">
                          <cw:CwButton runat="server" text="Découvrez ce que vous auriez économisé avec une mutelle" ID="btnLink" Kind="Link" NavigateUrl="http://animaux-relax.com/"></cw:CwButton>
                    </cw:CwPanelButtons>
                </cw:CwFormLayout>
	        </cw:CwFrame>
            <cw:CwFrame runat="server" ID="frmDz">
                <cw:CwFormLayout runat="server" ID="drlDz">

                </cw:CwFormLayout>
	        </cw:CwFrame>
        </cw:CwFormLayout>
	</div>
	</form>
</body>
</html>
