<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Edit_Map
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
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DvwEdges = New System.Windows.Forms.DataGridView()
        Me.Start = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Destination = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Distance = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NudDistance = New System.Windows.Forms.NumericUpDown()
        Me.CbxEndLocation = New System.Windows.Forms.ComboBox()
        Me.CbxStartLocation = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BtnAddEdge = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.TbxAddLocation = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.LblEdgeCount = New System.Windows.Forms.Label()
        Me.LblEdges = New System.Windows.Forms.Label()
        Me.LblLocationCount = New System.Windows.Forms.Label()
        Me.LblLocations = New System.Windows.Forms.Label()
        Me.TbxMapDirectory = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.RtbInformation = New System.Windows.Forms.RichTextBox()
        Me.GbxAdminTools = New System.Windows.Forms.GroupBox()
        Me.BtnDeleteIsolatedNodes = New System.Windows.Forms.Button()
        Me.BtnLoadMap = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DvwEdges, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NudDistance, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GbxAdminTools.SuspendLayout()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DvwEdges)
        Me.GroupBox2.Controls.Add(Me.NudDistance)
        Me.GroupBox2.Controls.Add(Me.CbxEndLocation)
        Me.GroupBox2.Controls.Add(Me.CbxStartLocation)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.BtnSave)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.BtnAddEdge)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Button10)
        Me.GroupBox2.Controls.Add(Me.TbxAddLocation)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 116)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(836, 223)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Add Locations"
        '
        'DvwEdges
        '
        Me.DvwEdges.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DvwEdges.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Start, Me.Destination, Me.Distance})
        Me.DvwEdges.Location = New System.Drawing.Point(15, 59)
        Me.DvwEdges.Name = "DvwEdges"
        Me.DvwEdges.Size = New System.Drawing.Size(815, 105)
        Me.DvwEdges.TabIndex = 21
        '
        'Start
        '
        Me.Start.HeaderText = "Start"
        Me.Start.Name = "Start"
        Me.Start.ReadOnly = True
        Me.Start.Width = 300
        '
        'Destination
        '
        Me.Destination.HeaderText = "Destination"
        Me.Destination.Name = "Destination"
        Me.Destination.ReadOnly = True
        Me.Destination.Width = 300
        '
        'Distance
        '
        Me.Distance.HeaderText = "Distance"
        Me.Distance.Name = "Distance"
        Me.Distance.ReadOnly = True
        '
        'NudDistance
        '
        Me.NudDistance.DecimalPlaces = 1
        Me.NudDistance.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.NudDistance.Location = New System.Drawing.Point(614, 173)
        Me.NudDistance.Name = "NudDistance"
        Me.NudDistance.Size = New System.Drawing.Size(120, 20)
        Me.NudDistance.TabIndex = 20
        '
        'CbxEndLocation
        '
        Me.CbxEndLocation.FormattingEnabled = True
        Me.CbxEndLocation.Location = New System.Drawing.Point(346, 173)
        Me.CbxEndLocation.Name = "CbxEndLocation"
        Me.CbxEndLocation.Size = New System.Drawing.Size(171, 21)
        Me.CbxEndLocation.TabIndex = 19
        '
        'CbxStartLocation
        '
        Me.CbxStartLocation.FormattingEnabled = True
        Me.CbxStartLocation.Location = New System.Drawing.Point(92, 173)
        Me.CbxStartLocation.Name = "CbxStartLocation"
        Me.CbxStartLocation.Size = New System.Drawing.Size(171, 21)
        Me.CbxStartLocation.TabIndex = 18
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(523, 176)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(85, 13)
        Me.Label12.TabIndex = 17
        Me.Label12.Text = "Distance (Miles):"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(269, 176)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(73, 13)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "End Location:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 176)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(76, 13)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Start Location:"
        '
        'BtnSave
        '
        Me.BtnSave.Enabled = False
        Me.BtnSave.Location = New System.Drawing.Point(6, 197)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(824, 23)
        Me.BtnSave.TabIndex = 12
        Me.BtnSave.Text = "Save Map"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(14, 43)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 13)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "New Edge"
        '
        'BtnAddEdge
        '
        Me.BtnAddEdge.Enabled = False
        Me.BtnAddEdge.Location = New System.Drawing.Point(755, 170)
        Me.BtnAddEdge.Name = "BtnAddEdge"
        Me.BtnAddEdge.Size = New System.Drawing.Size(75, 23)
        Me.BtnAddEdge.TabIndex = 3
        Me.BtnAddEdge.Text = "Add"
        Me.BtnAddEdge.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 13)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "New Location: "
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(755, 17)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(75, 22)
        Me.Button10.TabIndex = 0
        Me.Button10.Text = "Add"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'TbxAddLocation
        '
        Me.TbxAddLocation.Location = New System.Drawing.Point(92, 19)
        Me.TbxAddLocation.Name = "TbxAddLocation"
        Me.TbxAddLocation.Size = New System.Drawing.Size(657, 20)
        Me.TbxAddLocation.TabIndex = 1
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.LblEdgeCount)
        Me.GroupBox3.Controls.Add(Me.LblEdges)
        Me.GroupBox3.Controls.Add(Me.LblLocationCount)
        Me.GroupBox3.Controls.Add(Me.LblLocations)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 59)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(91, 51)
        Me.GroupBox3.TabIndex = 14
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Statistics"
        '
        'LblEdgeCount
        '
        Me.LblEdgeCount.AutoSize = True
        Me.LblEdgeCount.Location = New System.Drawing.Point(67, 33)
        Me.LblEdgeCount.Name = "LblEdgeCount"
        Me.LblEdgeCount.Size = New System.Drawing.Size(13, 13)
        Me.LblEdgeCount.TabIndex = 2
        Me.LblEdgeCount.Text = "0"
        '
        'LblEdges
        '
        Me.LblEdges.AutoSize = True
        Me.LblEdges.Location = New System.Drawing.Point(29, 33)
        Me.LblEdges.Name = "LblEdges"
        Me.LblEdges.Size = New System.Drawing.Size(40, 13)
        Me.LblEdges.TabIndex = 1
        Me.LblEdges.Text = "Edges:"
        '
        'LblLocationCount
        '
        Me.LblLocationCount.AutoSize = True
        Me.LblLocationCount.Location = New System.Drawing.Point(67, 20)
        Me.LblLocationCount.Name = "LblLocationCount"
        Me.LblLocationCount.Size = New System.Drawing.Size(13, 13)
        Me.LblLocationCount.TabIndex = 0
        Me.LblLocationCount.Text = "0"
        '
        'LblLocations
        '
        Me.LblLocations.AutoSize = True
        Me.LblLocations.Location = New System.Drawing.Point(14, 20)
        Me.LblLocations.Name = "LblLocations"
        Me.LblLocations.Size = New System.Drawing.Size(56, 13)
        Me.LblLocations.TabIndex = 0
        Me.LblLocations.Text = "Locations:"
        '
        'TbxMapDirectory
        '
        Me.TbxMapDirectory.Location = New System.Drawing.Point(92, 13)
        Me.TbxMapDirectory.Name = "TbxMapDirectory"
        Me.TbxMapDirectory.Size = New System.Drawing.Size(657, 20)
        Me.TbxMapDirectory.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(755, 11)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Browse"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Map File:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.TbxMapDirectory)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(836, 41)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Map Directory"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.RtbInformation)
        Me.GroupBox4.Location = New System.Drawing.Point(109, 60)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(457, 50)
        Me.GroupBox4.TabIndex = 15
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Information"
        '
        'RtbInformation
        '
        Me.RtbInformation.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RtbInformation.Location = New System.Drawing.Point(6, 19)
        Me.RtbInformation.Name = "RtbInformation"
        Me.RtbInformation.ReadOnly = True
        Me.RtbInformation.Size = New System.Drawing.Size(445, 27)
        Me.RtbInformation.TabIndex = 0
        Me.RtbInformation.Text = ""
        '
        'GbxAdminTools
        '
        Me.GbxAdminTools.Controls.Add(Me.BtnDeleteIsolatedNodes)
        Me.GbxAdminTools.Controls.Add(Me.BtnLoadMap)
        Me.GbxAdminTools.Location = New System.Drawing.Point(572, 59)
        Me.GbxAdminTools.Name = "GbxAdminTools"
        Me.GbxAdminTools.Size = New System.Drawing.Size(276, 51)
        Me.GbxAdminTools.TabIndex = 3
        Me.GbxAdminTools.TabStop = False
        Me.GbxAdminTools.Text = "Administrator Tools"
        '
        'BtnDeleteIsolatedNodes
        '
        Me.BtnDeleteIsolatedNodes.ForeColor = System.Drawing.Color.Red
        Me.BtnDeleteIsolatedNodes.Location = New System.Drawing.Point(9, 19)
        Me.BtnDeleteIsolatedNodes.Name = "BtnDeleteIsolatedNodes"
        Me.BtnDeleteIsolatedNodes.Size = New System.Drawing.Size(182, 23)
        Me.BtnDeleteIsolatedNodes.TabIndex = 5
        Me.BtnDeleteIsolatedNodes.Text = "DELETE ALL ISOLATED NODES"
        Me.BtnDeleteIsolatedNodes.UseVisualStyleBackColor = True
        '
        'BtnLoadMap
        '
        Me.BtnLoadMap.Location = New System.Drawing.Point(195, 19)
        Me.BtnLoadMap.Name = "BtnLoadMap"
        Me.BtnLoadMap.Size = New System.Drawing.Size(75, 23)
        Me.BtnLoadMap.TabIndex = 4
        Me.BtnLoadMap.Text = "Load Map"
        Me.BtnLoadMap.UseVisualStyleBackColor = True
        '
        'Edit_Map
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(860, 344)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GbxAdminTools)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Edit_Map"
        Me.Text = "Map Settings"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DvwEdges, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NudDistance, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GbxAdminTools.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents BtnAddEdge As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents TbxAddLocation As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents LblLocationCount As System.Windows.Forms.Label
    Friend WithEvents LblLocations As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents CbxEndLocation As System.Windows.Forms.ComboBox
    Friend WithEvents CbxStartLocation As System.Windows.Forms.ComboBox
    Friend WithEvents NudDistance As System.Windows.Forms.NumericUpDown
    Friend WithEvents TbxMapDirectory As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LblEdgeCount As System.Windows.Forms.Label
    Friend WithEvents LblEdges As System.Windows.Forms.Label
    Friend WithEvents DvwEdges As System.Windows.Forms.DataGridView
    Friend WithEvents Start As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Destination As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Distance As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents RtbInformation As System.Windows.Forms.RichTextBox
    Friend WithEvents GbxAdminTools As System.Windows.Forms.GroupBox
    Friend WithEvents BtnLoadMap As System.Windows.Forms.Button
    Friend WithEvents BtnDeleteIsolatedNodes As System.Windows.Forms.Button
End Class
