<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me._AMC1_2003DataSet3 = New FinalProject._AMC1_2003DataSet3()
        Me.RepairsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RepairsTableAdapter = New FinalProject._AMC1_2003DataSet3TableAdapters.RepairsTableAdapter()
        Me._AMC1_2003DataSet4 = New FinalProject._AMC1_2003DataSet4()
        Me.RepairsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.RepairsTableAdapter1 = New FinalProject._AMC1_2003DataSet4TableAdapters.RepairsTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtDisplay = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        CType(Me._AMC1_2003DataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepairsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._AMC1_2003DataSet4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepairsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(65, 260)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "technician id"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(65, 300)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "date of car entry"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(78, 220)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "car id"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(282, 213)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(239, 24)
        Me.TextBox1.TabIndex = 4
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(282, 257)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(239, 24)
        Me.TextBox2.TabIndex = 5
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(282, 300)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(239, 24)
        Me.DateTimePicker1.TabIndex = 6
        '
        '_AMC1_2003DataSet3
        '
        Me._AMC1_2003DataSet3.DataSetName = "_AMC1_2003DataSet3"
        Me._AMC1_2003DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RepairsBindingSource
        '
        Me.RepairsBindingSource.DataMember = "Repairs"
        Me.RepairsBindingSource.DataSource = Me._AMC1_2003DataSet3
        '
        'RepairsTableAdapter
        '
        Me.RepairsTableAdapter.ClearBeforeFill = True
        '
        '_AMC1_2003DataSet4
        '
        Me._AMC1_2003DataSet4.DataSetName = "_AMC1_2003DataSet4"
        Me._AMC1_2003DataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RepairsBindingSource1
        '
        Me.RepairsBindingSource1.DataMember = "Repairs"
        Me.RepairsBindingSource1.DataSource = Me._AMC1_2003DataSet4
        '
        'RepairsTableAdapter1
        '
        Me.RepairsTableAdapter1.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(68, 358)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(123, 77)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Repair car"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtDisplay
        '
        Me.txtDisplay.Location = New System.Drawing.Point(57, 12)
        Me.txtDisplay.Multiline = True
        Me.txtDisplay.Name = "txtDisplay"
        Me.txtDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDisplay.Size = New System.Drawing.Size(773, 187)
        Me.txtDisplay.TabIndex = 8
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(340, 358)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(131, 77)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Car is repaird"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(560, 207)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(233, 34)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "Display reparing car"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(617, 358)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(130, 77)
        Me.Button4.TabIndex = 11
        Me.Button4.Text = "Close"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(73, 515)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(118, 76)
        Me.Button5.TabIndex = 12
        Me.Button5.Text = "Customer"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(340, 515)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(131, 76)
        Me.Button6.TabIndex = 13
        Me.Button6.Text = "Car"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(617, 515)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(130, 76)
        Me.Button7.TabIndex = 14
        Me.Button7.Text = "Technician"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(854, 634)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.txtDisplay)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form4"
        Me.Text = "Form4"
        CType(Me._AMC1_2003DataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepairsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._AMC1_2003DataSet4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepairsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents _AMC1_2003DataSet3 As _AMC1_2003DataSet3
    Friend WithEvents RepairsBindingSource As BindingSource
    Friend WithEvents RepairsTableAdapter As _AMC1_2003DataSet3TableAdapters.RepairsTableAdapter
    Friend WithEvents _AMC1_2003DataSet4 As _AMC1_2003DataSet4
    Friend WithEvents RepairsBindingSource1 As BindingSource
    Friend WithEvents RepairsTableAdapter1 As _AMC1_2003DataSet4TableAdapters.RepairsTableAdapter
    Friend WithEvents Button1 As Button
    Friend WithEvents txtDisplay As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
End Class
