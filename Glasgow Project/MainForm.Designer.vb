<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.grpBoxMemberShip = New System.Windows.Forms.GroupBox()
        Me.rdoFamily = New System.Windows.Forms.RadioButton()
        Me.rdoSingle = New System.Windows.Forms.RadioButton()
        Me.grpBoxAdditional = New System.Windows.Forms.GroupBox()
        Me.chkRecquetball = New System.Windows.Forms.CheckBox()
        Me.chkTennis = New System.Windows.Forms.CheckBox()
        Me.chkGolf = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblBasicFee = New System.Windows.Forms.Label()
        Me.lblAdditional = New System.Windows.Forms.Label()
        Me.lblMonthlyDue = New System.Windows.Forms.Label()
        Me.grpBoxMemberShip.SuspendLayout()
        Me.grpBoxAdditional.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpBoxMemberShip
        '
        Me.grpBoxMemberShip.Controls.Add(Me.rdoFamily)
        Me.grpBoxMemberShip.Controls.Add(Me.rdoSingle)
        Me.grpBoxMemberShip.Location = New System.Drawing.Point(23, 29)
        Me.grpBoxMemberShip.Name = "grpBoxMemberShip"
        Me.grpBoxMemberShip.Size = New System.Drawing.Size(96, 104)
        Me.grpBoxMemberShip.TabIndex = 0
        Me.grpBoxMemberShip.TabStop = False
        Me.grpBoxMemberShip.Text = "MemberShip"
        '
        'rdoFamily
        '
        Me.rdoFamily.AutoSize = True
        Me.rdoFamily.Location = New System.Drawing.Point(6, 65)
        Me.rdoFamily.Name = "rdoFamily"
        Me.rdoFamily.Size = New System.Drawing.Size(60, 19)
        Me.rdoFamily.TabIndex = 0
        Me.rdoFamily.Text = "&Family"
        Me.rdoFamily.UseVisualStyleBackColor = True
        '
        'rdoSingle
        '
        Me.rdoSingle.AutoSize = True
        Me.rdoSingle.Checked = True
        Me.rdoSingle.Location = New System.Drawing.Point(6, 22)
        Me.rdoSingle.Name = "rdoSingle"
        Me.rdoSingle.Size = New System.Drawing.Size(57, 19)
        Me.rdoSingle.TabIndex = 0
        Me.rdoSingle.TabStop = True
        Me.rdoSingle.Text = "&Single"
        Me.rdoSingle.UseVisualStyleBackColor = True
        '
        'grpBoxAdditional
        '
        Me.grpBoxAdditional.Controls.Add(Me.chkRecquetball)
        Me.grpBoxAdditional.Controls.Add(Me.chkTennis)
        Me.grpBoxAdditional.Controls.Add(Me.chkGolf)
        Me.grpBoxAdditional.Location = New System.Drawing.Point(160, 29)
        Me.grpBoxAdditional.Name = "grpBoxAdditional"
        Me.grpBoxAdditional.Size = New System.Drawing.Size(96, 104)
        Me.grpBoxAdditional.TabIndex = 1
        Me.grpBoxAdditional.TabStop = False
        Me.grpBoxAdditional.Text = "Additional"
        '
        'chkRecquetball
        '
        Me.chkRecquetball.AutoSize = True
        Me.chkRecquetball.Location = New System.Drawing.Point(7, 73)
        Me.chkRecquetball.Name = "chkRecquetball"
        Me.chkRecquetball.Size = New System.Drawing.Size(88, 19)
        Me.chkRecquetball.TabIndex = 0
        Me.chkRecquetball.Text = "&Recquetball"
        Me.chkRecquetball.UseVisualStyleBackColor = True
        '
        'chkTennis
        '
        Me.chkTennis.AutoSize = True
        Me.chkTennis.Location = New System.Drawing.Point(7, 48)
        Me.chkTennis.Name = "chkTennis"
        Me.chkTennis.Size = New System.Drawing.Size(60, 19)
        Me.chkTennis.TabIndex = 0
        Me.chkTennis.Text = "&Tennis"
        Me.chkTennis.UseVisualStyleBackColor = True
        '
        'chkGolf
        '
        Me.chkGolf.AutoSize = True
        Me.chkGolf.Location = New System.Drawing.Point(7, 23)
        Me.chkGolf.Name = "chkGolf"
        Me.chkGolf.Size = New System.Drawing.Size(48, 19)
        Me.chkGolf.TabIndex = 0
        Me.chkGolf.Text = "&Golf"
        Me.chkGolf.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 167)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Basic Fee:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(157, 167)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Additional:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 260)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Monthly dues:"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(137, 285)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(78, 37)
        Me.btnCalculate.TabIndex = 3
        Me.btnCalculate.Text = "&Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(218, 285)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(78, 37)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblBasicFee
        '
        Me.lblBasicFee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBasicFee.Location = New System.Drawing.Point(26, 193)
        Me.lblBasicFee.Name = "lblBasicFee"
        Me.lblBasicFee.Size = New System.Drawing.Size(93, 37)
        Me.lblBasicFee.TabIndex = 2
        Me.lblBasicFee.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblAdditional
        '
        Me.lblAdditional.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAdditional.Location = New System.Drawing.Point(160, 193)
        Me.lblAdditional.Name = "lblAdditional"
        Me.lblAdditional.Size = New System.Drawing.Size(93, 37)
        Me.lblAdditional.TabIndex = 2
        Me.lblAdditional.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblMonthlyDue
        '
        Me.lblMonthlyDue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMonthlyDue.Location = New System.Drawing.Point(29, 285)
        Me.lblMonthlyDue.Name = "lblMonthlyDue"
        Me.lblMonthlyDue.Size = New System.Drawing.Size(93, 37)
        Me.lblMonthlyDue.TabIndex = 2
        Me.lblMonthlyDue.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(305, 335)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblMonthlyDue)
        Me.Controls.Add(Me.lblAdditional)
        Me.Controls.Add(Me.lblBasicFee)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grpBoxAdditional)
        Me.Controls.Add(Me.grpBoxMemberShip)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Glasgow Health Club"
        Me.grpBoxMemberShip.ResumeLayout(False)
        Me.grpBoxMemberShip.PerformLayout()
        Me.grpBoxAdditional.ResumeLayout(False)
        Me.grpBoxAdditional.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpBoxMemberShip As GroupBox
    Friend WithEvents rdoFamily As RadioButton
    Friend WithEvents rdoSingle As RadioButton
    Friend WithEvents grpBoxAdditional As GroupBox
    Friend WithEvents chkRecquetball As CheckBox
    Friend WithEvents chkTennis As CheckBox
    Friend WithEvents chkGolf As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblBasicFee As Label
    Friend WithEvents lblAdditional As Label
    Friend WithEvents lblMonthlyDue As Label
End Class
