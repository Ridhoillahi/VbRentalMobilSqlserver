Imports VB = Microsoft.VisualBasic
Public Class clspelengkap
    'Function untuk membuat penomoran otomatis dengan format angka 6 digit
    Public Function Generate(ByVal Nama_Tabel As String, ByVal Nama_Field As String) As String
        Tabel = Proses.ExecuteQuery("Select * From " & Nama_Tabel & " order by " & Nama_Field & " desc")
        If Tabel.Rows.Count = 0 Then
            Generate = "000001"
        Else
            With Tabel.Rows(0)
                VarStr = Val(.Item(0)) + 1
                VarStr1 = VB.Len(VarStr)
                VarStr2 = "000000"
                VarStr3 = VarStr2.Substring(VarStr1)
                Generate = VarStr3 & Mid(.Item("" & Nama_Field & ""), 2, 6) + 1
            End With
        End If
    End Function
    'Function untuk cek keadaan kolom teks 
    Public Function Isi(ByRef Teks As Object) As Boolean
        If Teks.ToString = "" Then
            Isi = False
            MsgBox("Data tidak boleh kosong, Silahkan cek lagi!", vbExclamation, "Peringatan")
        Else
            Isi = True
        End If
    End Function
    Function TerbilangIndonesia(ByRef Indx As String) As String

        Dim satu(10) As String
        Dim dua(10) As String
        Dim tiga(10) As String
        Dim ratus As String
        Dim ribu As String
        Dim juta As String
        Dim Millyar As String
        Dim Trilliun As String

        satu(0) = "Nol" : satu(1) = "Satu" : satu(2) = "Dua" : satu(3) = "Tiga" : satu(4) = "Empat" : satu(5) = "Lima" : satu(6) = "Enam" : satu(7) = "Tujuh" : satu(8) = "Delapan" : satu(9) = "Sembilan"
        dua(0) = "Sepuluh" : dua(1) = "Sebelas" : dua(2) = "Dua belas" : dua(3) = "Tiga belas" : dua(4) = "Empat Belas" : dua(5) = "Lima Belas" : dua(6) = "Enam Belas" : dua(7) = "Tujuh belas" : dua(8) = "Delapan belas" : dua(9) = "Sembilan belas"
        tiga(2) = "Dua puluh" : tiga(3) = "Tiga puluh" : tiga(4) = "Empat puluh" : tiga(5) = "Lima puluh" : tiga(6) = "Enam Puluh" : tiga(7) = "Tujuh Puluh" : tiga(8) = "Delapan puluh" : tiga(9) = "Sembilan puluh"
        ratus = "ratus" : ribu = "ribu" : juta = "juta"
        Millyar = "millyar" : Trilliun = "trilliun"

        Dim inp, BhsNilai As String

        inp = CStr(Val(Indx))


        Select Case Len(inp)
            Case 1
                BhsNilai = satu(CInt(Indx))

            Case 2
                If Int(CDbl(VB.Right(inp, 1))) > 0 And CDbl(VB.Left(inp, 1)) > 1 Then BhsNilai = TerbilangIndonesia(CStr(Int(CDbl(VB.Right(inp, 1)))))
                If CDbl(VB.Left(inp, 1)) > 1 Then BhsNilai = tiga(CInt(VB.Left(inp, 1))) & BhsNilai
                If CDbl(VB.Left(inp, 1)) = 1 Then BhsNilai = dua(CInt(VB.Right(inp, 1)))
                BhsNilai = Replace(BhsNilai, "Satu ribu", "Seribu")

            Case 3
                BhsNilai = satu(10)
                If Int(CDbl(VB.Right(inp, 2))) > 0 Then BhsNilai = TerbilangIndonesia(CStr(Int(CDbl(VB.Right(inp, 2)))))
                BhsNilai = TerbilangIndonesia(Int(CDbl(VB.Left(inp, 1)))) & ratus & BhsNilai

            Case 4
                If Int(CDbl(VB.Right(inp, 3))) > 0 Then BhsNilai = TerbilangIndonesia(CStr(Int(CDbl(VB.Right(inp, 3)))))
                BhsNilai = TerbilangIndonesia(Int(CDbl(VB.Left(inp, 1)))) & ribu & BhsNilai
                BhsNilai = Replace(BhsNilai, "Satu ribu", "Seribu")

            Case 5
                If Int(CDbl(VB.Right(inp, 3))) > 0 Then BhsNilai = TerbilangIndonesia(CStr(Int(CDbl(VB.Right(inp, 3)))))
                BhsNilai = TerbilangIndonesia(Int(CDbl(VB.Left(inp, 2)))) & ribu & BhsNilai

            Case 6
                If CInt(VB.Right(inp, 3)) > 0 Then BhsNilai = TerbilangIndonesia(CStr(CInt(VB.Right(inp, 3))))
                BhsNilai = TerbilangIndonesia(Int(CDbl(VB.Left(inp, 3)))) & ribu & BhsNilai

            Case 7
                If CInt(VB.Right(inp, 6)) > 0 Then BhsNilai = TerbilangIndonesia(CStr(CInt(VB.Right(inp, 6))))
                BhsNilai = TerbilangIndonesia(Int(CDbl(VB.Left(inp, 1)))) & juta & BhsNilai

            Case 8
                If CInt(VB.Right(inp, 6)) > 0 Then BhsNilai = TerbilangIndonesia(CStr(CInt(VB.Right(inp, 6))))
                BhsNilai = TerbilangIndonesia(Int(CDbl(VB.Left(inp, 2)))) & juta & BhsNilai

            Case 9
                If CInt(VB.Right(inp, 6)) > 0 Then BhsNilai = TerbilangIndonesia(CStr(CInt(VB.Right(inp, 6))))
                BhsNilai = TerbilangIndonesia(Int(CDbl(VB.Left(inp, 3)))) & juta & BhsNilai

            Case 10
                If CInt(VB.Right(inp, 9)) > 0 Then BhsNilai = TerbilangIndonesia(CStr(CInt(VB.Right(inp, 9))))
                BhsNilai = TerbilangIndonesia(Int(CDbl(VB.Left(inp, 1)))) & Millyar & BhsNilai

            Case 11
                If CInt(VB.Right(inp, 9)) > 0 Then BhsNilai = TerbilangIndonesia(CStr(CInt(VB.Right(inp, 9))))
                BhsNilai = TerbilangIndonesia(Int(CDbl(VB.Left(inp, 2)))) & Millyar & BhsNilai

            Case 12
                If Val(VB.Right(inp, 9)) > 0 Then BhsNilai = TerbilangIndonesia(VB.Right(inp, 9))
                BhsNilai = TerbilangIndonesia(Int(CDbl(VB.Left(inp, 3)))) & Millyar & BhsNilai

            Case 13
                If Val(VB.Right(inp, 12)) > 0 Then BhsNilai = TerbilangIndonesia(VB.Right(inp, 12))
                BhsNilai = TerbilangIndonesia(Int(CDbl(VB.Left(inp, 1)))) & Trilliun & BhsNilai

            Case 14
                If Val(VB.Right(inp, 12)) > 0 Then BhsNilai = TerbilangIndonesia(VB.Right(inp, 12))
                BhsNilai = TerbilangIndonesia(Int(CDbl(VB.Left(inp, 2)))) & Trilliun & BhsNilai

            Case 15
                If Val(VB.Right(inp, 12)) > 0 Then BhsNilai = TerbilangIndonesia(VB.Right(inp, 12))
                BhsNilai = TerbilangIndonesia(Int(CDbl(VB.Left(inp, 3)))) & Trilliun & BhsNilai
        End Select

        BhsNilai = Replace(BhsNilai, "Satu ratus", "Seratus")
        BhsNilai = Trim(BhsNilai)

        TerbilangIndonesia = " " & BhsNilai & " "
        TerbilangIndonesia = Replace(TerbilangIndonesia, " ", " ")

    End Function
End Class
