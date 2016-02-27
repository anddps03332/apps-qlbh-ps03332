Public Class frmCustomerAndProductInformation
    Private Sub tsmiExit_Click(sender As Object, e As EventArgs) Handles tsmiExit.Click
        Me.Close()
    End Sub
    Private Sub tsmiCustomer_Click(sender As Object, e As EventArgs) Handles tsmiCustomer.Click
        frmUpdateCustomer.Show()
    End Sub

    Private Sub tsmiProduct_Click(sender As Object, e As EventArgs) Handles tsmiProduct.Click
        frmUpdateProduct.Show()
    End Sub

    Private Sub btnSeachCustomer_Click_1(sender As Object, e As EventArgs) Handles btnSeachCustomer.Click
        frmCustomerSeach.Show()
    End Sub

    Private Sub btnSeachProductCode_Click_1(sender As Object, e As EventArgs) Handles btnSeachProductCode.Click
        frmProductSeach.Show()
    End Sub
End Class