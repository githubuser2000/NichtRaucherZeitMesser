<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class zigarettenmesser
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            Dim schreiber As New Xml.XmlTextWriter(xml_dir + "zigarettenmesser.xml", New System.Text.UnicodeEncoding)
            With schreiber

                .WriteStartDocument()
                .WriteStartElement("zigarettenmesser")

                .WriteStartElement("datum")
                .WriteAttributeString("jahr", b_jahr.Text)
                .WriteAttributeString("monat", b_monat.Text)
                .WriteAttributeString("tag", b_tag.Text)
                .WriteEndElement()

                .WriteStartElement("uhrzeit")
                .WriteAttributeString("stunde", b_stunde.Text)
                .WriteAttributeString("minute", b_minute.Text)
                .WriteEndElement()

                .WriteStartElement("rauchdaten")
                .WriteAttributeString("schachteln", b_schachteln_pro_tag.Text)
                .WriteAttributeString("schachtelpreis", b_preis_pro_Schachtel.Text)
                .WriteAttributeString("tabbakpreis", b_Tabakwoche.Text)
                .WriteEndElement()

                .WriteStartElement("zigarettendauer")
                .WriteAttributeString("pro", b_rauchdauer.Text)
                .WriteAttributeString("anzahl", b_stueck.Text)
                .WriteEndElement()

                .WriteStartElement("ausgabevariante")
                .WriteAttributeString("monat", RadioButton2.Checked.ToString)
                .WriteEndElement()
                .Close()
            End With
        Catch ex As Exception
        End Try



        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(zigarettenmesser))
        Me.Label1 = New System.Windows.Forms.Label
        Me.b_tag = New System.Windows.Forms.TextBox
        Me.b_monat = New System.Windows.Forms.TextBox
        Me.b_jahr = New System.Windows.Forms.TextBox
        Me.b_stunde = New System.Windows.Forms.TextBox
        Me.b_minute = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.b_rauchdauer = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Zeittext = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.b_stueck = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.RadioButton3 = New System.Windows.Forms.RadioButton
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.b_tabbaksumme = New System.Windows.Forms.TextBox
        Me.b_schachtelsumme = New System.Windows.Forms.TextBox
        Me.b_preis_pro_Schachtel = New System.Windows.Forms.TextBox
        Me.b_schachteln_pro_tag = New System.Windows.Forms.TextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.b_Tabakwoche = New System.Windows.Forms.TextBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.l_Herzinfarktrisiko = New System.Windows.Forms.Label
        Me.l_lunge_regeneriert = New System.Windows.Forms.Label
        Me.l_krebs = New System.Windows.Forms.Label
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.Label34 = New System.Windows.Forms.Label
        Me.Label33 = New System.Windows.Forms.Label
        Me.Label31 = New System.Windows.Forms.Label
        Me.Label32 = New System.Windows.Forms.Label
        Me.b_c = New System.Windows.Forms.TextBox
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel
        Me.Label30 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.b_nichtraucherprozent = New System.Windows.Forms.TextBox
        Me.Label25 = New System.Windows.Forms.Label
        Me.b_b = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.b_a = New System.Windows.Forms.TextBox
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.Label37 = New System.Windows.Forms.Label
        Me.Label36 = New System.Windows.Forms.Label
        Me.Label35 = New System.Windows.Forms.Label
        Me.rauchen_beendet = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(16, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "_"
        '
        'b_tag
        '
        Me.b_tag.Location = New System.Drawing.Point(145, 21)
        Me.b_tag.Name = "b_tag"
        Me.b_tag.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.b_tag.Size = New System.Drawing.Size(25, 20)
        Me.b_tag.TabIndex = 6
        Me.b_tag.Text = "5"
        '
        'b_monat
        '
        Me.b_monat.Location = New System.Drawing.Point(176, 21)
        Me.b_monat.Name = "b_monat"
        Me.b_monat.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.b_monat.Size = New System.Drawing.Size(25, 20)
        Me.b_monat.TabIndex = 7
        Me.b_monat.Text = "6"
        '
        'b_jahr
        '
        Me.b_jahr.Location = New System.Drawing.Point(207, 21)
        Me.b_jahr.Name = "b_jahr"
        Me.b_jahr.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.b_jahr.Size = New System.Drawing.Size(38, 20)
        Me.b_jahr.TabIndex = 8
        Me.b_jahr.Text = "2008"
        '
        'b_stunde
        '
        Me.b_stunde.Location = New System.Drawing.Point(145, 47)
        Me.b_stunde.Name = "b_stunde"
        Me.b_stunde.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.b_stunde.Size = New System.Drawing.Size(25, 20)
        Me.b_stunde.TabIndex = 101
        Me.b_stunde.Text = "20"
        '
        'b_minute
        '
        Me.b_minute.Location = New System.Drawing.Point(176, 47)
        Me.b_minute.Name = "b_minute"
        Me.b_minute.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.b_minute.Size = New System.Drawing.Size(25, 20)
        Me.b_minute.TabIndex = 100
        Me.b_minute.Text = "00"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(168, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(11, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = ":"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(169, 28)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(11, 13)
        Me.Label7.TabIndex = 102
        Me.Label7.Text = "."
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(199, 28)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(11, 13)
        Me.Label8.TabIndex = 103
        Me.Label8.Text = "."
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 24)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 13)
        Me.Label9.TabIndex = 104
        Me.Label9.Text = "am (Datum)"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 50)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(63, 13)
        Me.Label10.TabIndex = 105
        Me.Label10.Text = "um (Uhrzeit)"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(263, 28)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(56, 13)
        Me.Label11.TabIndex = 107
        Me.Label11.Text = "wurde das"
        '
        'b_rauchdauer
        '
        Me.b_rauchdauer.Location = New System.Drawing.Point(148, 23)
        Me.b_rauchdauer.Name = "b_rauchdauer"
        Me.b_rauchdauer.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.b_rauchdauer.Size = New System.Drawing.Size(25, 20)
        Me.b_rauchdauer.TabIndex = 109
        Me.b_rauchdauer.Text = "5"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 26)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(129, 13)
        Me.Label13.TabIndex = 110
        Me.Label13.Text = "Rauchdauer pro Zigarette"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(179, 26)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(45, 13)
        Me.Label14.TabIndex = 111
        Me.Label14.Text = "Minuten"
        '
        'Zeittext
        '
        Me.Zeittext.AutoSize = True
        Me.Zeittext.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Zeittext.Location = New System.Drawing.Point(6, 72)
        Me.Zeittext.Name = "Zeittext"
        Me.Zeittext.Size = New System.Drawing.Size(15, 15)
        Me.Zeittext.TabIndex = 112
        Me.Zeittext.Text = "_"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(179, 50)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(35, 13)
        Me.Label16.TabIndex = 115
        Me.Label16.Text = "Stück"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(6, 50)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(95, 13)
        Me.Label17.TabIndex = 114
        Me.Label17.Text = "Zigaretten pro Tag"
        '
        'b_stueck
        '
        Me.b_stueck.Location = New System.Drawing.Point(148, 47)
        Me.b_stueck.Name = "b_stueck"
        Me.b_stueck.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.b_stueck.Size = New System.Drawing.Size(25, 20)
        Me.b_stueck.TabIndex = 113
        Me.b_stueck.Text = "25"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.RadioButton3)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.b_tag)
        Me.GroupBox1.Controls.Add(Me.b_monat)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.b_jahr)
        Me.GroupBox1.Controls.Add(Me.b_minute)
        Me.GroupBox1.Controls.Add(Me.b_stunde)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(275, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(331, 134)
        Me.GroupBox1.TabIndex = 117
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Rauchen beendet"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(225, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 13)
        Me.Label3.TabIndex = 112
        Me.Label3.Text = "Rauchen beendet"
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(145, 105)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(106, 17)
        Me.RadioButton3.TabIndex = 111
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Woche = 7 Tage"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(9, 105)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(116, 17)
        Me.RadioButton2.TabIndex = 110
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Monat = 30,4 Tage"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.b_rauchdauer)
        Me.GroupBox2.Controls.Add(Me.Zeittext)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.b_stueck)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Location = New System.Drawing.Point(15, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(245, 134)
        Me.GroupBox2.TabIndex = 118
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "bisheriges Rauchverhalten"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(15, 15)
        Me.Label4.TabIndex = 116
        Me.Label4.Text = "_"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.GroupBox3.Controls.Add(Me.Label24)
        Me.GroupBox3.Controls.Add(Me.Label23)
        Me.GroupBox3.Controls.Add(Me.Label22)
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.b_tabbaksumme)
        Me.GroupBox3.Controls.Add(Me.b_schachtelsumme)
        Me.GroupBox3.Controls.Add(Me.b_preis_pro_Schachtel)
        Me.GroupBox3.Controls.Add(Me.b_schachteln_pro_tag)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.b_Tabakwoche)
        Me.GroupBox3.Location = New System.Drawing.Point(275, 152)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(331, 143)
        Me.GroupBox3.TabIndex = 119
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Ersparnisse durch Nichtrauchen"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(295, 93)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(13, 13)
        Me.Label24.TabIndex = 123
        Me.Label24.Text = "€"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(295, 40)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(13, 13)
        Me.Label23.TabIndex = 122
        Me.Label23.Text = "€"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(146, 16)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(40, 13)
        Me.Label22.TabIndex = 121
        Me.Label22.Text = "einzeln"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(244, 16)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(41, 13)
        Me.Label21.TabIndex = 120
        Me.Label21.Text = "gesamt"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(198, 93)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(13, 13)
        Me.Label20.TabIndex = 119
        Me.Label20.Text = "€"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(198, 40)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(13, 13)
        Me.Label12.TabIndex = 118
        Me.Label12.Text = "€"
        '
        'b_tabbaksumme
        '
        Me.b_tabbaksumme.BackColor = System.Drawing.SystemColors.Window
        Me.b_tabbaksumme.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b_tabbaksumme.Location = New System.Drawing.Point(234, 37)
        Me.b_tabbaksumme.Name = "b_tabbaksumme"
        Me.b_tabbaksumme.ReadOnly = True
        Me.b_tabbaksumme.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.b_tabbaksumme.Size = New System.Drawing.Size(55, 20)
        Me.b_tabbaksumme.TabIndex = 8
        '
        'b_schachtelsumme
        '
        Me.b_schachtelsumme.BackColor = System.Drawing.SystemColors.Window
        Me.b_schachtelsumme.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b_schachtelsumme.Location = New System.Drawing.Point(234, 90)
        Me.b_schachtelsumme.Name = "b_schachtelsumme"
        Me.b_schachtelsumme.ReadOnly = True
        Me.b_schachtelsumme.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.b_schachtelsumme.Size = New System.Drawing.Size(55, 20)
        Me.b_schachtelsumme.TabIndex = 7
        '
        'b_preis_pro_Schachtel
        '
        Me.b_preis_pro_Schachtel.Location = New System.Drawing.Point(139, 89)
        Me.b_preis_pro_Schachtel.Name = "b_preis_pro_Schachtel"
        Me.b_preis_pro_Schachtel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.b_preis_pro_Schachtel.Size = New System.Drawing.Size(56, 20)
        Me.b_preis_pro_Schachtel.TabIndex = 5
        Me.b_preis_pro_Schachtel.Text = "4"
        '
        'b_schachteln_pro_tag
        '
        Me.b_schachteln_pro_tag.Location = New System.Drawing.Point(139, 63)
        Me.b_schachteln_pro_tag.Name = "b_schachteln_pro_tag"
        Me.b_schachteln_pro_tag.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.b_schachteln_pro_tag.Size = New System.Drawing.Size(56, 20)
        Me.b_schachteln_pro_tag.TabIndex = 4
        Me.b_schachteln_pro_tag.Text = "1,5"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(12, 92)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(99, 13)
        Me.Label19.TabIndex = 3
        Me.Label19.Text = "Preis pro Schachtel"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(12, 66)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(101, 13)
        Me.Label18.TabIndex = 2
        Me.Label18.Text = "Schachteln pro Tag"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(9, 40)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(122, 13)
        Me.Label15.TabIndex = 1
        Me.Label15.Text = "Tabbakpreis pro Woche"
        '
        'b_Tabakwoche
        '
        Me.b_Tabakwoche.Location = New System.Drawing.Point(139, 37)
        Me.b_Tabakwoche.Name = "b_Tabakwoche"
        Me.b_Tabakwoche.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.b_Tabakwoche.Size = New System.Drawing.Size(56, 20)
        Me.b_Tabakwoche.TabIndex = 0
        Me.b_Tabakwoche.Text = "15"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.l_Herzinfarktrisiko)
        Me.GroupBox4.Controls.Add(Me.l_lunge_regeneriert)
        Me.GroupBox4.Controls.Add(Me.l_krebs)
        Me.GroupBox4.Location = New System.Drawing.Point(275, 303)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(331, 98)
        Me.GroupBox4.TabIndex = 124
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Gesundheit"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 64)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(14, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "_"
        '
        'l_Herzinfarktrisiko
        '
        Me.l_Herzinfarktrisiko.AutoSize = True
        Me.l_Herzinfarktrisiko.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l_Herzinfarktrisiko.Location = New System.Drawing.Point(7, 51)
        Me.l_Herzinfarktrisiko.Name = "l_Herzinfarktrisiko"
        Me.l_Herzinfarktrisiko.Size = New System.Drawing.Size(14, 13)
        Me.l_Herzinfarktrisiko.TabIndex = 2
        Me.l_Herzinfarktrisiko.Text = "_"
        '
        'l_lunge_regeneriert
        '
        Me.l_lunge_regeneriert.AutoSize = True
        Me.l_lunge_regeneriert.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l_lunge_regeneriert.Location = New System.Drawing.Point(7, 38)
        Me.l_lunge_regeneriert.Name = "l_lunge_regeneriert"
        Me.l_lunge_regeneriert.Size = New System.Drawing.Size(14, 13)
        Me.l_lunge_regeneriert.TabIndex = 1
        Me.l_lunge_regeneriert.Text = "_"
        '
        'l_krebs
        '
        Me.l_krebs.AutoSize = True
        Me.l_krebs.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l_krebs.Location = New System.Drawing.Point(7, 25)
        Me.l_krebs.Name = "l_krebs"
        Me.l_krebs.Size = New System.Drawing.Size(14, 13)
        Me.l_krebs.TabIndex = 0
        Me.l_krebs.Text = "_"
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "AK-Soft Zigarettenmesser"
        Me.NotifyIcon1.Visible = True
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.GroupBox5.Controls.Add(Me.Label34)
        Me.GroupBox5.Controls.Add(Me.Label33)
        Me.GroupBox5.Controls.Add(Me.Label31)
        Me.GroupBox5.Controls.Add(Me.Label32)
        Me.GroupBox5.Controls.Add(Me.b_c)
        Me.GroupBox5.Controls.Add(Me.LinkLabel1)
        Me.GroupBox5.Controls.Add(Me.Label30)
        Me.GroupBox5.Controls.Add(Me.Label28)
        Me.GroupBox5.Controls.Add(Me.Label27)
        Me.GroupBox5.Controls.Add(Me.Label29)
        Me.GroupBox5.Controls.Add(Me.Label26)
        Me.GroupBox5.Controls.Add(Me.b_nichtraucherprozent)
        Me.GroupBox5.Controls.Add(Me.Label25)
        Me.GroupBox5.Controls.Add(Me.b_b)
        Me.GroupBox5.Controls.Add(Me.Label6)
        Me.GroupBox5.Controls.Add(Me.b_a)
        Me.GroupBox5.Location = New System.Drawing.Point(15, 152)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(245, 214)
        Me.GroupBox5.TabIndex = 125
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Zahlung an die Welt der Nichtraucher"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(8, 161)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(208, 13)
        Me.Label34.TabIndex = 138
        Me.Label34.Text = "im Rentensystem: (Rechnung zu ungenau)"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(8, 90)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(209, 13)
        Me.Label33.TabIndex = 137
        Me.Label33.Text = "hätte man geraucht; im Gesundheitssystem"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(8, 109)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(110, 13)
        Me.Label31.TabIndex = 136
        Me.Label31.Text = "durch weniger Kosten"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(196, 109)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(13, 13)
        Me.Label32.TabIndex = 135
        Me.Label32.Text = "€"
        '
        'b_c
        '
        Me.b_c.BackColor = System.Drawing.SystemColors.Window
        Me.b_c.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b_c.Location = New System.Drawing.Point(135, 106)
        Me.b_c.Name = "b_c"
        Me.b_c.ReadOnly = True
        Me.b_c.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.b_c.Size = New System.Drawing.Size(55, 20)
        Me.b_c.TabIndex = 134
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(6, 130)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(192, 13)
        Me.LinkLabel1.TabIndex = 133
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "click: Nachweis bzgl. Krankheitskosten"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(8, 16)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(172, 13)
        Me.Label30.TabIndex = 132
        Me.Label30.Text = "hätte man geraucht; durch Steuern"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(13, 189)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(108, 13)
        Me.Label28.TabIndex = 131
        Me.Label28.Text = "Nichtraucher im Land"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(8, 66)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(127, 13)
        Me.Label27.TabIndex = 128
        Me.Label27.Text = "wegen Zigarettenkonsum"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(201, 189)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(15, 13)
        Me.Label29.TabIndex = 130
        Me.Label29.Text = "%"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(8, 40)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(116, 13)
        Me.Label26.TabIndex = 127
        Me.Label26.Text = "wegen Tabbakkonsum"
        '
        'b_nichtraucherprozent
        '
        Me.b_nichtraucherprozent.BackColor = System.Drawing.SystemColors.Window
        Me.b_nichtraucherprozent.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b_nichtraucherprozent.Location = New System.Drawing.Point(140, 186)
        Me.b_nichtraucherprozent.Name = "b_nichtraucherprozent"
        Me.b_nichtraucherprozent.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.b_nichtraucherprozent.Size = New System.Drawing.Size(55, 20)
        Me.b_nichtraucherprozent.TabIndex = 129
        Me.b_nichtraucherprozent.Text = "73"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(196, 66)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(13, 13)
        Me.Label25.TabIndex = 126
        Me.Label25.Text = "€"
        '
        'b_b
        '
        Me.b_b.BackColor = System.Drawing.SystemColors.Window
        Me.b_b.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b_b.Location = New System.Drawing.Point(135, 63)
        Me.b_b.Name = "b_b"
        Me.b_b.ReadOnly = True
        Me.b_b.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.b_b.Size = New System.Drawing.Size(55, 20)
        Me.b_b.TabIndex = 125
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(196, 40)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(13, 13)
        Me.Label6.TabIndex = 124
        Me.Label6.Text = "€"
        '
        'b_a
        '
        Me.b_a.BackColor = System.Drawing.SystemColors.Window
        Me.b_a.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b_a.Location = New System.Drawing.Point(135, 37)
        Me.b_a.Name = "b_a"
        Me.b_a.ReadOnly = True
        Me.b_a.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.b_a.Size = New System.Drawing.Size(55, 20)
        Me.b_a.TabIndex = 123
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.GroupBox6.Controls.Add(Me.Label37)
        Me.GroupBox6.Controls.Add(Me.Label36)
        Me.GroupBox6.Controls.Add(Me.Label35)
        Me.GroupBox6.Location = New System.Drawing.Point(15, 372)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(245, 63)
        Me.GroupBox6.TabIndex = 125
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Wo der Raucher dem Nichtraucher schenkt"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.Location = New System.Drawing.Point(6, 43)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(148, 13)
        Me.Label37.TabIndex = 4
        Me.Label37.Text = "Rentenbeiträge senkt er."
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(6, 30)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(194, 13)
        Me.Label36.TabIndex = 3
        Me.Label36.Text = "Krankenkassenbeiträge senkt er."
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(6, 16)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(151, 13)
        Me.Label35.TabIndex = 2
        Me.Label35.Text = "Steuern senkt er indirekt."
        '
        'rauchen_beendet
        '
        Me.rauchen_beendet.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rauchen_beendet.Location = New System.Drawing.Point(275, 411)
        Me.rauchen_beendet.Name = "rauchen_beendet"
        Me.rauchen_beendet.Size = New System.Drawing.Size(161, 24)
        Me.rauchen_beendet.TabIndex = 106
        Me.rauchen_beendet.Text = "Minimieren zum Symbol"
        Me.rauchen_beendet.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(445, 411)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(161, 24)
        Me.Button1.TabIndex = 126
        Me.Button1.Text = "Beenden"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 3600000
        '
        'zigarettenmesser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Beige
        Me.ClientSize = New System.Drawing.Size(620, 443)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.rauchen_beendet)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "zigarettenmesser"
        Me.Text = "AK-Soft Zigarettenmesser"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents b_tag As System.Windows.Forms.TextBox
    Friend WithEvents b_monat As System.Windows.Forms.TextBox
    Friend WithEvents b_jahr As System.Windows.Forms.TextBox
    Friend WithEvents b_stunde As System.Windows.Forms.TextBox
    Friend WithEvents b_minute As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents b_rauchdauer As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Zeittext As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents b_stueck As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents b_Tabakwoche As System.Windows.Forms.TextBox
    Friend WithEvents b_preis_pro_Schachtel As System.Windows.Forms.TextBox
    Friend WithEvents b_schachteln_pro_tag As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents b_schachtelsumme As System.Windows.Forms.TextBox
    Friend WithEvents b_tabbaksumme As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents l_krebs As System.Windows.Forms.Label
    Friend WithEvents l_lunge_regeneriert As System.Windows.Forms.Label
    Friend WithEvents l_Herzinfarktrisiko As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents b_b As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents b_a As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents b_nichtraucherprozent As System.Windows.Forms.TextBox
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents b_c As System.Windows.Forms.TextBox
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents rauchen_beendet As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class
