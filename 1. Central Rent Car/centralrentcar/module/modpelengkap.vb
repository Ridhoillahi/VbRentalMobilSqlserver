Module modpelengkap
    Public umur As Long
    Public lapor As String
    Public SQl As String
    Public Tabel As DataTable
    Public Proses As New clskoneksi
    Public Kode As New clspelengkap
    Public Pelengkap As New clspelengkap
    Public VarStr, VarStr1, VarStr2, VarStr3 As String
    Public Status, Posisi_Record As Boolean
    Public Diskon As Single
    Public No, Stock, Stock_Awal, Jml_Beli, Jml_Return, Jml_Jual, Sub_Total, No_Kartu As Integer
    Public Pengguna As String


    ' Public Tabel As DataTable
    'Public Proses As New ClsKoneksiDatabase
    'Mengosongkan isi teks pada form keseluruhan
    Public Sub KosongkanIsiText(ByVal x As Form)
        For Each i As Control In x.Controls
            If TypeOf (i) Is TextBox Then
                i.Text = ""
                i.Focus()
            End If
        Next
    End Sub

    'Mengosongkan isi teks combobox pada form seluruh
    Public Sub KosongkanIsiCombo(ByVal x As Form)
        For Each i As Control In x.Controls
            If TypeOf (i) Is ComboBox Then
                i.Text = ""
            End If
        Next
    End Sub



End Module
