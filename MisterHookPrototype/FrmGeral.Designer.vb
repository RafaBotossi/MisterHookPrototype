<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmGeral
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmGeral))
        Me.ArquivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NovoTesteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AbrirScriptToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GravarScriptToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SairToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SobreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.RecordTabStrip = New System.Windows.Forms.ToolStripButton()
        Me.StopTabStrip = New System.Windows.Forms.ToolStripButton()
        Me.PlayTabStrip = New System.Windows.Forms.ToolStripButton()
        Me.tmrStatusBar = New System.Windows.Forms.Timer(Me.components)
        Me.TabFiles = New System.Windows.Forms.TabControl()
        Me.Pnl1 = New System.Windows.Forms.Panel()
        Me.tmrRecord = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.Pnl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ArquivoToolStripMenuItem
        '
        Me.ArquivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NovoTesteToolStripMenuItem, Me.AbrirScriptToolStripMenuItem, Me.GravarScriptToolStripMenuItem, Me.SairToolStripMenuItem})
        Me.ArquivoToolStripMenuItem.Name = "ArquivoToolStripMenuItem"
        Me.ArquivoToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.ArquivoToolStripMenuItem.Text = "&Arquivo"
        '
        'NovoTesteToolStripMenuItem
        '
        Me.NovoTesteToolStripMenuItem.Name = "NovoTesteToolStripMenuItem"
        Me.NovoTesteToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.NovoTesteToolStripMenuItem.Text = "&Novo Teste (CTRL+N)"
        '
        'AbrirScriptToolStripMenuItem
        '
        Me.AbrirScriptToolStripMenuItem.Name = "AbrirScriptToolStripMenuItem"
        Me.AbrirScriptToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.AbrirScriptToolStripMenuItem.Text = "Abrir &Script (CTRL+O)"
        '
        'GravarScriptToolStripMenuItem
        '
        Me.GravarScriptToolStripMenuItem.Name = "GravarScriptToolStripMenuItem"
        Me.GravarScriptToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.GravarScriptToolStripMenuItem.Text = "&Salvar Script (CTRL+S)"
        '
        'SairToolStripMenuItem
        '
        Me.SairToolStripMenuItem.Name = "SairToolStripMenuItem"
        Me.SairToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.SairToolStripMenuItem.Text = "Sa&ir"
        '
        'AjudaToolStripMenuItem
        '
        Me.AjudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SobreToolStripMenuItem})
        Me.AjudaToolStripMenuItem.Name = "AjudaToolStripMenuItem"
        Me.AjudaToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.AjudaToolStripMenuItem.Text = "A&juda"
        '
        'SobreToolStripMenuItem
        '
        Me.SobreToolStripMenuItem.Name = "SobreToolStripMenuItem"
        Me.SobreToolStripMenuItem.Size = New System.Drawing.Size(104, 22)
        Me.SobreToolStripMenuItem.Text = "&Sobre"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArquivoToolStripMenuItem, Me.AjudaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1300, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 670)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1300, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(70, 17)
        Me.ToolStripStatusLabel1.Text = "ToolStripLbl"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RecordTabStrip, Me.StopTabStrip, Me.PlayTabStrip})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1300, 25)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip"
        '
        'RecordTabStrip
        '
        Me.RecordTabStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.RecordTabStrip.Image = CType(resources.GetObject("RecordTabStrip.Image"), System.Drawing.Image)
        Me.RecordTabStrip.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.RecordTabStrip.Name = "RecordTabStrip"
        Me.RecordTabStrip.Size = New System.Drawing.Size(23, 22)
        Me.RecordTabStrip.Text = "Gravar"
        '
        'StopTabStrip
        '
        Me.StopTabStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.StopTabStrip.Image = CType(resources.GetObject("StopTabStrip.Image"), System.Drawing.Image)
        Me.StopTabStrip.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.StopTabStrip.Name = "StopTabStrip"
        Me.StopTabStrip.Size = New System.Drawing.Size(23, 22)
        Me.StopTabStrip.Text = "Stop"
        '
        'PlayTabStrip
        '
        Me.PlayTabStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PlayTabStrip.Image = CType(resources.GetObject("PlayTabStrip.Image"), System.Drawing.Image)
        Me.PlayTabStrip.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PlayTabStrip.Name = "PlayTabStrip"
        Me.PlayTabStrip.Size = New System.Drawing.Size(23, 22)
        Me.PlayTabStrip.Text = "Play"
        '
        'tmrStatusBar
        '
        Me.tmrStatusBar.Interval = 3000
        '
        'TabFiles
        '
        Me.TabFiles.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabFiles.Location = New System.Drawing.Point(3, 3)
        Me.TabFiles.Name = "TabFiles"
        Me.TabFiles.SelectedIndex = 0
        Me.TabFiles.Size = New System.Drawing.Size(1270, 609)
        Me.TabFiles.TabIndex = 0
        '
        'Pnl1
        '
        Me.Pnl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Pnl1.Controls.Add(Me.TabFiles)
        Me.Pnl1.Location = New System.Drawing.Point(12, 52)
        Me.Pnl1.Name = "Pnl1"
        Me.Pnl1.Size = New System.Drawing.Size(1276, 615)
        Me.Pnl1.TabIndex = 3
        '
        'tmrRecord
        '
        Me.tmrRecord.Interval = 1000
        '
        'FrmGeral
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1300, 692)
        Me.Controls.Add(Me.Pnl1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FrmGeral"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MisterHook Prototype"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Pnl1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ArquivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NovoTesteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AbrirScriptToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SairToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AjudaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SobreToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents RecordTabStrip As ToolStripButton
    Friend WithEvents StopTabStrip As ToolStripButton
    Friend WithEvents PlayTabStrip As ToolStripButton
    Friend WithEvents GravarScriptToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tmrStatusBar As Timer
    Friend WithEvents TabFiles As TabControl
    Friend WithEvents Pnl1 As Panel
    Friend WithEvents tmrRecord As Timer
End Class
