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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.historyTextBox = New System.Windows.Forms.TextBox()
        Me.zeroButton = New System.Windows.Forms.Button()
        Me.plusButton = New System.Windows.Forms.Button()
        Me.threeButton = New System.Windows.Forms.Button()
        Me.twoButton = New System.Windows.Forms.Button()
        Me.oneButton = New System.Windows.Forms.Button()
        Me.minusButton = New System.Windows.Forms.Button()
        Me.sixButton = New System.Windows.Forms.Button()
        Me.fiveButton = New System.Windows.Forms.Button()
        Me.fourButton = New System.Windows.Forms.Button()
        Me.multiplyButton = New System.Windows.Forms.Button()
        Me.nineButton = New System.Windows.Forms.Button()
        Me.eightButton = New System.Windows.Forms.Button()
        Me.divideButton = New System.Windows.Forms.Button()
        Me.clearButton = New System.Windows.Forms.Button()
        Me.clearEntryButton = New System.Windows.Forms.Button()
        Me.backspaceButton = New System.Windows.Forms.Button()
        Me.calculationTextBox = New System.Windows.Forms.TextBox()
        Me.equalButton = New System.Windows.Forms.Button()
        Me.sevenButton = New System.Windows.Forms.Button()
        Me.saveHistoryButton = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.zeroButton, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.plusButton, 3, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.threeButton, 2, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.twoButton, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.oneButton, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.minusButton, 3, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.sixButton, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.fiveButton, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.fourButton, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.multiplyButton, 3, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.nineButton, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.eightButton, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.divideButton, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.clearButton, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.clearEntryButton, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.backspaceButton, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.calculationTextBox, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.equalButton, 2, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.sevenButton, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.historyTextBox, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.saveHistoryButton, 4, 5)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 6
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(364, 409)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'historyTextBox
        '
        Me.historyTextBox.Enabled = False
        Me.historyTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.historyTextBox.Location = New System.Drawing.Point(263, 3)
        Me.historyTextBox.Multiline = True
        Me.historyTextBox.Name = "historyTextBox"
        Me.historyTextBox.ReadOnly = True
        Me.TableLayoutPanel1.SetRowSpan(Me.historyTextBox, 5)
        Me.historyTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.historyTextBox.Size = New System.Drawing.Size(98, 340)
        Me.historyTextBox.TabIndex = 20
        '
        'zeroButton
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.zeroButton, 2)
        Me.zeroButton.Location = New System.Drawing.Point(3, 349)
        Me.zeroButton.Name = "zeroButton"
        Me.zeroButton.Size = New System.Drawing.Size(124, 55)
        Me.zeroButton.TabIndex = 17
        Me.zeroButton.Text = "0"
        Me.zeroButton.UseVisualStyleBackColor = True
        '
        'plusButton
        '
        Me.plusButton.Location = New System.Drawing.Point(198, 288)
        Me.plusButton.Name = "plusButton"
        Me.plusButton.Size = New System.Drawing.Size(59, 55)
        Me.plusButton.TabIndex = 16
        Me.plusButton.Text = "+"
        Me.plusButton.UseVisualStyleBackColor = True
        '
        'threeButton
        '
        Me.threeButton.Location = New System.Drawing.Point(133, 288)
        Me.threeButton.Name = "threeButton"
        Me.threeButton.Size = New System.Drawing.Size(59, 55)
        Me.threeButton.TabIndex = 15
        Me.threeButton.Text = "3"
        Me.threeButton.UseVisualStyleBackColor = True
        '
        'twoButton
        '
        Me.twoButton.Location = New System.Drawing.Point(68, 288)
        Me.twoButton.Name = "twoButton"
        Me.twoButton.Size = New System.Drawing.Size(59, 55)
        Me.twoButton.TabIndex = 14
        Me.twoButton.Text = "2"
        Me.twoButton.UseVisualStyleBackColor = True
        '
        'oneButton
        '
        Me.oneButton.Location = New System.Drawing.Point(3, 288)
        Me.oneButton.Name = "oneButton"
        Me.oneButton.Size = New System.Drawing.Size(59, 55)
        Me.oneButton.TabIndex = 13
        Me.oneButton.Text = "1"
        Me.oneButton.UseVisualStyleBackColor = True
        '
        'minusButton
        '
        Me.minusButton.Location = New System.Drawing.Point(198, 227)
        Me.minusButton.Name = "minusButton"
        Me.minusButton.Size = New System.Drawing.Size(59, 55)
        Me.minusButton.TabIndex = 12
        Me.minusButton.Text = "-"
        Me.minusButton.UseVisualStyleBackColor = True
        '
        'sixButton
        '
        Me.sixButton.Location = New System.Drawing.Point(133, 227)
        Me.sixButton.Name = "sixButton"
        Me.sixButton.Size = New System.Drawing.Size(59, 55)
        Me.sixButton.TabIndex = 11
        Me.sixButton.Text = "6"
        Me.sixButton.UseVisualStyleBackColor = True
        '
        'fiveButton
        '
        Me.fiveButton.Location = New System.Drawing.Point(68, 227)
        Me.fiveButton.Name = "fiveButton"
        Me.fiveButton.Size = New System.Drawing.Size(59, 55)
        Me.fiveButton.TabIndex = 10
        Me.fiveButton.Text = "5"
        Me.fiveButton.UseVisualStyleBackColor = True
        '
        'fourButton
        '
        Me.fourButton.Location = New System.Drawing.Point(3, 227)
        Me.fourButton.Name = "fourButton"
        Me.fourButton.Size = New System.Drawing.Size(59, 55)
        Me.fourButton.TabIndex = 9
        Me.fourButton.Text = "4"
        Me.fourButton.UseVisualStyleBackColor = True
        '
        'multiplyButton
        '
        Me.multiplyButton.Location = New System.Drawing.Point(198, 166)
        Me.multiplyButton.Name = "multiplyButton"
        Me.multiplyButton.Size = New System.Drawing.Size(59, 55)
        Me.multiplyButton.TabIndex = 8
        Me.multiplyButton.Text = "*"
        Me.multiplyButton.UseVisualStyleBackColor = True
        '
        'nineButton
        '
        Me.nineButton.Location = New System.Drawing.Point(133, 166)
        Me.nineButton.Name = "nineButton"
        Me.nineButton.Size = New System.Drawing.Size(59, 55)
        Me.nineButton.TabIndex = 7
        Me.nineButton.Text = "9"
        Me.nineButton.UseVisualStyleBackColor = True
        '
        'eightButton
        '
        Me.eightButton.Location = New System.Drawing.Point(68, 166)
        Me.eightButton.Name = "eightButton"
        Me.eightButton.Size = New System.Drawing.Size(59, 55)
        Me.eightButton.TabIndex = 6
        Me.eightButton.Text = "8"
        Me.eightButton.UseVisualStyleBackColor = True
        '
        'divideButton
        '
        Me.divideButton.Location = New System.Drawing.Point(198, 105)
        Me.divideButton.Name = "divideButton"
        Me.divideButton.Size = New System.Drawing.Size(59, 55)
        Me.divideButton.TabIndex = 5
        Me.divideButton.Text = "/"
        Me.divideButton.UseVisualStyleBackColor = True
        '
        'clearButton
        '
        Me.clearButton.Location = New System.Drawing.Point(133, 105)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(59, 55)
        Me.clearButton.TabIndex = 4
        Me.clearButton.Text = "C"
        Me.clearButton.UseVisualStyleBackColor = True
        '
        'clearEntryButton
        '
        Me.clearEntryButton.Location = New System.Drawing.Point(68, 105)
        Me.clearEntryButton.Name = "clearEntryButton"
        Me.clearEntryButton.Size = New System.Drawing.Size(59, 55)
        Me.clearEntryButton.TabIndex = 3
        Me.clearEntryButton.Text = "CE"
        Me.clearEntryButton.UseVisualStyleBackColor = True
        '
        'backspaceButton
        '
        Me.backspaceButton.Location = New System.Drawing.Point(3, 105)
        Me.backspaceButton.Name = "backspaceButton"
        Me.backspaceButton.Size = New System.Drawing.Size(59, 55)
        Me.backspaceButton.TabIndex = 1
        Me.backspaceButton.Text = "<-"
        Me.backspaceButton.UseVisualStyleBackColor = True
        '
        'calculationTextBox
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.calculationTextBox, 4)
        Me.calculationTextBox.Enabled = False
        Me.calculationTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calculationTextBox.Location = New System.Drawing.Point(3, 3)
        Me.calculationTextBox.Multiline = True
        Me.calculationTextBox.Name = "calculationTextBox"
        Me.calculationTextBox.ReadOnly = True
        Me.calculationTextBox.Size = New System.Drawing.Size(254, 96)
        Me.calculationTextBox.TabIndex = 2
        Me.calculationTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'equalButton
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.equalButton, 2)
        Me.equalButton.Location = New System.Drawing.Point(133, 349)
        Me.equalButton.Name = "equalButton"
        Me.equalButton.Size = New System.Drawing.Size(124, 55)
        Me.equalButton.TabIndex = 18
        Me.equalButton.Text = "="
        Me.equalButton.UseVisualStyleBackColor = True
        '
        'sevenButton
        '
        Me.sevenButton.Location = New System.Drawing.Point(3, 166)
        Me.sevenButton.Name = "sevenButton"
        Me.sevenButton.Size = New System.Drawing.Size(59, 55)
        Me.sevenButton.TabIndex = 0
        Me.sevenButton.Text = "7"
        Me.sevenButton.UseVisualStyleBackColor = True
        '
        'saveHistoryButton
        '
        Me.saveHistoryButton.Location = New System.Drawing.Point(263, 349)
        Me.saveHistoryButton.Name = "saveHistoryButton"
        Me.saveHistoryButton.Size = New System.Drawing.Size(98, 55)
        Me.saveHistoryButton.TabIndex = 21
        Me.saveHistoryButton.Text = "Save History"
        Me.saveHistoryButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(364, 409)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Calculator"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents zeroButton As Button
    Friend WithEvents plusButton As Button
    Friend WithEvents threeButton As Button
    Friend WithEvents twoButton As Button
    Friend WithEvents oneButton As Button
    Friend WithEvents minusButton As Button
    Friend WithEvents sixButton As Button
    Friend WithEvents fiveButton As Button
    Friend WithEvents fourButton As Button
    Friend WithEvents multiplyButton As Button
    Friend WithEvents nineButton As Button
    Friend WithEvents eightButton As Button
    Friend WithEvents divideButton As Button
    Friend WithEvents clearButton As Button
    Friend WithEvents clearEntryButton As Button
    Friend WithEvents sevenButton As Button
    Friend WithEvents backspaceButton As Button
    Friend WithEvents calculationTextBox As TextBox
    Friend WithEvents equalButton As Button
    Friend WithEvents historyTextBox As TextBox
    Friend WithEvents saveHistoryButton As Button
End Class
