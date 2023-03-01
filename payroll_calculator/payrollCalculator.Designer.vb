<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class payrollCalculator
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(payrollCalculator))
        Me.picPayroll = New System.Windows.Forms.PictureBox()
        Me.lblPayroll = New System.Windows.Forms.Label()
        Me.lblPaycheck = New System.Windows.Forms.Label()
        Me.lblCalculator = New System.Windows.Forms.Label()
        Me.lblGrossPay = New System.Windows.Forms.Label()
        Me.btnTaxes = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblFica = New System.Windows.Forms.Label()
        Me.lblFederalTax = New System.Windows.Forms.Label()
        Me.lblStateTax = New System.Windows.Forms.Label()
        Me.lblNetPay = New System.Windows.Forms.Label()
        Me.lblFicatxt = New System.Windows.Forms.Label()
        Me.lblFtax = New System.Windows.Forms.Label()
        Me.lblStax = New System.Windows.Forms.Label()
        Me.txtNetIncome = New System.Windows.Forms.TextBox()
        Me.txtPay = New System.Windows.Forms.TextBox()
        CType(Me.picPayroll, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picPayroll
        '
        Me.picPayroll.Image = CType(resources.GetObject("picPayroll.Image"), System.Drawing.Image)
        Me.picPayroll.Location = New System.Drawing.Point(0, -1)
        Me.picPayroll.Name = "picPayroll"
        Me.picPayroll.Size = New System.Drawing.Size(350, 224)
        Me.picPayroll.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPayroll.TabIndex = 0
        Me.picPayroll.TabStop = False
        '
        'lblPayroll
        '
        Me.lblPayroll.AutoSize = True
        Me.lblPayroll.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPayroll.Location = New System.Drawing.Point(386, 9)
        Me.lblPayroll.Name = "lblPayroll"
        Me.lblPayroll.Size = New System.Drawing.Size(245, 31)
        Me.lblPayroll.TabIndex = 1
        Me.lblPayroll.Text = "Payroll Calculator"
        '
        'lblPaycheck
        '
        Me.lblPaycheck.AutoSize = True
        Me.lblPaycheck.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPaycheck.Location = New System.Drawing.Point(452, 95)
        Me.lblPaycheck.Name = "lblPaycheck"
        Me.lblPaycheck.Size = New System.Drawing.Size(114, 25)
        Me.lblPaycheck.TabIndex = 2
        Me.lblPaycheck.Text = "Paycheck"
        '
        'lblCalculator
        '
        Me.lblCalculator.AutoSize = True
        Me.lblCalculator.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCalculator.Location = New System.Drawing.Point(444, 135)
        Me.lblCalculator.Name = "lblCalculator"
        Me.lblCalculator.Size = New System.Drawing.Size(130, 25)
        Me.lblCalculator.TabIndex = 3
        Me.lblCalculator.Text = "Calculation"
        '
        'lblGrossPay
        '
        Me.lblGrossPay.AutoSize = True
        Me.lblGrossPay.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrossPay.Location = New System.Drawing.Point(230, 257)
        Me.lblGrossPay.Name = "lblGrossPay"
        Me.lblGrossPay.Size = New System.Drawing.Size(166, 24)
        Me.lblGrossPay.TabIndex = 4
        Me.lblGrossPay.Text = "Enter Gross Pay:"
        '
        'btnTaxes
        '
        Me.btnTaxes.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnTaxes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTaxes.ForeColor = System.Drawing.Color.White
        Me.btnTaxes.Location = New System.Drawing.Point(80, 319)
        Me.btnTaxes.Name = "btnTaxes"
        Me.btnTaxes.Size = New System.Drawing.Size(141, 38)
        Me.btnTaxes.TabIndex = 6
        Me.btnTaxes.Text = "Compute Taxes"
        Me.btnTaxes.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Location = New System.Drawing.Point(272, 319)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(141, 38)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.Location = New System.Drawing.Point(464, 319)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(141, 38)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'lblFica
        '
        Me.lblFica.AutoSize = True
        Me.lblFica.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFica.Location = New System.Drawing.Point(88, 390)
        Me.lblFica.Name = "lblFica"
        Me.lblFica.Size = New System.Drawing.Size(49, 16)
        Me.lblFica.TabIndex = 9
        Me.lblFica.Text = "FICA: "
        '
        'lblFederalTax
        '
        Me.lblFederalTax.AutoSize = True
        Me.lblFederalTax.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFederalTax.Location = New System.Drawing.Point(250, 390)
        Me.lblFederalTax.Name = "lblFederalTax"
        Me.lblFederalTax.Size = New System.Drawing.Size(100, 16)
        Me.lblFederalTax.TabIndex = 10
        Me.lblFederalTax.Text = "Federal Tax: "
        '
        'lblStateTax
        '
        Me.lblStateTax.AutoSize = True
        Me.lblStateTax.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStateTax.Location = New System.Drawing.Point(461, 390)
        Me.lblStateTax.Name = "lblStateTax"
        Me.lblStateTax.Size = New System.Drawing.Size(82, 16)
        Me.lblStateTax.TabIndex = 11
        Me.lblStateTax.Text = "State Tax: "
        '
        'lblNetPay
        '
        Me.lblNetPay.AutoSize = True
        Me.lblNetPay.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNetPay.Location = New System.Drawing.Point(140, 452)
        Me.lblNetPay.Name = "lblNetPay"
        Me.lblNetPay.Size = New System.Drawing.Size(219, 24)
        Me.lblNetPay.TabIndex = 15
        Me.lblNetPay.Text = "Net Paycheck Income:"
        '
        'lblFicatxt
        '
        Me.lblFicatxt.AutoSize = True
        Me.lblFicatxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFicatxt.Location = New System.Drawing.Point(154, 390)
        Me.lblFicatxt.Name = "lblFicatxt"
        Me.lblFicatxt.Size = New System.Drawing.Size(32, 16)
        Me.lblFicatxt.TabIndex = 18
        Me.lblFicatxt.Text = "123"
        '
        'lblFtax
        '
        Me.lblFtax.AutoSize = True
        Me.lblFtax.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFtax.Location = New System.Drawing.Point(357, 390)
        Me.lblFtax.Name = "lblFtax"
        Me.lblFtax.Size = New System.Drawing.Size(32, 16)
        Me.lblFtax.TabIndex = 19
        Me.lblFtax.Text = "456"
        '
        'lblStax
        '
        Me.lblStax.AutoSize = True
        Me.lblStax.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStax.Location = New System.Drawing.Point(566, 390)
        Me.lblStax.Name = "lblStax"
        Me.lblStax.Size = New System.Drawing.Size(32, 16)
        Me.lblStax.TabIndex = 20
        Me.lblStax.Text = "789"
        '
        'txtNetIncome
        '
        Me.txtNetIncome.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNetIncome.Location = New System.Drawing.Point(392, 452)
        Me.txtNetIncome.Name = "txtNetIncome"
        Me.txtNetIncome.Size = New System.Drawing.Size(110, 26)
        Me.txtNetIncome.TabIndex = 16
        Me.txtNetIncome.Text = "$12345.67"
        Me.txtNetIncome.Visible = False
        '
        'txtPay
        '
        Me.txtPay.Location = New System.Drawing.Point(429, 257)
        Me.txtPay.Name = "txtPay"
        Me.txtPay.Size = New System.Drawing.Size(100, 20)
        Me.txtPay.TabIndex = 21
        '
        'payrollCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 511)
        Me.Controls.Add(Me.txtPay)
        Me.Controls.Add(Me.lblStax)
        Me.Controls.Add(Me.lblFtax)
        Me.Controls.Add(Me.lblFicatxt)
        Me.Controls.Add(Me.txtNetIncome)
        Me.Controls.Add(Me.lblNetPay)
        Me.Controls.Add(Me.lblStateTax)
        Me.Controls.Add(Me.lblFederalTax)
        Me.Controls.Add(Me.lblFica)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnTaxes)
        Me.Controls.Add(Me.lblGrossPay)
        Me.Controls.Add(Me.lblCalculator)
        Me.Controls.Add(Me.lblPaycheck)
        Me.Controls.Add(Me.lblPayroll)
        Me.Controls.Add(Me.picPayroll)
        Me.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.Name = "payrollCalculator"
        Me.Text = "Payroll Every Two Weeks"
        CType(Me.picPayroll, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picPayroll As PictureBox
    Friend WithEvents lblPayroll As Label
    Friend WithEvents lblPaycheck As Label
    Friend WithEvents lblCalculator As Label
    Friend WithEvents lblGrossPay As Label
    Friend WithEvents btnTaxes As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblFica As Label
    Friend WithEvents lblFederalTax As Label
    Friend WithEvents lblStateTax As Label
    Friend WithEvents lblNetPay As Label
    Friend WithEvents lblFicatxt As Label
    Friend WithEvents lblFtax As Label
    Friend WithEvents lblStax As Label
    Friend WithEvents txtNetIncome As TextBox
    Friend WithEvents txtPay As TextBox
End Class
