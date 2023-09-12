namespace WinForms_Zapravka
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.grbAvtozapravka = new System.Windows.Forms.GroupBox();
            this.lblGrn = new System.Windows.Forms.Label();
            this.lblL = new System.Windows.Forms.Label();
            this.txbRub = new System.Windows.Forms.TextBox();
            this.txbLitri = new System.Windows.Forms.TextBox();
            this.grbKolSumm = new System.Windows.Forms.GroupBox();
            this.rdbSumm = new System.Windows.Forms.RadioButton();
            this.rdbKol = new System.Windows.Forms.RadioButton();
            this.txbZena_Benzin = new System.Windows.Forms.TextBox();
            this.cmbBenzin = new System.Windows.Forms.ComboBox();
            this.lblZena = new System.Windows.Forms.Label();
            this.lblBenzin = new System.Windows.Forms.Label();
            this.grbKOplate_Avtozapr = new System.Windows.Forms.GroupBox();
            this.lblRubIliLitri = new System.Windows.Forms.Label();
            this.lblKOplate_Avtozapr = new System.Windows.Forms.Label();
            this.grbMiniKafe = new System.Windows.Forms.GroupBox();
            this.txbCol_Kola = new System.Windows.Forms.TextBox();
            this.txbZena_Kola = new System.Windows.Forms.TextBox();
            this.txbCol_Fri = new System.Windows.Forms.TextBox();
            this.txbZena_Fri = new System.Windows.Forms.TextBox();
            this.txbCol_Gamburg = new System.Windows.Forms.TextBox();
            this.txbZena_Gamburg = new System.Windows.Forms.TextBox();
            this.txbCol_ChotDog = new System.Windows.Forms.TextBox();
            this.txbZena_ChotDog = new System.Windows.Forms.TextBox();
            this.lblCol_Kafe = new System.Windows.Forms.Label();
            this.lblZena_Kafe = new System.Windows.Forms.Label();
            this.chbKola = new System.Windows.Forms.CheckBox();
            this.chbFri = new System.Windows.Forms.CheckBox();
            this.chbGamburger = new System.Windows.Forms.CheckBox();
            this.chbChotDog = new System.Windows.Forms.CheckBox();
            this.grbKOplate_MiniKafe = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblKOplate_MiniKafe = new System.Windows.Forms.Label();
            this.grbKOplate_Vsego = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblKOplate_Vsego = new System.Windows.Forms.Label();
            this.btnPoschitat = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.grbVirutschZaDen = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblVsegoZaDen = new System.Windows.Forms.Label();
            this.grbAvtozapravka.SuspendLayout();
            this.grbKolSumm.SuspendLayout();
            this.grbKOplate_Avtozapr.SuspendLayout();
            this.grbMiniKafe.SuspendLayout();
            this.grbKOplate_MiniKafe.SuspendLayout();
            this.grbKOplate_Vsego.SuspendLayout();
            this.grbVirutschZaDen.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbAvtozapravka
            // 
            this.grbAvtozapravka.Controls.Add(this.grbVirutschZaDen);
            this.grbAvtozapravka.Controls.Add(this.lblGrn);
            this.grbAvtozapravka.Controls.Add(this.grbKOplate_Vsego);
            this.grbAvtozapravka.Controls.Add(this.lblL);
            this.grbAvtozapravka.Controls.Add(this.grbMiniKafe);
            this.grbAvtozapravka.Controls.Add(this.txbRub);
            this.grbAvtozapravka.Controls.Add(this.txbLitri);
            this.grbAvtozapravka.Controls.Add(this.grbKolSumm);
            this.grbAvtozapravka.Controls.Add(this.txbZena_Benzin);
            this.grbAvtozapravka.Controls.Add(this.cmbBenzin);
            this.grbAvtozapravka.Controls.Add(this.lblZena);
            this.grbAvtozapravka.Controls.Add(this.lblBenzin);
            this.grbAvtozapravka.Controls.Add(this.grbKOplate_Avtozapr);
            this.grbAvtozapravka.Location = new System.Drawing.Point(0, 3);
            this.grbAvtozapravka.Name = "grbAvtozapravka";
            this.grbAvtozapravka.Size = new System.Drawing.Size(547, 472);
            this.grbAvtozapravka.TabIndex = 0;
            this.grbAvtozapravka.TabStop = false;
            this.grbAvtozapravka.Text = "Автозаправка";
            // 
            // lblGrn
            // 
            this.lblGrn.AutoSize = true;
            this.lblGrn.Location = new System.Drawing.Point(186, 145);
            this.lblGrn.Name = "lblGrn";
            this.lblGrn.Size = new System.Drawing.Size(27, 13);
            this.lblGrn.TabIndex = 9;
            this.lblGrn.Text = "руб.";
            // 
            // lblL
            // 
            this.lblL.AutoSize = true;
            this.lblL.Location = new System.Drawing.Point(186, 120);
            this.lblL.Name = "lblL";
            this.lblL.Size = new System.Drawing.Size(16, 13);
            this.lblL.TabIndex = 8;
            this.lblL.Text = "л.";
            // 
            // txbRub
            // 
            this.txbRub.Enabled = false;
            this.txbRub.Location = new System.Drawing.Point(124, 140);
            this.txbRub.Name = "txbRub";
            this.txbRub.Size = new System.Drawing.Size(52, 20);
            this.txbRub.TabIndex = 7;
            this.txbRub.TextChanged += new System.EventHandler(this.txbGrn_TextChanged);
            // 
            // txbLitri
            // 
            this.txbLitri.Enabled = false;
            this.txbLitri.Location = new System.Drawing.Point(124, 118);
            this.txbLitri.Name = "txbLitri";
            this.txbLitri.Size = new System.Drawing.Size(52, 20);
            this.txbLitri.TabIndex = 6;
            this.txbLitri.TextChanged += new System.EventHandler(this.txbLitri_TextChanged);
            // 
            // grbKolSumm
            // 
            this.grbKolSumm.Controls.Add(this.rdbSumm);
            this.grbKolSumm.Controls.Add(this.rdbKol);
            this.grbKolSumm.Location = new System.Drawing.Point(21, 100);
            this.grbKolSumm.Name = "grbKolSumm";
            this.grbKolSumm.Size = new System.Drawing.Size(96, 64);
            this.grbKolSumm.TabIndex = 5;
            this.grbKolSumm.TabStop = false;
            // 
            // rdbSumm
            // 
            this.rdbSumm.AutoSize = true;
            this.rdbSumm.Location = new System.Drawing.Point(6, 41);
            this.rdbSumm.Name = "rdbSumm";
            this.rdbSumm.Size = new System.Drawing.Size(59, 17);
            this.rdbSumm.TabIndex = 1;
            this.rdbSumm.Text = "Сумма";
            this.rdbSumm.UseVisualStyleBackColor = true;
            this.rdbSumm.CheckedChanged += new System.EventHandler(this.rdbSumm_CheckedChanged);
            // 
            // rdbKol
            // 
            this.rdbKol.AutoSize = true;
            this.rdbKol.Location = new System.Drawing.Point(6, 18);
            this.rdbKol.Name = "rdbKol";
            this.rdbKol.Size = new System.Drawing.Size(84, 17);
            this.rdbKol.TabIndex = 0;
            this.rdbKol.Text = "Количество";
            this.rdbKol.UseVisualStyleBackColor = true;
            this.rdbKol.CheckedChanged += new System.EventHandler(this.rdbKol_CheckedChanged);
            // 
            // txbZena_Benzin
            // 
            this.txbZena_Benzin.Enabled = false;
            this.txbZena_Benzin.Location = new System.Drawing.Point(85, 63);
            this.txbZena_Benzin.Name = "txbZena_Benzin";
            this.txbZena_Benzin.Size = new System.Drawing.Size(121, 20);
            this.txbZena_Benzin.TabIndex = 4;
            // 
            // cmbBenzin
            // 
            this.cmbBenzin.FormattingEnabled = true;
            this.cmbBenzin.Location = new System.Drawing.Point(85, 23);
            this.cmbBenzin.Name = "cmbBenzin";
            this.cmbBenzin.Size = new System.Drawing.Size(121, 21);
            this.cmbBenzin.TabIndex = 3;
            this.cmbBenzin.SelectedIndexChanged += new System.EventHandler(this.cmbBenzin_SelectedIndexChanged_1);
            // 
            // lblZena
            // 
            this.lblZena.AutoSize = true;
            this.lblZena.Location = new System.Drawing.Point(21, 66);
            this.lblZena.Name = "lblZena";
            this.lblZena.Size = new System.Drawing.Size(33, 13);
            this.lblZena.TabIndex = 2;
            this.lblZena.Text = "Цена";
            // 
            // lblBenzin
            // 
            this.lblBenzin.AutoSize = true;
            this.lblBenzin.Location = new System.Drawing.Point(18, 26);
            this.lblBenzin.Name = "lblBenzin";
            this.lblBenzin.Size = new System.Drawing.Size(44, 13);
            this.lblBenzin.TabIndex = 1;
            this.lblBenzin.Text = "Бензин";
            // 
            // grbKOplate_Avtozapr
            // 
            this.grbKOplate_Avtozapr.Controls.Add(this.lblRubIliLitri);
            this.grbKOplate_Avtozapr.Controls.Add(this.lblKOplate_Avtozapr);
            this.grbKOplate_Avtozapr.Location = new System.Drawing.Point(21, 191);
            this.grbKOplate_Avtozapr.Name = "grbKOplate_Avtozapr";
            this.grbKOplate_Avtozapr.Size = new System.Drawing.Size(185, 68);
            this.grbKOplate_Avtozapr.TabIndex = 0;
            this.grbKOplate_Avtozapr.TabStop = false;
            this.grbKOplate_Avtozapr.Text = "К оплате:";
            // 
            // lblRubIliLitri
            // 
            this.lblRubIliLitri.AutoSize = true;
            this.lblRubIliLitri.Location = new System.Drawing.Point(152, 40);
            this.lblRubIliLitri.Name = "lblRubIliLitri";
            this.lblRubIliLitri.Size = new System.Drawing.Size(27, 13);
            this.lblRubIliLitri.TabIndex = 10;
            this.lblRubIliLitri.Text = "руб.";
            // 
            // lblKOplate_Avtozapr
            // 
            this.lblKOplate_Avtozapr.AutoSize = true;
            this.lblKOplate_Avtozapr.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblKOplate_Avtozapr.Location = new System.Drawing.Point(23, 28);
            this.lblKOplate_Avtozapr.Name = "lblKOplate_Avtozapr";
            this.lblKOplate_Avtozapr.Size = new System.Drawing.Size(67, 31);
            this.lblKOplate_Avtozapr.TabIndex = 0;
            this.lblKOplate_Avtozapr.Text = "0,00";
            // 
            // grbMiniKafe
            // 
            this.grbMiniKafe.Controls.Add(this.txbCol_Kola);
            this.grbMiniKafe.Controls.Add(this.txbZena_Kola);
            this.grbMiniKafe.Controls.Add(this.txbCol_Fri);
            this.grbMiniKafe.Controls.Add(this.txbZena_Fri);
            this.grbMiniKafe.Controls.Add(this.txbCol_Gamburg);
            this.grbMiniKafe.Controls.Add(this.txbZena_Gamburg);
            this.grbMiniKafe.Controls.Add(this.txbCol_ChotDog);
            this.grbMiniKafe.Controls.Add(this.txbZena_ChotDog);
            this.grbMiniKafe.Controls.Add(this.lblCol_Kafe);
            this.grbMiniKafe.Controls.Add(this.lblZena_Kafe);
            this.grbMiniKafe.Controls.Add(this.chbKola);
            this.grbMiniKafe.Controls.Add(this.chbFri);
            this.grbMiniKafe.Controls.Add(this.chbGamburger);
            this.grbMiniKafe.Controls.Add(this.chbChotDog);
            this.grbMiniKafe.Controls.Add(this.grbKOplate_MiniKafe);
            this.grbMiniKafe.Location = new System.Drawing.Point(0, 279);
            this.grbMiniKafe.Name = "grbMiniKafe";
            this.grbMiniKafe.Size = new System.Drawing.Size(547, 193);
            this.grbMiniKafe.TabIndex = 1;
            this.grbMiniKafe.TabStop = false;
            this.grbMiniKafe.Text = "Мини-Кафе";
            // 
            // txbCol_Kola
            // 
            this.txbCol_Kola.Enabled = false;
            this.txbCol_Kola.Location = new System.Drawing.Point(187, 148);
            this.txbCol_Kola.Name = "txbCol_Kola";
            this.txbCol_Kola.Size = new System.Drawing.Size(48, 20);
            this.txbCol_Kola.TabIndex = 15;
            this.txbCol_Kola.TextChanged += new System.EventHandler(this.txbCol_Kola_TextChanged);
            // 
            // txbZena_Kola
            // 
            this.txbZena_Kola.Enabled = false;
            this.txbZena_Kola.Location = new System.Drawing.Point(120, 148);
            this.txbZena_Kola.Name = "txbZena_Kola";
            this.txbZena_Kola.Size = new System.Drawing.Size(48, 20);
            this.txbZena_Kola.TabIndex = 14;
            this.txbZena_Kola.Text = "54,40";
            // 
            // txbCol_Fri
            // 
            this.txbCol_Fri.Enabled = false;
            this.txbCol_Fri.Location = new System.Drawing.Point(187, 113);
            this.txbCol_Fri.Name = "txbCol_Fri";
            this.txbCol_Fri.Size = new System.Drawing.Size(48, 20);
            this.txbCol_Fri.TabIndex = 13;
            this.txbCol_Fri.TextChanged += new System.EventHandler(this.txbCol_Fri_TextChanged);
            // 
            // txbZena_Fri
            // 
            this.txbZena_Fri.Enabled = false;
            this.txbZena_Fri.Location = new System.Drawing.Point(120, 113);
            this.txbZena_Fri.Name = "txbZena_Fri";
            this.txbZena_Fri.Size = new System.Drawing.Size(48, 20);
            this.txbZena_Fri.TabIndex = 12;
            this.txbZena_Fri.Text = "76,20";
            // 
            // txbCol_Gamburg
            // 
            this.txbCol_Gamburg.Enabled = false;
            this.txbCol_Gamburg.Location = new System.Drawing.Point(187, 78);
            this.txbCol_Gamburg.Name = "txbCol_Gamburg";
            this.txbCol_Gamburg.Size = new System.Drawing.Size(48, 20);
            this.txbCol_Gamburg.TabIndex = 11;
            this.txbCol_Gamburg.TextChanged += new System.EventHandler(this.txbCol_Gamburg_TextChanged);
            // 
            // txbZena_Gamburg
            // 
            this.txbZena_Gamburg.Enabled = false;
            this.txbZena_Gamburg.Location = new System.Drawing.Point(120, 78);
            this.txbZena_Gamburg.Name = "txbZena_Gamburg";
            this.txbZena_Gamburg.Size = new System.Drawing.Size(48, 20);
            this.txbZena_Gamburg.TabIndex = 10;
            this.txbZena_Gamburg.Text = "125,40";
            // 
            // txbCol_ChotDog
            // 
            this.txbCol_ChotDog.Enabled = false;
            this.txbCol_ChotDog.Location = new System.Drawing.Point(187, 43);
            this.txbCol_ChotDog.Name = "txbCol_ChotDog";
            this.txbCol_ChotDog.Size = new System.Drawing.Size(48, 20);
            this.txbCol_ChotDog.TabIndex = 9;
            this.txbCol_ChotDog.TextChanged += new System.EventHandler(this.txbCol_ChotDog_TextChanged);
            // 
            // txbZena_ChotDog
            // 
            this.txbZena_ChotDog.Enabled = false;
            this.txbZena_ChotDog.Location = new System.Drawing.Point(120, 43);
            this.txbZena_ChotDog.Name = "txbZena_ChotDog";
            this.txbZena_ChotDog.Size = new System.Drawing.Size(48, 20);
            this.txbZena_ChotDog.TabIndex = 8;
            this.txbZena_ChotDog.Text = "111,00";
            // 
            // lblCol_Kafe
            // 
            this.lblCol_Kafe.AutoSize = true;
            this.lblCol_Kafe.Location = new System.Drawing.Point(179, 20);
            this.lblCol_Kafe.Name = "lblCol_Kafe";
            this.lblCol_Kafe.Size = new System.Drawing.Size(66, 13);
            this.lblCol_Kafe.TabIndex = 7;
            this.lblCol_Kafe.Text = "Количество";
            // 
            // lblZena_Kafe
            // 
            this.lblZena_Kafe.AutoSize = true;
            this.lblZena_Kafe.Location = new System.Drawing.Point(126, 20);
            this.lblZena_Kafe.Name = "lblZena_Kafe";
            this.lblZena_Kafe.Size = new System.Drawing.Size(33, 13);
            this.lblZena_Kafe.TabIndex = 6;
            this.lblZena_Kafe.Text = "Цена";
            // 
            // chbKola
            // 
            this.chbKola.AutoSize = true;
            this.chbKola.Location = new System.Drawing.Point(6, 150);
            this.chbKola.Name = "chbKola";
            this.chbKola.Size = new System.Drawing.Size(78, 17);
            this.chbKola.TabIndex = 5;
            this.chbKola.Text = "Кока-кола";
            this.chbKola.UseVisualStyleBackColor = true;
            this.chbKola.CheckedChanged += new System.EventHandler(this.chbKola_CheckedChanged);
            // 
            // chbFri
            // 
            this.chbFri.AutoSize = true;
            this.chbFri.Location = new System.Drawing.Point(6, 115);
            this.chbFri.Name = "chbFri";
            this.chbFri.Size = new System.Drawing.Size(99, 17);
            this.chbFri.TabIndex = 4;
            this.chbFri.Text = "Картошка фри";
            this.chbFri.UseVisualStyleBackColor = true;
            this.chbFri.CheckedChanged += new System.EventHandler(this.chbFri_CheckedChanged);
            // 
            // chbGamburger
            // 
            this.chbGamburger.AutoSize = true;
            this.chbGamburger.Location = new System.Drawing.Point(6, 80);
            this.chbGamburger.Name = "chbGamburger";
            this.chbGamburger.Size = new System.Drawing.Size(80, 17);
            this.chbGamburger.TabIndex = 3;
            this.chbGamburger.Text = "Гамбургер";
            this.chbGamburger.UseVisualStyleBackColor = true;
            this.chbGamburger.CheckedChanged += new System.EventHandler(this.chbGamburger_CheckedChanged);
            // 
            // chbChotDog
            // 
            this.chbChotDog.AutoSize = true;
            this.chbChotDog.Location = new System.Drawing.Point(6, 45);
            this.chbChotDog.Name = "chbChotDog";
            this.chbChotDog.Size = new System.Drawing.Size(64, 17);
            this.chbChotDog.TabIndex = 2;
            this.chbChotDog.Text = "Хот-дог";
            this.chbChotDog.UseVisualStyleBackColor = true;
            this.chbChotDog.CheckedChanged += new System.EventHandler(this.chbChotDog_CheckedChanged);
            // 
            // grbKOplate_MiniKafe
            // 
            this.grbKOplate_MiniKafe.Controls.Add(this.label3);
            this.grbKOplate_MiniKafe.Controls.Add(this.lblKOplate_MiniKafe);
            this.grbKOplate_MiniKafe.Location = new System.Drawing.Point(283, 64);
            this.grbKOplate_MiniKafe.Name = "grbKOplate_MiniKafe";
            this.grbKOplate_MiniKafe.Size = new System.Drawing.Size(228, 68);
            this.grbKOplate_MiniKafe.TabIndex = 1;
            this.grbKOplate_MiniKafe.TabStop = false;
            this.grbKOplate_MiniKafe.Text = "К оплате:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(173, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "руб.";
            // 
            // lblKOplate_MiniKafe
            // 
            this.lblKOplate_MiniKafe.AutoSize = true;
            this.lblKOplate_MiniKafe.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblKOplate_MiniKafe.Location = new System.Drawing.Point(65, 25);
            this.lblKOplate_MiniKafe.Name = "lblKOplate_MiniKafe";
            this.lblKOplate_MiniKafe.Size = new System.Drawing.Size(67, 31);
            this.lblKOplate_MiniKafe.TabIndex = 1;
            this.lblKOplate_MiniKafe.Text = "0,00";
            // 
            // grbKOplate_Vsego
            // 
            this.grbKOplate_Vsego.Controls.Add(this.label4);
            this.grbKOplate_Vsego.Controls.Add(this.lblKOplate_Vsego);
            this.grbKOplate_Vsego.Controls.Add(this.btnPoschitat);
            this.grbKOplate_Vsego.Location = new System.Drawing.Point(254, 100);
            this.grbKOplate_Vsego.Name = "grbKOplate_Vsego";
            this.grbKOplate_Vsego.Size = new System.Drawing.Size(287, 173);
            this.grbKOplate_Vsego.TabIndex = 2;
            this.grbKOplate_Vsego.TabStop = false;
            this.grbKOplate_Vsego.Text = "Всего к оплате";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(134, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "руб.";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblKOplate_Vsego
            // 
            this.lblKOplate_Vsego.AutoSize = true;
            this.lblKOplate_Vsego.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblKOplate_Vsego.Location = new System.Drawing.Point(6, 131);
            this.lblKOplate_Vsego.Name = "lblKOplate_Vsego";
            this.lblKOplate_Vsego.Size = new System.Drawing.Size(67, 31);
            this.lblKOplate_Vsego.TabIndex = 2;
            this.lblKOplate_Vsego.Text = "0,00";
            // 
            // btnPoschitat
            // 
            this.btnPoschitat.Location = new System.Drawing.Point(104, 35);
            this.btnPoschitat.Name = "btnPoschitat";
            this.btnPoschitat.Size = new System.Drawing.Size(156, 60);
            this.btnPoschitat.TabIndex = 0;
            this.btnPoschitat.Text = "Посчитать";
            this.btnPoschitat.UseVisualStyleBackColor = true;
            this.btnPoschitat.Click += new System.EventHandler(this.btnPoschitat_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // grbVirutschZaDen
            // 
            this.grbVirutschZaDen.Controls.Add(this.label2);
            this.grbVirutschZaDen.Controls.Add(this.lblVsegoZaDen);
            this.grbVirutschZaDen.Location = new System.Drawing.Point(283, 9);
            this.grbVirutschZaDen.Name = "grbVirutschZaDen";
            this.grbVirutschZaDen.Size = new System.Drawing.Size(264, 65);
            this.grbVirutschZaDen.TabIndex = 3;
            this.grbVirutschZaDen.TabStop = false;
            this.grbVirutschZaDen.Text = "Выручка за день";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(198, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "руб.";
            // 
            // lblVsegoZaDen
            // 
            this.lblVsegoZaDen.AutoSize = true;
            this.lblVsegoZaDen.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblVsegoZaDen.Location = new System.Drawing.Point(114, 16);
            this.lblVsegoZaDen.Name = "lblVsegoZaDen";
            this.lblVsegoZaDen.Size = new System.Drawing.Size(67, 31);
            this.lblVsegoZaDen.TabIndex = 13;
            this.lblVsegoZaDen.Text = "0,00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1723, 930);
            this.Controls.Add(this.grbAvtozapravka);
            this.Name = "Form1";
            this.Text = "BestOil";
            this.grbAvtozapravka.ResumeLayout(false);
            this.grbAvtozapravka.PerformLayout();
            this.grbKolSumm.ResumeLayout(false);
            this.grbKolSumm.PerformLayout();
            this.grbKOplate_Avtozapr.ResumeLayout(false);
            this.grbKOplate_Avtozapr.PerformLayout();
            this.grbMiniKafe.ResumeLayout(false);
            this.grbMiniKafe.PerformLayout();
            this.grbKOplate_MiniKafe.ResumeLayout(false);
            this.grbKOplate_MiniKafe.PerformLayout();
            this.grbKOplate_Vsego.ResumeLayout(false);
            this.grbKOplate_Vsego.PerformLayout();
            this.grbVirutschZaDen.ResumeLayout(false);
            this.grbVirutschZaDen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbAvtozapravka;
        private System.Windows.Forms.Label lblGrn;
        private System.Windows.Forms.Label lblL;
        private System.Windows.Forms.TextBox txbRub;
        private System.Windows.Forms.TextBox txbLitri;
        private System.Windows.Forms.GroupBox grbKolSumm;
        private System.Windows.Forms.RadioButton rdbSumm;
        private System.Windows.Forms.RadioButton rdbKol;
        private System.Windows.Forms.TextBox txbZena_Benzin;
        private System.Windows.Forms.ComboBox cmbBenzin;
        private System.Windows.Forms.Label lblZena;
        private System.Windows.Forms.Label lblBenzin;
        private System.Windows.Forms.GroupBox grbKOplate_Avtozapr;
        private System.Windows.Forms.Label lblRubIliLitri;
        private System.Windows.Forms.Label lblKOplate_Avtozapr;
        private System.Windows.Forms.GroupBox grbMiniKafe;
        private System.Windows.Forms.TextBox txbCol_Kola;
        private System.Windows.Forms.TextBox txbZena_Kola;
        private System.Windows.Forms.TextBox txbCol_Fri;
        private System.Windows.Forms.TextBox txbZena_Fri;
        private System.Windows.Forms.TextBox txbCol_Gamburg;
        private System.Windows.Forms.TextBox txbZena_Gamburg;
        private System.Windows.Forms.TextBox txbCol_ChotDog;
        private System.Windows.Forms.TextBox txbZena_ChotDog;
        private System.Windows.Forms.Label lblCol_Kafe;
        private System.Windows.Forms.Label lblZena_Kafe;
        private System.Windows.Forms.CheckBox chbKola;
        private System.Windows.Forms.CheckBox chbFri;
        private System.Windows.Forms.CheckBox chbGamburger;
        private System.Windows.Forms.CheckBox chbChotDog;
        private System.Windows.Forms.GroupBox grbKOplate_MiniKafe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblKOplate_MiniKafe;
        private System.Windows.Forms.GroupBox grbKOplate_Vsego;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblKOplate_Vsego;
        private System.Windows.Forms.Button btnPoschitat;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.GroupBox grbVirutschZaDen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblVsegoZaDen;
    }
}

