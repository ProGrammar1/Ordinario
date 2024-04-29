Imports System.Runtime.InteropServices
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1

    Dim total_amntvar As Double

    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(hWnd As IntPtr, wMsg As Integer, wParam As Integer, lParam As Integer)
    End Sub
    Private Sub HandleButtonClick(buttonName As String)
        Select Case buttonName
            Case "Transactions"
                ' Code to handle Button1 click
                Panel4.Visible = True
                AddCustomerPnl.Visible = False
                Panel6.Visible = True
                Pawncards.Visible = False
                renewal_panel.Visible = False
                Pay.Visible = False
                paytransact.Visible = False


            Case "Pawncards"
                ' Code to handle Button2 click
                Panel4.Visible = False
                AddCustomerPnl.Visible = False
                Panel6.Visible = False
                PanelTransactions.Visible = False
                renewal_panel.Visible -= True
                Pay.Visible = False

            Case "Customers"
                ' Code to handle Button3 click
                Panel4.Visible = False
                AddCustomerPnl.Visible = False
                Panel6.Visible = False
                PanelTransactions.Visible = False
                renewal_panel.Visible = False
                Pay.Visible = False
                Pawncards.Visible = False
                paytransact.Visible = False

                CustPanel.Visible = True

            Case "Payments"
                Panel4.Visible = False
                AddCustomerPnl.Visible = False
                Panel6.Visible = False
                PanelTransactions.Visible = False
                renewal_panel.Visible = False
                Pay.Visible = False
                Pawncards.Visible = False
                paytransact.Visible = False

                CustPanel.Visible = False
                ItemsPanel.Visible = False
                AuctionItems.Visible = False
                payemnts.Visible = True

            Case "Auction"
                Panel4.Visible = False
                AddCustomerPnl.Visible = False
                Panel6.Visible = False
                PanelTransactions.Visible = False
                renewal_panel.Visible = False
                Pay.Visible = False
                Pawncards.Visible = False
                paytransact.Visible = False

                CustPanel.Visible = False
                ItemsPanel.Visible = False
                AuctionItems.Visible = True
                payemnts.Visible = False


            Case "Items"
                Panel4.Visible = False
                AddCustomerPnl.Visible = False
                Panel6.Visible = False
                PanelTransactions.Visible = False
                renewal_panel.Visible = False
                Pay.Visible = False
                Pawncards.Visible = False
                paytransact.Visible = False

                CustPanel.Visible = False
                ItemsPanel.Visible = True
                AuctionItems.Visible = False
                payemnts.Visible = False










            Case Else
                ' Handle other buttons or cases if needed
        End Select
    End Sub



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set the default value of DateTimePicker to be four months in advance
        Panel4.Visible = False
        AddCustomerPnl.Visible = False
        Panel6.Visible = False
        Pawncards.Visible = False
        renewal_panel.Visible = False
        Pay.Visible = False
        paytransact.Visible = False
        ItemsPanel.Visible = False
        AuctionItems.Visible = False
        payemnts.Visible = False
        PanelTransactions.Visible = True



    End Sub
    Private Sub btn_customers_Click(sender As Object, e As EventArgs) Handles btn_customers.Click
        HandleButtonClick("Customers")
        panelOnButtonCst.Height = btn_customers.Height
        panelOnButtonCst.Top = btn_customers.Top

        DataGridView4.Rows.Clear()

        Dim customer_data As String = "Select CustFname, CustLname, CustContact, CustAddress from customers"


        readQuery(customer_data)
        With cmdRead
            While .Read
                DataGridView4.Rows.Add(.GetValue(0), .GetValue(1), .GetValue(2), .GetValue(3), "Edit", "Delete")
            End While
        End With






    End Sub

    Private Sub btn_transactions_Click(sender As Object, e As EventArgs) Handles btn_transactions.Click
        panelOnButtonCst.Height = btn_transactions.Height
        panelOnButtonCst.Top = btn_transactions.Top
        AddCustomerPnl.Visible = False
        Pay.Visible = False



        PanelTransactions.Visible = True
        HandleButtonClick("Transactions")



    End Sub

    Private Sub buttonItems_Click(sender As Object, e As EventArgs) Handles buttonItems.Click
        HandleButtonClick("Items")

        panelOnButtonCst.Height = buttonItems.Height

        panelOnButtonCst.Top = buttonItems.Top
        DataGridView5.Rows.Clear()

        Dim itemquery As String = "select ItemName, ItemTypeName, Status from item, itemtypes where ItemType = ItemTypeID "

        Try
            readQuery(itemquery)
            With cmdRead
                While .Read
                    DataGridView5.Rows.Add(.GetValue(0), .GetValue(1), .GetValue(2))

                End While
            End With

        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnPawnCards_Click(sender As Object, e As EventArgs) Handles btnPawnCards.Click
        panelOnButtonCst.Height = btnPawnCards.Height
        panelOnButtonCst.Top = btnPawnCards.Top
        HandleButtonClick("Pawncards")


        Pawncards.Visible = True
        Pawncards.Size = PanelTransactions.Size
        Pawncards.Location = PanelTransactions.Location
        Pawncards.Anchor = PanelTransactions.Anchor
        DataGridView2.Rows.Clear()
        ItemTypeSearchbox.Text = ""
        ItemTypeSearchbox.Items.Clear()

        Dim itemtypeload As String = "Select ItemTypeName from itemtypes"
        Dim pcardload As String = "Select PawnDate, MaturityDate, ExpiryDate, LoanAmount, Balance, CustLname, CustFname, ItemName, ItemTypeName from pawncards,customers, item, itemtypes where Cnum = CustID and ItemID = Itemnum  and ItemType = ItemTypeID and Status = 'Active'"

        Try
            readQuery(itemtypeload)

            With cmdRead
                While .Read
                    ItemTypeSearchbox.Items.Add(.GetValue(0))
                End While
            End With

            readQuery(pcardload)

            With cmdRead
                While .Read
                    DataGridView2.Rows.Add(.GetValue(0), .GetValue(1), .GetValue(2), .GetValue(3), .GetValue(4), .GetValue(5), .GetValue(6), .GetValue(7), .GetValue(8), "Renew", "Auction")
                End While
            End With

        Catch ex As Exception

        End Try



    End Sub

    Private Sub btnTransactRec_Click(sender As Object, e As EventArgs) Handles btnTransactRec.Click
        HandleButtonClick("Payments")

        panelOnButtonCst.Height = btnTransactRec.Height
        panelOnButtonCst.Top = btnTransactRec.Top
        DataGridView6.Rows.Clear()

        Dim records As String = "SELECT customers.CustFname,customers.CustLname, item.ItemName, itemtypes.ItemTypeName, transactions.T_amount,transactions.T_Date from customers,item,itemtypes,transactions where Cno=customers.CustID and Itemno = ItemID 
            and ItemType = ItemTypeID "

        Try
            readQuery(records)
            With cmdRead
                While .Read
                    DataGridView6.Rows.Add(.GetValue(0), .GetValue(1), .GetValue(2), .GetValue(3), .GetValue(4), .GetValue(5))

                End While
            End With

        Catch ex As Exception

        End Try




    End Sub

    Private Sub btnAuctions_Click(sender As Object, e As EventArgs) Handles btnAuctions.Click
        panelOnButtonCst.Height = btnAuctions.Height
        panelOnButtonCst.Top = btnAuctions.Top
        HandleButtonClick("Auction")

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub btn_pawn_Click(sender As Object, e As EventArgs) Handles btn_pawn.Click
        Panel4.Size = PanelTransactions.Size
        Panel4.Anchor = PanelTransactions.Anchor
        Panel4.Location = PanelTransactions.Location

        Panel4.Visible = True
        DataGridView1.Rows.Clear()

        Dim customer_data As String = "Select CustFname, CustLname, CustContact, CustAddress from customers"


        readQuery(customer_data)
        With cmdRead
            While .Read
                DataGridView1.Rows.Add(.GetValue(0), .GetValue(1), .GetValue(2), .GetValue(3))
            End While
        End With


        PanelTransactions.Visible = False





    End Sub

    Private Sub AddCust_Click(sender As Object, e As EventArgs)

        CustPanel.Visible = False
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


        Dim itemtypes As String = "Select ItemTypeName from itemtypes"

        Try
            readQuery(itemtypes)
            With cmdRead
                While .Read
                    jtypebox.Items.Add(.GetValue(0))
                End While
            End With
        Catch ex As Exception

        End Try
        DateTimematurity.Value = DateTime.Now.AddMonths(1)
        DateTimeexpiry.Value = DateTime.Now.AddMonths(4)

        interestRate.Text = "0.03"


    End Sub

    Private Sub addcustbtn_Click(sender As Object, e As EventArgs) Handles addcustbtn.Click

        Dim str As String

        str = "INSERT INTO customers( CustFname, CustLname, CustContact,CustAddress ) VALUES ('" & fnameTbox.Text & "','" & lnameTbox.Text & "','" & contactTbox.Text & "','" & addressTbox.Text & "')"


        Try
            readQuery(str)
            MsgBox("Successfully Added")
            AddCustomerPnl.Visible = False
            DataGridView1.Rows.Clear()

            Dim customer_data As String = "Select CustFname, CustLname, CustContact, CustAddress from customers"


            readQuery(customer_data)
            With cmdRead
                While .Read
                    DataGridView1.Rows.Add(.GetValue(0), .GetValue(1), .GetValue(2), .GetValue(3))
                End While
            End With
            Panel4.Visible = True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try


    End Sub



    Private Sub Confirm_Click(sender As Object, e As EventArgs) Handles Confirm.Click

        Dim str As String

        Dim itmInsrt As String

        Dim pawndate As String = DateTimeloan.Value.ToString("yyyy-MM-dd")
        Dim mdate As String = DateTimematurity.Value.ToString("yyyy-MM-dd")

        Dim Edate As String = DateTimeexpiry.Value.ToString("yyyy-MM-dd")


        Dim itemID As String
        Dim custID As String

        Dim itemtypeidQuery As String = "select ItemTypeID from itemtypes where ItemTypeName = '" & jtypebox.Text & "'"
        Dim itemtypeid As String

        Try
            readQuery(itemtypeidQuery)
            With cmdRead
                While .Read
                    itemtypeid = .GetValue(0)
                End While
            End With
        Catch ex As Exception

        End Try

        itmInsrt = "insert into item(ItemName, ItemValue, ItemType ) values ('" & jewelryname.Text & "' ,'n/a', '" & itemtypeid & "' )"




        Try
            readQuery(itmInsrt)



            Dim itmIDquery As String = "Select ItemID FROM item ORDER BY ItemID DESC LIMIT 1"
            Dim custIDquery As String = "Select CustID from customers where CustFname = '" & Nfnametbox.Text & "' AND CustLname = '" & Nlnametbox.Text & "' "



            Try
                readQuery(itmIDquery)
                With cmdRead
                    While .Read
                        itemID = .GetValue(0)



                    End While
                End With

                readQuery(custIDquery)
                With cmdRead
                    While .Read
                        custID = .GetValue(0)
                    End While
                End With



            Catch ex As Exception

            End Try
            str = "INSERT INTO pawncards( PawnDate, MaturityDate, ExpiryDate, LoanAmount, Balance, Cnum, Itemnum ) VALUES ('" & pawndate & "' ,'" & mdate & "','" & Edate & "' ,'" & total_amount.Text.ToString & "' ,'" & total_amount.Text.ToString & "','" & custID & "','" & itemID & "' )"


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
        Dim rowIndex As Integer = e.RowIndex

        ' Access the data in the clicked row
        Dim pawndate As DateTime = DataGridView2.Rows(rowIndex).Cells("pdate_column").Value
        Dim maturity As DateTime = DataGridView2.Rows(rowIndex).Cells("mdate_column").Value
        Dim expiry As DateTime = DataGridView2.Rows(rowIndex).Cells("edate_column").Value


        Dim curbalance As String = DataGridView2.Rows(rowIndex).Cells("balance_column").Value.ToString()
        Dim lname As String = DataGridView2.Rows(rowIndex).Cells("lname_column").Value.ToString()

        Dim fname As String = DataGridView2.Rows(rowIndex).Cells("fname_column").Value.ToString()
        Dim itemname As String = DataGridView2.Rows(rowIndex).Cells("item_column").Value.ToString()
        Dim itemtype As String = DataGridView2.Rows(rowIndex).Cells("Itype_column").Value.ToString()

        Dim balance_num As Double = Double.Parse(curbalance)
        Dim total As Double = balance_num + 50.0


        Pawncards.Visible = False

        renewal_panel.Visible = True


        fnametbox2.Text = fname
        lnametbox2.Text = lname
        loandateupdt.Value = pawndate
        maturityupdt.Value = maturity
        Expiryupdt.Value = expiry.AddMonths(1)

        jtypebox2.Text = itemtype
        Jname2.Text = itemname
        balance.Text = curbalance
        renewal.Text = "50.00"

        totaltbox2.Text = total.ToString
    End Sub

    Private Sub principal_amnt_TextChanged(sender As Object, e As EventArgs) Handles principal_amnt.TextChanged

        If String.IsNullOrEmpty(principal_amnt.Text) Then

            total_amount.Text = ""

        Else


            Dim principal As Double = Double.Parse(principal_amnt.Text)

            Dim interest As Double = Double.Parse(interestRate.Text)
            Dim interest_amnt As Double = principal * interest
            Dim total_amnt As Double = principal + interest_amnt
            total_amntvar = total_amnt
            total_amount.Text = total_amnt.ToString


        End If
    End Sub

    Private Sub ItemTypeSearchbox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ItemTypeSearchbox.SelectedIndexChanged
        LoadPcards(DataGridView2, searchLname.Text, searchFname.Text, searchItemname.Text, ItemTypeSearchbox.Text, "Renew")




    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim pcardID As String

        Dim pcardIDquery As String = "SELECT PcardID FROM pawncards, customers, item, itemtypes WHERE CustID = Cnum AND ItemID = Itemnum and ItemType = ItemTypeID and CustLname = '" & lnametbox2.Text & "' and CustFname = '" & fnametbox2.Text & "' ;"
        Try
            readQuery(pcardIDquery)
            With cmdRead
                While .Read
                    pcardID = .GetValue(0)

                End While
            End With

            Dim New_Expiry = Expiryupdt.Value.ToString()
            Dim PcardUpdt As String = "Update pawncards set ExpiryDate = '" & Expiryupdt.Value.ToString("yyyy-MM-dd") & "', Balance = '" & totaltbox2.Text & "' where PcardID = '" & pcardID & "'"

            readQuery(PcardUpdt)

            MsgBox("Pawn Card Renewed", MsgBoxStyle.MsgBoxRight)


            renewal_panel.Visible = False
            DataGridView2.Rows.Clear()
            Dim pcardload As String = "Select PawnDate, MaturityDate, ExpiryDate, LoanAmount, Balance, CustLname, CustFname, ItemName, ItemTypeName from pawncards,customers, item, itemtypes where Cnum = CustID and ItemID = Itemnum  and ItemType = ItemTypeID and Status = 'Active'"

            Try
                readQuery(pcardload)
                With cmdRead
                    While .Read
                        DataGridView2.Rows.Add(.GetValue(0), .GetValue(1), .GetValue(2), .GetValue(3), .GetValue(4), .GetValue(5), .GetValue(6), .GetValue(7), .GetValue(8), "Renew", "Move to Auction")
                    End While
                End With

            Catch ex As Exception


            End Try
            Pawncards.Visible = True



        Catch ex As Exception

        End Try



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        itemtypesearchbox2.Items.Clear()



        DataGridView3.Rows.Clear()


        Dim itemtypeload As String = "Select ItemTypeName from itemtypes"
        Dim pcardload As String = "Select PawnDate, MaturityDate, ExpiryDate, LoanAmount, Balance, CustLname, CustFname, ItemName, ItemTypeName from pawncards,customers, item, itemtypes where Cnum = CustID and ItemID = Itemnum  and ItemType = ItemTypeID and Status = 'Active'"
        DataGridView3.Rows.Clear()

        Try
            readQuery(itemtypeload)

            With cmdRead
                While .Read
                    itemtypesearchbox2.Items.Add(.GetValue(0))
                End While
            End With

            readQuery(pcardload)

            With cmdRead
                While .Read
                    DataGridView3.Rows.Add(.GetValue(0), .GetValue(1), .GetValue(2), .GetValue(3), .GetValue(4), .GetValue(5), .GetValue(6), .GetValue(7), .GetValue(8), "Pay")
                End While
            End With


            Pay.Size = PanelTransactions.Size
            Pay.Anchor = PanelTransactions.Anchor
            Pay.Location = PanelTransactions.Location
            PanelTransactions.Visible = False
            Panel4.Visible = False
            Panel6.Visible = False
            renewal_panel.Visible = False

            Pay.Visible = True

        Catch ex As Exception

        End Try

    End Sub


    Private Sub dataGridView3_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView3.CellContentClick
        ' Check if the clicked cell is the button cell and its column index matches the column where you placed the button
        Dim rowIndex As Integer = e.RowIndex

        ' Access the data in the clicked row
        Dim pawndate As DateTime = DataGridView3.Rows(rowIndex).Cells("pawndate2").Value
        Dim maturity As DateTime = DataGridView3.Rows(rowIndex).Cells("mdate2").Value
        Dim expiry As DateTime = DataGridView3.Rows(rowIndex).Cells("edate2").Value


        Dim curbalance As String = DataGridView3.Rows(rowIndex).Cells("balance2").Value.ToString()
        Dim lname As String = DataGridView3.Rows(rowIndex).Cells("lname2").Value.ToString()

        Dim fname As String = DataGridView3.Rows(rowIndex).Cells("fname2").Value.ToString()
        Dim itemname As String = DataGridView3.Rows(rowIndex).Cells("item2").Value.ToString()
        Dim itemtype As String = DataGridView3.Rows(rowIndex).Cells("itemtype2").Value.ToString()

        'Dim balance_num As Double = Double.Parse(curbalance)
        'Dim total As Double = balance_num + 50.0


        Pay.Visible = False

        paytransact.Visible = True


        fname3.Text = fname
        lname3.Text = lname
        ldate3.Value = pawndate
        mdate3.Value = maturity
        edate3.Value = expiry



        jtypebox3.Text = itemtype
        jname3.Text = itemname
        bduetbox.Text = curbalance






    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim status As String
        Dim PcardId As String
        Dim Cnum As String
        Dim itemnum As String
        Dim IDquery = "SELECT PcardID, Cnum, Itemnum FROM pawncards, customers, item, itemtypes WHERE CustID = Cnum AND ItemID = Itemnum and ItemType = ItemTypeID and CustLname = '" & lname3.Text & "' and CustFname = '" & fname3.Text & "' and ItemName = '" & jname3.Text & "' ;"
        Dim currentDate As Date = DateTime.Now
        Dim sqlFormattedDate As String = currentDate.ToString("yyyy-MM-dd")


        Dim amount As Double = Double.Parse(amountpaytbox.Text.ToString)
        Dim updt_blance As Double = Double.Parse(bduetbox.Text.ToString) - amount


        Try
            If updt_blance < 0 Then
                MsgBox("Please enter correct amount", MsgBoxStyle.Critical)
                Return

            ElseIf updt_blance > 0 Then

                status = "Active"


            Else
                status = "Redeemed"


            End If

            readQuery(IDquery)
            With cmdRead
                While .Read
                    PcardId = .GetValue(0)
                    Cnum = .GetValue(1)
                    itemnum = .GetValue(2)
                End While
            End With
            Dim InsPayments = "Insert into transactions(Cno, Itemno, T_amount, T_Date) values ('" & Cnum & "' ,'" & itemnum & "' ,'" & amount.ToString & "' ,'" & sqlFormattedDate & "'  )"
            Dim update_balanceQuery As String = "Update pawncards set balance = '" & updt_blance.ToString & "' where PcardID = '" & PcardId & "'"
            Dim itemstatus As String = "update item set Status = '" & status & "' where ItemID = '" & itemnum & "'"
            readQuery(InsPayments)
            readQuery(update_balanceQuery)
            readQuery(itemstatus)

            MsgBox("Payment Succesful", MsgBoxStyle.MsgBoxRight)

            Dim itemtypeload As String = "Select ItemTypeName from itemtypes"
            Dim pcardload As String = "Select PawnDate, MaturityDate, ExpiryDate, LoanAmount, Balance, CustLname, CustFname, ItemName, ItemTypeName from pawncards,customers, item, itemtypes where Cnum = CustID and ItemID = Itemnum  and ItemType = ItemTypeID and Status = 'Active'"
            DataGridView3.Rows.Clear()

            Try
                readQuery(itemtypeload)

                With cmdRead
                    While .Read
                        itemtypesearchbox2.Items.Add(.GetValue(0))
                    End While
                End With

                readQuery(pcardload)

                With cmdRead
                    While .Read
                        DataGridView3.Rows.Add(.GetValue(0), .GetValue(1), .GetValue(2), .GetValue(3), .GetValue(4), .GetValue(5), .GetValue(6), .GetValue(7), .GetValue(8), "Pay")
                    End While
                End With


            Catch ex As Exception

            End Try

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

        paytransact.Visible = False
        Pay.Visible = True

    End Sub

    Private Sub itemtypesearchbox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles itemtypesearchbox2.SelectedIndexChanged

        LoadPcards(DataGridView3, lnamesearch2.Text, fnamesearch2.Text, itemnamesearch2.Text, itemtypesearchbox2.Text, "Pay")


    End Sub

    Private Sub searchItemname_TextChanged(sender As Object, e As EventArgs) Handles searchItemname.TextChanged
        LoadPcards(DataGridView2, searchLname.Text, searchFname.Text, searchItemname.Text, ItemTypeSearchbox.Text, "Renew")

    End Sub

    Private Sub searchLname_TextChanged(sender As Object, e As EventArgs) Handles searchLname.TextChanged
        LoadPcards(DataGridView2, searchLname.Text, searchFname.Text, searchItemname.Text, ItemTypeSearchbox.Text, "Renew")

    End Sub

    Private Sub searchFname_TextChanged(sender As Object, e As EventArgs) Handles searchFname.TextChanged

        LoadPcards(DataGridView2, searchLname.Text, searchFname.Text, searchItemname.Text, ItemTypeSearchbox.Text, "Renew")


    End Sub

    Private Sub LoadPcards(ByVal dgv As DataGridView, ByVal lnamesearch As String, ByVal fnamesearch As String, ByVal itemsearch As String, ByVal itemtypesearch As String, ByVal method As String)
        Dim pcardload As String = "Select PawnDate, MaturityDate, ExpiryDate, LoanAmount, Balance, CustLname, CustFname, ItemName, ItemTypeName from pawncards,customers, item, itemtypes where Cnum = CustID and ItemID = Itemnum  and ItemType = ItemTypeID  and Status = 'Active'"


        If Not String.IsNullOrEmpty(lnamesearch) Then
            pcardload &= "and CustLname LIKE '%" & lnamesearch & "%'"
        End If

        If Not String.IsNullOrEmpty(fnamesearch) Then
            pcardload &= "and CustFname LIKE '%" & fnamesearch & "%'"
        End If

        If Not String.IsNullOrEmpty(itemsearch) Then
            pcardload &= "and ItemName LIKE '%" & itemsearch & "%'"
        End If

        If ItemTypeSearchbox.SelectedIndex <> -1 Then
            pcardload &= "and ItemTypeName = '" & itemtypesearch & "'"
        End If

        dgv.Rows.Clear()

        Try
            readQuery(pcardload)
            With cmdRead
                While .Read


                    dgv.Rows.Add(.GetValue(0), .GetValue(1), .GetValue(2), .GetValue(3), .GetValue(4), .GetValue(5), .GetValue(6), .GetValue(7), .GetValue(8), method)

                End While
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub lnamesearch2_TextChanged(sender As Object, e As EventArgs) Handles lnamesearch2.TextChanged
        LoadPcards(DataGridView3, lnamesearch2.Text, fnamesearch2.Text, itemnamesearch2.Text, itemtypesearchbox2.Text, "Pay")

    End Sub

    Private Sub fnamesearch2_TextChanged(sender As Object, e As EventArgs) Handles fnamesearch2.TextChanged
        LoadPcards(DataGridView3, lnamesearch2.Text, fnamesearch2.Text, itemnamesearch2.Text, itemtypesearchbox2.Text, "Pay")

    End Sub

    Private Sub itemnamesearch2_TextChanged(sender As Object, e As EventArgs) Handles itemnamesearch2.TextChanged
        LoadPcards(DataGridView3, lnamesearch2.Text, fnamesearch2.Text, itemnamesearch2.Text, itemtypesearchbox2.Text, "Pay")

    End Sub



    Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub PanelTransactions_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelTransactions.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub AddCust_Click_1(sender As Object, e As EventArgs) Handles AddCust.Click
        CustPanel.Visible = False
        AddCustomerPnl.Visible = True
    End Sub
End Class
