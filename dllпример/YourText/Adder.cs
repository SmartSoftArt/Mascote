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
    public partial class Adder : Form
    {
        public Adder()
        {
            InitializeComponent();
        }
        private void Form_closing()
        {
            Starter fnew = new Starter();
            fnew.Show();
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            Text_Box newbox = new Text_Box(valbox.Text, namebox.Text);
            if(newbox.AddBd()) 
            {
            MessageBox.Show("Успешно!", "YourText True");
            Close();
            } 
            else 
            { 
            MessageBox.Show("Ошибка!", "YourText False");
            Close();
            }
        }
    }
}
