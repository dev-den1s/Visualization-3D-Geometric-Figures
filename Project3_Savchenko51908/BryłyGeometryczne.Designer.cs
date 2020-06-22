namespace Project3_Savchenko51908
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dspbRysownica = new System.Windows.Forms.PictureBox();
            this.dstbPromien = new System.Windows.Forms.TrackBar();
            this.dscmbWybierz = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dstbWysokosc = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dstbkat = new System.Windows.Forms.TrackBar();
            this.dsbtnDodaj = new System.Windows.Forms.Button();
            this.dsbtnKierunekObrotuPrawo = new System.Windows.Forms.Button();
            this.dsbtnKierunekObrotuLewo = new System.Windows.Forms.Button();
            this.dsbtnAtrybutyLosowo = new System.Windows.Forms.Button();
            this.dsbtnWylosujNowepolozenie = new System.Windows.Forms.Button();
            this.dsbtnUsunPierwsa = new System.Windows.Forms.Button();
            this.dsbtnUsunOstatnia = new System.Windows.Forms.Button();
            this.dsbtnUsunWybrana = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dsgbPokaz = new System.Windows.Forms.GroupBox();
            this.dsrbpolepowierzchni = new System.Windows.Forms.RadioButton();
            this.dsrbobietosc = new System.Windows.Forms.RadioButton();
            this.dsrbWysokosc = new System.Windows.Forms.RadioButton();
            this.dsgbpokazslajder = new System.Windows.Forms.GroupBox();
            this.dsrbAutomatyczny = new System.Windows.Forms.RadioButton();
            this.dsrbManualny = new System.Windows.Forms.RadioButton();
            this.dsbtnslajderOn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dsbtnpoprzedni = new System.Windows.Forms.Button();
            this.dsbtnnastepny = new System.Windows.Forms.Button();
            this.dsbtnSlajderOff = new System.Windows.Forms.Button();
            this.dstbnumerSlajder = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dsTimerObrotow = new System.Windows.Forms.Timer(this.components);
            this.dscmbPodstawaBryly = new System.Windows.Forms.ComboBox();
            this.dsdNumerUsuwanej = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dsbtnReset = new System.Windows.Forms.Button();
            this.dsPanelKontrolek = new System.Windows.Forms.Panel();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dspbRysownica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dstbPromien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dstbWysokosc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dstbkat)).BeginInit();
            this.dsgbPokaz.SuspendLayout();
            this.dsgbpokazslajder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dspbRysownica
            // 
            this.dspbRysownica.BackColor = System.Drawing.SystemColors.Info;
            this.dspbRysownica.Location = new System.Drawing.Point(206, 70);
            this.dspbRysownica.Name = "dspbRysownica";
            this.dspbRysownica.Size = new System.Drawing.Size(868, 576);
            this.dspbRysownica.TabIndex = 0;
            this.dspbRysownica.TabStop = false;
            // 
            // dstbPromien
            // 
            this.dstbPromien.LargeChange = 20;
            this.dstbPromien.Location = new System.Drawing.Point(17, 85);
            this.dstbPromien.Maximum = 150;
            this.dstbPromien.Minimum = 50;
            this.dstbPromien.Name = "dstbPromien";
            this.dstbPromien.Size = new System.Drawing.Size(183, 45);
            this.dstbPromien.SmallChange = 20;
            this.dstbPromien.TabIndex = 50;
            this.dstbPromien.TickFrequency = 10;
            this.dstbPromien.Value = 50;
            // 
            // dscmbWybierz
            // 
            this.dscmbWybierz.FormattingEnabled = true;
            this.dscmbWybierz.Items.AddRange(new object[] {
            "Stożek",
            "Walec",
            "Ostroślup trójkątny",
            "Graniastoślup",
            "Ostroślup czworokątny"});
            this.dscmbWybierz.Location = new System.Drawing.Point(14, 14);
            this.dscmbWybierz.Name = "dscmbWybierz";
            this.dscmbWybierz.Size = new System.Drawing.Size(186, 23);
            this.dscmbWybierz.TabIndex = 2;
            this.dscmbWybierz.Text = "Wybierz bryłę geometryczną";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(45, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ustaw promien bryły";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(39, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ustaw wysokość bryły";
            // 
            // dstbWysokosc
            // 
            this.dstbWysokosc.LargeChange = 20;
            this.dstbWysokosc.Location = new System.Drawing.Point(14, 159);
            this.dstbWysokosc.Maximum = 200;
            this.dstbWysokosc.Minimum = 50;
            this.dstbWysokosc.Name = "dstbWysokosc";
            this.dstbWysokosc.Size = new System.Drawing.Size(186, 45);
            this.dstbWysokosc.SmallChange = 20;
            this.dstbWysokosc.TabIndex = 20;
            this.dstbWysokosc.TickFrequency = 20;
            this.dstbWysokosc.Value = 50;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(14, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 83);
            this.label3.TabIndex = 6;
            this.label3.Text = "Stopień wielokąta podstawy bryły( Nie trzeba podawać w ostroślupach )";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(39, 309);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 35);
            this.label4.TabIndex = 9;
            this.label4.Text = "Kąt nachyłenia bryły geometrycznej";
            // 
            // dstbkat
            // 
            this.dstbkat.AutoSize = false;
            this.dstbkat.LargeChange = 20;
            this.dstbkat.Location = new System.Drawing.Point(24, 361);
            this.dstbkat.Maximum = 170;
            this.dstbkat.Minimum = 10;
            this.dstbkat.Name = "dstbkat";
            this.dstbkat.Size = new System.Drawing.Size(176, 40);
            this.dstbkat.SmallChange = 20;
            this.dstbkat.TabIndex = 20;
            this.dstbkat.TickFrequency = 20;
            this.dstbkat.Value = 90;
            // 
            // dsbtnDodaj
            // 
            this.dsbtnDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dsbtnDodaj.Location = new System.Drawing.Point(30, 418);
            this.dsbtnDodaj.Name = "dsbtnDodaj";
            this.dsbtnDodaj.Size = new System.Drawing.Size(152, 33);
            this.dsbtnDodaj.TabIndex = 10;
            this.dsbtnDodaj.Text = "Dodaj nową bryłe";
            this.dsbtnDodaj.UseVisualStyleBackColor = true;
            this.dsbtnDodaj.Click += new System.EventHandler(this.dsbtnDodaj_Click);
            // 
            // dsbtnKierunekObrotuPrawo
            // 
            this.dsbtnKierunekObrotuPrawo.Enabled = false;
            this.dsbtnKierunekObrotuPrawo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dsbtnKierunekObrotuPrawo.Location = new System.Drawing.Point(30, 468);
            this.dsbtnKierunekObrotuPrawo.Name = "dsbtnKierunekObrotuPrawo";
            this.dsbtnKierunekObrotuPrawo.Size = new System.Drawing.Size(152, 48);
            this.dsbtnKierunekObrotuPrawo.TabIndex = 11;
            this.dsbtnKierunekObrotuPrawo.Text = "Kierunek obrotu w prawo";
            this.dsbtnKierunekObrotuPrawo.UseVisualStyleBackColor = true;
            this.dsbtnKierunekObrotuPrawo.Click += new System.EventHandler(this.dsbtnKierunekObrotuPrawo_Click);
            // 
            // dsbtnKierunekObrotuLewo
            // 
            this.dsbtnKierunekObrotuLewo.Enabled = false;
            this.dsbtnKierunekObrotuLewo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dsbtnKierunekObrotuLewo.Location = new System.Drawing.Point(32, 532);
            this.dsbtnKierunekObrotuLewo.Name = "dsbtnKierunekObrotuLewo";
            this.dsbtnKierunekObrotuLewo.Size = new System.Drawing.Size(150, 45);
            this.dsbtnKierunekObrotuLewo.TabIndex = 12;
            this.dsbtnKierunekObrotuLewo.Text = "Kierunek obrotu w lewo";
            this.dsbtnKierunekObrotuLewo.UseVisualStyleBackColor = true;
            this.dsbtnKierunekObrotuLewo.Click += new System.EventHandler(this.dsbtnKierunekObrotuLewo_Click);
            // 
            // dsbtnAtrybutyLosowo
            // 
            this.dsbtnAtrybutyLosowo.Enabled = false;
            this.dsbtnAtrybutyLosowo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dsbtnAtrybutyLosowo.Location = new System.Drawing.Point(32, 594);
            this.dsbtnAtrybutyLosowo.Name = "dsbtnAtrybutyLosowo";
            this.dsbtnAtrybutyLosowo.Size = new System.Drawing.Size(150, 43);
            this.dsbtnAtrybutyLosowo.TabIndex = 13;
            this.dsbtnAtrybutyLosowo.Text = "Ustaw nowe atrybuty (losowo)";
            this.dsbtnAtrybutyLosowo.UseVisualStyleBackColor = true;
            this.dsbtnAtrybutyLosowo.Click += new System.EventHandler(this.dsbtnAtrybutyLosowo_Click);
            // 
            // dsbtnWylosujNowepolozenie
            // 
            this.dsbtnWylosujNowepolozenie.Enabled = false;
            this.dsbtnWylosujNowepolozenie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dsbtnWylosujNowepolozenie.Location = new System.Drawing.Point(32, 653);
            this.dsbtnWylosujNowepolozenie.Name = "dsbtnWylosujNowepolozenie";
            this.dsbtnWylosujNowepolozenie.Size = new System.Drawing.Size(150, 49);
            this.dsbtnWylosujNowepolozenie.TabIndex = 14;
            this.dsbtnWylosujNowepolozenie.Text = "Wylosuj nowe położenie";
            this.dsbtnWylosujNowepolozenie.UseVisualStyleBackColor = true;
            this.dsbtnWylosujNowepolozenie.Click += new System.EventHandler(this.dsbtnWylosujNowepolozenie_Click);
            // 
            // dsbtnUsunPierwsa
            // 
            this.dsbtnUsunPierwsa.Enabled = false;
            this.dsbtnUsunPierwsa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dsbtnUsunPierwsa.Location = new System.Drawing.Point(280, 12);
            this.dsbtnUsunPierwsa.Name = "dsbtnUsunPierwsa";
            this.dsbtnUsunPierwsa.Size = new System.Drawing.Size(123, 44);
            this.dsbtnUsunPierwsa.TabIndex = 16;
            this.dsbtnUsunPierwsa.Text = "Usuń pierwszą dodaną bryłę";
            this.dsbtnUsunPierwsa.UseVisualStyleBackColor = true;
            this.dsbtnUsunPierwsa.Click += new System.EventHandler(this.dsbtnUsunPierwsa_Click);
            // 
            // dsbtnUsunOstatnia
            // 
            this.dsbtnUsunOstatnia.Enabled = false;
            this.dsbtnUsunOstatnia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dsbtnUsunOstatnia.Location = new System.Drawing.Point(485, 14);
            this.dsbtnUsunOstatnia.Name = "dsbtnUsunOstatnia";
            this.dsbtnUsunOstatnia.Size = new System.Drawing.Size(123, 43);
            this.dsbtnUsunOstatnia.TabIndex = 17;
            this.dsbtnUsunOstatnia.Text = "Usuń ostatnio dodaną bryłę";
            this.dsbtnUsunOstatnia.UseVisualStyleBackColor = true;
            this.dsbtnUsunOstatnia.Click += new System.EventHandler(this.dsbtnUsunOstatnia_Click);
            // 
            // dsbtnUsunWybrana
            // 
            this.dsbtnUsunWybrana.Enabled = false;
            this.dsbtnUsunWybrana.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dsbtnUsunWybrana.Location = new System.Drawing.Point(690, 14);
            this.dsbtnUsunWybrana.Name = "dsbtnUsunWybrana";
            this.dsbtnUsunWybrana.Size = new System.Drawing.Size(123, 43);
            this.dsbtnUsunWybrana.TabIndex = 18;
            this.dsbtnUsunWybrana.Text = "Usuń wybraną bryłę";
            this.dsbtnUsunWybrana.UseVisualStyleBackColor = true;
            this.dsbtnUsunWybrana.Click += new System.EventHandler(this.dsbtnUsunWybrana_Click);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(878, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 47);
            this.label5.TabIndex = 19;
            this.label5.Text = "Podaj numer usuwanej bryły";
            // 
            // dsgbPokaz
            // 
            this.dsgbPokaz.Controls.Add(this.dsrbpolepowierzchni);
            this.dsgbPokaz.Controls.Add(this.dsrbobietosc);
            this.dsgbPokaz.Controls.Add(this.dsrbWysokosc);
            this.dsgbPokaz.Enabled = false;
            this.dsgbPokaz.Location = new System.Drawing.Point(273, 653);
            this.dsgbPokaz.Name = "dsgbPokaz";
            this.dsgbPokaz.Size = new System.Drawing.Size(509, 46);
            this.dsgbPokaz.TabIndex = 21;
            this.dsgbPokaz.TabStop = false;
            this.dsgbPokaz.Text = "Kryteria pokazu brył geometrzycznych";
            // 
            // dsrbpolepowierzchni
            // 
            this.dsrbpolepowierzchni.AutoSize = true;
            this.dsrbpolepowierzchni.Location = new System.Drawing.Point(346, 20);
            this.dsrbpolepowierzchni.Name = "dsrbpolepowierzchni";
            this.dsrbpolepowierzchni.Size = new System.Drawing.Size(127, 20);
            this.dsrbpolepowierzchni.TabIndex = 3;
            this.dsrbpolepowierzchni.Text = "Pole powierzchni";
            this.dsrbpolepowierzchni.UseVisualStyleBackColor = true;
            // 
            // dsrbobietosc
            // 
            this.dsrbobietosc.AutoSize = true;
            this.dsrbobietosc.Location = new System.Drawing.Point(190, 20);
            this.dsrbobietosc.Name = "dsrbobietosc";
            this.dsrbobietosc.Size = new System.Drawing.Size(80, 20);
            this.dsrbobietosc.TabIndex = 2;
            this.dsrbobietosc.Text = "Obiętość";
            this.dsrbobietosc.UseVisualStyleBackColor = true;
            // 
            // dsrbWysokosc
            // 
            this.dsrbWysokosc.AutoSize = true;
            this.dsrbWysokosc.Checked = true;
            this.dsrbWysokosc.Location = new System.Drawing.Point(26, 20);
            this.dsrbWysokosc.Name = "dsrbWysokosc";
            this.dsrbWysokosc.Size = new System.Drawing.Size(90, 20);
            this.dsrbWysokosc.TabIndex = 0;
            this.dsrbWysokosc.TabStop = true;
            this.dsrbWysokosc.Text = "Wysokość";
            this.dsrbWysokosc.UseVisualStyleBackColor = true;
            // 
            // dsgbpokazslajder
            // 
            this.dsgbpokazslajder.Controls.Add(this.dsrbAutomatyczny);
            this.dsgbpokazslajder.Controls.Add(this.dsrbManualny);
            this.dsgbpokazslajder.Enabled = false;
            this.dsgbpokazslajder.Location = new System.Drawing.Point(1132, 45);
            this.dsgbpokazslajder.Name = "dsgbpokazslajder";
            this.dsgbpokazslajder.Size = new System.Drawing.Size(141, 97);
            this.dsgbpokazslajder.TabIndex = 22;
            this.dsgbpokazslajder.TabStop = false;
            this.dsgbpokazslajder.Text = "Pokaz slajdów";
            // 
            // dsrbAutomatyczny
            // 
            this.dsrbAutomatyczny.AutoSize = true;
            this.dsrbAutomatyczny.Checked = true;
            this.dsrbAutomatyczny.Location = new System.Drawing.Point(17, 56);
            this.dsrbAutomatyczny.Name = "dsrbAutomatyczny";
            this.dsrbAutomatyczny.Size = new System.Drawing.Size(109, 20);
            this.dsrbAutomatyczny.TabIndex = 1;
            this.dsrbAutomatyczny.TabStop = true;
            this.dsrbAutomatyczny.Text = "Automatyczny";
            this.dsrbAutomatyczny.UseVisualStyleBackColor = true;
            // 
            // dsrbManualny
            // 
            this.dsrbManualny.AutoSize = true;
            this.dsrbManualny.Location = new System.Drawing.Point(17, 25);
            this.dsrbManualny.Name = "dsrbManualny";
            this.dsrbManualny.Size = new System.Drawing.Size(84, 20);
            this.dsrbManualny.TabIndex = 0;
            this.dsrbManualny.Text = "Manualny";
            this.dsrbManualny.UseVisualStyleBackColor = true;
            // 
            // dsbtnslajderOn
            // 
            this.dsbtnslajderOn.Enabled = false;
            this.dsbtnslajderOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dsbtnslajderOn.Location = new System.Drawing.Point(1134, 170);
            this.dsbtnslajderOn.Name = "dsbtnslajderOn";
            this.dsbtnslajderOn.Size = new System.Drawing.Size(139, 65);
            this.dsbtnslajderOn.TabIndex = 23;
            this.dsbtnslajderOn.Text = "Włącz slajder figur geometrycznych";
            this.dsbtnslajderOn.UseVisualStyleBackColor = true;
            this.dsbtnslajderOn.Click += new System.EventHandler(this.dsbtnslajderOn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(1158, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 16);
            this.label6.TabIndex = 26;
            this.label6.Text = "Numer Figury";
            // 
            // dsbtnpoprzedni
            // 
            this.dsbtnpoprzedni.Enabled = false;
            this.dsbtnpoprzedni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dsbtnpoprzedni.Location = new System.Drawing.Point(1223, 324);
            this.dsbtnpoprzedni.Name = "dsbtnpoprzedni";
            this.dsbtnpoprzedni.Size = new System.Drawing.Size(87, 46);
            this.dsbtnpoprzedni.TabIndex = 25;
            this.dsbtnpoprzedni.Text = "Poprzedni";
            this.dsbtnpoprzedni.UseVisualStyleBackColor = true;
            this.dsbtnpoprzedni.Click += new System.EventHandler(this.dsbtnpoprzedni_Click);
            // 
            // dsbtnnastepny
            // 
            this.dsbtnnastepny.Enabled = false;
            this.dsbtnnastepny.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dsbtnnastepny.Location = new System.Drawing.Point(1097, 324);
            this.dsbtnnastepny.Name = "dsbtnnastepny";
            this.dsbtnnastepny.Size = new System.Drawing.Size(87, 46);
            this.dsbtnnastepny.TabIndex = 24;
            this.dsbtnnastepny.Text = "Następny";
            this.dsbtnnastepny.UseVisualStyleBackColor = true;
            this.dsbtnnastepny.Click += new System.EventHandler(this.dsbtnnastepny_Click);
            // 
            // dsbtnSlajderOff
            // 
            this.dsbtnSlajderOff.Enabled = false;
            this.dsbtnSlajderOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dsbtnSlajderOff.Location = new System.Drawing.Point(1134, 386);
            this.dsbtnSlajderOff.Name = "dsbtnSlajderOff";
            this.dsbtnSlajderOff.Size = new System.Drawing.Size(139, 65);
            this.dsbtnSlajderOff.TabIndex = 27;
            this.dsbtnSlajderOff.Text = "Wyłącz slajder figur geometrycznych";
            this.dsbtnSlajderOff.UseVisualStyleBackColor = true;
            this.dsbtnSlajderOff.Click += new System.EventHandler(this.dsbtnSlajderOff_Click);
            // 
            // dstbnumerSlajder
            // 
            this.dstbnumerSlajder.Location = new System.Drawing.Point(1180, 287);
            this.dstbnumerSlajder.Name = "dstbnumerSlajder";
            this.dstbnumerSlajder.Size = new System.Drawing.Size(44, 21);
            this.dstbnumerSlajder.TabIndex = 28;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // dsTimerObrotow
            // 
            this.dsTimerObrotow.Tick += new System.EventHandler(this.dsTimerObrotow_Tick);
            // 
            // dscmbPodstawaBryly
            // 
            this.dscmbPodstawaBryly.FormattingEnabled = true;
            this.dscmbPodstawaBryly.Items.AddRange(new object[] {
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.dscmbPodstawaBryly.Location = new System.Drawing.Point(150, 226);
            this.dscmbPodstawaBryly.Name = "dscmbPodstawaBryly";
            this.dscmbPodstawaBryly.Size = new System.Drawing.Size(45, 23);
            this.dscmbPodstawaBryly.TabIndex = 29;
            this.dscmbPodstawaBryly.Text = "0";
            // 
            // dsdNumerUsuwanej
            // 
            this.dsdNumerUsuwanej.Location = new System.Drawing.Point(998, 24);
            this.dsdNumerUsuwanej.Name = "dsdNumerUsuwanej";
            this.dsdNumerUsuwanej.Size = new System.Drawing.Size(47, 21);
            this.dsdNumerUsuwanej.TabIndex = 51;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dsbtnReset
            // 
            this.dsbtnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dsbtnReset.Enabled = false;
            this.dsbtnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dsbtnReset.Location = new System.Drawing.Point(1180, 660);
            this.dsbtnReset.Name = "dsbtnReset";
            this.dsbtnReset.Size = new System.Drawing.Size(87, 46);
            this.dsbtnReset.TabIndex = 52;
            this.dsbtnReset.Text = "RESET";
            this.dsbtnReset.UseVisualStyleBackColor = true;
            this.dsbtnReset.Click += new System.EventHandler(this.dsbtnReset_Click);
            // 
            // dsPanelKontrolek
            // 
            this.dsPanelKontrolek.BackColor = System.Drawing.SystemColors.Info;
            this.dsPanelKontrolek.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dsPanelKontrolek.Location = new System.Drawing.Point(1099, 468);
            this.dsPanelKontrolek.Name = "dsPanelKontrolek";
            this.dsPanelKontrolek.Size = new System.Drawing.Size(200, 178);
            this.dsPanelKontrolek.TabIndex = 53;
            this.dsPanelKontrolek.Visible = false;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(995, 664);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 35);
            this.label7.TabIndex = 54;
            this.label7.Text = "Samoocena projectu: 5";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(859, 664);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 35);
            this.label8.TabIndex = 55;
            this.label8.Text = "Samoocena sprawdzianu: 5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1311, 713);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dsPanelKontrolek);
            this.Controls.Add(this.dsbtnReset);
            this.Controls.Add(this.dsbtnDodaj);
            this.Controls.Add(this.dsdNumerUsuwanej);
            this.Controls.Add(this.dscmbPodstawaBryly);
            this.Controls.Add(this.dstbnumerSlajder);
            this.Controls.Add(this.dsbtnSlajderOff);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dsbtnpoprzedni);
            this.Controls.Add(this.dsbtnnastepny);
            this.Controls.Add(this.dsbtnslajderOn);
            this.Controls.Add(this.dsgbpokazslajder);
            this.Controls.Add(this.dsgbPokaz);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dsbtnUsunWybrana);
            this.Controls.Add(this.dsbtnUsunOstatnia);
            this.Controls.Add(this.dsbtnUsunPierwsa);
            this.Controls.Add(this.dsbtnWylosujNowepolozenie);
            this.Controls.Add(this.dsbtnAtrybutyLosowo);
            this.Controls.Add(this.dsbtnKierunekObrotuLewo);
            this.Controls.Add(this.dsbtnKierunekObrotuPrawo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dstbkat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dstbWysokosc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dscmbWybierz);
            this.Controls.Add(this.dstbPromien);
            this.Controls.Add(this.dspbRysownica);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "Form1";
            this.Text = "Wizualizacja brył geometrycznych";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dspbRysownica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dstbPromien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dstbWysokosc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dstbkat)).EndInit();
            this.dsgbPokaz.ResumeLayout(false);
            this.dsgbPokaz.PerformLayout();
            this.dsgbpokazslajder.ResumeLayout(false);
            this.dsgbpokazslajder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox dspbRysownica;
        private System.Windows.Forms.TrackBar dstbPromien;
        private System.Windows.Forms.ComboBox dscmbWybierz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar dstbWysokosc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar dstbkat;
        private System.Windows.Forms.Button dsbtnDodaj;
        private System.Windows.Forms.Button dsbtnKierunekObrotuPrawo;
        private System.Windows.Forms.Button dsbtnKierunekObrotuLewo;
        private System.Windows.Forms.Button dsbtnAtrybutyLosowo;
        private System.Windows.Forms.Button dsbtnWylosujNowepolozenie;
        private System.Windows.Forms.Button dsbtnUsunPierwsa;
        private System.Windows.Forms.Button dsbtnUsunOstatnia;
        private System.Windows.Forms.Button dsbtnUsunWybrana;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox dsgbPokaz;
        private System.Windows.Forms.RadioButton dsrbpolepowierzchni;
        private System.Windows.Forms.RadioButton dsrbobietosc;
        private System.Windows.Forms.RadioButton dsrbWysokosc;
        private System.Windows.Forms.GroupBox dsgbpokazslajder;
        private System.Windows.Forms.RadioButton dsrbAutomatyczny;
        private System.Windows.Forms.RadioButton dsrbManualny;
        private System.Windows.Forms.Button dsbtnslajderOn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button dsbtnpoprzedni;
        private System.Windows.Forms.Button dsbtnnastepny;
        private System.Windows.Forms.Button dsbtnSlajderOff;
        private System.Windows.Forms.TextBox dstbnumerSlajder;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Timer dsTimerObrotow;
        private System.Windows.Forms.ComboBox dscmbPodstawaBryly;
        private System.Windows.Forms.TextBox dsdNumerUsuwanej;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button dsbtnReset;
        private System.Windows.Forms.Panel dsPanelKontrolek;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}

