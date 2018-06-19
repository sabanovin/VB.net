'========================================================================
' This conversion was produced by the Free Edition of
' Instant VB courtesy of Tangible Software Solutions.
' Order the Premium Edition at https://www.tangiblesoftwaresolutions.com
'========================================================================

Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Net
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms

Namespace smsApi
	Partial Public Class Form1
		Inherits Form

		Public api_key, gateway As String
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub get_init_paramters()
			If apitxt.Text = "" OrElse gatewaytxt.Text = "" Then
				MessageBox.Show("api key and gateway cant be null")
			End If
			api_key = apitxt.Text
			gateway = gatewaytxt.Text
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			get_init_paramters()
			Dim webClient As New WebClient()
			Dim url As String = "https://api.sabanovin.com/v1/" & api_key & "/account/balance.json"
			Dim result As String = webClient.DownloadString(url)
			resulttxt.Text = result
			Dim obj As JObject = JObject.Parse(result)
			resTxt.Text = obj("entry")("balance").ToString()
			statusCodeTxt.Text = obj("status")("code").ToString()
			' Fix UTF-8 Encoding
			Dim message As String = obj("status")("message").ToString()
			Dim bytes() As Byte = Encoding.Default.GetBytes(message)
			message = Encoding.UTF8.GetString(bytes)
			messageTxt.Text = message
		End Sub

		Private Sub send_single_or_group_sms_btn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles send_single_or_group_sms_btn.Click
			get_init_paramters()
			Dim url As String = "https://api.sabanovin.com/v1/" & api_key & "/sms/send.json?gateway=" & gateway & "&to=" & single_group_numbers_txt.Text & "&text=" & single_group_sms_txt.Text
			Dim webClient As New WebClient()
			Dim result As String = webClient.DownloadString(url)
			resulttxt.Text = result
			Dim obj As JObject = JObject.Parse(result)
			resTxt.Text = "reference_id = " & obj("entries")(0)("reference_id").ToString()
			statusCodeTxt.Text = obj("status")("code").ToString()
			' Fix UTF-8 Encoding
			Dim message As String = obj("status")("message").ToString()
			Dim bytes() As Byte = Encoding.Default.GetBytes(message)
			message = Encoding.UTF8.GetString(bytes)
			messageTxt.Text = message
		End Sub

		Private Sub get_smses_btn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles get_smses_btn.Click
			get_init_paramters()
			Dim url As String = ""
			If from_date_get_sms_txt.Text <> "" Then
				If to_date_get_sms_txt.Text <> "" Then
					url = "https://api.sabanovin.com/v1/" & api_key & "/sms/receive.json?gateway=" & gateway & "&is_read=0&from_date=" & from_date_get_sms_txt.Text &"&to_date=" & to_date_get_sms_txt.Text
				Else
					url = "https://api.sabanovin.com/v1/" & api_key & "/sms/receive.json?gateway=" & gateway & "&is_read=0&from_date=" & from_date_get_sms_txt.Text
				End If
			Else
				url = "https://api.sabanovin.com/v1/" & api_key & "/sms/receive.json?gateway=" & gateway & "&is_read=0"
			End If
			System.Console.WriteLine(url)
			Dim webClient As New WebClient()
			Dim result As String = webClient.DownloadString(url)
			resulttxt.Text = result
			Dim obj As JObject = JObject.Parse(result)
			If obj("entries").Count() <> 0 Then
				resTxt.Text = "reference_id = " & obj("entries")(0)("reference_id").ToString()
			End If
			statusCodeTxt.Text = obj("status")("code").ToString()
			' Fix UTF-8 Encoding
			Dim message As String = obj("status")("message").ToString()
			Dim bytes() As Byte = Encoding.Default.GetBytes(message)
			message = Encoding.UTF8.GetString(bytes)
			messageTxt.Text = message
		End Sub

		Private Sub add_to_phonebook_btn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles add_to_phonebook_btn.Click
			get_init_paramters()
			Dim url As String = "https://api.sabanovin.com/v1/" & api_key & "/utils/add_contact.json?group_id=" & group_id.Text & "&number=" & number_add_to_phone_txt.Text
			Dim webClient As New WebClient()
			Dim result As String = webClient.DownloadString(url)
			resulttxt.Text = result
			Dim obj As JObject = JObject.Parse(result)
			statusCodeTxt.Text = obj("status")("code").ToString()
			' Fix UTF-8 Encoding
			Dim message As String = obj("status")("message").ToString()
			Dim bytes() As Byte = Encoding.Default.GetBytes(message)
			message = Encoding.UTF8.GetString(bytes)
			messageTxt.Text = message
		End Sub

		Private Sub textBox2_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles numbers_pair_txt.TextChanged

		End Sub

		Private Sub send_pair_pair_sms_Click(ByVal sender As Object, ByVal e As EventArgs) Handles send_pair_pair_sms.Click
			get_init_paramters()
			Dim numbers() As String
			numbers = numbers_pair_txt.Text.Split(","c)
			Dim textes() As String
			textes = smes_pair_txt.Text.Split(","c)
			If textes.Count() <> numbers.Count() Then
				MessageBox.Show("number and textes are not equal")
			End If
			Dim paramters = New With {
				Key .gateway = gateway,
				Key .to = numbers,
				Key .text = textes
			}
			Using client = New WebClient()
				Dim dataString = JsonConvert.SerializeObject(paramters)
				client.Headers.Add(HttpRequestHeader.ContentType, "application/json")
				Dim result As String = client.UploadString(New Uri("https://api.sabanovin.com/v1/" & api_key &"/sms/send_array.json"), "POST", dataString)
				resulttxt.Text = result
				Dim obj As JObject = JObject.Parse(result)
				If obj("entries").Count() <> 0 Then
					resTxt.Text = "reference_id = " & obj("entries")(0)("reference_id").ToString()
				End If
				statusCodeTxt.Text = obj("status")("code").ToString()
				' Fix UTF-8 Encoding
				Dim message As String = obj("status")("message").ToString()
				Dim bytes() As Byte = Encoding.Default.GetBytes(message)
				message = Encoding.UTF8.GetString(bytes)
				messageTxt.Text = message
			End Using
		End Sub
	End Class
End Namespace
