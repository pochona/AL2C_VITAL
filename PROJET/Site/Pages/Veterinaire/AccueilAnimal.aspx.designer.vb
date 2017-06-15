'------------------------------------------------------------------------------
' <généré automatiquement>
'     Ce code a été généré par un outil.
'
'     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
'     le code est régénéré.
' </généré automatiquement>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Partial Public Class PageAccueilAnimal

    '''<summary>
    '''Contrôle frmData.
    '''</summary>
    '''<remarks>
    '''Champ généré automatiquement.
    '''Pour modifier, déplacez la déclaration de champ du fichier de concepteur dans le fichier code-behind.
    '''</remarks>
    Protected WithEvents frmData As Global.System.Web.UI.HtmlControls.HtmlForm

    '''<summary>
    '''Contrôle FrlTheBoss.
    '''</summary>
    '''<remarks>
    '''Champ généré automatiquement.
    '''Pour modifier, déplacez la déclaration de champ du fichier de concepteur dans le fichier code-behind.
    '''</remarks>
    Protected WithEvents FrlTheBoss As Global.Corail.Web.CwFormLayout

    '''<summary>
    '''Contrôle frmInfosAniml.
    '''</summary>
    '''<remarks>
    '''Champ généré automatiquement.
    '''Pour modifier, déplacez la déclaration de champ du fichier de concepteur dans le fichier code-behind.
    '''</remarks>
    Protected WithEvents frmInfosAniml As Global.Corail.Web.CwFrame

    '''<summary>
    '''Contrôle frlInfosAniml.
    '''</summary>
    '''<remarks>
    '''Champ généré automatiquement.
    '''Pour modifier, déplacez la déclaration de champ du fichier de concepteur dans le fichier code-behind.
    '''</remarks>
    Protected WithEvents frlInfosAniml As Global.Corail.Web.CwFormLayout

    '''<summary>
    '''Contrôle txtNom.
    '''</summary>
    '''<remarks>
    '''Champ généré automatiquement.
    '''Pour modifier, déplacez la déclaration de champ du fichier de concepteur dans le fichier code-behind.
    '''</remarks>
    Protected WithEvents txtNom As Global.Corail.Web.CwTextBox

    '''<summary>
    '''Contrôle ntbAge.
    '''</summary>
    '''<remarks>
    '''Champ généré automatiquement.
    '''Pour modifier, déplacez la déclaration de champ du fichier de concepteur dans le fichier code-behind.
    '''</remarks>
    Protected WithEvents ntbAge As Global.Corail.Web.CwNumericTextBox

    '''<summary>
    '''Contrôle ntbPoids.
    '''</summary>
    '''<remarks>
    '''Champ généré automatiquement.
    '''Pour modifier, déplacez la déclaration de champ du fichier de concepteur dans le fichier code-behind.
    '''</remarks>
    Protected WithEvents ntbPoids As Global.Corail.Web.CwNumericTextBox

    '''<summary>
    '''Contrôle ntbTaille.
    '''</summary>
    '''<remarks>
    '''Champ généré automatiquement.
    '''Pour modifier, déplacez la déclaration de champ du fichier de concepteur dans le fichier code-behind.
    '''</remarks>
    Protected WithEvents ntbTaille As Global.Corail.Web.CwNumericTextBox

    '''<summary>
    '''Contrôle txtNumPuce.
    '''</summary>
    '''<remarks>
    '''Champ généré automatiquement.
    '''Pour modifier, déplacez la déclaration de champ du fichier de concepteur dans le fichier code-behind.
    '''</remarks>
    Protected WithEvents txtNumPuce As Global.Corail.Web.CwTextBox

    '''<summary>
    '''Contrôle chkCarte.
    '''</summary>
    '''<remarks>
    '''Champ généré automatiquement.
    '''Pour modifier, déplacez la déclaration de champ du fichier de concepteur dans le fichier code-behind.
    '''</remarks>
    Protected WithEvents chkCarte As Global.Corail.Web.CwCheckBox

    '''<summary>
    '''Contrôle txtCarte.
    '''</summary>
    '''<remarks>
    '''Champ généré automatiquement.
    '''Pour modifier, déplacez la déclaration de champ du fichier de concepteur dans le fichier code-behind.
    '''</remarks>
    Protected WithEvents txtCarte As Global.Corail.Web.CwTextBox

    '''<summary>
    '''Contrôle dtbNaiss.
    '''</summary>
    '''<remarks>
    '''Champ généré automatiquement.
    '''Pour modifier, déplacez la déclaration de champ du fichier de concepteur dans le fichier code-behind.
    '''</remarks>
    Protected WithEvents dtbNaiss As Global.Corail.Web.CwDateTextBox

    '''<summary>
    '''Contrôle dtbDeces.
    '''</summary>
    '''<remarks>
    '''Champ généré automatiquement.
    '''Pour modifier, déplacez la déclaration de champ du fichier de concepteur dans le fichier code-behind.
    '''</remarks>
    Protected WithEvents dtbDeces As Global.Corail.Web.CwDateTextBox

    '''<summary>
    '''Contrôle cboType.
    '''</summary>
    '''<remarks>
    '''Champ généré automatiquement.
    '''Pour modifier, déplacez la déclaration de champ du fichier de concepteur dans le fichier code-behind.
    '''</remarks>
    Protected WithEvents cboType As Global.Corail.Web.CwComboBox

    '''<summary>
    '''Contrôle cboRace.
    '''</summary>
    '''<remarks>
    '''Champ généré automatiquement.
    '''Pour modifier, déplacez la déclaration de champ du fichier de concepteur dans le fichier code-behind.
    '''</remarks>
    Protected WithEvents cboRace As Global.Corail.Web.CwComboBox

    '''<summary>
    '''Contrôle txtIdPropCache.
    '''</summary>
    '''<remarks>
    '''Champ généré automatiquement.
    '''Pour modifier, déplacez la déclaration de champ du fichier de concepteur dans le fichier code-behind.
    '''</remarks>
    Protected WithEvents txtIdPropCache As Global.Corail.Web.CwTextBox

    '''<summary>
    '''Contrôle stbProprio.
    '''</summary>
    '''<remarks>
    '''Champ généré automatiquement.
    '''Pour modifier, déplacez la déclaration de champ du fichier de concepteur dans le fichier code-behind.
    '''</remarks>
    Protected WithEvents stbProprio As Global.Corail.Web.CwSelectTextBox

    '''<summary>
    '''Contrôle pbnInfosAnimal.
    '''</summary>
    '''<remarks>
    '''Champ généré automatiquement.
    '''Pour modifier, déplacez la déclaration de champ du fichier de concepteur dans le fichier code-behind.
    '''</remarks>
    Protected WithEvents pbnInfosAnimal As Global.Corail.Web.CwPanelButtons

    '''<summary>
    '''Contrôle btnModifierInfoAnml.
    '''</summary>
    '''<remarks>
    '''Champ généré automatiquement.
    '''Pour modifier, déplacez la déclaration de champ du fichier de concepteur dans le fichier code-behind.
    '''</remarks>
    Protected WithEvents btnModifierInfoAnml As Global.Corail.Web.CwButton

    '''<summary>
    '''Contrôle btnSaveInfoAnml.
    '''</summary>
    '''<remarks>
    '''Champ généré automatiquement.
    '''Pour modifier, déplacez la déclaration de champ du fichier de concepteur dans le fichier code-behind.
    '''</remarks>
    Protected WithEvents btnSaveInfoAnml As Global.Corail.Web.CwButton

    '''<summary>
    '''Contrôle btnNewAnimal.
    '''</summary>
    '''<remarks>
    '''Champ généré automatiquement.
    '''Pour modifier, déplacez la déclaration de champ du fichier de concepteur dans le fichier code-behind.
    '''</remarks>
    Protected WithEvents btnNewAnimal As Global.Corail.Web.CwButton

    '''<summary>
    '''Contrôle frmNewConsul.
    '''</summary>
    '''<remarks>
    '''Champ généré automatiquement.
    '''Pour modifier, déplacez la déclaration de champ du fichier de concepteur dans le fichier code-behind.
    '''</remarks>
    Protected WithEvents frmNewConsul As Global.Corail.Web.CwFrame

    '''<summary>
    '''Contrôle pbnNewConsult.
    '''</summary>
    '''<remarks>
    '''Champ généré automatiquement.
    '''Pour modifier, déplacez la déclaration de champ du fichier de concepteur dans le fichier code-behind.
    '''</remarks>
    Protected WithEvents pbnNewConsult As Global.Corail.Web.CwPanelButtons

    '''<summary>
    '''Contrôle btnNewConsult.
    '''</summary>
    '''<remarks>
    '''Champ généré automatiquement.
    '''Pour modifier, déplacez la déclaration de champ du fichier de concepteur dans le fichier code-behind.
    '''</remarks>
    Protected WithEvents btnNewConsult As Global.Corail.Web.CwButton

    '''<summary>
    '''Contrôle frmListConsult.
    '''</summary>
    '''<remarks>
    '''Champ généré automatiquement.
    '''Pour modifier, déplacez la déclaration de champ du fichier de concepteur dans le fichier code-behind.
    '''</remarks>
    Protected WithEvents frmListConsult As Global.Corail.Web.CwFrame

    '''<summary>
    '''Contrôle dtgConsultations.
    '''</summary>
    '''<remarks>
    '''Champ généré automatiquement.
    '''Pour modifier, déplacez la déclaration de champ du fichier de concepteur dans le fichier code-behind.
    '''</remarks>
    Protected WithEvents dtgConsultations As Global.Corail.Web.CwDataGrid

    '''<summary>
    '''Contrôle frmListTraitements.
    '''</summary>
    '''<remarks>
    '''Champ généré automatiquement.
    '''Pour modifier, déplacez la déclaration de champ du fichier de concepteur dans le fichier code-behind.
    '''</remarks>
    Protected WithEvents frmListTraitements As Global.Corail.Web.CwFrame

    '''<summary>
    '''Contrôle pbnTraitements.
    '''</summary>
    '''<remarks>
    '''Champ généré automatiquement.
    '''Pour modifier, déplacez la déclaration de champ du fichier de concepteur dans le fichier code-behind.
    '''</remarks>
    Protected WithEvents pbnTraitements As Global.Corail.Web.CwPanelButtons

    '''<summary>
    '''Contrôle btnNewTraitement.
    '''</summary>
    '''<remarks>
    '''Champ généré automatiquement.
    '''Pour modifier, déplacez la déclaration de champ du fichier de concepteur dans le fichier code-behind.
    '''</remarks>
    Protected WithEvents btnNewTraitement As Global.Corail.Web.CwButton

    '''<summary>
    '''Contrôle dtgTraitements.
    '''</summary>
    '''<remarks>
    '''Champ généré automatiquement.
    '''Pour modifier, déplacez la déclaration de champ du fichier de concepteur dans le fichier code-behind.
    '''</remarks>
    Protected WithEvents dtgTraitements As Global.Corail.Web.CwDataGrid

    '''<summary>
    '''Contrôle frmListVaccins.
    '''</summary>
    '''<remarks>
    '''Champ généré automatiquement.
    '''Pour modifier, déplacez la déclaration de champ du fichier de concepteur dans le fichier code-behind.
    '''</remarks>
    Protected WithEvents frmListVaccins As Global.Corail.Web.CwFrame

    '''<summary>
    '''Contrôle frlVaccination.
    '''</summary>
    '''<remarks>
    '''Champ généré automatiquement.
    '''Pour modifier, déplacez la déclaration de champ du fichier de concepteur dans le fichier code-behind.
    '''</remarks>
    Protected WithEvents frlVaccination As Global.Corail.Web.CwFormLayout

    '''<summary>
    '''Contrôle dttxtNewVaccin.
    '''</summary>
    '''<remarks>
    '''Champ généré automatiquement.
    '''Pour modifier, déplacez la déclaration de champ du fichier de concepteur dans le fichier code-behind.
    '''</remarks>
    Protected WithEvents dttxtNewVaccin As Global.Corail.Web.CwDateTextBox

    '''<summary>
    '''Contrôle CboVaccin.
    '''</summary>
    '''<remarks>
    '''Champ généré automatiquement.
    '''Pour modifier, déplacez la déclaration de champ du fichier de concepteur dans le fichier code-behind.
    '''</remarks>
    Protected WithEvents CboVaccin As Global.Corail.Web.CwComboBox

    '''<summary>
    '''Contrôle pnbBtnsVaccin.
    '''</summary>
    '''<remarks>
    '''Champ généré automatiquement.
    '''Pour modifier, déplacez la déclaration de champ du fichier de concepteur dans le fichier code-behind.
    '''</remarks>
    Protected WithEvents pnbBtnsVaccin As Global.Corail.Web.CwPanelButtons

    '''<summary>
    '''Contrôle btnNewVaccin.
    '''</summary>
    '''<remarks>
    '''Champ généré automatiquement.
    '''Pour modifier, déplacez la déclaration de champ du fichier de concepteur dans le fichier code-behind.
    '''</remarks>
    Protected WithEvents btnNewVaccin As Global.Corail.Web.CwButton

    '''<summary>
    '''Contrôle dtgVaccins.
    '''</summary>
    '''<remarks>
    '''Champ généré automatiquement.
    '''Pour modifier, déplacez la déclaration de champ du fichier de concepteur dans le fichier code-behind.
    '''</remarks>
    Protected WithEvents dtgVaccins As Global.Corail.Web.CwDataGrid

    '''<summary>
    '''Contrôle frmListConseilDiet.
    '''</summary>
    '''<remarks>
    '''Champ généré automatiquement.
    '''Pour modifier, déplacez la déclaration de champ du fichier de concepteur dans le fichier code-behind.
    '''</remarks>
    Protected WithEvents frmListConseilDiet As Global.Corail.Web.CwFrame

    '''<summary>
    '''Contrôle frlDtlDiet.
    '''</summary>
    '''<remarks>
    '''Champ généré automatiquement.
    '''Pour modifier, déplacez la déclaration de champ du fichier de concepteur dans le fichier code-behind.
    '''</remarks>
    Protected WithEvents frlDtlDiet As Global.Corail.Web.CwFormLayout

    '''<summary>
    '''Contrôle txtNewConseil.
    '''</summary>
    '''<remarks>
    '''Champ généré automatiquement.
    '''Pour modifier, déplacez la déclaration de champ du fichier de concepteur dans le fichier code-behind.
    '''</remarks>
    Protected WithEvents txtNewConseil As Global.Corail.Web.CwTextBox

    '''<summary>
    '''Contrôle pnbBtnsDiet.
    '''</summary>
    '''<remarks>
    '''Champ généré automatiquement.
    '''Pour modifier, déplacez la déclaration de champ du fichier de concepteur dans le fichier code-behind.
    '''</remarks>
    Protected WithEvents pnbBtnsDiet As Global.Corail.Web.CwPanelButtons

    '''<summary>
    '''Contrôle btnNewConseil.
    '''</summary>
    '''<remarks>
    '''Champ généré automatiquement.
    '''Pour modifier, déplacez la déclaration de champ du fichier de concepteur dans le fichier code-behind.
    '''</remarks>
    Protected WithEvents btnNewConseil As Global.Corail.Web.CwButton

    '''<summary>
    '''Contrôle dtgDietetiques.
    '''</summary>
    '''<remarks>
    '''Champ généré automatiquement.
    '''Pour modifier, déplacez la déclaration de champ du fichier de concepteur dans le fichier code-behind.
    '''</remarks>
    Protected WithEvents dtgDietetiques As Global.Corail.Web.CwDataGrid
End Class
