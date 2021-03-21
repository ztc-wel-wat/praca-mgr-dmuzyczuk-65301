
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
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageGeneral = new System.Windows.Forms.TabPage();
            this.gBoxSensors = new System.Windows.Forms.GroupBox();
            this.cBoxHumidity = new System.Windows.Forms.ComboBox();
            this.cBoxPressure = new System.Windows.Forms.ComboBox();
            this.cBoxThermometer = new System.Windows.Forms.ComboBox();
            this.cBoxMagnetometer = new System.Windows.Forms.ComboBox();
            this.cBoxGyroscope = new System.Windows.Forms.ComboBox();
            this.cBoxAccelerometer = new System.Windows.Forms.ComboBox();
            this.labelHumidity = new System.Windows.Forms.Label();
            this.labelPressure = new System.Windows.Forms.Label();
            this.labelThermometer = new System.Windows.Forms.Label();
            this.labelMagnetometer = new System.Windows.Forms.Label();
            this.labelGyroscope = new System.Windows.Forms.Label();
            this.labelAccelerometer = new System.Windows.Forms.Label();
            this.gBoxConnection = new System.Windows.Forms.GroupBox();
            this.pBoxLogoWEL = new System.Windows.Forms.PictureBox();
            this.progressBarData = new System.Windows.Forms.ProgressBar();
            this.labelExchangeStatus = new System.Windows.Forms.Label();
            this.labelDataExchange = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.progressBarCOM = new System.Windows.Forms.ProgressBar();
            this.labelStatusCOM = new System.Windows.Forms.Label();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.cBoxPorts = new System.Windows.Forms.ComboBox();
            this.labelPortSelection = new System.Windows.Forms.Label();
            this.gBoxInfo = new System.Windows.Forms.GroupBox();
            this.pBoxBoard = new System.Windows.Forms.PictureBox();
            this.labelNoBoards = new System.Windows.Forms.Label();
            this.labelAvailablePorts = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.tabPageSensors = new System.Windows.Forms.TabPage();
            this.gBoxHumidity = new System.Windows.Forms.GroupBox();
            this.higNameLab = new System.Windows.Forms.Label();
            this.labHumName = new System.Windows.Forms.Label();
            this.cBoxHumODR = new System.Windows.Forms.ComboBox();
            this.labHumODR = new System.Windows.Forms.Label();
            this.gBoxHumRegister = new System.Windows.Forms.GroupBox();
            this.buttonHumGet = new System.Windows.Forms.Button();
            this.buttonHumSet = new System.Windows.Forms.Button();
            this.tBoxHumValue = new System.Windows.Forms.TextBox();
            this.tBoxHumAddress = new System.Windows.Forms.TextBox();
            this.labHumValue = new System.Windows.Forms.Label();
            this.labHumAddress = new System.Windows.Forms.Label();
            this.buttonHumOpen = new System.Windows.Forms.Button();
            this.buttonHumDrawPlot = new System.Windows.Forms.Button();
            this.chBoxHumEnabled = new System.Windows.Forms.CheckBox();
            this.gBoxMagnetometer = new System.Windows.Forms.GroupBox();
            this.magNameLab = new System.Windows.Forms.Label();
            this.labMagName = new System.Windows.Forms.Label();
            this.cBoxMagODR = new System.Windows.Forms.ComboBox();
            this.cBoxMagScale = new System.Windows.Forms.ComboBox();
            this.gBoxMagRegister = new System.Windows.Forms.GroupBox();
            this.buttonMagGet = new System.Windows.Forms.Button();
            this.buttonMagSet = new System.Windows.Forms.Button();
            this.tBoxMagValue = new System.Windows.Forms.TextBox();
            this.tBoxMagAddress = new System.Windows.Forms.TextBox();
            this.labMagValue = new System.Windows.Forms.Label();
            this.labMagAddress = new System.Windows.Forms.Label();
            this.buttonMagOpen = new System.Windows.Forms.Button();
            this.buttonMagDrawPlot = new System.Windows.Forms.Button();
            this.labMagODR = new System.Windows.Forms.Label();
            this.labMagScale = new System.Windows.Forms.Label();
            this.chBoxMagEnabled = new System.Windows.Forms.CheckBox();
            this.gBoxPressure = new System.Windows.Forms.GroupBox();
            this.barNameLab = new System.Windows.Forms.Label();
            this.labPreName = new System.Windows.Forms.Label();
            this.cBoxPreODR = new System.Windows.Forms.ComboBox();
            this.labPreODR = new System.Windows.Forms.Label();
            this.gBoxPreRegister = new System.Windows.Forms.GroupBox();
            this.buttonPreGet = new System.Windows.Forms.Button();
            this.buttonPreSet = new System.Windows.Forms.Button();
            this.tBoxPreValue = new System.Windows.Forms.TextBox();
            this.tBoxPreAddress = new System.Windows.Forms.TextBox();
            this.labPreValue = new System.Windows.Forms.Label();
            this.labPreAddress = new System.Windows.Forms.Label();
            this.buttonPreOpen = new System.Windows.Forms.Button();
            this.buttonPreDrawPlot = new System.Windows.Forms.Button();
            this.chBoxPreEnabled = new System.Windows.Forms.CheckBox();
            this.gBoxGyroscope = new System.Windows.Forms.GroupBox();
            this.gyroNameLab = new System.Windows.Forms.Label();
            this.LabGyroName = new System.Windows.Forms.Label();
            this.cBoxGyroODR = new System.Windows.Forms.ComboBox();
            this.cBoxGyroScale = new System.Windows.Forms.ComboBox();
            this.gBoxGyroRegister = new System.Windows.Forms.GroupBox();
            this.buttonGyroGet = new System.Windows.Forms.Button();
            this.buttonGyroSet = new System.Windows.Forms.Button();
            this.tBoxGyroValue = new System.Windows.Forms.TextBox();
            this.tBoxGyroAddress = new System.Windows.Forms.TextBox();
            this.labGyroValue = new System.Windows.Forms.Label();
            this.labGyroAddress = new System.Windows.Forms.Label();
            this.buttonGyroOpen = new System.Windows.Forms.Button();
            this.buttonGyroDrawPlot = new System.Windows.Forms.Button();
            this.labGyroODR = new System.Windows.Forms.Label();
            this.labGyroScale = new System.Windows.Forms.Label();
            this.chBoxGyroEnabled = new System.Windows.Forms.CheckBox();
            this.gBoxTermometer = new System.Windows.Forms.GroupBox();
            this.terNameLab = new System.Windows.Forms.Label();
            this.labTermName = new System.Windows.Forms.Label();
            this.cBoxTermODR = new System.Windows.Forms.ComboBox();
            this.labTermODR = new System.Windows.Forms.Label();
            this.gBoxTermRegister = new System.Windows.Forms.GroupBox();
            this.buttonTermGet = new System.Windows.Forms.Button();
            this.buttonTermSet = new System.Windows.Forms.Button();
            this.tBoxTermValue = new System.Windows.Forms.TextBox();
            this.tBoxTermAddress = new System.Windows.Forms.TextBox();
            this.labTermValue = new System.Windows.Forms.Label();
            this.labTermAddress = new System.Windows.Forms.Label();
            this.buttonTermOpen = new System.Windows.Forms.Button();
            this.buttonTermDrawPlot = new System.Windows.Forms.Button();
            this.chBoxTermEnabled = new System.Windows.Forms.CheckBox();
            this.gBoxAccelerometer = new System.Windows.Forms.GroupBox();
            this.accNameLab = new System.Windows.Forms.Label();
            this.labAccName = new System.Windows.Forms.Label();
            this.cBoxAccODR = new System.Windows.Forms.ComboBox();
            this.cBoxAccScale = new System.Windows.Forms.ComboBox();
            this.gBoxAccRegister = new System.Windows.Forms.GroupBox();
            this.buttonAccGet = new System.Windows.Forms.Button();
            this.buttonAccSet = new System.Windows.Forms.Button();
            this.tBoxAccValue = new System.Windows.Forms.TextBox();
            this.tBoxAccAdsress = new System.Windows.Forms.TextBox();
            this.labAccValue = new System.Windows.Forms.Label();
            this.labAccAddress = new System.Windows.Forms.Label();
            this.buttonAccOpen = new System.Windows.Forms.Button();
            this.buttonAccDrawPlot = new System.Windows.Forms.Button();
            this.labAccODR = new System.Windows.Forms.Label();
            this.labAccScale = new System.Windows.Forms.Label();
            this.chBoxAccEnabled = new System.Windows.Forms.CheckBox();
            this.tabPageData = new System.Windows.Forms.TabPage();
            this.rTBoxData = new System.Windows.Forms.RichTextBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edytujToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.portOpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EnableAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DisableAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.włączWyłączPrzerwaniaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomocToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.oProgramieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.bgWorkerOtworz = new System.ComponentModel.BackgroundWorker();
            this.tabControlMain.SuspendLayout();
            this.tabPageGeneral.SuspendLayout();
            this.gBoxSensors.SuspendLayout();
            this.gBoxConnection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxLogoWEL)).BeginInit();
            this.gBoxInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxBoard)).BeginInit();
            this.tabPageSensors.SuspendLayout();
            this.gBoxHumidity.SuspendLayout();
            this.gBoxHumRegister.SuspendLayout();
            this.gBoxMagnetometer.SuspendLayout();
            this.gBoxMagRegister.SuspendLayout();
            this.gBoxPressure.SuspendLayout();
            this.gBoxPreRegister.SuspendLayout();
            this.gBoxGyroscope.SuspendLayout();
            this.gBoxGyroRegister.SuspendLayout();
            this.gBoxTermometer.SuspendLayout();
            this.gBoxTermRegister.SuspendLayout();
            this.gBoxAccelerometer.SuspendLayout();
            this.gBoxAccRegister.SuspendLayout();
            this.tabPageData.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageGeneral);
            this.tabControlMain.Controls.Add(this.tabPageSensors);
            this.tabControlMain.Controls.Add(this.tabPageData);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 24);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(742, 500);
            this.tabControlMain.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControlMain.TabIndex = 0;
            // 
            // tabPageGeneral
            // 
            this.tabPageGeneral.Controls.Add(this.gBoxSensors);
            this.tabPageGeneral.Controls.Add(this.gBoxConnection);
            this.tabPageGeneral.Controls.Add(this.gBoxInfo);
            this.tabPageGeneral.Location = new System.Drawing.Point(4, 22);
            this.tabPageGeneral.Name = "tabPageGeneral";
            this.tabPageGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGeneral.Size = new System.Drawing.Size(734, 474);
            this.tabPageGeneral.TabIndex = 0;
            this.tabPageGeneral.Text = "Ogólne";
            this.tabPageGeneral.UseVisualStyleBackColor = true;
            // 
            // gBoxSensors
            // 
            this.gBoxSensors.Controls.Add(this.cBoxHumidity);
            this.gBoxSensors.Controls.Add(this.cBoxPressure);
            this.gBoxSensors.Controls.Add(this.cBoxThermometer);
            this.gBoxSensors.Controls.Add(this.cBoxMagnetometer);
            this.gBoxSensors.Controls.Add(this.cBoxGyroscope);
            this.gBoxSensors.Controls.Add(this.cBoxAccelerometer);
            this.gBoxSensors.Controls.Add(this.labelHumidity);
            this.gBoxSensors.Controls.Add(this.labelPressure);
            this.gBoxSensors.Controls.Add(this.labelThermometer);
            this.gBoxSensors.Controls.Add(this.labelMagnetometer);
            this.gBoxSensors.Controls.Add(this.labelGyroscope);
            this.gBoxSensors.Controls.Add(this.labelAccelerometer);
            this.gBoxSensors.Dock = System.Windows.Forms.DockStyle.Top;
            this.gBoxSensors.Location = new System.Drawing.Point(3, 307);
            this.gBoxSensors.Name = "gBoxSensors";
            this.gBoxSensors.Size = new System.Drawing.Size(728, 144);
            this.gBoxSensors.TabIndex = 2;
            this.gBoxSensors.TabStop = false;
            this.gBoxSensors.Text = "Czujniki";
            // 
            // cBoxHumidity
            // 
            this.cBoxHumidity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cBoxHumidity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxHumidity.Enabled = false;
            this.cBoxHumidity.FormattingEnabled = true;
            this.cBoxHumidity.Location = new System.Drawing.Point(524, 101);
            this.cBoxHumidity.Name = "cBoxHumidity";
            this.cBoxHumidity.Size = new System.Drawing.Size(140, 21);
            this.cBoxHumidity.TabIndex = 11;
            // 
            // cBoxPressure
            // 
            this.cBoxPressure.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cBoxPressure.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxPressure.Enabled = false;
            this.cBoxPressure.FormattingEnabled = true;
            this.cBoxPressure.Location = new System.Drawing.Point(524, 66);
            this.cBoxPressure.Name = "cBoxPressure";
            this.cBoxPressure.Size = new System.Drawing.Size(140, 21);
            this.cBoxPressure.TabIndex = 10;
            // 
            // cBoxThermometer
            // 
            this.cBoxThermometer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cBoxThermometer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxThermometer.Enabled = false;
            this.cBoxThermometer.FormattingEnabled = true;
            this.cBoxThermometer.Location = new System.Drawing.Point(524, 31);
            this.cBoxThermometer.Name = "cBoxThermometer";
            this.cBoxThermometer.Size = new System.Drawing.Size(140, 21);
            this.cBoxThermometer.TabIndex = 9;
            // 
            // cBoxMagnetometer
            // 
            this.cBoxMagnetometer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cBoxMagnetometer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxMagnetometer.Enabled = false;
            this.cBoxMagnetometer.FormattingEnabled = true;
            this.cBoxMagnetometer.Location = new System.Drawing.Point(172, 101);
            this.cBoxMagnetometer.Name = "cBoxMagnetometer";
            this.cBoxMagnetometer.Size = new System.Drawing.Size(140, 21);
            this.cBoxMagnetometer.TabIndex = 8;
            // 
            // cBoxGyroscope
            // 
            this.cBoxGyroscope.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cBoxGyroscope.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxGyroscope.Enabled = false;
            this.cBoxGyroscope.FormattingEnabled = true;
            this.cBoxGyroscope.Location = new System.Drawing.Point(172, 66);
            this.cBoxGyroscope.Name = "cBoxGyroscope";
            this.cBoxGyroscope.Size = new System.Drawing.Size(140, 21);
            this.cBoxGyroscope.TabIndex = 7;
            // 
            // cBoxAccelerometer
            // 
            this.cBoxAccelerometer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cBoxAccelerometer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxAccelerometer.Enabled = false;
            this.cBoxAccelerometer.Location = new System.Drawing.Point(172, 31);
            this.cBoxAccelerometer.Name = "cBoxAccelerometer";
            this.cBoxAccelerometer.Size = new System.Drawing.Size(140, 21);
            this.cBoxAccelerometer.TabIndex = 6;
            // 
            // labelHumidity
            // 
            this.labelHumidity.AutoSize = true;
            this.labelHumidity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelHumidity.Location = new System.Drawing.Point(393, 102);
            this.labelHumidity.Name = "labelHumidity";
            this.labelHumidity.Size = new System.Drawing.Size(74, 17);
            this.labelHumidity.TabIndex = 5;
            this.labelHumidity.Text = "Higrometr:";
            // 
            // labelPressure
            // 
            this.labelPressure.AutoSize = true;
            this.labelPressure.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPressure.Location = new System.Drawing.Point(393, 67);
            this.labelPressure.Name = "labelPressure";
            this.labelPressure.Size = new System.Drawing.Size(70, 17);
            this.labelPressure.TabIndex = 4;
            this.labelPressure.Text = "Barometr:";
            // 
            // labelThermometer
            // 
            this.labelThermometer.AutoSize = true;
            this.labelThermometer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelThermometer.Location = new System.Drawing.Point(393, 32);
            this.labelThermometer.Name = "labelThermometer";
            this.labelThermometer.Size = new System.Drawing.Size(81, 17);
            this.labelThermometer.TabIndex = 3;
            this.labelThermometer.Text = "Termometr:";
            // 
            // labelMagnetometer
            // 
            this.labelMagnetometer.AutoSize = true;
            this.labelMagnetometer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMagnetometer.Location = new System.Drawing.Point(20, 102);
            this.labelMagnetometer.Name = "labelMagnetometer";
            this.labelMagnetometer.Size = new System.Drawing.Size(95, 17);
            this.labelMagnetometer.TabIndex = 2;
            this.labelMagnetometer.Text = "Magnetometr:";
            // 
            // labelGyroscope
            // 
            this.labelGyroscope.AutoSize = true;
            this.labelGyroscope.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelGyroscope.Location = new System.Drawing.Point(20, 67);
            this.labelGyroscope.Name = "labelGyroscope";
            this.labelGyroscope.Size = new System.Drawing.Size(71, 17);
            this.labelGyroscope.TabIndex = 1;
            this.labelGyroscope.Text = "Żyroskop:";
            // 
            // labelAccelerometer
            // 
            this.labelAccelerometer.AutoSize = true;
            this.labelAccelerometer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelAccelerometer.Location = new System.Drawing.Point(20, 32);
            this.labelAccelerometer.Name = "labelAccelerometer";
            this.labelAccelerometer.Size = new System.Drawing.Size(95, 17);
            this.labelAccelerometer.TabIndex = 0;
            this.labelAccelerometer.Text = "Akcelerometr:";
            // 
            // gBoxConnection
            // 
            this.gBoxConnection.Controls.Add(this.pBoxLogoWEL);
            this.gBoxConnection.Controls.Add(this.progressBarData);
            this.gBoxConnection.Controls.Add(this.labelExchangeStatus);
            this.gBoxConnection.Controls.Add(this.labelDataExchange);
            this.gBoxConnection.Controls.Add(this.buttonStart);
            this.gBoxConnection.Controls.Add(this.buttonStop);
            this.gBoxConnection.Controls.Add(this.progressBarCOM);
            this.gBoxConnection.Controls.Add(this.labelStatusCOM);
            this.gBoxConnection.Controls.Add(this.buttonOpen);
            this.gBoxConnection.Controls.Add(this.buttonClose);
            this.gBoxConnection.Controls.Add(this.cBoxPorts);
            this.gBoxConnection.Controls.Add(this.labelPortSelection);
            this.gBoxConnection.Dock = System.Windows.Forms.DockStyle.Top;
            this.gBoxConnection.Location = new System.Drawing.Point(3, 163);
            this.gBoxConnection.Name = "gBoxConnection";
            this.gBoxConnection.Size = new System.Drawing.Size(728, 144);
            this.gBoxConnection.TabIndex = 1;
            this.gBoxConnection.TabStop = false;
            this.gBoxConnection.Text = "Połączenie";
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
            // progressBarData
            // 
            this.progressBarData.Location = new System.Drawing.Point(435, 104);
            this.progressBarData.Name = "progressBarData";
            this.progressBarData.Size = new System.Drawing.Size(266, 23);
            this.progressBarData.TabIndex = 10;
            // 
            // labelExchangeStatus
            // 
            this.labelExchangeStatus.AutoSize = true;
            this.labelExchangeStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelExchangeStatus.Location = new System.Drawing.Point(432, 81);
            this.labelExchangeStatus.Name = "labelExchangeStatus";
            this.labelExchangeStatus.Size = new System.Drawing.Size(173, 17);
            this.labelExchangeStatus.TabIndex = 9;
            this.labelExchangeStatus.Text = "Status pobierania danych:";
            // 
            // labelDataExchange
            // 
            this.labelDataExchange.AutoSize = true;
            this.labelDataExchange.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDataExchange.Location = new System.Drawing.Point(503, 28);
            this.labelDataExchange.Name = "labelDataExchange";
            this.labelDataExchange.Size = new System.Drawing.Size(130, 17);
            this.labelDataExchange.TabIndex = 8;
            this.labelDataExchange.Text = "Pobieranie danych:";
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
            // buttonOpen
            // 
            this.buttonOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOpen.Location = new System.Drawing.Point(31, 55);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(130, 23);
            this.buttonOpen.TabIndex = 3;
            this.buttonOpen.Text = "Otwórz";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOtworz_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClose.Enabled = false;
            this.buttonClose.ForeColor = System.Drawing.Color.Red;
            this.buttonClose.Location = new System.Drawing.Point(167, 55);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(130, 23);
            this.buttonClose.TabIndex = 2;
            this.buttonClose.Text = "Zamknij";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonZamknij_Click);
            // 
            // cBoxPorts
            // 
            this.cBoxPorts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cBoxPorts.FormattingEnabled = true;
            this.cBoxPorts.Location = new System.Drawing.Point(208, 28);
            this.cBoxPorts.Name = "cBoxPorts";
            this.cBoxPorts.Size = new System.Drawing.Size(89, 21);
            this.cBoxPorts.TabIndex = 1;
            // 
            // labelPortSelection
            // 
            this.labelPortSelection.AutoSize = true;
            this.labelPortSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPortSelection.Location = new System.Drawing.Point(28, 29);
            this.labelPortSelection.Name = "labelPortSelection";
            this.labelPortSelection.Size = new System.Drawing.Size(127, 17);
            this.labelPortSelection.TabIndex = 0;
            this.labelPortSelection.Text = "Wybierz port COM:";
            // 
            // gBoxInfo
            // 
            this.gBoxInfo.Controls.Add(this.pBoxBoard);
            this.gBoxInfo.Controls.Add(this.labelNoBoards);
            this.gBoxInfo.Controls.Add(this.labelAvailablePorts);
            this.gBoxInfo.Controls.Add(this.labelVersion);
            this.gBoxInfo.Controls.Add(this.labelTitle);
            this.gBoxInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.gBoxInfo.Location = new System.Drawing.Point(3, 3);
            this.gBoxInfo.Name = "gBoxInfo";
            this.gBoxInfo.Size = new System.Drawing.Size(728, 160);
            this.gBoxInfo.TabIndex = 0;
            this.gBoxInfo.TabStop = false;
            this.gBoxInfo.Text = "Informacje";
            // 
            // pBoxBoard
            // 
            this.pBoxBoard.Image = global::Aplikacja_MEMS.Properties.Resources.Plytka;
            this.pBoxBoard.InitialImage = global::Aplikacja_MEMS.Properties.Resources.Plytka;
            this.pBoxBoard.Location = new System.Drawing.Point(538, 10);
            this.pBoxBoard.Name = "pBoxBoard";
            this.pBoxBoard.Size = new System.Drawing.Size(185, 144);
            this.pBoxBoard.TabIndex = 4;
            this.pBoxBoard.TabStop = false;
            // 
            // labelNoBoards
            // 
            this.labelNoBoards.AutoSize = true;
            this.labelNoBoards.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNoBoards.ForeColor = System.Drawing.Color.Red;
            this.labelNoBoards.Location = new System.Drawing.Point(20, 85);
            this.labelNoBoards.Name = "labelNoBoards";
            this.labelNoBoards.Size = new System.Drawing.Size(158, 17);
            this.labelNoBoards.TabIndex = 3;
            this.labelNoBoards.Text = "Brak dostępnych płytek!";
            // 
            // labelAvailablePorts
            // 
            this.labelAvailablePorts.AutoSize = true;
            this.labelAvailablePorts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelAvailablePorts.Location = new System.Drawing.Point(6, 66);
            this.labelAvailablePorts.Name = "labelAvailablePorts";
            this.labelAvailablePorts.Size = new System.Drawing.Size(109, 17);
            this.labelAvailablePorts.TabIndex = 2;
            this.labelAvailablePorts.Text = "Dostępne płytki:";
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelVersion.Location = new System.Drawing.Point(6, 49);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(146, 17);
            this.labelVersion.TabIndex = 1;
            this.labelVersion.Text = "Wersja aplikacji: 1.0.0";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTitle.Location = new System.Drawing.Point(196, 16);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(296, 24);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Aplikacja MEMS czujnika IKS01A2";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPageSensors
            // 
            this.tabPageSensors.CausesValidation = false;
            this.tabPageSensors.Controls.Add(this.gBoxHumidity);
            this.tabPageSensors.Controls.Add(this.gBoxMagnetometer);
            this.tabPageSensors.Controls.Add(this.gBoxPressure);
            this.tabPageSensors.Controls.Add(this.gBoxGyroscope);
            this.tabPageSensors.Controls.Add(this.gBoxTermometer);
            this.tabPageSensors.Controls.Add(this.gBoxAccelerometer);
            this.tabPageSensors.Location = new System.Drawing.Point(4, 22);
            this.tabPageSensors.Name = "tabPageSensors";
            this.tabPageSensors.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSensors.Size = new System.Drawing.Size(734, 474);
            this.tabPageSensors.TabIndex = 1;
            this.tabPageSensors.Text = "Czujniki MEMS";
            this.tabPageSensors.UseVisualStyleBackColor = true;
            // 
            // gBoxHumidity
            // 
            this.gBoxHumidity.Controls.Add(this.higNameLab);
            this.gBoxHumidity.Controls.Add(this.labHumName);
            this.gBoxHumidity.Controls.Add(this.cBoxHumODR);
            this.gBoxHumidity.Controls.Add(this.labHumODR);
            this.gBoxHumidity.Controls.Add(this.gBoxHumRegister);
            this.gBoxHumidity.Controls.Add(this.buttonHumDrawPlot);
            this.gBoxHumidity.Controls.Add(this.chBoxHumEnabled);
            this.gBoxHumidity.Enabled = false;
            this.gBoxHumidity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gBoxHumidity.Location = new System.Drawing.Point(369, 318);
            this.gBoxHumidity.Name = "gBoxHumidity";
            this.gBoxHumidity.Size = new System.Drawing.Size(355, 150);
            this.gBoxHumidity.TabIndex = 4;
            this.gBoxHumidity.TabStop = false;
            this.gBoxHumidity.Text = "Higrometr";
            // 
            // higNameLab
            // 
            this.higNameLab.AutoSize = true;
            this.higNameLab.Location = new System.Drawing.Point(100, 19);
            this.higNameLab.Name = "higNameLab";
            this.higNameLab.Size = new System.Drawing.Size(16, 17);
            this.higNameLab.TabIndex = 24;
            this.higNameLab.Text = "?";
            // 
            // labHumName
            // 
            this.labHumName.AutoSize = true;
            this.labHumName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labHumName.Location = new System.Drawing.Point(6, 19);
            this.labHumName.Name = "labHumName";
            this.labHumName.Size = new System.Drawing.Size(99, 15);
            this.labHumName.TabIndex = 18;
            this.labHumName.Text = "Nazwa czujnika: ";
            // 
            // cBoxHumODR
            // 
            this.cBoxHumODR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cBoxHumODR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxHumODR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cBoxHumODR.FormattingEnabled = true;
            this.cBoxHumODR.Items.AddRange(new object[] {
            "1",
            "7",
            "12,5"});
            this.cBoxHumODR.Location = new System.Drawing.Point(9, 77);
            this.cBoxHumODR.Name = "cBoxHumODR";
            this.cBoxHumODR.Size = new System.Drawing.Size(121, 21);
            this.cBoxHumODR.TabIndex = 20;
            this.cBoxHumODR.SelectedIndexChanged += new System.EventHandler(this.cBoxHigODR_SelectedIndexChanged);
            // 
            // labHumODR
            // 
            this.labHumODR.AutoSize = true;
            this.labHumODR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labHumODR.Location = new System.Drawing.Point(6, 59);
            this.labHumODR.Name = "labHumODR";
            this.labHumODR.Size = new System.Drawing.Size(37, 15);
            this.labHumODR.TabIndex = 23;
            this.labHumODR.Text = "ODR:";
            // 
            // gBoxHumRegister
            // 
            this.gBoxHumRegister.Controls.Add(this.buttonHumGet);
            this.gBoxHumRegister.Controls.Add(this.buttonHumSet);
            this.gBoxHumRegister.Controls.Add(this.tBoxHumValue);
            this.gBoxHumRegister.Controls.Add(this.tBoxHumAddress);
            this.gBoxHumRegister.Controls.Add(this.labHumValue);
            this.gBoxHumRegister.Controls.Add(this.labHumAddress);
            this.gBoxHumRegister.Controls.Add(this.buttonHumOpen);
            this.gBoxHumRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gBoxHumRegister.Location = new System.Drawing.Point(154, 39);
            this.gBoxHumRegister.Name = "gBoxHumRegister";
            this.gBoxHumRegister.Size = new System.Drawing.Size(195, 105);
            this.gBoxHumRegister.TabIndex = 21;
            this.gBoxHumRegister.TabStop = false;
            this.gBoxHumRegister.Text = "Rejestr";
            // 
            // buttonHumGet
            // 
            this.buttonHumGet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHumGet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonHumGet.Location = new System.Drawing.Point(107, 54);
            this.buttonHumGet.Name = "buttonHumGet";
            this.buttonHumGet.Size = new System.Drawing.Size(66, 23);
            this.buttonHumGet.TabIndex = 20;
            this.buttonHumGet.Text = "Wczytaj";
            this.buttonHumGet.UseVisualStyleBackColor = true;
            // 
            // buttonHumSet
            // 
            this.buttonHumSet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHumSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonHumSet.Location = new System.Drawing.Point(30, 54);
            this.buttonHumSet.Name = "buttonHumSet";
            this.buttonHumSet.Size = new System.Drawing.Size(66, 23);
            this.buttonHumSet.TabIndex = 19;
            this.buttonHumSet.Text = "Ustaw";
            this.buttonHumSet.UseVisualStyleBackColor = true;
            // 
            // tBoxHumValue
            // 
            this.tBoxHumValue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tBoxHumValue.Location = new System.Drawing.Point(107, 28);
            this.tBoxHumValue.Name = "tBoxHumValue";
            this.tBoxHumValue.Size = new System.Drawing.Size(66, 20);
            this.tBoxHumValue.TabIndex = 18;
            // 
            // tBoxHumAddress
            // 
            this.tBoxHumAddress.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tBoxHumAddress.Location = new System.Drawing.Point(30, 28);
            this.tBoxHumAddress.Name = "tBoxHumAddress";
            this.tBoxHumAddress.Size = new System.Drawing.Size(66, 20);
            this.tBoxHumAddress.TabIndex = 17;
            // 
            // labHumValue
            // 
            this.labHumValue.AutoSize = true;
            this.labHumValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labHumValue.Location = new System.Drawing.Point(117, 10);
            this.labHumValue.Name = "labHumValue";
            this.labHumValue.Size = new System.Drawing.Size(54, 15);
            this.labHumValue.TabIndex = 16;
            this.labHumValue.Text = "Wartość:";
            // 
            // labHumAddress
            // 
            this.labHumAddress.AutoSize = true;
            this.labHumAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labHumAddress.Location = new System.Drawing.Point(43, 10);
            this.labHumAddress.Name = "labHumAddress";
            this.labHumAddress.Size = new System.Drawing.Size(41, 15);
            this.labHumAddress.TabIndex = 15;
            this.labHumAddress.Text = "Adres:";
            // 
            // buttonHumOpen
            // 
            this.buttonHumOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHumOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonHumOpen.Location = new System.Drawing.Point(30, 79);
            this.buttonHumOpen.Name = "buttonHumOpen";
            this.buttonHumOpen.Size = new System.Drawing.Size(143, 23);
            this.buttonHumOpen.TabIndex = 14;
            this.buttonHumOpen.Text = "Otwórz rejestr";
            this.buttonHumOpen.UseVisualStyleBackColor = true;
            // 
            // buttonHumDrawPlot
            // 
            this.buttonHumDrawPlot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHumDrawPlot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHumDrawPlot.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonHumDrawPlot.ForeColor = System.Drawing.Color.LimeGreen;
            this.buttonHumDrawPlot.Location = new System.Drawing.Point(249, 15);
            this.buttonHumDrawPlot.Name = "buttonHumDrawPlot";
            this.buttonHumDrawPlot.Size = new System.Drawing.Size(100, 23);
            this.buttonHumDrawPlot.TabIndex = 22;
            this.buttonHumDrawPlot.Text = "Rysuj wykres";
            this.buttonHumDrawPlot.UseVisualStyleBackColor = true;
            // 
            // chBoxHumEnabled
            // 
            this.chBoxHumEnabled.AutoSize = true;
            this.chBoxHumEnabled.Checked = true;
            this.chBoxHumEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chBoxHumEnabled.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chBoxHumEnabled.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chBoxHumEnabled.Location = new System.Drawing.Point(9, 37);
            this.chBoxHumEnabled.Name = "chBoxHumEnabled";
            this.chBoxHumEnabled.Size = new System.Drawing.Size(78, 19);
            this.chBoxHumEnabled.TabIndex = 19;
            this.chBoxHumEnabled.Text = "Włączony";
            this.chBoxHumEnabled.UseVisualStyleBackColor = true;
            this.chBoxHumEnabled.Click += new System.EventHandler(this.chBoxHumEnabled_Click);
            // 
            // gBoxMagnetometer
            // 
            this.gBoxMagnetometer.Controls.Add(this.magNameLab);
            this.gBoxMagnetometer.Controls.Add(this.labMagName);
            this.gBoxMagnetometer.Controls.Add(this.cBoxMagODR);
            this.gBoxMagnetometer.Controls.Add(this.cBoxMagScale);
            this.gBoxMagnetometer.Controls.Add(this.gBoxMagRegister);
            this.gBoxMagnetometer.Controls.Add(this.buttonMagDrawPlot);
            this.gBoxMagnetometer.Controls.Add(this.labMagODR);
            this.gBoxMagnetometer.Controls.Add(this.labMagScale);
            this.gBoxMagnetometer.Controls.Add(this.chBoxMagEnabled);
            this.gBoxMagnetometer.Enabled = false;
            this.gBoxMagnetometer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gBoxMagnetometer.Location = new System.Drawing.Point(8, 318);
            this.gBoxMagnetometer.Name = "gBoxMagnetometer";
            this.gBoxMagnetometer.Size = new System.Drawing.Size(355, 150);
            this.gBoxMagnetometer.TabIndex = 1;
            this.gBoxMagnetometer.TabStop = false;
            this.gBoxMagnetometer.Text = "Magnetometr";
            // 
            // magNameLab
            // 
            this.magNameLab.AutoSize = true;
            this.magNameLab.Location = new System.Drawing.Point(100, 19);
            this.magNameLab.Name = "magNameLab";
            this.magNameLab.Size = new System.Drawing.Size(16, 17);
            this.magNameLab.TabIndex = 17;
            this.magNameLab.Text = "?";
            // 
            // labMagName
            // 
            this.labMagName.AutoSize = true;
            this.labMagName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labMagName.Location = new System.Drawing.Point(6, 19);
            this.labMagName.Name = "labMagName";
            this.labMagName.Size = new System.Drawing.Size(99, 15);
            this.labMagName.TabIndex = 9;
            this.labMagName.Text = "Nazwa czujnika: ";
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
            this.cBoxMagODR.SelectedIndexChanged += new System.EventHandler(this.cBoxMagODR_SelectedIndexChanged);
            // 
            // cBoxMagScale
            // 
            this.cBoxMagScale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cBoxMagScale.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxMagScale.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cBoxMagScale.FormattingEnabled = true;
            this.cBoxMagScale.Items.AddRange(new object[] {
            "50"});
            this.cBoxMagScale.Location = new System.Drawing.Point(9, 77);
            this.cBoxMagScale.Name = "cBoxMagScale";
            this.cBoxMagScale.Size = new System.Drawing.Size(121, 21);
            this.cBoxMagScale.TabIndex = 12;
            this.cBoxMagScale.SelectedIndexChanged += new System.EventHandler(this.cBoxMagScale_SelectedIndexChanged);
            // 
            // gBoxMagRegister
            // 
            this.gBoxMagRegister.Controls.Add(this.buttonMagGet);
            this.gBoxMagRegister.Controls.Add(this.buttonMagSet);
            this.gBoxMagRegister.Controls.Add(this.tBoxMagValue);
            this.gBoxMagRegister.Controls.Add(this.tBoxMagAddress);
            this.gBoxMagRegister.Controls.Add(this.labMagValue);
            this.gBoxMagRegister.Controls.Add(this.labMagAddress);
            this.gBoxMagRegister.Controls.Add(this.buttonMagOpen);
            this.gBoxMagRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gBoxMagRegister.Location = new System.Drawing.Point(154, 39);
            this.gBoxMagRegister.Name = "gBoxMagRegister";
            this.gBoxMagRegister.Size = new System.Drawing.Size(195, 105);
            this.gBoxMagRegister.TabIndex = 15;
            this.gBoxMagRegister.TabStop = false;
            this.gBoxMagRegister.Text = "Rejestr";
            // 
            // buttonMagGet
            // 
            this.buttonMagGet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMagGet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonMagGet.Location = new System.Drawing.Point(107, 54);
            this.buttonMagGet.Name = "buttonMagGet";
            this.buttonMagGet.Size = new System.Drawing.Size(66, 23);
            this.buttonMagGet.TabIndex = 20;
            this.buttonMagGet.Text = "Wczytaj";
            this.buttonMagGet.UseVisualStyleBackColor = true;
            // 
            // buttonMagSet
            // 
            this.buttonMagSet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMagSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonMagSet.Location = new System.Drawing.Point(30, 54);
            this.buttonMagSet.Name = "buttonMagSet";
            this.buttonMagSet.Size = new System.Drawing.Size(66, 23);
            this.buttonMagSet.TabIndex = 19;
            this.buttonMagSet.Text = "Ustaw";
            this.buttonMagSet.UseVisualStyleBackColor = true;
            // 
            // tBoxMagValue
            // 
            this.tBoxMagValue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tBoxMagValue.Location = new System.Drawing.Point(107, 28);
            this.tBoxMagValue.Name = "tBoxMagValue";
            this.tBoxMagValue.Size = new System.Drawing.Size(66, 20);
            this.tBoxMagValue.TabIndex = 18;
            // 
            // tBoxMagAddress
            // 
            this.tBoxMagAddress.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tBoxMagAddress.Location = new System.Drawing.Point(30, 28);
            this.tBoxMagAddress.Name = "tBoxMagAddress";
            this.tBoxMagAddress.Size = new System.Drawing.Size(66, 20);
            this.tBoxMagAddress.TabIndex = 17;
            // 
            // labMagValue
            // 
            this.labMagValue.AutoSize = true;
            this.labMagValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labMagValue.Location = new System.Drawing.Point(117, 10);
            this.labMagValue.Name = "labMagValue";
            this.labMagValue.Size = new System.Drawing.Size(54, 15);
            this.labMagValue.TabIndex = 16;
            this.labMagValue.Text = "Wartość:";
            // 
            // labMagAddress
            // 
            this.labMagAddress.AutoSize = true;
            this.labMagAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labMagAddress.Location = new System.Drawing.Point(43, 10);
            this.labMagAddress.Name = "labMagAddress";
            this.labMagAddress.Size = new System.Drawing.Size(41, 15);
            this.labMagAddress.TabIndex = 15;
            this.labMagAddress.Text = "Adres:";
            // 
            // buttonMagOpen
            // 
            this.buttonMagOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMagOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonMagOpen.Location = new System.Drawing.Point(30, 79);
            this.buttonMagOpen.Name = "buttonMagOpen";
            this.buttonMagOpen.Size = new System.Drawing.Size(143, 23);
            this.buttonMagOpen.TabIndex = 14;
            this.buttonMagOpen.Text = "Otwórz rejestr";
            this.buttonMagOpen.UseVisualStyleBackColor = true;
            // 
            // buttonMagDrawPlot
            // 
            this.buttonMagDrawPlot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMagDrawPlot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMagDrawPlot.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonMagDrawPlot.ForeColor = System.Drawing.Color.LimeGreen;
            this.buttonMagDrawPlot.Location = new System.Drawing.Point(249, 15);
            this.buttonMagDrawPlot.Name = "buttonMagDrawPlot";
            this.buttonMagDrawPlot.Size = new System.Drawing.Size(100, 23);
            this.buttonMagDrawPlot.TabIndex = 16;
            this.buttonMagDrawPlot.Text = "Rysuj wykres";
            this.buttonMagDrawPlot.UseVisualStyleBackColor = true;
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
            // labMagScale
            // 
            this.labMagScale.AutoSize = true;
            this.labMagScale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labMagScale.Location = new System.Drawing.Point(6, 59);
            this.labMagScale.Name = "labMagScale";
            this.labMagScale.Size = new System.Drawing.Size(47, 15);
            this.labMagScale.TabIndex = 11;
            this.labMagScale.Text = "Zakres:";
            // 
            // chBoxMagEnabled
            // 
            this.chBoxMagEnabled.AutoSize = true;
            this.chBoxMagEnabled.Checked = true;
            this.chBoxMagEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chBoxMagEnabled.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chBoxMagEnabled.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chBoxMagEnabled.Location = new System.Drawing.Point(9, 37);
            this.chBoxMagEnabled.Name = "chBoxMagEnabled";
            this.chBoxMagEnabled.Size = new System.Drawing.Size(78, 19);
            this.chBoxMagEnabled.TabIndex = 10;
            this.chBoxMagEnabled.Text = "Włączony";
            this.chBoxMagEnabled.UseVisualStyleBackColor = true;
            this.chBoxMagEnabled.Click += new System.EventHandler(this.chBoxMagEnabled_Click);
            // 
            // gBoxPressure
            // 
            this.gBoxPressure.Controls.Add(this.barNameLab);
            this.gBoxPressure.Controls.Add(this.labPreName);
            this.gBoxPressure.Controls.Add(this.cBoxPreODR);
            this.gBoxPressure.Controls.Add(this.labPreODR);
            this.gBoxPressure.Controls.Add(this.gBoxPreRegister);
            this.gBoxPressure.Controls.Add(this.buttonPreDrawPlot);
            this.gBoxPressure.Controls.Add(this.chBoxPreEnabled);
            this.gBoxPressure.Enabled = false;
            this.gBoxPressure.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gBoxPressure.Location = new System.Drawing.Point(367, 162);
            this.gBoxPressure.Name = "gBoxPressure";
            this.gBoxPressure.Size = new System.Drawing.Size(355, 150);
            this.gBoxPressure.TabIndex = 3;
            this.gBoxPressure.TabStop = false;
            this.gBoxPressure.Text = "Barometr";
            // 
            // barNameLab
            // 
            this.barNameLab.AutoSize = true;
            this.barNameLab.Location = new System.Drawing.Point(102, 19);
            this.barNameLab.Name = "barNameLab";
            this.barNameLab.Size = new System.Drawing.Size(16, 17);
            this.barNameLab.TabIndex = 24;
            this.barNameLab.Text = "?";
            // 
            // labPreName
            // 
            this.labPreName.AutoSize = true;
            this.labPreName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labPreName.Location = new System.Drawing.Point(6, 19);
            this.labPreName.Name = "labPreName";
            this.labPreName.Size = new System.Drawing.Size(99, 15);
            this.labPreName.TabIndex = 18;
            this.labPreName.Text = "Nazwa czujnika: ";
            // 
            // cBoxPreODR
            // 
            this.cBoxPreODR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cBoxPreODR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxPreODR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cBoxPreODR.FormattingEnabled = true;
            this.cBoxPreODR.Items.AddRange(new object[] {
            "1",
            "10",
            "25",
            "50",
            "75"});
            this.cBoxPreODR.Location = new System.Drawing.Point(9, 77);
            this.cBoxPreODR.Name = "cBoxPreODR";
            this.cBoxPreODR.Size = new System.Drawing.Size(121, 21);
            this.cBoxPreODR.TabIndex = 20;
            this.cBoxPreODR.SelectedIndexChanged += new System.EventHandler(this.cBoxBarODR_SelectedIndexChanged);
            // 
            // labPreODR
            // 
            this.labPreODR.AutoSize = true;
            this.labPreODR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labPreODR.Location = new System.Drawing.Point(6, 59);
            this.labPreODR.Name = "labPreODR";
            this.labPreODR.Size = new System.Drawing.Size(37, 15);
            this.labPreODR.TabIndex = 23;
            this.labPreODR.Text = "ODR:";
            // 
            // gBoxPreRegister
            // 
            this.gBoxPreRegister.Controls.Add(this.buttonPreGet);
            this.gBoxPreRegister.Controls.Add(this.buttonPreSet);
            this.gBoxPreRegister.Controls.Add(this.tBoxPreValue);
            this.gBoxPreRegister.Controls.Add(this.tBoxPreAddress);
            this.gBoxPreRegister.Controls.Add(this.labPreValue);
            this.gBoxPreRegister.Controls.Add(this.labPreAddress);
            this.gBoxPreRegister.Controls.Add(this.buttonPreOpen);
            this.gBoxPreRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gBoxPreRegister.Location = new System.Drawing.Point(154, 39);
            this.gBoxPreRegister.Name = "gBoxPreRegister";
            this.gBoxPreRegister.Size = new System.Drawing.Size(195, 105);
            this.gBoxPreRegister.TabIndex = 21;
            this.gBoxPreRegister.TabStop = false;
            this.gBoxPreRegister.Text = "Rejestr";
            // 
            // buttonPreGet
            // 
            this.buttonPreGet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPreGet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPreGet.Location = new System.Drawing.Point(107, 54);
            this.buttonPreGet.Name = "buttonPreGet";
            this.buttonPreGet.Size = new System.Drawing.Size(66, 23);
            this.buttonPreGet.TabIndex = 20;
            this.buttonPreGet.Text = "Wczytaj";
            this.buttonPreGet.UseVisualStyleBackColor = true;
            // 
            // buttonPreSet
            // 
            this.buttonPreSet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPreSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPreSet.Location = new System.Drawing.Point(30, 54);
            this.buttonPreSet.Name = "buttonPreSet";
            this.buttonPreSet.Size = new System.Drawing.Size(66, 23);
            this.buttonPreSet.TabIndex = 19;
            this.buttonPreSet.Text = "Ustaw";
            this.buttonPreSet.UseVisualStyleBackColor = true;
            // 
            // tBoxPreValue
            // 
            this.tBoxPreValue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tBoxPreValue.Location = new System.Drawing.Point(107, 28);
            this.tBoxPreValue.Name = "tBoxPreValue";
            this.tBoxPreValue.Size = new System.Drawing.Size(66, 20);
            this.tBoxPreValue.TabIndex = 18;
            // 
            // tBoxPreAddress
            // 
            this.tBoxPreAddress.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tBoxPreAddress.Location = new System.Drawing.Point(30, 28);
            this.tBoxPreAddress.Name = "tBoxPreAddress";
            this.tBoxPreAddress.Size = new System.Drawing.Size(66, 20);
            this.tBoxPreAddress.TabIndex = 17;
            // 
            // labPreValue
            // 
            this.labPreValue.AutoSize = true;
            this.labPreValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labPreValue.Location = new System.Drawing.Point(117, 10);
            this.labPreValue.Name = "labPreValue";
            this.labPreValue.Size = new System.Drawing.Size(54, 15);
            this.labPreValue.TabIndex = 16;
            this.labPreValue.Text = "Wartość:";
            // 
            // labPreAddress
            // 
            this.labPreAddress.AutoSize = true;
            this.labPreAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labPreAddress.Location = new System.Drawing.Point(43, 10);
            this.labPreAddress.Name = "labPreAddress";
            this.labPreAddress.Size = new System.Drawing.Size(41, 15);
            this.labPreAddress.TabIndex = 15;
            this.labPreAddress.Text = "Adres:";
            // 
            // buttonPreOpen
            // 
            this.buttonPreOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPreOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPreOpen.Location = new System.Drawing.Point(30, 79);
            this.buttonPreOpen.Name = "buttonPreOpen";
            this.buttonPreOpen.Size = new System.Drawing.Size(143, 23);
            this.buttonPreOpen.TabIndex = 14;
            this.buttonPreOpen.Text = "Otwórz rejestr";
            this.buttonPreOpen.UseVisualStyleBackColor = true;
            // 
            // buttonPreDrawPlot
            // 
            this.buttonPreDrawPlot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPreDrawPlot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPreDrawPlot.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPreDrawPlot.ForeColor = System.Drawing.Color.LimeGreen;
            this.buttonPreDrawPlot.Location = new System.Drawing.Point(249, 15);
            this.buttonPreDrawPlot.Name = "buttonPreDrawPlot";
            this.buttonPreDrawPlot.Size = new System.Drawing.Size(100, 23);
            this.buttonPreDrawPlot.TabIndex = 22;
            this.buttonPreDrawPlot.Text = "Rysuj wykres";
            this.buttonPreDrawPlot.UseVisualStyleBackColor = true;
            // 
            // chBoxPreEnabled
            // 
            this.chBoxPreEnabled.AutoSize = true;
            this.chBoxPreEnabled.Checked = true;
            this.chBoxPreEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chBoxPreEnabled.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chBoxPreEnabled.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chBoxPreEnabled.Location = new System.Drawing.Point(9, 37);
            this.chBoxPreEnabled.Name = "chBoxPreEnabled";
            this.chBoxPreEnabled.Size = new System.Drawing.Size(78, 19);
            this.chBoxPreEnabled.TabIndex = 19;
            this.chBoxPreEnabled.Text = "Włączony";
            this.chBoxPreEnabled.UseVisualStyleBackColor = true;
            this.chBoxPreEnabled.Click += new System.EventHandler(this.chBoxPreEnabled_Click);
            // 
            // gBoxGyroscope
            // 
            this.gBoxGyroscope.Controls.Add(this.gyroNameLab);
            this.gBoxGyroscope.Controls.Add(this.LabGyroName);
            this.gBoxGyroscope.Controls.Add(this.cBoxGyroODR);
            this.gBoxGyroscope.Controls.Add(this.cBoxGyroScale);
            this.gBoxGyroscope.Controls.Add(this.gBoxGyroRegister);
            this.gBoxGyroscope.Controls.Add(this.buttonGyroDrawPlot);
            this.gBoxGyroscope.Controls.Add(this.labGyroODR);
            this.gBoxGyroscope.Controls.Add(this.labGyroScale);
            this.gBoxGyroscope.Controls.Add(this.chBoxGyroEnabled);
            this.gBoxGyroscope.Enabled = false;
            this.gBoxGyroscope.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gBoxGyroscope.Location = new System.Drawing.Point(6, 162);
            this.gBoxGyroscope.Name = "gBoxGyroscope";
            this.gBoxGyroscope.Size = new System.Drawing.Size(355, 150);
            this.gBoxGyroscope.TabIndex = 1;
            this.gBoxGyroscope.TabStop = false;
            this.gBoxGyroscope.Text = "Żyroskop";
            // 
            // gyroNameLab
            // 
            this.gyroNameLab.AutoSize = true;
            this.gyroNameLab.Location = new System.Drawing.Point(102, 19);
            this.gyroNameLab.Name = "gyroNameLab";
            this.gyroNameLab.Size = new System.Drawing.Size(16, 17);
            this.gyroNameLab.TabIndex = 10;
            this.gyroNameLab.Text = "?";
            // 
            // LabGyroName
            // 
            this.LabGyroName.AutoSize = true;
            this.LabGyroName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabGyroName.Location = new System.Drawing.Point(6, 19);
            this.LabGyroName.Name = "LabGyroName";
            this.LabGyroName.Size = new System.Drawing.Size(99, 15);
            this.LabGyroName.TabIndex = 9;
            this.LabGyroName.Text = "Nazwa czujnika: ";
            // 
            // cBoxGyroODR
            // 
            this.cBoxGyroODR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cBoxGyroODR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxGyroODR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cBoxGyroODR.FormattingEnabled = true;
            this.cBoxGyroODR.Items.AddRange(new object[] {
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
            this.cBoxGyroODR.Location = new System.Drawing.Point(9, 119);
            this.cBoxGyroODR.Name = "cBoxGyroODR";
            this.cBoxGyroODR.Size = new System.Drawing.Size(121, 21);
            this.cBoxGyroODR.TabIndex = 14;
            this.cBoxGyroODR.SelectedIndexChanged += new System.EventHandler(this.cBoxZyroODR_SelectedIndexChanged);
            // 
            // cBoxGyroScale
            // 
            this.cBoxGyroScale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cBoxGyroScale.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxGyroScale.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cBoxGyroScale.FormattingEnabled = true;
            this.cBoxGyroScale.Items.AddRange(new object[] {
            "125",
            "250",
            "500",
            "1000",
            "2000"});
            this.cBoxGyroScale.Location = new System.Drawing.Point(9, 77);
            this.cBoxGyroScale.Name = "cBoxGyroScale";
            this.cBoxGyroScale.Size = new System.Drawing.Size(121, 21);
            this.cBoxGyroScale.TabIndex = 12;
            this.cBoxGyroScale.SelectedIndexChanged += new System.EventHandler(this.cBoxZyroSkala_SelectedIndexChanged);
            // 
            // gBoxGyroRegister
            // 
            this.gBoxGyroRegister.Controls.Add(this.buttonGyroGet);
            this.gBoxGyroRegister.Controls.Add(this.buttonGyroSet);
            this.gBoxGyroRegister.Controls.Add(this.tBoxGyroValue);
            this.gBoxGyroRegister.Controls.Add(this.tBoxGyroAddress);
            this.gBoxGyroRegister.Controls.Add(this.labGyroValue);
            this.gBoxGyroRegister.Controls.Add(this.labGyroAddress);
            this.gBoxGyroRegister.Controls.Add(this.buttonGyroOpen);
            this.gBoxGyroRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gBoxGyroRegister.Location = new System.Drawing.Point(154, 39);
            this.gBoxGyroRegister.Name = "gBoxGyroRegister";
            this.gBoxGyroRegister.Size = new System.Drawing.Size(195, 105);
            this.gBoxGyroRegister.TabIndex = 15;
            this.gBoxGyroRegister.TabStop = false;
            this.gBoxGyroRegister.Text = "Rejestr";
            // 
            // buttonGyroGet
            // 
            this.buttonGyroGet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGyroGet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonGyroGet.Location = new System.Drawing.Point(107, 54);
            this.buttonGyroGet.Name = "buttonGyroGet";
            this.buttonGyroGet.Size = new System.Drawing.Size(66, 23);
            this.buttonGyroGet.TabIndex = 20;
            this.buttonGyroGet.Text = "Wczytaj";
            this.buttonGyroGet.UseVisualStyleBackColor = true;
            // 
            // buttonGyroSet
            // 
            this.buttonGyroSet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGyroSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonGyroSet.Location = new System.Drawing.Point(30, 54);
            this.buttonGyroSet.Name = "buttonGyroSet";
            this.buttonGyroSet.Size = new System.Drawing.Size(66, 23);
            this.buttonGyroSet.TabIndex = 19;
            this.buttonGyroSet.Text = "Ustaw";
            this.buttonGyroSet.UseVisualStyleBackColor = true;
            // 
            // tBoxGyroValue
            // 
            this.tBoxGyroValue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tBoxGyroValue.Location = new System.Drawing.Point(107, 28);
            this.tBoxGyroValue.Name = "tBoxGyroValue";
            this.tBoxGyroValue.Size = new System.Drawing.Size(66, 20);
            this.tBoxGyroValue.TabIndex = 18;
            // 
            // tBoxGyroAddress
            // 
            this.tBoxGyroAddress.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tBoxGyroAddress.Location = new System.Drawing.Point(30, 28);
            this.tBoxGyroAddress.Name = "tBoxGyroAddress";
            this.tBoxGyroAddress.Size = new System.Drawing.Size(66, 20);
            this.tBoxGyroAddress.TabIndex = 17;
            // 
            // labGyroValue
            // 
            this.labGyroValue.AutoSize = true;
            this.labGyroValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labGyroValue.Location = new System.Drawing.Point(117, 10);
            this.labGyroValue.Name = "labGyroValue";
            this.labGyroValue.Size = new System.Drawing.Size(54, 15);
            this.labGyroValue.TabIndex = 16;
            this.labGyroValue.Text = "Wartość:";
            // 
            // labGyroAddress
            // 
            this.labGyroAddress.AutoSize = true;
            this.labGyroAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labGyroAddress.Location = new System.Drawing.Point(43, 10);
            this.labGyroAddress.Name = "labGyroAddress";
            this.labGyroAddress.Size = new System.Drawing.Size(41, 15);
            this.labGyroAddress.TabIndex = 15;
            this.labGyroAddress.Text = "Adres:";
            // 
            // buttonGyroOpen
            // 
            this.buttonGyroOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGyroOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonGyroOpen.Location = new System.Drawing.Point(30, 79);
            this.buttonGyroOpen.Name = "buttonGyroOpen";
            this.buttonGyroOpen.Size = new System.Drawing.Size(143, 23);
            this.buttonGyroOpen.TabIndex = 14;
            this.buttonGyroOpen.Text = "Otwórz rejestr";
            this.buttonGyroOpen.UseVisualStyleBackColor = true;
            // 
            // buttonGyroDrawPlot
            // 
            this.buttonGyroDrawPlot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGyroDrawPlot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGyroDrawPlot.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonGyroDrawPlot.ForeColor = System.Drawing.Color.LimeGreen;
            this.buttonGyroDrawPlot.Location = new System.Drawing.Point(249, 15);
            this.buttonGyroDrawPlot.Name = "buttonGyroDrawPlot";
            this.buttonGyroDrawPlot.Size = new System.Drawing.Size(100, 23);
            this.buttonGyroDrawPlot.TabIndex = 16;
            this.buttonGyroDrawPlot.Text = "Rysuj wykres";
            this.buttonGyroDrawPlot.UseVisualStyleBackColor = true;
            // 
            // labGyroODR
            // 
            this.labGyroODR.AutoSize = true;
            this.labGyroODR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labGyroODR.Location = new System.Drawing.Point(6, 101);
            this.labGyroODR.Name = "labGyroODR";
            this.labGyroODR.Size = new System.Drawing.Size(37, 15);
            this.labGyroODR.TabIndex = 13;
            this.labGyroODR.Text = "ODR:";
            // 
            // labGyroScale
            // 
            this.labGyroScale.AutoSize = true;
            this.labGyroScale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labGyroScale.Location = new System.Drawing.Point(6, 59);
            this.labGyroScale.Name = "labGyroScale";
            this.labGyroScale.Size = new System.Drawing.Size(47, 15);
            this.labGyroScale.TabIndex = 11;
            this.labGyroScale.Text = "Zakres:";
            // 
            // chBoxGyroEnabled
            // 
            this.chBoxGyroEnabled.AutoSize = true;
            this.chBoxGyroEnabled.Checked = true;
            this.chBoxGyroEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chBoxGyroEnabled.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chBoxGyroEnabled.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chBoxGyroEnabled.Location = new System.Drawing.Point(9, 37);
            this.chBoxGyroEnabled.Name = "chBoxGyroEnabled";
            this.chBoxGyroEnabled.Size = new System.Drawing.Size(78, 19);
            this.chBoxGyroEnabled.TabIndex = 10;
            this.chBoxGyroEnabled.Text = "Włączony";
            this.chBoxGyroEnabled.UseVisualStyleBackColor = true;
            this.chBoxGyroEnabled.Click += new System.EventHandler(this.chBoxGyroEnabled_Click);
            // 
            // gBoxTermometer
            // 
            this.gBoxTermometer.Controls.Add(this.terNameLab);
            this.gBoxTermometer.Controls.Add(this.labTermName);
            this.gBoxTermometer.Controls.Add(this.cBoxTermODR);
            this.gBoxTermometer.Controls.Add(this.labTermODR);
            this.gBoxTermometer.Controls.Add(this.gBoxTermRegister);
            this.gBoxTermometer.Controls.Add(this.buttonTermDrawPlot);
            this.gBoxTermometer.Controls.Add(this.chBoxTermEnabled);
            this.gBoxTermometer.Enabled = false;
            this.gBoxTermometer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gBoxTermometer.Location = new System.Drawing.Point(367, 6);
            this.gBoxTermometer.Name = "gBoxTermometer";
            this.gBoxTermometer.Size = new System.Drawing.Size(355, 150);
            this.gBoxTermometer.TabIndex = 2;
            this.gBoxTermometer.TabStop = false;
            this.gBoxTermometer.Text = "Termometr";
            // 
            // terNameLab
            // 
            this.terNameLab.AutoSize = true;
            this.terNameLab.Location = new System.Drawing.Point(102, 19);
            this.terNameLab.Name = "terNameLab";
            this.terNameLab.Size = new System.Drawing.Size(16, 17);
            this.terNameLab.TabIndex = 18;
            this.terNameLab.Text = "?";
            // 
            // labTermName
            // 
            this.labTermName.AutoSize = true;
            this.labTermName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labTermName.Location = new System.Drawing.Point(6, 19);
            this.labTermName.Name = "labTermName";
            this.labTermName.Size = new System.Drawing.Size(99, 15);
            this.labTermName.TabIndex = 9;
            this.labTermName.Text = "Nazwa czujnika: ";
            // 
            // cBoxTermODR
            // 
            this.cBoxTermODR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cBoxTermODR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxTermODR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cBoxTermODR.FormattingEnabled = true;
            this.cBoxTermODR.Items.AddRange(new object[] {
            "1",
            "7",
            "12.5"});
            this.cBoxTermODR.Location = new System.Drawing.Point(9, 77);
            this.cBoxTermODR.Name = "cBoxTermODR";
            this.cBoxTermODR.Size = new System.Drawing.Size(121, 21);
            this.cBoxTermODR.TabIndex = 12;
            this.cBoxTermODR.SelectedIndexChanged += new System.EventHandler(this.cBoxTermODR_SelectedIndexChanged);
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
            // gBoxTermRegister
            // 
            this.gBoxTermRegister.Controls.Add(this.buttonTermGet);
            this.gBoxTermRegister.Controls.Add(this.buttonTermSet);
            this.gBoxTermRegister.Controls.Add(this.tBoxTermValue);
            this.gBoxTermRegister.Controls.Add(this.tBoxTermAddress);
            this.gBoxTermRegister.Controls.Add(this.labTermValue);
            this.gBoxTermRegister.Controls.Add(this.labTermAddress);
            this.gBoxTermRegister.Controls.Add(this.buttonTermOpen);
            this.gBoxTermRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gBoxTermRegister.Location = new System.Drawing.Point(154, 39);
            this.gBoxTermRegister.Name = "gBoxTermRegister";
            this.gBoxTermRegister.Size = new System.Drawing.Size(195, 105);
            this.gBoxTermRegister.TabIndex = 15;
            this.gBoxTermRegister.TabStop = false;
            this.gBoxTermRegister.Text = "Rejestr";
            // 
            // buttonTermGet
            // 
            this.buttonTermGet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTermGet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonTermGet.Location = new System.Drawing.Point(107, 54);
            this.buttonTermGet.Name = "buttonTermGet";
            this.buttonTermGet.Size = new System.Drawing.Size(66, 23);
            this.buttonTermGet.TabIndex = 20;
            this.buttonTermGet.Text = "Wczytaj";
            this.buttonTermGet.UseVisualStyleBackColor = true;
            // 
            // buttonTermSet
            // 
            this.buttonTermSet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTermSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonTermSet.Location = new System.Drawing.Point(30, 54);
            this.buttonTermSet.Name = "buttonTermSet";
            this.buttonTermSet.Size = new System.Drawing.Size(66, 23);
            this.buttonTermSet.TabIndex = 19;
            this.buttonTermSet.Text = "Ustaw";
            this.buttonTermSet.UseVisualStyleBackColor = true;
            // 
            // tBoxTermValue
            // 
            this.tBoxTermValue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tBoxTermValue.Location = new System.Drawing.Point(107, 28);
            this.tBoxTermValue.Name = "tBoxTermValue";
            this.tBoxTermValue.Size = new System.Drawing.Size(66, 20);
            this.tBoxTermValue.TabIndex = 18;
            // 
            // tBoxTermAddress
            // 
            this.tBoxTermAddress.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tBoxTermAddress.Location = new System.Drawing.Point(30, 28);
            this.tBoxTermAddress.Name = "tBoxTermAddress";
            this.tBoxTermAddress.Size = new System.Drawing.Size(66, 20);
            this.tBoxTermAddress.TabIndex = 17;
            // 
            // labTermValue
            // 
            this.labTermValue.AutoSize = true;
            this.labTermValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labTermValue.Location = new System.Drawing.Point(117, 10);
            this.labTermValue.Name = "labTermValue";
            this.labTermValue.Size = new System.Drawing.Size(54, 15);
            this.labTermValue.TabIndex = 16;
            this.labTermValue.Text = "Wartość:";
            // 
            // labTermAddress
            // 
            this.labTermAddress.AutoSize = true;
            this.labTermAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labTermAddress.Location = new System.Drawing.Point(43, 10);
            this.labTermAddress.Name = "labTermAddress";
            this.labTermAddress.Size = new System.Drawing.Size(41, 15);
            this.labTermAddress.TabIndex = 15;
            this.labTermAddress.Text = "Adres:";
            // 
            // buttonTermOpen
            // 
            this.buttonTermOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTermOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonTermOpen.Location = new System.Drawing.Point(30, 79);
            this.buttonTermOpen.Name = "buttonTermOpen";
            this.buttonTermOpen.Size = new System.Drawing.Size(143, 23);
            this.buttonTermOpen.TabIndex = 14;
            this.buttonTermOpen.Text = "Otwórz rejestr";
            this.buttonTermOpen.UseVisualStyleBackColor = true;
            // 
            // buttonTermDrawPlot
            // 
            this.buttonTermDrawPlot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTermDrawPlot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTermDrawPlot.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonTermDrawPlot.ForeColor = System.Drawing.Color.LimeGreen;
            this.buttonTermDrawPlot.Location = new System.Drawing.Point(249, 15);
            this.buttonTermDrawPlot.Name = "buttonTermDrawPlot";
            this.buttonTermDrawPlot.Size = new System.Drawing.Size(100, 23);
            this.buttonTermDrawPlot.TabIndex = 16;
            this.buttonTermDrawPlot.Text = "Rysuj wykres";
            this.buttonTermDrawPlot.UseVisualStyleBackColor = true;
            // 
            // chBoxTermEnabled
            // 
            this.chBoxTermEnabled.AutoSize = true;
            this.chBoxTermEnabled.Checked = true;
            this.chBoxTermEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chBoxTermEnabled.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chBoxTermEnabled.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chBoxTermEnabled.Location = new System.Drawing.Point(9, 37);
            this.chBoxTermEnabled.Name = "chBoxTermEnabled";
            this.chBoxTermEnabled.Size = new System.Drawing.Size(78, 19);
            this.chBoxTermEnabled.TabIndex = 10;
            this.chBoxTermEnabled.Text = "Włączony";
            this.chBoxTermEnabled.UseVisualStyleBackColor = true;
            this.chBoxTermEnabled.Click += new System.EventHandler(this.chBoxTermEnabled_Click);
            // 
            // gBoxAccelerometer
            // 
            this.gBoxAccelerometer.Controls.Add(this.accNameLab);
            this.gBoxAccelerometer.Controls.Add(this.labAccName);
            this.gBoxAccelerometer.Controls.Add(this.cBoxAccODR);
            this.gBoxAccelerometer.Controls.Add(this.cBoxAccScale);
            this.gBoxAccelerometer.Controls.Add(this.gBoxAccRegister);
            this.gBoxAccelerometer.Controls.Add(this.buttonAccDrawPlot);
            this.gBoxAccelerometer.Controls.Add(this.labAccODR);
            this.gBoxAccelerometer.Controls.Add(this.labAccScale);
            this.gBoxAccelerometer.Controls.Add(this.chBoxAccEnabled);
            this.gBoxAccelerometer.Enabled = false;
            this.gBoxAccelerometer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gBoxAccelerometer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gBoxAccelerometer.Location = new System.Drawing.Point(6, 6);
            this.gBoxAccelerometer.Name = "gBoxAccelerometer";
            this.gBoxAccelerometer.Size = new System.Drawing.Size(355, 150);
            this.gBoxAccelerometer.TabIndex = 0;
            this.gBoxAccelerometer.TabStop = false;
            this.gBoxAccelerometer.Text = "Akcelerometr";
            // 
            // accNameLab
            // 
            this.accNameLab.AutoSize = true;
            this.accNameLab.Location = new System.Drawing.Point(102, 19);
            this.accNameLab.Name = "accNameLab";
            this.accNameLab.Size = new System.Drawing.Size(16, 17);
            this.accNameLab.TabIndex = 9;
            this.accNameLab.Text = "?";
            // 
            // labAccName
            // 
            this.labAccName.AutoSize = true;
            this.labAccName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labAccName.Location = new System.Drawing.Point(6, 19);
            this.labAccName.Name = "labAccName";
            this.labAccName.Size = new System.Drawing.Size(99, 15);
            this.labAccName.TabIndex = 0;
            this.labAccName.Text = "Nazwa czujnika: ";
            // 
            // cBoxAccODR
            // 
            this.cBoxAccODR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cBoxAccODR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxAccODR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cBoxAccODR.FormattingEnabled = true;
            this.cBoxAccODR.Items.AddRange(new object[] {
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
            this.cBoxAccODR.Location = new System.Drawing.Point(9, 119);
            this.cBoxAccODR.Name = "cBoxAccODR";
            this.cBoxAccODR.Size = new System.Drawing.Size(121, 21);
            this.cBoxAccODR.TabIndex = 5;
            this.cBoxAccODR.SelectedIndexChanged += new System.EventHandler(this.cBoxAkcODR_SelectedIndexChanged);
            // 
            // cBoxAccScale
            // 
            this.cBoxAccScale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cBoxAccScale.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxAccScale.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cBoxAccScale.FormattingEnabled = true;
            this.cBoxAccScale.Items.AddRange(new object[] {
            "2",
            "4",
            "8",
            "16"});
            this.cBoxAccScale.Location = new System.Drawing.Point(9, 77);
            this.cBoxAccScale.Name = "cBoxAccScale";
            this.cBoxAccScale.Size = new System.Drawing.Size(121, 21);
            this.cBoxAccScale.TabIndex = 3;
            this.cBoxAccScale.SelectedIndexChanged += new System.EventHandler(this.cBoxAkcSkala_SelectedIndexChanged);
            // 
            // gBoxAccRegister
            // 
            this.gBoxAccRegister.Controls.Add(this.buttonAccGet);
            this.gBoxAccRegister.Controls.Add(this.buttonAccSet);
            this.gBoxAccRegister.Controls.Add(this.tBoxAccValue);
            this.gBoxAccRegister.Controls.Add(this.tBoxAccAdsress);
            this.gBoxAccRegister.Controls.Add(this.labAccValue);
            this.gBoxAccRegister.Controls.Add(this.labAccAddress);
            this.gBoxAccRegister.Controls.Add(this.buttonAccOpen);
            this.gBoxAccRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gBoxAccRegister.Location = new System.Drawing.Point(154, 39);
            this.gBoxAccRegister.Name = "gBoxAccRegister";
            this.gBoxAccRegister.Size = new System.Drawing.Size(195, 105);
            this.gBoxAccRegister.TabIndex = 7;
            this.gBoxAccRegister.TabStop = false;
            this.gBoxAccRegister.Text = "Rejestr";
            // 
            // buttonAccGet
            // 
            this.buttonAccGet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAccGet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAccGet.Location = new System.Drawing.Point(107, 54);
            this.buttonAccGet.Name = "buttonAccGet";
            this.buttonAccGet.Size = new System.Drawing.Size(66, 23);
            this.buttonAccGet.TabIndex = 20;
            this.buttonAccGet.Text = "Wczytaj";
            this.buttonAccGet.UseVisualStyleBackColor = true;
            // 
            // buttonAccSet
            // 
            this.buttonAccSet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAccSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAccSet.Location = new System.Drawing.Point(30, 54);
            this.buttonAccSet.Name = "buttonAccSet";
            this.buttonAccSet.Size = new System.Drawing.Size(66, 23);
            this.buttonAccSet.TabIndex = 19;
            this.buttonAccSet.Text = "Ustaw";
            this.buttonAccSet.UseVisualStyleBackColor = true;
            // 
            // tBoxAccValue
            // 
            this.tBoxAccValue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tBoxAccValue.Location = new System.Drawing.Point(107, 28);
            this.tBoxAccValue.Name = "tBoxAccValue";
            this.tBoxAccValue.Size = new System.Drawing.Size(66, 20);
            this.tBoxAccValue.TabIndex = 18;
            // 
            // tBoxAccAdsress
            // 
            this.tBoxAccAdsress.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tBoxAccAdsress.Location = new System.Drawing.Point(30, 28);
            this.tBoxAccAdsress.Name = "tBoxAccAdsress";
            this.tBoxAccAdsress.Size = new System.Drawing.Size(66, 20);
            this.tBoxAccAdsress.TabIndex = 17;
            // 
            // labAccValue
            // 
            this.labAccValue.AutoSize = true;
            this.labAccValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labAccValue.Location = new System.Drawing.Point(117, 10);
            this.labAccValue.Name = "labAccValue";
            this.labAccValue.Size = new System.Drawing.Size(54, 15);
            this.labAccValue.TabIndex = 16;
            this.labAccValue.Text = "Wartość:";
            // 
            // labAccAddress
            // 
            this.labAccAddress.AutoSize = true;
            this.labAccAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labAccAddress.Location = new System.Drawing.Point(43, 10);
            this.labAccAddress.Name = "labAccAddress";
            this.labAccAddress.Size = new System.Drawing.Size(41, 15);
            this.labAccAddress.TabIndex = 15;
            this.labAccAddress.Text = "Adres:";
            // 
            // buttonAccOpen
            // 
            this.buttonAccOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAccOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAccOpen.Location = new System.Drawing.Point(30, 79);
            this.buttonAccOpen.Name = "buttonAccOpen";
            this.buttonAccOpen.Size = new System.Drawing.Size(143, 23);
            this.buttonAccOpen.TabIndex = 14;
            this.buttonAccOpen.Text = "Otwórz rejestr";
            this.buttonAccOpen.UseVisualStyleBackColor = true;
            // 
            // buttonAccDrawPlot
            // 
            this.buttonAccDrawPlot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAccDrawPlot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAccDrawPlot.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAccDrawPlot.ForeColor = System.Drawing.Color.LimeGreen;
            this.buttonAccDrawPlot.Location = new System.Drawing.Point(249, 15);
            this.buttonAccDrawPlot.Name = "buttonAccDrawPlot";
            this.buttonAccDrawPlot.Size = new System.Drawing.Size(100, 23);
            this.buttonAccDrawPlot.TabIndex = 8;
            this.buttonAccDrawPlot.Text = "Rysuj wykres";
            this.buttonAccDrawPlot.UseVisualStyleBackColor = true;
            // 
            // labAccODR
            // 
            this.labAccODR.AutoSize = true;
            this.labAccODR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labAccODR.Location = new System.Drawing.Point(6, 101);
            this.labAccODR.Name = "labAccODR";
            this.labAccODR.Size = new System.Drawing.Size(37, 15);
            this.labAccODR.TabIndex = 4;
            this.labAccODR.Text = "ODR:";
            // 
            // labAccScale
            // 
            this.labAccScale.AutoSize = true;
            this.labAccScale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labAccScale.Location = new System.Drawing.Point(6, 59);
            this.labAccScale.Name = "labAccScale";
            this.labAccScale.Size = new System.Drawing.Size(47, 15);
            this.labAccScale.TabIndex = 2;
            this.labAccScale.Text = "Zakres:";
            // 
            // chBoxAccEnabled
            // 
            this.chBoxAccEnabled.AutoSize = true;
            this.chBoxAccEnabled.Checked = true;
            this.chBoxAccEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chBoxAccEnabled.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chBoxAccEnabled.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chBoxAccEnabled.Location = new System.Drawing.Point(9, 37);
            this.chBoxAccEnabled.Name = "chBoxAccEnabled";
            this.chBoxAccEnabled.Size = new System.Drawing.Size(78, 19);
            this.chBoxAccEnabled.TabIndex = 1;
            this.chBoxAccEnabled.Text = "Włączony";
            this.chBoxAccEnabled.UseVisualStyleBackColor = true;
            this.chBoxAccEnabled.Click += new System.EventHandler(this.chBoxAkcWlaczony_CheckedChanged);
            // 
            // tabPageData
            // 
            this.tabPageData.Controls.Add(this.rTBoxData);
            this.tabPageData.Location = new System.Drawing.Point(4, 22);
            this.tabPageData.Name = "tabPageData";
            this.tabPageData.Size = new System.Drawing.Size(734, 474);
            this.tabPageData.TabIndex = 2;
            this.tabPageData.Text = "Dane";
            this.tabPageData.UseVisualStyleBackColor = true;
            // 
            // rTBoxData
            // 
            this.rTBoxData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rTBoxData.Location = new System.Drawing.Point(0, 0);
            this.rTBoxData.Name = "rTBoxData";
            this.rTBoxData.ReadOnly = true;
            this.rTBoxData.Size = new System.Drawing.Size(734, 474);
            this.rTBoxData.TabIndex = 0;
            this.rTBoxData.Text = "";
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
            this.portOpenToolStripMenuItem,
            this.EnableAllToolStripMenuItem,
            this.DisableAllToolStripMenuItem,
            this.włączWyłączPrzerwaniaToolStripMenuItem});
            this.opcjeToolStripMenuItem.Name = "opcjeToolStripMenuItem";
            this.opcjeToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.opcjeToolStripMenuItem.Text = "Opcje";
            // 
            // portOpenToolStripMenuItem
            // 
            this.portOpenToolStripMenuItem.Name = "portOpenToolStripMenuItem";
            this.portOpenToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.portOpenToolStripMenuItem.Text = "Otworz port";
            // 
            // EnableAllToolStripMenuItem
            // 
            this.EnableAllToolStripMenuItem.Enabled = false;
            this.EnableAllToolStripMenuItem.Name = "EnableAllToolStripMenuItem";
            this.EnableAllToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.EnableAllToolStripMenuItem.Text = "Włącz wszystkie czujniki";
            this.EnableAllToolStripMenuItem.Click += new System.EventHandler(this.włączWszystkieCzujnikiToolStripMenuItem_Click);
            // 
            // DisableAllToolStripMenuItem
            // 
            this.DisableAllToolStripMenuItem.Enabled = false;
            this.DisableAllToolStripMenuItem.Name = "DisableAllToolStripMenuItem";
            this.DisableAllToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.DisableAllToolStripMenuItem.Text = "Wyłącz wszystkie czujniki";
            this.DisableAllToolStripMenuItem.Click += new System.EventHandler(this.wyłączWszystkieCzujnikiToolStripMenuItem_Click);
            // 
            // włączWyłączPrzerwaniaToolStripMenuItem
            // 
            this.włączWyłączPrzerwaniaToolStripMenuItem.Name = "włączWyłączPrzerwaniaToolStripMenuItem";
            this.włączWyłączPrzerwaniaToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.włączWyłączPrzerwaniaToolStripMenuItem.Text = "Włącz/Wyłącz przerwania";
            this.włączWyłączPrzerwaniaToolStripMenuItem.Click += new System.EventHandler(this.włączWyłączPrzerwaniaToolStripMenuItem_Click);
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
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.menuStrip);
            this.MaximizeBox = false;
            this.Name = "UserForm";
            this.Text = "Aplikacja MEMS";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.Shown += new System.EventHandler(this.UserForm_Shown);
            this.tabControlMain.ResumeLayout(false);
            this.tabPageGeneral.ResumeLayout(false);
            this.gBoxSensors.ResumeLayout(false);
            this.gBoxSensors.PerformLayout();
            this.gBoxConnection.ResumeLayout(false);
            this.gBoxConnection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxLogoWEL)).EndInit();
            this.gBoxInfo.ResumeLayout(false);
            this.gBoxInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxBoard)).EndInit();
            this.tabPageSensors.ResumeLayout(false);
            this.gBoxHumidity.ResumeLayout(false);
            this.gBoxHumidity.PerformLayout();
            this.gBoxHumRegister.ResumeLayout(false);
            this.gBoxHumRegister.PerformLayout();
            this.gBoxMagnetometer.ResumeLayout(false);
            this.gBoxMagnetometer.PerformLayout();
            this.gBoxMagRegister.ResumeLayout(false);
            this.gBoxMagRegister.PerformLayout();
            this.gBoxPressure.ResumeLayout(false);
            this.gBoxPressure.PerformLayout();
            this.gBoxPreRegister.ResumeLayout(false);
            this.gBoxPreRegister.PerformLayout();
            this.gBoxGyroscope.ResumeLayout(false);
            this.gBoxGyroscope.PerformLayout();
            this.gBoxGyroRegister.ResumeLayout(false);
            this.gBoxGyroRegister.PerformLayout();
            this.gBoxTermometer.ResumeLayout(false);
            this.gBoxTermometer.PerformLayout();
            this.gBoxTermRegister.ResumeLayout(false);
            this.gBoxTermRegister.PerformLayout();
            this.gBoxAccelerometer.ResumeLayout(false);
            this.gBoxAccelerometer.PerformLayout();
            this.gBoxAccRegister.ResumeLayout(false);
            this.gBoxAccRegister.PerformLayout();
            this.tabPageData.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageGeneral;
        private System.Windows.Forms.TabPage tabPageSensors;
        private System.Windows.Forms.GroupBox gBoxInfo;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edytujToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opcjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asdToolStripMenuItem;
        private System.Windows.Forms.GroupBox gBoxSensors;
        private System.Windows.Forms.GroupBox gBoxConnection;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelNoBoards;
        private System.Windows.Forms.Label labelAvailablePorts;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.PictureBox pBoxBoard;
        private System.Windows.Forms.TabPage tabPageData;
        public System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.ComboBox cBoxPorts;
        private System.Windows.Forms.Label labelPortSelection;
        private System.Windows.Forms.Label labelGyroscope;
        private System.Windows.Forms.Label labelAccelerometer;
        private System.Windows.Forms.ProgressBar progressBarData;
        private System.Windows.Forms.Label labelExchangeStatus;
        private System.Windows.Forms.Label labelDataExchange;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonStop;
        public System.Windows.Forms.ProgressBar progressBarCOM;
        private System.Windows.Forms.Label labelStatusCOM;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label labelHumidity;
        private System.Windows.Forms.Label labelPressure;
        private System.Windows.Forms.Label labelThermometer;
        private System.Windows.Forms.Label labelMagnetometer;
        private System.Windows.Forms.ToolStripMenuItem portOpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomocToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem oProgramieToolStripMenuItem;
        private System.Windows.Forms.ComboBox cBoxHumidity;
        private System.Windows.Forms.ComboBox cBoxPressure;
        private System.Windows.Forms.ComboBox cBoxThermometer;
        private System.Windows.Forms.ComboBox cBoxMagnetometer;
        private System.Windows.Forms.ComboBox cBoxGyroscope;
        private System.Windows.Forms.ComboBox cBoxAccelerometer;
        private System.Windows.Forms.PictureBox pBoxLogoWEL;
        private System.ComponentModel.BackgroundWorker bgWorkerOtworz;
        private System.Windows.Forms.GroupBox gBoxHumidity;
        private System.Windows.Forms.GroupBox gBoxMagnetometer;
        private System.Windows.Forms.GroupBox gBoxPressure;
        private System.Windows.Forms.GroupBox gBoxGyroscope;
        private System.Windows.Forms.GroupBox gBoxTermometer;
        private System.Windows.Forms.GroupBox gBoxAccelerometer;
        private System.Windows.Forms.GroupBox gBoxMagRegister;
        private System.Windows.Forms.Button buttonMagGet;
        private System.Windows.Forms.Button buttonMagSet;
        private System.Windows.Forms.TextBox tBoxMagValue;
        private System.Windows.Forms.TextBox tBoxMagAddress;
        private System.Windows.Forms.Label labMagValue;
        private System.Windows.Forms.Label labMagAddress;
        private System.Windows.Forms.Button buttonMagOpen;
        private System.Windows.Forms.Button buttonMagDrawPlot;
        private System.Windows.Forms.ComboBox cBoxMagODR;
        private System.Windows.Forms.Label labMagODR;
        private System.Windows.Forms.ComboBox cBoxMagScale;
        private System.Windows.Forms.Label labMagScale;
        private System.Windows.Forms.CheckBox chBoxMagEnabled;
        private System.Windows.Forms.Label labMagName;
        private System.Windows.Forms.GroupBox gBoxGyroRegister;
        private System.Windows.Forms.Button buttonGyroGet;
        private System.Windows.Forms.Button buttonGyroSet;
        private System.Windows.Forms.TextBox tBoxGyroValue;
        private System.Windows.Forms.TextBox tBoxGyroAddress;
        private System.Windows.Forms.Label labGyroValue;
        private System.Windows.Forms.Label labGyroAddress;
        private System.Windows.Forms.Button buttonGyroOpen;
        private System.Windows.Forms.Button buttonGyroDrawPlot;
        private System.Windows.Forms.ComboBox cBoxGyroODR;
        private System.Windows.Forms.Label labGyroODR;
        private System.Windows.Forms.ComboBox cBoxGyroScale;
        private System.Windows.Forms.Label labGyroScale;
        private System.Windows.Forms.CheckBox chBoxGyroEnabled;
        private System.Windows.Forms.Label LabGyroName;
        private System.Windows.Forms.GroupBox gBoxTermRegister;
        private System.Windows.Forms.Button buttonTermGet;
        private System.Windows.Forms.Button buttonTermSet;
        private System.Windows.Forms.TextBox tBoxTermValue;
        private System.Windows.Forms.TextBox tBoxTermAddress;
        private System.Windows.Forms.Label labTermValue;
        private System.Windows.Forms.Label labTermAddress;
        private System.Windows.Forms.Button buttonTermOpen;
        private System.Windows.Forms.Button buttonTermDrawPlot;
        private System.Windows.Forms.ComboBox cBoxTermODR;
        private System.Windows.Forms.CheckBox chBoxTermEnabled;
        private System.Windows.Forms.Label labTermName;
        private System.Windows.Forms.GroupBox gBoxAccRegister;
        private System.Windows.Forms.Button buttonAccGet;
        private System.Windows.Forms.Button buttonAccSet;
        private System.Windows.Forms.TextBox tBoxAccValue;
        private System.Windows.Forms.TextBox tBoxAccAdsress;
        private System.Windows.Forms.Label labAccValue;
        private System.Windows.Forms.Label labAccAddress;
        private System.Windows.Forms.Button buttonAccOpen;
        private System.Windows.Forms.Button buttonAccDrawPlot;
        private System.Windows.Forms.ComboBox cBoxAccODR;
        private System.Windows.Forms.Label labAccODR;
        private System.Windows.Forms.ComboBox cBoxAccScale;
        private System.Windows.Forms.Label labAccScale;
        private System.Windows.Forms.CheckBox chBoxAccEnabled;
        private System.Windows.Forms.Label labAccName;
        private System.Windows.Forms.Label labHumODR;
        private System.Windows.Forms.GroupBox gBoxHumRegister;
        private System.Windows.Forms.Button buttonHumGet;
        private System.Windows.Forms.Button buttonHumSet;
        private System.Windows.Forms.TextBox tBoxHumValue;
        private System.Windows.Forms.TextBox tBoxHumAddress;
        private System.Windows.Forms.Label labHumValue;
        private System.Windows.Forms.Label labHumAddress;
        private System.Windows.Forms.Button buttonHumOpen;
        private System.Windows.Forms.Button buttonHumDrawPlot;
        private System.Windows.Forms.ComboBox cBoxHumODR;
        private System.Windows.Forms.CheckBox chBoxHumEnabled;
        private System.Windows.Forms.Label labHumName;
        private System.Windows.Forms.Label labPreODR;
        private System.Windows.Forms.GroupBox gBoxPreRegister;
        private System.Windows.Forms.Button buttonPreGet;
        private System.Windows.Forms.Button buttonPreSet;
        private System.Windows.Forms.TextBox tBoxPreValue;
        private System.Windows.Forms.TextBox tBoxPreAddress;
        private System.Windows.Forms.Label labPreValue;
        private System.Windows.Forms.Label labPreAddress;
        private System.Windows.Forms.Button buttonPreOpen;
        private System.Windows.Forms.Button buttonPreDrawPlot;
        private System.Windows.Forms.ComboBox cBoxPreODR;
        private System.Windows.Forms.CheckBox chBoxPreEnabled;
        private System.Windows.Forms.Label labPreName;
        private System.Windows.Forms.Label labTermODR;
        public System.Windows.Forms.RichTextBox rTBoxData;
        private System.Windows.Forms.ToolStripMenuItem EnableAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DisableAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem włączWyłączPrzerwaniaToolStripMenuItem;
        private System.Windows.Forms.Label magNameLab;
        private System.Windows.Forms.Label gyroNameLab;
        private System.Windows.Forms.Label accNameLab;
        private System.Windows.Forms.Label terNameLab;
        private System.Windows.Forms.Label higNameLab;
        private System.Windows.Forms.Label barNameLab;
    }
}

