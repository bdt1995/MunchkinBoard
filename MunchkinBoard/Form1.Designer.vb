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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.P1Add = New System.Windows.Forms.Button()
        Me.P1Minus = New System.Windows.Forms.Button()
        Me.P1Level = New System.Windows.Forms.Label()
        Me.P1Reset = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.P2Reset = New System.Windows.Forms.Button()
        Me.P2Level = New System.Windows.Forms.Label()
        Me.P2Minus = New System.Windows.Forms.Button()
        Me.P2Add = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.P3Reset = New System.Windows.Forms.Button()
        Me.P3Level = New System.Windows.Forms.Label()
        Me.P3Minus = New System.Windows.Forms.Button()
        Me.P3Add = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.P4Reset = New System.Windows.Forms.Button()
        Me.P4Level = New System.Windows.Forms.Label()
        Me.P4Minus = New System.Windows.Forms.Button()
        Me.P4Add = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TotalResetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.P1Reset)
        Me.GroupBox1.Controls.Add(Me.P1Level)
        Me.GroupBox1.Controls.Add(Me.P1Minus)
        Me.GroupBox1.Controls.Add(Me.P1Add)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 41)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(251, 228)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Player 1"
        '
        'P1Add
        '
        Me.P1Add.Location = New System.Drawing.Point(6, 144)
        Me.P1Add.Name = "P1Add"
        Me.P1Add.Size = New System.Drawing.Size(64, 68)
        Me.P1Add.TabIndex = 0
        Me.P1Add.Text = "+"
        Me.P1Add.UseVisualStyleBackColor = True
        '
        'P1Minus
        '
        Me.P1Minus.Location = New System.Drawing.Point(181, 144)
        Me.P1Minus.Name = "P1Minus"
        Me.P1Minus.Size = New System.Drawing.Size(64, 68)
        Me.P1Minus.TabIndex = 1
        Me.P1Minus.Text = "-"
        Me.P1Minus.UseVisualStyleBackColor = True
        '
        'P1Level
        '
        Me.P1Level.AutoSize = True
        Me.P1Level.Location = New System.Drawing.Point(97, 70)
        Me.P1Level.Name = "P1Level"
        Me.P1Level.Size = New System.Drawing.Size(58, 17)
        Me.P1Level.TabIndex = 2
        Me.P1Level.Text = "Level: 1"
        '
        'P1Reset
        '
        Me.P1Reset.Location = New System.Drawing.Point(90, 167)
        Me.P1Reset.Name = "P1Reset"
        Me.P1Reset.Size = New System.Drawing.Size(75, 23)
        Me.P1Reset.TabIndex = 3
        Me.P1Reset.Text = "reset"
        Me.P1Reset.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.P2Reset)
        Me.GroupBox2.Controls.Add(Me.P2Level)
        Me.GroupBox2.Controls.Add(Me.P2Minus)
        Me.GroupBox2.Controls.Add(Me.P2Add)
        Me.GroupBox2.Location = New System.Drawing.Point(318, 41)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(251, 228)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Player 2"
        '
        'P2Reset
        '
        Me.P2Reset.Location = New System.Drawing.Point(90, 167)
        Me.P2Reset.Name = "P2Reset"
        Me.P2Reset.Size = New System.Drawing.Size(75, 23)
        Me.P2Reset.TabIndex = 3
        Me.P2Reset.Text = "reset"
        Me.P2Reset.UseVisualStyleBackColor = True
        '
        'P2Level
        '
        Me.P2Level.AutoSize = True
        Me.P2Level.Location = New System.Drawing.Point(97, 70)
        Me.P2Level.Name = "P2Level"
        Me.P2Level.Size = New System.Drawing.Size(58, 17)
        Me.P2Level.TabIndex = 2
        Me.P2Level.Text = "Level: 1"
        '
        'P2Minus
        '
        Me.P2Minus.Location = New System.Drawing.Point(181, 144)
        Me.P2Minus.Name = "P2Minus"
        Me.P2Minus.Size = New System.Drawing.Size(64, 68)
        Me.P2Minus.TabIndex = 1
        Me.P2Minus.Text = "-"
        Me.P2Minus.UseVisualStyleBackColor = True
        '
        'P2Add
        '
        Me.P2Add.Location = New System.Drawing.Point(6, 144)
        Me.P2Add.Name = "P2Add"
        Me.P2Add.Size = New System.Drawing.Size(64, 68)
        Me.P2Add.TabIndex = 0
        Me.P2Add.Text = "+"
        Me.P2Add.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.P3Reset)
        Me.GroupBox3.Controls.Add(Me.P3Level)
        Me.GroupBox3.Controls.Add(Me.P3Minus)
        Me.GroupBox3.Controls.Add(Me.P3Add)
        Me.GroupBox3.Location = New System.Drawing.Point(608, 41)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(251, 228)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Player 3"
        '
        'P3Reset
        '
        Me.P3Reset.Location = New System.Drawing.Point(90, 167)
        Me.P3Reset.Name = "P3Reset"
        Me.P3Reset.Size = New System.Drawing.Size(75, 23)
        Me.P3Reset.TabIndex = 3
        Me.P3Reset.Text = "reset"
        Me.P3Reset.UseVisualStyleBackColor = True
        '
        'P3Level
        '
        Me.P3Level.AutoSize = True
        Me.P3Level.Location = New System.Drawing.Point(97, 70)
        Me.P3Level.Name = "P3Level"
        Me.P3Level.Size = New System.Drawing.Size(58, 17)
        Me.P3Level.TabIndex = 2
        Me.P3Level.Text = "Level: 1"
        '
        'P3Minus
        '
        Me.P3Minus.Location = New System.Drawing.Point(181, 144)
        Me.P3Minus.Name = "P3Minus"
        Me.P3Minus.Size = New System.Drawing.Size(64, 68)
        Me.P3Minus.TabIndex = 1
        Me.P3Minus.Text = "-"
        Me.P3Minus.UseVisualStyleBackColor = True
        '
        'P3Add
        '
        Me.P3Add.Location = New System.Drawing.Point(6, 144)
        Me.P3Add.Name = "P3Add"
        Me.P3Add.Size = New System.Drawing.Size(64, 68)
        Me.P3Add.TabIndex = 0
        Me.P3Add.Text = "+"
        Me.P3Add.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.P4Reset)
        Me.GroupBox4.Controls.Add(Me.P4Level)
        Me.GroupBox4.Controls.Add(Me.P4Minus)
        Me.GroupBox4.Controls.Add(Me.P4Add)
        Me.GroupBox4.Location = New System.Drawing.Point(885, 41)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(251, 228)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Player 4"
        '
        'P4Reset
        '
        Me.P4Reset.Location = New System.Drawing.Point(90, 167)
        Me.P4Reset.Name = "P4Reset"
        Me.P4Reset.Size = New System.Drawing.Size(75, 23)
        Me.P4Reset.TabIndex = 3
        Me.P4Reset.Text = "reset"
        Me.P4Reset.UseVisualStyleBackColor = True
        '
        'P4Level
        '
        Me.P4Level.AutoSize = True
        Me.P4Level.Location = New System.Drawing.Point(97, 70)
        Me.P4Level.Name = "P4Level"
        Me.P4Level.Size = New System.Drawing.Size(58, 17)
        Me.P4Level.TabIndex = 2
        Me.P4Level.Text = "Level: 1"
        '
        'P4Minus
        '
        Me.P4Minus.Location = New System.Drawing.Point(181, 144)
        Me.P4Minus.Name = "P4Minus"
        Me.P4Minus.Size = New System.Drawing.Size(64, 68)
        Me.P4Minus.TabIndex = 1
        Me.P4Minus.Text = "-"
        Me.P4Minus.UseVisualStyleBackColor = True
        '
        'P4Add
        '
        Me.P4Add.Location = New System.Drawing.Point(6, 144)
        Me.P4Add.Name = "P4Add"
        Me.P4Add.Size = New System.Drawing.Size(64, 68)
        Me.P4Add.TabIndex = 0
        Me.P4Add.Text = "+"
        Me.P4Add.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1148, 28)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TotalResetToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(44, 24)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'TotalResetToolStripMenuItem
        '
        Me.TotalResetToolStripMenuItem.Name = "TotalResetToolStripMenuItem"
        Me.TotalResetToolStripMenuItem.Size = New System.Drawing.Size(175, 24)
        Me.TotalResetToolStripMenuItem.Text = "Total Reset"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1148, 534)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents P1Reset As System.Windows.Forms.Button
    Friend WithEvents P1Level As System.Windows.Forms.Label
    Friend WithEvents P1Minus As System.Windows.Forms.Button
    Friend WithEvents P1Add As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents P2Reset As System.Windows.Forms.Button
    Friend WithEvents P2Level As System.Windows.Forms.Label
    Friend WithEvents P2Minus As System.Windows.Forms.Button
    Friend WithEvents P2Add As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents P3Reset As System.Windows.Forms.Button
    Friend WithEvents P3Level As System.Windows.Forms.Label
    Friend WithEvents P3Minus As System.Windows.Forms.Button
    Friend WithEvents P3Add As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents P4Reset As System.Windows.Forms.Button
    Friend WithEvents P4Level As System.Windows.Forms.Label
    Friend WithEvents P4Minus As System.Windows.Forms.Button
    Friend WithEvents P4Add As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TotalResetToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
