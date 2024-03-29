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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.panel_left = New System.Windows.Forms.Panel()
        Me.panelOnButtonCst = New System.Windows.Forms.Panel()
        Me.btnAuctions = New System.Windows.Forms.Button()
        Me.btnTransactRec = New System.Windows.Forms.Button()
        Me.btnPawnCards = New System.Windows.Forms.Button()
        Me.btn_customers = New System.Windows.Forms.Button()
        Me.buttonItems = New System.Windows.Forms.Button()
        Me.btn_transactions = New System.Windows.Forms.Button()
        Me.panelUp = New System.Windows.Forms.Panel()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.PanelTransactions = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PanelPay = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PanelPawn = New System.Windows.Forms.Panel()
        Me.Pawn = New System.Windows.Forms.Label()
        Me.btn_pawn = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.panel_left.SuspendLayout()
        Me.PanelTransactions.SuspendLayout()
        Me.PanelPay.SuspendLayout()
        Me.PanelPawn.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'panel_left
        '
        Me.panel_left.BackColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.panel_left.Controls.Add(Me.Panel2)
        Me.panel_left.Controls.Add(Me.panelOnButtonCst)
        Me.panel_left.Controls.Add(Me.btnAuctions)
        Me.panel_left.Controls.Add(Me.btnTransactRec)
        Me.panel_left.Controls.Add(Me.btnPawnCards)
        Me.panel_left.Controls.Add(Me.btn_customers)
        Me.panel_left.Controls.Add(Me.buttonItems)
        Me.panel_left.Controls.Add(Me.btn_transactions)
        Me.panel_left.Dock = System.Windows.Forms.DockStyle.Left
        Me.panel_left.Location = New System.Drawing.Point(0, 0)
        Me.panel_left.Name = "panel_left"
        Me.panel_left.Size = New System.Drawing.Size(200, 498)
        Me.panel_left.TabIndex = 0
        '
        'panelOnButtonCst
        '
        Me.panelOnButtonCst.BackColor = System.Drawing.Color.Gold
        Me.panelOnButtonCst.Location = New System.Drawing.Point(0, 121)
        Me.panelOnButtonCst.Name = "panelOnButtonCst"
        Me.panelOnButtonCst.Size = New System.Drawing.Size(10, 42)
        Me.panelOnButtonCst.TabIndex = 2
        '
        'btnAuctions
        '
        Me.btnAuctions.FlatAppearance.BorderSize = 0
        Me.btnAuctions.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAuctions.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAuctions.ForeColor = System.Drawing.SystemColors.Control
        Me.btnAuctions.Image = CType(resources.GetObject("btnAuctions.Image"), System.Drawing.Image)
        Me.btnAuctions.Location = New System.Drawing.Point(0, 361)
        Me.btnAuctions.Name = "btnAuctions"
        Me.btnAuctions.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.btnAuctions.Size = New System.Drawing.Size(200, 43)
        Me.btnAuctions.TabIndex = 11
        Me.btnAuctions.Text = "   Auction"
        Me.btnAuctions.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAuctions.UseVisualStyleBackColor = True
        '
        'btnTransactRec
        '
        Me.btnTransactRec.FlatAppearance.BorderSize = 0
        Me.btnTransactRec.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTransactRec.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTransactRec.ForeColor = System.Drawing.SystemColors.Control
        Me.btnTransactRec.Image = CType(resources.GetObject("btnTransactRec.Image"), System.Drawing.Image)
        Me.btnTransactRec.Location = New System.Drawing.Point(0, 313)
        Me.btnTransactRec.Name = "btnTransactRec"
        Me.btnTransactRec.Padding = New System.Windows.Forms.Padding(12, 0, 0, 0)
        Me.btnTransactRec.Size = New System.Drawing.Size(200, 43)
        Me.btnTransactRec.TabIndex = 9
        Me.btnTransactRec.Text = "    Payments"
        Me.btnTransactRec.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnTransactRec.UseVisualStyleBackColor = True
        '
        'btnPawnCards
        '
        Me.btnPawnCards.FlatAppearance.BorderSize = 0
        Me.btnPawnCards.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPawnCards.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPawnCards.ForeColor = System.Drawing.SystemColors.Control
        Me.btnPawnCards.Image = CType(resources.GetObject("btnPawnCards.Image"), System.Drawing.Image)
        Me.btnPawnCards.Location = New System.Drawing.Point(0, 265)
        Me.btnPawnCards.Name = "btnPawnCards"
        Me.btnPawnCards.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.btnPawnCards.Size = New System.Drawing.Size(200, 43)
        Me.btnPawnCards.TabIndex = 7
        Me.btnPawnCards.Text = "    Pawn Cards"
        Me.btnPawnCards.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPawnCards.UseVisualStyleBackColor = True
        '
        'btn_customers
        '
        Me.btn_customers.FlatAppearance.BorderSize = 0
        Me.btn_customers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_customers.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_customers.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_customers.Image = CType(resources.GetObject("btn_customers.Image"), System.Drawing.Image)
        Me.btn_customers.Location = New System.Drawing.Point(0, 169)
        Me.btn_customers.Name = "btn_customers"
        Me.btn_customers.Padding = New System.Windows.Forms.Padding(11, 0, 0, 0)
        Me.btn_customers.Size = New System.Drawing.Size(200, 43)
        Me.btn_customers.TabIndex = 5
        Me.btn_customers.Text = "    Customers"
        Me.btn_customers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_customers.UseVisualStyleBackColor = True
        '
        'buttonItems
        '
        Me.buttonItems.FlatAppearance.BorderSize = 0
        Me.buttonItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buttonItems.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonItems.ForeColor = System.Drawing.SystemColors.Control
        Me.buttonItems.Image = CType(resources.GetObject("buttonItems.Image"), System.Drawing.Image)
        Me.buttonItems.Location = New System.Drawing.Point(0, 217)
        Me.buttonItems.Name = "buttonItems"
        Me.buttonItems.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.buttonItems.Size = New System.Drawing.Size(200, 43)
        Me.buttonItems.TabIndex = 3
        Me.buttonItems.Text = "       Items"
        Me.buttonItems.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.buttonItems.UseVisualStyleBackColor = True
        '
        'btn_transactions
        '
        Me.btn_transactions.FlatAppearance.BorderSize = 0
        Me.btn_transactions.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_transactions.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_transactions.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_transactions.Image = CType(resources.GetObject("btn_transactions.Image"), System.Drawing.Image)
        Me.btn_transactions.Location = New System.Drawing.Point(0, 121)
        Me.btn_transactions.Name = "btn_transactions"
        Me.btn_transactions.Padding = New System.Windows.Forms.Padding(9, 0, 0, 0)
        Me.btn_transactions.Size = New System.Drawing.Size(200, 43)
        Me.btn_transactions.TabIndex = 0
        Me.btn_transactions.Text = "    Transact"
        Me.btn_transactions.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_transactions.UseVisualStyleBackColor = True
        '
        'panelUp
        '
        Me.panelUp.BackColor = System.Drawing.Color.Gold
        Me.panelUp.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelUp.Location = New System.Drawing.Point(200, 0)
        Me.panelUp.Name = "panelUp"
        Me.panelUp.Size = New System.Drawing.Size(683, 23)
        Me.panelUp.TabIndex = 1
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'PanelTransactions
        '
        Me.PanelTransactions.Controls.Add(Me.Panel1)
        Me.PanelTransactions.Controls.Add(Me.Label3)
        Me.PanelTransactions.Controls.Add(Me.Label2)
        Me.PanelTransactions.Controls.Add(Me.PanelPay)
        Me.PanelTransactions.Controls.Add(Me.PanelPawn)
        Me.PanelTransactions.Location = New System.Drawing.Point(200, 22)
        Me.PanelTransactions.Name = "PanelTransactions"
        Me.PanelTransactions.Size = New System.Drawing.Size(683, 476)
        Me.PanelTransactions.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Panel1.Location = New System.Drawing.Point(182, 16)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(66, 72)
        Me.Panel1.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(298, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Pawnshop and Jewelry"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(245, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(247, 42)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "ORDINARIO "
        '
        'PanelPay
        '
        Me.PanelPay.Controls.Add(Me.Label1)
        Me.PanelPay.Controls.Add(Me.Button1)
        Me.PanelPay.Location = New System.Drawing.Point(389, 126)
        Me.PanelPay.Name = "PanelPay"
        Me.PanelPay.Size = New System.Drawing.Size(174, 175)
        Me.PanelPay.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Myriad Pro Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(76, 141)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Pay"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Gold
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(7, 6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(160, 125)
        Me.Button1.TabIndex = 0
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PanelPawn
        '
        Me.PanelPawn.Controls.Add(Me.Pawn)
        Me.PanelPawn.Controls.Add(Me.btn_pawn)
        Me.PanelPawn.Location = New System.Drawing.Point(103, 126)
        Me.PanelPawn.Name = "PanelPawn"
        Me.PanelPawn.Size = New System.Drawing.Size(174, 175)
        Me.PanelPawn.TabIndex = 0
        '
        'Pawn
        '
        Me.Pawn.AutoSize = True
        Me.Pawn.Font = New System.Drawing.Font("Myriad Pro Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pawn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Pawn.Location = New System.Drawing.Point(65, 141)
        Me.Pawn.Name = "Pawn"
        Me.Pawn.Size = New System.Drawing.Size(36, 19)
        Me.Pawn.TabIndex = 1
        Me.Pawn.Text = "Pawn"
        '
        'btn_pawn
        '
        Me.btn_pawn.BackColor = System.Drawing.Color.Brown
        Me.btn_pawn.BackgroundImage = CType(resources.GetObject("btn_pawn.BackgroundImage"), System.Drawing.Image)
        Me.btn_pawn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_pawn.FlatAppearance.BorderSize = 0
        Me.btn_pawn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_pawn.Location = New System.Drawing.Point(7, 6)
        Me.btn_pawn.Name = "btn_pawn"
        Me.btn_pawn.Size = New System.Drawing.Size(160, 125)
        Me.btn_pawn.TabIndex = 0
        Me.btn_pawn.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Location = New System.Drawing.Point(-8, 22)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 100)
        Me.Panel2.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Gold
        Me.Label4.Location = New System.Drawing.Point(63, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 24)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "ORDINARIO"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Gold
        Me.Label5.Location = New System.Drawing.Point(64, 62)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(116, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Pawnshop and Jewelry"
        '
        'Panel3
        '
        Me.Panel3.BackgroundImage = CType(resources.GetObject("Panel3.BackgroundImage"), System.Drawing.Image)
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Panel3.Location = New System.Drawing.Point(16, 27)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(59, 59)
        Me.Panel3.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(883, 498)
        Me.Controls.Add(Me.PanelTransactions)
        Me.Controls.Add(Me.panelUp)
        Me.Controls.Add(Me.panel_left)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.panel_left.ResumeLayout(False)
        Me.PanelTransactions.ResumeLayout(False)
        Me.PanelTransactions.PerformLayout()
        Me.PanelPay.ResumeLayout(False)
        Me.PanelPay.PerformLayout()
        Me.PanelPawn.ResumeLayout(False)
        Me.PanelPawn.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panel_left As Panel
    Friend WithEvents btn_transactions As Button
    Friend WithEvents panelUp As Panel
    Friend WithEvents panelOnButtonCst As Panel
    Friend WithEvents btnAuctions As Button
    Friend WithEvents btnTransactRec As Button
    Friend WithEvents btnPawnCards As Button
    Friend WithEvents btn_customers As Button
    Friend WithEvents buttonItems As Button
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents PanelTransactions As Panel
    Friend WithEvents PanelPawn As Panel
    Friend WithEvents Pawn As Label
    Friend WithEvents btn_pawn As Button
    Friend WithEvents PanelPay As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
End Class
