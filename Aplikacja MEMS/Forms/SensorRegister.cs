using System.Windows.Forms;
using System.IO;
using System;

namespace Aplikacja_MEMS
{
    public partial class SensorRegister : Form
    {
        Sensor sensor;
        public SensorRegister(string name, Sensor s)
        {
            InitializeComponent();

            this.Text = name;
            sensor = s;

            string fileContent;
            using (StreamReader reader = new StreamReader(name + ".txt"))
                fileContent = reader.ReadToEnd();

            while (fileContent.Length > 0)
            {
                string bankBuffer = fileContent.Substring(0, fileContent.IndexOf("-"));

                string pageTag = bankBuffer.Substring(0, bankBuffer.IndexOf("|"));

                this.tabPage = new System.Windows.Forms.TabPage();
                this.tabPage.AutoScroll = true;
                this.tabPage.Location = new System.Drawing.Point(4, 22);
                this.tabPage.Name = bankBuffer.Substring(0, bankBuffer.IndexOf("|"));
                this.tabPage.Padding = new System.Windows.Forms.Padding(3);
                this.tabPage.Size = new System.Drawing.Size(375, 498);
                this.tabPage.TabIndex = 0;
                this.tabPage.Text = bankBuffer.Substring(0, bankBuffer.IndexOf("|"));
                bankBuffer = bankBuffer.Remove(0, bankBuffer.IndexOf('|') + 1);

                this.tabPage.Tag = bankBuffer.Substring(0, bankBuffer.IndexOf("|"));
                bankBuffer = bankBuffer.Remove(0, bankBuffer.IndexOf('|') + 1);

                this.tabPage.UseVisualStyleBackColor = true;
                this.tabPage.Click += new System.EventHandler(this.SetRegister);
                this.tabControl.Controls.Add(this.tabPage);


                // 
                // btnGetAll
                // 
                this.btnGetAll = new System.Windows.Forms.Button();

                this.btnGetAll.Cursor = System.Windows.Forms.Cursors.Hand;
                this.btnGetAll.Location = new System.Drawing.Point(201, 12);
                this.btnGetAll.Name = "btnReadAll";
                this.btnGetAll.Size = new System.Drawing.Size(50, 22);
                this.btnGetAll.Dock = DockStyle.Top;
                this.btnGetAll.TabIndex = 1;
                this.btnGetAll.Text = "Pobierz wszystkie parametry";
                this.btnGetAll.Tag = pageTag;
                this.btnGetAll.Click += new System.EventHandler(this.GetAll);
                this.btnGetAll.UseVisualStyleBackColor = true;

                this.tabPage.Controls.Add(this.btnGetAll);


                int where = 25;
                do
                {

                    this.groupBox = new System.Windows.Forms.GroupBox();

                    this.label = new System.Windows.Forms.Label();
                    this.btnGet = new System.Windows.Forms.Button();
                    this.tBoxParam = new System.Windows.Forms.TextBox();

                    string address = bankBuffer.Substring(0, bankBuffer.IndexOf('|'));
                    bankBuffer = bankBuffer.Remove(0, bankBuffer.IndexOf('|') + 1);


                    string paramName = bankBuffer.Substring(0, bankBuffer.IndexOf('|'));
                    bankBuffer = bankBuffer.Remove(0, bankBuffer.IndexOf('|') + 1);


                    string getSet = bankBuffer.Substring(0, bankBuffer.IndexOf('|'));
                    bankBuffer = bankBuffer.Remove(0, bankBuffer.IndexOf('|') + 1);


                    // 
                    // label
                    // 
                    this.label.AutoSize = true;
                    this.label.Location = new System.Drawing.Point(6, 16);
                    this.label.Name = "label" + paramName;
                    this.label.Size = new System.Drawing.Size(29, 13);
                    this.label.TabIndex = 0;
                    this.label.Text = "0x" + address + " " + paramName;
                    // 
                    // btnGet
                    // 
                    this.btnGet.Cursor = System.Windows.Forms.Cursors.Hand;
                    this.btnGet.Location = new System.Drawing.Point(201, 12);
                    this.btnGet.Name = address;
                    this.btnGet.Size = new System.Drawing.Size(50, 22);
                    this.btnGet.TabIndex = 1;
                    this.btnGet.Text = "Get";
                    this.btnGet.Tag = pageTag;
                    this.btnGet.Click += new System.EventHandler(this.Get);
                    this.btnGet.UseVisualStyleBackColor = true;


                    if (getSet == "S")
                    {
                        // 
                        // btnSet
                        // 
                        this.btnSet = new System.Windows.Forms.Button();
                        this.btnSet.Cursor = System.Windows.Forms.Cursors.Hand;
                        this.btnSet.Location = new System.Drawing.Point(257, 12);
                        this.btnSet.Name = address;
                        this.btnSet.Size = new System.Drawing.Size(50, 22);
                        this.btnSet.TabIndex = 2;
                        this.btnSet.Text = "Set";
                        this.btnSet.Tag = pageTag;
                        this.btnSet.Click += new System.EventHandler(this.Set_Parameter);
                        this.btnSet.UseVisualStyleBackColor = true;
                        this.groupBox.Controls.Add(this.btnSet);
                    }
                    // 
                    // tBoxParam
                    // 
                    this.tBoxParam.Cursor = System.Windows.Forms.Cursors.Hand;
                    this.tBoxParam.Location = new System.Drawing.Point(313, 13);
                    this.tBoxParam.Name = address;
                    this.tBoxParam.Size = new System.Drawing.Size(50, 20);
                    this.tBoxParam.TabIndex = 3;
                    this.tBoxParam.Tag = pageTag;
                    this.tBoxParam.ReadOnly = true;
                    this.tBoxParam.TextAlign = HorizontalAlignment.Center;


                    this.groupBox.Controls.Add(this.tBoxParam);
                    this.groupBox.Controls.Add(this.btnGet);
                    this.groupBox.Controls.Add(this.label);
                    this.groupBox.Tag = pageTag;
                    this.groupBox.Location = new System.Drawing.Point(3, where);
                    this.groupBox.Name = address;
                    this.groupBox.Size = new System.Drawing.Size(369, 40);
                    this.groupBox.TabIndex = 0;
                    this.groupBox.TabStop = false;
                    where += 43;

                    this.tabPage.Controls.Add(this.groupBox);

                } while (bankBuffer.Length > 1);

                fileContent = fileContent.Remove(0, fileContent.IndexOf("-") + 1);
            }


            tabControl.SelectedIndex = 0;
        }
        private void Set_Parameter(object sender, EventArgs e)
        {
            foreach (TabPage tPage in tabControl.Controls)
                if (tPage.Name == (string)(((Button)sender).Tag))
                    foreach (GroupBox gBox in tPage.Controls)
                        if (gBox.Name == ((Button)sender).Name)
                            foreach (Control c in gBox.Controls)
                                if (c is TextBox tBox)
                                    sensor.SetRegisterParameter(((Button)sender).Name, tBox.Text);
        }
        private void SetRegister(object sender, EventArgs e)
        {
            sensor.SetRegisterParameter("01", (string)((TabPage)(sender)).Tag);
        }

        private void GetAll(object sender, EventArgs e)
        {
            foreach(Control c in tabControl.Controls[tabControl.SelectedIndex].Controls)
                if(c is GroupBox gBox)
                sensor.GetRegisterParameter(gBox.Name);
        }

        private void Get(object sender, EventArgs e)
        {
            sensor.GetRegisterParameter(((Button)(sender)).Name);
        }

        private void SensorRegister_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Visible = false;

                UserForm.EnableParameterButtons();
            }
        }

        public void AddData(string address, string parameter)
        {
            Invoke((Action)delegate
            {
                foreach (Control c in tabControl.Controls[tabControl.SelectedIndex].Controls)
                    if (c is GroupBox gBox && gBox.Name == address)
                        foreach (Control g in gBox.Controls)
                            if (g is TextBox tBox)
                                tBox.Text = parameter;
            });

        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetRegister(((TabControl)sender).Controls[((TabControl)(sender)).SelectedIndex], null);
        }
    }
}