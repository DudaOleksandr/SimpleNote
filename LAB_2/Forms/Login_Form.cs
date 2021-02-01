using LAB_2.Forms;
using MySql.Data.MySqlClient;
using System;
using Autofac;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB_2
{
    public partial class Notes : Form
    {
        Autofac.IContainer container;
        IDataBase database;
     
        Table table;
        String login, password, loginUser,passUser;
        int id;
        
        public Notes()
        {
            this.container = Containers.Configure();
            this.database = container.Resolve<IDataBase>();
            this.table = new Table();
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            loginUser = Loginfield.Text;
            passUser = Passfield.Text;
            var adapter = database.GetAdapter();      
            MySqlCommand command = new MySqlCommand("SELECT* FROM `users` WHERE `login` = @uL AND `pass`= @uP", database.GetConnection());

            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Авторизовано");
                this.Close();
                Note_Form note_Form = new Note_Form(loginUser);
                note_Form.Show();
               
            }
            else
                MessageBox.Show("Не Авторизовано");

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            login = Loginfield.Text;
        }
        private void sign_in_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration_Form registration_Form = new Registration_Form();
            registration_Form.Show();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            password = Passfield.Text;
        }
        
    }
}
