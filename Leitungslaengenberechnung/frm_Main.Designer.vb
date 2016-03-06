<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Main))
        Me.tab1 = New System.Windows.Forms.TabControl()
        Me.tab_page1 = New System.Windows.Forms.TabPage()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.o230_spannungsabfall = New System.Windows.Forms.TextBox()
        Me.btn_beenden = New System.Windows.Forms.Button()
        Me.btn_berechnen = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.o230_querschnitt = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.i230_leitwert = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.i230_abfall = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.i230_wirkungsgrad = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.i230_strom = New System.Windows.Forms.TextBox()
        Me.i230_spannung = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.i230_laenge = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tab_page2 = New System.Windows.Forms.TabPage()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.o400_querschnitt = New System.Windows.Forms.TextBox()
        Me.btn_beenden400 = New System.Windows.Forms.Button()
        Me.btn_berechnen400 = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.i400_leitwert = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.i400_abfall = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.i400_wirkungsgrad = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.i400_strom = New System.Windows.Forms.TextBox()
        Me.i400_spannung = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.o400_spannungsabfall = New System.Windows.Forms.TextBox()
        Me.i400_laenge = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tab3 = New System.Windows.Forms.TabPage()
        Me.oAus_rechnung = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.oAus_ausschaltstrom = New System.Windows.Forms.TextBox()
        Me.iAus_type = New System.Windows.Forms.ComboBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.iAus_faktor = New System.Windows.Forms.TextBox()
        Me.check_ueber32A = New System.Windows.Forms.RadioButton()
        Me.check_unter32A = New System.Windows.Forms.RadioButton()
        Me.iAus_nennspannung = New System.Windows.Forms.ComboBox()
        Me.btn_beendenAus = New System.Windows.Forms.Button()
        Me.btn_berechnenAus = New System.Windows.Forms.Button()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.iAus_nennstrom = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.oAus_ergebnis = New System.Windows.Forms.TextBox()
        Me.iAus_schleife = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.tab1.SuspendLayout()
        Me.tab_page1.SuspendLayout()
        Me.tab_page2.SuspendLayout()
        Me.tab3.SuspendLayout()
        Me.SuspendLayout()
        '
        'tab1
        '
        Me.tab1.Controls.Add(Me.tab_page1)
        Me.tab1.Controls.Add(Me.tab_page2)
        Me.tab1.Controls.Add(Me.tab3)
        Me.tab1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tab1.Location = New System.Drawing.Point(0, 0)
        Me.tab1.Name = "tab1"
        Me.tab1.SelectedIndex = 0
        Me.tab1.Size = New System.Drawing.Size(475, 250)
        Me.tab1.TabIndex = 0
        '
        'tab_page1
        '
        Me.tab_page1.Controls.Add(Me.Label8)
        Me.tab_page1.Controls.Add(Me.o230_spannungsabfall)
        Me.tab_page1.Controls.Add(Me.btn_beenden)
        Me.tab_page1.Controls.Add(Me.btn_berechnen)
        Me.tab_page1.Controls.Add(Me.Label7)
        Me.tab_page1.Controls.Add(Me.o230_querschnitt)
        Me.tab_page1.Controls.Add(Me.Label6)
        Me.tab_page1.Controls.Add(Me.i230_leitwert)
        Me.tab_page1.Controls.Add(Me.Label5)
        Me.tab_page1.Controls.Add(Me.i230_abfall)
        Me.tab_page1.Controls.Add(Me.Label4)
        Me.tab_page1.Controls.Add(Me.i230_wirkungsgrad)
        Me.tab_page1.Controls.Add(Me.Label3)
        Me.tab_page1.Controls.Add(Me.i230_strom)
        Me.tab_page1.Controls.Add(Me.i230_spannung)
        Me.tab_page1.Controls.Add(Me.Label2)
        Me.tab_page1.Controls.Add(Me.i230_laenge)
        Me.tab_page1.Controls.Add(Me.Label1)
        Me.tab_page1.Location = New System.Drawing.Point(4, 22)
        Me.tab_page1.Name = "tab_page1"
        Me.tab_page1.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_page1.Size = New System.Drawing.Size(467, 224)
        Me.tab_page1.TabIndex = 0
        Me.tab_page1.Text = "Wechselstrom (230V)"
        Me.tab_page1.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(251, 28)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(108, 13)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Spannungsabfall [ V ]"
        '
        'o230_spannungsabfall
        '
        Me.o230_spannungsabfall.Location = New System.Drawing.Point(387, 25)
        Me.o230_spannungsabfall.Name = "o230_spannungsabfall"
        Me.o230_spannungsabfall.ReadOnly = True
        Me.o230_spannungsabfall.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.o230_spannungsabfall.Size = New System.Drawing.Size(65, 20)
        Me.o230_spannungsabfall.TabIndex = 17
        '
        'btn_beenden
        '
        Me.btn_beenden.Location = New System.Drawing.Point(254, 181)
        Me.btn_beenden.Name = "btn_beenden"
        Me.btn_beenden.Size = New System.Drawing.Size(198, 27)
        Me.btn_beenden.TabIndex = 16
        Me.btn_beenden.Text = "BEENDEN"
        Me.btn_beenden.UseVisualStyleBackColor = True
        '
        'btn_berechnen
        '
        Me.btn_berechnen.Location = New System.Drawing.Point(11, 181)
        Me.btn_berechnen.Name = "btn_berechnen"
        Me.btn_berechnen.Size = New System.Drawing.Size(197, 27)
        Me.btn_berechnen.TabIndex = 15
        Me.btn_berechnen.Text = "BERECHNEN"
        Me.btn_berechnen.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(251, 54)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(116, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Leiterquerschnitt [ mm ]"
        '
        'o230_querschnitt
        '
        Me.o230_querschnitt.Location = New System.Drawing.Point(387, 51)
        Me.o230_querschnitt.Name = "o230_querschnitt"
        Me.o230_querschnitt.ReadOnly = True
        Me.o230_querschnitt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.o230_querschnitt.Size = New System.Drawing.Size(65, 20)
        Me.o230_querschnitt.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 158)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Leitwert"
        '
        'i230_leitwert
        '
        Me.i230_leitwert.Location = New System.Drawing.Point(144, 155)
        Me.i230_leitwert.Name = "i230_leitwert"
        Me.i230_leitwert.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.i230_leitwert.Size = New System.Drawing.Size(64, 20)
        Me.i230_leitwert.TabIndex = 10
        Me.i230_leitwert.Text = "56"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 132)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Spannungsabfall [ % ]"
        '
        'i230_abfall
        '
        Me.i230_abfall.Location = New System.Drawing.Point(144, 129)
        Me.i230_abfall.Name = "i230_abfall"
        Me.i230_abfall.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.i230_abfall.Size = New System.Drawing.Size(64, 20)
        Me.i230_abfall.TabIndex = 8
        Me.i230_abfall.Text = "3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 106)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Wirkungsgrad"
        '
        'i230_wirkungsgrad
        '
        Me.i230_wirkungsgrad.Location = New System.Drawing.Point(144, 103)
        Me.i230_wirkungsgrad.Name = "i230_wirkungsgrad"
        Me.i230_wirkungsgrad.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.i230_wirkungsgrad.Size = New System.Drawing.Size(64, 20)
        Me.i230_wirkungsgrad.TabIndex = 6
        Me.i230_wirkungsgrad.Text = "0,8"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Leiterstrom [ A ]"
        '
        'i230_strom
        '
        Me.i230_strom.Location = New System.Drawing.Point(144, 77)
        Me.i230_strom.Name = "i230_strom"
        Me.i230_strom.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.i230_strom.Size = New System.Drawing.Size(64, 20)
        Me.i230_strom.TabIndex = 4
        Me.i230_strom.Text = "16"
        '
        'i230_spannung
        '
        Me.i230_spannung.Location = New System.Drawing.Point(144, 51)
        Me.i230_spannung.Name = "i230_spannung"
        Me.i230_spannung.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.i230_spannung.Size = New System.Drawing.Size(64, 20)
        Me.i230_spannung.TabIndex = 3
        Me.i230_spannung.Text = "230"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Spannung [ V ]"
        '
        'i230_laenge
        '
        Me.i230_laenge.Location = New System.Drawing.Point(144, 25)
        Me.i230_laenge.Name = "i230_laenge"
        Me.i230_laenge.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.i230_laenge.Size = New System.Drawing.Size(64, 20)
        Me.i230_laenge.TabIndex = 1
        Me.i230_laenge.Text = "20"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Leitungslänge [ m ]"
        '
        'tab_page2
        '
        Me.tab_page2.Controls.Add(Me.Label16)
        Me.tab_page2.Controls.Add(Me.o400_querschnitt)
        Me.tab_page2.Controls.Add(Me.btn_beenden400)
        Me.tab_page2.Controls.Add(Me.btn_berechnen400)
        Me.tab_page2.Controls.Add(Me.Label11)
        Me.tab_page2.Controls.Add(Me.i400_leitwert)
        Me.tab_page2.Controls.Add(Me.Label12)
        Me.tab_page2.Controls.Add(Me.i400_abfall)
        Me.tab_page2.Controls.Add(Me.Label13)
        Me.tab_page2.Controls.Add(Me.i400_wirkungsgrad)
        Me.tab_page2.Controls.Add(Me.Label14)
        Me.tab_page2.Controls.Add(Me.i400_strom)
        Me.tab_page2.Controls.Add(Me.i400_spannung)
        Me.tab_page2.Controls.Add(Me.Label15)
        Me.tab_page2.Controls.Add(Me.Label9)
        Me.tab_page2.Controls.Add(Me.o400_spannungsabfall)
        Me.tab_page2.Controls.Add(Me.i400_laenge)
        Me.tab_page2.Controls.Add(Me.Label10)
        Me.tab_page2.Location = New System.Drawing.Point(4, 22)
        Me.tab_page2.Name = "tab_page2"
        Me.tab_page2.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_page2.Size = New System.Drawing.Size(467, 224)
        Me.tab_page2.TabIndex = 1
        Me.tab_page2.Text = "Drehstrom (400V)"
        Me.tab_page2.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(251, 54)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(116, 13)
        Me.Label16.TabIndex = 36
        Me.Label16.Text = "Leiterquerschnitt [ mm ]"
        '
        'o400_querschnitt
        '
        Me.o400_querschnitt.Location = New System.Drawing.Point(387, 51)
        Me.o400_querschnitt.Name = "o400_querschnitt"
        Me.o400_querschnitt.ReadOnly = True
        Me.o400_querschnitt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.o400_querschnitt.Size = New System.Drawing.Size(65, 20)
        Me.o400_querschnitt.TabIndex = 35
        '
        'btn_beenden400
        '
        Me.btn_beenden400.Location = New System.Drawing.Point(254, 181)
        Me.btn_beenden400.Name = "btn_beenden400"
        Me.btn_beenden400.Size = New System.Drawing.Size(198, 27)
        Me.btn_beenden400.TabIndex = 34
        Me.btn_beenden400.Text = "BEENDEN"
        Me.btn_beenden400.UseVisualStyleBackColor = True
        '
        'btn_berechnen400
        '
        Me.btn_berechnen400.Location = New System.Drawing.Point(11, 181)
        Me.btn_berechnen400.Name = "btn_berechnen400"
        Me.btn_berechnen400.Size = New System.Drawing.Size(197, 27)
        Me.btn_berechnen400.TabIndex = 33
        Me.btn_berechnen400.Text = "BERECHNEN"
        Me.btn_berechnen400.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(8, 158)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(44, 13)
        Me.Label11.TabIndex = 32
        Me.Label11.Text = "Leitwert"
        '
        'i400_leitwert
        '
        Me.i400_leitwert.Location = New System.Drawing.Point(144, 155)
        Me.i400_leitwert.Name = "i400_leitwert"
        Me.i400_leitwert.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.i400_leitwert.Size = New System.Drawing.Size(64, 20)
        Me.i400_leitwert.TabIndex = 31
        Me.i400_leitwert.Text = "56"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(8, 132)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(109, 13)
        Me.Label12.TabIndex = 30
        Me.Label12.Text = "Spannungsabfall [ % ]"
        '
        'i400_abfall
        '
        Me.i400_abfall.Location = New System.Drawing.Point(144, 129)
        Me.i400_abfall.Name = "i400_abfall"
        Me.i400_abfall.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.i400_abfall.Size = New System.Drawing.Size(64, 20)
        Me.i400_abfall.TabIndex = 29
        Me.i400_abfall.Text = "3"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(8, 106)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(73, 13)
        Me.Label13.TabIndex = 28
        Me.Label13.Text = "Wirkungsgrad"
        '
        'i400_wirkungsgrad
        '
        Me.i400_wirkungsgrad.Location = New System.Drawing.Point(144, 103)
        Me.i400_wirkungsgrad.Name = "i400_wirkungsgrad"
        Me.i400_wirkungsgrad.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.i400_wirkungsgrad.Size = New System.Drawing.Size(64, 20)
        Me.i400_wirkungsgrad.TabIndex = 27
        Me.i400_wirkungsgrad.Text = "0,8"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(8, 80)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(80, 13)
        Me.Label14.TabIndex = 26
        Me.Label14.Text = "Leiterstrom [ A ]"
        '
        'i400_strom
        '
        Me.i400_strom.Location = New System.Drawing.Point(144, 77)
        Me.i400_strom.Name = "i400_strom"
        Me.i400_strom.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.i400_strom.Size = New System.Drawing.Size(64, 20)
        Me.i400_strom.TabIndex = 25
        Me.i400_strom.Text = "16"
        '
        'i400_spannung
        '
        Me.i400_spannung.Location = New System.Drawing.Point(144, 51)
        Me.i400_spannung.Name = "i400_spannung"
        Me.i400_spannung.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.i400_spannung.Size = New System.Drawing.Size(64, 20)
        Me.i400_spannung.TabIndex = 24
        Me.i400_spannung.Text = "400"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(8, 54)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(78, 13)
        Me.Label15.TabIndex = 23
        Me.Label15.Text = "Spannung [ V ]"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(251, 28)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(108, 13)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Spannungsabfall [ V ]"
        '
        'o400_spannungsabfall
        '
        Me.o400_spannungsabfall.Location = New System.Drawing.Point(387, 25)
        Me.o400_spannungsabfall.Name = "o400_spannungsabfall"
        Me.o400_spannungsabfall.ReadOnly = True
        Me.o400_spannungsabfall.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.o400_spannungsabfall.Size = New System.Drawing.Size(65, 20)
        Me.o400_spannungsabfall.TabIndex = 21
        '
        'i400_laenge
        '
        Me.i400_laenge.Location = New System.Drawing.Point(144, 25)
        Me.i400_laenge.Name = "i400_laenge"
        Me.i400_laenge.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.i400_laenge.Size = New System.Drawing.Size(64, 20)
        Me.i400_laenge.TabIndex = 20
        Me.i400_laenge.Text = "30"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(8, 28)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(96, 13)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Leitungslänge [ m ]"
        '
        'tab3
        '
        Me.tab3.Controls.Add(Me.oAus_rechnung)
        Me.tab3.Controls.Add(Me.Label17)
        Me.tab3.Controls.Add(Me.oAus_ausschaltstrom)
        Me.tab3.Controls.Add(Me.iAus_type)
        Me.tab3.Controls.Add(Me.Label23)
        Me.tab3.Controls.Add(Me.Label22)
        Me.tab3.Controls.Add(Me.iAus_faktor)
        Me.tab3.Controls.Add(Me.check_ueber32A)
        Me.tab3.Controls.Add(Me.check_unter32A)
        Me.tab3.Controls.Add(Me.iAus_nennspannung)
        Me.tab3.Controls.Add(Me.btn_beendenAus)
        Me.tab3.Controls.Add(Me.btn_berechnenAus)
        Me.tab3.Controls.Add(Me.Label21)
        Me.tab3.Controls.Add(Me.iAus_nennstrom)
        Me.tab3.Controls.Add(Me.Label18)
        Me.tab3.Controls.Add(Me.Label19)
        Me.tab3.Controls.Add(Me.oAus_ergebnis)
        Me.tab3.Controls.Add(Me.iAus_schleife)
        Me.tab3.Controls.Add(Me.Label20)
        Me.tab3.Location = New System.Drawing.Point(4, 22)
        Me.tab3.Name = "tab3"
        Me.tab3.Padding = New System.Windows.Forms.Padding(3)
        Me.tab3.Size = New System.Drawing.Size(467, 224)
        Me.tab3.TabIndex = 2
        Me.tab3.Text = "Ausschaltbedingung"
        Me.tab3.UseVisualStyleBackColor = True
        '
        'oAus_rechnung
        '
        Me.oAus_rechnung.AutoSize = True
        Me.oAus_rechnung.Location = New System.Drawing.Point(260, 131)
        Me.oAus_rechnung.Name = "oAus_rechnung"
        Me.oAus_rechnung.Size = New System.Drawing.Size(66, 13)
        Me.oAus_rechnung.TabIndex = 61
        Me.oAus_rechnung.Text = "Rechnung..."
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(260, 80)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(100, 13)
        Me.Label17.TabIndex = 60
        Me.Label17.Text = "Ausschaltstrom [ A ]"
        '
        'oAus_ausschaltstrom
        '
        Me.oAus_ausschaltstrom.Enabled = False
        Me.oAus_ausschaltstrom.Location = New System.Drawing.Point(387, 77)
        Me.oAus_ausschaltstrom.Name = "oAus_ausschaltstrom"
        Me.oAus_ausschaltstrom.Size = New System.Drawing.Size(65, 20)
        Me.oAus_ausschaltstrom.TabIndex = 59
        '
        'iAus_type
        '
        Me.iAus_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.iAus_type.FormattingEnabled = True
        Me.iAus_type.Items.AddRange(New Object() {"Schmelz", "B", "C", "D"})
        Me.iAus_type.Location = New System.Drawing.Point(144, 103)
        Me.iAus_type.Name = "iAus_type"
        Me.iAus_type.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.iAus_type.Size = New System.Drawing.Size(64, 21)
        Me.iAus_type.TabIndex = 58
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(8, 106)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(80, 13)
        Me.Label23.TabIndex = 57
        Me.Label23.Text = "Sicherungstype"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(8, 132)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(105, 13)
        Me.Label22.TabIndex = 55
        Me.Label22.Text = "Ausschaltstromfaktor"
        '
        'iAus_faktor
        '
        Me.iAus_faktor.Location = New System.Drawing.Point(144, 129)
        Me.iAus_faktor.Name = "iAus_faktor"
        Me.iAus_faktor.ReadOnly = True
        Me.iAus_faktor.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.iAus_faktor.Size = New System.Drawing.Size(64, 20)
        Me.iAus_faktor.TabIndex = 54
        '
        'check_ueber32A
        '
        Me.check_ueber32A.AutoSize = True
        Me.check_ueber32A.Location = New System.Drawing.Point(254, 52)
        Me.check_ueber32A.Name = "check_ueber32A"
        Me.check_ueber32A.Size = New System.Drawing.Size(140, 17)
        Me.check_ueber32A.TabIndex = 51
        Me.check_ueber32A.Text = "Endstromkreis über 32 A"
        Me.check_ueber32A.UseVisualStyleBackColor = True
        '
        'check_unter32A
        '
        Me.check_unter32A.AutoSize = True
        Me.check_unter32A.Checked = True
        Me.check_unter32A.Location = New System.Drawing.Point(254, 26)
        Me.check_unter32A.Name = "check_unter32A"
        Me.check_unter32A.Size = New System.Drawing.Size(143, 17)
        Me.check_unter32A.TabIndex = 50
        Me.check_unter32A.TabStop = True
        Me.check_unter32A.Text = "Endstromkreis unter 32 A"
        Me.check_unter32A.UseVisualStyleBackColor = True
        '
        'iAus_nennspannung
        '
        Me.iAus_nennspannung.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.iAus_nennspannung.FormattingEnabled = True
        Me.iAus_nennspannung.Items.AddRange(New Object() {"230", "400"})
        Me.iAus_nennspannung.Location = New System.Drawing.Point(144, 77)
        Me.iAus_nennspannung.Name = "iAus_nennspannung"
        Me.iAus_nennspannung.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.iAus_nennspannung.Size = New System.Drawing.Size(64, 21)
        Me.iAus_nennspannung.TabIndex = 49
        '
        'btn_beendenAus
        '
        Me.btn_beendenAus.Location = New System.Drawing.Point(254, 181)
        Me.btn_beendenAus.Name = "btn_beendenAus"
        Me.btn_beendenAus.Size = New System.Drawing.Size(198, 27)
        Me.btn_beendenAus.TabIndex = 48
        Me.btn_beendenAus.Text = "BEENDEN"
        Me.btn_beendenAus.UseVisualStyleBackColor = True
        '
        'btn_berechnenAus
        '
        Me.btn_berechnenAus.Location = New System.Drawing.Point(11, 181)
        Me.btn_berechnenAus.Name = "btn_berechnenAus"
        Me.btn_berechnenAus.Size = New System.Drawing.Size(197, 27)
        Me.btn_berechnenAus.TabIndex = 47
        Me.btn_berechnenAus.Text = "BERECHNEN"
        Me.btn_berechnenAus.UseVisualStyleBackColor = True
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(8, 80)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(102, 13)
        Me.Label21.TabIndex = 45
        Me.Label21.Text = "Nennspannung [ V ]"
        '
        'iAus_nennstrom
        '
        Me.iAus_nennstrom.Location = New System.Drawing.Point(144, 51)
        Me.iAus_nennstrom.Name = "iAus_nennstrom"
        Me.iAus_nennstrom.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.iAus_nennstrom.Size = New System.Drawing.Size(64, 20)
        Me.iAus_nennstrom.TabIndex = 42
        Me.iAus_nennstrom.Text = "16"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(8, 54)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(91, 13)
        Me.Label18.TabIndex = 41
        Me.Label18.Text = "Vorsicherung [ A ]"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(260, 105)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(85, 13)
        Me.Label19.TabIndex = 40
        Me.Label19.Text = "Widerstand OK?"
        '
        'oAus_ergebnis
        '
        Me.oAus_ergebnis.BackColor = System.Drawing.SystemColors.Window
        Me.oAus_ergebnis.Enabled = False
        Me.oAus_ergebnis.Location = New System.Drawing.Point(387, 102)
        Me.oAus_ergebnis.Name = "oAus_ergebnis"
        Me.oAus_ergebnis.ReadOnly = True
        Me.oAus_ergebnis.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.oAus_ergebnis.Size = New System.Drawing.Size(65, 20)
        Me.oAus_ergebnis.TabIndex = 39
        '
        'iAus_schleife
        '
        Me.iAus_schleife.Location = New System.Drawing.Point(144, 25)
        Me.iAus_schleife.Name = "iAus_schleife"
        Me.iAus_schleife.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.iAus_schleife.Size = New System.Drawing.Size(64, 20)
        Me.iAus_schleife.TabIndex = 38
        Me.iAus_schleife.Text = "3"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(8, 28)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(133, 13)
        Me.Label20.TabIndex = 37
        Me.Label20.Text = "Schleifenimpedanz [ Ohm ]"
        '
        'frm_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(475, 250)
        Me.Controls.Add(Me.tab1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_Main"
        Me.Text = "Leitungslängenberechnung"
        Me.tab1.ResumeLayout(False)
        Me.tab_page1.ResumeLayout(False)
        Me.tab_page1.PerformLayout()
        Me.tab_page2.ResumeLayout(False)
        Me.tab_page2.PerformLayout()
        Me.tab3.ResumeLayout(False)
        Me.tab3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tab1 As System.Windows.Forms.TabControl
    Friend WithEvents tab_page1 As System.Windows.Forms.TabPage
    Friend WithEvents tab_page2 As System.Windows.Forms.TabPage
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents o230_querschnitt As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents i230_leitwert As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents i230_abfall As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents i230_wirkungsgrad As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents i230_strom As System.Windows.Forms.TextBox
    Friend WithEvents i230_spannung As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents i230_laenge As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_beenden As System.Windows.Forms.Button
    Friend WithEvents btn_berechnen As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents o230_spannungsabfall As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents o400_querschnitt As System.Windows.Forms.TextBox
    Friend WithEvents btn_beenden400 As System.Windows.Forms.Button
    Friend WithEvents btn_berechnen400 As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents i400_leitwert As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents i400_abfall As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents i400_wirkungsgrad As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents i400_strom As System.Windows.Forms.TextBox
    Friend WithEvents i400_spannung As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents o400_spannungsabfall As System.Windows.Forms.TextBox
    Friend WithEvents i400_laenge As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents tab3 As System.Windows.Forms.TabPage
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents iAus_nennstrom As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents oAus_ergebnis As System.Windows.Forms.TextBox
    Friend WithEvents iAus_schleife As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents btn_beendenAus As System.Windows.Forms.Button
    Friend WithEvents btn_berechnenAus As System.Windows.Forms.Button
    Friend WithEvents iAus_nennspannung As System.Windows.Forms.ComboBox
    Friend WithEvents check_ueber32A As System.Windows.Forms.RadioButton
    Friend WithEvents check_unter32A As System.Windows.Forms.RadioButton
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents iAus_faktor As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents iAus_type As System.Windows.Forms.ComboBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents oAus_ausschaltstrom As System.Windows.Forms.TextBox
    Friend WithEvents oAus_rechnung As System.Windows.Forms.Label

End Class
