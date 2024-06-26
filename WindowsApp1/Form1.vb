﻿Imports System.Runtime.InteropServices
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Text.RegularExpressions
Imports System.Security.Cryptography
Imports System.Text


Public Class Form1
    Public Property UserData As String

    Dim total_amntvar As Double
    Dim custid As String
    Dim Item As String
    Dim itemtype As String
    Dim startbidprice As Double
    Dim curbid As Double




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
                Panel4.Visible = False
                AddCustomerPnl.Visible = False
                Panel6.Visible = False
                Pawncards.Visible = False
                renewal_panel.Visible = False
                Pay.Visible = False
                paytransact.Visible = False
                BID_PANEL.Visible = False
                records.Visible = False
                adduser.Visible = False
                userspanel.Visible = False



            Case "Pawncards"
                ' Code to handle Button2 click
                Panel4.Visible = False
                AddCustomerPnl.Visible = False
                Panel6.Visible = False
                PanelTransactions.Visible = False
                renewal_panel.Visible -= True
                Pay.Visible = False
                BID_PANEL.Visible = False
                records.Visible = False
                adduser.Visible = False
                userspanel.Visible = False



            Case "Customers"
                Panel4.Visible = False
                AddCustomerPnl.Visible = False
                Panel6.Visible = False
                PanelTransactions.Visible = False
                renewal_panel.Visible = False
                Pay.Visible = False
                Pawncards.Visible = False
                paytransact.Visible = False
                ItemsPanel.Visible = False

                CustPanel.Visible = True
                BID_PANEL.Visible = False
                records.Visible = False
                adduser.Visible = False
                userspanel.Visible = False



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
                BID_PANEL.Visible = False
                records.Visible = False
                adduser.Visible = False
                userspanel.Visible = False



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
                BID_PANEL.Visible = False
                records.Visible = False
                adduser.Visible = False
                userspanel.Visible = False



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
                BID_PANEL.Visible = False
                records.Visible = False
                adduser.Visible = False
                userspanel.Visible = False

            Case "Records"
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
                payemnts.Visible = False
                BID_PANEL.Visible = False
                records.Visible = True
                adduser.Visible = False
                userspanel.Visible = False

            Case "Users"
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
                payemnts.Visible = False
                BID_PANEL.Visible = False
                records.Visible = False
                adduser.Visible = False
                userspanel.Visible = True














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
        BID_PANEL.Visible = False
        records.Visible = False
        adduser.Visible = False
        userspanel.Visible = False

        records.Visible = False

        If UserData.Equals("Admin") Then
            btnAuctions.Enabled = True
            btnPawnCards.Enabled = True
            btn_customers.Enabled = True
            buttonItems.Enabled = True
            btnTransactRec.Enabled = True
            btn_transactions.Enabled = True
            users.Enabled = False
            reportsbtn.Enabled = False


        ElseIf UserData.Equals("User") Then

            buttonItems.Enabled = False

            users.Enabled = False
            reportsbtn.Enabled = False

        Else
            btnAuctions.Enabled = True
            btnPawnCards.Enabled = True
            btn_customers.Enabled = True
            buttonItems.Enabled = True
            btnTransactRec.Enabled = True
            btn_transactions.Enabled = True
            users.Enabled = True
            reportsbtn.Enabled = True

        End If
        'Dim pos As String = loginfrm.DataToPass



    End Sub

    Private Sub dataGridView7_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView7.CellContentClick
        If e.ColumnIndex = DataGridView7.Columns("bid").Index AndAlso e.RowIndex >= 0 Then

            Dim rowIndex As Integer = e.RowIndex

            ' Access the data in the clicked row
            Item = DataGridView7.Rows(rowIndex).Cells("AuctItem").Value.ToString()
            itemtype = DataGridView7.Rows(rowIndex).Cells("AuctionItemType").Value.ToString()
            startbidprice = DataGridView7.Rows(rowIndex).Cells("StartBid").Value.ToString()
            curbid = DataGridView7.Rows(rowIndex).Cells("curbid_column").Value.ToString()


            BID_PANEL.Visible = True
            AuctionItems.Visible = False

            panel_left.Enabled = False



        End If

    End Sub

    Private Sub btn_customers_Click(sender As Object, e As EventArgs) Handles btn_customers.Click
        HandleButtonClick("Customers")
        panelOnButtonCst.Height = btn_customers.Height
        panelOnButtonCst.Top = btn_customers.Top

        DataGridView4.Rows.Clear()
        savebtn.Enabled = False
        updtfname.Clear()
        updtlname.Clear()

        updtcontact.Clear()

        updtaddress.Clear()

        Dim customer_data As String = "Select CustFname, CustLname, CustContact, CustAddress from customers where CustStatus = 'Active'"

        Try
            readQuery(customer_data)
            With cmdRead
                While .Read
                    DataGridView4.Rows.Add(.GetValue(0), .GetValue(1), .GetValue(2), .GetValue(3), "Edit", "Delete")
                End While
            End With

        Catch ex As Exception

        End Try






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
        statuscbox.Items.Clear()
        itemtypesrch.Items.Clear()
        statuscbox.Items.Add("Active")
        statuscbox.Items.Add("Redeemed")

        statuscbox.Items.Add("Auctioned")

        Dim itemtypeload As String = "Select ItemTypeName from itemtypes"

        Dim itemquery As String = "select ItemName, ItemTypeName, Status from item, itemtypes where ItemType = ItemTypeID "

        Try

            readQuery(itemtypeload)
            With cmdRead
                While .Read
                    itemtypesrch.Items.Add(.GetValue(0))
                End While
            End With
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
        DataGridView7.Rows.Clear()
        Dim aucItems As String = "Select ItemName, ItemTypeName,startingbid,currentbid,enddate from item,itemtypes,auction where item.ItemID = auction.ItemID and item.ItemType = ItemTypeID "
        Try
            readQuery(aucItems)
            With cmdRead
                While .Read
                    DataGridView7.Rows.Add(.GetValue(0), .GetValue(1), .GetValue(2), .GetValue(3), .GetValue(4), "Bid")
                End While
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub btn_pawn_Click(sender As Object, e As EventArgs) Handles btn_pawn.Click
        Panel4.Size = PanelTransactions.Size
        Panel4.Anchor = PanelTransactions.Anchor
        Panel4.Location = PanelTransactions.Location

        Panel4.Visible = True
        DataGridView1.Rows.Clear()

        Dim customer_data As String = "Select CustFname, CustLname, CustContact, CustAddress from customers where CustStatus = 'Active'"


        readQuery(customer_data)
        With cmdRead
            While .Read
                DataGridView1.Rows.Add(.GetValue(0), .GetValue(1), .GetValue(2), .GetValue(3), "Pawn")
            End While
        End With


        PanelTransactions.Visible = False





    End Sub

    Private Sub AddCust_Click(sender As Object, e As EventArgs)

        CustPanel.Visible = False
        AddCustomerPnl.Visible = True
    End Sub

    Private Sub dataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.ColumnIndex = DataGridView1.Columns("pawn_colbtn").Index AndAlso e.RowIndex >= 0 Then
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
            jtypebox.Items.Clear()
            jewelryname.Clear()
            principal_amnt.Clear()



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


        End If

        ' Get the index of the clicked row


    End Sub

    Private Sub addcustbtn_Click(sender As Object, e As EventArgs) Handles addcustbtn.Click
        If String.IsNullOrWhiteSpace(fnameTbox.Text) OrElse
       String.IsNullOrWhiteSpace(lnameTbox.Text) OrElse
       String.IsNullOrWhiteSpace(contactTbox.Text) OrElse
       String.IsNullOrWhiteSpace(addressTbox.Text) Then
            MsgBox("Please fill in all fields.", MsgBoxStyle.Exclamation)
            Return
        End If

        If IsNumeric(fnameTbox.Text) OrElse IsNumeric(lnameTbox.Text) OrElse IsNumeric(addressTbox.Text) Then
            MsgBox("Please enter valid text for name and address fields.", MsgBoxStyle.Exclamation)
            Return
        End If

        If Not IsValidPhilippinePhoneNumber(contactTbox.Text.ToString) Then
            MsgBox("Please enter valid phone number for name and address fields.", MsgBoxStyle.Exclamation)
            Return

        End If

        Dim str As String
        str = "INSERT INTO customers(CustFname, CustLname, CustContact, CustAddress) VALUES ('" & fnameTbox.Text & "','" & lnameTbox.Text & "','" & contactTbox.Text & "','" & addressTbox.Text & "')"

        Try
            readQuery(str)
            MsgBox("Successfully Added")
            CustPanel.Visible = True
            CustPanel.Enabled = True
            panel_left.Enabled = True
            AddCustomerPnl.Visible = False
            DataGridView4.Rows.Clear()

            Dim customer_data As String = "SELECT CustFname, CustLname, CustContact, CustAddress FROM customers WHERE CustStatus = 'Active'"

            readQuery(customer_data)
            With cmdRead
                While .Read
                    DataGridView4.Rows.Add(.GetValue(0), .GetValue(1), .GetValue(2), .GetValue(3), "Edit", "Delete")
                End While
            End With

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
        If Not String.IsNullOrEmpty(jtypebox.Text) And Not String.IsNullOrEmpty(jewelryname.Text) And Not String.IsNullOrEmpty(principal_amnt.Text) Then

            Try
                readQuery(itemtypeidQuery)
                With cmdRead
                    While .Read
                        itemtypeid = .GetValue(0)
                    End While
                End With
            Catch ex As Exception

            End Try

            itmInsrt = "insert into item(ItemName, ItemType ) values ('" & jewelryname.Text & "' , '" & itemtypeid & "' )"




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
        Else
            MsgBox("Please Fill all required inputs", MsgBoxStyle.Critical)
        End If





    End Sub

    Private Sub dataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
        If e.ColumnIndex = DataGridView2.Columns("renew_column").Index AndAlso e.RowIndex >= 0 Then
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

        ElseIf e.ColumnIndex = DataGridView2.Columns("auction").Index AndAlso e.RowIndex >= 0 Then
            Dim rowIndex As Integer = e.RowIndex

            Dim expiry As DateTime = DataGridView2.Rows(rowIndex).Cells("edate_column").Value
            Dim itemname As String = DataGridView2.Rows(rowIndex).Cells("item_column").Value.ToString()
            Dim lname As String = DataGridView2.Rows(rowIndex).Cells("lname_column").Value.ToString()

            Dim fname As String = DataGridView2.Rows(rowIndex).Cells("fname_column").Value.ToString()
            Dim startingbid As String = DataGridView2.Rows(rowIndex).Cells("loan_column").Value.ToString()

            Dim enddate As String = expiry.AddMonths(1).ToString("yyyy-MM-dd")

            Dim pcardID As String

            Dim result As DialogResult = MessageBox.Show("Are you sure you want to proceed?", "Confirmation", MessageBoxButtons.YesNo)

            If result = DialogResult.Yes Then
                Dim pcardIDquery As String = "SELECT Itemnum FROM pawncards, customers, item, itemtypes WHERE CustID = Cnum AND ItemID = Itemnum and ItemType = ItemTypeID and CustLname = '" & lname & "' and CustFname = '" & fname & "' and ItemName = '" & itemname & "';"
                Try
                    readQuery(pcardIDquery)
                    With cmdRead
                        While .Read
                            pcardID = .GetValue(0)

                        End While


                    End With
                    Dim itemupdate = "Update item set Status = 'Auctioned' where ItemID = '" & pcardID & "'"
                    Dim auction_insert As String = "Insert into auction (ItemID, startingbid, enddate) values ('" & pcardID & "','" & startingbid & "', '" & enddate & "')"

                    readQuery(auction_insert)
                    readQuery(itemupdate)
                    Dim aID As String
                    Dim auctionid As String = "select AuctionID from auction where ItemID = '" & pcardID & "'"
                    readQuery(auctionid)
                    With cmdRead
                        While .Read
                            aID = .GetValue(0)
                        End While
                    End With
                    Dim curdate As DateTime = DateTime.Now
                    Dim formattedDate As String = curdate.ToString("yyyy-MM-dd")

                    Dim itemtransfer As String = "Insert into transfers(Inum,Anum,ItemTransferDate) values ('" & pcardID & "','" & aID & "','" & formattedDate & "' )"

                    readQuery(itemtransfer)

                    MsgBox("Item Transferred to Auctioned", MsgBoxStyle.Information)
                    Dim pcardload As String = "Select PawnDate, MaturityDate, ExpiryDate, LoanAmount, Balance, CustLname, CustFname, ItemName, ItemTypeName from pawncards,customers, item, itemtypes where Cnum = CustID and ItemID = Itemnum  and ItemType = ItemTypeID and Status = 'Active'"
                    DataGridView2.Rows.Clear()

                    Try


                        readQuery(pcardload)

                        With cmdRead
                            While .Read
                                DataGridView2.Rows.Add(.GetValue(0), .GetValue(1), .GetValue(2), .GetValue(3), .GetValue(4), .GetValue(5), .GetValue(6), .GetValue(7), .GetValue(8), "Renew", "Auction")
                            End While
                        End With

                    Catch ex As Exception

                    End Try






                Catch ex As Exception

                End Try




            Else
                ' User clicked No or closed the dialog, don't proceed
                ' Your code here
            End If









        End If
        ' Check if the clicked cell is the button cell and its column index matches the column where you placed the button

    End Sub

    Private Sub principal_amnt_TextChanged(sender As Object, e As EventArgs) Handles principal_amnt.TextChanged
        Try
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
        Catch ex As Exception
            MsgBox("Please Enter Correct Input")
            principal_amnt.Clear()

        End Try

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
        If e.ColumnIndex = DataGridView3.Columns("pay_column").Index AndAlso e.RowIndex >= 0 Then
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


        End If






    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim status As String
        Dim PcardId As String
        Dim Cnum As String
        Dim itemnum As String
        Dim IDquery = "SELECT PcardID, Cnum, Itemnum FROM pawncards, customers, item, itemtypes WHERE CustID = Cnum AND ItemID = Itemnum and ItemType = ItemTypeID and CustLname = '" & lname3.Text & "' and CustFname = '" & fname3.Text & "' and ItemName = '" & jname3.Text & "' ;"
        Dim currentDate As Date = DateTime.Now
        Dim sqlFormattedDate As String = currentDate.ToString("yyyy-MM-dd")
        Try
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
        Catch ex As Exception
            MsgBox("Please Enter Correct Input")


        End Try



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
        CustPanel.Visible = True
        CustPanel.Enabled = False
        panel_left.Enabled = False
        AddCustomerPnl.Visible = True
        fnameTbox.Text = ""
        addressTbox.Text = ""
        contactTbox.Text = ""
        lnameTbox.Text = ""
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles savebtn.Click

        If Not String.IsNullOrEmpty(updtfname.Text) And Not String.IsNullOrEmpty(updtlname.Text) And Not String.IsNullOrEmpty(updtaddress.Text) And Not String.IsNullOrEmpty(updtcontact.Text) And IsValidPhilippinePhoneNumber(updtcontact.Text.ToString) Then
            Dim custupdate As String = "Update customers set CustFname = '" & updtfname.Text & "',CustLname = '" & updtlname.Text & "',CustContact = '" & updtcontact.Text & "',CustAddress = '" & updtaddress.Text & "' where CustID = '" & custid & "'"
            Try
                readQuery(custupdate)
                MsgBox("Updated Successfully", MsgBoxStyle.Information)
                savebtn.Enabled = False
                updtfname.Clear()
                updtlname.Clear()

                updtcontact.Clear()

                updtaddress.Clear()


            Catch ex As Exception

            End Try
        Else
            MsgBox("Please input necessary values", MsgBoxStyle.Critical)




        End If

    End Sub

    Function IsValidPhilippinePhoneNumber(ByVal phoneNumber As String) As Boolean
        ' Regular expression pattern for Philippine phone number format
        Dim pattern As String = "^09[0-9]{9}$"

        ' Check if the phone number matches the pattern
        Dim regex As New Regex(pattern)
        Return regex.IsMatch(phoneNumber)
    End Function


    Private Sub CustomerIdquery(fname As String, lname As String)

        Dim custidquery As String = "select CustID from customers where CustFname = '" & fname & "' and CustLname = '" & lname & "' "


        Try
            readQuery(custidquery)
            With cmdRead
                While .Read
                    custid = .GetValue(0)
                End While
            End With


        Catch ex As Exception

        End Try
        savebtn.Enabled = True
    End Sub


    Private Sub dataGridView4_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView4.CellContentClick
        Dim rowIndex As Integer
        If e.ColumnIndex = DataGridView4.Columns("Edit").Index AndAlso e.RowIndex >= 0 Then

            rowIndex = e.RowIndex

            Dim fname As String = DataGridView4.Rows(rowIndex).Cells("custfname").Value.ToString()
            Dim lname As String = DataGridView4.Rows(rowIndex).Cells("custlname").Value.ToString()

            Dim contact As String = DataGridView4.Rows(rowIndex).Cells("custcontact").Value.ToString()
            Dim address As String = DataGridView4.Rows(rowIndex).Cells("custaddress").Value.ToString()


            updtfname.Text = fname
            updtlname.Text = lname
            updtcontact.Text = contact
            updtaddress.Text = address


            CustomerIdquery(fname, lname)
        ElseIf e.ColumnIndex = DataGridView4.Columns("Delete").Index AndAlso e.RowIndex >= 0 Then
            rowIndex = e.RowIndex

            Dim fname As String = DataGridView4.Rows(rowIndex).Cells("custfname").Value.ToString()
            Dim lname As String = DataGridView4.Rows(rowIndex).Cells("custlname").Value.ToString()
            CustomerIdquery(fname, lname)
            Dim custupdate As String = "Update customers set CustStatus = 'Deleted' where CustID = '" & custid & "'"
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete record?", "Confirmation", MessageBoxButtons.YesNo)

            If result = DialogResult.Yes Then
                Try
                    readQuery(custupdate)
                    MsgBox("Record Deleted", MsgBoxStyle.Information)

                    DataGridView4.Rows.Clear()

                    Dim customer_data As String = "Select CustFname, CustLname, CustContact, CustAddress from customers where CustStatus = 'Active'"


                    readQuery(customer_data)
                    With cmdRead
                        While .Read
                            DataGridView4.Rows.Add(.GetValue(0), .GetValue(1), .GetValue(2), .GetValue(3), "Edit", "Delete")
                        End While
                    End With



                Catch ex As Exception

                End Try

            Else


            End If

        End If

    End Sub
    Private Sub customersearch(ByVal dgv As DataGridView, lnamesearch As String, fnamesearch As String, method As String)
        Dim customerquery As String = "SELECT CustFname, CustLname, CustContact, CustAddress from customers where CustStatus = 'Active' "
        If Not String.IsNullOrEmpty(lnamesearch) Then
            customerquery &= "AND CustLname LIKE '%" & lnamesearch & "%'"
        End If

        If Not String.IsNullOrEmpty(fnamesearch) Then
            customerquery &= "AND CustFname LIKE '%" & fnamesearch & "%'"
        End If

        dgv.Rows.Clear()

        If method = "" Then
            Try
                readQuery(customerquery)
                With cmdRead
                    While .Read


                        dgv.Rows.Add(.GetValue(0), .GetValue(1), .GetValue(2), .GetValue(3), "Edit", "Delete")

                    End While
                End With
            Catch ex As Exception

            End Try

        Else
            Try
                readQuery(customerquery)
                With cmdRead
                    While .Read


                        dgv.Rows.Add(.GetValue(0), .GetValue(1), .GetValue(2), .GetValue(3), method)

                    End While
                End With
            Catch ex As Exception

            End Try

        End If




    End Sub

    Private Sub itemsearch()

        Dim itemquery As String = "select ItemName, ItemTypeName, Status from item, itemtypes where ItemType = ItemTypeID "
        If Not String.IsNullOrEmpty(c.Text) Then
            itemquery &= "and ItemName LIKE '%" & c.Text & "%'"
        End If


        If itemtypesrch.SelectedIndex <> -1 Then
            itemquery &= "and ItemTypeName = '" & itemtypesrch.Text & "'"
        End If

        If statuscbox.SelectedIndex <> -1 Then
            itemquery &= "and Status = '" & statuscbox.Text & "'"
        End If
        DataGridView5.Rows.Clear()

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

    Private Sub transactsearch()
        Dim transactquery As String = "select CustFname, CustLname, ItemName, ItemTypeName, T_amount, T_Date FROM customers,item,itemtypes, transactions where CustID = Cno and Itemno = ItemID and ItemType = ItemTypeID"

        If Not String.IsNullOrEmpty(Transactlname.Text) Then
            transactquery &= " and CustLname LIKE '%" & Transactlname.Text & "%'"
        End If

        If Not String.IsNullOrEmpty(Transactfname.Text) Then
            transactquery &= " and CustFname LIKE '%" & Transactfname.Text & "%'"
        End If

        If Not String.IsNullOrEmpty(TransactItemName.Text) Then
            transactquery &= " and ItemName LIKE '%" & TransactItemName.Text & "%'"
        End If

        If TransactItemType.SelectedIndex <> -1 Then
            transactquery &= " and ItemTypeName = '" & TransactItemType.Text & "'"
        End If
        DataGridView6.Rows.Clear()

        Try
            readQuery(transactquery)
            With cmdRead
                While .Read
                    DataGridView6.Rows.Add(.GetValue(0), .GetValue(1), .GetValue(2), .GetValue(3), .GetValue(4), .GetValue(5))

                End While
            End With
        Catch ex As Exception

        End Try

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles fnamesearch.TextChanged
        customersearch(DataGridView4, lnamesearch.Text, fnamesearch.Text, "")
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles lnamesearch.TextChanged
        customersearch(DataGridView4, lnamesearch.Text, fnamesearch.Text, "")

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles fnameSTbox.TextChanged
        customersearch(DataGridView1, lnameSTbox.Text, fnameSTbox.Text, "Pawn")

    End Sub

    Private Sub lnameSTbox_TextChanged(sender As Object, e As EventArgs) Handles lnameSTbox.TextChanged
        customersearch(DataGridView1, lnameSTbox.Text, fnameSTbox.Text, "Pawn")
    End Sub

    Private Sub c_TextChanged(sender As Object, e As EventArgs) Handles c.TextChanged
        itemsearch()

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles itemtypesrch.SelectedIndexChanged
        itemsearch()

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles statuscbox.SelectedIndexChanged
        itemsearch()
    End Sub

    Private Sub Transactfname_TextChanged(sender As Object, e As EventArgs) Handles Transactfname.TextChanged
        transactsearch()
    End Sub

    Private Sub Transactlname_TextChanged(sender As Object, e As EventArgs) Handles Transactlname.TextChanged
        transactsearch()
    End Sub

    Private Sub TransactItemName_TextChanged(sender As Object, e As EventArgs) Handles TransactItemName.TextChanged
        transactsearch()
    End Sub

    Private Sub TransactItemType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TransactItemType.SelectedIndexChanged
        transactsearch()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        CustPanel.Visible = True
        CustPanel.Enabled = True
        panel_left.Enabled = True
        AddCustomerPnl.Visible = False
    End Sub

    Private Sub bidconfirm_Click(sender As Object, e As EventArgs) Handles bidconfirm.Click

        Try
            If Not String.IsNullOrEmpty(bidtbox.Text) Then

                Dim bid As Double = Double.Parse(bidtbox.Text)

                If Not bid <= startbidprice And Not bid < curbid Then
                    Dim AId As String
                    Dim ItemID As String
                    Dim auctionAndItem As String = "select AuctionID ,auction.ItemID FROM auction,item where auction.ItemID = item.ItemID AND startingbid = '" & startbidprice & "'"
                    Try
                        readQuery(auctionAndItem)
                        With cmdRead
                            While .Read
                                AId = .GetValue(0)
                                ItemID = .GetValue(1)

                            End While
                        End With

                        Dim updatebid As String = "Update auction set currentbid = '" & bidtbox.Text & "' where AuctionID = '" & AId & "' AND ItemID ='" & ItemID & "'"

                        readQuery(updatebid)
                        MsgBox("Bid Successfully Placed", MsgBoxStyle.Information)
                        DataGridView7.Rows.Clear()
                        bidtbox.Clear()
                        Dim aucItems As String = "Select ItemName, ItemTypeName,startingbid,currentbid,enddate from item,itemtypes,auction where item.ItemID = auction.ItemID and item.ItemType = ItemTypeID "
                        Try
                            readQuery(aucItems)
                            With cmdRead
                                While .Read
                                    DataGridView7.Rows.Add(.GetValue(0), .GetValue(1), .GetValue(2), .GetValue(3), .GetValue(4), "Bid")
                                End While
                            End With
                        Catch ex As Exception

                        End Try
                        BID_PANEL.Visible = False
                        AuctionItems.Enabled = True
                        panel_left.Enabled = True
                    Catch ex As Exception

                    End Try

                Else
                    MsgBox("Please input amount greater than the Current Bid", MsgBoxStyle.Exclamation)
                End If

            Else
                MsgBox("Input cannot be empty", MsgBoxStyle.Exclamation)
            End If
        Catch ex As Exception
            MsgBox("Please enter valid value")
        End Try



    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        BID_PANEL.Visible = False
        AuctionItems.Visible = True
        panel_left.Enabled = True
    End Sub

    Private Sub AitemName_TextChanged(sender As Object, e As EventArgs) Handles AitemName.TextChanged
        auction_search()
    End Sub

    Private Sub AitemType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles AitemType.SelectedIndexChanged
        auction_search()
    End Sub

    Private Sub auction_search()
        DataGridView7.Rows.Clear()
        Dim aucItems As String = "Select ItemName, ItemTypeName,startingbid,currentbid,enddate from item,itemtypes,auction where item.ItemID = auction.ItemID and item.ItemType = ItemTypeID "
        If Not String.IsNullOrEmpty(AitemName.Text) Then
            aucItems &= "and ItemName LIKE '%" & AitemName.Text & "%'"
        End If


        If AitemType.SelectedIndex <> -1 Then
            aucItems &= "and ItemTypeName = '" & AitemType.Text & "'"
        End If


        Try
            readQuery(aucItems)
            With cmdRead
                While .Read
                    DataGridView7.Rows.Add(.GetValue(0), .GetValue(1), .GetValue(2), .GetValue(3), .GetValue(4), "Bid")
                End While
            End With
        Catch ex As Exception

        End Try


    End Sub

    Private Sub reportsbtn_Click(sender As Object, e As EventArgs) Handles reportsbtn.Click
        panelOnButtonCst.Height = reportsbtn.Height
        panelOnButtonCst.Top = reportsbtn.Top
        HandleButtonClick("Records")



        Dim custcount2 As String = "SELECT count(*) from customers where customers.CustStatus = 'Active'"
        Dim item_loan_count As String = "SELECT count(*) from item where item.Status = 'Active';"
        Dim t_bal As String = "SELECT SUM(pawncards.Balance) from pawncards join item on item.ItemID = pawncards.Itemnum where item.Status = 'Active';"
        Dim auction_count As String = "select count(*) from auction where auctionstatus = 'Active'"

        Dim c_count As String
        Dim item_count As String
        Dim total_balnce As String
        Dim total_balance_with_peso As String
        Dim a_count As String

        Try
            readQuery(custcount2)
            With cmdRead
                While .Read
                    c_count = .GetValue(0)

                End While
            End With

            readQuery(item_loan_count)
            With cmdRead
                While .Read
                    item_count = .GetValue(0)

                End While
            End With

            readQuery(t_bal)
            With cmdRead
                While .Read
                    total_balnce = .GetValue(0)
                    total_balance_with_peso = "₱" & total_balnce & ".00"

                End While
            End With

            readQuery(auction_count)
            With cmdRead
                While .Read
                    a_count = .GetValue(0)

                End While
            End With



        Catch ex As Exception

        End Try

        custcount.Text = c_count
        loan_count.Text = item_count
        bal_count.Text = total_balance_with_peso
        auct_count.Text = a_count
    End Sub

    Private Sub add_user_Click(sender As Object, e As EventArgs) Handles add_user.Click
        u_level_cbox.Items.Clear()
        u_level_cbox.Items.Add("Admin")
        u_level_cbox.Items.Add("User")
        username_tbox.Clear()
        password_tbox.Clear()


        userspanel.Enabled = False
        panel_left.Enabled = False
        adduser.Visible = True
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

        If Not String.IsNullOrEmpty(username_tbox.Text) And Not String.IsNullOrEmpty(password_tbox.Text) And Not String.IsNullOrEmpty(u_level_cbox.Text) Then
            Dim username As String = username_tbox.Text
            Dim password As String = EncryptPassword(password_tbox.Text) ' Encrypt password before storing
            Dim user_level As String = u_level_cbox.Text


            Dim insert_user = "insert into users (username,password,user_level) values ('" & username & "','" & password & "', '" & user_level & "' )"

            Try
                readQuery(insert_user)
                MsgBox("User Successfully Added")
                username_tbox.Clear()
                password_tbox.Clear()
                u_level_cbox.Items.Clear()
                adduser.Visible = False
                userspanel.Enabled = True
                panel_left.Enabled = True
                Dim userquery As String = "Select username,user_level from users"
                DataGridView8.Rows.Clear()

                Try
                    readQuery(userquery)
                    With cmdRead
                        While .Read
                            DataGridView8.Rows.Add(.GetValue(0), .GetValue(1))
                        End While
                    End With

                Catch ex As Exception

                End Try
            Catch ex As Exception

            End Try
        End If

    End Sub

    Private Function EncryptPassword(password As String) As String
        Using md5Hash As MD5 = MD5.Create()
            ' Convert the input string to a byte array and compute the hash
            Dim data As Byte() = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(password))

            ' Create a new StringBuilder to collect the bytes
            Dim sBuilder As New StringBuilder()

            ' Loop through each byte of the hashed data and format each one as a hexadecimal string
            For i As Integer = 0 To data.Length - 1
                sBuilder.Append(data(i).ToString("x2"))
            Next

            ' Return the hexadecimal string
            Return sBuilder.ToString()
        End Using
    End Function

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        userspanel.Enabled = True
        panel_left.Enabled = True
        adduser.Visible = False
    End Sub

    Private Sub Button7_Click_1(sender As Object, e As EventArgs) Handles users.Click
        panelOnButtonCst.Height = users.Height
        panelOnButtonCst.Top = users.Top



        HandleButtonClick("Users")

        Dim userquery As String = "Select username,user_level from users"
        DataGridView8.Rows.Clear()

        Try
            readQuery(userquery)
            With cmdRead
                While .Read
                    DataGridView8.Rows.Add(.GetValue(0), .GetValue(1))
                End While
            End With

        Catch ex As Exception

        End Try


    End Sub

    Private Sub PanelTransactions_Paint(sender As Object, e As PaintEventArgs) Handles PanelTransactions.Paint

    End Sub

    Private Sub logout_Click(sender As Object, e As EventArgs) Handles logout.Click
        UserData = ""

        Dim loginfrm As New loginfrm
        loginfrm.Show()
        Me.Close()
    End Sub
End Class
