
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gBoxHigrometr = new System.Windows.Forms.GroupBox();
            this.gBoxMagnetometr = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label15 = new System.Windows.Forms.Label();
            this.gBoxBarometr = new System.Windows.Forms.GroupBox();
            this.gBoxŻyroskop = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.gBoxTermometr = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.comboBox8 = new System.Windows.Forms.ComboBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.label20 = new System.Windows.Forms.Label();
            this.gBoxAkcelerometr = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chBoxWlaczonyAkc = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.button23 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.comboBox9 = new System.Windows.Forms.ComboBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.label27 = new System.Windows.Forms.Label();
            this.tabControlCzujniki.SuspendLayout();
            this.tabPageOgolne.SuspendLayout();
            this.gBoxCzujniki.SuspendLayout();
            this.gBoxPolaczenie.SuspendLayout();
            this.gBoxInfo.SuspendLayout();
            this.tabPageCzujniki.SuspendLayout();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gBoxHigrometr.SuspendLayout();
            this.gBoxMagnetometr.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gBoxBarometr.SuspendLayout();
            this.gBoxŻyroskop.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gBoxTermometr.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.gBoxAkcelerometr.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
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
            this.tabPageCzujniki.Controls.Add(this.gBoxHigrometr);
            this.tabPageCzujniki.Controls.Add(this.gBoxMagnetometr);
            this.tabPageCzujniki.Controls.Add(this.gBoxBarometr);
            this.tabPageCzujniki.Controls.Add(this.gBoxŻyroskop);
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
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Aplikacja_MEMS.Properties.Resources.WEL_WAT;
            this.pictureBox2.Location = new System.Drawing.Point(328, 38);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(80, 80);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
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
            // gBoxHigrometr
            // 
            this.gBoxHigrometr.Controls.Add(this.label24);
            this.gBoxHigrometr.Controls.Add(this.groupBox6);
            this.gBoxHigrometr.Controls.Add(this.button24);
            this.gBoxHigrometr.Controls.Add(this.comboBox9);
            this.gBoxHigrometr.Controls.Add(this.checkBox5);
            this.gBoxHigrometr.Controls.Add(this.label27);
            this.gBoxHigrometr.Enabled = false;
            this.gBoxHigrometr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gBoxHigrometr.Location = new System.Drawing.Point(369, 318);
            this.gBoxHigrometr.Name = "gBoxHigrometr";
            this.gBoxHigrometr.Size = new System.Drawing.Size(355, 150);
            this.gBoxHigrometr.TabIndex = 4;
            this.gBoxHigrometr.TabStop = false;
            this.gBoxHigrometr.Text = "Higrometr";
            // 
            // gBoxMagnetometr
            // 
            this.gBoxMagnetometr.Controls.Add(this.groupBox3);
            this.gBoxMagnetometr.Controls.Add(this.button12);
            this.gBoxMagnetometr.Controls.Add(this.comboBox5);
            this.gBoxMagnetometr.Controls.Add(this.label13);
            this.gBoxMagnetometr.Controls.Add(this.comboBox6);
            this.gBoxMagnetometr.Controls.Add(this.label14);
            this.gBoxMagnetometr.Controls.Add(this.checkBox2);
            this.gBoxMagnetometr.Controls.Add(this.label15);
            this.gBoxMagnetometr.Enabled = false;
            this.gBoxMagnetometr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gBoxMagnetometr.Location = new System.Drawing.Point(8, 318);
            this.gBoxMagnetometr.Name = "gBoxMagnetometr";
            this.gBoxMagnetometr.Size = new System.Drawing.Size(355, 150);
            this.gBoxMagnetometr.TabIndex = 1;
            this.gBoxMagnetometr.TabStop = false;
            this.gBoxMagnetometr.Text = "Magnetometr";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button9);
            this.groupBox3.Controls.Add(this.button10);
            this.groupBox3.Controls.Add(this.textBox5);
            this.groupBox3.Controls.Add(this.textBox6);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.button11);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox3.Location = new System.Drawing.Point(154, 39);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(195, 105);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Rejestr";
            // 
            // button9
            // 
            this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button9.Location = new System.Drawing.Point(107, 54);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(66, 23);
            this.button9.TabIndex = 20;
            this.button9.Text = "Wczytaj";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button10.Location = new System.Drawing.Point(30, 54);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(66, 23);
            this.button10.TabIndex = 19;
            this.button10.Text = "Ustaw";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            this.textBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBox5.Location = new System.Drawing.Point(107, 28);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(66, 20);
            this.textBox5.TabIndex = 18;
            // 
            // textBox6
            // 
            this.textBox6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBox6.Location = new System.Drawing.Point(30, 28);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(66, 20);
            this.textBox6.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(117, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 15);
            this.label11.TabIndex = 16;
            this.label11.Text = "Wartość:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(43, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 15);
            this.label12.TabIndex = 15;
            this.label12.Text = "Adres:";
            // 
            // button11
            // 
            this.button11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button11.Location = new System.Drawing.Point(30, 79);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(143, 23);
            this.button11.TabIndex = 14;
            this.button11.Text = "Otwórz rejestr";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button12.ForeColor = System.Drawing.Color.LimeGreen;
            this.button12.Location = new System.Drawing.Point(249, 15);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(100, 23);
            this.button12.TabIndex = 16;
            this.button12.Text = "Rysuj wykres";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // comboBox5
            // 
            this.comboBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(9, 119);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(121, 21);
            this.comboBox5.TabIndex = 14;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.Location = new System.Drawing.Point(6, 101);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(87, 15);
            this.label13.TabIndex = 13;
            this.label13.Text = "Liczba próbek:";
            // 
            // comboBox6
            // 
            this.comboBox6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(9, 77);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(121, 21);
            this.comboBox6.TabIndex = 12;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label14.Location = new System.Drawing.Point(6, 59);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 15);
            this.label14.TabIndex = 11;
            this.label14.Text = "Skala (oś Y):";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBox2.Location = new System.Drawing.Point(9, 37);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(78, 19);
            this.checkBox2.TabIndex = 10;
            this.checkBox2.Text = "Włączony";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label15.Location = new System.Drawing.Point(6, 19);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(99, 15);
            this.label15.TabIndex = 9;
            this.label15.Text = "Nazwa czujnika: ";
            // 
            // gBoxBarometr
            // 
            this.gBoxBarometr.Controls.Add(this.label19);
            this.gBoxBarometr.Controls.Add(this.groupBox5);
            this.gBoxBarometr.Controls.Add(this.button20);
            this.gBoxBarometr.Controls.Add(this.comboBox7);
            this.gBoxBarometr.Controls.Add(this.checkBox4);
            this.gBoxBarometr.Controls.Add(this.label23);
            this.gBoxBarometr.Enabled = false;
            this.gBoxBarometr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gBoxBarometr.Location = new System.Drawing.Point(367, 162);
            this.gBoxBarometr.Name = "gBoxBarometr";
            this.gBoxBarometr.Size = new System.Drawing.Size(355, 150);
            this.gBoxBarometr.TabIndex = 3;
            this.gBoxBarometr.TabStop = false;
            this.gBoxBarometr.Text = "Barometr";
            // 
            // gBoxŻyroskop
            // 
            this.gBoxŻyroskop.Controls.Add(this.groupBox2);
            this.gBoxŻyroskop.Controls.Add(this.button8);
            this.gBoxŻyroskop.Controls.Add(this.comboBox3);
            this.gBoxŻyroskop.Controls.Add(this.label8);
            this.gBoxŻyroskop.Controls.Add(this.comboBox4);
            this.gBoxŻyroskop.Controls.Add(this.label9);
            this.gBoxŻyroskop.Controls.Add(this.checkBox1);
            this.gBoxŻyroskop.Controls.Add(this.label10);
            this.gBoxŻyroskop.Enabled = false;
            this.gBoxŻyroskop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gBoxŻyroskop.Location = new System.Drawing.Point(6, 162);
            this.gBoxŻyroskop.Name = "gBoxŻyroskop";
            this.gBoxŻyroskop.Size = new System.Drawing.Size(355, 150);
            this.gBoxŻyroskop.TabIndex = 1;
            this.gBoxŻyroskop.TabStop = false;
            this.gBoxŻyroskop.Text = "Żyroskop";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.button7);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox2.Location = new System.Drawing.Point(154, 39);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(195, 105);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rejestr";
            // 
            // button5
            // 
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button5.Location = new System.Drawing.Point(107, 54);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(66, 23);
            this.button5.TabIndex = 20;
            this.button5.Text = "Wczytaj";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button6.Location = new System.Drawing.Point(30, 54);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(66, 23);
            this.button6.TabIndex = 19;
            this.button6.Text = "Ustaw";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBox3.Location = new System.Drawing.Point(107, 28);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(66, 20);
            this.textBox3.TabIndex = 18;
            // 
            // textBox4
            // 
            this.textBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBox4.Location = new System.Drawing.Point(30, 28);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(66, 20);
            this.textBox4.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(117, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "Wartość:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(43, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "Adres:";
            // 
            // button7
            // 
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button7.Location = new System.Drawing.Point(30, 79);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(143, 23);
            this.button7.TabIndex = 14;
            this.button7.Text = "Otwórz rejestr";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button8.ForeColor = System.Drawing.Color.LimeGreen;
            this.button8.Location = new System.Drawing.Point(249, 15);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(100, 23);
            this.button8.TabIndex = 16;
            this.button8.Text = "Rysuj wykres";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // comboBox3
            // 
            this.comboBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(9, 119);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(6, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 15);
            this.label8.TabIndex = 13;
            this.label8.Text = "Liczba próbek:";
            // 
            // comboBox4
            // 
            this.comboBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(9, 77);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 21);
            this.comboBox4.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(6, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 15);
            this.label9.TabIndex = 11;
            this.label9.Text = "Skala (oś Y):";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBox1.Location = new System.Drawing.Point(9, 37);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(78, 19);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Włączony";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(6, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 15);
            this.label10.TabIndex = 9;
            this.label10.Text = "Nazwa czujnika: ";
            // 
            // gBoxTermometr
            // 
            this.gBoxTermometr.Controls.Add(this.label18);
            this.gBoxTermometr.Controls.Add(this.groupBox4);
            this.gBoxTermometr.Controls.Add(this.button16);
            this.gBoxTermometr.Controls.Add(this.comboBox8);
            this.gBoxTermometr.Controls.Add(this.checkBox3);
            this.gBoxTermometr.Controls.Add(this.label20);
            this.gBoxTermometr.Enabled = false;
            this.gBoxTermometr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gBoxTermometr.Location = new System.Drawing.Point(367, 6);
            this.gBoxTermometr.Name = "gBoxTermometr";
            this.gBoxTermometr.Size = new System.Drawing.Size(355, 150);
            this.gBoxTermometr.TabIndex = 2;
            this.gBoxTermometr.TabStop = false;
            this.gBoxTermometr.Text = "Termometr";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button13);
            this.groupBox4.Controls.Add(this.button14);
            this.groupBox4.Controls.Add(this.textBox7);
            this.groupBox4.Controls.Add(this.textBox8);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.button15);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox4.Location = new System.Drawing.Point(154, 39);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(195, 105);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Rejestr";
            // 
            // button13
            // 
            this.button13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button13.Location = new System.Drawing.Point(107, 54);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(66, 23);
            this.button13.TabIndex = 20;
            this.button13.Text = "Wczytaj";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button14.Location = new System.Drawing.Point(30, 54);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(66, 23);
            this.button14.TabIndex = 19;
            this.button14.Text = "Ustaw";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // textBox7
            // 
            this.textBox7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBox7.Location = new System.Drawing.Point(107, 28);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(66, 20);
            this.textBox7.TabIndex = 18;
            // 
            // textBox8
            // 
            this.textBox8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBox8.Location = new System.Drawing.Point(30, 28);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(66, 20);
            this.textBox8.TabIndex = 17;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label16.Location = new System.Drawing.Point(117, 10);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(54, 15);
            this.label16.TabIndex = 16;
            this.label16.Text = "Wartość:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label17.Location = new System.Drawing.Point(43, 10);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(41, 15);
            this.label17.TabIndex = 15;
            this.label17.Text = "Adres:";
            // 
            // button15
            // 
            this.button15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button15.Location = new System.Drawing.Point(30, 79);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(143, 23);
            this.button15.TabIndex = 14;
            this.button15.Text = "Otwórz rejestr";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            this.button16.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button16.ForeColor = System.Drawing.Color.LimeGreen;
            this.button16.Location = new System.Drawing.Point(249, 15);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(100, 23);
            this.button16.TabIndex = 16;
            this.button16.Text = "Rysuj wykres";
            this.button16.UseVisualStyleBackColor = true;
            // 
            // comboBox8
            // 
            this.comboBox8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox8.FormattingEnabled = true;
            this.comboBox8.Location = new System.Drawing.Point(9, 77);
            this.comboBox8.Name = "comboBox8";
            this.comboBox8.Size = new System.Drawing.Size(121, 21);
            this.comboBox8.TabIndex = 12;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBox3.Location = new System.Drawing.Point(9, 37);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(78, 19);
            this.checkBox3.TabIndex = 10;
            this.checkBox3.Text = "Włączony";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label20.Location = new System.Drawing.Point(6, 19);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(99, 15);
            this.label20.TabIndex = 9;
            this.label20.Text = "Nazwa czujnika: ";
            // 
            // gBoxAkcelerometr
            // 
            this.gBoxAkcelerometr.Controls.Add(this.groupBox1);
            this.gBoxAkcelerometr.Controls.Add(this.button1);
            this.gBoxAkcelerometr.Controls.Add(this.comboBox2);
            this.gBoxAkcelerometr.Controls.Add(this.label3);
            this.gBoxAkcelerometr.Controls.Add(this.comboBox1);
            this.gBoxAkcelerometr.Controls.Add(this.label2);
            this.gBoxAkcelerometr.Controls.Add(this.chBoxWlaczonyAkc);
            this.gBoxAkcelerometr.Controls.Add(this.label1);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(154, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(195, 105);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rejestr";
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button4.Location = new System.Drawing.Point(107, 54);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(66, 23);
            this.button4.TabIndex = 20;
            this.button4.Text = "Wczytaj";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.Location = new System.Drawing.Point(30, 54);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(66, 23);
            this.button3.TabIndex = 19;
            this.button3.Text = "Ustaw";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBox2.Location = new System.Drawing.Point(107, 28);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(66, 20);
            this.textBox2.TabIndex = 18;
            // 
            // textBox1
            // 
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBox1.Location = new System.Drawing.Point(30, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(66, 20);
            this.textBox1.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(117, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "Wartość:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(43, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "Adres:";
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(30, 79);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Otwórz rejestr";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.Color.LimeGreen;
            this.button1.Location = new System.Drawing.Point(249, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Rysuj wykres";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(9, 119);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(6, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Liczba próbek:";
            // 
            // comboBox1
            // 
            this.comboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(9, 77);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(6, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Skala (oś Y):";
            // 
            // chBoxWlaczonyAkc
            // 
            this.chBoxWlaczonyAkc.AutoSize = true;
            this.chBoxWlaczonyAkc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chBoxWlaczonyAkc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chBoxWlaczonyAkc.Location = new System.Drawing.Point(9, 37);
            this.chBoxWlaczonyAkc.Name = "chBoxWlaczonyAkc";
            this.chBoxWlaczonyAkc.Size = new System.Drawing.Size(78, 19);
            this.chBoxWlaczonyAkc.TabIndex = 1;
            this.chBoxWlaczonyAkc.Text = "Włączony";
            this.chBoxWlaczonyAkc.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nazwa czujnika: ";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label18.Location = new System.Drawing.Point(6, 59);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(87, 15);
            this.label18.TabIndex = 17;
            this.label18.Text = "Liczba próbek:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label19.Location = new System.Drawing.Point(6, 59);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(87, 15);
            this.label19.TabIndex = 23;
            this.label19.Text = "Liczba próbek:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button17);
            this.groupBox5.Controls.Add(this.button18);
            this.groupBox5.Controls.Add(this.textBox9);
            this.groupBox5.Controls.Add(this.textBox10);
            this.groupBox5.Controls.Add(this.label21);
            this.groupBox5.Controls.Add(this.label22);
            this.groupBox5.Controls.Add(this.button19);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox5.Location = new System.Drawing.Point(154, 39);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(195, 105);
            this.groupBox5.TabIndex = 21;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Rejestr";
            // 
            // button17
            // 
            this.button17.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button17.Location = new System.Drawing.Point(107, 54);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(66, 23);
            this.button17.TabIndex = 20;
            this.button17.Text = "Wczytaj";
            this.button17.UseVisualStyleBackColor = true;
            // 
            // button18
            // 
            this.button18.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button18.Location = new System.Drawing.Point(30, 54);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(66, 23);
            this.button18.TabIndex = 19;
            this.button18.Text = "Ustaw";
            this.button18.UseVisualStyleBackColor = true;
            // 
            // textBox9
            // 
            this.textBox9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBox9.Location = new System.Drawing.Point(107, 28);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(66, 20);
            this.textBox9.TabIndex = 18;
            // 
            // textBox10
            // 
            this.textBox10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBox10.Location = new System.Drawing.Point(30, 28);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(66, 20);
            this.textBox10.TabIndex = 17;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label21.Location = new System.Drawing.Point(117, 10);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(54, 15);
            this.label21.TabIndex = 16;
            this.label21.Text = "Wartość:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label22.Location = new System.Drawing.Point(43, 10);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(41, 15);
            this.label22.TabIndex = 15;
            this.label22.Text = "Adres:";
            // 
            // button19
            // 
            this.button19.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button19.Location = new System.Drawing.Point(30, 79);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(143, 23);
            this.button19.TabIndex = 14;
            this.button19.Text = "Otwórz rejestr";
            this.button19.UseVisualStyleBackColor = true;
            // 
            // button20
            // 
            this.button20.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button20.ForeColor = System.Drawing.Color.LimeGreen;
            this.button20.Location = new System.Drawing.Point(249, 15);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(100, 23);
            this.button20.TabIndex = 22;
            this.button20.Text = "Rysuj wykres";
            this.button20.UseVisualStyleBackColor = true;
            // 
            // comboBox7
            // 
            this.comboBox7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Location = new System.Drawing.Point(9, 77);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(121, 21);
            this.comboBox7.TabIndex = 20;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBox4.Location = new System.Drawing.Point(9, 37);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(78, 19);
            this.checkBox4.TabIndex = 19;
            this.checkBox4.Text = "Włączony";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label23.Location = new System.Drawing.Point(6, 19);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(99, 15);
            this.label23.TabIndex = 18;
            this.label23.Text = "Nazwa czujnika: ";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label24.Location = new System.Drawing.Point(6, 59);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(87, 15);
            this.label24.TabIndex = 23;
            this.label24.Text = "Liczba próbek:";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.button21);
            this.groupBox6.Controls.Add(this.button22);
            this.groupBox6.Controls.Add(this.textBox11);
            this.groupBox6.Controls.Add(this.textBox12);
            this.groupBox6.Controls.Add(this.label25);
            this.groupBox6.Controls.Add(this.label26);
            this.groupBox6.Controls.Add(this.button23);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox6.Location = new System.Drawing.Point(154, 39);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(195, 105);
            this.groupBox6.TabIndex = 21;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Rejestr";
            // 
            // button21
            // 
            this.button21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button21.Location = new System.Drawing.Point(107, 54);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(66, 23);
            this.button21.TabIndex = 20;
            this.button21.Text = "Wczytaj";
            this.button21.UseVisualStyleBackColor = true;
            // 
            // button22
            // 
            this.button22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button22.Location = new System.Drawing.Point(30, 54);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(66, 23);
            this.button22.TabIndex = 19;
            this.button22.Text = "Ustaw";
            this.button22.UseVisualStyleBackColor = true;
            // 
            // textBox11
            // 
            this.textBox11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBox11.Location = new System.Drawing.Point(107, 28);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(66, 20);
            this.textBox11.TabIndex = 18;
            // 
            // textBox12
            // 
            this.textBox12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBox12.Location = new System.Drawing.Point(30, 28);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(66, 20);
            this.textBox12.TabIndex = 17;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label25.Location = new System.Drawing.Point(117, 10);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(54, 15);
            this.label25.TabIndex = 16;
            this.label25.Text = "Wartość:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label26.Location = new System.Drawing.Point(43, 10);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(41, 15);
            this.label26.TabIndex = 15;
            this.label26.Text = "Adres:";
            // 
            // button23
            // 
            this.button23.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button23.Location = new System.Drawing.Point(30, 79);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(143, 23);
            this.button23.TabIndex = 14;
            this.button23.Text = "Otwórz rejestr";
            this.button23.UseVisualStyleBackColor = true;
            // 
            // button24
            // 
            this.button24.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button24.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button24.ForeColor = System.Drawing.Color.LimeGreen;
            this.button24.Location = new System.Drawing.Point(249, 15);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(100, 23);
            this.button24.TabIndex = 22;
            this.button24.Text = "Rysuj wykres";
            this.button24.UseVisualStyleBackColor = true;
            // 
            // comboBox9
            // 
            this.comboBox9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox9.FormattingEnabled = true;
            this.comboBox9.Location = new System.Drawing.Point(9, 77);
            this.comboBox9.Name = "comboBox9";
            this.comboBox9.Size = new System.Drawing.Size(121, 21);
            this.comboBox9.TabIndex = 20;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBox5.Location = new System.Drawing.Point(9, 37);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(78, 19);
            this.checkBox5.TabIndex = 19;
            this.checkBox5.Text = "Włączony";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label27.Location = new System.Drawing.Point(6, 19);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(99, 15);
            this.label27.TabIndex = 18;
            this.label27.Text = "Nazwa czujnika: ";
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
            this.gBoxInfo.ResumeLayout(false);
            this.gBoxInfo.PerformLayout();
            this.tabPageCzujniki.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gBoxHigrometr.ResumeLayout(false);
            this.gBoxHigrometr.PerformLayout();
            this.gBoxMagnetometr.ResumeLayout(false);
            this.gBoxMagnetometr.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.gBoxBarometr.ResumeLayout(false);
            this.gBoxBarometr.PerformLayout();
            this.gBoxŻyroskop.ResumeLayout(false);
            this.gBoxŻyroskop.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gBoxTermometr.ResumeLayout(false);
            this.gBoxTermometr.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.gBoxAkcelerometr.ResumeLayout(false);
            this.gBoxAkcelerometr.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
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
        private System.Windows.Forms.GroupBox gBoxHigrometr;
        private System.Windows.Forms.GroupBox gBoxMagnetometr;
        private System.Windows.Forms.GroupBox gBoxBarometr;
        private System.Windows.Forms.GroupBox gBoxŻyroskop;
        private System.Windows.Forms.GroupBox gBoxTermometr;
        private System.Windows.Forms.GroupBox gBoxAkcelerometr;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.ComboBox comboBox8;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chBoxWlaczonyAkc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.ComboBox comboBox9;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.ComboBox comboBox7;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label18;
    }
}

