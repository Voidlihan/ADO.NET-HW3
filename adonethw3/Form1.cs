using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adonethw3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();            
            button1.Click += new EventHandler(but_Click);
        }
        private void textbox_TextChanged(object sender, EventArgs e)
        {
            textBox2.Controls.Add(button1);
        }
        private void but_Click(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder connectionString = new SqlConnectionStringBuilder();                                                          
            if(connectionString.ConnectionString == textBox2.ToString())
            {
                MessageBox.Show("Вы подключились к серверу!");
            }
            else
            {
                MessageBox.Show("Сервер не найден");
            }
        }
    }
}
