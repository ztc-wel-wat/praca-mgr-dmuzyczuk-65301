using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikacja_MEMS
{
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
        }

        public void Update(int parameter)
        {
            Action<int> updateAction = new Action<int>((value) => progressBar.Value += parameter);
            progressBar.Invoke(updateAction, 32);
        }

        public void Disable()
        {
            Action<int> updateAction1 = new Action<int>((value) => this.Close());
            this.Invoke(updateAction1, 32);
        }
    }
}
