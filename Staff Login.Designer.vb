<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStaffLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStaffLogin))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnLogIn = New System.Windows.Forms.Button()
        Me.btnNewStaff = New System.Windows.Forms.Button()
        Me.txtStaffID = New System.Windows.Forms.TextBox()
        Me.txtPasswordStaff = New System.Windows.Forms.TextBox()
        Me.picStaff = New System.Windows.Forms.PictureBox()
        Me.chkShowPass = New System.Windows.Forms.CheckBox()
        Me.btnBack = New System.Windows.Forms.Button()
        CType(Me.picStaff, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(107, 203)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(224, 51)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "STAFF ID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(113, 345)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(286, 51)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "PASSWORD:"
        '
        'btnLogIn
        '
        Me.btnLogIn.BackColor = System.Drawing.Color.Teal
        Me.btnLogIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogIn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnLogIn.Location = New System.Drawing.Point(347, 499)
        Me.btnLogIn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnLogIn.Name = "btnLogIn"
        Me.btnLogIn.Size = New System.Drawing.Size(245, 94)
        Me.btnLogIn.TabIndex = 2
        Me.btnLogIn.Text = "LOG IN"
        Me.btnLogIn.UseVisualStyleBackColor = False
        '
        'btnNewStaff
        '
        Me.btnNewStaff.BackColor = System.Drawing.Color.Teal
        Me.btnNewStaff.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewStaff.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnNewStaff.Location = New System.Drawing.Point(691, 499)
        Me.btnNewStaff.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnNewStaff.Name = "btnNewStaff"
        Me.btnNewStaff.Size = New System.Drawing.Size(268, 94)
        Me.btnNewStaff.TabIndex = 3
        Me.btnNewStaff.Text = "NEW STAFF"
        Me.btnNewStaff.UseVisualStyleBackColor = False
        '
        'txtStaffID
        '
        Me.txtStaffID.BackColor = System.Drawing.Color.LightSeaGreen
        Me.txtStaffID.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStaffID.Location = New System.Drawing.Point(408, 200)
        Me.txtStaffID.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtStaffID.Name = "txtStaffID"
        Me.txtStaffID.Size = New System.Drawing.Size(324, 56)
        Me.txtStaffID.TabIndex = 4
        '
        'txtPasswordStaff
        '
        Me.txtPasswordStaff.BackColor = System.Drawing.Color.LightSeaGreen
        Me.txtPasswordStaff.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPasswordStaff.Location = New System.Drawing.Point(408, 342)
        Me.txtPasswordStaff.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPasswordStaff.Name = "txtPasswordStaff"
        Me.txtPasswordStaff.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPasswordStaff.Size = New System.Drawing.Size(324, 56)
        Me.txtPasswordStaff.TabIndex = 5
        Me.txtPasswordStaff.UseSystemPasswordChar = True
        '
        'picStaff
        '
        Me.picStaff.BackColor = System.Drawing.Color.Transparent
        Me.picStaff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picStaff.Image = CType(resources.GetObject("picStaff.Image"), System.Drawing.Image)
        Me.picStaff.Location = New System.Drawing.Point(1003, 189)
        Me.picStaff.Name = "picStaff"
        Me.picStaff.Size = New System.Drawing.Size(343, 314)
        Me.picStaff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picStaff.TabIndex = 6
        Me.picStaff.TabStop = False
        '
        'chkShowPass
        '
        Me.chkShowPass.AutoSize = True
        Me.chkShowPass.BackColor = System.Drawing.Color.Transparent
        Me.chkShowPass.Location = New System.Drawing.Point(408, 412)
        Me.chkShowPass.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkShowPass.Name = "chkShowPass"
        Me.chkShowPass.Size = New System.Drawing.Size(129, 21)
        Me.chkShowPass.TabIndex = 7
        Me.chkShowPass.Text = "Show Password"
        Me.chkShowPass.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Teal
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnBack.Location = New System.Drawing.Point(33, 499)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(245, 94)
        Me.btnBack.TabIndex = 8
        Me.btnBack.Text = "BACK"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'frmStaffLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1540, 657)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.chkShowPass)
        Me.Controls.Add(Me.picStaff)
        Me.Controls.Add(Me.txtPasswordStaff)
        Me.Controls.Add(Me.txtStaffID)
        Me.Controls.Add(Me.btnNewStaff)
        Me.Controls.Add(Me.btnLogIn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmStaffLogin"
        Me.Text = "Staff Login"
        CType(Me.picStaff, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnLogIn As Button
    Friend WithEvents btnNewStaff As Button
    Friend WithEvents txtStaffID As TextBox
    Friend WithEvents txtPasswordStaff As TextBox
    Friend WithEvents picStaff As PictureBox
    Friend WithEvents chkShowPass As CheckBox
    Friend WithEvents btnBack As Button
End Class
