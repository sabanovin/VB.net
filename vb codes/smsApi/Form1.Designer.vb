'========================================================================
' This conversion was produced by the Free Edition of
' Instant VB courtesy of Tangible Software Solutions.
' Order the Premium Edition at https://www.tangiblesoftwaresolutions.com
'========================================================================

Namespace smsApi
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.label1 = New System.Windows.Forms.Label()
			Me.apitxt = New System.Windows.Forms.TextBox()
			Me.gatewaytxt = New System.Windows.Forms.TextBox()
			Me.label2 = New System.Windows.Forms.Label()
			Me.resulttxt = New System.Windows.Forms.TextBox()
			Me.label3 = New System.Windows.Forms.Label()
			Me.button1 = New System.Windows.Forms.Button()
			Me.messageTxt = New System.Windows.Forms.TextBox()
			Me.label4 = New System.Windows.Forms.Label()
			Me.statusCodeTxt = New System.Windows.Forms.TextBox()
			Me.label5 = New System.Windows.Forms.Label()
			Me.resTxt = New System.Windows.Forms.TextBox()
			Me.label6 = New System.Windows.Forms.Label()
			Me.send_single_or_group_sms_btn = New System.Windows.Forms.Button()
			Me.single_group_numbers_txt = New System.Windows.Forms.TextBox()
			Me.label7 = New System.Windows.Forms.Label()
			Me.single_group_sms_txt = New System.Windows.Forms.TextBox()
			Me.label8 = New System.Windows.Forms.Label()
			Me.get_smses_btn = New System.Windows.Forms.Button()
			Me.panel1 = New System.Windows.Forms.Panel()
			Me.panel2 = New System.Windows.Forms.Panel()
			Me.panel3 = New System.Windows.Forms.Panel()
			Me.from_date_get_sms_txt = New System.Windows.Forms.TextBox()
			Me.label9 = New System.Windows.Forms.Label()
			Me.to_date_get_sms_txt = New System.Windows.Forms.TextBox()
			Me.label10 = New System.Windows.Forms.Label()
			Me.panel4 = New System.Windows.Forms.Panel()
			Me.number_add_to_phone_txt = New System.Windows.Forms.TextBox()
			Me.label11 = New System.Windows.Forms.Label()
			Me.group_id = New System.Windows.Forms.TextBox()
			Me.label12 = New System.Windows.Forms.Label()
			Me.add_to_phonebook_btn = New System.Windows.Forms.Button()
			Me.panel5 = New System.Windows.Forms.Panel()
			Me.smes_pair_txt = New System.Windows.Forms.TextBox()
			Me.label13 = New System.Windows.Forms.Label()
			Me.numbers_pair_txt = New System.Windows.Forms.TextBox()
			Me.label14 = New System.Windows.Forms.Label()
			Me.send_pair_pair_sms = New System.Windows.Forms.Button()
			Me.panel3.SuspendLayout()
			Me.panel4.SuspendLayout()
			Me.panel5.SuspendLayout()
			Me.SuspendLayout()
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Location = New System.Drawing.Point(158, 40)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(52, 17)
			Me.label1.TabIndex = 0
			Me.label1.Text = "ApiKey"
			' 
			' apitxt
			' 
			Me.apitxt.Location = New System.Drawing.Point(216, 35)
			Me.apitxt.Name = "apitxt"
			Me.apitxt.Size = New System.Drawing.Size(827, 22)
			Me.apitxt.TabIndex = 1
			Me.apitxt.Text = "sa659126429:mLumyhIpZsDYyIo1PNhiPq9O0UpdZiOYoE6q"
			' 
			' gatewaytxt
			' 
			Me.gatewaytxt.Location = New System.Drawing.Point(216, 65)
			Me.gatewaytxt.Name = "gatewaytxt"
			Me.gatewaytxt.Size = New System.Drawing.Size(827, 22)
			Me.gatewaytxt.TabIndex = 3
			Me.gatewaytxt.Text = "10009398238801"
			' 
			' label2
			' 
			Me.label2.AutoSize = True
			Me.label2.Location = New System.Drawing.Point(147, 68)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(63, 17)
			Me.label2.TabIndex = 2
			Me.label2.Text = "Gateway"
			' 
			' resulttxt
			' 
			Me.resulttxt.Location = New System.Drawing.Point(216, 763)
			Me.resulttxt.Multiline = True
			Me.resulttxt.Name = "resulttxt"
			Me.resulttxt.Size = New System.Drawing.Size(838, 120)
			Me.resulttxt.TabIndex = 4
			' 
			' label3
			' 
			Me.label3.AutoSize = True
			Me.label3.Location = New System.Drawing.Point(128, 766)
			Me.label3.Name = "label3"
			Me.label3.Size = New System.Drawing.Size(82, 17)
			Me.label3.TabIndex = 5
			Me.label3.Text = "Json Result"
			' 
			' button1
			' 
			Me.button1.Location = New System.Drawing.Point(216, 119)
			Me.button1.Name = "button1"
			Me.button1.Size = New System.Drawing.Size(210, 32)
			Me.button1.TabIndex = 6
			Me.button1.Text = "GetBalance"
			Me.button1.UseVisualStyleBackColor = True
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.button1.Click += new System.EventHandler(this.button1_Click);
			' 
			' messageTxt
			' 
			Me.messageTxt.Location = New System.Drawing.Point(216, 735)
			Me.messageTxt.Name = "messageTxt"
			Me.messageTxt.Size = New System.Drawing.Size(827, 22)
			Me.messageTxt.TabIndex = 8
			' 
			' label4
			' 
			Me.label4.AutoSize = True
			Me.label4.Location = New System.Drawing.Point(147, 738)
			Me.label4.Name = "label4"
			Me.label4.Size = New System.Drawing.Size(65, 17)
			Me.label4.TabIndex = 7
			Me.label4.Text = "Message"
			' 
			' statusCodeTxt
			' 
			Me.statusCodeTxt.Location = New System.Drawing.Point(216, 707)
			Me.statusCodeTxt.Name = "statusCodeTxt"
			Me.statusCodeTxt.Size = New System.Drawing.Size(827, 22)
			Me.statusCodeTxt.TabIndex = 10
			' 
			' label5
			' 
			Me.label5.AutoSize = True
			Me.label5.Location = New System.Drawing.Point(125, 710)
			Me.label5.Name = "label5"
			Me.label5.Size = New System.Drawing.Size(85, 17)
			Me.label5.TabIndex = 9
			Me.label5.Text = "Status Code"
			' 
			' resTxt
			' 
			Me.resTxt.Location = New System.Drawing.Point(216, 679)
			Me.resTxt.Name = "resTxt"
			Me.resTxt.Size = New System.Drawing.Size(827, 22)
			Me.resTxt.TabIndex = 12
			' 
			' label6
			' 
			Me.label6.AutoSize = True
			Me.label6.Location = New System.Drawing.Point(162, 682)
			Me.label6.Name = "label6"
			Me.label6.Size = New System.Drawing.Size(48, 17)
			Me.label6.TabIndex = 11
			Me.label6.Text = "Result"
			' 
			' send_single_or_group_sms_btn
			' 
			Me.send_single_or_group_sms_btn.Location = New System.Drawing.Point(216, 173)
			Me.send_single_or_group_sms_btn.Name = "send_single_or_group_sms_btn"
			Me.send_single_or_group_sms_btn.Size = New System.Drawing.Size(210, 32)
			Me.send_single_or_group_sms_btn.TabIndex = 13
			Me.send_single_or_group_sms_btn.Text = "Send Single Or Group Sms"
			Me.send_single_or_group_sms_btn.UseVisualStyleBackColor = True
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.send_single_or_group_sms_btn.Click += new System.EventHandler(this.send_single_or_group_sms_btn_Click);
			' 
			' single_group_numbers_txt
			' 
			Me.single_group_numbers_txt.Location = New System.Drawing.Point(789, 178)
			Me.single_group_numbers_txt.Name = "single_group_numbers_txt"
			Me.single_group_numbers_txt.Size = New System.Drawing.Size(346, 22)
			Me.single_group_numbers_txt.TabIndex = 15
			' 
			' label7
			' 
			Me.label7.AutoSize = True
			Me.label7.Location = New System.Drawing.Point(431, 181)
			Me.label7.Name = "label7"
			Me.label7.Size = New System.Drawing.Size(345, 17)
			Me.label7.TabIndex = 14
			Me.label7.Text = "Your Numbers:example(09398238801,09175555555)"
			' 
			' single_group_sms_txt
			' 
			Me.single_group_sms_txt.Location = New System.Drawing.Point(1228, 178)
			Me.single_group_sms_txt.Multiline = True
			Me.single_group_sms_txt.Name = "single_group_sms_txt"
			Me.single_group_sms_txt.Size = New System.Drawing.Size(271, 83)
			Me.single_group_sms_txt.TabIndex = 17
			' 
			' label8
			' 
			Me.label8.AutoSize = True
			Me.label8.Location = New System.Drawing.Point(1153, 181)
			Me.label8.Name = "label8"
			Me.label8.Size = New System.Drawing.Size(69, 17)
			Me.label8.TabIndex = 16
			Me.label8.Text = "Your Text"
			' 
			' get_smses_btn
			' 
			Me.get_smses_btn.Location = New System.Drawing.Point(55, 13)
			Me.get_smses_btn.Name = "get_smses_btn"
			Me.get_smses_btn.Size = New System.Drawing.Size(210, 32)
			Me.get_smses_btn.TabIndex = 18
			Me.get_smses_btn.Text = "Get Smses"
			Me.get_smses_btn.UseVisualStyleBackColor = True
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.get_smses_btn.Click += new System.EventHandler(this.get_smses_btn_Click);
			' 
			' panel1
			' 
			Me.panel1.BackColor = System.Drawing.Color.MistyRose
			Me.panel1.Location = New System.Drawing.Point(161, 113)
			Me.panel1.Name = "panel1"
			Me.panel1.Size = New System.Drawing.Size(1338, 43)
			Me.panel1.TabIndex = 19
			' 
			' panel2
			' 
			Me.panel2.BackColor = System.Drawing.Color.Khaki
			Me.panel2.Location = New System.Drawing.Point(161, 164)
			Me.panel2.Name = "panel2"
			Me.panel2.Size = New System.Drawing.Size(1338, 113)
			Me.panel2.TabIndex = 20
			' 
			' panel3
			' 
			Me.panel3.BackColor = System.Drawing.Color.LightBlue
			Me.panel3.Controls.Add(Me.to_date_get_sms_txt)
			Me.panel3.Controls.Add(Me.label10)
			Me.panel3.Controls.Add(Me.from_date_get_sms_txt)
			Me.panel3.Controls.Add(Me.label9)
			Me.panel3.Controls.Add(Me.get_smses_btn)
			Me.panel3.Location = New System.Drawing.Point(161, 307)
			Me.panel3.Name = "panel3"
			Me.panel3.Size = New System.Drawing.Size(1338, 55)
			Me.panel3.TabIndex = 20
			' 
			' from_date_get_sms_txt
			' 
			Me.from_date_get_sms_txt.Location = New System.Drawing.Point(502, 18)
			Me.from_date_get_sms_txt.Name = "from_date_get_sms_txt"
			Me.from_date_get_sms_txt.Size = New System.Drawing.Size(113, 22)
			Me.from_date_get_sms_txt.TabIndex = 22
			' 
			' label9
			' 
			Me.label9.AutoSize = True
			Me.label9.Location = New System.Drawing.Point(289, 21)
			Me.label9.Name = "label9"
			Me.label9.Size = New System.Drawing.Size(213, 17)
			Me.label9.TabIndex = 21
			Me.label9.Text = "From Date:Exapmle(1397/04/05)"
			' 
			' to_date_get_sms_txt
			' 
			Me.to_date_get_sms_txt.Location = New System.Drawing.Point(838, 18)
			Me.to_date_get_sms_txt.Name = "to_date_get_sms_txt"
			Me.to_date_get_sms_txt.Size = New System.Drawing.Size(113, 22)
			Me.to_date_get_sms_txt.TabIndex = 24
			' 
			' label10
			' 
			Me.label10.AutoSize = True
			Me.label10.Location = New System.Drawing.Point(625, 21)
			Me.label10.Name = "label10"
			Me.label10.Size = New System.Drawing.Size(198, 17)
			Me.label10.TabIndex = 23
			Me.label10.Text = "To Date:Exapmle(1397/05/12)"
			' 
			' panel4
			' 
			Me.panel4.BackColor = System.Drawing.Color.Plum
			Me.panel4.Controls.Add(Me.number_add_to_phone_txt)
			Me.panel4.Controls.Add(Me.label11)
			Me.panel4.Controls.Add(Me.group_id)
			Me.panel4.Controls.Add(Me.label12)
			Me.panel4.Controls.Add(Me.add_to_phonebook_btn)
			Me.panel4.Location = New System.Drawing.Point(161, 386)
			Me.panel4.Name = "panel4"
			Me.panel4.Size = New System.Drawing.Size(1338, 55)
			Me.panel4.TabIndex = 25
			' 
			' number_add_to_phone_txt
			' 
			Me.number_add_to_phone_txt.Location = New System.Drawing.Point(553, 18)
			Me.number_add_to_phone_txt.Name = "number_add_to_phone_txt"
			Me.number_add_to_phone_txt.Size = New System.Drawing.Size(141, 22)
			Me.number_add_to_phone_txt.TabIndex = 24
			' 
			' label11
			' 
			Me.label11.AutoSize = True
			Me.label11.Location = New System.Drawing.Point(489, 21)
			Me.label11.Name = "label11"
			Me.label11.Size = New System.Drawing.Size(58, 17)
			Me.label11.TabIndex = 23
			Me.label11.Text = "Number"
			' 
			' group_id
			' 
			Me.group_id.Location = New System.Drawing.Point(359, 18)
			Me.group_id.Name = "group_id"
			Me.group_id.Size = New System.Drawing.Size(113, 22)
			Me.group_id.TabIndex = 22
			' 
			' label12
			' 
			Me.label12.AutoSize = True
			Me.label12.Location = New System.Drawing.Point(289, 21)
			Me.label12.Name = "label12"
			Me.label12.Size = New System.Drawing.Size(64, 17)
			Me.label12.TabIndex = 21
			Me.label12.Text = "group_id"
			' 
			' add_to_phonebook_btn
			' 
			Me.add_to_phonebook_btn.Location = New System.Drawing.Point(55, 13)
			Me.add_to_phonebook_btn.Name = "add_to_phonebook_btn"
			Me.add_to_phonebook_btn.Size = New System.Drawing.Size(210, 32)
			Me.add_to_phonebook_btn.TabIndex = 18
			Me.add_to_phonebook_btn.Text = "Add To Phonebook"
			Me.add_to_phonebook_btn.UseVisualStyleBackColor = True
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.add_to_phonebook_btn.Click += new System.EventHandler(this.add_to_phonebook_btn_Click);
			' 
			' panel5
			' 
			Me.panel5.BackColor = System.Drawing.Color.LightSlateGray
			Me.panel5.Controls.Add(Me.smes_pair_txt)
			Me.panel5.Controls.Add(Me.label13)
			Me.panel5.Controls.Add(Me.numbers_pair_txt)
			Me.panel5.Controls.Add(Me.label14)
			Me.panel5.Controls.Add(Me.send_pair_pair_sms)
			Me.panel5.Location = New System.Drawing.Point(161, 458)
			Me.panel5.Name = "panel5"
			Me.panel5.Size = New System.Drawing.Size(1338, 174)
			Me.panel5.TabIndex = 26
			' 
			' smes_pair_txt
			' 
			Me.smes_pair_txt.Location = New System.Drawing.Point(1067, 16)
			Me.smes_pair_txt.Multiline = True
			Me.smes_pair_txt.Name = "smes_pair_txt"
			Me.smes_pair_txt.Size = New System.Drawing.Size(252, 96)
			Me.smes_pair_txt.TabIndex = 24
			' 
			' label13
			' 
			Me.label13.AutoSize = True
			Me.label13.Location = New System.Drawing.Point(843, 21)
			Me.label13.Name = "label13"
			Me.label13.Size = New System.Drawing.Size(215, 17)
			Me.label13.TabIndex = 23
			Me.label13.Text = "Your Textes:Example(text1,text2)"
			' 
			' numbers_pair_txt
			' 
			Me.numbers_pair_txt.Location = New System.Drawing.Point(606, 18)
			Me.numbers_pair_txt.Multiline = True
			Me.numbers_pair_txt.Name = "numbers_pair_txt"
			Me.numbers_pair_txt.Size = New System.Drawing.Size(231, 94)
			Me.numbers_pair_txt.TabIndex = 22
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.numbers_pair_txt.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
			' 
			' label14
			' 
			Me.label14.AutoSize = True
			Me.label14.Location = New System.Drawing.Point(289, 21)
			Me.label14.Name = "label14"
			Me.label14.Size = New System.Drawing.Size(311, 17)
			Me.label14.TabIndex = 21
			Me.label14.Text = "Numbers:example(09398238801,09399999999)"
			' 
			' send_pair_pair_sms
			' 
			Me.send_pair_pair_sms.Location = New System.Drawing.Point(55, 13)
			Me.send_pair_pair_sms.Name = "send_pair_pair_sms"
			Me.send_pair_pair_sms.Size = New System.Drawing.Size(210, 32)
			Me.send_pair_pair_sms.TabIndex = 18
			Me.send_pair_pair_sms.Text = "Send Pair to Pair Sms"
			Me.send_pair_pair_sms.UseVisualStyleBackColor = True
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.send_pair_pair_sms.Click += new System.EventHandler(this.send_pair_pair_sms_Click);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(8F, 16F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(1538, 1017)
			Me.Controls.Add(Me.panel5)
			Me.Controls.Add(Me.panel4)
			Me.Controls.Add(Me.panel3)
			Me.Controls.Add(Me.single_group_sms_txt)
			Me.Controls.Add(Me.label8)
			Me.Controls.Add(Me.single_group_numbers_txt)
			Me.Controls.Add(Me.label7)
			Me.Controls.Add(Me.send_single_or_group_sms_btn)
			Me.Controls.Add(Me.resTxt)
			Me.Controls.Add(Me.label6)
			Me.Controls.Add(Me.statusCodeTxt)
			Me.Controls.Add(Me.label5)
			Me.Controls.Add(Me.messageTxt)
			Me.Controls.Add(Me.label4)
			Me.Controls.Add(Me.button1)
			Me.Controls.Add(Me.label3)
			Me.Controls.Add(Me.resulttxt)
			Me.Controls.Add(Me.gatewaytxt)
			Me.Controls.Add(Me.label2)
			Me.Controls.Add(Me.apitxt)
			Me.Controls.Add(Me.label1)
			Me.Controls.Add(Me.panel1)
			Me.Controls.Add(Me.panel2)
			Me.Name = "Form1"
			Me.Text = "Form1"
			Me.panel3.ResumeLayout(False)
			Me.panel3.PerformLayout()
			Me.panel4.ResumeLayout(False)
			Me.panel4.PerformLayout()
			Me.panel5.ResumeLayout(False)
			Me.panel5.PerformLayout()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private label1 As System.Windows.Forms.Label
		Private apitxt As System.Windows.Forms.TextBox
		Private gatewaytxt As System.Windows.Forms.TextBox
		Private label2 As System.Windows.Forms.Label
		Private resulttxt As System.Windows.Forms.TextBox
		Private label3 As System.Windows.Forms.Label
		Private WithEvents button1 As System.Windows.Forms.Button
		Private messageTxt As System.Windows.Forms.TextBox
		Private label4 As System.Windows.Forms.Label
		Private statusCodeTxt As System.Windows.Forms.TextBox
		Private label5 As System.Windows.Forms.Label
		Private resTxt As System.Windows.Forms.TextBox
		Private label6 As System.Windows.Forms.Label
		Private WithEvents send_single_or_group_sms_btn As System.Windows.Forms.Button
		Private single_group_numbers_txt As System.Windows.Forms.TextBox
		Private label7 As System.Windows.Forms.Label
		Private single_group_sms_txt As System.Windows.Forms.TextBox
		Private label8 As System.Windows.Forms.Label
		Private WithEvents get_smses_btn As System.Windows.Forms.Button
		Private panel1 As System.Windows.Forms.Panel
		Private panel2 As System.Windows.Forms.Panel
		Private panel3 As System.Windows.Forms.Panel
		Private to_date_get_sms_txt As System.Windows.Forms.TextBox
		Private label10 As System.Windows.Forms.Label
		Private from_date_get_sms_txt As System.Windows.Forms.TextBox
		Private label9 As System.Windows.Forms.Label
		Private panel4 As System.Windows.Forms.Panel
		Private number_add_to_phone_txt As System.Windows.Forms.TextBox
		Private label11 As System.Windows.Forms.Label
		Private group_id As System.Windows.Forms.TextBox
		Private label12 As System.Windows.Forms.Label
		Private WithEvents add_to_phonebook_btn As System.Windows.Forms.Button
		Private panel5 As System.Windows.Forms.Panel
		Private smes_pair_txt As System.Windows.Forms.TextBox
		Private label13 As System.Windows.Forms.Label
		Private WithEvents numbers_pair_txt As System.Windows.Forms.TextBox
		Private label14 As System.Windows.Forms.Label
		Private WithEvents send_pair_pair_sms As System.Windows.Forms.Button
	End Class
End Namespace

