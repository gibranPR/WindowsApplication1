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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lblPrincipal = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBusca = New System.Windows.Forms.Button()
        Me.btnModifica = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btnOp1 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblPrincipal
        '
        Me.lblPrincipal.AutoSize = True
        Me.lblPrincipal.Font = New System.Drawing.Font("Walkway UltraBold", 21.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrincipal.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.lblPrincipal.Location = New System.Drawing.Point(350, 35)
        Me.lblPrincipal.Name = "lblPrincipal"
        Me.lblPrincipal.Size = New System.Drawing.Size(296, 30)
        Me.lblPrincipal.TabIndex = 0
        Me.lblPrincipal.Text = "Control de equipos PR"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(75, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(195, 82)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(417, 174)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(184, 22)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "¿QUÉ DESEA HACER?"
        '
        'btnBusca
        '
        Me.btnBusca.Image = CType(resources.GetObject("btnBusca.Image"), System.Drawing.Image)
        Me.btnBusca.Location = New System.Drawing.Point(603, 239)
        Me.btnBusca.Name = "btnBusca"
        Me.btnBusca.Size = New System.Drawing.Size(140, 140)
        Me.btnBusca.TabIndex = 4
        Me.btnBusca.UseVisualStyleBackColor = True
        '
        'btnModifica
        '
        Me.btnModifica.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnModifica.Image = CType(resources.GetObject("btnModifica.Image"), System.Drawing.Image)
        Me.btnModifica.Location = New System.Drawing.Point(310, 422)
        Me.btnModifica.Name = "btnModifica"
        Me.btnModifica.Size = New System.Drawing.Size(140, 140)
        Me.btnModifica.TabIndex = 5
        Me.btnModifica.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(603, 422)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(140, 140)
        Me.Button3.TabIndex = 6
        Me.Button3.UseVisualStyleBackColor = True
        '
        'btnOp1
        '
        Me.btnOp1.Image = CType(resources.GetObject("btnOp1.Image"), System.Drawing.Image)
        Me.btnOp1.Location = New System.Drawing.Point(310, 239)
        Me.btnOp1.Name = "btnOp1"
        Me.btnOp1.Size = New System.Drawing.Size(140, 140)
        Me.btnOp1.TabIndex = 3
        Me.btnOp1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 730)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btnModifica)
        Me.Controls.Add(Me.btnBusca)
        Me.Controls.Add(Me.btnOp1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblPrincipal)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PRSys V3.0"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPrincipal As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnBusca As Button
    Friend WithEvents btnModifica As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents btnOp1 As Button
End Class
