Public Class Form1




    Private Sub btn_customers_Click(sender As Object, e As EventArgs) Handles btn_customers.Click
        panelOnButtonCst.Height = btn_customers.Height
        panelOnButtonCst.Top = btn_customers.Top




    End Sub

    Private Sub btn_transactions_Click(sender As Object, e As EventArgs) Handles btn_transactions.Click
        panelOnButtonCst.Height = btn_transactions.Height
        panelOnButtonCst.Top = btn_transactions.Top

    End Sub

    Private Sub buttonItems_Click(sender As Object, e As EventArgs) Handles buttonItems.Click

        panelOnButtonCst.Height = buttonItems.Height

        panelOnButtonCst.Top = buttonItems.Top

    End Sub

    Private Sub btnPawnCards_Click(sender As Object, e As EventArgs) Handles btnPawnCards.Click
        panelOnButtonCst.Height = btnPawnCards.Height
        panelOnButtonCst.Top = btnPawnCards.Top
    End Sub

    Private Sub btnTransactRec_Click(sender As Object, e As EventArgs) Handles btnTransactRec.Click
        panelOnButtonCst.Height = btnTransactRec.Height
        panelOnButtonCst.Top = btnTransactRec.Top
    End Sub

    Private Sub btnAuctions_Click(sender As Object, e As EventArgs) Handles btnAuctions.Click
        panelOnButtonCst.Height = btnAuctions.Height
        panelOnButtonCst.Top = btnAuctions.Top
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub btn_pawn_Click(sender As Object, e As EventArgs) Handles btn_pawn.Click
        Panel4.Size = PanelTransactions.Size
        Panel4.Visible = True
        DataGridView1.Rows.Add("Ver", "Borje", "09380422897", "Pamorangon")

        PanelTransactions.Visible = False





    End Sub

    Private Sub AddCust_Click(sender As Object, e As EventArgs) Handles AddCust.Click
        Panel4.Visible = False
        AddCustomerPnl.Visible = True
    End Sub

    Private Sub DataGridView1_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.RowHeaderMouseClick
        ' Get the index of the clicked row
        Dim rowIndex As Integer = e.RowIndex

        ' Access the data in the clicked row
        Dim value1 As String = DataGridView1.Rows(rowIndex).Cells("Column1").Value.ToString()
        Dim value2 As String = DataGridView1.Rows(rowIndex).Cells("Column2").Value.ToString()
        Dim value3 As String = DataGridView1.Rows(rowIndex).Cells("Column3").Value.ToString()

        Dim value4 As String = DataGridView1.Rows(rowIndex).Cells("Column4").Value.ToString()



        ' Perform actions with the data, for example, display it in a MessageBox


        Panel6.Visible = True
        Panel6.Size = PanelTransactions.Size
        Panel6.Location = PanelTransactions.Location
        Panel6.Anchor = PanelTransactions.Anchor




        AddCustomerPnl.Visible = False

        Panel4.Visible = False

        Nfnametbox.Text = value1
        Nlnametbox.Text = value2
        Ncontacttbox.Text = value3
        Naddresstbox.Text = value4

    End Sub

    Private Sub addcustbtn_Click(sender As Object, e As EventArgs) Handles addcustbtn.Click

        Dim str As String

        str = "INSERT INTO customers( CustFname, CustLname, CustContact,CustAddress ) VALUES ('" & fnameTbox.Text & "','" & lnameTbox.Text & "','" & contactTbox.Text & "','" & addressTbox.Text & "')"


        Try
            readQuery(str)
            MsgBox("Successfully Added")
            AddCustomerPnl.Visible = False
            Panel4.Visible = True

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
End Class
