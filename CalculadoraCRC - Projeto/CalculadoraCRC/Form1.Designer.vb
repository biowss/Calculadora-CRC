<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Calculadora
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
        Me.txtDec = New System.Windows.Forms.TextBox()
        Me.lblDec = New System.Windows.Forms.Label()
        Me.txtHexa = New System.Windows.Forms.TextBox()
        Me.lblHexa = New System.Windows.Forms.Label()
        Me.txtBin = New System.Windows.Forms.TextBox()
        Me.lblBin = New System.Windows.Forms.Label()
        Me.lblConversor = New System.Windows.Forms.Label()
        Me.lblCalculadora = New System.Windows.Forms.Label()
        Me.txtDireto = New System.Windows.Forms.TextBox()
        Me.txtCRC1 = New System.Windows.Forms.TextBox()
        Me.lblCRC1 = New System.Windows.Forms.Label()
        Me.lblDireto = New System.Windows.Forms.Label()
        Me.txtInverso = New System.Windows.Forms.TextBox()
        Me.txtCRC2 = New System.Windows.Forms.TextBox()
        Me.lblInverso = New System.Windows.Forms.Label()
        Me.lblCRC2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtDec
        '
        Me.txtDec.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtDec.Location = New System.Drawing.Point(246, 99)
        Me.txtDec.Margin = New System.Windows.Forms.Padding(3, 25, 3, 25)
        Me.txtDec.Name = "txtDec"
        Me.txtDec.Size = New System.Drawing.Size(450, 29)
        Me.txtDec.TabIndex = 0
        '
        'lblDec
        '
        Me.lblDec.AutoSize = True
        Me.lblDec.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblDec.Location = New System.Drawing.Point(171, 102)
        Me.lblDec.Margin = New System.Windows.Forms.Padding(3)
        Me.lblDec.Name = "lblDec"
        Me.lblDec.Size = New System.Drawing.Size(69, 21)
        Me.lblDec.TabIndex = 1
        Me.lblDec.Text = "Decimal:"
        '
        'txtHexa
        '
        Me.txtHexa.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtHexa.Location = New System.Drawing.Point(246, 156)
        Me.txtHexa.Margin = New System.Windows.Forms.Padding(3, 3, 3, 25)
        Me.txtHexa.Name = "txtHexa"
        Me.txtHexa.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHexa.Size = New System.Drawing.Size(450, 29)
        Me.txtHexa.TabIndex = 0
        '
        'lblHexa
        '
        Me.lblHexa.AutoSize = True
        Me.lblHexa.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblHexa.Location = New System.Drawing.Point(139, 159)
        Me.lblHexa.Name = "lblHexa"
        Me.lblHexa.Size = New System.Drawing.Size(101, 21)
        Me.lblHexa.TabIndex = 1
        Me.lblHexa.Text = "Hexadecimal:"
        '
        'txtBin
        '
        Me.txtBin.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtBin.Location = New System.Drawing.Point(246, 213)
        Me.txtBin.Margin = New System.Windows.Forms.Padding(3, 3, 3, 25)
        Me.txtBin.Name = "txtBin"
        Me.txtBin.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtBin.Size = New System.Drawing.Size(450, 29)
        Me.txtBin.TabIndex = 0
        '
        'lblBin
        '
        Me.lblBin.AutoSize = True
        Me.lblBin.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblBin.Location = New System.Drawing.Point(178, 216)
        Me.lblBin.Name = "lblBin"
        Me.lblBin.Size = New System.Drawing.Size(62, 21)
        Me.lblBin.TabIndex = 1
        Me.lblBin.Text = "Binário:"
        '
        'lblConversor
        '
        Me.lblConversor.AutoSize = True
        Me.lblConversor.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblConversor.Location = New System.Drawing.Point(373, 29)
        Me.lblConversor.Name = "lblConversor"
        Me.lblConversor.Size = New System.Drawing.Size(164, 45)
        Me.lblConversor.TabIndex = 2
        Me.lblConversor.Text = "Conversor"
        '
        'lblCalculadora
        '
        Me.lblCalculadora.AutoSize = True
        Me.lblCalculadora.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblCalculadora.Location = New System.Drawing.Point(313, 292)
        Me.lblCalculadora.Margin = New System.Windows.Forms.Padding(3, 25, 3, 0)
        Me.lblCalculadora.Name = "lblCalculadora"
        Me.lblCalculadora.Size = New System.Drawing.Size(254, 45)
        Me.lblCalculadora.TabIndex = 2
        Me.lblCalculadora.Text = "Calculadora CRC"
        '
        'txtDireto
        '
        Me.txtDireto.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtDireto.Location = New System.Drawing.Point(34, 392)
        Me.txtDireto.Margin = New System.Windows.Forms.Padding(25, 10, 5, 25)
        Me.txtDireto.Name = "txtDireto"
        Me.txtDireto.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDireto.Size = New System.Drawing.Size(702, 29)
        Me.txtDireto.TabIndex = 0
        '
        'txtCRC1
        '
        Me.txtCRC1.Enabled = False
        Me.txtCRC1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtCRC1.Location = New System.Drawing.Point(766, 392)
        Me.txtCRC1.Margin = New System.Windows.Forms.Padding(25, 10, 25, 25)
        Me.txtCRC1.Name = "txtCRC1"
        Me.txtCRC1.Size = New System.Drawing.Size(72, 29)
        Me.txtCRC1.TabIndex = 0
        '
        'lblCRC1
        '
        Me.lblCRC1.AutoSize = True
        Me.lblCRC1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblCRC1.Location = New System.Drawing.Point(782, 361)
        Me.lblCRC1.Name = "lblCRC1"
        Me.lblCRC1.Size = New System.Drawing.Size(40, 21)
        Me.lblCRC1.TabIndex = 3
        Me.lblCRC1.Text = "CRC"
        '
        'lblDireto
        '
        Me.lblDireto.AutoSize = True
        Me.lblDireto.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblDireto.Location = New System.Drawing.Point(34, 361)
        Me.lblDireto.Margin = New System.Windows.Forms.Padding(3, 25, 3, 0)
        Me.lblDireto.Name = "lblDireto"
        Me.lblDireto.Size = New System.Drawing.Size(130, 21)
        Me.lblDireto.TabIndex = 1
        Me.lblDireto.Text = "Sequência Direta:"
        '
        'txtInverso
        '
        Me.txtInverso.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtInverso.Location = New System.Drawing.Point(34, 469)
        Me.txtInverso.Margin = New System.Windows.Forms.Padding(25, 10, 5, 25)
        Me.txtInverso.Name = "txtInverso"
        Me.txtInverso.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtInverso.Size = New System.Drawing.Size(702, 29)
        Me.txtInverso.TabIndex = 0
        '
        'txtCRC2
        '
        Me.txtCRC2.Enabled = False
        Me.txtCRC2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtCRC2.Location = New System.Drawing.Point(766, 469)
        Me.txtCRC2.Margin = New System.Windows.Forms.Padding(25, 10, 25, 25)
        Me.txtCRC2.Name = "txtCRC2"
        Me.txtCRC2.Size = New System.Drawing.Size(72, 29)
        Me.txtCRC2.TabIndex = 0
        '
        'lblInverso
        '
        Me.lblInverso.AutoSize = True
        Me.lblInverso.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblInverso.Location = New System.Drawing.Point(34, 438)
        Me.lblInverso.Margin = New System.Windows.Forms.Padding(3, 25, 3, 0)
        Me.lblInverso.Name = "lblInverso"
        Me.lblInverso.Size = New System.Drawing.Size(138, 21)
        Me.lblInverso.TabIndex = 1
        Me.lblInverso.Text = "Sequência Inversa:"
        '
        'lblCRC2
        '
        Me.lblCRC2.AutoSize = True
        Me.lblCRC2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblCRC2.Location = New System.Drawing.Point(782, 438)
        Me.lblCRC2.Name = "lblCRC2"
        Me.lblCRC2.Size = New System.Drawing.Size(40, 21)
        Me.lblCRC2.TabIndex = 3
        Me.lblCRC2.Text = "CRC"
        '
        'Calculadora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 561)
        Me.Controls.Add(Me.lblCRC2)
        Me.Controls.Add(Me.lblCRC1)
        Me.Controls.Add(Me.lblCalculadora)
        Me.Controls.Add(Me.lblConversor)
        Me.Controls.Add(Me.lblInverso)
        Me.Controls.Add(Me.lblDireto)
        Me.Controls.Add(Me.lblBin)
        Me.Controls.Add(Me.lblHexa)
        Me.Controls.Add(Me.lblDec)
        Me.Controls.Add(Me.txtBin)
        Me.Controls.Add(Me.txtHexa)
        Me.Controls.Add(Me.txtCRC2)
        Me.Controls.Add(Me.txtCRC1)
        Me.Controls.Add(Me.txtInverso)
        Me.Controls.Add(Me.txtDireto)
        Me.Controls.Add(Me.txtDec)
        Me.Name = "Calculadora"
        Me.Text = "Calculadora"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblDec As Label
    Friend WithEvents txtHexa As TextBox
    Friend WithEvents lblHexa As Label
    Friend WithEvents txtBin As TextBox
    Friend WithEvents lblBin As Label
    Friend WithEvents lblConversor As Label
    Friend WithEvents lblCalculadora As Label
    Friend WithEvents txtDireto As TextBox
    Friend WithEvents txtCRC1 As TextBox
    Friend WithEvents lblCRC1 As Label
    Friend WithEvents lblDireto As Label
    Friend WithEvents txtInverso As TextBox
    Friend WithEvents txtCRC2 As TextBox
    Friend WithEvents lblInverso As Label
    Friend WithEvents lblCRC2 As Label
    Friend WithEvents txtDec As TextBox
End Class
