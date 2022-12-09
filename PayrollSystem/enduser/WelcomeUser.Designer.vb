<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WelcomeUser
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
        Me.tableView = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.tableView.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tableView
        '
        Me.tableView.Controls.Add(Me.TabPage1)
        Me.tableView.Controls.Add(Me.TabPage6)
        Me.tableView.Location = New System.Drawing.Point(254, 68)
        Me.tableView.Name = "tableView"
        Me.tableView.SelectedIndex = 0
        Me.tableView.Size = New System.Drawing.Size(700, 384)
        Me.tableView.TabIndex = 42
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.DataGridView1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(692, 358)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "EMPLOYEE"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.DataGridView2)
        Me.TabPage6.Location = New System.Drawing.Point(4, 22)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage6.Size = New System.Drawing.Size(692, 358)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "LEAVES"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(6, 6)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(680, 349)
        Me.DataGridView2.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(52, 409)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(147, 23)
        Me.Button1.TabIndex = 41
        Me.Button1.Text = "View My Payroll"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(37, 242)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(162, 23)
        Me.Button7.TabIndex = 40
        Me.Button7.Text = "Manage my Leaves"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(958, 31)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(85, 23)
        Me.Button9.TabIndex = 39
        Me.Button9.Text = "Update Tables"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(968, 456)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(75, 23)
        Me.Button8.TabIndex = 38
        Me.Button8.Text = "Logout"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(37, 193)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(162, 23)
        Me.Button3.TabIndex = 35
        Me.Button3.Text = "Manage  my Employee Record"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(61, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Welcome, User!"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(6, 6)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(680, 349)
        Me.DataGridView1.TabIndex = 43
        '
        'WelcomeUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1066, 521)
        Me.Controls.Add(Me.tableView)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label1)
        Me.Name = "WelcomeUser"
        Me.Text = "User Interface"
        Me.tableView.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage6.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tableView As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
End Class
