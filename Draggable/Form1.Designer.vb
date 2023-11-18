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
        Me.components = New System.ComponentModel.Container()
        Dim CBlendItems1 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
        Dim CBlendItems2 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
        Me.PanelContainer = New System.Windows.Forms.Panel()
        Me.btnStart = New CButtonLib.CButton()
        Me.PanelTitleBar = New System.Windows.Forms.Panel()
        Me.btnClose = New CButtonLib.CButton()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.PanelContainer.SuspendLayout()
        Me.PanelTitleBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelContainer
        '
        Me.PanelContainer.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.PanelContainer.Controls.Add(Me.btnStart)
        Me.PanelContainer.Controls.Add(Me.PanelTitleBar)
        Me.PanelContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContainer.Location = New System.Drawing.Point(0, 0)
        Me.PanelContainer.Name = "PanelContainer"
        Me.PanelContainer.Size = New System.Drawing.Size(600, 450)
        Me.PanelContainer.TabIndex = 0
        '
        'btnStart
        '
        Me.btnStart.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnStart.BorderColor = System.Drawing.Color.Black
        CBlendItems1.iColor = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))}
        CBlendItems1.iPoint = New Single() {0!, 0.5!, 1.0!}
        Me.btnStart.ColorFillBlend = CBlendItems1
        Me.btnStart.ColorFillSolid = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnStart.Corners.All = 15
        Me.btnStart.Corners.LowerLeft = 15
        Me.btnStart.Corners.LowerRight = 15
        Me.btnStart.Corners.UpperLeft = 15
        Me.btnStart.Corners.UpperRight = 15
        Me.btnStart.DesignerSelected = True
        Me.btnStart.FillType = CButtonLib.CButton.eFillType.GradientPath
        Me.btnStart.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.ForeColor = System.Drawing.Color.Black
        Me.btnStart.ImageIndex = 0
        Me.btnStart.Location = New System.Drawing.Point(11, 407)
        Me.btnStart.Margin = New System.Windows.Forms.Padding(2)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(72, 32)
        Me.btnStart.TabIndex = 2
        Me.btnStart.Text = "Start"
        Me.btnStart.TextShadow = System.Drawing.Color.Transparent
        '
        'PanelTitleBar
        '
        Me.PanelTitleBar.BackColor = System.Drawing.Color.DarkSlateGray
        Me.PanelTitleBar.Controls.Add(Me.btnClose)
        Me.PanelTitleBar.Controls.Add(Me.lblTitle)
        Me.PanelTitleBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTitleBar.Location = New System.Drawing.Point(0, 0)
        Me.PanelTitleBar.Name = "PanelTitleBar"
        Me.PanelTitleBar.Size = New System.Drawing.Size(600, 50)
        Me.PanelTitleBar.TabIndex = 0
        '
        'btnClose
        '
        Me.btnClose.BorderColor = System.Drawing.Color.Black
        CBlendItems2.iColor = New System.Drawing.Color() {System.Drawing.Color.DarkSlateGray, System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))}
        CBlendItems2.iPoint = New Single() {0!, 0.5!, 1.0!}
        Me.btnClose.ColorFillBlend = CBlendItems2
        Me.btnClose.Corners.All = 15
        Me.btnClose.Corners.LowerLeft = 15
        Me.btnClose.Corners.LowerRight = 15
        Me.btnClose.Corners.UpperLeft = 15
        Me.btnClose.Corners.UpperRight = 15
        Me.btnClose.DesignerSelected = False
        Me.btnClose.FillType = CButtonLib.CButton.eFillType.GradientPath
        Me.btnClose.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Black
        Me.btnClose.ImageIndex = 0
        Me.btnClose.Location = New System.Drawing.Point(515, 9)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(2)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(72, 32)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "Close"
        Me.btnClose.TextShadow = System.Drawing.Color.Transparent
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Malgun Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(18, 16)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(116, 17)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Title and Version"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lime
        Me.ClientSize = New System.Drawing.Size(600, 450)
        Me.Controls.Add(Me.PanelContainer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.PanelContainer.ResumeLayout(False)
        Me.PanelTitleBar.ResumeLayout(False)
        Me.PanelTitleBar.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelContainer As Panel
    Friend WithEvents PanelTitleBar As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnClose As CButtonLib.CButton
    Friend WithEvents btnStart As CButtonLib.CButton
End Class
