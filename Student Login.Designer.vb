<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmStudLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnLogIn = New System.Windows.Forms.Button()
        Me.btnNewStud = New System.Windows.Forms.Button()
        Me.txtStudentID = New System.Windows.Forms.TextBox()
        Me.chkShowPass = New System.Windows.Forms.CheckBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(43, 244)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(310, 52)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "STUDENT ID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(52, 364)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(300, 52)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "PASSWORD:"
        '
        'btnLogIn
        '
        Me.btnLogIn.BackColor = System.Drawing.Color.Teal
        Me.btnLogIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogIn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnLogIn.Location = New System.Drawing.Point(378, 525)
        Me.btnLogIn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnLogIn.Name = "btnLogIn"
        Me.btnLogIn.Size = New System.Drawing.Size(245, 94)
        Me.btnLogIn.TabIndex = 2
        Me.btnLogIn.Text = "LOG IN"
        Me.btnLogIn.UseVisualStyleBackColor = False
        '
        'btnNewStud
        '
        Me.btnNewStud.BackColor = System.Drawing.Color.Teal
        Me.btnNewStud.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewStud.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnNewStud.Location = New System.Drawing.Point(714, 525)
        Me.btnNewStud.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnNewStud.Name = "btnNewStud"
        Me.btnNewStud.Size = New System.Drawing.Size(268, 94)
        Me.btnNewStud.TabIndex = 3
        Me.btnNewStud.Text = "NEW STUDENT"
        Me.btnNewStud.UseVisualStyleBackColor = False
        '
        'txtStudentID
        '
        Me.txtStudentID.BackColor = System.Drawing.Color.LightSeaGreen
        Me.txtStudentID.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudentID.Location = New System.Drawing.Point(520, 234)
        Me.txtStudentID.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtStudentID.Multiline = True
        Me.txtStudentID.Name = "txtStudentID"
        Me.txtStudentID.Size = New System.Drawing.Size(269, 58)
        Me.txtStudentID.TabIndex = 4
        '
        'chkShowPass
        '
        Me.chkShowPass.AutoSize = True
        Me.chkShowPass.BackColor = System.Drawing.Color.Transparent
        Me.chkShowPass.Location = New System.Drawing.Point(520, 431)
        Me.chkShowPass.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkShowPass.Name = "chkShowPass"
        Me.chkShowPass.Size = New System.Drawing.Size(129, 21)
        Me.chkShowPass.TabIndex = 6
        Me.chkShowPass.Text = "Show Password"
        Me.chkShowPass.UseVisualStyleBackColor = False
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.LightSeaGreen
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(520, 364)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(269, 49)
        Me.txtPassword.TabIndex = 7
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Teal
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnBack.Location = New System.Drawing.Point(52, 525)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(245, 94)
        Me.btnBack.TabIndex = 8
        Me.btnBack.Text = "BACK"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'frmStudLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSeaGreen
        Me.BackgroundImage = Global.College_Management_System_301.My.Resources.Resources.Home2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1540, 657)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.chkShowPass)
        Me.Controls.Add(Me.txtStudentID)
        Me.Controls.Add(Me.btnNewStud)
        Me.Controls.Add(Me.btnLogIn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmStudLogin"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnLogIn As Button
    Friend WithEvents btnNewStud As Button
    Friend WithEvents txtStudentID As TextBox
    Friend WithEvents chkShowPass As CheckBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnBack As Button
End Class
