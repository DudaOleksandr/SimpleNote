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
    
    public partial class Registration_Form : Form
    {
        Autofac.IContainer container;
        IDataBase database;
        Table table;
        public Registration_Form()
        {
            InitializeComponent();
            this.table = new Table();
            this.container = Containers.Configure();
            this.database = container.Resolve<IDataBase>();
            database.openCon();
        }


        private void register_Click(object sender, EventArgs e)
        {
            if (Loginfield.Text == "" || Passfield2.Text == "" || Passfield.Text =="")
            {
                MessageBox.Show("Ви не ввели нічого");
                return;
            }
            if (checkU())
                return;
    
            MySqlCommand command  = new MySqlCommand("INSERT INTO users (login, pass) VALUES (@login,@pass);", database.GetConnection());
            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = Loginfield.Text;
           
            if (Passfield.Text == Passfield2.Text)
            {
                command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = Passfield2.Text;
                database.openCon();
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Ви успішно зареєструвалися");
                    log_in_Click(this,e);
                }
                else
                    MessageBox.Show("Упс шось пішло не так");
                database.closeCon();
            }
            else
                MessageBox.Show("Паролі не збігаються попробуйте знову");

        }
        public Boolean checkU()
        {
            
            var adapter = database.GetAdapter();
            MySqlCommand command = new MySqlCommand("SELECT* FROM `users` WHERE `login` = @uL", database.GetConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = Loginfield.Text;
          
            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Логін занятий, введіть інший");
                return true;
            }
            else
                return false;

        }

        private void log_in_Click(object sender, EventArgs e)
        {
            this.Hide();
            Notes form1 = new Notes();
            form1.Show();
        }

       
    }
}
