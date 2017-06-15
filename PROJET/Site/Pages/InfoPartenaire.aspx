<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="InfoPartenaire.aspx.vb" Inherits="VITAL.PageInfoPartenaire" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
	<title>InfoPartenaire</title>
</head>
<body>
	<form id="frmData" runat="server">
	<div>
        <cw:CwFormLayout runat="server" ID="frlGene" DefaultCells-Small="4" Orientation="Horizontal">
            <cw:CwFrame runat="server" ID="frmAnix" ResetLayout="False" HorizontalAlign="Center" Height="300px">
                <cw:CwFormLayout runat="server" ID="frlAnix" DefaultCells-Small="12">
                    <cw:CwImage runat="server" ID="imgAnix" ImageUrl="~/Images/desirade.png" Height="150px" />

                    <cw:CwLabel runat="server" id="txtAnimx" Enabled="false" Width="100%" LabelCells-Small="1">
                        Désirade est une SSII spécialisée 'petites applications' pour les moyennes / grandes entreprises et les collectivités.<br />Désirade a été notre partenaire technique afin de créer l'interface</cw:CwLabel>
                    <cw:CwPanelButtons runat="server" ID="pbnAnix">
                          <cw:CwButton runat="server" text="Site de Désirade" ID="btnLink" Kind="Link" NavigateUrl="https://www.desirade.fr/"></cw:CwButton>
                    </cw:CwPanelButtons>
                </cw:CwFormLayout>
	        </cw:CwFrame>
            <cw:CwFrame runat="server" ID="CwFrame1" ResetLayout="False" HorizontalAlign="Center" Height="300px">
                <cw:CwFormLayout runat="server" ID="CwFormLayout1">
                    <cw:CwImage runat="server" ID="CwImage1" ImageUrl="~/Images/animauxrelax.png" Height="150px" />
                    <cw:CwLabel runat="server" id="CwLabel1" Enabled="false" Width="100%" LabelCells-Small="1">
                        Animaux Relax est un comparateur de mutuelles pour animaux en ligne et peut vous aider à trouver la meilleure assurance animaux du marché français
                        <br />AnimauxRelax a été notre partenaire mutuelle
                    </cw:CwLabel>
                    <cw:CwPanelButtons runat="server" ID="CwPanelButtons1">
                          <cw:CwButton runat="server" text="Site de AnimauxRelax.com" ID="CwButton1" Kind="Link" NavigateUrl="http://animaux-relax.com/"></cw:CwButton>
                    </cw:CwPanelButtons>
                </cw:CwFormLayout>
	        </cw:CwFrame>
            <cw:CwFrame runat="server" ID="CwFrame2" ResetLayout="False" HorizontalAlign="Center" Height="300px">
                <cw:CwFormLayout runat="server" ID="CwFormLayout2">
                    <cw:CwImage runat="server" ID="CwImage2" ImageUrl="~/Images/ecole vet.png" Height="150px" />
                    <cw:CwLabel runat="server" id="CwLabel2" Enabled="false" Width="100%" LabelCells-Small="1">
                        L'école Nationale Vétériaire de Toulouse est une école riche de son histoire et tournée vers l’avenir.
                        <br />L'école Nationale Vétérinaire de Toulouse a été notre partenaire Vétérinaire</cw:CwLabel>
                    <cw:CwPanelButtons runat="server" ID="CwPanelButtons2">
                          <cw:CwButton runat="server" text="Site de l'Ecole Nationale Vétérinaire de Toulouse" ID="CwButton2" Kind="Link" NavigateUrl="http://www.envt.fr/node?destination=node"></cw:CwButton>
                    </cw:CwPanelButtons>
                </cw:CwFormLayout>
	        </cw:CwFrame>

        </cw:CwFormLayout>
	</div>
	</form>
</body>
</html>
