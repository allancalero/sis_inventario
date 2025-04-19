<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.user = New System.Windows.Forms.Label()
        Me.txtuser = New System.Windows.Forms.TextBox()
        Me.txtpass = New System.Windows.Forms.TextBox()
        Me.pass = New System.Windows.Forms.Label()
        Me.btningresar = New System.Windows.Forms.Button()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'user
        '
        Me.user.BackColor = System.Drawing.Color.Transparent
        Me.user.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.user.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.user.Location = New System.Drawing.Point(128, 227)
        Me.user.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.user.Name = "user"
        Me.user.Size = New System.Drawing.Size(164, 31)
        Me.user.TabIndex = 0
        Me.user.Text = "Usuario"
        Me.user.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtuser
        '
        Me.txtuser.Location = New System.Drawing.Point(128, 272)
        Me.txtuser.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txtuser.Name = "txtuser"
        Me.txtuser.Size = New System.Drawing.Size(164, 26)
        Me.txtuser.TabIndex = 1
        '
        'txtpass
        '
        Me.txtpass.Location = New System.Drawing.Point(128, 372)
        Me.txtpass.Margin = New System.Windows.Forms.Padding(5)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpass.Size = New System.Drawing.Size(164, 26)
        Me.txtpass.TabIndex = 3
        '
        'pass
        '
        Me.pass.BackColor = System.Drawing.Color.Transparent
        Me.pass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pass.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pass.Location = New System.Drawing.Point(128, 327)
        Me.pass.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.pass.Name = "pass"
        Me.pass.Size = New System.Drawing.Size(164, 31)
        Me.pass.TabIndex = 2
        Me.pass.Text = "Contraseña"
        Me.pass.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btningresar
        '
        Me.btningresar.Location = New System.Drawing.Point(128, 424)
        Me.btningresar.Name = "btningresar"
        Me.btningresar.Size = New System.Drawing.Size(162, 35)
        Me.btningresar.TabIndex = 4
        Me.btningresar.Text = "&Ingresar"
        Me.btningresar.UseVisualStyleBackColor = True
        '
        'btnsalir
        '
        Me.btnsalir.Location = New System.Drawing.Point(128, 474)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(162, 35)
        Me.btnsalir.TabIndex = 5
        Me.btnsalir.Text = "&Salir"
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(140, 66)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(140, 135)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(440, 692)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.btningresar)
        Me.Controls.Add(Me.txtpass)
        Me.Controls.Add(Me.pass)
        Me.Controls.Add(Me.txtuser)
        Me.Controls.Add(Me.user)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Name = "Form1"
        Me.Text = " Bienvenido al Sistema"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents user As Label
    Friend WithEvents txtuser As TextBox
    Friend WithEvents txtpass As TextBox
    Friend WithEvents pass As Label
    Friend WithEvents btningresar As Button
    Friend WithEvents btnsalir As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
