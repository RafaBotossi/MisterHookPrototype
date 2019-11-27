Imports MisterHookLibrary.MisterHook

''' <summary>
''' Classe do Formulário Geral
''' </summary>
Public Class FrmGeral

#Region "Initialize"

    'Instância do programa, usada para identificar na library que é este programa que está realizando Hooks
    Private _hinstance As IntPtr

    'Objeto de Playback usado em ambos os objetos de gravação
    Private PlayBackActions As Models.PlaybackActions

    'Objeto de Record
    Private WithEvents Recorder As Models.Recorder

    'Variáveis usadas somente para contagem de segundos no form
    Const _SecondsBeforeRecord As Integer = 2
    Private _CountDownBeforeRecord As Integer
    Const _MilisecondsBeforePlayback As Integer = 1500

    ''' <summary>
    ''' Inicialização do sistema
    ''' </summary>
    Private Sub Initialize()

        _CountDownBeforeRecord = _SecondsBeforeRecord

        'É necessário enviar o handle da instância do programa executado para os gravadores, se não enviar, a gravação não funciona.
        _hinstance = System.Runtime.InteropServices.Marshal.GetHINSTANCE(System.Reflection.Assembly.GetExecutingAssembly.GetModules()(0)).ToInt32

        'É necessário enviar o objeto para ambos o gravador.
        PlayBackActions = Models.PlaybackSingleton.Instance(_hinstance) 'Também é necessário enviar o handle do programa pro objeto de playback pois se no playback você quiser apertar a tecla 'Pause' para parar o playback, é possível, ou seja, existe um gravador de teclado também sendo executado no playback
        Recorder = New Models.Recorder(_hinstance, PlayBackActions)

        SetStatusBarMessage(String.Empty)
        NewTest()

    End Sub

#End Region

#Region "Eventos"

    ''' <summary>
    ''' Inicialização do sistema
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub FrmGeral_Load(sender As Object, e As EventArgs) Handles Me.Load

        Try
            Initialize()
        Catch ex As Exception
            MessageBox.Show(ex.Message, My.Resources.SoftwareName)
        End Try

    End Sub

    ''' <summary>
    ''' Menu Novo Teste
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub NovoTesteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NovoTesteToolStripMenuItem.Click

        Try
            NewTest()
        Catch ex As Exception
            MessageBox.Show(ex.Message, My.Resources.SoftwareName)
        End Try

    End Sub

    ''' <summary>
    ''' Abrir Script já criado
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub AbrirScriptToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbrirScriptToolStripMenuItem.Click

        Try
            OpenScript()
        Catch ex As Exception
            MessageBox.Show(ex.Message, My.Resources.SoftwareName)
        End Try

    End Sub

    ''' <summary>
    ''' Gravar Script já criado
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub GravarScriptToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GravarScriptToolStripMenuItem.Click

        Try
            SaveScript()
        Catch ex As Exception
            MessageBox.Show(ex.Message, My.Resources.SoftwareName)
        End Try

    End Sub

    ''' <summary>
    ''' Sair do sistema
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub SairToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SairToolStripMenuItem.Click

        Try
            ExitProgram()
        Catch ex As Exception
            MessageBox.Show(ex.Message, My.Resources.SoftwareName)
        End Try

    End Sub

    ''' <summary>
    ''' Abrir tela Sobre
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub SobreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SobreToolStripMenuItem.Click

        Try
            OpenAbout()
        Catch ex As Exception
            MessageBox.Show(ex.Message, My.Resources.SoftwareName)
        End Try

    End Sub

    ''' <summary>
    ''' Ao apertar atalho de teclado, realizar ação
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub FrmGeral_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        Try
            SetShortcutAction(sender, e)
        Catch ex As Exception
            MessageBox.Show(ex.Message, My.Resources.SoftwareName)
        End Try
    End Sub

    ''' <summary>
    ''' Ao apertar atalho de teclado, realizar ação
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub TabFiles_KeyDown(sender As Object, e As KeyEventArgs) Handles TabFiles.KeyDown

        Try
            SetShortcutAction(sender, e)
        Catch ex As Exception
            MessageBox.Show(ex.Message, My.Resources.SoftwareName)
        End Try

    End Sub

    ''' <summary>
    ''' Ações a realizar ao apertar atalho no teclado
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub SetShortcutAction(sender As Object, e As KeyEventArgs)

        If e.Control AndAlso e.KeyCode = Keys.N Then
            NewTest()
        ElseIf e.Control AndAlso e.KeyCode = Keys.O Then
            OpenScript()
        ElseIf e.Control AndAlso e.KeyCode = Keys.S Then
            SaveScript()
        End If

    End Sub

    ''' <summary>
    ''' Gravar Script
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub RecordTabStrip_Click(sender As Object, e As EventArgs) Handles RecordTabStrip.Click

        Try

            RecordTabStrip.Enabled = False
            StopTabStrip.Enabled = True
            PlayTabStrip.Enabled = True

            SetStatusBarMessage(String.Format("A sua gravação começará em {0} segundos.", _CountDownBeforeRecord))

            tmrRecord.Enabled = True

        Catch ex As Exception
            MessageBox.Show(ex.Message, My.Resources.SoftwareName)
        End Try

    End Sub

    ''' <summary>
    ''' Parar Gravação
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub StopTabStrip_Click(sender As Object, e As EventArgs) Handles StopTabStrip.Click

        Try

            RecordTabStrip.Enabled = True
            StopTabStrip.Enabled = False
            PlayTabStrip.Enabled = True

            tmrRecord.Enabled = False

            StopRecording()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    ''' <summary>
    ''' Reproduzir Gravação
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub PlayTabStrip_Click(sender As Object, e As EventArgs) Handles PlayTabStrip.Click

        Try

            If String.IsNullOrEmpty(TabFiles.SelectedTab.Tag) Then
                Throw New Exception("É necessário salvar o script primeiro.")
            Else
                SaveScript()
            End If

            RecordTabStrip.Enabled = False
            StopTabStrip.Enabled = False
            PlayTabStrip.Enabled = False

            PlayBack()

            RecordTabStrip.Enabled = True
            StopTabStrip.Enabled = False
            PlayTabStrip.Enabled = True

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    'Timer para início da gravação.
    Private Sub TmrRecord_Tick(sender As Object, e As EventArgs) Handles tmrRecord.Tick

        _CountDownBeforeRecord -= 1

        SetStatusBarMessage(String.Format("A sua gravação começará em {0} segundos.", _CountDownBeforeRecord))

        If _CountDownBeforeRecord = 0 Then
            SetStatusBarMessage("A sua gravação começou.")
            tmrRecord.Enabled = False
            _CountDownBeforeRecord = _SecondsBeforeRecord
            StartRecording()
        End If

    End Sub

#End Region

#Region "New Test"

    ''' <summary>
    ''' Criação de um novo teste
    ''' </summary>
    Private Sub NewTest()

        CreateNewTab()
        FocusLastTab()

        SetStatusBarMessage("Novo teste criado.")

    End Sub

#End Region

#Region "Open Script"

    ''' <summary>
    ''' Aberta de Script
    ''' </summary>
    Private Sub OpenScript()

        Dim fileName As String = GetScriptFilename()
        If Not String.IsNullOrEmpty(fileName) Then

            Dim script As String = GetTextFromFile(fileName)

            If Not IsValidScript(script) Then
                SetStatusBarMessage("Este script não é válido.")
                Exit Sub
            End If

            CreateNewTab()
            FocusLastTab()

            SetTabText(TabFiles.TabPages.Count - 1, fileName)
            SetRTBText(TabFiles.TabPages.Count - 1, script)

            SetStatusBarMessage(String.Format("Arquivo '{0}' aberto com sucesso.", fileName))

        End If

    End Sub

    ''' <summary>
    ''' Verifica se o script é válido. Ficará sem desenvolvimento até a implementação do padrão de projeto Interpreter
    ''' </summary>
    ''' <param name="script"></param>
    ''' <returns></returns>
    Private Function IsValidScript(script As String) As Boolean

        Return True

    End Function

    ''' <summary>
    ''' Busca conteúdo do arquivo
    ''' </summary>
    ''' <param name="Filename"></param>
    ''' <returns></returns>
    Private Function GetTextFromFile(Filename As String) As String

        If System.IO.File.Exists(Filename) Then
            Return System.IO.File.ReadAllText(Filename)
        End If
        Return String.Empty

    End Function

    ''' <summary>
    ''' Marca o conteúdo do RichTextBox
    ''' </summary>
    ''' <param name="tabPageIndex"></param>
    ''' <param name="rtbText"></param>
    Private Sub SetRTBText(tabPageIndex As Integer, rtbText As String)

        For Each control As Control In TabFiles.TabPages(tabPageIndex).Controls
            If control.GetType Is GetType(Panel) Then
                Dim pnl = control
                For Each ctr As Control In pnl.Controls
                    If ctr.GetType Is GetType(RichTextBox) Then
                        Dim rtb As RichTextBox = ctr
                        rtb.Text = rtbText
                        Exit Sub
                    End If
                Next
            End If
        Next

    End Sub

    ''' <summary>
    ''' Grava o texto na Aba
    ''' </summary>
    ''' <param name="tabPageIndex"></param>
    ''' <param name="text"></param>
    Private Sub SetTabText(tabPageIndex As Integer, text As String)

        Dim onlyFileName As String = Strings.Mid(text, text.ToString.LastIndexOf("\") + 2, Len(text))
        TabFiles.TabPages(tabPageIndex).Text = onlyFileName

        Dim textAux As String = text
        If Len(text) > 30 Then
            textAux = Strings.Left(text, 30) & "..."
        End If
        TabFiles.TabPages(tabPageIndex).ToolTipText = text
        TabFiles.TabPages(tabPageIndex).Tag = text

    End Sub

    ''' <summary>
    ''' Abre tela para informar o nome do arquivo de Script
    ''' </summary>
    ''' <returns></returns>
    Private Function GetScriptFilename() As String

        Dim Opf1 As New OpenFileDialog
        Opf1.Multiselect = False
        Opf1.Title = "Selecionar Script"
        Opf1.InitialDirectory = My.Application.Info.DirectoryPath & "\Scripts"
        Opf1.Filter = "Script (*.txt)|*.txt"
        Opf1.CheckFileExists = True
        Opf1.CheckPathExists = True
        Opf1.FilterIndex = 2
        Opf1.RestoreDirectory = True

        Dim dr As DialogResult = Opf1.ShowDialog()

        If dr = System.Windows.Forms.DialogResult.OK Then
            Return Opf1.FileName
        End If

        Return String.Empty

    End Function

#End Region

#Region "Save Script"

    ''' <summary>
    ''' Salva o Script
    ''' </summary>
    Private Sub SaveScript()

        Dim fileName As String = TabFiles.SelectedTab.Tag
        If String.IsNullOrEmpty(fileName) Then
            fileName = GetSavedFileName()
        Else
            TabFiles.SelectedTab.Text.Replace(" *", "")
        End If

        If Not String.IsNullOrEmpty(fileName) Then

            Dim script As String = GetRTBText(TabFiles.SelectedTab.TabIndex)
            System.IO.File.WriteAllText(fileName, script)

            SetTabText(TabFiles.SelectedTab.TabIndex, fileName)

            SetStatusBarMessage(String.Format("Arquivo '{0}' salvo com sucesso.", fileName))

        End If

    End Sub

    ''' <summary>
    ''' Abre tela para busca do script Salvo
    ''' </summary>
    ''' <returns></returns>
    Private Function GetSavedFileName() As String

        Dim svdlg As New SaveFileDialog()
        svdlg.Filter = "Script (*.txt)|*.txt"

        If svdlg.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Return svdlg.FileName
        End If

        Return String.Empty

    End Function

    ''' <summary>
    ''' Busca o texto do RichTextBox
    ''' </summary>
    ''' <param name="tabPageIndex"></param>
    ''' <returns></returns>
    Private Function GetRTBText(tabPageIndex As Integer) As String

        For Each control As Control In TabFiles.TabPages(tabPageIndex).Controls
            If control.GetType Is GetType(Panel) Then
                Dim pnl = control
                For Each ctr As Control In pnl.Controls
                    If ctr.GetType Is GetType(RichTextBox) Then
                        Dim rtb As RichTextBox = ctr
                        Return rtb.Text
                    End If
                Next
            End If
        Next
        Return String.Empty

    End Function

#End Region

#Region "Record Actions"

    ''' <summary>
    ''' Evento de início de Gravação.
    ''' </summary>
    Public Sub StartRecording()

        Try

            Recorder.StartRecording()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    ''' <summary>
    ''' Evento de Stop de gravação
    ''' </summary>
    Public Sub StopRecording()

        Try

            If Recorder IsNot Nothing Then
                Recorder.StopRecording()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    ''' <summary>
    ''' Evento de Playback do que foi gravado.
    ''' </summary>
    Public Sub PlayBack()
        Try

            Threading.Thread.Sleep(_MilisecondsBeforePlayback)
            If PlayBackActions IsNot Nothing Then
                PlayBackActions.Playback(TabFiles.SelectedTab.Tag)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    ''' <summary>
    ''' Set do script gravado no RichTextBox
    ''' </summary>
    ''' <param name="script"></param>
    Private Sub Recorder_GetRecordedActions(script As String) Handles Recorder.GetRecordedActions

        SetRTBText(TabFiles.TabPages.Count - 1, script)

    End Sub

#End Region

#Region "Exit"

    ''' <summary>
    ''' Finaliza o Programa
    ''' </summary>
    Private Sub ExitProgram()

        Dim msg As String = "Deseja realmente sair?"
        If NotSavedFileExists() Then
            msg &= " Existem arquivos não salvos que serão perdidos"
        End If

        If MessageBox.Show(msg, "Sair", MessageBoxButtons.YesNoCancel) = DialogResult.Yes Then
            End
        End If

    End Sub

#End Region

#Region "Apoio"

    ''' <summary>
    ''' Verifica se o arquivo está gravado
    ''' </summary>
    ''' <returns></returns>
    Private Function NotSavedFileExists() As Boolean

        For Each tabFile As TabPage In TabFiles.TabPages
            If tabFile.Text.Contains("*") Then
                Return True
            End If
        Next
        Return False

    End Function

#End Region

#Region "Open About"

    ''' <summary>
    ''' Abre tela Sobre
    ''' </summary>
    Private Sub OpenAbout()

        Dim frmSobre As New FrmSobre
        frmSobre.Show()

    End Sub

#End Region

#Region "Tabs"

    ''' <summary>
    ''' Cria nova Aba
    ''' </summary>
    Private Sub CreateNewTab()

        TabFiles.TabPages.Add("Novo Script *")
        Dim pnl As New Panel
        With pnl
            .Left = 0
            .Top = 0
            .Width = TabFiles.TabPages(TabFiles.TabPages.Count - 1).Width
            .Height = TabFiles.TabPages(TabFiles.TabPages.Count - 1).Height
            .Visible = True
            .BorderStyle = BorderStyle.FixedSingle
            .Anchor = AnchorStyles.Bottom + AnchorStyles.Right + AnchorStyles.Left + AnchorStyles.Top
        End With

        Dim rtb As New RichTextBox
        With rtb
            .Left = 3
            .Top = 3
            .Width = TabFiles.TabPages(TabFiles.TabPages.Count - 1).Width - 6
            .Height = TabFiles.TabPages(TabFiles.TabPages.Count - 1).Height - 6
            .Visible = True
            .Anchor = AnchorStyles.Bottom + AnchorStyles.Right + AnchorStyles.Left + AnchorStyles.Top
        End With
        AddHandler rtb.TextChanged, AddressOf rtb_TextChanged
        pnl.Controls.Add(rtb)

        TabFiles.TabPages.Item(TabFiles.TabPages.Count - 1).Controls.Add(pnl)

    End Sub

    ''' <summary>
    ''' Ao mudar o texto do RichTextBox, indica que não está gravado
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub rtb_TextChanged(sender As Object, e As EventArgs)

        If Not TabFiles.SelectedTab.Text.Contains("*") Then
            TabFiles.SelectedTab.Text &= " *"
        End If

    End Sub

    ''' <summary>
    ''' Coloca Focus na Aba
    ''' </summary>
    Private Sub FocusLastTab()

        TabFiles.SelectTab(TabFiles.TabPages.Item(TabFiles.TabPages.Count - 1))

    End Sub

#End Region

#Region "Status Bar"

    ''' <summary>
    ''' Informa ao usuário a ação realizada no StatusBar
    ''' </summary>
    ''' <param name="msg"></param>
    Private Sub SetStatusBarMessage(msg As String)

        ToolStripStatusLabel1.Text = msg
        tmrStatusBar.Enabled = True

    End Sub

    ''' <summary>
    ''' Remove o texto do StatusBar após alguns segundos
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub tmrStatusBar_Tick(sender As Object, e As EventArgs) Handles tmrStatusBar.Tick

        ToolStripStatusLabel1.Text = ""
        tmrStatusBar.Enabled = False

    End Sub

#End Region

End Class
