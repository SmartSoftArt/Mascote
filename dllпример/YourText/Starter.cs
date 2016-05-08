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
    public partial class Starter : Form
    {
        public Starter()
        {
            InitializeComponent();
        }

        private void StartButAdd_Click(object sender, EventArgs e)
        {
            Adder NewAdd = new Adder();
            NewAdd.ShowDialog();
        }

        private void StartButRead_Click(object sender, EventArgs e)
        {
            Reader NewRead = new Reader();
            NewRead.ShowDialog();
        }
    }
}
