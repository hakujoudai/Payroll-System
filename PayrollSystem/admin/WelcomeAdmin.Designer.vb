﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WelcomeAdmin
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.tableView = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.DataGridView4 = New System.Windows.Forms.DataGridView()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.DataGridView5 = New System.Windows.Forms.DataGridView()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.DataGridView6 = New System.Windows.Forms.DataGridView()
        Me.TabPage7 = New System.Windows.Forms.TabPage()
        Me.DataGridView7 = New System.Windows.Forms.DataGridView()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.tableView.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage5.SuspendLayout()
        CType(Me.DataGridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage6.SuspendLayout()
        CType(Me.DataGridView6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage7.SuspendLayout()
        CType(Me.DataGridView7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(101, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Welcome, Admin!"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(77, 112)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(147, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Manage Employees"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(77, 160)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(147, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Manage Job Department"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'tableView
        '
        Me.tableView.Controls.Add(Me.TabPage1)
        Me.tableView.Controls.Add(Me.TabPage2)
        Me.tableView.Controls.Add(Me.TabPage3)
        Me.tableView.Controls.Add(Me.TabPage4)
        Me.tableView.Controls.Add(Me.TabPage5)
        Me.tableView.Controls.Add(Me.TabPage6)
        Me.tableView.Controls.Add(Me.TabPage7)
        Me.tableView.Location = New System.Drawing.Point(302, 56)
        Me.tableView.Name = "tableView"
        Me.tableView.SelectedIndex = 0
        Me.tableView.Size = New System.Drawing.Size(700, 384)
        Me.tableView.TabIndex = 3
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
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(6, 6)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(680, 349)
        Me.DataGridView1.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.DataGridView2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(692, 358)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "JOB DEPT"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(6, 6)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(680, 349)
        Me.DataGridView2.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.DataGridView3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(692, 358)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "SALARY"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'DataGridView3
        '
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Location = New System.Drawing.Point(6, 6)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.Size = New System.Drawing.Size(680, 349)
        Me.DataGridView3.TabIndex = 0
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.DataGridView4)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(692, 358)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "BONUSES"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'DataGridView4
        '
        Me.DataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView4.Location = New System.Drawing.Point(6, 6)
        Me.DataGridView4.Name = "DataGridView4"
        Me.DataGridView4.Size = New System.Drawing.Size(680, 349)
        Me.DataGridView4.TabIndex = 0
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.DataGridView5)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(692, 358)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "DEDUCTIONS"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'DataGridView5
        '
        Me.DataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView5.Location = New System.Drawing.Point(6, 6)
        Me.DataGridView5.Name = "DataGridView5"
        Me.DataGridView5.Size = New System.Drawing.Size(680, 349)
        Me.DataGridView5.TabIndex = 0
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.DataGridView6)
        Me.TabPage6.Location = New System.Drawing.Point(4, 22)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage6.Size = New System.Drawing.Size(692, 358)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "LEAVES"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'DataGridView6
        '
        Me.DataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView6.Location = New System.Drawing.Point(6, 6)
        Me.DataGridView6.Name = "DataGridView6"
        Me.DataGridView6.Size = New System.Drawing.Size(680, 349)
        Me.DataGridView6.TabIndex = 0
        '
        'TabPage7
        '
        Me.TabPage7.Controls.Add(Me.DataGridView7)
        Me.TabPage7.Location = New System.Drawing.Point(4, 22)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage7.Size = New System.Drawing.Size(692, 358)
        Me.TabPage7.TabIndex = 6
        Me.TabPage7.Text = "PAYROLL"
        Me.TabPage7.UseVisualStyleBackColor = True
        '
        'DataGridView7
        '
        Me.DataGridView7.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView7.Location = New System.Drawing.Point(6, 6)
        Me.DataGridView7.Name = "DataGridView7"
        Me.DataGridView7.Size = New System.Drawing.Size(680, 349)
        Me.DataGridView7.TabIndex = 0
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(77, 211)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(147, 23)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Manage Salary"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(77, 257)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(147, 23)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "Manage Bonuses"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(77, 307)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(147, 23)
        Me.Button5.TabIndex = 5
        Me.Button5.Text = "Manage Deductions"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(77, 359)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(147, 23)
        Me.Button6.TabIndex = 6
        Me.Button6.Text = "Manage Leaves"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(77, 410)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(147, 23)
        Me.Button7.TabIndex = 7
        Me.Button7.Text = "Manage Payroll"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(1008, 458)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(75, 23)
        Me.Button8.TabIndex = 9
        Me.Button8.Text = "Logout"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(998, 33)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(85, 23)
        Me.Button9.TabIndex = 10
        Me.Button9.Text = "Update Tables"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'WelcomeAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1095, 493)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.tableView)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "WelcomeAdmin"
        Me.Text = "Administrator Interface"
        Me.tableView.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage5.ResumeLayout(False)
        CType(Me.DataGridView5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage6.ResumeLayout(False)
        CType(Me.DataGridView6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage7.ResumeLayout(False)
        CType(Me.DataGridView7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents tableView As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents DataGridView4 As DataGridView
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents DataGridView5 As DataGridView
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents DataGridView6 As DataGridView
    Friend WithEvents TabPage7 As TabPage
    Friend WithEvents DataGridView7 As DataGridView
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
End Class
