<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PicBullet = New System.Windows.Forms.PictureBox()
        Me.Spaceship = New System.Windows.Forms.PictureBox()
        Me.PicInvader1 = New System.Windows.Forms.PictureBox()
        Me.PicInvader3 = New System.Windows.Forms.PictureBox()
        Me.PicInvader2 = New System.Windows.Forms.PictureBox()
        Me.PicInvader4 = New System.Windows.Forms.PictureBox()
        Me.PicInvader5 = New System.Windows.Forms.PictureBox()
        Me.PicInvader6 = New System.Windows.Forms.PictureBox()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PicBullet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Spaceship, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicInvader1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicInvader3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicInvader2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicInvader4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicInvader5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicInvader6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'PicBullet
        '
        Me.PicBullet.Image = Global.WindowsApplication2.My.Resources.Resources.Capture
        Me.PicBullet.Location = New System.Drawing.Point(249, 275)
        Me.PicBullet.Name = "PicBullet"
        Me.PicBullet.Size = New System.Drawing.Size(36, 27)
        Me.PicBullet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicBullet.TabIndex = 7
        Me.PicBullet.TabStop = False
        '
        'Spaceship
        '
        Me.Spaceship.Image = Global.WindowsApplication2.My.Resources.Resources.alienspaceship
        Me.Spaceship.Location = New System.Drawing.Point(240, 308)
        Me.Spaceship.Name = "Spaceship"
        Me.Spaceship.Size = New System.Drawing.Size(61, 52)
        Me.Spaceship.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Spaceship.TabIndex = 6
        Me.Spaceship.TabStop = False
        '
        'PicInvader1
        '
        Me.PicInvader1.Image = Global.WindowsApplication2.My.Resources.Resources.Virus_Emoji_large
        Me.PicInvader1.Location = New System.Drawing.Point(240, 155)
        Me.PicInvader1.Name = "PicInvader1"
        Me.PicInvader1.Size = New System.Drawing.Size(45, 41)
        Me.PicInvader1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicInvader1.TabIndex = 5
        Me.PicInvader1.TabStop = False
        '
        'PicInvader3
        '
        Me.PicInvader3.Image = Global.WindowsApplication2.My.Resources.Resources.Virus_Emoji_large
        Me.PicInvader3.Location = New System.Drawing.Point(179, 92)
        Me.PicInvader3.Name = "PicInvader3"
        Me.PicInvader3.Size = New System.Drawing.Size(43, 43)
        Me.PicInvader3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicInvader3.TabIndex = 4
        Me.PicInvader3.TabStop = False
        '
        'PicInvader2
        '
        Me.PicInvader2.Image = Global.WindowsApplication2.My.Resources.Resources.Virus_Emoji_large
        Me.PicInvader2.Location = New System.Drawing.Point(303, 92)
        Me.PicInvader2.Name = "PicInvader2"
        Me.PicInvader2.Size = New System.Drawing.Size(42, 43)
        Me.PicInvader2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicInvader2.TabIndex = 3
        Me.PicInvader2.TabStop = False
        '
        'PicInvader4
        '
        Me.PicInvader4.Image = Global.WindowsApplication2.My.Resources.Resources.Virus_Emoji_large
        Me.PicInvader4.Location = New System.Drawing.Point(377, 26)
        Me.PicInvader4.Name = "PicInvader4"
        Me.PicInvader4.Size = New System.Drawing.Size(41, 40)
        Me.PicInvader4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicInvader4.TabIndex = 2
        Me.PicInvader4.TabStop = False
        '
        'PicInvader5
        '
        Me.PicInvader5.Image = Global.WindowsApplication2.My.Resources.Resources.Virus_Emoji_large
        Me.PicInvader5.Location = New System.Drawing.Point(240, 26)
        Me.PicInvader5.Name = "PicInvader5"
        Me.PicInvader5.Size = New System.Drawing.Size(45, 40)
        Me.PicInvader5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicInvader5.TabIndex = 1
        Me.PicInvader5.TabStop = False
        '
        'PicInvader6
        '
        Me.PicInvader6.Image = Global.WindowsApplication2.My.Resources.Resources.Virus_Emoji_large
        Me.PicInvader6.Location = New System.Drawing.Point(126, 26)
        Me.PicInvader6.Name = "PicInvader6"
        Me.PicInvader6.Size = New System.Drawing.Size(44, 40)
        Me.PicInvader6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicInvader6.TabIndex = 0
        Me.PicInvader6.TabStop = False
        '
        'Timer2
        '
        '
        'Timer3
        '
        Me.Timer3.Enabled = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(796, 420)
        Me.Controls.Add(Me.PicBullet)
        Me.Controls.Add(Me.Spaceship)
        Me.Controls.Add(Me.PicInvader1)
        Me.Controls.Add(Me.PicInvader3)
        Me.Controls.Add(Me.PicInvader2)
        Me.Controls.Add(Me.PicInvader4)
        Me.Controls.Add(Me.PicInvader5)
        Me.Controls.Add(Me.PicInvader6)
        Me.KeyPreview = True
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.TransparencyKey = System.Drawing.Color.Black
        CType(Me.PicBullet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Spaceship, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicInvader1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicInvader3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicInvader2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicInvader4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicInvader5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicInvader6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PicInvader6 As System.Windows.Forms.PictureBox
    Friend WithEvents PicInvader5 As System.Windows.Forms.PictureBox
    Friend WithEvents PicInvader4 As System.Windows.Forms.PictureBox
    Friend WithEvents PicInvader2 As System.Windows.Forms.PictureBox
    Friend WithEvents PicInvader3 As System.Windows.Forms.PictureBox
    Friend WithEvents PicInvader1 As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Spaceship As System.Windows.Forms.PictureBox
    Friend WithEvents PicBullet As System.Windows.Forms.PictureBox
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Timer3 As System.Windows.Forms.Timer

End Class
