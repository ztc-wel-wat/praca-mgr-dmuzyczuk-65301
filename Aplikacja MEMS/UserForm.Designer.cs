
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
            this.pBoxLogoWEL = new System.Windows.Forms.PictureBox();
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
            this.pBoxPlytka = new System.Windows.Forms.PictureBox();
            this.labelBrakPlytek = new System.Windows.Forms.Label();
            this.labelDostepnePorty = new System.Windows.Forms.Label();
            this.labelWersja = new System.Windows.Forms.Label();
            this.labelTytul = new System.Windows.Forms.Label();
            this.tabPageCzujniki = new System.Windows.Forms.TabPage();
            this.gBoxHigrometr = new System.Windows.Forms.GroupBox();
            this.labHigNazwaCzujnika = new System.Windows.Forms.Label();
            this.cBoxHigODR = new System.Windows.Forms.ComboBox();
            this.labHigODR = new System.Windows.Forms.Label();
            this.gBoxHigRejestr = new System.Windows.Forms.GroupBox();
            this.buttonHigWczytaj = new System.Windows.Forms.Button();
            this.buttonHigUstaw = new System.Windows.Forms.Button();
            this.tBoxHigWartosc = new System.Windows.Forms.TextBox();
            this.tBoxHigAdres = new System.Windows.Forms.TextBox();
            this.labHigWartosc = new System.Windows.Forms.Label();
            this.labHigAdres = new System.Windows.Forms.Label();
            this.buttonHigOtworz = new System.Windows.Forms.Button();
            this.buttonHigRysujWykres = new System.Windows.Forms.Button();
            this.chBoxHigWlaczony = new System.Windows.Forms.CheckBox();
            this.gBoxMagnetometr = new System.Windows.Forms.GroupBox();
            this.labMagNazwaCzujnika = new System.Windows.Forms.Label();
            this.cBoxMagODR = new System.Windows.Forms.ComboBox();
            this.cBoxMagSkala = new System.Windows.Forms.ComboBox();
            this.gBoxMagRejestr = new System.Windows.Forms.GroupBox();
            this.buttonMagWczytaj = new System.Windows.Forms.Button();
            this.buttonMagUstaw = new System.Windows.Forms.Button();
            this.tBoxMagWartosc = new System.Windows.Forms.TextBox();
            this.tBoxMagAdres = new System.Windows.Forms.TextBox();
            this.labMagWartosc = new System.Windows.Forms.Label();
            this.labMagAdres = new System.Windows.Forms.Label();
            this.buttonMagOtworz = new System.Windows.Forms.Button();
            this.buttonMagRysujWykres = new System.Windows.Forms.Button();
            this.labMagODR = new System.Windows.Forms.Label();
            this.labMagSkala = new System.Windows.Forms.Label();
            this.chBoxMagWlaczony = new System.Windows.Forms.CheckBox();
            this.gBoxBarometr = new System.Windows.Forms.GroupBox();
            this.labBarNazwaCzujnika = new System.Windows.Forms.Label();
            this.cBoxBarODR = new System.Windows.Forms.ComboBox();
            this.labBarODR = new System.Windows.Forms.Label();
            this.gBoxBarRejestr = new System.Windows.Forms.GroupBox();
            this.buttonBarWczytaj = new System.Windows.Forms.Button();
            this.buttonBarUstaw = new System.Windows.Forms.Button();
            this.tBoxBarWartosc = new System.Windows.Forms.TextBox();
            this.tBoxBarAdres = new System.Windows.Forms.TextBox();
            this.labBarWartosc = new System.Windows.Forms.Label();
            this.labBarAdres = new System.Windows.Forms.Label();
            this.buttonBarOtworz = new System.Windows.Forms.Button();
            this.buttonBarRysujWykres = new System.Windows.Forms.Button();
            this.chBoxBarWlaczony = new System.Windows.Forms.CheckBox();
            this.gBoxZyroskop = new System.Windows.Forms.GroupBox();
            this.LabZyroNazwaCzujnika = new System.Windows.Forms.Label();
            this.cBoxZyroODR = new System.Windows.Forms.ComboBox();
            this.cBoxZyroSkala = new System.Windows.Forms.ComboBox();
            this.gBoxZyroRejestr = new System.Windows.Forms.GroupBox();
            this.buttonZyroWczytaj = new System.Windows.Forms.Button();
            this.buttonZyroUstaw = new System.Windows.Forms.Button();
            this.tBoxZyroWartosc = new System.Windows.Forms.TextBox();
            this.tBoxZyroAdres = new System.Windows.Forms.TextBox();
            this.labZyroWartosc = new System.Windows.Forms.Label();
            this.labZyroAdres = new System.Windows.Forms.Label();
            this.buttonZyroOtworz = new System.Windows.Forms.Button();
            this.buttonZyroRysujWykres = new System.Windows.Forms.Button();
            this.labZyroODR = new System.Windows.Forms.Label();
            this.labZyroSkala = new System.Windows.Forms.Label();
            this.chBoxZyroWlaczony = new System.Windows.Forms.CheckBox();
            this.gBoxTermometr = new System.Windows.Forms.GroupBox();
            this.labTermNazwaCzujnika = new System.Windows.Forms.Label();
            this.cBoxTermODR = new System.Windows.Forms.ComboBox();
            this.labTermODR = new System.Windows.Forms.Label();
            this.gBoxTermRejestr = new System.Windows.Forms.GroupBox();
            this.buttonTermWczytaj = new System.Windows.Forms.Button();
            this.buttonTermUstaw = new System.Windows.Forms.Button();
            this.tBoxTermWartosc = new System.Windows.Forms.TextBox();
            this.tBoxTermAdres = new System.Windows.Forms.TextBox();
            this.labTermWartosc = new System.Windows.Forms.Label();
            this.labTermAdres = new System.Windows.Forms.Label();
            this.buttonTermOtworz = new System.Windows.Forms.Button();
            this.buttonTermRysujWYkres = new System.Windows.Forms.Button();
            this.chBoxTermWlaczony = new System.Windows.Forms.CheckBox();
            this.gBoxAkcelerometr = new System.Windows.Forms.GroupBox();
            this.labAkcNazwa = new System.Windows.Forms.Label();
            this.cBoxAkcODR = new System.Windows.Forms.ComboBox();
            this.cBoxAkcSkala = new System.Windows.Forms.ComboBox();
            this.gBoxAkcRejestr = new System.Windows.Forms.GroupBox();
            this.buttonAkcWczytaj = new System.Windows.Forms.Button();
            this.buttonAkcUstaw = new System.Windows.Forms.Button();
            this.tBoxAkcWartosc = new System.Windows.Forms.TextBox();
            this.tBoxAkcAdres = new System.Windows.Forms.TextBox();
            this.labAkcWartosc = new System.Windows.Forms.Label();
            this.labAkcAdres = new System.Windows.Forms.Label();
            this.buttonAkcOtworz = new System.Windows.Forms.Button();
            this.buttonAkcRysujWykres = new System.Windows.Forms.Button();
            this.labAkcLiczbaProbek = new System.Windows.Forms.Label();
            this.labAkcSkala = new System.Windows.Forms.Label();
            this.chBoxAkcWlaczony = new System.Windows.Forms.CheckBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.pBoxLogoWEL)).BeginInit();
            this.gBoxInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxPlytka)).BeginInit();
            this.tabPageCzujniki.SuspendLayout();
            this.gBoxHigrometr.SuspendLayout();
            this.gBoxHigRejestr.SuspendLayout();
            this.gBoxMagnetometr.SuspendLayout();
            this.gBoxMagRejestr.SuspendLayout();
            this.gBoxBarometr.SuspendLayout();
            this.gBoxBarRejestr.SuspendLayout();
            this.gBoxZyroskop.SuspendLayout();
            this.gBoxZyroRejestr.SuspendLayout();
            this.gBoxTermometr.SuspendLayout();
            this.gBoxTermRejestr.SuspendLayout();
            this.gBoxAkcelerometr.SuspendLayout();
            this.gBoxAkcRejestr.SuspendLayout();
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
            this.gBoxPolaczenie.Controls.Add(this.pBoxLogoWEL);
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
            // pBoxLogoWEL
            // 
            this.pBoxLogoWEL.Image = global::Aplikacja_MEMS.Properties.Resources.WEL_WAT;
            this.pBoxLogoWEL.Location = new System.Drawing.Point(326, 38);
            this.pBoxLogoWEL.Name = "pBoxLogoWEL";
            this.pBoxLogoWEL.Size = new System.Drawing.Size(80, 80);
            this.pBoxLogoWEL.TabIndex = 11;
            this.pBoxLogoWEL.TabStop = false;
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
            this.buttonStart.Text = " Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
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
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
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
            this.gBoxInfo.Controls.Add(this.pBoxPlytka);
            this.gBoxInfo.Controls.Add(this.labelBrakPlytek);
            this.gBoxInfo.Controls.Add(this.labelDostepnePorty);
            this.gBoxInfo.Controls.Add(this.labelWersja);
            this.gBoxInfo.Controls.Add(this.labelTytul);
            this.gBoxInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.gBoxInfo.Location = new System.Drawing.Point(3, 3);
            this.gBoxInfo.Name = "gBoxInfo";
            this.gBoxInfo.Size = new System.Drawing.Size(728, 160);
            this.gBoxInfo.TabIndex = 0;
            this.gBoxInfo.TabStop = false;
            this.gBoxInfo.Text = "Informacje";
            // 
            // pBoxPlytka
            // 
            this.pBoxPlytka.Image = global::Aplikacja_MEMS.Properties.Resources.Plytka;
            this.pBoxPlytka.InitialImage = global::Aplikacja_MEMS.Properties.Resources.Plytka;
            this.pBoxPlytka.Location = new System.Drawing.Point(538, 10);
            this.pBoxPlytka.Name = "pBoxPlytka";
            this.pBoxPlytka.Size = new System.Drawing.Size(185, 144);
            this.pBoxPlytka.TabIndex = 4;
            this.pBoxPlytka.TabStop = false;
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
            // labelTytul
            // 
            this.labelTytul.AutoSize = true;
            this.labelTytul.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTytul.Location = new System.Drawing.Point(196, 16);
            this.labelTytul.Name = "labelTytul";
            this.labelTytul.Size = new System.Drawing.Size(296, 24);
            this.labelTytul.TabIndex = 0;
            this.labelTytul.Text = "Aplikacja MEMS czujnika IKS01A2";
            this.labelTytul.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPageCzujniki
            // 
            this.tabPageCzujniki.CausesValidation = false;
            this.tabPageCzujniki.Controls.Add(this.gBoxHigrometr);
            this.tabPageCzujniki.Controls.Add(this.gBoxMagnetometr);
            this.tabPageCzujniki.Controls.Add(this.gBoxBarometr);
            this.tabPageCzujniki.Controls.Add(this.gBoxZyroskop);
            this.tabPageCzujniki.Controls.Add(this.gBoxTermometr);
            this.tabPageCzujniki.Controls.Add(this.gBoxAkcelerometr);
            this.tabPageCzujniki.Location = new System.Drawing.Point(4, 22);
            this.tabPageCzujniki.Name = "tabPageCzujniki";
            this.tabPageCzujniki.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCzujniki.Size = new System.Drawing.Size(734, 474);
            this.tabPageCzujniki.TabIndex = 1;
            this.tabPageCzujniki.Text = "Czujniki MEMS";
            this.tabPageCzujniki.UseVisualStyleBackColor = true;
            // 
            // gBoxHigrometr
            // 
            this.gBoxHigrometr.Controls.Add(this.labHigNazwaCzujnika);
            this.gBoxHigrometr.Controls.Add(this.cBoxHigODR);
            this.gBoxHigrometr.Controls.Add(this.labHigODR);
            this.gBoxHigrometr.Controls.Add(this.gBoxHigRejestr);
            this.gBoxHigrometr.Controls.Add(this.buttonHigRysujWykres);
            this.gBoxHigrometr.Controls.Add(this.chBoxHigWlaczony);
            this.gBoxHigrometr.Enabled = false;
            this.gBoxHigrometr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gBoxHigrometr.Location = new System.Drawing.Point(369, 318);
            this.gBoxHigrometr.Name = "gBoxHigrometr";
            this.gBoxHigrometr.Size = new System.Drawing.Size(355, 150);
            this.gBoxHigrometr.TabIndex = 4;
            this.gBoxHigrometr.TabStop = false;
            this.gBoxHigrometr.Text = "Higrometr";
            // 
            // labHigNazwaCzujnika
            // 
            this.labHigNazwaCzujnika.AutoSize = true;
            this.labHigNazwaCzujnika.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labHigNazwaCzujnika.Location = new System.Drawing.Point(6, 19);
            this.labHigNazwaCzujnika.Name = "labHigNazwaCzujnika";
            this.labHigNazwaCzujnika.Size = new System.Drawing.Size(99, 15);
            this.labHigNazwaCzujnika.TabIndex = 18;
            this.labHigNazwaCzujnika.Text = "Nazwa czujnika: ";
            // 
            // cBoxHigODR
            // 
            this.cBoxHigODR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cBoxHigODR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxHigODR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cBoxHigODR.FormattingEnabled = true;
            this.cBoxHigODR.Items.AddRange(new object[] {
            "1",
            "7",
            "12,5"});
            this.cBoxHigODR.Location = new System.Drawing.Point(9, 77);
            this.cBoxHigODR.Name = "cBoxHigODR";
            this.cBoxHigODR.Size = new System.Drawing.Size(121, 21);
            this.cBoxHigODR.TabIndex = 20;
            // 
            // labHigODR
            // 
            this.labHigODR.AutoSize = true;
            this.labHigODR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labHigODR.Location = new System.Drawing.Point(6, 59);
            this.labHigODR.Name = "labHigODR";
            this.labHigODR.Size = new System.Drawing.Size(37, 15);
            this.labHigODR.TabIndex = 23;
            this.labHigODR.Text = "ODR:";
            // 
            // gBoxHigRejestr
            // 
            this.gBoxHigRejestr.Controls.Add(this.buttonHigWczytaj);
            this.gBoxHigRejestr.Controls.Add(this.buttonHigUstaw);
            this.gBoxHigRejestr.Controls.Add(this.tBoxHigWartosc);
            this.gBoxHigRejestr.Controls.Add(this.tBoxHigAdres);
            this.gBoxHigRejestr.Controls.Add(this.labHigWartosc);
            this.gBoxHigRejestr.Controls.Add(this.labHigAdres);
            this.gBoxHigRejestr.Controls.Add(this.buttonHigOtworz);
            this.gBoxHigRejestr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gBoxHigRejestr.Location = new System.Drawing.Point(154, 39);
            this.gBoxHigRejestr.Name = "gBoxHigRejestr";
            this.gBoxHigRejestr.Size = new System.Drawing.Size(195, 105);
            this.gBoxHigRejestr.TabIndex = 21;
            this.gBoxHigRejestr.TabStop = false;
            this.gBoxHigRejestr.Text = "Rejestr";
            // 
            // buttonHigWczytaj
            // 
            this.buttonHigWczytaj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHigWczytaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonHigWczytaj.Location = new System.Drawing.Point(107, 54);
            this.buttonHigWczytaj.Name = "buttonHigWczytaj";
            this.buttonHigWczytaj.Size = new System.Drawing.Size(66, 23);
            this.buttonHigWczytaj.TabIndex = 20;
            this.buttonHigWczytaj.Text = "Wczytaj";
            this.buttonHigWczytaj.UseVisualStyleBackColor = true;
            // 
            // buttonHigUstaw
            // 
            this.buttonHigUstaw.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHigUstaw.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonHigUstaw.Location = new System.Drawing.Point(30, 54);
            this.buttonHigUstaw.Name = "buttonHigUstaw";
            this.buttonHigUstaw.Size = new System.Drawing.Size(66, 23);
            this.buttonHigUstaw.TabIndex = 19;
            this.buttonHigUstaw.Text = "Ustaw";
            this.buttonHigUstaw.UseVisualStyleBackColor = true;
            // 
            // tBoxHigWartosc
            // 
            this.tBoxHigWartosc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tBoxHigWartosc.Location = new System.Drawing.Point(107, 28);
            this.tBoxHigWartosc.Name = "tBoxHigWartosc";
            this.tBoxHigWartosc.Size = new System.Drawing.Size(66, 20);
            this.tBoxHigWartosc.TabIndex = 18;
            // 
            // tBoxHigAdres
            // 
            this.tBoxHigAdres.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tBoxHigAdres.Location = new System.Drawing.Point(30, 28);
            this.tBoxHigAdres.Name = "tBoxHigAdres";
            this.tBoxHigAdres.Size = new System.Drawing.Size(66, 20);
            this.tBoxHigAdres.TabIndex = 17;
            // 
            // labHigWartosc
            // 
            this.labHigWartosc.AutoSize = true;
            this.labHigWartosc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labHigWartosc.Location = new System.Drawing.Point(117, 10);
            this.labHigWartosc.Name = "labHigWartosc";
            this.labHigWartosc.Size = new System.Drawing.Size(54, 15);
            this.labHigWartosc.TabIndex = 16;
            this.labHigWartosc.Text = "Wartość:";
            // 
            // labHigAdres
            // 
            this.labHigAdres.AutoSize = true;
            this.labHigAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labHigAdres.Location = new System.Drawing.Point(43, 10);
            this.labHigAdres.Name = "labHigAdres";
            this.labHigAdres.Size = new System.Drawing.Size(41, 15);
            this.labHigAdres.TabIndex = 15;
            this.labHigAdres.Text = "Adres:";
            // 
            // buttonHigOtworz
            // 
            this.buttonHigOtworz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHigOtworz.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonHigOtworz.Location = new System.Drawing.Point(30, 79);
            this.buttonHigOtworz.Name = "buttonHigOtworz";
            this.buttonHigOtworz.Size = new System.Drawing.Size(143, 23);
            this.buttonHigOtworz.TabIndex = 14;
            this.buttonHigOtworz.Text = "Otwórz rejestr";
            this.buttonHigOtworz.UseVisualStyleBackColor = true;
            // 
            // buttonHigRysujWykres
            // 
            this.buttonHigRysujWykres.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHigRysujWykres.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHigRysujWykres.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonHigRysujWykres.ForeColor = System.Drawing.Color.LimeGreen;
            this.buttonHigRysujWykres.Location = new System.Drawing.Point(249, 15);
            this.buttonHigRysujWykres.Name = "buttonHigRysujWykres";
            this.buttonHigRysujWykres.Size = new System.Drawing.Size(100, 23);
            this.buttonHigRysujWykres.TabIndex = 22;
            this.buttonHigRysujWykres.Text = "Rysuj wykres";
            this.buttonHigRysujWykres.UseVisualStyleBackColor = true;
            // 
            // chBoxHigWlaczony
            // 
            this.chBoxHigWlaczony.AutoSize = true;
            this.chBoxHigWlaczony.Checked = true;
            this.chBoxHigWlaczony.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chBoxHigWlaczony.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chBoxHigWlaczony.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chBoxHigWlaczony.Location = new System.Drawing.Point(9, 37);
            this.chBoxHigWlaczony.Name = "chBoxHigWlaczony";
            this.chBoxHigWlaczony.Size = new System.Drawing.Size(78, 19);
            this.chBoxHigWlaczony.TabIndex = 19;
            this.chBoxHigWlaczony.Text = "Włączony";
            this.chBoxHigWlaczony.UseVisualStyleBackColor = true;
            this.chBoxHigWlaczony.CheckedChanged += new System.EventHandler(this.chBoxHigWlaczony_CheckedChanged);
            // 
            // gBoxMagnetometr
            // 
            this.gBoxMagnetometr.Controls.Add(this.labMagNazwaCzujnika);
            this.gBoxMagnetometr.Controls.Add(this.cBoxMagODR);
            this.gBoxMagnetometr.Controls.Add(this.cBoxMagSkala);
            this.gBoxMagnetometr.Controls.Add(this.gBoxMagRejestr);
            this.gBoxMagnetometr.Controls.Add(this.buttonMagRysujWykres);
            this.gBoxMagnetometr.Controls.Add(this.labMagODR);
            this.gBoxMagnetometr.Controls.Add(this.labMagSkala);
            this.gBoxMagnetometr.Controls.Add(this.chBoxMagWlaczony);
            this.gBoxMagnetometr.Enabled = false;
            this.gBoxMagnetometr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gBoxMagnetometr.Location = new System.Drawing.Point(8, 318);
            this.gBoxMagnetometr.Name = "gBoxMagnetometr";
            this.gBoxMagnetometr.Size = new System.Drawing.Size(355, 150);
            this.gBoxMagnetometr.TabIndex = 1;
            this.gBoxMagnetometr.TabStop = false;
            this.gBoxMagnetometr.Text = "Magnetometr";
            // 
            // labMagNazwaCzujnika
            // 
            this.labMagNazwaCzujnika.AutoSize = true;
            this.labMagNazwaCzujnika.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labMagNazwaCzujnika.Location = new System.Drawing.Point(6, 19);
            this.labMagNazwaCzujnika.Name = "labMagNazwaCzujnika";
            this.labMagNazwaCzujnika.Size = new System.Drawing.Size(99, 15);
            this.labMagNazwaCzujnika.TabIndex = 9;
            this.labMagNazwaCzujnika.Text = "Nazwa czujnika: ";
            // 
            // cBoxMagODR
            // 
            this.cBoxMagODR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cBoxMagODR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxMagODR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cBoxMagODR.FormattingEnabled = true;
            this.cBoxMagODR.Items.AddRange(new object[] {
            "10",
            "20",
            "50",
            "100"});
            this.cBoxMagODR.Location = new System.Drawing.Point(9, 119);
            this.cBoxMagODR.Name = "cBoxMagODR";
            this.cBoxMagODR.Size = new System.Drawing.Size(121, 21);
            this.cBoxMagODR.TabIndex = 14;
            // 
            // cBoxMagSkala
            // 
            this.cBoxMagSkala.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cBoxMagSkala.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxMagSkala.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cBoxMagSkala.FormattingEnabled = true;
            this.cBoxMagSkala.Items.AddRange(new object[] {
            "50"});
            this.cBoxMagSkala.Location = new System.Drawing.Point(9, 77);
            this.cBoxMagSkala.Name = "cBoxMagSkala";
            this.cBoxMagSkala.Size = new System.Drawing.Size(121, 21);
            this.cBoxMagSkala.TabIndex = 12;
            // 
            // gBoxMagRejestr
            // 
            this.gBoxMagRejestr.Controls.Add(this.buttonMagWczytaj);
            this.gBoxMagRejestr.Controls.Add(this.buttonMagUstaw);
            this.gBoxMagRejestr.Controls.Add(this.tBoxMagWartosc);
            this.gBoxMagRejestr.Controls.Add(this.tBoxMagAdres);
            this.gBoxMagRejestr.Controls.Add(this.labMagWartosc);
            this.gBoxMagRejestr.Controls.Add(this.labMagAdres);
            this.gBoxMagRejestr.Controls.Add(this.buttonMagOtworz);
            this.gBoxMagRejestr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gBoxMagRejestr.Location = new System.Drawing.Point(154, 39);
            this.gBoxMagRejestr.Name = "gBoxMagRejestr";
            this.gBoxMagRejestr.Size = new System.Drawing.Size(195, 105);
            this.gBoxMagRejestr.TabIndex = 15;
            this.gBoxMagRejestr.TabStop = false;
            this.gBoxMagRejestr.Text = "Rejestr";
            // 
            // buttonMagWczytaj
            // 
            this.buttonMagWczytaj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMagWczytaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonMagWczytaj.Location = new System.Drawing.Point(107, 54);
            this.buttonMagWczytaj.Name = "buttonMagWczytaj";
            this.buttonMagWczytaj.Size = new System.Drawing.Size(66, 23);
            this.buttonMagWczytaj.TabIndex = 20;
            this.buttonMagWczytaj.Text = "Wczytaj";
            this.buttonMagWczytaj.UseVisualStyleBackColor = true;
            // 
            // buttonMagUstaw
            // 
            this.buttonMagUstaw.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMagUstaw.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonMagUstaw.Location = new System.Drawing.Point(30, 54);
            this.buttonMagUstaw.Name = "buttonMagUstaw";
            this.buttonMagUstaw.Size = new System.Drawing.Size(66, 23);
            this.buttonMagUstaw.TabIndex = 19;
            this.buttonMagUstaw.Text = "Ustaw";
            this.buttonMagUstaw.UseVisualStyleBackColor = true;
            // 
            // tBoxMagWartosc
            // 
            this.tBoxMagWartosc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tBoxMagWartosc.Location = new System.Drawing.Point(107, 28);
            this.tBoxMagWartosc.Name = "tBoxMagWartosc";
            this.tBoxMagWartosc.Size = new System.Drawing.Size(66, 20);
            this.tBoxMagWartosc.TabIndex = 18;
            // 
            // tBoxMagAdres
            // 
            this.tBoxMagAdres.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tBoxMagAdres.Location = new System.Drawing.Point(30, 28);
            this.tBoxMagAdres.Name = "tBoxMagAdres";
            this.tBoxMagAdres.Size = new System.Drawing.Size(66, 20);
            this.tBoxMagAdres.TabIndex = 17;
            // 
            // labMagWartosc
            // 
            this.labMagWartosc.AutoSize = true;
            this.labMagWartosc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labMagWartosc.Location = new System.Drawing.Point(117, 10);
            this.labMagWartosc.Name = "labMagWartosc";
            this.labMagWartosc.Size = new System.Drawing.Size(54, 15);
            this.labMagWartosc.TabIndex = 16;
            this.labMagWartosc.Text = "Wartość:";
            // 
            // labMagAdres
            // 
            this.labMagAdres.AutoSize = true;
            this.labMagAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labMagAdres.Location = new System.Drawing.Point(43, 10);
            this.labMagAdres.Name = "labMagAdres";
            this.labMagAdres.Size = new System.Drawing.Size(41, 15);
            this.labMagAdres.TabIndex = 15;
            this.labMagAdres.Text = "Adres:";
            // 
            // buttonMagOtworz
            // 
            this.buttonMagOtworz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMagOtworz.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonMagOtworz.Location = new System.Drawing.Point(30, 79);
            this.buttonMagOtworz.Name = "buttonMagOtworz";
            this.buttonMagOtworz.Size = new System.Drawing.Size(143, 23);
            this.buttonMagOtworz.TabIndex = 14;
            this.buttonMagOtworz.Text = "Otwórz rejestr";
            this.buttonMagOtworz.UseVisualStyleBackColor = true;
            // 
            // buttonMagRysujWykres
            // 
            this.buttonMagRysujWykres.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMagRysujWykres.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMagRysujWykres.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonMagRysujWykres.ForeColor = System.Drawing.Color.LimeGreen;
            this.buttonMagRysujWykres.Location = new System.Drawing.Point(249, 15);
            this.buttonMagRysujWykres.Name = "buttonMagRysujWykres";
            this.buttonMagRysujWykres.Size = new System.Drawing.Size(100, 23);
            this.buttonMagRysujWykres.TabIndex = 16;
            this.buttonMagRysujWykres.Text = "Rysuj wykres";
            this.buttonMagRysujWykres.UseVisualStyleBackColor = true;
            // 
            // labMagODR
            // 
            this.labMagODR.AutoSize = true;
            this.labMagODR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labMagODR.Location = new System.Drawing.Point(6, 101);
            this.labMagODR.Name = "labMagODR";
            this.labMagODR.Size = new System.Drawing.Size(37, 15);
            this.labMagODR.TabIndex = 13;
            this.labMagODR.Text = "ODR:";
            // 
            // labMagSkala
            // 
            this.labMagSkala.AutoSize = true;
            this.labMagSkala.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labMagSkala.Location = new System.Drawing.Point(6, 59);
            this.labMagSkala.Name = "labMagSkala";
            this.labMagSkala.Size = new System.Drawing.Size(75, 15);
            this.labMagSkala.TabIndex = 11;
            this.labMagSkala.Text = "Skala (oś Y):";
            // 
            // chBoxMagWlaczony
            // 
            this.chBoxMagWlaczony.AutoSize = true;
            this.chBoxMagWlaczony.Checked = true;
            this.chBoxMagWlaczony.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chBoxMagWlaczony.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chBoxMagWlaczony.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chBoxMagWlaczony.Location = new System.Drawing.Point(9, 37);
            this.chBoxMagWlaczony.Name = "chBoxMagWlaczony";
            this.chBoxMagWlaczony.Size = new System.Drawing.Size(78, 19);
            this.chBoxMagWlaczony.TabIndex = 10;
            this.chBoxMagWlaczony.Text = "Włączony";
            this.chBoxMagWlaczony.UseVisualStyleBackColor = true;
            this.chBoxMagWlaczony.CheckedChanged += new System.EventHandler(this.chBoxMagWlaczony_CheckedChanged);
            // 
            // gBoxBarometr
            // 
            this.gBoxBarometr.Controls.Add(this.labBarNazwaCzujnika);
            this.gBoxBarometr.Controls.Add(this.cBoxBarODR);
            this.gBoxBarometr.Controls.Add(this.labBarODR);
            this.gBoxBarometr.Controls.Add(this.gBoxBarRejestr);
            this.gBoxBarometr.Controls.Add(this.buttonBarRysujWykres);
            this.gBoxBarometr.Controls.Add(this.chBoxBarWlaczony);
            this.gBoxBarometr.Enabled = false;
            this.gBoxBarometr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gBoxBarometr.Location = new System.Drawing.Point(367, 162);
            this.gBoxBarometr.Name = "gBoxBarometr";
            this.gBoxBarometr.Size = new System.Drawing.Size(355, 150);
            this.gBoxBarometr.TabIndex = 3;
            this.gBoxBarometr.TabStop = false;
            this.gBoxBarometr.Text = "Barometr";
            // 
            // labBarNazwaCzujnika
            // 
            this.labBarNazwaCzujnika.AutoSize = true;
            this.labBarNazwaCzujnika.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labBarNazwaCzujnika.Location = new System.Drawing.Point(6, 19);
            this.labBarNazwaCzujnika.Name = "labBarNazwaCzujnika";
            this.labBarNazwaCzujnika.Size = new System.Drawing.Size(99, 15);
            this.labBarNazwaCzujnika.TabIndex = 18;
            this.labBarNazwaCzujnika.Text = "Nazwa czujnika: ";
            // 
            // cBoxBarODR
            // 
            this.cBoxBarODR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cBoxBarODR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxBarODR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cBoxBarODR.FormattingEnabled = true;
            this.cBoxBarODR.Items.AddRange(new object[] {
            "1",
            "7",
            "12,5"});
            this.cBoxBarODR.Location = new System.Drawing.Point(9, 77);
            this.cBoxBarODR.Name = "cBoxBarODR";
            this.cBoxBarODR.Size = new System.Drawing.Size(121, 21);
            this.cBoxBarODR.TabIndex = 20;
            // 
            // labBarODR
            // 
            this.labBarODR.AutoSize = true;
            this.labBarODR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labBarODR.Location = new System.Drawing.Point(6, 59);
            this.labBarODR.Name = "labBarODR";
            this.labBarODR.Size = new System.Drawing.Size(37, 15);
            this.labBarODR.TabIndex = 23;
            this.labBarODR.Text = "ODR:";
            // 
            // gBoxBarRejestr
            // 
            this.gBoxBarRejestr.Controls.Add(this.buttonBarWczytaj);
            this.gBoxBarRejestr.Controls.Add(this.buttonBarUstaw);
            this.gBoxBarRejestr.Controls.Add(this.tBoxBarWartosc);
            this.gBoxBarRejestr.Controls.Add(this.tBoxBarAdres);
            this.gBoxBarRejestr.Controls.Add(this.labBarWartosc);
            this.gBoxBarRejestr.Controls.Add(this.labBarAdres);
            this.gBoxBarRejestr.Controls.Add(this.buttonBarOtworz);
            this.gBoxBarRejestr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gBoxBarRejestr.Location = new System.Drawing.Point(154, 39);
            this.gBoxBarRejestr.Name = "gBoxBarRejestr";
            this.gBoxBarRejestr.Size = new System.Drawing.Size(195, 105);
            this.gBoxBarRejestr.TabIndex = 21;
            this.gBoxBarRejestr.TabStop = false;
            this.gBoxBarRejestr.Text = "Rejestr";
            // 
            // buttonBarWczytaj
            // 
            this.buttonBarWczytaj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBarWczytaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonBarWczytaj.Location = new System.Drawing.Point(107, 54);
            this.buttonBarWczytaj.Name = "buttonBarWczytaj";
            this.buttonBarWczytaj.Size = new System.Drawing.Size(66, 23);
            this.buttonBarWczytaj.TabIndex = 20;
            this.buttonBarWczytaj.Text = "Wczytaj";
            this.buttonBarWczytaj.UseVisualStyleBackColor = true;
            // 
            // buttonBarUstaw
            // 
            this.buttonBarUstaw.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBarUstaw.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonBarUstaw.Location = new System.Drawing.Point(30, 54);
            this.buttonBarUstaw.Name = "buttonBarUstaw";
            this.buttonBarUstaw.Size = new System.Drawing.Size(66, 23);
            this.buttonBarUstaw.TabIndex = 19;
            this.buttonBarUstaw.Text = "Ustaw";
            this.buttonBarUstaw.UseVisualStyleBackColor = true;
            // 
            // tBoxBarWartosc
            // 
            this.tBoxBarWartosc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tBoxBarWartosc.Location = new System.Drawing.Point(107, 28);
            this.tBoxBarWartosc.Name = "tBoxBarWartosc";
            this.tBoxBarWartosc.Size = new System.Drawing.Size(66, 20);
            this.tBoxBarWartosc.TabIndex = 18;
            // 
            // tBoxBarAdres
            // 
            this.tBoxBarAdres.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tBoxBarAdres.Location = new System.Drawing.Point(30, 28);
            this.tBoxBarAdres.Name = "tBoxBarAdres";
            this.tBoxBarAdres.Size = new System.Drawing.Size(66, 20);
            this.tBoxBarAdres.TabIndex = 17;
            // 
            // labBarWartosc
            // 
            this.labBarWartosc.AutoSize = true;
            this.labBarWartosc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labBarWartosc.Location = new System.Drawing.Point(117, 10);
            this.labBarWartosc.Name = "labBarWartosc";
            this.labBarWartosc.Size = new System.Drawing.Size(54, 15);
            this.labBarWartosc.TabIndex = 16;
            this.labBarWartosc.Text = "Wartość:";
            // 
            // labBarAdres
            // 
            this.labBarAdres.AutoSize = true;
            this.labBarAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labBarAdres.Location = new System.Drawing.Point(43, 10);
            this.labBarAdres.Name = "labBarAdres";
            this.labBarAdres.Size = new System.Drawing.Size(41, 15);
            this.labBarAdres.TabIndex = 15;
            this.labBarAdres.Text = "Adres:";
            // 
            // buttonBarOtworz
            // 
            this.buttonBarOtworz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBarOtworz.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonBarOtworz.Location = new System.Drawing.Point(30, 79);
            this.buttonBarOtworz.Name = "buttonBarOtworz";
            this.buttonBarOtworz.Size = new System.Drawing.Size(143, 23);
            this.buttonBarOtworz.TabIndex = 14;
            this.buttonBarOtworz.Text = "Otwórz rejestr";
            this.buttonBarOtworz.UseVisualStyleBackColor = true;
            // 
            // buttonBarRysujWykres
            // 
            this.buttonBarRysujWykres.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBarRysujWykres.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBarRysujWykres.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonBarRysujWykres.ForeColor = System.Drawing.Color.LimeGreen;
            this.buttonBarRysujWykres.Location = new System.Drawing.Point(249, 15);
            this.buttonBarRysujWykres.Name = "buttonBarRysujWykres";
            this.buttonBarRysujWykres.Size = new System.Drawing.Size(100, 23);
            this.buttonBarRysujWykres.TabIndex = 22;
            this.buttonBarRysujWykres.Text = "Rysuj wykres";
            this.buttonBarRysujWykres.UseVisualStyleBackColor = true;
            // 
            // chBoxBarWlaczony
            // 
            this.chBoxBarWlaczony.AutoSize = true;
            this.chBoxBarWlaczony.Checked = true;
            this.chBoxBarWlaczony.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chBoxBarWlaczony.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chBoxBarWlaczony.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chBoxBarWlaczony.Location = new System.Drawing.Point(9, 37);
            this.chBoxBarWlaczony.Name = "chBoxBarWlaczony";
            this.chBoxBarWlaczony.Size = new System.Drawing.Size(78, 19);
            this.chBoxBarWlaczony.TabIndex = 19;
            this.chBoxBarWlaczony.Text = "Włączony";
            this.chBoxBarWlaczony.UseVisualStyleBackColor = true;
            this.chBoxBarWlaczony.CheckedChanged += new System.EventHandler(this.chBoxBarWlaczony_CheckedChanged);
            // 
            // gBoxZyroskop
            // 
            this.gBoxZyroskop.Controls.Add(this.LabZyroNazwaCzujnika);
            this.gBoxZyroskop.Controls.Add(this.cBoxZyroODR);
            this.gBoxZyroskop.Controls.Add(this.cBoxZyroSkala);
            this.gBoxZyroskop.Controls.Add(this.gBoxZyroRejestr);
            this.gBoxZyroskop.Controls.Add(this.buttonZyroRysujWykres);
            this.gBoxZyroskop.Controls.Add(this.labZyroODR);
            this.gBoxZyroskop.Controls.Add(this.labZyroSkala);
            this.gBoxZyroskop.Controls.Add(this.chBoxZyroWlaczony);
            this.gBoxZyroskop.Enabled = false;
            this.gBoxZyroskop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gBoxZyroskop.Location = new System.Drawing.Point(6, 162);
            this.gBoxZyroskop.Name = "gBoxZyroskop";
            this.gBoxZyroskop.Size = new System.Drawing.Size(355, 150);
            this.gBoxZyroskop.TabIndex = 1;
            this.gBoxZyroskop.TabStop = false;
            this.gBoxZyroskop.Text = "Żyroskop";
            // 
            // LabZyroNazwaCzujnika
            // 
            this.LabZyroNazwaCzujnika.AutoSize = true;
            this.LabZyroNazwaCzujnika.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabZyroNazwaCzujnika.Location = new System.Drawing.Point(6, 19);
            this.LabZyroNazwaCzujnika.Name = "LabZyroNazwaCzujnika";
            this.LabZyroNazwaCzujnika.Size = new System.Drawing.Size(99, 15);
            this.LabZyroNazwaCzujnika.TabIndex = 9;
            this.LabZyroNazwaCzujnika.Text = "Nazwa czujnika: ";
            // 
            // cBoxZyroODR
            // 
            this.cBoxZyroODR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cBoxZyroODR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxZyroODR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cBoxZyroODR.FormattingEnabled = true;
            this.cBoxZyroODR.Items.AddRange(new object[] {
            "12.5",
            "26",
            "52",
            "104",
            "208",
            "416",
            "833",
            "1660",
            "3330",
            "6660"});
            this.cBoxZyroODR.Location = new System.Drawing.Point(9, 119);
            this.cBoxZyroODR.Name = "cBoxZyroODR";
            this.cBoxZyroODR.Size = new System.Drawing.Size(121, 21);
            this.cBoxZyroODR.TabIndex = 14;
            // 
            // cBoxZyroSkala
            // 
            this.cBoxZyroSkala.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cBoxZyroSkala.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxZyroSkala.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cBoxZyroSkala.FormattingEnabled = true;
            this.cBoxZyroSkala.Items.AddRange(new object[] {
            "125",
            "250",
            "500",
            "1000",
            "2000"});
            this.cBoxZyroSkala.Location = new System.Drawing.Point(9, 77);
            this.cBoxZyroSkala.Name = "cBoxZyroSkala";
            this.cBoxZyroSkala.Size = new System.Drawing.Size(121, 21);
            this.cBoxZyroSkala.TabIndex = 12;
            // 
            // gBoxZyroRejestr
            // 
            this.gBoxZyroRejestr.Controls.Add(this.buttonZyroWczytaj);
            this.gBoxZyroRejestr.Controls.Add(this.buttonZyroUstaw);
            this.gBoxZyroRejestr.Controls.Add(this.tBoxZyroWartosc);
            this.gBoxZyroRejestr.Controls.Add(this.tBoxZyroAdres);
            this.gBoxZyroRejestr.Controls.Add(this.labZyroWartosc);
            this.gBoxZyroRejestr.Controls.Add(this.labZyroAdres);
            this.gBoxZyroRejestr.Controls.Add(this.buttonZyroOtworz);
            this.gBoxZyroRejestr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gBoxZyroRejestr.Location = new System.Drawing.Point(154, 39);
            this.gBoxZyroRejestr.Name = "gBoxZyroRejestr";
            this.gBoxZyroRejestr.Size = new System.Drawing.Size(195, 105);
            this.gBoxZyroRejestr.TabIndex = 15;
            this.gBoxZyroRejestr.TabStop = false;
            this.gBoxZyroRejestr.Text = "Rejestr";
            // 
            // buttonZyroWczytaj
            // 
            this.buttonZyroWczytaj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonZyroWczytaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonZyroWczytaj.Location = new System.Drawing.Point(107, 54);
            this.buttonZyroWczytaj.Name = "buttonZyroWczytaj";
            this.buttonZyroWczytaj.Size = new System.Drawing.Size(66, 23);
            this.buttonZyroWczytaj.TabIndex = 20;
            this.buttonZyroWczytaj.Text = "Wczytaj";
            this.buttonZyroWczytaj.UseVisualStyleBackColor = true;
            // 
            // buttonZyroUstaw
            // 
            this.buttonZyroUstaw.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonZyroUstaw.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonZyroUstaw.Location = new System.Drawing.Point(30, 54);
            this.buttonZyroUstaw.Name = "buttonZyroUstaw";
            this.buttonZyroUstaw.Size = new System.Drawing.Size(66, 23);
            this.buttonZyroUstaw.TabIndex = 19;
            this.buttonZyroUstaw.Text = "Ustaw";
            this.buttonZyroUstaw.UseVisualStyleBackColor = true;
            // 
            // tBoxZyroWartosc
            // 
            this.tBoxZyroWartosc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tBoxZyroWartosc.Location = new System.Drawing.Point(107, 28);
            this.tBoxZyroWartosc.Name = "tBoxZyroWartosc";
            this.tBoxZyroWartosc.Size = new System.Drawing.Size(66, 20);
            this.tBoxZyroWartosc.TabIndex = 18;
            // 
            // tBoxZyroAdres
            // 
            this.tBoxZyroAdres.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tBoxZyroAdres.Location = new System.Drawing.Point(30, 28);
            this.tBoxZyroAdres.Name = "tBoxZyroAdres";
            this.tBoxZyroAdres.Size = new System.Drawing.Size(66, 20);
            this.tBoxZyroAdres.TabIndex = 17;
            // 
            // labZyroWartosc
            // 
            this.labZyroWartosc.AutoSize = true;
            this.labZyroWartosc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labZyroWartosc.Location = new System.Drawing.Point(117, 10);
            this.labZyroWartosc.Name = "labZyroWartosc";
            this.labZyroWartosc.Size = new System.Drawing.Size(54, 15);
            this.labZyroWartosc.TabIndex = 16;
            this.labZyroWartosc.Text = "Wartość:";
            // 
            // labZyroAdres
            // 
            this.labZyroAdres.AutoSize = true;
            this.labZyroAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labZyroAdres.Location = new System.Drawing.Point(43, 10);
            this.labZyroAdres.Name = "labZyroAdres";
            this.labZyroAdres.Size = new System.Drawing.Size(41, 15);
            this.labZyroAdres.TabIndex = 15;
            this.labZyroAdres.Text = "Adres:";
            // 
            // buttonZyroOtworz
            // 
            this.buttonZyroOtworz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonZyroOtworz.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonZyroOtworz.Location = new System.Drawing.Point(30, 79);
            this.buttonZyroOtworz.Name = "buttonZyroOtworz";
            this.buttonZyroOtworz.Size = new System.Drawing.Size(143, 23);
            this.buttonZyroOtworz.TabIndex = 14;
            this.buttonZyroOtworz.Text = "Otwórz rejestr";
            this.buttonZyroOtworz.UseVisualStyleBackColor = true;
            // 
            // buttonZyroRysujWykres
            // 
            this.buttonZyroRysujWykres.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonZyroRysujWykres.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonZyroRysujWykres.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonZyroRysujWykres.ForeColor = System.Drawing.Color.LimeGreen;
            this.buttonZyroRysujWykres.Location = new System.Drawing.Point(249, 15);
            this.buttonZyroRysujWykres.Name = "buttonZyroRysujWykres";
            this.buttonZyroRysujWykres.Size = new System.Drawing.Size(100, 23);
            this.buttonZyroRysujWykres.TabIndex = 16;
            this.buttonZyroRysujWykres.Text = "Rysuj wykres";
            this.buttonZyroRysujWykres.UseVisualStyleBackColor = true;
            // 
            // labZyroODR
            // 
            this.labZyroODR.AutoSize = true;
            this.labZyroODR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labZyroODR.Location = new System.Drawing.Point(6, 101);
            this.labZyroODR.Name = "labZyroODR";
            this.labZyroODR.Size = new System.Drawing.Size(37, 15);
            this.labZyroODR.TabIndex = 13;
            this.labZyroODR.Text = "ODR:";
            // 
            // labZyroSkala
            // 
            this.labZyroSkala.AutoSize = true;
            this.labZyroSkala.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labZyroSkala.Location = new System.Drawing.Point(6, 59);
            this.labZyroSkala.Name = "labZyroSkala";
            this.labZyroSkala.Size = new System.Drawing.Size(75, 15);
            this.labZyroSkala.TabIndex = 11;
            this.labZyroSkala.Text = "Skala (oś Y):";
            // 
            // chBoxZyroWlaczony
            // 
            this.chBoxZyroWlaczony.AutoSize = true;
            this.chBoxZyroWlaczony.Checked = true;
            this.chBoxZyroWlaczony.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chBoxZyroWlaczony.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chBoxZyroWlaczony.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chBoxZyroWlaczony.Location = new System.Drawing.Point(9, 37);
            this.chBoxZyroWlaczony.Name = "chBoxZyroWlaczony";
            this.chBoxZyroWlaczony.Size = new System.Drawing.Size(78, 19);
            this.chBoxZyroWlaczony.TabIndex = 10;
            this.chBoxZyroWlaczony.Text = "Włączony";
            this.chBoxZyroWlaczony.UseVisualStyleBackColor = true;
            this.chBoxZyroWlaczony.CheckedChanged += new System.EventHandler(this.chBoxZyroWlaczony_CheckedChanged);
            // 
            // gBoxTermometr
            // 
            this.gBoxTermometr.Controls.Add(this.labTermNazwaCzujnika);
            this.gBoxTermometr.Controls.Add(this.cBoxTermODR);
            this.gBoxTermometr.Controls.Add(this.labTermODR);
            this.gBoxTermometr.Controls.Add(this.gBoxTermRejestr);
            this.gBoxTermometr.Controls.Add(this.buttonTermRysujWYkres);
            this.gBoxTermometr.Controls.Add(this.chBoxTermWlaczony);
            this.gBoxTermometr.Enabled = false;
            this.gBoxTermometr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gBoxTermometr.Location = new System.Drawing.Point(367, 6);
            this.gBoxTermometr.Name = "gBoxTermometr";
            this.gBoxTermometr.Size = new System.Drawing.Size(355, 150);
            this.gBoxTermometr.TabIndex = 2;
            this.gBoxTermometr.TabStop = false;
            this.gBoxTermometr.Text = "Termometr";
            // 
            // labTermNazwaCzujnika
            // 
            this.labTermNazwaCzujnika.AutoSize = true;
            this.labTermNazwaCzujnika.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labTermNazwaCzujnika.Location = new System.Drawing.Point(6, 19);
            this.labTermNazwaCzujnika.Name = "labTermNazwaCzujnika";
            this.labTermNazwaCzujnika.Size = new System.Drawing.Size(99, 15);
            this.labTermNazwaCzujnika.TabIndex = 9;
            this.labTermNazwaCzujnika.Text = "Nazwa czujnika: ";
            // 
            // cBoxTermODR
            // 
            this.cBoxTermODR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cBoxTermODR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxTermODR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cBoxTermODR.FormattingEnabled = true;
            this.cBoxTermODR.Items.AddRange(new object[] {
            "1",
            "10",
            "25",
            "50",
            "75"});
            this.cBoxTermODR.Location = new System.Drawing.Point(9, 77);
            this.cBoxTermODR.Name = "cBoxTermODR";
            this.cBoxTermODR.Size = new System.Drawing.Size(121, 21);
            this.cBoxTermODR.TabIndex = 12;
            // 
            // labTermODR
            // 
            this.labTermODR.AutoSize = true;
            this.labTermODR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labTermODR.Location = new System.Drawing.Point(6, 59);
            this.labTermODR.Name = "labTermODR";
            this.labTermODR.Size = new System.Drawing.Size(37, 15);
            this.labTermODR.TabIndex = 17;
            this.labTermODR.Text = "ODR:";
            // 
            // gBoxTermRejestr
            // 
            this.gBoxTermRejestr.Controls.Add(this.buttonTermWczytaj);
            this.gBoxTermRejestr.Controls.Add(this.buttonTermUstaw);
            this.gBoxTermRejestr.Controls.Add(this.tBoxTermWartosc);
            this.gBoxTermRejestr.Controls.Add(this.tBoxTermAdres);
            this.gBoxTermRejestr.Controls.Add(this.labTermWartosc);
            this.gBoxTermRejestr.Controls.Add(this.labTermAdres);
            this.gBoxTermRejestr.Controls.Add(this.buttonTermOtworz);
            this.gBoxTermRejestr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gBoxTermRejestr.Location = new System.Drawing.Point(154, 39);
            this.gBoxTermRejestr.Name = "gBoxTermRejestr";
            this.gBoxTermRejestr.Size = new System.Drawing.Size(195, 105);
            this.gBoxTermRejestr.TabIndex = 15;
            this.gBoxTermRejestr.TabStop = false;
            this.gBoxTermRejestr.Text = "Rejestr";
            // 
            // buttonTermWczytaj
            // 
            this.buttonTermWczytaj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTermWczytaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonTermWczytaj.Location = new System.Drawing.Point(107, 54);
            this.buttonTermWczytaj.Name = "buttonTermWczytaj";
            this.buttonTermWczytaj.Size = new System.Drawing.Size(66, 23);
            this.buttonTermWczytaj.TabIndex = 20;
            this.buttonTermWczytaj.Text = "Wczytaj";
            this.buttonTermWczytaj.UseVisualStyleBackColor = true;
            // 
            // buttonTermUstaw
            // 
            this.buttonTermUstaw.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTermUstaw.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonTermUstaw.Location = new System.Drawing.Point(30, 54);
            this.buttonTermUstaw.Name = "buttonTermUstaw";
            this.buttonTermUstaw.Size = new System.Drawing.Size(66, 23);
            this.buttonTermUstaw.TabIndex = 19;
            this.buttonTermUstaw.Text = "Ustaw";
            this.buttonTermUstaw.UseVisualStyleBackColor = true;
            // 
            // tBoxTermWartosc
            // 
            this.tBoxTermWartosc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tBoxTermWartosc.Location = new System.Drawing.Point(107, 28);
            this.tBoxTermWartosc.Name = "tBoxTermWartosc";
            this.tBoxTermWartosc.Size = new System.Drawing.Size(66, 20);
            this.tBoxTermWartosc.TabIndex = 18;
            // 
            // tBoxTermAdres
            // 
            this.tBoxTermAdres.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tBoxTermAdres.Location = new System.Drawing.Point(30, 28);
            this.tBoxTermAdres.Name = "tBoxTermAdres";
            this.tBoxTermAdres.Size = new System.Drawing.Size(66, 20);
            this.tBoxTermAdres.TabIndex = 17;
            // 
            // labTermWartosc
            // 
            this.labTermWartosc.AutoSize = true;
            this.labTermWartosc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labTermWartosc.Location = new System.Drawing.Point(117, 10);
            this.labTermWartosc.Name = "labTermWartosc";
            this.labTermWartosc.Size = new System.Drawing.Size(54, 15);
            this.labTermWartosc.TabIndex = 16;
            this.labTermWartosc.Text = "Wartość:";
            // 
            // labTermAdres
            // 
            this.labTermAdres.AutoSize = true;
            this.labTermAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labTermAdres.Location = new System.Drawing.Point(43, 10);
            this.labTermAdres.Name = "labTermAdres";
            this.labTermAdres.Size = new System.Drawing.Size(41, 15);
            this.labTermAdres.TabIndex = 15;
            this.labTermAdres.Text = "Adres:";
            // 
            // buttonTermOtworz
            // 
            this.buttonTermOtworz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTermOtworz.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonTermOtworz.Location = new System.Drawing.Point(30, 79);
            this.buttonTermOtworz.Name = "buttonTermOtworz";
            this.buttonTermOtworz.Size = new System.Drawing.Size(143, 23);
            this.buttonTermOtworz.TabIndex = 14;
            this.buttonTermOtworz.Text = "Otwórz rejestr";
            this.buttonTermOtworz.UseVisualStyleBackColor = true;
            // 
            // buttonTermRysujWYkres
            // 
            this.buttonTermRysujWYkres.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTermRysujWYkres.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTermRysujWYkres.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonTermRysujWYkres.ForeColor = System.Drawing.Color.LimeGreen;
            this.buttonTermRysujWYkres.Location = new System.Drawing.Point(249, 15);
            this.buttonTermRysujWYkres.Name = "buttonTermRysujWYkres";
            this.buttonTermRysujWYkres.Size = new System.Drawing.Size(100, 23);
            this.buttonTermRysujWYkres.TabIndex = 16;
            this.buttonTermRysujWYkres.Text = "Rysuj wykres";
            this.buttonTermRysujWYkres.UseVisualStyleBackColor = true;
            // 
            // chBoxTermWlaczony
            // 
            this.chBoxTermWlaczony.AutoSize = true;
            this.chBoxTermWlaczony.Checked = true;
            this.chBoxTermWlaczony.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chBoxTermWlaczony.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chBoxTermWlaczony.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chBoxTermWlaczony.Location = new System.Drawing.Point(9, 37);
            this.chBoxTermWlaczony.Name = "chBoxTermWlaczony";
            this.chBoxTermWlaczony.Size = new System.Drawing.Size(78, 19);
            this.chBoxTermWlaczony.TabIndex = 10;
            this.chBoxTermWlaczony.Text = "Włączony";
            this.chBoxTermWlaczony.UseVisualStyleBackColor = true;
            this.chBoxTermWlaczony.CheckedChanged += new System.EventHandler(this.chBoxTermWlaczony_CheckedChanged);
            // 
            // gBoxAkcelerometr
            // 
            this.gBoxAkcelerometr.Controls.Add(this.labAkcNazwa);
            this.gBoxAkcelerometr.Controls.Add(this.cBoxAkcODR);
            this.gBoxAkcelerometr.Controls.Add(this.cBoxAkcSkala);
            this.gBoxAkcelerometr.Controls.Add(this.gBoxAkcRejestr);
            this.gBoxAkcelerometr.Controls.Add(this.buttonAkcRysujWykres);
            this.gBoxAkcelerometr.Controls.Add(this.labAkcLiczbaProbek);
            this.gBoxAkcelerometr.Controls.Add(this.labAkcSkala);
            this.gBoxAkcelerometr.Controls.Add(this.chBoxAkcWlaczony);
            this.gBoxAkcelerometr.Enabled = false;
            this.gBoxAkcelerometr.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gBoxAkcelerometr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gBoxAkcelerometr.Location = new System.Drawing.Point(6, 6);
            this.gBoxAkcelerometr.Name = "gBoxAkcelerometr";
            this.gBoxAkcelerometr.Size = new System.Drawing.Size(355, 150);
            this.gBoxAkcelerometr.TabIndex = 0;
            this.gBoxAkcelerometr.TabStop = false;
            this.gBoxAkcelerometr.Text = "Akcelerometr";
            // 
            // labAkcNazwa
            // 
            this.labAkcNazwa.AutoSize = true;
            this.labAkcNazwa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labAkcNazwa.Location = new System.Drawing.Point(6, 19);
            this.labAkcNazwa.Name = "labAkcNazwa";
            this.labAkcNazwa.Size = new System.Drawing.Size(99, 15);
            this.labAkcNazwa.TabIndex = 0;
            this.labAkcNazwa.Text = "Nazwa czujnika: ";
            // 
            // cBoxAkcODR
            // 
            this.cBoxAkcODR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cBoxAkcODR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxAkcODR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cBoxAkcODR.FormattingEnabled = true;
            this.cBoxAkcODR.Items.AddRange(new object[] {
            "12.5",
            "26",
            "52",
            "104",
            "208",
            "416",
            "833",
            "1660",
            "3330",
            "6660"});
            this.cBoxAkcODR.Location = new System.Drawing.Point(9, 119);
            this.cBoxAkcODR.Name = "cBoxAkcODR";
            this.cBoxAkcODR.Size = new System.Drawing.Size(121, 21);
            this.cBoxAkcODR.TabIndex = 5;
            // 
            // cBoxAkcSkala
            // 
            this.cBoxAkcSkala.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cBoxAkcSkala.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxAkcSkala.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cBoxAkcSkala.FormattingEnabled = true;
            this.cBoxAkcSkala.Items.AddRange(new object[] {
            "2",
            "4",
            "8",
            "16"});
            this.cBoxAkcSkala.Location = new System.Drawing.Point(9, 77);
            this.cBoxAkcSkala.Name = "cBoxAkcSkala";
            this.cBoxAkcSkala.Size = new System.Drawing.Size(121, 21);
            this.cBoxAkcSkala.TabIndex = 3;
            // 
            // gBoxAkcRejestr
            // 
            this.gBoxAkcRejestr.Controls.Add(this.buttonAkcWczytaj);
            this.gBoxAkcRejestr.Controls.Add(this.buttonAkcUstaw);
            this.gBoxAkcRejestr.Controls.Add(this.tBoxAkcWartosc);
            this.gBoxAkcRejestr.Controls.Add(this.tBoxAkcAdres);
            this.gBoxAkcRejestr.Controls.Add(this.labAkcWartosc);
            this.gBoxAkcRejestr.Controls.Add(this.labAkcAdres);
            this.gBoxAkcRejestr.Controls.Add(this.buttonAkcOtworz);
            this.gBoxAkcRejestr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gBoxAkcRejestr.Location = new System.Drawing.Point(154, 39);
            this.gBoxAkcRejestr.Name = "gBoxAkcRejestr";
            this.gBoxAkcRejestr.Size = new System.Drawing.Size(195, 105);
            this.gBoxAkcRejestr.TabIndex = 7;
            this.gBoxAkcRejestr.TabStop = false;
            this.gBoxAkcRejestr.Text = "Rejestr";
            // 
            // buttonAkcWczytaj
            // 
            this.buttonAkcWczytaj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAkcWczytaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAkcWczytaj.Location = new System.Drawing.Point(107, 54);
            this.buttonAkcWczytaj.Name = "buttonAkcWczytaj";
            this.buttonAkcWczytaj.Size = new System.Drawing.Size(66, 23);
            this.buttonAkcWczytaj.TabIndex = 20;
            this.buttonAkcWczytaj.Text = "Wczytaj";
            this.buttonAkcWczytaj.UseVisualStyleBackColor = true;
            // 
            // buttonAkcUstaw
            // 
            this.buttonAkcUstaw.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAkcUstaw.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAkcUstaw.Location = new System.Drawing.Point(30, 54);
            this.buttonAkcUstaw.Name = "buttonAkcUstaw";
            this.buttonAkcUstaw.Size = new System.Drawing.Size(66, 23);
            this.buttonAkcUstaw.TabIndex = 19;
            this.buttonAkcUstaw.Text = "Ustaw";
            this.buttonAkcUstaw.UseVisualStyleBackColor = true;
            // 
            // tBoxAkcWartosc
            // 
            this.tBoxAkcWartosc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tBoxAkcWartosc.Location = new System.Drawing.Point(107, 28);
            this.tBoxAkcWartosc.Name = "tBoxAkcWartosc";
            this.tBoxAkcWartosc.Size = new System.Drawing.Size(66, 20);
            this.tBoxAkcWartosc.TabIndex = 18;
            // 
            // tBoxAkcAdres
            // 
            this.tBoxAkcAdres.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tBoxAkcAdres.Location = new System.Drawing.Point(30, 28);
            this.tBoxAkcAdres.Name = "tBoxAkcAdres";
            this.tBoxAkcAdres.Size = new System.Drawing.Size(66, 20);
            this.tBoxAkcAdres.TabIndex = 17;
            // 
            // labAkcWartosc
            // 
            this.labAkcWartosc.AutoSize = true;
            this.labAkcWartosc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labAkcWartosc.Location = new System.Drawing.Point(117, 10);
            this.labAkcWartosc.Name = "labAkcWartosc";
            this.labAkcWartosc.Size = new System.Drawing.Size(54, 15);
            this.labAkcWartosc.TabIndex = 16;
            this.labAkcWartosc.Text = "Wartość:";
            // 
            // labAkcAdres
            // 
            this.labAkcAdres.AutoSize = true;
            this.labAkcAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labAkcAdres.Location = new System.Drawing.Point(43, 10);
            this.labAkcAdres.Name = "labAkcAdres";
            this.labAkcAdres.Size = new System.Drawing.Size(41, 15);
            this.labAkcAdres.TabIndex = 15;
            this.labAkcAdres.Text = "Adres:";
            // 
            // buttonAkcOtworz
            // 
            this.buttonAkcOtworz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAkcOtworz.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAkcOtworz.Location = new System.Drawing.Point(30, 79);
            this.buttonAkcOtworz.Name = "buttonAkcOtworz";
            this.buttonAkcOtworz.Size = new System.Drawing.Size(143, 23);
            this.buttonAkcOtworz.TabIndex = 14;
            this.buttonAkcOtworz.Text = "Otwórz rejestr";
            this.buttonAkcOtworz.UseVisualStyleBackColor = true;
            // 
            // buttonAkcRysujWykres
            // 
            this.buttonAkcRysujWykres.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAkcRysujWykres.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAkcRysujWykres.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAkcRysujWykres.ForeColor = System.Drawing.Color.LimeGreen;
            this.buttonAkcRysujWykres.Location = new System.Drawing.Point(249, 15);
            this.buttonAkcRysujWykres.Name = "buttonAkcRysujWykres";
            this.buttonAkcRysujWykres.Size = new System.Drawing.Size(100, 23);
            this.buttonAkcRysujWykres.TabIndex = 8;
            this.buttonAkcRysujWykres.Text = "Rysuj wykres";
            this.buttonAkcRysujWykres.UseVisualStyleBackColor = true;
            // 
            // labAkcLiczbaProbek
            // 
            this.labAkcLiczbaProbek.AutoSize = true;
            this.labAkcLiczbaProbek.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labAkcLiczbaProbek.Location = new System.Drawing.Point(6, 101);
            this.labAkcLiczbaProbek.Name = "labAkcLiczbaProbek";
            this.labAkcLiczbaProbek.Size = new System.Drawing.Size(37, 15);
            this.labAkcLiczbaProbek.TabIndex = 4;
            this.labAkcLiczbaProbek.Text = "ODR:";
            // 
            // labAkcSkala
            // 
            this.labAkcSkala.AutoSize = true;
            this.labAkcSkala.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labAkcSkala.Location = new System.Drawing.Point(6, 59);
            this.labAkcSkala.Name = "labAkcSkala";
            this.labAkcSkala.Size = new System.Drawing.Size(75, 15);
            this.labAkcSkala.TabIndex = 2;
            this.labAkcSkala.Text = "Skala (oś Y):";
            // 
            // chBoxAkcWlaczony
            // 
            this.chBoxAkcWlaczony.AutoSize = true;
            this.chBoxAkcWlaczony.Checked = true;
            this.chBoxAkcWlaczony.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chBoxAkcWlaczony.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chBoxAkcWlaczony.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chBoxAkcWlaczony.Location = new System.Drawing.Point(9, 37);
            this.chBoxAkcWlaczony.Name = "chBoxAkcWlaczony";
            this.chBoxAkcWlaczony.Size = new System.Drawing.Size(78, 19);
            this.chBoxAkcWlaczony.TabIndex = 1;
            this.chBoxAkcWlaczony.Text = "Włączony";
            this.chBoxAkcWlaczony.UseVisualStyleBackColor = true;
            this.chBoxAkcWlaczony.CheckedChanged += new System.EventHandler(this.chBoxAkcWlaczony_CheckedChanged);
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
            ((System.ComponentModel.ISupportInitialize)(this.pBoxLogoWEL)).EndInit();
            this.gBoxInfo.ResumeLayout(false);
            this.gBoxInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxPlytka)).EndInit();
            this.tabPageCzujniki.ResumeLayout(false);
            this.gBoxHigrometr.ResumeLayout(false);
            this.gBoxHigrometr.PerformLayout();
            this.gBoxHigRejestr.ResumeLayout(false);
            this.gBoxHigRejestr.PerformLayout();
            this.gBoxMagnetometr.ResumeLayout(false);
            this.gBoxMagnetometr.PerformLayout();
            this.gBoxMagRejestr.ResumeLayout(false);
            this.gBoxMagRejestr.PerformLayout();
            this.gBoxBarometr.ResumeLayout(false);
            this.gBoxBarometr.PerformLayout();
            this.gBoxBarRejestr.ResumeLayout(false);
            this.gBoxBarRejestr.PerformLayout();
            this.gBoxZyroskop.ResumeLayout(false);
            this.gBoxZyroskop.PerformLayout();
            this.gBoxZyroRejestr.ResumeLayout(false);
            this.gBoxZyroRejestr.PerformLayout();
            this.gBoxTermometr.ResumeLayout(false);
            this.gBoxTermometr.PerformLayout();
            this.gBoxTermRejestr.ResumeLayout(false);
            this.gBoxTermRejestr.PerformLayout();
            this.gBoxAkcelerometr.ResumeLayout(false);
            this.gBoxAkcelerometr.PerformLayout();
            this.gBoxAkcRejestr.ResumeLayout(false);
            this.gBoxAkcRejestr.PerformLayout();
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
        private System.Windows.Forms.Label labelTytul;
        private System.Windows.Forms.Label labelBrakPlytek;
        private System.Windows.Forms.Label labelDostepnePorty;
        private System.Windows.Forms.Label labelWersja;
        private System.Windows.Forms.PictureBox pBoxPlytka;
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
        private System.Windows.Forms.PictureBox pBoxLogoWEL;
        private System.ComponentModel.BackgroundWorker bgWorkerOtworz;
        private System.Windows.Forms.GroupBox gBoxHigrometr;
        private System.Windows.Forms.GroupBox gBoxMagnetometr;
        private System.Windows.Forms.GroupBox gBoxBarometr;
        private System.Windows.Forms.GroupBox gBoxZyroskop;
        private System.Windows.Forms.GroupBox gBoxTermometr;
        private System.Windows.Forms.GroupBox gBoxAkcelerometr;
        private System.Windows.Forms.GroupBox gBoxMagRejestr;
        private System.Windows.Forms.Button buttonMagWczytaj;
        private System.Windows.Forms.Button buttonMagUstaw;
        private System.Windows.Forms.TextBox tBoxMagWartosc;
        private System.Windows.Forms.TextBox tBoxMagAdres;
        private System.Windows.Forms.Label labMagWartosc;
        private System.Windows.Forms.Label labMagAdres;
        private System.Windows.Forms.Button buttonMagOtworz;
        private System.Windows.Forms.Button buttonMagRysujWykres;
        private System.Windows.Forms.ComboBox cBoxMagODR;
        private System.Windows.Forms.Label labMagODR;
        private System.Windows.Forms.ComboBox cBoxMagSkala;
        private System.Windows.Forms.Label labMagSkala;
        private System.Windows.Forms.CheckBox chBoxMagWlaczony;
        private System.Windows.Forms.Label labMagNazwaCzujnika;
        private System.Windows.Forms.GroupBox gBoxZyroRejestr;
        private System.Windows.Forms.Button buttonZyroWczytaj;
        private System.Windows.Forms.Button buttonZyroUstaw;
        private System.Windows.Forms.TextBox tBoxZyroWartosc;
        private System.Windows.Forms.TextBox tBoxZyroAdres;
        private System.Windows.Forms.Label labZyroWartosc;
        private System.Windows.Forms.Label labZyroAdres;
        private System.Windows.Forms.Button buttonZyroOtworz;
        private System.Windows.Forms.Button buttonZyroRysujWykres;
        private System.Windows.Forms.ComboBox cBoxZyroODR;
        private System.Windows.Forms.Label labZyroODR;
        private System.Windows.Forms.ComboBox cBoxZyroSkala;
        private System.Windows.Forms.Label labZyroSkala;
        private System.Windows.Forms.CheckBox chBoxZyroWlaczony;
        private System.Windows.Forms.Label LabZyroNazwaCzujnika;
        private System.Windows.Forms.GroupBox gBoxTermRejestr;
        private System.Windows.Forms.Button buttonTermWczytaj;
        private System.Windows.Forms.Button buttonTermUstaw;
        private System.Windows.Forms.TextBox tBoxTermWartosc;
        private System.Windows.Forms.TextBox tBoxTermAdres;
        private System.Windows.Forms.Label labTermWartosc;
        private System.Windows.Forms.Label labTermAdres;
        private System.Windows.Forms.Button buttonTermOtworz;
        private System.Windows.Forms.Button buttonTermRysujWYkres;
        private System.Windows.Forms.ComboBox cBoxTermODR;
        private System.Windows.Forms.CheckBox chBoxTermWlaczony;
        private System.Windows.Forms.Label labTermNazwaCzujnika;
        private System.Windows.Forms.GroupBox gBoxAkcRejestr;
        private System.Windows.Forms.Button buttonAkcWczytaj;
        private System.Windows.Forms.Button buttonAkcUstaw;
        private System.Windows.Forms.TextBox tBoxAkcWartosc;
        private System.Windows.Forms.TextBox tBoxAkcAdres;
        private System.Windows.Forms.Label labAkcWartosc;
        private System.Windows.Forms.Label labAkcAdres;
        private System.Windows.Forms.Button buttonAkcOtworz;
        private System.Windows.Forms.Button buttonAkcRysujWykres;
        private System.Windows.Forms.ComboBox cBoxAkcODR;
        private System.Windows.Forms.Label labAkcLiczbaProbek;
        private System.Windows.Forms.ComboBox cBoxAkcSkala;
        private System.Windows.Forms.Label labAkcSkala;
        private System.Windows.Forms.CheckBox chBoxAkcWlaczony;
        private System.Windows.Forms.Label labAkcNazwa;
        private System.Windows.Forms.Label labHigODR;
        private System.Windows.Forms.GroupBox gBoxHigRejestr;
        private System.Windows.Forms.Button buttonHigWczytaj;
        private System.Windows.Forms.Button buttonHigUstaw;
        private System.Windows.Forms.TextBox tBoxHigWartosc;
        private System.Windows.Forms.TextBox tBoxHigAdres;
        private System.Windows.Forms.Label labHigWartosc;
        private System.Windows.Forms.Label labHigAdres;
        private System.Windows.Forms.Button buttonHigOtworz;
        private System.Windows.Forms.Button buttonHigRysujWykres;
        private System.Windows.Forms.ComboBox cBoxHigODR;
        private System.Windows.Forms.CheckBox chBoxHigWlaczony;
        private System.Windows.Forms.Label labHigNazwaCzujnika;
        private System.Windows.Forms.Label labBarODR;
        private System.Windows.Forms.GroupBox gBoxBarRejestr;
        private System.Windows.Forms.Button buttonBarWczytaj;
        private System.Windows.Forms.Button buttonBarUstaw;
        private System.Windows.Forms.TextBox tBoxBarWartosc;
        private System.Windows.Forms.TextBox tBoxBarAdres;
        private System.Windows.Forms.Label labBarWartosc;
        private System.Windows.Forms.Label labBarAdres;
        private System.Windows.Forms.Button buttonBarOtworz;
        private System.Windows.Forms.Button buttonBarRysujWykres;
        private System.Windows.Forms.ComboBox cBoxBarODR;
        private System.Windows.Forms.CheckBox chBoxBarWlaczony;
        private System.Windows.Forms.Label labBarNazwaCzujnika;
        private System.Windows.Forms.Label labTermODR;
    }
}

