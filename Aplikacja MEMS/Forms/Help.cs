using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikacja_MEMS.Forms
{
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();

            pictureBox2.Location = new System.Drawing.Point(0, (int)(pictureBox1.Location.Y + pictureBox1.Size.Height)-2);
            pictureBox3.Location = new System.Drawing.Point(0, (int)(pictureBox2.Location.Y + pictureBox2.Size.Height)-2);
            pictureBox4.Location = new System.Drawing.Point(0, (int)(pictureBox3.Location.Y + pictureBox3.Size.Height)-2);
            pictureBox5.Location = new System.Drawing.Point(0, (int)(pictureBox4.Location.Y + pictureBox4.Size.Height)-2);
            pictureBox6.Location = new System.Drawing.Point(0, (int)(pictureBox5.Location.Y + pictureBox5.Size.Height)-2);
            pictureBox7.Location = new System.Drawing.Point(0, (int)(pictureBox6.Location.Y + pictureBox6.Size.Height)-2);
            pictureBox8.Location = new System.Drawing.Point(0, (int)(pictureBox7.Location.Y + pictureBox7.Size.Height)-2);
            pictureBox9.Location = new System.Drawing.Point(0, (int)(pictureBox8.Location.Y + pictureBox8.Size.Height)-2);
            pictureBox10.Location = new System.Drawing.Point(0, (int)(pictureBox9.Location.Y + pictureBox9.Size.Height)-2);
            pictureBox11.Location = new System.Drawing.Point(0, (int)(pictureBox10.Location.Y + pictureBox10.Size.Height)-2);

        }
    }
}
