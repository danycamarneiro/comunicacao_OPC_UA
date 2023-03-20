<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.Start_connection_btn = New System.Windows.Forms.Button()
        Me.IP_tb = New System.Windows.Forms.TextBox()
        Me.IP_lbl = New System.Windows.Forms.Label()
        Me.config_btn = New System.Windows.Forms.Button()
        Me.stop_btn = New System.Windows.Forms.Button()
        Me.ns_lbl = New System.Windows.Forms.Label()
        Me.ns_tb = New System.Windows.Forms.TextBox()
        Me.s_lbl = New System.Windows.Forms.Label()
        Me.s_tb = New System.Windows.Forms.TextBox()
        Me.Read_btn = New System.Windows.Forms.Button()
        Me.write_btn = New System.Windows.Forms.Button()
        Me.read_lbl = New System.Windows.Forms.Label()
        Me.read_tb = New System.Windows.Forms.TextBox()
        Me.write_lbl = New System.Windows.Forms.Label()
        Me.write_tb = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Start_connection_btn
        '
        Me.Start_connection_btn.Location = New System.Drawing.Point(77, 76)
        Me.Start_connection_btn.Name = "Start_connection_btn"
        Me.Start_connection_btn.Size = New System.Drawing.Size(128, 23)
        Me.Start_connection_btn.TabIndex = 0
        Me.Start_connection_btn.Text = "Start_connection"
        Me.Start_connection_btn.UseVisualStyleBackColor = True
        '
        'IP_tb
        '
        Me.IP_tb.Location = New System.Drawing.Point(47, 21)
        Me.IP_tb.Name = "IP_tb"
        Me.IP_tb.Size = New System.Drawing.Size(200, 20)
        Me.IP_tb.TabIndex = 1
        '
        'IP_lbl
        '
        Me.IP_lbl.AutoSize = True
        Me.IP_lbl.Location = New System.Drawing.Point(12, 24)
        Me.IP_lbl.Name = "IP_lbl"
        Me.IP_lbl.Size = New System.Drawing.Size(17, 13)
        Me.IP_lbl.TabIndex = 2
        Me.IP_lbl.Text = "IP"
        '
        'config_btn
        '
        Me.config_btn.Location = New System.Drawing.Point(77, 47)
        Me.config_btn.Name = "config_btn"
        Me.config_btn.Size = New System.Drawing.Size(128, 23)
        Me.config_btn.TabIndex = 3
        Me.config_btn.Text = "Update_configuration"
        Me.config_btn.UseVisualStyleBackColor = True
        '
        'stop_btn
        '
        Me.stop_btn.Location = New System.Drawing.Point(77, 105)
        Me.stop_btn.Name = "stop_btn"
        Me.stop_btn.Size = New System.Drawing.Size(128, 23)
        Me.stop_btn.TabIndex = 4
        Me.stop_btn.Text = "Stop_connection"
        Me.stop_btn.UseVisualStyleBackColor = True
        '
        'ns_lbl
        '
        Me.ns_lbl.AutoSize = True
        Me.ns_lbl.Location = New System.Drawing.Point(12, 137)
        Me.ns_lbl.Name = "ns_lbl"
        Me.ns_lbl.Size = New System.Drawing.Size(18, 13)
        Me.ns_lbl.TabIndex = 6
        Me.ns_lbl.Text = "ns"
        '
        'ns_tb
        '
        Me.ns_tb.Location = New System.Drawing.Point(47, 134)
        Me.ns_tb.Name = "ns_tb"
        Me.ns_tb.Size = New System.Drawing.Size(200, 20)
        Me.ns_tb.TabIndex = 5
        '
        's_lbl
        '
        Me.s_lbl.AutoSize = True
        Me.s_lbl.Location = New System.Drawing.Point(12, 163)
        Me.s_lbl.Name = "s_lbl"
        Me.s_lbl.Size = New System.Drawing.Size(12, 13)
        Me.s_lbl.TabIndex = 8
        Me.s_lbl.Text = "s"
        '
        's_tb
        '
        Me.s_tb.Location = New System.Drawing.Point(47, 160)
        Me.s_tb.Name = "s_tb"
        Me.s_tb.Size = New System.Drawing.Size(200, 20)
        Me.s_tb.TabIndex = 7
        '
        'Read_btn
        '
        Me.Read_btn.Location = New System.Drawing.Point(77, 186)
        Me.Read_btn.Name = "Read_btn"
        Me.Read_btn.Size = New System.Drawing.Size(128, 23)
        Me.Read_btn.TabIndex = 9
        Me.Read_btn.Text = "Read"
        Me.Read_btn.UseVisualStyleBackColor = True
        '
        'write_btn
        '
        Me.write_btn.Location = New System.Drawing.Point(78, 345)
        Me.write_btn.Name = "write_btn"
        Me.write_btn.Size = New System.Drawing.Size(128, 23)
        Me.write_btn.TabIndex = 10
        Me.write_btn.Text = "Write"
        Me.write_btn.UseVisualStyleBackColor = True
        '
        'read_lbl
        '
        Me.read_lbl.AutoSize = True
        Me.read_lbl.Location = New System.Drawing.Point(12, 196)
        Me.read_lbl.Name = "read_lbl"
        Me.read_lbl.Size = New System.Drawing.Size(56, 13)
        Me.read_lbl.TabIndex = 12
        Me.read_lbl.Text = "Read_info"
        '
        'read_tb
        '
        Me.read_tb.Location = New System.Drawing.Point(47, 215)
        Me.read_tb.Multiline = True
        Me.read_tb.Name = "read_tb"
        Me.read_tb.Size = New System.Drawing.Size(200, 124)
        Me.read_tb.TabIndex = 11
        '
        'write_lbl
        '
        Me.write_lbl.AutoSize = True
        Me.write_lbl.Location = New System.Drawing.Point(17, 355)
        Me.write_lbl.Name = "write_lbl"
        Me.write_lbl.Size = New System.Drawing.Size(55, 13)
        Me.write_lbl.TabIndex = 14
        Me.write_lbl.Text = "Write_info"
        '
        'write_tb
        '
        Me.write_tb.Location = New System.Drawing.Point(47, 374)
        Me.write_tb.Name = "write_tb"
        Me.write_tb.Size = New System.Drawing.Size(200, 20)
        Me.write_tb.TabIndex = 13
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 450)
        Me.Controls.Add(Me.write_lbl)
        Me.Controls.Add(Me.write_tb)
        Me.Controls.Add(Me.read_lbl)
        Me.Controls.Add(Me.read_tb)
        Me.Controls.Add(Me.write_btn)
        Me.Controls.Add(Me.Read_btn)
        Me.Controls.Add(Me.s_lbl)
        Me.Controls.Add(Me.s_tb)
        Me.Controls.Add(Me.ns_lbl)
        Me.Controls.Add(Me.ns_tb)
        Me.Controls.Add(Me.stop_btn)
        Me.Controls.Add(Me.config_btn)
        Me.Controls.Add(Me.IP_lbl)
        Me.Controls.Add(Me.IP_tb)
        Me.Controls.Add(Me.Start_connection_btn)
        Me.Name = "Form1"
        Me.Text = "b"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Start_connection_btn As Windows.Forms.Button
    Friend WithEvents IP_tb As Windows.Forms.TextBox
    Friend WithEvents IP_lbl As Windows.Forms.Label
    Friend WithEvents config_btn As Windows.Forms.Button
    Friend WithEvents stop_btn As Windows.Forms.Button
    Friend WithEvents ns_lbl As Windows.Forms.Label
    Friend WithEvents ns_tb As Windows.Forms.TextBox
    Friend WithEvents s_lbl As Windows.Forms.Label
    Friend WithEvents s_tb As Windows.Forms.TextBox
    Friend WithEvents Read_btn As Windows.Forms.Button
    Friend WithEvents write_btn As Windows.Forms.Button
    Friend WithEvents read_lbl As Windows.Forms.Label
    Friend WithEvents read_tb As Windows.Forms.TextBox
    Friend WithEvents write_lbl As Windows.Forms.Label
    Friend WithEvents write_tb As Windows.Forms.TextBox
End Class
