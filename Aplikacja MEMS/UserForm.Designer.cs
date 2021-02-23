
namespace Aplikacja_MEMS
{
    partial class UserForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControlCzujniki = new System.Windows.Forms.TabControl();
            this.tabPageOgolne = new System.Windows.Forms.TabPage();
            this.gBoxCzujniki = new System.Windows.Forms.GroupBox();
            this.cBoxHigrometr = new System.Windows.Forms.ComboBox();
            this.cBoxBarometr = new System.Windows.Forms.ComboBox();
            this.cBoxTermometr = new System.Windows.Forms.ComboBox();
            this.cBoxMagnetometr = new System.Windows.Forms.ComboBox();
            this.cBoxZyroskop = new System.Windows.Forms.ComboBox();
            this.cBoxAkcelerometr = new System.Windows.Forms.ComboBox();
            this.labelHigrometr = new System.Windows.Forms.Label();
            this.labelBarometr = new System.Windows.Forms.Label();
            this.labelTermometr = new System.Windows.Forms.Label();
            this.labelMagnetometr = new System.Windows.Forms.Label();
            this.labelZyroskop = new System.Windows.Forms.Label();
            this.labelAkcelerometr = new System.Windows.Forms.Label();
            this.gBoxPolaczenie = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.progressBarDane = new System.Windows.Forms.ProgressBar();
            this.labelStatusDanych = new System.Windows.Forms.Label();
            this.labelPobieranieDanych = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.progressBarCOM = new System.Windows.Forms.ProgressBar();
            this.labelStatusCOM = new System.Windows.Forms.Label();
            this.buttonOtworz = new System.Windows.Forms.Button();
            this.buttonZamknij = new System.Windows.Forms.Button();
            this.cBoxPorty = new System.Windows.Forms.ComboBox();
            this.labelWyborPortu = new System.Windows.Forms.Label();
            this.gBoxInfo = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelBrakPlytek = new System.Windows.Forms.Label();
            this.labelDostepnePorty = new System.Windows.Forms.Label();
            this.labelWersja = new System.Windows.Forms.Label();
            this.lableTytul = new System.Windows.Forms.Label();
            this.tabPageCzujniki = new System.Windows.Forms.TabPage();
            this.tabPageDane = new System.Windows.Forms.TabPage();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edytujToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otworzPortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomocToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.oProgramieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.bgWorkerOtworz = new System.ComponentModel.BackgroundWorker();
            this.tabControlCzujniki.SuspendLayout();
            this.tabPageOgolne.SuspendLayout();
            this.gBoxCzujniki.SuspendLayout();
            this.gBoxPolaczenie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.gBoxInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlCzujniki
            // 
            this.tabControlCzujniki.Controls.Add(this.tabPageOgolne);
            this.tabControlCzujniki.Controls.Add(this.tabPageCzujniki);
            this.tabControlCzujniki.Controls.Add(this.tabPageDane);
            this.tabControlCzujniki.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlCzujniki.Location = new System.Drawing.Point(0, 24);
            this.tabControlCzujniki.Name = "tabControlCzujniki";
            this.tabControlCzujniki.SelectedIndex = 0;
            this.tabControlCzujniki.Size = new System.Drawing.Size(742, 500);
            this.tabControlCzujniki.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControlCzujniki.TabIndex = 0;
            // 
            // tabPageOgolne
            // 
            this.tabPageOgolne.Controls.Add(this.gBoxCzujniki);
            this.tabPageOgolne.Controls.Add(this.gBoxPolaczenie);
            this.tabPageOgolne.Controls.Add(this.gBoxInfo);
            this.tabPageOgolne.Location = new System.Drawing.Point(4, 22);
            this.tabPageOgolne.Name = "tabPageOgolne";
            this.tabPageOgolne.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOgolne.Size = new System.Drawing.Size(734, 474);
            this.tabPageOgolne.TabIndex = 0;
            this.tabPageOgolne.Text = "Ogólne";
            this.tabPageOgolne.UseVisualStyleBackColor = true;
            // 
            // gBoxCzujniki
            // 
            this.gBoxCzujniki.Controls.Add(this.cBoxHigrometr);
            this.gBoxCzujniki.Controls.Add(this.cBoxBarometr);
            this.gBoxCzujniki.Controls.Add(this.cBoxTermometr);
            this.gBoxCzujniki.Controls.Add(this.cBoxMagnetometr);
            this.gBoxCzujniki.Controls.Add(this.cBoxZyroskop);
            this.gBoxCzujniki.Controls.Add(this.cBoxAkcelerometr);
            this.gBoxCzujniki.Controls.Add(this.labelHigrometr);
            this.gBoxCzujniki.Controls.Add(this.labelBarometr);
            this.gBoxCzujniki.Controls.Add(this.labelTermometr);
            this.gBoxCzujniki.Controls.Add(this.labelMagnetometr);
            this.gBoxCzujniki.Controls.Add(this.labelZyroskop);
            this.gBoxCzujniki.Controls.Add(this.labelAkcelerometr);
            this.gBoxCzujniki.Dock = System.Windows.Forms.DockStyle.Top;
            this.gBoxCzujniki.Location = new System.Drawing.Point(3, 307);
            this.gBoxCzujniki.Name = "gBoxCzujniki";
            this.gBoxCzujniki.Size = new System.Drawing.Size(728, 144);
            this.gBoxCzujniki.TabIndex = 2;
            this.gBoxCzujniki.TabStop = false;
            this.gBoxCzujniki.Text = "Czujniki";
            // 
            // cBoxHigrometr
            // 
            this.cBoxHigrometr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cBoxHigrometr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxHigrometr.Enabled = false;
            this.cBoxHigrometr.FormattingEnabled = true;
            this.cBoxHigrometr.Location = new System.Drawing.Point(524, 101);
            this.cBoxHigrometr.Name = "cBoxHigrometr";
            this.cBoxHigrometr.Size = new System.Drawing.Size(140, 21);
            this.cBoxHigrometr.TabIndex = 11;
            // 
            // cBoxBarometr
            // 
            this.cBoxBarometr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cBoxBarometr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxBarometr.Enabled = false;
            this.cBoxBarometr.FormattingEnabled = true;
            this.cBoxBarometr.Location = new System.Drawing.Point(524, 66);
            this.cBoxBarometr.Name = "cBoxBarometr";
            this.cBoxBarometr.Size = new System.Drawing.Size(140, 21);
            this.cBoxBarometr.TabIndex = 10;
            // 
            // cBoxTermometr
            // 
            this.cBoxTermometr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cBoxTermometr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxTermometr.Enabled = false;
            this.cBoxTermometr.FormattingEnabled = true;
            this.cBoxTermometr.Location = new System.Drawing.Point(524, 31);
            this.cBoxTermometr.Name = "cBoxTermometr";
            this.cBoxTermometr.Size = new System.Drawing.Size(140, 21);
            this.cBoxTermometr.TabIndex = 9;
            // 
            // cBoxMagnetometr
            // 
            this.cBoxMagnetometr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cBoxMagnetometr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxMagnetometr.Enabled = false;
            this.cBoxMagnetometr.FormattingEnabled = true;
            this.cBoxMagnetometr.Location = new System.Drawing.Point(172, 101);
            this.cBoxMagnetometr.Name = "cBoxMagnetometr";
            this.cBoxMagnetometr.Size = new System.Drawing.Size(140, 21);
            this.cBoxMagnetometr.TabIndex = 8;
            // 
            // cBoxZyroskop
            // 
            this.cBoxZyroskop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cBoxZyroskop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxZyroskop.Enabled = false;
            this.cBoxZyroskop.FormattingEnabled = true;
            this.cBoxZyroskop.Location = new System.Drawing.Point(172, 66);
            this.cBoxZyroskop.Name = "cBoxZyroskop";
            this.cBoxZyroskop.Size = new System.Drawing.Size(140, 21);
            this.cBoxZyroskop.TabIndex = 7;
            // 
            // cBoxAkcelerometr
            // 
            this.cBoxAkcelerometr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cBoxAkcelerometr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxAkcelerometr.Enabled = false;
            this.cBoxAkcelerometr.Location = new System.Drawing.Point(172, 31);
            this.cBoxAkcelerometr.Name = "cBoxAkcelerometr";
            this.cBoxAkcelerometr.Size = new System.Drawing.Size(140, 21);
            this.cBoxAkcelerometr.TabIndex = 6;
            // 
            // labelHigrometr
            // 
            this.labelHigrometr.AutoSize = true;
            this.labelHigrometr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelHigrometr.Location = new System.Drawing.Point(393, 102);
            this.labelHigrometr.Name = "labelHigrometr";
            this.labelHigrometr.Size = new System.Drawing.Size(74, 17);
            this.labelHigrometr.TabIndex = 5;
            this.labelHigrometr.Text = "Higrometr:";
            // 
            // labelBarometr
            // 
            this.labelBarometr.AutoSize = true;
            this.labelBarometr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelBarometr.Location = new System.Drawing.Point(393, 67);
            this.labelBarometr.Name = "labelBarometr";
            this.labelBarometr.Size = new System.Drawing.Size(70, 17);
            this.labelBarometr.TabIndex = 4;
            this.labelBarometr.Text = "Barometr:";
            // 
            // labelTermometr
            // 
            this.labelTermometr.AutoSize = true;
            this.labelTermometr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTermometr.Location = new System.Drawing.Point(393, 32);
            this.labelTermometr.Name = "labelTermometr";
            this.labelTermometr.Size = new System.Drawing.Size(81, 17);
            this.labelTermometr.TabIndex = 3;
            this.labelTermometr.Text = "Termometr:";
            // 
            // labelMagnetometr
            // 
            this.labelMagnetometr.AutoSize = true;
            this.labelMagnetometr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMagnetometr.Location = new System.Drawing.Point(20, 102);
            this.labelMagnetometr.Name = "labelMagnetometr";
            this.labelMagnetometr.Size = new System.Drawing.Size(95, 17);
            this.labelMagnetometr.TabIndex = 2;
            this.labelMagnetometr.Text = "Magnetometr:";
            // 
            // labelZyroskop
            // 
            this.labelZyroskop.AutoSize = true;
            this.labelZyroskop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelZyroskop.Location = new System.Drawing.Point(20, 67);
            this.labelZyroskop.Name = "labelZyroskop";
            this.labelZyroskop.Size = new System.Drawing.Size(71, 17);
            this.labelZyroskop.TabIndex = 1;
            this.labelZyroskop.Text = "Żyroskop:";
            // 
            // labelAkcelerometr
            // 
            this.labelAkcelerometr.AutoSize = true;
            this.labelAkcelerometr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelAkcelerometr.Location = new System.Drawing.Point(20, 32);
            this.labelAkcelerometr.Name = "labelAkcelerometr";
            this.labelAkcelerometr.Size = new System.Drawing.Size(95, 17);
            this.labelAkcelerometr.TabIndex = 0;
            this.labelAkcelerometr.Text = "Akcelerometr:";
            // 
            // gBoxPolaczenie
            // 
            this.gBoxPolaczenie.Controls.Add(this.pictureBox2);
            this.gBoxPolaczenie.Controls.Add(this.progressBarDane);
            this.gBoxPolaczenie.Controls.Add(this.labelStatusDanych);
            this.gBoxPolaczenie.Controls.Add(this.labelPobieranieDanych);
            this.gBoxPolaczenie.Controls.Add(this.buttonStart);
            this.gBoxPolaczenie.Controls.Add(this.buttonStop);
            this.gBoxPolaczenie.Controls.Add(this.progressBarCOM);
            this.gBoxPolaczenie.Controls.Add(this.labelStatusCOM);
            this.gBoxPolaczenie.Controls.Add(this.buttonOtworz);
            this.gBoxPolaczenie.Controls.Add(this.buttonZamknij);
            this.gBoxPolaczenie.Controls.Add(this.cBoxPorty);
            this.gBoxPolaczenie.Controls.Add(this.labelWyborPortu);
            this.gBoxPolaczenie.Dock = System.Windows.Forms.DockStyle.Top;
            this.gBoxPolaczenie.Location = new System.Drawing.Point(3, 163);
            this.gBoxPolaczenie.Name = "gBoxPolaczenie";
            this.gBoxPolaczenie.Size = new System.Drawing.Size(728, 144);
            this.gBoxPolaczenie.TabIndex = 1;
            this.gBoxPolaczenie.TabStop = false;
            this.gBoxPolaczenie.Text = "Połączenie";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Aplikacja_MEMS.Properties.Resources.WEL_WAT;
            this.pictureBox2.Location = new System.Drawing.Point(328, 38);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(80, 80);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // progressBarDane
            // 
            this.progressBarDane.Location = new System.Drawing.Point(435, 104);
            this.progressBarDane.Name = "progressBarDane";
            this.progressBarDane.Size = new System.Drawing.Size(266, 23);
            this.progressBarDane.TabIndex = 10;
            // 
            // labelStatusDanych
            // 
            this.labelStatusDanych.AutoSize = true;
            this.labelStatusDanych.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelStatusDanych.Location = new System.Drawing.Point(432, 81);
            this.labelStatusDanych.Name = "labelStatusDanych";
            this.labelStatusDanych.Size = new System.Drawing.Size(173, 17);
            this.labelStatusDanych.TabIndex = 9;
            this.labelStatusDanych.Text = "Status pobierania danych:";
            // 
            // labelPobieranieDanych
            // 
            this.labelPobieranieDanych.AutoSize = true;
            this.labelPobieranieDanych.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPobieranieDanych.Location = new System.Drawing.Point(503, 28);
            this.labelPobieranieDanych.Name = "labelPobieranieDanych";
            this.labelPobieranieDanych.Size = new System.Drawing.Size(130, 17);
            this.labelPobieranieDanych.TabIndex = 8;
            this.labelPobieranieDanych.Text = "Pobieranie danych:";
            // 
            // buttonStart
            // 
            this.buttonStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStart.Enabled = false;
            this.buttonStart.Location = new System.Drawing.Point(435, 55);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(130, 23);
            this.buttonStart.TabIndex = 7;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            // 
            // buttonStop
            // 
            this.buttonStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStop.Enabled = false;
            this.buttonStop.ForeColor = System.Drawing.Color.Red;
            this.buttonStop.Location = new System.Drawing.Point(571, 55);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(130, 23);
            this.buttonStop.TabIndex = 6;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            // 
            // progressBarCOM
            // 
            this.progressBarCOM.Location = new System.Drawing.Point(31, 104);
            this.progressBarCOM.Name = "progressBarCOM";
            this.progressBarCOM.Size = new System.Drawing.Size(266, 23);
            this.progressBarCOM.TabIndex = 5;
            // 
            // labelStatusCOM
            // 
            this.labelStatusCOM.AutoSize = true;
            this.labelStatusCOM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelStatusCOM.Location = new System.Drawing.Point(28, 81);
            this.labelStatusCOM.Name = "labelStatusCOM";
            this.labelStatusCOM.Size = new System.Drawing.Size(265, 17);
            this.labelStatusCOM.TabIndex = 4;
            this.labelStatusCOM.Text = "Status połączenia z portem szeregowym:";
            // 
            // buttonOtworz
            // 
            this.buttonOtworz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOtworz.Location = new System.Drawing.Point(31, 55);
            this.buttonOtworz.Name = "buttonOtworz";
            this.buttonOtworz.Size = new System.Drawing.Size(130, 23);
            this.buttonOtworz.TabIndex = 3;
            this.buttonOtworz.Text = "Otwórz";
            this.buttonOtworz.UseVisualStyleBackColor = true;
            this.buttonOtworz.Click += new System.EventHandler(this.buttonOtworz_Click);
            // 
            // buttonZamknij
            // 
            this.buttonZamknij.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonZamknij.Enabled = false;
            this.buttonZamknij.ForeColor = System.Drawing.Color.Red;
            this.buttonZamknij.Location = new System.Drawing.Point(167, 55);
            this.buttonZamknij.Name = "buttonZamknij";
            this.buttonZamknij.Size = new System.Drawing.Size(130, 23);
            this.buttonZamknij.TabIndex = 2;
            this.buttonZamknij.Text = "Zamknij";
            this.buttonZamknij.UseVisualStyleBackColor = true;
            this.buttonZamknij.Click += new System.EventHandler(this.buttonZamknij_Click);
            // 
            // cBoxPorty
            // 
            this.cBoxPorty.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cBoxPorty.FormattingEnabled = true;
            this.cBoxPorty.Location = new System.Drawing.Point(208, 28);
            this.cBoxPorty.Name = "cBoxPorty";
            this.cBoxPorty.Size = new System.Drawing.Size(89, 21);
            this.cBoxPorty.TabIndex = 1;
            // 
            // labelWyborPortu
            // 
            this.labelWyborPortu.AutoSize = true;
            this.labelWyborPortu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWyborPortu.Location = new System.Drawing.Point(28, 29);
            this.labelWyborPortu.Name = "labelWyborPortu";
            this.labelWyborPortu.Size = new System.Drawing.Size(127, 17);
            this.labelWyborPortu.TabIndex = 0;
            this.labelWyborPortu.Text = "Wybierz port COM:";
            // 
            // gBoxInfo
            // 
            this.gBoxInfo.Controls.Add(this.pictureBox1);
            this.gBoxInfo.Controls.Add(this.labelBrakPlytek);
            this.gBoxInfo.Controls.Add(this.labelDostepnePorty);
            this.gBoxInfo.Controls.Add(this.labelWersja);
            this.gBoxInfo.Controls.Add(this.lableTytul);
            this.gBoxInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.gBoxInfo.Location = new System.Drawing.Point(3, 3);
            this.gBoxInfo.Name = "gBoxInfo";
            this.gBoxInfo.Size = new System.Drawing.Size(728, 160);
            this.gBoxInfo.TabIndex = 0;
            this.gBoxInfo.TabStop = false;
            this.gBoxInfo.Text = "Informacje";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Aplikacja_MEMS.Properties.Resources.Plytka;
            this.pictureBox1.InitialImage = global::Aplikacja_MEMS.Properties.Resources.Plytka;
            this.pictureBox1.Location = new System.Drawing.Point(538, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(185, 144);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // labelBrakPlytek
            // 
            this.labelBrakPlytek.AutoSize = true;
            this.labelBrakPlytek.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelBrakPlytek.ForeColor = System.Drawing.Color.Red;
            this.labelBrakPlytek.Location = new System.Drawing.Point(20, 85);
            this.labelBrakPlytek.Name = "labelBrakPlytek";
            this.labelBrakPlytek.Size = new System.Drawing.Size(158, 17);
            this.labelBrakPlytek.TabIndex = 3;
            this.labelBrakPlytek.Text = "Brak dostępnych płytek!";
            // 
            // labelDostepnePorty
            // 
            this.labelDostepnePorty.AutoSize = true;
            this.labelDostepnePorty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDostepnePorty.Location = new System.Drawing.Point(6, 66);
            this.labelDostepnePorty.Name = "labelDostepnePorty";
            this.labelDostepnePorty.Size = new System.Drawing.Size(109, 17);
            this.labelDostepnePorty.TabIndex = 2;
            this.labelDostepnePorty.Text = "Dostępne płytki:";
            // 
            // labelWersja
            // 
            this.labelWersja.AutoSize = true;
            this.labelWersja.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWersja.Location = new System.Drawing.Point(6, 49);
            this.labelWersja.Name = "labelWersja";
            this.labelWersja.Size = new System.Drawing.Size(146, 17);
            this.labelWersja.TabIndex = 1;
            this.labelWersja.Text = "Wersja aplikacji: 1.0.0";
            // 
            // lableTytul
            // 
            this.lableTytul.AutoSize = true;
            this.lableTytul.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lableTytul.Location = new System.Drawing.Point(196, 16);
            this.lableTytul.Name = "lableTytul";
            this.lableTytul.Size = new System.Drawing.Size(296, 24);
            this.lableTytul.TabIndex = 0;
            this.lableTytul.Text = "Aplikacja MEMS czujnika IKS01A2";
            this.lableTytul.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPageCzujniki
            // 
            this.tabPageCzujniki.CausesValidation = false;
            this.tabPageCzujniki.Location = new System.Drawing.Point(4, 22);
            this.tabPageCzujniki.Name = "tabPageCzujniki";
            this.tabPageCzujniki.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCzujniki.Size = new System.Drawing.Size(734, 474);
            this.tabPageCzujniki.TabIndex = 1;
            this.tabPageCzujniki.Text = "Czujniki MEMS";
            this.tabPageCzujniki.UseVisualStyleBackColor = true;
            // 
            // tabPageDane
            // 
            this.tabPageDane.Location = new System.Drawing.Point(4, 22);
            this.tabPageDane.Name = "tabPageDane";
            this.tabPageDane.Size = new System.Drawing.Size(734, 474);
            this.tabPageDane.TabIndex = 2;
            this.tabPageDane.Text = "Dane";
            this.tabPageDane.UseVisualStyleBackColor = true;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.edytujToolStripMenuItem,
            this.opcjeToolStripMenuItem,
            this.pomocToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(742, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asdToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // asdToolStripMenuItem
            // 
            this.asdToolStripMenuItem.Name = "asdToolStripMenuItem";
            this.asdToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.asdToolStripMenuItem.Text = "asd";
            // 
            // edytujToolStripMenuItem
            // 
            this.edytujToolStripMenuItem.Name = "edytujToolStripMenuItem";
            this.edytujToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.edytujToolStripMenuItem.Text = "Edytuj";
            // 
            // opcjeToolStripMenuItem
            // 
            this.opcjeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.otworzPortToolStripMenuItem});
            this.opcjeToolStripMenuItem.Name = "opcjeToolStripMenuItem";
            this.opcjeToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.opcjeToolStripMenuItem.Text = "Opcje";
            // 
            // otworzPortToolStripMenuItem
            // 
            this.otworzPortToolStripMenuItem.Name = "otworzPortToolStripMenuItem";
            this.otworzPortToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.otworzPortToolStripMenuItem.Text = "Otworz port";
            // 
            // pomocToolStripMenuItem
            // 
            this.pomocToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pomocToolStripMenuItem1,
            this.oProgramieToolStripMenuItem});
            this.pomocToolStripMenuItem.Name = "pomocToolStripMenuItem";
            this.pomocToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.pomocToolStripMenuItem.Text = "Pomoc";
            // 
            // pomocToolStripMenuItem1
            // 
            this.pomocToolStripMenuItem1.Name = "pomocToolStripMenuItem1";
            this.pomocToolStripMenuItem1.Size = new System.Drawing.Size(141, 22);
            this.pomocToolStripMenuItem1.Text = "Pomoc";
            // 
            // oProgramieToolStripMenuItem
            // 
            this.oProgramieToolStripMenuItem.Name = "oProgramieToolStripMenuItem";
            this.oProgramieToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.oProgramieToolStripMenuItem.Text = "O programie";
            // 
            // serialPort
            // 
            this.serialPort.BaudRate = 921600;
            // 
            // bgWorkerOtworz
            // 
            this.bgWorkerOtworz.WorkerSupportsCancellation = true;
            this.bgWorkerOtworz.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorkerOtworz_DoWork);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(742, 524);
            this.Controls.Add(this.tabControlCzujniki);
            this.Controls.Add(this.menuStrip);
            this.MaximizeBox = false;
            this.Name = "UserForm";
            this.Text = "Aplikacja MEMS";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.Shown += new System.EventHandler(this.UserForm_Shown);
            this.tabControlCzujniki.ResumeLayout(false);
            this.tabPageOgolne.ResumeLayout(false);
            this.gBoxCzujniki.ResumeLayout(false);
            this.gBoxCzujniki.PerformLayout();
            this.gBoxPolaczenie.ResumeLayout(false);
            this.gBoxPolaczenie.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.gBoxInfo.ResumeLayout(false);
            this.gBoxInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlCzujniki;
        private System.Windows.Forms.TabPage tabPageOgolne;
        private System.Windows.Forms.TabPage tabPageCzujniki;
        private System.Windows.Forms.GroupBox gBoxInfo;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edytujToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opcjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asdToolStripMenuItem;
        private System.Windows.Forms.GroupBox gBoxCzujniki;
        private System.Windows.Forms.GroupBox gBoxPolaczenie;
        private System.Windows.Forms.Label lableTytul;
        private System.Windows.Forms.Label labelBrakPlytek;
        private System.Windows.Forms.Label labelDostepnePorty;
        private System.Windows.Forms.Label labelWersja;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage tabPageDane;
        public System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.ComboBox cBoxPorty;
        private System.Windows.Forms.Label labelWyborPortu;
        private System.Windows.Forms.Label labelZyroskop;
        private System.Windows.Forms.Label labelAkcelerometr;
        private System.Windows.Forms.ProgressBar progressBarDane;
        private System.Windows.Forms.Label labelStatusDanych;
        private System.Windows.Forms.Label labelPobieranieDanych;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonStop;
        public System.Windows.Forms.ProgressBar progressBarCOM;
        private System.Windows.Forms.Label labelStatusCOM;
        private System.Windows.Forms.Button buttonOtworz;
        private System.Windows.Forms.Button buttonZamknij;
        private System.Windows.Forms.Label labelHigrometr;
        private System.Windows.Forms.Label labelBarometr;
        private System.Windows.Forms.Label labelTermometr;
        private System.Windows.Forms.Label labelMagnetometr;
        private System.Windows.Forms.ToolStripMenuItem otworzPortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomocToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem oProgramieToolStripMenuItem;
        private System.Windows.Forms.ComboBox cBoxHigrometr;
        private System.Windows.Forms.ComboBox cBoxBarometr;
        private System.Windows.Forms.ComboBox cBoxTermometr;
        private System.Windows.Forms.ComboBox cBoxMagnetometr;
        private System.Windows.Forms.ComboBox cBoxZyroskop;
        private System.Windows.Forms.ComboBox cBoxAkcelerometr;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.ComponentModel.BackgroundWorker bgWorkerOtworz;
    }
}

