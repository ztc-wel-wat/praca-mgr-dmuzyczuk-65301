
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
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
            this.btnRefresh = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.pBoxBoard = new System.Windows.Forms.PictureBox();
            this.labelNoBoards = new System.Windows.Forms.Label();
            this.labelAvailablePorts = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.tabPageSensors = new System.Windows.Forms.TabPage();
            this.gBoxHumidity = new System.Windows.Forms.GroupBox();
            this.humNameLab = new System.Windows.Forms.Label();
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
            this.presNameLab = new System.Windows.Forms.Label();
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
            this.gyrNameLab = new System.Windows.Forms.Label();
            this.LabGyrName = new System.Windows.Forms.Label();
            this.cBoxGyrODR = new System.Windows.Forms.ComboBox();
            this.cBoxGyrScale = new System.Windows.Forms.ComboBox();
            this.gBoxGyrRegister = new System.Windows.Forms.GroupBox();
            this.buttonGyrGet = new System.Windows.Forms.Button();
            this.buttonGyrSet = new System.Windows.Forms.Button();
            this.tBoxGyrValue = new System.Windows.Forms.TextBox();
            this.tBoxGyrAddress = new System.Windows.Forms.TextBox();
            this.labGyrValue = new System.Windows.Forms.Label();
            this.labGyrAddress = new System.Windows.Forms.Label();
            this.buttonGyrOpen = new System.Windows.Forms.Button();
            this.buttonGyrDrawPlot = new System.Windows.Forms.Button();
            this.labGyrODR = new System.Windows.Forms.Label();
            this.labGyrScale = new System.Windows.Forms.Label();
            this.chBoxGyrEnabled = new System.Windows.Forms.CheckBox();
            this.gBoxThermometer = new System.Windows.Forms.GroupBox();
            this.terNameLab = new System.Windows.Forms.Label();
            this.labTherName = new System.Windows.Forms.Label();
            this.cBoxTherODR = new System.Windows.Forms.ComboBox();
            this.labTherODR = new System.Windows.Forms.Label();
            this.gBoxTherRegister = new System.Windows.Forms.GroupBox();
            this.buttonTherGet = new System.Windows.Forms.Button();
            this.buttonTherSet = new System.Windows.Forms.Button();
            this.tBoxTherValue = new System.Windows.Forms.TextBox();
            this.tBoxTherAddress = new System.Windows.Forms.TextBox();
            this.labTherValue = new System.Windows.Forms.Label();
            this.labTherAddress = new System.Windows.Forms.Label();
            this.buttonTherOpen = new System.Windows.Forms.Button();
            this.buttonTherDrawPlot = new System.Windows.Forms.Button();
            this.chBoxTherEnabled = new System.Windows.Forms.CheckBox();
            this.gBoxAccelerometer = new System.Windows.Forms.GroupBox();
            this.accNameLab = new System.Windows.Forms.Label();
            this.labAccName = new System.Windows.Forms.Label();
            this.cBoxAccODR = new System.Windows.Forms.ComboBox();
            this.cBoxAccScale = new System.Windows.Forms.ComboBox();
            this.gBoxAccRegister = new System.Windows.Forms.GroupBox();
            this.buttonAccGet = new System.Windows.Forms.Button();
            this.buttonAccSet = new System.Windows.Forms.Button();
            this.tBoxAccValue = new System.Windows.Forms.TextBox();
            this.tBoxAccAddress = new System.Windows.Forms.TextBox();
            this.labAccValue = new System.Windows.Forms.Label();
            this.labAccAddress = new System.Windows.Forms.Label();
            this.buttonAccOpen = new System.Windows.Forms.Button();
            this.buttonAccDrawPlot = new System.Windows.Forms.Button();
            this.labAccODR = new System.Windows.Forms.Label();
            this.labAccScale = new System.Windows.Forms.Label();
            this.chBoxAccEnabled = new System.Windows.Forms.CheckBox();
            this.tabPageData = new System.Windows.Forms.TabPage();
            this.rtBoxHeader = new System.Windows.Forms.RichTextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.rTBoxData = new System.Windows.Forms.RichTextBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszPomiaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.akcelerometrToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.żyroskopToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.magnetometrToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.termometrToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.barometrToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.higrometrToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.otwórzPomiaryZPlikuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.zamknijToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edytujToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wyczyśćToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.daneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.akcelerometrToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.żyroskopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.magnetometrToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.termometrToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.barometrToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.higrometrToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wykresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.akcelerometrToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.żyroskopToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.magnetometrToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.termometrToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.barometrToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.higrometrToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.opcjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.portOpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.EnableAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DisableAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.włączWyłączPrzerwaniaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.pokazujNaWspólnymWykresieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomocToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.oProgramieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.gBoxGyrRegister.SuspendLayout();
            this.gBoxThermometer.SuspendLayout();
            this.gBoxTherRegister.SuspendLayout();
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
            this.tabControlMain.Size = new System.Drawing.Size(788, 500);
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
            this.tabPageGeneral.Size = new System.Drawing.Size(780, 474);
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
            this.gBoxSensors.Size = new System.Drawing.Size(774, 144);
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
            this.cBoxHumidity.Location = new System.Drawing.Point(566, 101);
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
            this.cBoxPressure.Location = new System.Drawing.Point(566, 66);
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
            this.cBoxThermometer.Location = new System.Drawing.Point(566, 31);
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
            this.labelHumidity.Location = new System.Drawing.Point(435, 102);
            this.labelHumidity.Name = "labelHumidity";
            this.labelHumidity.Size = new System.Drawing.Size(74, 17);
            this.labelHumidity.TabIndex = 5;
            this.labelHumidity.Text = "Higrometr:";
            // 
            // labelPressure
            // 
            this.labelPressure.AutoSize = true;
            this.labelPressure.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPressure.Location = new System.Drawing.Point(435, 67);
            this.labelPressure.Name = "labelPressure";
            this.labelPressure.Size = new System.Drawing.Size(70, 17);
            this.labelPressure.TabIndex = 4;
            this.labelPressure.Text = "Barometr:";
            // 
            // labelThermometer
            // 
            this.labelThermometer.AutoSize = true;
            this.labelThermometer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelThermometer.Location = new System.Drawing.Point(435, 32);
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
            this.gBoxConnection.Size = new System.Drawing.Size(774, 144);
            this.gBoxConnection.TabIndex = 1;
            this.gBoxConnection.TabStop = false;
            this.gBoxConnection.Text = "Połączenie";
            // 
            // pBoxLogoWEL
            // 
            this.pBoxLogoWEL.Image = global::Aplikacja_MEMS.Properties.Resources.WEL_WAT;
            this.pBoxLogoWEL.Location = new System.Drawing.Point(347, 38);
            this.pBoxLogoWEL.Name = "pBoxLogoWEL";
            this.pBoxLogoWEL.Size = new System.Drawing.Size(80, 80);
            this.pBoxLogoWEL.TabIndex = 11;
            this.pBoxLogoWEL.TabStop = false;
            // 
            // progressBarData
            // 
            this.progressBarData.Location = new System.Drawing.Point(470, 104);
            this.progressBarData.Name = "progressBarData";
            this.progressBarData.Size = new System.Drawing.Size(266, 23);
            this.progressBarData.TabIndex = 10;
            // 
            // labelExchangeStatus
            // 
            this.labelExchangeStatus.AutoSize = true;
            this.labelExchangeStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelExchangeStatus.Location = new System.Drawing.Point(467, 81);
            this.labelExchangeStatus.Name = "labelExchangeStatus";
            this.labelExchangeStatus.Size = new System.Drawing.Size(173, 17);
            this.labelExchangeStatus.TabIndex = 9;
            this.labelExchangeStatus.Text = "Status pobierania danych:";
            // 
            // labelDataExchange
            // 
            this.labelDataExchange.AutoSize = true;
            this.labelDataExchange.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDataExchange.Location = new System.Drawing.Point(538, 28);
            this.labelDataExchange.Name = "labelDataExchange";
            this.labelDataExchange.Size = new System.Drawing.Size(130, 17);
            this.labelDataExchange.TabIndex = 8;
            this.labelDataExchange.Text = "Pobieranie danych:";
            // 
            // buttonStart
            // 
            this.buttonStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStart.Enabled = false;
            this.buttonStart.Location = new System.Drawing.Point(470, 55);
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
            this.buttonStop.Location = new System.Drawing.Point(606, 55);
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
            this.cBoxPorts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.gBoxInfo.Controls.Add(this.btnRefresh);
            this.gBoxInfo.Controls.Add(this.labelTitle);
            this.gBoxInfo.Controls.Add(this.pBoxBoard);
            this.gBoxInfo.Controls.Add(this.labelNoBoards);
            this.gBoxInfo.Controls.Add(this.labelAvailablePorts);
            this.gBoxInfo.Controls.Add(this.labelVersion);
            this.gBoxInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.gBoxInfo.Location = new System.Drawing.Point(3, 3);
            this.gBoxInfo.Name = "gBoxInfo";
            this.gBoxInfo.Size = new System.Drawing.Size(774, 160);
            this.gBoxInfo.TabIndex = 0;
            this.gBoxInfo.TabStop = false;
            this.gBoxInfo.Text = "Informacje";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackgroundImage = global::Aplikacja_MEMS.Properties.Resources.refresh;
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Location = new System.Drawing.Point(115, 65);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(22, 22);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTitle.Location = new System.Drawing.Point(212, 16);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(296, 24);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Aplikacja MEMS czujnika IKS01A2";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pBoxBoard
            // 
            this.pBoxBoard.Image = global::Aplikacja_MEMS.Properties.Resources.Plytka;
            this.pBoxBoard.InitialImage = global::Aplikacja_MEMS.Properties.Resources.Plytka;
            this.pBoxBoard.Location = new System.Drawing.Point(572, 10);
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
            // tabPageSensors
            // 
            this.tabPageSensors.CausesValidation = false;
            this.tabPageSensors.Controls.Add(this.gBoxHumidity);
            this.tabPageSensors.Controls.Add(this.gBoxMagnetometer);
            this.tabPageSensors.Controls.Add(this.gBoxPressure);
            this.tabPageSensors.Controls.Add(this.gBoxGyroscope);
            this.tabPageSensors.Controls.Add(this.gBoxThermometer);
            this.tabPageSensors.Controls.Add(this.gBoxAccelerometer);
            this.tabPageSensors.Location = new System.Drawing.Point(4, 22);
            this.tabPageSensors.Name = "tabPageSensors";
            this.tabPageSensors.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSensors.Size = new System.Drawing.Size(780, 474);
            this.tabPageSensors.TabIndex = 1;
            this.tabPageSensors.Text = "Czujniki MEMS";
            this.tabPageSensors.UseVisualStyleBackColor = true;
            // 
            // gBoxHumidity
            // 
            this.gBoxHumidity.Controls.Add(this.humNameLab);
            this.gBoxHumidity.Controls.Add(this.labHumName);
            this.gBoxHumidity.Controls.Add(this.cBoxHumODR);
            this.gBoxHumidity.Controls.Add(this.labHumODR);
            this.gBoxHumidity.Controls.Add(this.gBoxHumRegister);
            this.gBoxHumidity.Controls.Add(this.buttonHumDrawPlot);
            this.gBoxHumidity.Controls.Add(this.chBoxHumEnabled);
            this.gBoxHumidity.Enabled = false;
            this.gBoxHumidity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gBoxHumidity.Location = new System.Drawing.Point(409, 318);
            this.gBoxHumidity.Name = "gBoxHumidity";
            this.gBoxHumidity.Size = new System.Drawing.Size(355, 150);
            this.gBoxHumidity.TabIndex = 4;
            this.gBoxHumidity.TabStop = false;
            this.gBoxHumidity.Tag = "Higrometr";
            this.gBoxHumidity.Text = "Higrometr";
            // 
            // humNameLab
            // 
            this.humNameLab.AutoSize = true;
            this.humNameLab.Location = new System.Drawing.Point(100, 19);
            this.humNameLab.Name = "humNameLab";
            this.humNameLab.Size = new System.Drawing.Size(16, 17);
            this.humNameLab.TabIndex = 24;
            this.humNameLab.Text = "?";
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
            this.cBoxHumODR.Tag = "Higrometr";
            this.cBoxHumODR.SelectedIndexChanged += new System.EventHandler(this.SetOdr);
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
            this.buttonHumGet.Tag = "Higrometr";
            this.buttonHumGet.Text = "Wczytaj";
            this.buttonHumGet.UseVisualStyleBackColor = true;
            this.buttonHumGet.Click += new System.EventHandler(this.GetRegParam);
            // 
            // buttonHumSet
            // 
            this.buttonHumSet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHumSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonHumSet.Location = new System.Drawing.Point(30, 54);
            this.buttonHumSet.Name = "buttonHumSet";
            this.buttonHumSet.Size = new System.Drawing.Size(66, 23);
            this.buttonHumSet.TabIndex = 19;
            this.buttonHumSet.Tag = "Higrometr";
            this.buttonHumSet.Text = "Ustaw";
            this.buttonHumSet.UseVisualStyleBackColor = true;
            this.buttonHumSet.Click += new System.EventHandler(this.SetRegParam);
            // 
            // tBoxHumValue
            // 
            this.tBoxHumValue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tBoxHumValue.Location = new System.Drawing.Point(107, 28);
            this.tBoxHumValue.Name = "tBoxHumValue";
            this.tBoxHumValue.Size = new System.Drawing.Size(66, 20);
            this.tBoxHumValue.TabIndex = 18;
            this.tBoxHumValue.Tag = "Higrometr";
            this.tBoxHumValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tBoxHumAddress
            // 
            this.tBoxHumAddress.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tBoxHumAddress.Location = new System.Drawing.Point(30, 28);
            this.tBoxHumAddress.Name = "tBoxHumAddress";
            this.tBoxHumAddress.Size = new System.Drawing.Size(66, 20);
            this.tBoxHumAddress.TabIndex = 17;
            this.tBoxHumAddress.Tag = "Higrometr";
            this.tBoxHumAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.buttonHumOpen.Tag = "Higrometr";
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
            this.buttonHumDrawPlot.Tag = "Higrometr";
            this.buttonHumDrawPlot.Text = "Rysuj wykres";
            this.buttonHumDrawPlot.UseVisualStyleBackColor = true;
            this.buttonHumDrawPlot.Click += new System.EventHandler(this.ShowPlot);
            // 
            // chBoxHumEnabled
            // 
            this.chBoxHumEnabled.AutoSize = true;
            this.chBoxHumEnabled.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chBoxHumEnabled.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chBoxHumEnabled.Location = new System.Drawing.Point(9, 37);
            this.chBoxHumEnabled.Name = "chBoxHumEnabled";
            this.chBoxHumEnabled.Size = new System.Drawing.Size(78, 19);
            this.chBoxHumEnabled.TabIndex = 19;
            this.chBoxHumEnabled.Tag = "Higrometr";
            this.chBoxHumEnabled.Text = "Włączony";
            this.chBoxHumEnabled.UseVisualStyleBackColor = true;
            this.chBoxHumEnabled.Click += new System.EventHandler(this.ChangeEnable);
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
            this.gBoxMagnetometer.Location = new System.Drawing.Point(14, 318);
            this.gBoxMagnetometer.Name = "gBoxMagnetometer";
            this.gBoxMagnetometer.Size = new System.Drawing.Size(355, 150);
            this.gBoxMagnetometer.TabIndex = 1;
            this.gBoxMagnetometer.TabStop = false;
            this.gBoxMagnetometer.Tag = "Magnetometr";
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
            this.cBoxMagODR.Tag = "Magnetometr";
            this.cBoxMagODR.SelectedIndexChanged += new System.EventHandler(this.SetOdr);
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
            this.cBoxMagScale.Tag = "Magnetometr";
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
            this.buttonMagGet.Location = new System.Drawing.Point(105, 54);
            this.buttonMagGet.Name = "buttonMagGet";
            this.buttonMagGet.Size = new System.Drawing.Size(66, 23);
            this.buttonMagGet.TabIndex = 20;
            this.buttonMagGet.Tag = "Magnetometr";
            this.buttonMagGet.Text = "Wczytaj";
            this.buttonMagGet.UseVisualStyleBackColor = true;
            this.buttonMagGet.Click += new System.EventHandler(this.GetRegParam);
            // 
            // buttonMagSet
            // 
            this.buttonMagSet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMagSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonMagSet.Location = new System.Drawing.Point(28, 54);
            this.buttonMagSet.Name = "buttonMagSet";
            this.buttonMagSet.Size = new System.Drawing.Size(66, 23);
            this.buttonMagSet.TabIndex = 19;
            this.buttonMagSet.Tag = "Magnetometr";
            this.buttonMagSet.Text = "Ustaw";
            this.buttonMagSet.UseVisualStyleBackColor = true;
            this.buttonMagSet.Click += new System.EventHandler(this.SetRegParam);
            // 
            // tBoxMagValue
            // 
            this.tBoxMagValue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tBoxMagValue.Location = new System.Drawing.Point(105, 28);
            this.tBoxMagValue.Name = "tBoxMagValue";
            this.tBoxMagValue.Size = new System.Drawing.Size(66, 20);
            this.tBoxMagValue.TabIndex = 18;
            this.tBoxMagValue.Tag = "Magnetometr";
            this.tBoxMagValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tBoxMagAddress
            // 
            this.tBoxMagAddress.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tBoxMagAddress.Location = new System.Drawing.Point(28, 28);
            this.tBoxMagAddress.Name = "tBoxMagAddress";
            this.tBoxMagAddress.Size = new System.Drawing.Size(66, 20);
            this.tBoxMagAddress.TabIndex = 17;
            this.tBoxMagAddress.Tag = "Magnetometr";
            this.tBoxMagAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labMagValue
            // 
            this.labMagValue.AutoSize = true;
            this.labMagValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labMagValue.Location = new System.Drawing.Point(115, 10);
            this.labMagValue.Name = "labMagValue";
            this.labMagValue.Size = new System.Drawing.Size(54, 15);
            this.labMagValue.TabIndex = 16;
            this.labMagValue.Text = "Wartość:";
            // 
            // labMagAddress
            // 
            this.labMagAddress.AutoSize = true;
            this.labMagAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labMagAddress.Location = new System.Drawing.Point(41, 10);
            this.labMagAddress.Name = "labMagAddress";
            this.labMagAddress.Size = new System.Drawing.Size(41, 15);
            this.labMagAddress.TabIndex = 15;
            this.labMagAddress.Text = "Adres:";
            // 
            // buttonMagOpen
            // 
            this.buttonMagOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMagOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonMagOpen.Location = new System.Drawing.Point(28, 79);
            this.buttonMagOpen.Name = "buttonMagOpen";
            this.buttonMagOpen.Size = new System.Drawing.Size(143, 23);
            this.buttonMagOpen.TabIndex = 14;
            this.buttonMagOpen.Tag = "Magnetometr";
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
            this.buttonMagDrawPlot.Tag = "Magnetometr";
            this.buttonMagDrawPlot.Text = "Rysuj wykres";
            this.buttonMagDrawPlot.UseVisualStyleBackColor = true;
            this.buttonMagDrawPlot.Click += new System.EventHandler(this.ShowPlot);
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
            this.chBoxMagEnabled.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chBoxMagEnabled.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chBoxMagEnabled.Location = new System.Drawing.Point(9, 37);
            this.chBoxMagEnabled.Name = "chBoxMagEnabled";
            this.chBoxMagEnabled.Size = new System.Drawing.Size(78, 19);
            this.chBoxMagEnabled.TabIndex = 10;
            this.chBoxMagEnabled.Tag = "Magnetometr";
            this.chBoxMagEnabled.Text = "Włączony";
            this.chBoxMagEnabled.UseVisualStyleBackColor = true;
            this.chBoxMagEnabled.Click += new System.EventHandler(this.ChangeEnable);
            // 
            // gBoxPressure
            // 
            this.gBoxPressure.Controls.Add(this.presNameLab);
            this.gBoxPressure.Controls.Add(this.labPreName);
            this.gBoxPressure.Controls.Add(this.cBoxPreODR);
            this.gBoxPressure.Controls.Add(this.labPreODR);
            this.gBoxPressure.Controls.Add(this.gBoxPreRegister);
            this.gBoxPressure.Controls.Add(this.buttonPreDrawPlot);
            this.gBoxPressure.Controls.Add(this.chBoxPreEnabled);
            this.gBoxPressure.Enabled = false;
            this.gBoxPressure.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gBoxPressure.Location = new System.Drawing.Point(407, 162);
            this.gBoxPressure.Name = "gBoxPressure";
            this.gBoxPressure.Size = new System.Drawing.Size(355, 150);
            this.gBoxPressure.TabIndex = 3;
            this.gBoxPressure.TabStop = false;
            this.gBoxPressure.Tag = "Barometr";
            this.gBoxPressure.Text = "Barometr";
            // 
            // presNameLab
            // 
            this.presNameLab.AutoSize = true;
            this.presNameLab.Location = new System.Drawing.Point(102, 19);
            this.presNameLab.Name = "presNameLab";
            this.presNameLab.Size = new System.Drawing.Size(16, 17);
            this.presNameLab.TabIndex = 24;
            this.presNameLab.Text = "?";
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
            this.cBoxPreODR.Tag = "Barometr";
            this.cBoxPreODR.SelectedIndexChanged += new System.EventHandler(this.SetOdr);
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
            this.buttonPreGet.Tag = "Barometr";
            this.buttonPreGet.Text = "Wczytaj";
            this.buttonPreGet.UseVisualStyleBackColor = true;
            this.buttonPreGet.Click += new System.EventHandler(this.GetRegParam);
            // 
            // buttonPreSet
            // 
            this.buttonPreSet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPreSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPreSet.Location = new System.Drawing.Point(30, 54);
            this.buttonPreSet.Name = "buttonPreSet";
            this.buttonPreSet.Size = new System.Drawing.Size(66, 23);
            this.buttonPreSet.TabIndex = 19;
            this.buttonPreSet.Tag = "Barometr";
            this.buttonPreSet.Text = "Ustaw";
            this.buttonPreSet.UseVisualStyleBackColor = true;
            this.buttonPreSet.Click += new System.EventHandler(this.SetRegParam);
            // 
            // tBoxPreValue
            // 
            this.tBoxPreValue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tBoxPreValue.Location = new System.Drawing.Point(107, 28);
            this.tBoxPreValue.Name = "tBoxPreValue";
            this.tBoxPreValue.Size = new System.Drawing.Size(66, 20);
            this.tBoxPreValue.TabIndex = 18;
            this.tBoxPreValue.Tag = "Barometr";
            this.tBoxPreValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tBoxPreAddress
            // 
            this.tBoxPreAddress.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tBoxPreAddress.Location = new System.Drawing.Point(30, 28);
            this.tBoxPreAddress.Name = "tBoxPreAddress";
            this.tBoxPreAddress.Size = new System.Drawing.Size(66, 20);
            this.tBoxPreAddress.TabIndex = 17;
            this.tBoxPreAddress.Tag = "Barometr";
            this.tBoxPreAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.buttonPreOpen.Tag = "Barometr";
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
            this.buttonPreDrawPlot.Tag = "Barometr";
            this.buttonPreDrawPlot.Text = "Rysuj wykres";
            this.buttonPreDrawPlot.UseVisualStyleBackColor = true;
            this.buttonPreDrawPlot.Click += new System.EventHandler(this.ShowPlot);
            // 
            // chBoxPreEnabled
            // 
            this.chBoxPreEnabled.AutoSize = true;
            this.chBoxPreEnabled.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chBoxPreEnabled.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chBoxPreEnabled.Location = new System.Drawing.Point(9, 37);
            this.chBoxPreEnabled.Name = "chBoxPreEnabled";
            this.chBoxPreEnabled.Size = new System.Drawing.Size(78, 19);
            this.chBoxPreEnabled.TabIndex = 19;
            this.chBoxPreEnabled.Tag = "Barometr";
            this.chBoxPreEnabled.Text = "Włączony";
            this.chBoxPreEnabled.UseVisualStyleBackColor = true;
            this.chBoxPreEnabled.Click += new System.EventHandler(this.ChangeEnable);
            // 
            // gBoxGyroscope
            // 
            this.gBoxGyroscope.Controls.Add(this.gyrNameLab);
            this.gBoxGyroscope.Controls.Add(this.LabGyrName);
            this.gBoxGyroscope.Controls.Add(this.cBoxGyrODR);
            this.gBoxGyroscope.Controls.Add(this.cBoxGyrScale);
            this.gBoxGyroscope.Controls.Add(this.gBoxGyrRegister);
            this.gBoxGyroscope.Controls.Add(this.buttonGyrDrawPlot);
            this.gBoxGyroscope.Controls.Add(this.labGyrODR);
            this.gBoxGyroscope.Controls.Add(this.labGyrScale);
            this.gBoxGyroscope.Controls.Add(this.chBoxGyrEnabled);
            this.gBoxGyroscope.Enabled = false;
            this.gBoxGyroscope.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gBoxGyroscope.Location = new System.Drawing.Point(12, 162);
            this.gBoxGyroscope.Name = "gBoxGyroscope";
            this.gBoxGyroscope.Size = new System.Drawing.Size(355, 150);
            this.gBoxGyroscope.TabIndex = 1;
            this.gBoxGyroscope.TabStop = false;
            this.gBoxGyroscope.Tag = "Żyroskop";
            this.gBoxGyroscope.Text = "Żyroskop";
            // 
            // gyrNameLab
            // 
            this.gyrNameLab.AutoSize = true;
            this.gyrNameLab.Location = new System.Drawing.Point(102, 19);
            this.gyrNameLab.Name = "gyrNameLab";
            this.gyrNameLab.Size = new System.Drawing.Size(16, 17);
            this.gyrNameLab.TabIndex = 10;
            this.gyrNameLab.Text = "?";
            // 
            // LabGyrName
            // 
            this.LabGyrName.AutoSize = true;
            this.LabGyrName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabGyrName.Location = new System.Drawing.Point(6, 19);
            this.LabGyrName.Name = "LabGyrName";
            this.LabGyrName.Size = new System.Drawing.Size(99, 15);
            this.LabGyrName.TabIndex = 9;
            this.LabGyrName.Text = "Nazwa czujnika: ";
            // 
            // cBoxGyrODR
            // 
            this.cBoxGyrODR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cBoxGyrODR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxGyrODR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cBoxGyrODR.FormattingEnabled = true;
            this.cBoxGyrODR.Items.AddRange(new object[] {
            "12,5",
            "26",
            "52",
            "104",
            "208",
            "416",
            "833",
            "1660",
            "3330",
            "6660"});
            this.cBoxGyrODR.Location = new System.Drawing.Point(9, 119);
            this.cBoxGyrODR.Name = "cBoxGyrODR";
            this.cBoxGyrODR.Size = new System.Drawing.Size(121, 21);
            this.cBoxGyrODR.TabIndex = 14;
            this.cBoxGyrODR.Tag = "Żyroskop";
            this.cBoxGyrODR.SelectedIndexChanged += new System.EventHandler(this.SetOdr);
            // 
            // cBoxGyrScale
            // 
            this.cBoxGyrScale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cBoxGyrScale.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxGyrScale.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cBoxGyrScale.FormattingEnabled = true;
            this.cBoxGyrScale.Items.AddRange(new object[] {
            "125",
            "250",
            "500",
            "1000",
            "2000"});
            this.cBoxGyrScale.Location = new System.Drawing.Point(9, 77);
            this.cBoxGyrScale.Name = "cBoxGyrScale";
            this.cBoxGyrScale.Size = new System.Drawing.Size(121, 21);
            this.cBoxGyrScale.TabIndex = 12;
            this.cBoxGyrScale.Tag = "Żyroskop";
            this.cBoxGyrScale.SelectedIndexChanged += new System.EventHandler(this.SetScale);
            // 
            // gBoxGyrRegister
            // 
            this.gBoxGyrRegister.Controls.Add(this.buttonGyrGet);
            this.gBoxGyrRegister.Controls.Add(this.buttonGyrSet);
            this.gBoxGyrRegister.Controls.Add(this.tBoxGyrValue);
            this.gBoxGyrRegister.Controls.Add(this.tBoxGyrAddress);
            this.gBoxGyrRegister.Controls.Add(this.labGyrValue);
            this.gBoxGyrRegister.Controls.Add(this.labGyrAddress);
            this.gBoxGyrRegister.Controls.Add(this.buttonGyrOpen);
            this.gBoxGyrRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gBoxGyrRegister.Location = new System.Drawing.Point(154, 39);
            this.gBoxGyrRegister.Name = "gBoxGyrRegister";
            this.gBoxGyrRegister.Size = new System.Drawing.Size(195, 105);
            this.gBoxGyrRegister.TabIndex = 15;
            this.gBoxGyrRegister.TabStop = false;
            this.gBoxGyrRegister.Text = "Rejestr";
            // 
            // buttonGyrGet
            // 
            this.buttonGyrGet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGyrGet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonGyrGet.Location = new System.Drawing.Point(107, 54);
            this.buttonGyrGet.Name = "buttonGyrGet";
            this.buttonGyrGet.Size = new System.Drawing.Size(66, 23);
            this.buttonGyrGet.TabIndex = 20;
            this.buttonGyrGet.Tag = "Żyroskop";
            this.buttonGyrGet.Text = "Wczytaj";
            this.buttonGyrGet.UseVisualStyleBackColor = true;
            this.buttonGyrGet.Click += new System.EventHandler(this.GetRegParam);
            // 
            // buttonGyrSet
            // 
            this.buttonGyrSet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGyrSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonGyrSet.Location = new System.Drawing.Point(30, 54);
            this.buttonGyrSet.Name = "buttonGyrSet";
            this.buttonGyrSet.Size = new System.Drawing.Size(66, 23);
            this.buttonGyrSet.TabIndex = 19;
            this.buttonGyrSet.Tag = "Żyroskop";
            this.buttonGyrSet.Text = "Ustaw";
            this.buttonGyrSet.UseVisualStyleBackColor = true;
            this.buttonGyrSet.Click += new System.EventHandler(this.SetRegParam);
            // 
            // tBoxGyrValue
            // 
            this.tBoxGyrValue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tBoxGyrValue.Location = new System.Drawing.Point(107, 28);
            this.tBoxGyrValue.Name = "tBoxGyrValue";
            this.tBoxGyrValue.Size = new System.Drawing.Size(66, 20);
            this.tBoxGyrValue.TabIndex = 18;
            this.tBoxGyrValue.Tag = "Żyroskop";
            this.tBoxGyrValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tBoxGyrAddress
            // 
            this.tBoxGyrAddress.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tBoxGyrAddress.Location = new System.Drawing.Point(30, 28);
            this.tBoxGyrAddress.Name = "tBoxGyrAddress";
            this.tBoxGyrAddress.Size = new System.Drawing.Size(66, 20);
            this.tBoxGyrAddress.TabIndex = 17;
            this.tBoxGyrAddress.Tag = "Żyroskop";
            this.tBoxGyrAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labGyrValue
            // 
            this.labGyrValue.AutoSize = true;
            this.labGyrValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labGyrValue.Location = new System.Drawing.Point(117, 10);
            this.labGyrValue.Name = "labGyrValue";
            this.labGyrValue.Size = new System.Drawing.Size(54, 15);
            this.labGyrValue.TabIndex = 16;
            this.labGyrValue.Text = "Wartość:";
            // 
            // labGyrAddress
            // 
            this.labGyrAddress.AutoSize = true;
            this.labGyrAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labGyrAddress.Location = new System.Drawing.Point(43, 10);
            this.labGyrAddress.Name = "labGyrAddress";
            this.labGyrAddress.Size = new System.Drawing.Size(41, 15);
            this.labGyrAddress.TabIndex = 15;
            this.labGyrAddress.Text = "Adres:";
            // 
            // buttonGyrOpen
            // 
            this.buttonGyrOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGyrOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonGyrOpen.Location = new System.Drawing.Point(30, 79);
            this.buttonGyrOpen.Name = "buttonGyrOpen";
            this.buttonGyrOpen.Size = new System.Drawing.Size(143, 23);
            this.buttonGyrOpen.TabIndex = 14;
            this.buttonGyrOpen.Tag = "Żyroskop";
            this.buttonGyrOpen.Text = "Otwórz rejestr";
            this.buttonGyrOpen.UseVisualStyleBackColor = true;
            // 
            // buttonGyrDrawPlot
            // 
            this.buttonGyrDrawPlot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGyrDrawPlot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGyrDrawPlot.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonGyrDrawPlot.ForeColor = System.Drawing.Color.LimeGreen;
            this.buttonGyrDrawPlot.Location = new System.Drawing.Point(249, 15);
            this.buttonGyrDrawPlot.Name = "buttonGyrDrawPlot";
            this.buttonGyrDrawPlot.Size = new System.Drawing.Size(100, 23);
            this.buttonGyrDrawPlot.TabIndex = 16;
            this.buttonGyrDrawPlot.Tag = "Żyroskop";
            this.buttonGyrDrawPlot.Text = "Rysuj wykres";
            this.buttonGyrDrawPlot.UseVisualStyleBackColor = true;
            this.buttonGyrDrawPlot.Click += new System.EventHandler(this.ShowPlot);
            // 
            // labGyrODR
            // 
            this.labGyrODR.AutoSize = true;
            this.labGyrODR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labGyrODR.Location = new System.Drawing.Point(6, 101);
            this.labGyrODR.Name = "labGyrODR";
            this.labGyrODR.Size = new System.Drawing.Size(37, 15);
            this.labGyrODR.TabIndex = 13;
            this.labGyrODR.Text = "ODR:";
            // 
            // labGyrScale
            // 
            this.labGyrScale.AutoSize = true;
            this.labGyrScale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labGyrScale.Location = new System.Drawing.Point(6, 59);
            this.labGyrScale.Name = "labGyrScale";
            this.labGyrScale.Size = new System.Drawing.Size(47, 15);
            this.labGyrScale.TabIndex = 11;
            this.labGyrScale.Text = "Zakres:";
            // 
            // chBoxGyrEnabled
            // 
            this.chBoxGyrEnabled.AutoSize = true;
            this.chBoxGyrEnabled.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chBoxGyrEnabled.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chBoxGyrEnabled.Location = new System.Drawing.Point(9, 37);
            this.chBoxGyrEnabled.Name = "chBoxGyrEnabled";
            this.chBoxGyrEnabled.Size = new System.Drawing.Size(78, 19);
            this.chBoxGyrEnabled.TabIndex = 10;
            this.chBoxGyrEnabled.Tag = "Żyroskop";
            this.chBoxGyrEnabled.Text = "Włączony";
            this.chBoxGyrEnabled.UseVisualStyleBackColor = true;
            this.chBoxGyrEnabled.Click += new System.EventHandler(this.ChangeEnable);
            // 
            // gBoxThermometer
            // 
            this.gBoxThermometer.Controls.Add(this.terNameLab);
            this.gBoxThermometer.Controls.Add(this.labTherName);
            this.gBoxThermometer.Controls.Add(this.cBoxTherODR);
            this.gBoxThermometer.Controls.Add(this.labTherODR);
            this.gBoxThermometer.Controls.Add(this.gBoxTherRegister);
            this.gBoxThermometer.Controls.Add(this.buttonTherDrawPlot);
            this.gBoxThermometer.Controls.Add(this.chBoxTherEnabled);
            this.gBoxThermometer.Enabled = false;
            this.gBoxThermometer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gBoxThermometer.Location = new System.Drawing.Point(407, 6);
            this.gBoxThermometer.Name = "gBoxThermometer";
            this.gBoxThermometer.Size = new System.Drawing.Size(355, 150);
            this.gBoxThermometer.TabIndex = 2;
            this.gBoxThermometer.TabStop = false;
            this.gBoxThermometer.Tag = "Termometr";
            this.gBoxThermometer.Text = "Termometr";
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
            // labTherName
            // 
            this.labTherName.AutoSize = true;
            this.labTherName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labTherName.Location = new System.Drawing.Point(6, 19);
            this.labTherName.Name = "labTherName";
            this.labTherName.Size = new System.Drawing.Size(99, 15);
            this.labTherName.TabIndex = 9;
            this.labTherName.Text = "Nazwa czujnika: ";
            // 
            // cBoxTherODR
            // 
            this.cBoxTherODR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cBoxTherODR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxTherODR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cBoxTherODR.FormattingEnabled = true;
            this.cBoxTherODR.Items.AddRange(new object[] {
            "1",
            "7",
            "12,5"});
            this.cBoxTherODR.Location = new System.Drawing.Point(9, 77);
            this.cBoxTherODR.Name = "cBoxTherODR";
            this.cBoxTherODR.Size = new System.Drawing.Size(121, 21);
            this.cBoxTherODR.TabIndex = 12;
            this.cBoxTherODR.Tag = "Termometr";
            this.cBoxTherODR.SelectedIndexChanged += new System.EventHandler(this.SetOdr);
            // 
            // labTherODR
            // 
            this.labTherODR.AutoSize = true;
            this.labTherODR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labTherODR.Location = new System.Drawing.Point(6, 59);
            this.labTherODR.Name = "labTherODR";
            this.labTherODR.Size = new System.Drawing.Size(37, 15);
            this.labTherODR.TabIndex = 17;
            this.labTherODR.Text = "ODR:";
            // 
            // gBoxTherRegister
            // 
            this.gBoxTherRegister.Controls.Add(this.buttonTherGet);
            this.gBoxTherRegister.Controls.Add(this.buttonTherSet);
            this.gBoxTherRegister.Controls.Add(this.tBoxTherValue);
            this.gBoxTherRegister.Controls.Add(this.tBoxTherAddress);
            this.gBoxTherRegister.Controls.Add(this.labTherValue);
            this.gBoxTherRegister.Controls.Add(this.labTherAddress);
            this.gBoxTherRegister.Controls.Add(this.buttonTherOpen);
            this.gBoxTherRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gBoxTherRegister.Location = new System.Drawing.Point(154, 39);
            this.gBoxTherRegister.Name = "gBoxTherRegister";
            this.gBoxTherRegister.Size = new System.Drawing.Size(195, 105);
            this.gBoxTherRegister.TabIndex = 15;
            this.gBoxTherRegister.TabStop = false;
            this.gBoxTherRegister.Text = "Rejestr";
            // 
            // buttonTherGet
            // 
            this.buttonTherGet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTherGet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonTherGet.Location = new System.Drawing.Point(107, 54);
            this.buttonTherGet.Name = "buttonTherGet";
            this.buttonTherGet.Size = new System.Drawing.Size(66, 23);
            this.buttonTherGet.TabIndex = 20;
            this.buttonTherGet.Tag = "Termometr";
            this.buttonTherGet.Text = "Wczytaj";
            this.buttonTherGet.UseVisualStyleBackColor = true;
            this.buttonTherGet.Click += new System.EventHandler(this.GetRegParam);
            // 
            // buttonTherSet
            // 
            this.buttonTherSet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTherSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonTherSet.Location = new System.Drawing.Point(30, 54);
            this.buttonTherSet.Name = "buttonTherSet";
            this.buttonTherSet.Size = new System.Drawing.Size(66, 23);
            this.buttonTherSet.TabIndex = 19;
            this.buttonTherSet.Tag = "Termometr";
            this.buttonTherSet.Text = "Ustaw";
            this.buttonTherSet.UseVisualStyleBackColor = true;
            this.buttonTherSet.Click += new System.EventHandler(this.SetRegParam);
            // 
            // tBoxTherValue
            // 
            this.tBoxTherValue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tBoxTherValue.Location = new System.Drawing.Point(107, 28);
            this.tBoxTherValue.Name = "tBoxTherValue";
            this.tBoxTherValue.Size = new System.Drawing.Size(66, 20);
            this.tBoxTherValue.TabIndex = 18;
            this.tBoxTherValue.Tag = "Termometr";
            this.tBoxTherValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tBoxTherAddress
            // 
            this.tBoxTherAddress.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tBoxTherAddress.Location = new System.Drawing.Point(30, 28);
            this.tBoxTherAddress.Name = "tBoxTherAddress";
            this.tBoxTherAddress.Size = new System.Drawing.Size(66, 20);
            this.tBoxTherAddress.TabIndex = 17;
            this.tBoxTherAddress.Tag = "Termometr";
            this.tBoxTherAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labTherValue
            // 
            this.labTherValue.AutoSize = true;
            this.labTherValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labTherValue.Location = new System.Drawing.Point(117, 10);
            this.labTherValue.Name = "labTherValue";
            this.labTherValue.Size = new System.Drawing.Size(54, 15);
            this.labTherValue.TabIndex = 16;
            this.labTherValue.Text = "Wartość:";
            // 
            // labTherAddress
            // 
            this.labTherAddress.AutoSize = true;
            this.labTherAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labTherAddress.Location = new System.Drawing.Point(43, 10);
            this.labTherAddress.Name = "labTherAddress";
            this.labTherAddress.Size = new System.Drawing.Size(41, 15);
            this.labTherAddress.TabIndex = 15;
            this.labTherAddress.Text = "Adres:";
            // 
            // buttonTherOpen
            // 
            this.buttonTherOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTherOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonTherOpen.Location = new System.Drawing.Point(30, 79);
            this.buttonTherOpen.Name = "buttonTherOpen";
            this.buttonTherOpen.Size = new System.Drawing.Size(143, 23);
            this.buttonTherOpen.TabIndex = 14;
            this.buttonTherOpen.Tag = "Termometr";
            this.buttonTherOpen.Text = "Otwórz rejestr";
            this.buttonTherOpen.UseVisualStyleBackColor = true;
            // 
            // buttonTherDrawPlot
            // 
            this.buttonTherDrawPlot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTherDrawPlot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTherDrawPlot.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonTherDrawPlot.ForeColor = System.Drawing.Color.LimeGreen;
            this.buttonTherDrawPlot.Location = new System.Drawing.Point(249, 15);
            this.buttonTherDrawPlot.Name = "buttonTherDrawPlot";
            this.buttonTherDrawPlot.Size = new System.Drawing.Size(100, 23);
            this.buttonTherDrawPlot.TabIndex = 16;
            this.buttonTherDrawPlot.Tag = "Termometr";
            this.buttonTherDrawPlot.Text = "Rysuj wykres";
            this.buttonTherDrawPlot.UseVisualStyleBackColor = true;
            this.buttonTherDrawPlot.Click += new System.EventHandler(this.ShowPlot);
            // 
            // chBoxTherEnabled
            // 
            this.chBoxTherEnabled.AutoSize = true;
            this.chBoxTherEnabled.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chBoxTherEnabled.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chBoxTherEnabled.Location = new System.Drawing.Point(9, 37);
            this.chBoxTherEnabled.Name = "chBoxTherEnabled";
            this.chBoxTherEnabled.Size = new System.Drawing.Size(78, 19);
            this.chBoxTherEnabled.TabIndex = 10;
            this.chBoxTherEnabled.Tag = "Termometr";
            this.chBoxTherEnabled.Text = "Włączony";
            this.chBoxTherEnabled.UseVisualStyleBackColor = true;
            this.chBoxTherEnabled.Click += new System.EventHandler(this.ChangeEnable);
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
            this.gBoxAccelerometer.Location = new System.Drawing.Point(12, 6);
            this.gBoxAccelerometer.Name = "gBoxAccelerometer";
            this.gBoxAccelerometer.Size = new System.Drawing.Size(355, 150);
            this.gBoxAccelerometer.TabIndex = 0;
            this.gBoxAccelerometer.TabStop = false;
            this.gBoxAccelerometer.Tag = "Akcelerometr";
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
            "12,5",
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
            this.cBoxAccODR.Tag = "Akcelerometr";
            this.cBoxAccODR.SelectedIndexChanged += new System.EventHandler(this.SetOdr);
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
            this.cBoxAccScale.Tag = "Akcelerometr";
            this.cBoxAccScale.SelectedIndexChanged += new System.EventHandler(this.SetScale);
            // 
            // gBoxAccRegister
            // 
            this.gBoxAccRegister.Controls.Add(this.buttonAccGet);
            this.gBoxAccRegister.Controls.Add(this.buttonAccSet);
            this.gBoxAccRegister.Controls.Add(this.tBoxAccValue);
            this.gBoxAccRegister.Controls.Add(this.tBoxAccAddress);
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
            this.buttonAccGet.Tag = "Akcelerometr";
            this.buttonAccGet.Text = "Wczytaj";
            this.buttonAccGet.UseVisualStyleBackColor = true;
            this.buttonAccGet.Click += new System.EventHandler(this.GetRegParam);
            // 
            // buttonAccSet
            // 
            this.buttonAccSet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAccSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAccSet.Location = new System.Drawing.Point(30, 54);
            this.buttonAccSet.Name = "buttonAccSet";
            this.buttonAccSet.Size = new System.Drawing.Size(66, 23);
            this.buttonAccSet.TabIndex = 19;
            this.buttonAccSet.Tag = "Akcelerometr";
            this.buttonAccSet.Text = "Ustaw";
            this.buttonAccSet.UseVisualStyleBackColor = true;
            this.buttonAccSet.Click += new System.EventHandler(this.SetRegParam);
            // 
            // tBoxAccValue
            // 
            this.tBoxAccValue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tBoxAccValue.Location = new System.Drawing.Point(107, 28);
            this.tBoxAccValue.Name = "tBoxAccValue";
            this.tBoxAccValue.Size = new System.Drawing.Size(66, 20);
            this.tBoxAccValue.TabIndex = 18;
            this.tBoxAccValue.Tag = "Akcelerometr";
            this.tBoxAccValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tBoxAccAddress
            // 
            this.tBoxAccAddress.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tBoxAccAddress.Location = new System.Drawing.Point(30, 28);
            this.tBoxAccAddress.MaxLength = 4;
            this.tBoxAccAddress.Name = "tBoxAccAddress";
            this.tBoxAccAddress.Size = new System.Drawing.Size(66, 20);
            this.tBoxAccAddress.TabIndex = 17;
            this.tBoxAccAddress.Tag = "Akcelerometr";
            this.tBoxAccAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.buttonAccOpen.Tag = "Akcelerometr";
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
            this.buttonAccDrawPlot.Tag = "Akcelerometr";
            this.buttonAccDrawPlot.Text = "Rysuj wykres";
            this.buttonAccDrawPlot.UseVisualStyleBackColor = true;
            this.buttonAccDrawPlot.Click += new System.EventHandler(this.ShowPlot);
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
            this.chBoxAccEnabled.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chBoxAccEnabled.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chBoxAccEnabled.Location = new System.Drawing.Point(9, 37);
            this.chBoxAccEnabled.Name = "chBoxAccEnabled";
            this.chBoxAccEnabled.Size = new System.Drawing.Size(78, 19);
            this.chBoxAccEnabled.TabIndex = 1;
            this.chBoxAccEnabled.Tag = "Akcelerometr";
            this.chBoxAccEnabled.Text = "Włączony";
            this.chBoxAccEnabled.UseVisualStyleBackColor = true;
            this.chBoxAccEnabled.Click += new System.EventHandler(this.ChangeEnable);
            // 
            // tabPageData
            // 
            this.tabPageData.Controls.Add(this.rtBoxHeader);
            this.tabPageData.Controls.Add(this.btnClear);
            this.tabPageData.Controls.Add(this.rTBoxData);
            this.tabPageData.Location = new System.Drawing.Point(4, 22);
            this.tabPageData.Name = "tabPageData";
            this.tabPageData.Size = new System.Drawing.Size(780, 474);
            this.tabPageData.TabIndex = 2;
            this.tabPageData.Text = "Dane";
            this.tabPageData.UseVisualStyleBackColor = true;
            // 
            // rtBoxHeader
            // 
            this.rtBoxHeader.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtBoxHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.rtBoxHeader.Enabled = false;
            this.rtBoxHeader.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(238)));
            this.rtBoxHeader.Location = new System.Drawing.Point(0, 0);
            this.rtBoxHeader.Name = "rtBoxHeader";
            this.rtBoxHeader.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtBoxHeader.Size = new System.Drawing.Size(780, 45);
            this.rtBoxHeader.TabIndex = 2;
            this.rtBoxHeader.Text = "";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(697, 443);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Wyczyść";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.button1_Click);
            // 
            // rTBoxData
            // 
            this.rTBoxData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rTBoxData.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(238)));
            this.rTBoxData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rTBoxData.ImeMode = System.Windows.Forms.ImeMode.On;
            this.rTBoxData.Location = new System.Drawing.Point(0, 51);
            this.rTBoxData.Name = "rTBoxData";
            this.rTBoxData.ReadOnly = true;
            this.rTBoxData.Size = new System.Drawing.Size(780, 389);
            this.rTBoxData.TabIndex = 0;
            this.rTBoxData.Text = "";
            this.rTBoxData.WordWrap = false;
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.edytujToolStripMenuItem,
            this.opcjeToolStripMenuItem,
            this.pomocToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(788, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zapiszPomiaryToolStripMenuItem,
            this.otwórzPomiaryZPlikuToolStripMenuItem,
            this.toolStripMenuItem1,
            this.zamknijToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // zapiszPomiaryToolStripMenuItem
            // 
            this.zapiszPomiaryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.akcelerometrToolStripMenuItem2,
            this.żyroskopToolStripMenuItem2,
            this.magnetometrToolStripMenuItem2,
            this.termometrToolStripMenuItem2,
            this.barometrToolStripMenuItem2,
            this.higrometrToolStripMenuItem2});
            this.zapiszPomiaryToolStripMenuItem.Name = "zapiszPomiaryToolStripMenuItem";
            this.zapiszPomiaryToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.zapiszPomiaryToolStripMenuItem.Text = "Zapisz pomiary";
            // 
            // akcelerometrToolStripMenuItem2
            // 
            this.akcelerometrToolStripMenuItem2.Name = "akcelerometrToolStripMenuItem2";
            this.akcelerometrToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.akcelerometrToolStripMenuItem2.Tag = "Akcelerometr";
            this.akcelerometrToolStripMenuItem2.Text = "Akcelerometr";
            this.akcelerometrToolStripMenuItem2.Click += new System.EventHandler(this.SaveSensorParameters);
            // 
            // żyroskopToolStripMenuItem2
            // 
            this.żyroskopToolStripMenuItem2.Name = "żyroskopToolStripMenuItem2";
            this.żyroskopToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.żyroskopToolStripMenuItem2.Tag = "Żyroskop";
            this.żyroskopToolStripMenuItem2.Text = "Żyroskop";
            this.żyroskopToolStripMenuItem2.Click += new System.EventHandler(this.SaveSensorParameters);
            // 
            // magnetometrToolStripMenuItem2
            // 
            this.magnetometrToolStripMenuItem2.Name = "magnetometrToolStripMenuItem2";
            this.magnetometrToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.magnetometrToolStripMenuItem2.Tag = "Magnetometr";
            this.magnetometrToolStripMenuItem2.Text = "Magnetometr";
            this.magnetometrToolStripMenuItem2.Click += new System.EventHandler(this.SaveSensorParameters);
            // 
            // termometrToolStripMenuItem2
            // 
            this.termometrToolStripMenuItem2.Name = "termometrToolStripMenuItem2";
            this.termometrToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.termometrToolStripMenuItem2.Tag = "Termometr";
            this.termometrToolStripMenuItem2.Text = "Termometr";
            this.termometrToolStripMenuItem2.Click += new System.EventHandler(this.SaveSensorParameters);
            // 
            // barometrToolStripMenuItem2
            // 
            this.barometrToolStripMenuItem2.Name = "barometrToolStripMenuItem2";
            this.barometrToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.barometrToolStripMenuItem2.Tag = "Barometr";
            this.barometrToolStripMenuItem2.Text = "Barometr";
            this.barometrToolStripMenuItem2.Click += new System.EventHandler(this.SaveSensorParameters);
            // 
            // higrometrToolStripMenuItem2
            // 
            this.higrometrToolStripMenuItem2.Name = "higrometrToolStripMenuItem2";
            this.higrometrToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.higrometrToolStripMenuItem2.Tag = "Higrometr";
            this.higrometrToolStripMenuItem2.Text = "Higrometr";
            this.higrometrToolStripMenuItem2.Click += new System.EventHandler(this.SaveSensorParameters);
            // 
            // otwórzPomiaryZPlikuToolStripMenuItem
            // 
            this.otwórzPomiaryZPlikuToolStripMenuItem.Name = "otwórzPomiaryZPlikuToolStripMenuItem";
            this.otwórzPomiaryZPlikuToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.otwórzPomiaryZPlikuToolStripMenuItem.Text = "Otwórz pomiary z pliku";
            this.otwórzPomiaryZPlikuToolStripMenuItem.Click += new System.EventHandler(this.otwórzPomiaryZPlikuToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(193, 6);
            // 
            // zamknijToolStripMenuItem
            // 
            this.zamknijToolStripMenuItem.Name = "zamknijToolStripMenuItem";
            this.zamknijToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.zamknijToolStripMenuItem.Text = "Zamknij";
            this.zamknijToolStripMenuItem.Click += new System.EventHandler(this.zamknijToolStripMenuItem_Click);
            // 
            // edytujToolStripMenuItem
            // 
            this.edytujToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wyczyśćToolStripMenuItem});
            this.edytujToolStripMenuItem.Name = "edytujToolStripMenuItem";
            this.edytujToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.edytujToolStripMenuItem.Text = "Edytuj";
            // 
            // wyczyśćToolStripMenuItem
            // 
            this.wyczyśćToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.daneToolStripMenuItem,
            this.wykresToolStripMenuItem});
            this.wyczyśćToolStripMenuItem.Name = "wyczyśćToolStripMenuItem";
            this.wyczyśćToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.wyczyśćToolStripMenuItem.Text = "Wyczyść";
            // 
            // daneToolStripMenuItem
            // 
            this.daneToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.akcelerometrToolStripMenuItem,
            this.żyroskopToolStripMenuItem,
            this.magnetometrToolStripMenuItem,
            this.termometrToolStripMenuItem,
            this.barometrToolStripMenuItem,
            this.higrometrToolStripMenuItem});
            this.daneToolStripMenuItem.Name = "daneToolStripMenuItem";
            this.daneToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.daneToolStripMenuItem.Text = "Dane";
            // 
            // akcelerometrToolStripMenuItem
            // 
            this.akcelerometrToolStripMenuItem.Name = "akcelerometrToolStripMenuItem";
            this.akcelerometrToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.akcelerometrToolStripMenuItem.Tag = "Akcelerometr";
            this.akcelerometrToolStripMenuItem.Text = "Akcelerometr";
            this.akcelerometrToolStripMenuItem.Click += new System.EventHandler(this.CleartSensorData);
            // 
            // żyroskopToolStripMenuItem
            // 
            this.żyroskopToolStripMenuItem.Name = "żyroskopToolStripMenuItem";
            this.żyroskopToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.żyroskopToolStripMenuItem.Tag = "Żyroskop";
            this.żyroskopToolStripMenuItem.Text = "Żyroskop";
            this.żyroskopToolStripMenuItem.Click += new System.EventHandler(this.CleartSensorData);
            // 
            // magnetometrToolStripMenuItem
            // 
            this.magnetometrToolStripMenuItem.Name = "magnetometrToolStripMenuItem";
            this.magnetometrToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.magnetometrToolStripMenuItem.Tag = "Magnetometr";
            this.magnetometrToolStripMenuItem.Text = "Magnetometr";
            this.magnetometrToolStripMenuItem.Click += new System.EventHandler(this.CleartSensorData);
            // 
            // termometrToolStripMenuItem
            // 
            this.termometrToolStripMenuItem.Name = "termometrToolStripMenuItem";
            this.termometrToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.termometrToolStripMenuItem.Tag = "Termometr";
            this.termometrToolStripMenuItem.Text = "Termometr";
            this.termometrToolStripMenuItem.Click += new System.EventHandler(this.CleartSensorData);
            // 
            // barometrToolStripMenuItem
            // 
            this.barometrToolStripMenuItem.Name = "barometrToolStripMenuItem";
            this.barometrToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.barometrToolStripMenuItem.Tag = "Barometr";
            this.barometrToolStripMenuItem.Text = "Barometr";
            this.barometrToolStripMenuItem.Click += new System.EventHandler(this.CleartSensorData);
            // 
            // higrometrToolStripMenuItem
            // 
            this.higrometrToolStripMenuItem.Name = "higrometrToolStripMenuItem";
            this.higrometrToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.higrometrToolStripMenuItem.Tag = "Higrometr";
            this.higrometrToolStripMenuItem.Text = "Higrometr";
            this.higrometrToolStripMenuItem.Click += new System.EventHandler(this.CleartSensorData);
            // 
            // wykresToolStripMenuItem
            // 
            this.wykresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.akcelerometrToolStripMenuItem1,
            this.żyroskopToolStripMenuItem1,
            this.magnetometrToolStripMenuItem1,
            this.termometrToolStripMenuItem1,
            this.barometrToolStripMenuItem1,
            this.higrometrToolStripMenuItem1});
            this.wykresToolStripMenuItem.Name = "wykresToolStripMenuItem";
            this.wykresToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.wykresToolStripMenuItem.Text = "Wykres";
            // 
            // akcelerometrToolStripMenuItem1
            // 
            this.akcelerometrToolStripMenuItem1.Name = "akcelerometrToolStripMenuItem1";
            this.akcelerometrToolStripMenuItem1.Size = new System.Drawing.Size(147, 22);
            this.akcelerometrToolStripMenuItem1.Tag = "Akcelerometr";
            this.akcelerometrToolStripMenuItem1.Text = "Akcelerometr";
            this.akcelerometrToolStripMenuItem1.Click += new System.EventHandler(this.ClearSensorPlot);
            // 
            // żyroskopToolStripMenuItem1
            // 
            this.żyroskopToolStripMenuItem1.Name = "żyroskopToolStripMenuItem1";
            this.żyroskopToolStripMenuItem1.Size = new System.Drawing.Size(147, 22);
            this.żyroskopToolStripMenuItem1.Tag = "Żyroskop";
            this.żyroskopToolStripMenuItem1.Text = "Żyroskop";
            this.żyroskopToolStripMenuItem1.Click += new System.EventHandler(this.ClearSensorPlot);
            // 
            // magnetometrToolStripMenuItem1
            // 
            this.magnetometrToolStripMenuItem1.Name = "magnetometrToolStripMenuItem1";
            this.magnetometrToolStripMenuItem1.Size = new System.Drawing.Size(147, 22);
            this.magnetometrToolStripMenuItem1.Tag = "Magnetometr";
            this.magnetometrToolStripMenuItem1.Text = "Magnetometr";
            this.magnetometrToolStripMenuItem1.Click += new System.EventHandler(this.ClearSensorPlot);
            // 
            // termometrToolStripMenuItem1
            // 
            this.termometrToolStripMenuItem1.Name = "termometrToolStripMenuItem1";
            this.termometrToolStripMenuItem1.Size = new System.Drawing.Size(147, 22);
            this.termometrToolStripMenuItem1.Tag = "Termometr";
            this.termometrToolStripMenuItem1.Text = "Termometr";
            this.termometrToolStripMenuItem1.Click += new System.EventHandler(this.ClearSensorPlot);
            // 
            // barometrToolStripMenuItem1
            // 
            this.barometrToolStripMenuItem1.Name = "barometrToolStripMenuItem1";
            this.barometrToolStripMenuItem1.Size = new System.Drawing.Size(147, 22);
            this.barometrToolStripMenuItem1.Tag = "Barometr";
            this.barometrToolStripMenuItem1.Text = "Barometr";
            this.barometrToolStripMenuItem1.Click += new System.EventHandler(this.ClearSensorPlot);
            // 
            // higrometrToolStripMenuItem1
            // 
            this.higrometrToolStripMenuItem1.Name = "higrometrToolStripMenuItem1";
            this.higrometrToolStripMenuItem1.Size = new System.Drawing.Size(147, 22);
            this.higrometrToolStripMenuItem1.Tag = "Higrometr";
            this.higrometrToolStripMenuItem1.Text = "Higrometr";
            this.higrometrToolStripMenuItem1.Click += new System.EventHandler(this.ClearSensorPlot);
            // 
            // opcjeToolStripMenuItem
            // 
            this.opcjeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.portOpenToolStripMenuItem,
            this.toolStripMenuItem2,
            this.EnableAllToolStripMenuItem,
            this.DisableAllToolStripMenuItem,
            this.włączWyłączPrzerwaniaToolStripMenuItem,
            this.toolStripMenuItem3,
            this.pokazujNaWspólnymWykresieToolStripMenuItem});
            this.opcjeToolStripMenuItem.Name = "opcjeToolStripMenuItem";
            this.opcjeToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.opcjeToolStripMenuItem.Text = "Opcje";
            // 
            // portOpenToolStripMenuItem
            // 
            this.portOpenToolStripMenuItem.Name = "portOpenToolStripMenuItem";
            this.portOpenToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.portOpenToolStripMenuItem.Text = "Otworz port";
            this.portOpenToolStripMenuItem.Click += new System.EventHandler(this.portOpenToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(234, 6);
            // 
            // EnableAllToolStripMenuItem
            // 
            this.EnableAllToolStripMenuItem.Enabled = false;
            this.EnableAllToolStripMenuItem.Name = "EnableAllToolStripMenuItem";
            this.EnableAllToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.EnableAllToolStripMenuItem.Text = "Włącz wszystkie czujniki";
            this.EnableAllToolStripMenuItem.Click += new System.EventHandler(this.włączWszystkieCzujnikiToolStripMenuItem_Click);
            // 
            // DisableAllToolStripMenuItem
            // 
            this.DisableAllToolStripMenuItem.Enabled = false;
            this.DisableAllToolStripMenuItem.Name = "DisableAllToolStripMenuItem";
            this.DisableAllToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.DisableAllToolStripMenuItem.Text = "Wyłącz wszystkie czujniki";
            this.DisableAllToolStripMenuItem.Click += new System.EventHandler(this.wyłączWszystkieCzujnikiToolStripMenuItem_Click);
            // 
            // włączWyłączPrzerwaniaToolStripMenuItem
            // 
            this.włączWyłączPrzerwaniaToolStripMenuItem.Name = "włączWyłączPrzerwaniaToolStripMenuItem";
            this.włączWyłączPrzerwaniaToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.włączWyłączPrzerwaniaToolStripMenuItem.Text = "Włącz/Wyłącz przerwania";
            this.włączWyłączPrzerwaniaToolStripMenuItem.Click += new System.EventHandler(this.włączWyłączPrzerwaniaToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(234, 6);
            // 
            // pokazujNaWspólnymWykresieToolStripMenuItem
            // 
            this.pokazujNaWspólnymWykresieToolStripMenuItem.CheckOnClick = true;
            this.pokazujNaWspólnymWykresieToolStripMenuItem.Name = "pokazujNaWspólnymWykresieToolStripMenuItem";
            this.pokazujNaWspólnymWykresieToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.pokazujNaWspólnymWykresieToolStripMenuItem.Text = "Pokazuj na wspólnym wykresie";
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
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(788, 524);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "UserForm";
            this.Text = "Aplikacja MEMS";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserForm_FormClosing);
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
            this.gBoxGyrRegister.ResumeLayout(false);
            this.gBoxGyrRegister.PerformLayout();
            this.gBoxThermometer.ResumeLayout(false);
            this.gBoxThermometer.PerformLayout();
            this.gBoxTherRegister.ResumeLayout(false);
            this.gBoxTherRegister.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem opcjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomocToolStripMenuItem;
        private System.Windows.Forms.GroupBox gBoxSensors;
        private System.Windows.Forms.GroupBox gBoxConnection;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelNoBoards;
        private System.Windows.Forms.Label labelAvailablePorts;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.PictureBox pBoxBoard;
        private System.Windows.Forms.TabPage tabPageData;
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
        private System.Windows.Forms.GroupBox gBoxHumidity;
        private System.Windows.Forms.GroupBox gBoxMagnetometer;
        private System.Windows.Forms.GroupBox gBoxPressure;
        private System.Windows.Forms.GroupBox gBoxGyroscope;
        private System.Windows.Forms.GroupBox gBoxThermometer;
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
        private System.Windows.Forms.GroupBox gBoxGyrRegister;
        private System.Windows.Forms.Button buttonGyrGet;
        private System.Windows.Forms.Button buttonGyrSet;
        private System.Windows.Forms.TextBox tBoxGyrValue;
        private System.Windows.Forms.TextBox tBoxGyrAddress;
        private System.Windows.Forms.Label labGyrValue;
        private System.Windows.Forms.Label labGyrAddress;
        private System.Windows.Forms.Button buttonGyrOpen;
        private System.Windows.Forms.Button buttonGyrDrawPlot;
        private System.Windows.Forms.ComboBox cBoxGyrODR;
        private System.Windows.Forms.Label labGyrODR;
        private System.Windows.Forms.ComboBox cBoxGyrScale;
        private System.Windows.Forms.Label labGyrScale;
        private System.Windows.Forms.CheckBox chBoxGyrEnabled;
        private System.Windows.Forms.Label LabGyrName;
        private System.Windows.Forms.GroupBox gBoxTherRegister;
        private System.Windows.Forms.Button buttonTherGet;
        private System.Windows.Forms.Button buttonTherSet;
        private System.Windows.Forms.TextBox tBoxTherValue;
        private System.Windows.Forms.TextBox tBoxTherAddress;
        private System.Windows.Forms.Label labTherValue;
        private System.Windows.Forms.Label labTherAddress;
        private System.Windows.Forms.Button buttonTherOpen;
        private System.Windows.Forms.Button buttonTherDrawPlot;
        private System.Windows.Forms.ComboBox cBoxTherODR;
        private System.Windows.Forms.CheckBox chBoxTherEnabled;
        private System.Windows.Forms.Label labTherName;
        private System.Windows.Forms.GroupBox gBoxAccRegister;
        private System.Windows.Forms.Button buttonAccGet;
        private System.Windows.Forms.Button buttonAccSet;
        private System.Windows.Forms.TextBox tBoxAccValue;
        private System.Windows.Forms.TextBox tBoxAccAddress;
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
        private System.Windows.Forms.Label labTherODR;
        public System.Windows.Forms.RichTextBox rTBoxData;
        private System.Windows.Forms.ToolStripMenuItem EnableAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DisableAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem włączWyłączPrzerwaniaToolStripMenuItem;
        private System.Windows.Forms.Label magNameLab;
        private System.Windows.Forms.Label gyrNameLab;
        private System.Windows.Forms.Label accNameLab;
        private System.Windows.Forms.Label terNameLab;
        private System.Windows.Forms.Label humNameLab;
        private System.Windows.Forms.Label presNameLab;
        private System.Windows.Forms.ToolStripMenuItem zapiszPomiaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otwórzPomiaryZPlikuToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem zamknijToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pokazujNaWspólnymWykresieToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.RichTextBox rtBoxHeader;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ToolStripMenuItem edytujToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wyczyśćToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem daneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem akcelerometrToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem żyroskopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem magnetometrToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem termometrToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem barometrToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem higrometrToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wykresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem akcelerometrToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem żyroskopToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem magnetometrToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem termometrToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem barometrToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem higrometrToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem akcelerometrToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem żyroskopToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem magnetometrToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem termometrToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem barometrToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem higrometrToolStripMenuItem2;
    }
}

