Public Class Form1

    Private Sub HandleButtonClick(buttonName As String)
        Select Case buttonName
            Case "Trannsactions"
                ' Code to handle Button1 click
                Panel4.Visible = True
                AddCustomerPnl.Visible = True
                Panel6.Visible = True
                Pawncards.Visible = False


            Case "Pawncards"
                ' Code to handle Button2 click
                Panel4.Visible = False
                AddCustomerPnl.Visible = False
                Panel6.Visible = False
                PanelTransactions.Visible = False

            Case "Button3"
                ' Code to handle Button3 click
                Panel1.Visible = True
                Panel2.Visible = True
                Panel3.Visible = False
            Case Else
                ' Handle other buttons or cases if needed
        End Select
    End Sub




    Private Sub btn_customers_Click(sender As Object, e As EventArgs) Handles btn_customers.Click
        panelOnButtonCst.Height = btn_customers.Height
        panelOnButtonCst.Top = btn_customers.Top




    End Sub

    Private Sub btn_transactions_Click(sender As Object, e As EventArgs) Handles btn_transactions.Click
        panelOnButtonCst.Height = btn_transactions.Height
        panelOnButtonCst.Top = btn_transactions.Top
        HandleButtonClick("Transactions")


        PanelTransactions.Visible = True



    End Sub

    Private Sub buttonItems_Click(sender As Object, e As EventArgs) Handles buttonItems.Click

        panelOnButtonCst.Height = buttonItems.Height

        panelOnButtonCst.Top = buttonItems.Top

    End Sub

    Private Sub btnPawnCards_Click(sender As Object, e As EventArgs) Handles btnPawnCards.Click
        panelOnButtonCst.Height = btnPawnCards.Height
        panelOnButtonCst.Top = btnPawnCards.Top
        HandleButtonClick("Pawncards")


        Pawncards.Visible = True
        Pawncards.Size = PanelTransactions.Size
        Pawncards.Location = PanelTransactions.Location
        Pawncards.Anchor = PanelTransactions.Anchor
        DataGridView2.Rows.Add("2023-04-06", "2023-04-06", "2023-04-06", "1000.00", "Borje", "Ver", "Ring", "Renew")



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
        DataGridView1.Rows.Clear()

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

        jtypebox.Items.Add("Watch")
        jtypebox.Items.Add("Necklace")

        jtypebox.Items.Add("Ring")


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



    Private Sub Confirm_Click(sender As Object, e As EventArgs) Handles Confirm.Click

        Dim str As String

        str = "INSERT INTO pawncards( PawnDate, MaturityDate, ExpiryDate, LoanAmount ) VALUES ('2023-06-06','2023-06-06','2023-06-06','1000.00')"


        Try
            readQuery(str)
            MsgBox("Successfully Added")
            Panel6.Visible = False
            Panel4.Visible = True

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try




    End Sub

    Private Sub dataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
        ' Check if the clicked cell is the button cell and its column index matches the column where you placed the button
        If e.ColumnIndex = DataGridView2.Columns("Column8").Index AndAlso e.RowIndex >= 0 Then
            ' Perform the desired action when the button is clicked
            MessageBox.Show("Button clicked in row " & e.RowIndex.ToString())
            ' You can replace MessageBox.Show with your custom function call or any other action you want to perform
        End If
    End Sub

End Class
