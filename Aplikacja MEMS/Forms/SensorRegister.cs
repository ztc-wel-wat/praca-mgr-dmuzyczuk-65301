using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aplikacja_MEMS.Registers;
using System.Windows.Forms;

namespace Aplikacja_MEMS
{
    public partial class SensorRegister : Form
    {
        public SensorRegister(Register register)
        {
            InitializeComponent();

            foreach(RegisterType r in register.registerType)
            {
                this.tabPage = new System.Windows.Forms.TabPage();
                this.tabPage.AutoScroll = true;
                this.tabPage.Location = new System.Drawing.Point(4, 22);
                this.tabPage.Name = "tabPage";
                this.tabPage.Padding = new System.Windows.Forms.Padding(3);
                this.tabPage.Size = new System.Drawing.Size(375, 498);
                this.tabPage.TabIndex = 0;
                this.tabPage.Text = r.typeName;
                this.tabPage.UseVisualStyleBackColor = true;
                this.tabControl.Controls.Add(this.tabPage);

                int where = 3;

                foreach(Parameter p in r.parameterList)
                {
                    this.groupBox = new System.Windows.Forms.GroupBox();

                    this.label = new System.Windows.Forms.Label();
                    this.btnGet = new System.Windows.Forms.Button();
                    this.tBoxParam = new System.Windows.Forms.TextBox();
                    // 
                    // label
                    // 
                    this.label.AutoSize = true;
                    this.label.Location = new System.Drawing.Point(6, 16);
                    this.label.Name = "label" + p.name;
                    this.label.Size = new System.Drawing.Size(29, 13);
                    this.label.TabIndex = 0;
                    this.label.Text = "0x" + p.address.ToString("X2") + " " +p.name;
                    // 
                    // btnGet
                    // 
                    this.btnGet.Cursor = System.Windows.Forms.Cursors.Hand;
                    this.btnGet.Location = new System.Drawing.Point(201, 12);
                    this.btnGet.Name = "btnGet";
                    this.btnGet.Size = new System.Drawing.Size(50, 22);
                    this.btnGet.TabIndex = 1;
                    this.btnGet.Text = "Get";
                    this.btnGet.UseVisualStyleBackColor = true;
                    if (p.getSet)
                    {
                        // 
                        // btnSet
                        // 
                        this.btnSet = new System.Windows.Forms.Button();
                        this.btnSet.Cursor = System.Windows.Forms.Cursors.Hand;
                        this.btnSet.Location = new System.Drawing.Point(257, 12);
                        this.btnSet.Name = "btnSet";
                        this.btnSet.Size = new System.Drawing.Size(50, 22);
                        this.btnSet.TabIndex = 2;
                        this.btnSet.Text = "Set";
                        this.btnSet.UseVisualStyleBackColor = true;
                        this.groupBox.Controls.Add(this.btnSet);
                    }
                    // 
                    // tBoxParam
                    // 
                    this.tBoxParam.Cursor = System.Windows.Forms.Cursors.Hand;
                    this.tBoxParam.Location = new System.Drawing.Point(313, 13);
                    this.tBoxParam.Name = "tBoxParam";
                    this.tBoxParam.Size = new System.Drawing.Size(50, 20);
                    this.tBoxParam.TabIndex = 3;
                    this.groupBox.Controls.Add(this.tBoxParam);
                    this.groupBox.Controls.Add(this.btnGet);
                    this.groupBox.Controls.Add(this.label);
                    this.groupBox.Location = new System.Drawing.Point(3, where);
                    this.groupBox.Name = "groupBox";
                    this.groupBox.Size = new System.Drawing.Size(369, 40);
                    this.groupBox.TabIndex = 0;
                    this.groupBox.TabStop = false;
                    where += 43;

                    this.tabPage.Controls.Add(this.groupBox);
                }

            }
            tabControl.SelectedIndex = 0;
        }

        private void SensorRegister_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }
    }
}
