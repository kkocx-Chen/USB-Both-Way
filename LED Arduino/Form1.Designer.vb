<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
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

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.OvalShape1 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.OvalShape2 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.OvalShape3 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.OvalShape4 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.OvalShape5 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.OvalShape6 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.OvalShape7 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.OvalShape8 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.LED0 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("新細明體", 20.0!)
        Me.Button1.Location = New System.Drawing.Point(451, 450)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(263, 123)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Exit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1
        '
        'SerialPort1
        '
        Me.SerialPort1.BaudRate = 19200
        Me.SerialPort1.PortName = "COM5"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.OvalShape8, Me.OvalShape7, Me.OvalShape6, Me.OvalShape5, Me.OvalShape4, Me.OvalShape3, Me.OvalShape2, Me.OvalShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1180, 709)
        Me.ShapeContainer1.TabIndex = 9
        Me.ShapeContainer1.TabStop = False
        '
        'OvalShape1
        '
        Me.OvalShape1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.OvalShape1.Location = New System.Drawing.Point(145, 186)
        Me.OvalShape1.Name = "OvalShape1"
        Me.OvalShape1.Size = New System.Drawing.Size(55, 54)
        '
        'OvalShape2
        '
        Me.OvalShape2.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.OvalShape2.Location = New System.Drawing.Point(269, 186)
        Me.OvalShape2.Name = "OvalShape2"
        Me.OvalShape2.Size = New System.Drawing.Size(55, 54)
        '
        'OvalShape3
        '
        Me.OvalShape3.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.OvalShape3.Location = New System.Drawing.Point(393, 186)
        Me.OvalShape3.Name = "OvalShape3"
        Me.OvalShape3.Size = New System.Drawing.Size(55, 54)
        '
        'OvalShape4
        '
        Me.OvalShape4.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.OvalShape4.Location = New System.Drawing.Point(517, 186)
        Me.OvalShape4.Name = "OvalShape4"
        Me.OvalShape4.Size = New System.Drawing.Size(55, 54)
        '
        'OvalShape5
        '
        Me.OvalShape5.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.OvalShape5.Location = New System.Drawing.Point(641, 186)
        Me.OvalShape5.Name = "OvalShape5"
        Me.OvalShape5.Size = New System.Drawing.Size(55, 54)
        '
        'OvalShape6
        '
        Me.OvalShape6.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.OvalShape6.Location = New System.Drawing.Point(765, 186)
        Me.OvalShape6.Name = "OvalShape6"
        Me.OvalShape6.Size = New System.Drawing.Size(55, 54)
        '
        'OvalShape7
        '
        Me.OvalShape7.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.OvalShape7.Location = New System.Drawing.Point(889, 186)
        Me.OvalShape7.Name = "OvalShape7"
        Me.OvalShape7.Size = New System.Drawing.Size(55, 54)
        '
        'OvalShape8
        '
        Me.OvalShape8.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.OvalShape8.Location = New System.Drawing.Point(1013, 186)
        Me.OvalShape8.Name = "OvalShape8"
        Me.OvalShape8.Size = New System.Drawing.Size(55, 54)
        '
        'LED0
        '
        Me.LED0.AutoSize = True
        Me.LED0.Font = New System.Drawing.Font("新細明體", 20.0!)
        Me.LED0.Location = New System.Drawing.Point(143, 149)
        Me.LED0.Name = "LED0"
        Me.LED0.Size = New System.Drawing.Size(75, 27)
        Me.LED0.TabIndex = 10
        Me.LED0.Text = "LED0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("新細明體", 20.0!)
        Me.Label2.Location = New System.Drawing.Point(267, 149)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 27)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "LED1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("新細明體", 20.0!)
        Me.Label3.Location = New System.Drawing.Point(391, 149)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 27)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "LED2"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("新細明體", 20.0!)
        Me.Label4.Location = New System.Drawing.Point(515, 149)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 27)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "LED3"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("新細明體", 20.0!)
        Me.Label5.Location = New System.Drawing.Point(639, 149)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 27)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "LED4"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("新細明體", 20.0!)
        Me.Label6.Location = New System.Drawing.Point(763, 149)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 27)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "LED5"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("新細明體", 20.0!)
        Me.Label7.Location = New System.Drawing.Point(887, 149)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 27)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "LED6"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("新細明體", 20.0!)
        Me.Label8.Location = New System.Drawing.Point(1011, 149)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 27)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "LED7"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1180, 709)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LED0)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents OvalShape1 As PowerPacks.OvalShape
    Friend WithEvents OvalShape8 As PowerPacks.OvalShape
    Friend WithEvents OvalShape7 As PowerPacks.OvalShape
    Friend WithEvents OvalShape6 As PowerPacks.OvalShape
    Friend WithEvents OvalShape5 As PowerPacks.OvalShape
    Friend WithEvents OvalShape4 As PowerPacks.OvalShape
    Friend WithEvents OvalShape3 As PowerPacks.OvalShape
    Friend WithEvents OvalShape2 As PowerPacks.OvalShape
    Friend WithEvents LED0 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
End Class
