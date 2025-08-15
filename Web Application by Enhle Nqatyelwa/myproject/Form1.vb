Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Const Vatrate As Decimal = 0.15
        Const Markuprate As Decimal = 0.4
        Dim Name As String = txtName.Text
        Dim Surname As String = txtSurname.Text
        Dim Peripherals As Double
        Dim Computer As Double
        Dim GraphicsCard As Double
        Dim Monitor As Double
        Dim Mouse As Double
        Dim keyboard As Double
        Dim Speakers As Double


        If txtName.Text = "" Then
            MessageBox.Show("Please Enter name")
            txtName.Focus()
        Else
            Name = (txtName.Text)
        End If

        If txtSurname.Text = "" Then
            MessageBox.Show("Please Enter Surname")
            txtSurname.Focus()
        Else
            Surname = (txtSurname.Text)
        End If

        'Checkbox for Peripherals
        lstDisplay.Items.Clear()
        lstDisplay.Items.Add("===Welcome To Nqatyelwa Computer===")
        lstDisplay.Items.Add("Customer: " & txtName.Text & " " & txtSurname.Text)
        lstDisplay.Items.Add("-----------------------------")

        If chkComputer.Checked = True Then
            Peripherals += 4607
            Computer = Peripherals
            lstDisplay.Items.Add("Computer:         R4 607")
        End If
        If chkMonitor.Checked = True Then
            Peripherals += 1578
            Monitor = Peripherals
            lstDisplay.Items.Add("Monitor:            R1578")
        End If
        If chkGraphicsCard.Checked = True Then
            Peripherals += 1438
            GraphicsCard = Peripherals
            lstDisplay.Items.Add("Graphics Card:  R1438")
        End If
        If chkKeyboard.Checked = True Then
            Peripherals += 115
            keyboard = Peripherals
            lstDisplay.Items.Add("Keyboard:         R115")
        End If
        If chkMouse.Checked = True Then
            Peripherals += 49
            Mouse = Peripherals
            lstDisplay.Items.Add("Mouse:             R49")
        End If
        If chkSpeakers.Checked = True Then
            Peripherals += 169
            Speakers = Peripherals
            lstDisplay.Items.Add("Speakers:         R169")
        End If

        'Combo box using Select Case
        Dim comboBox As Double


        Select Case cmbHDD.SelectedItem.ToString()
                Case "EAGET 256GB"
                    lstDisplay.Items.Add("Eaget 256GB:  R400")
                    comboBox += 400
                Case "SUMSUNG 500GB"
                    lstDisplay.Items.Add("Sumsung 500GB:R700")
                    comboBox += 700
                Case "SEAGET 160GB"
                    lstDisplay.Items.Add("Seaget 160GB: R260")
                    comboBox += 260
            End Select


        'Ram Section using If Statement
        Dim ram As Double

        If radCrucial.Checked Then
            ram = 200
            lstDisplay.Items.Add("Crucial 8GB:     " & ram.ToString("c2"))
        End If
        If radEaget.Checked Then
            ram = 400
            lstDisplay.Items.Add("Eaget 8GB:      " & ram.ToString("c2"))
        End If
        If radSumsung.Checked Then
            ram = 350
            lstDisplay.Items.Add("Sumsung 4GB: " & ram.ToString("c2"))
        End If


        Dim subtotal As Double = 0
        subtotal += Peripherals + ram + comboBox

        Dim Vat As Decimal = subtotal * Vatrate
        Dim Markup As Decimal = subtotal * Markuprate
        Dim Total As Decimal = subtotal + Markup + Vat



        lstDisplay.Items.Add("-----------------------------")
        lstDisplay.Items.Add("Subtotal:          " & subtotal.ToString("c2"))
        lstDisplay.Items.Add("VAT(15):          " & Vat.ToString("c2"))
        lstDisplay.Items.Add("Markup(40%):   " & Markup.ToString("c2"))
        lstDisplay.Items.Add("Total:               " & Total.ToString("c2"))


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnQuote.Click
        SaveIt.InitialDirectory = "C:\"
        SaveIt.FileName = "Save as..."
        SaveIt.Filter = "Text Files ONLY (*.txt) | *.txt"
        SaveIt.ShowDialog()

        Dim W As New IO.StreamWriter(SaveIt.FileName)
        W.Write(lstDisplay.Text)
        W.Close()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub cmbHDD_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbHDD.SelectedIndexChanged

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtName.Text = ""
        txtSurname.Text = ""
        radCrucial.Checked = False
        radEaget.Checked = False
        radSumsung.Checked = False
        cmbHDD.Text = " "
        lstDisplay.Items.Clear()
        chkComputer.Checked = False
        chkGraphicsCard.Checked = False
        chkKeyboard.Checked = False
        chkMonitor.Checked = False
        chkMouse.Checked = False
        chkSpeakers.Checked = False
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class
