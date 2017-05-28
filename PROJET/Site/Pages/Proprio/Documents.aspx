<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Documents.aspx.vb" Inherits="VITAL.PageDocuments" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
	<title>Documents</title>
</head>
<body>
    <form id="frmData" runat="server">
	<div>
	 <cw:CwFormLayout runat="server" ID="frlGeneral">
            <cw:CwFrame runat="server" ID="frmAjoutDoc" text="Ajouter un document" Collapsable="true" >
                <cw:CwFormLayout runat="server" ID="frlDtl">
                   <cw:CwUploadBox runat="server" ID="uplDoc" Label="Sélectionnez un fichier" Cells-ExtraSmall="6"></cw:CwUploadBox>
                    <cw:CwButton runat="server" ID="btnSaveDoc" ImageName="plus-circle" Text="Ajouter"></cw:CwButton>
                </cw:CwFormLayout>
            </cw:CwFrame>
            <cw:CwFrame runat="server" ID="frmDoc" text="Documents" Collapsable="true" >
                <cw:CwDataGrid runat="server" ID="dtgDocs" Title="{0} document(s)"></cw:CwDataGrid>   
           </cw:CwFrame>
	    </cw:CwFormLayout>
        </div>
        </form>
</body>
</html>
