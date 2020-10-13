Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports System.IO
Imports System.Net
Imports System.Net.Http
Imports System.Text
Imports System.Web.Script.Serialization
Imports System.Threading
Imports System.Globalization
Imports System.Text.RegularExpressions
'/*
'/////////////////////////////////////////
'////   Author By Project AM
'////   GITHUB : https://github.com/am-523
'////   FB : https://web.facebook.com/crypter.server.zombie/
'//////////////////////////////////////////
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RichTextBox2.Font = New Font("Scheherazade", 15.0, FontStyle.Regular)
        Terjemahan()
        'QuranSurat()
        ' suratayat()
        '  showhtml()
        '  suratayat()
        showhtmll()
        QuranSurat()
    End Sub

    Public Function ConvertUnicodeForRTF(ByVal rtfUnicode As String) As String
        Dim regNonAscii As Regex = New Regex("[^\x00-\x7F]")
        Dim mc As MatchCollection = regNonAscii.Matches(rtfUnicode)
        Dim foundMatch As Match
        Dim insert As String

        If mc.Count = 0 Then
            Return rtfUnicode
        End If

        For i As Integer = mc.Count - 1 To -1 + 1
            foundMatch = mc(i)
            Dim c As Char = foundMatch.Value(0)
            Dim dec As Integer = Convert.ToInt32(c)
            rtfUnicode = rtfUnicode.Remove(foundMatch.Index, 1)
            insert = "\u" & dec.ToString() & "?"
            rtfUnicode = rtfUnicode.Insert(foundMatch.Index, insert)
        Next

        Return rtfUnicode
    End Function
    Private Sub showhtml()
        With WebBrowser1
            .Stop()
            .Document.OpenNew(False)
            .Document.Write(RichTextBox1.Text)
            .Refresh()
            .AllowNavigation = False
        End With
    End Sub
    Private Sub showhtmll()
        With WebBrowser2
            .Stop()
            .Document.OpenNew(False)
            .Document.Write(RichTextBox2.Text)
            .Refresh()
            .AllowNavigation = False
        End With
    End Sub

    Private Sub suratayat()
        Dim request As HttpWebRequest
        Dim response As HttpWebResponse = Nothing
        Dim reader As StreamReader
        Dim rawresp As String
        Dim str As String = TextBox1.Text
        Try
            request = DirectCast(WebRequest.Create("https://equran.id/api/surat/" & TextBox1.Text), HttpWebRequest)
            response = DirectCast(request.GetResponse(), HttpWebResponse)
            reader = New StreamReader(response.GetResponseStream())
            rawresp = reader.ReadToEnd()
            Label1.Text = JObject.Parse(rawresp)("nama_latin")
            RichTextBox1.Text = JObject.Parse(rawresp)("deskripsi")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub
    'Private Sub Surat()
    '    Dim json As String = (New WebClient).DownloadString("https://equran.id/api/surat/114")
    '    Dim jarr As Linq.JArray = Linq.JArray.Parse(json)
    '    For Each jtk As JToken In jarr
    '        RichTextBox1.Text = jtk.SelectToken("nama_latin")
    '    Next
    'End Sub

    Private Sub QuranSurat()
        Dim json As String = (New WebClient).DownloadString("https://equran.id/api/surat")
        Dim jarr As Linq.JArray = Linq.JArray.Parse(json)
        Dim sNomor, sNamaLatin, sJumlahAyat As String


        For Each jtk As JToken In jarr
            sNomor = jtk.SelectToken("nomor")
            sNamaLatin = jtk.SelectToken("nama_latin")
            sJumlahAyat = jtk.SelectToken("jumlah_ayat")
            DgvSurah.Rows.Add()
            DgvSurah.Rows(DgvSurah.Rows.Count - 1).Cells("DgvNomor").Value = sNomor
            DgvSurah.Rows(DgvSurah.Rows.Count - 1).Cells("DgvNamaLatin").Value = sNamaLatin
            DgvSurah.Rows(DgvSurah.Rows.Count - 1).Cells("DgvJumlahAyat").Value = Val(sJumlahAyat)
        Next

    End Sub

    Private Sub Terjemahan()
        Dim json As String = (New WebClient).DownloadString("https://equran.id/api/surat/1")
        Dim jarq As Linq.JArray = JObject.Parse(json)("ayat")
        Dim nomor, tr, ar, idn As String
        Dim token As JToken
        For Each value As Object In jarq
            token = JObject.Parse(value.ToString())
            nomor = token.SelectToken("nomor")
            ar = token.SelectToken("ar")
            tr = token.SelectToken("tr")
            idn = token.SelectToken("idn")
            Dim jurq As String = "Suroh " & Environment.NewLine & ar & "<br><br><br>" & "Ayat " & Environment.NewLine & nomor & "<br><br><br>" & "Terjemahan : " & tr & Environment.NewLine & " <br><br><br>Artinya : " & idn
            RichTextBox2.Rtf = RichTextBox2.Rtf.Replace(ar, ConvertUnicodeForRTF(jurq))
            RichTextBox2.Text = jurq
            'lblarab.Text = ar
        Next

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        suratayat()
        showhtml()
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
    Dim str As System.IO.Stream = My.Resources._001AlFaatihah__online_audio_converter_com_
    Dim snd As System.Media.SoundPlayer = New System.Media.SoundPlayer(str)
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        snd.Play()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        snd.Stop()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        For Each ci As CultureInfo In CultureInfo.GetCultures(CultureTypes.AllCultures)
            MsgBox(ci.EnglishName + " - " + ci.Name)
        Next
    End Sub
End Class
