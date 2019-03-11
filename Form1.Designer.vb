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
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtNederlands = New System.Windows.Forms.TextBox()
        Me.txtEngels = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.BestandToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NieuwToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpslaanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpslaanAlsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AfsluitenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OefeningenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NederlandsEngelsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EngelsNederlandsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OverToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.save = New System.Windows.Forms.SaveFileDialog()
        Me.open = New System.Windows.Forms.OpenFileDialog()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 14
        Me.ListBox1.Location = New System.Drawing.Point(80, 262)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(419, 186)
        Me.ListBox1.TabIndex = 15
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(269, 194)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "toevoegen"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(152, 194)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "verwijderen"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtNederlands
        '
        Me.txtNederlands.Location = New System.Drawing.Point(170, 123)
        Me.txtNederlands.Name = "txtNederlands"
        Me.txtNederlands.Size = New System.Drawing.Size(166, 20)
        Me.txtNederlands.TabIndex = 12
        '
        'txtEngels
        '
        Me.txtEngels.Location = New System.Drawing.Point(170, 75)
        Me.txtEngels.Name = "txtEngels"
        Me.txtEngels.Size = New System.Drawing.Size(166, 20)
        Me.txtEngels.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(52, 131)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Nederlands"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(52, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Engels"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BestandToolStripMenuItem, Me.OefeningenToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'BestandToolStripMenuItem
        '
        Me.BestandToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NieuwToolStripMenuItem, Me.OpenToolStripMenuItem, Me.OpslaanToolStripMenuItem, Me.OpslaanAlsToolStripMenuItem, Me.AfsluitenToolStripMenuItem})
        Me.BestandToolStripMenuItem.Name = "BestandToolStripMenuItem"
        Me.BestandToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.BestandToolStripMenuItem.Text = "bestand"
        '
        'NieuwToolStripMenuItem
        '
        Me.NieuwToolStripMenuItem.Name = "NieuwToolStripMenuItem"
        Me.NieuwToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.NieuwToolStripMenuItem.Text = "nieuw"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.OpenToolStripMenuItem.Text = "open"
        '
        'OpslaanToolStripMenuItem
        '
        Me.OpslaanToolStripMenuItem.Name = "OpslaanToolStripMenuItem"
        Me.OpslaanToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.OpslaanToolStripMenuItem.Text = "ops&laan"
        '
        'OpslaanAlsToolStripMenuItem
        '
        Me.OpslaanAlsToolStripMenuItem.Name = "OpslaanAlsToolStripMenuItem"
        Me.OpslaanAlsToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.OpslaanAlsToolStripMenuItem.Text = "Opslaan als"
        '
        'AfsluitenToolStripMenuItem
        '
        Me.AfsluitenToolStripMenuItem.Name = "AfsluitenToolStripMenuItem"
        Me.AfsluitenToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.AfsluitenToolStripMenuItem.Text = "Afsluiten"
        '
        'OefeningenToolStripMenuItem
        '
        Me.OefeningenToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NederlandsEngelsToolStripMenuItem, Me.EngelsNederlandsToolStripMenuItem})
        Me.OefeningenToolStripMenuItem.Name = "OefeningenToolStripMenuItem"
        Me.OefeningenToolStripMenuItem.Size = New System.Drawing.Size(81, 20)
        Me.OefeningenToolStripMenuItem.Text = "Oefeningen"
        '
        'NederlandsEngelsToolStripMenuItem
        '
        Me.NederlandsEngelsToolStripMenuItem.Name = "NederlandsEngelsToolStripMenuItem"
        Me.NederlandsEngelsToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.NederlandsEngelsToolStripMenuItem.Text = "Nederlands - Engels"
        '
        'EngelsNederlandsToolStripMenuItem
        '
        Me.EngelsNederlandsToolStripMenuItem.Name = "EngelsNederlandsToolStripMenuItem"
        Me.EngelsNederlandsToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.EngelsNederlandsToolStripMenuItem.Text = "Engels - Nederlands"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OverToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(47, 20)
        Me.HelpToolStripMenuItem.Text = "Help "
        '
        'OverToolStripMenuItem
        '
        Me.OverToolStripMenuItem.Name = "OverToolStripMenuItem"
        Me.OverToolStripMenuItem.Size = New System.Drawing.Size(97, 22)
        Me.OverToolStripMenuItem.Text = "over"
        '
        'open
        '
        Me.open.FileName = "OpenFileDialog1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 496)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtNederlands)
        Me.Controls.Add(Me.txtEngels)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents txtNederlands As TextBox
    Friend WithEvents txtEngels As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents BestandToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NieuwToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpslaanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpslaanAlsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AfsluitenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OefeningenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NederlandsEngelsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EngelsNederlandsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OverToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents save As SaveFileDialog
    Friend WithEvents open As OpenFileDialog
End Class
