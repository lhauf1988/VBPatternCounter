<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCountingForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCountingForm))
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtStartingPosition = New System.Windows.Forms.TextBox()
        Me.txtHowManyTimes = New System.Windows.Forms.TextBox()
        Me.txtStepThrough = New System.Windows.Forms.TextBox()
        Me.lblStartingPosition = New System.Windows.Forms.Label()
        Me.lblNumberOfTimes = New System.Windows.Forms.Label()
        Me.lblStep = New System.Windows.Forms.Label()
        Me.LtbDisplay = New System.Windows.Forms.ListBox()
        Me.lblInformation = New System.Windows.Forms.Label()
        Me.lblStartInfo = New System.Windows.Forms.Label()
        Me.lblNumberInfo = New System.Windows.Forms.Label()
        Me.lblStepInfo = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(12, 261)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(75, 23)
        Me.btnStart.TabIndex = 11
        Me.btnStart.Text = "&Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(148, 261)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 12
        Me.btnReset.Text = "&Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(284, 261)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 13
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtStartingPosition
        '
        Me.txtStartingPosition.Location = New System.Drawing.Point(26, 79)
        Me.txtStartingPosition.MaxLength = 2
        Me.txtStartingPosition.Name = "txtStartingPosition"
        Me.txtStartingPosition.Size = New System.Drawing.Size(39, 20)
        Me.txtStartingPosition.TabIndex = 4
        '
        'txtHowManyTimes
        '
        Me.txtHowManyTimes.Location = New System.Drawing.Point(148, 79)
        Me.txtHowManyTimes.MaxLength = 2
        Me.txtHowManyTimes.Name = "txtHowManyTimes"
        Me.txtHowManyTimes.Size = New System.Drawing.Size(40, 20)
        Me.txtHowManyTimes.TabIndex = 6
        '
        'txtStepThrough
        '
        Me.txtStepThrough.Location = New System.Drawing.Point(266, 78)
        Me.txtStepThrough.MaxLength = 2
        Me.txtStepThrough.Name = "txtStepThrough"
        Me.txtStepThrough.Size = New System.Drawing.Size(42, 20)
        Me.txtStepThrough.TabIndex = 8
        '
        'lblStartingPosition
        '
        Me.lblStartingPosition.AutoSize = True
        Me.lblStartingPosition.Location = New System.Drawing.Point(23, 50)
        Me.lblStartingPosition.Name = "lblStartingPosition"
        Me.lblStartingPosition.Size = New System.Drawing.Size(83, 13)
        Me.lblStartingPosition.TabIndex = 1
        Me.lblStartingPosition.Text = "Starting Position"
        '
        'lblNumberOfTimes
        '
        Me.lblNumberOfTimes.AutoSize = True
        Me.lblNumberOfTimes.Location = New System.Drawing.Point(145, 50)
        Me.lblNumberOfTimes.Name = "lblNumberOfTimes"
        Me.lblNumberOfTimes.Size = New System.Drawing.Size(87, 13)
        Me.lblNumberOfTimes.TabIndex = 2
        Me.lblNumberOfTimes.Text = "Number of Times"
        '
        'lblStep
        '
        Me.lblStep.AutoSize = True
        Me.lblStep.Location = New System.Drawing.Point(263, 50)
        Me.lblStep.Name = "lblStep"
        Me.lblStep.Size = New System.Drawing.Size(29, 13)
        Me.lblStep.TabIndex = 3
        Me.lblStep.Text = "Step"
        '
        'LtbDisplay
        '
        Me.LtbDisplay.FormattingEnabled = True
        Me.LtbDisplay.Location = New System.Drawing.Point(12, 114)
        Me.LtbDisplay.Name = "LtbDisplay"
        Me.LtbDisplay.Size = New System.Drawing.Size(348, 134)
        Me.LtbDisplay.TabIndex = 10
        '
        'lblInformation
        '
        Me.lblInformation.AutoSize = True
        Me.lblInformation.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInformation.Location = New System.Drawing.Point(26, 13)
        Me.lblInformation.Name = "lblInformation"
        Me.lblInformation.Size = New System.Drawing.Size(241, 13)
        Me.lblInformation.TabIndex = 0
        Me.lblInformation.Text = "Please enter a number in the fields below"
        '
        'lblStartInfo
        '
        Me.lblStartInfo.AutoSize = True
        Me.lblStartInfo.ForeColor = System.Drawing.Color.Blue
        Me.lblStartInfo.Location = New System.Drawing.Point(71, 81)
        Me.lblStartInfo.Name = "lblStartInfo"
        Me.lblStartInfo.Size = New System.Drawing.Size(46, 13)
        Me.lblStartInfo.TabIndex = 5
        Me.lblStartInfo.Text = "( 0 - 99 )"
        '
        'lblNumberInfo
        '
        Me.lblNumberInfo.AutoSize = True
        Me.lblNumberInfo.ForeColor = System.Drawing.Color.Blue
        Me.lblNumberInfo.Location = New System.Drawing.Point(194, 81)
        Me.lblNumberInfo.Name = "lblNumberInfo"
        Me.lblNumberInfo.Size = New System.Drawing.Size(46, 13)
        Me.lblNumberInfo.TabIndex = 7
        Me.lblNumberInfo.Text = "( 1 - 99 )"
        '
        'lblStepInfo
        '
        Me.lblStepInfo.AutoSize = True
        Me.lblStepInfo.ForeColor = System.Drawing.Color.Blue
        Me.lblStepInfo.Location = New System.Drawing.Point(313, 81)
        Me.lblStepInfo.Name = "lblStepInfo"
        Me.lblStepInfo.Size = New System.Drawing.Size(46, 13)
        Me.lblStepInfo.TabIndex = 9
        Me.lblStepInfo.Text = "( 1 - 99 )"
        '
        'frmCountingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(371, 301)
        Me.Controls.Add(Me.lblStepInfo)
        Me.Controls.Add(Me.lblNumberInfo)
        Me.Controls.Add(Me.lblStartInfo)
        Me.Controls.Add(Me.lblInformation)
        Me.Controls.Add(Me.LtbDisplay)
        Me.Controls.Add(Me.lblStep)
        Me.Controls.Add(Me.lblNumberOfTimes)
        Me.Controls.Add(Me.lblStartingPosition)
        Me.Controls.Add(Me.txtStepThrough)
        Me.Controls.Add(Me.txtHowManyTimes)
        Me.Controls.Add(Me.txtStartingPosition)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnStart)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCountingForm"
        Me.Text = "Pattern Counting Application"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents txtStartingPosition As System.Windows.Forms.TextBox
    Friend WithEvents txtHowManyTimes As System.Windows.Forms.TextBox
    Friend WithEvents txtStepThrough As System.Windows.Forms.TextBox
    Friend WithEvents lblStartingPosition As System.Windows.Forms.Label
    Friend WithEvents lblNumberOfTimes As System.Windows.Forms.Label
    Friend WithEvents lblStep As System.Windows.Forms.Label
    Friend WithEvents LtbDisplay As System.Windows.Forms.ListBox
    Friend WithEvents lblInformation As System.Windows.Forms.Label
    Friend WithEvents lblStartInfo As System.Windows.Forms.Label
    Friend WithEvents lblNumberInfo As System.Windows.Forms.Label
    Friend WithEvents lblStepInfo As System.Windows.Forms.Label

End Class
