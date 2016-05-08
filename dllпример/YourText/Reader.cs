using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YourText
{
    public partial class Reader : Form
    {
        public Reader()
        {
            InitializeComponent();
        }

        private void ReadButton_Click(object sender, EventArgs e)
        {
            valbox.Text = Db_use.ReadBd(namebox.Text);
        }
    }
}
