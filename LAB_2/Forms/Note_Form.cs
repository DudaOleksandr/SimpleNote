using Autofac;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB_2.Forms
{
    public partial class Note_Form : Form
    {
        Autofac.IContainer container;
        IDataBase database;
        Table table;
        String Log,Note;
        public Note_Form(String Login_name)
        {
            InitializeComponent();
            this.table = new Table();
            this.container = Containers.Configure();
            this.database = container.Resolve<IDataBase>();
            database.openCon();
        
            this.label1.Text = Login_name;
            Log = Login_name;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
            Notes form1 = new Notes();
            form1.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Note = " " + textBox1.Text;

        }

        private void button1_Click(object sender, EventArgs e)
        {
                
                MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login`='" + Log + "'", database.GetConnection());
                var adapter = database.GetAdapter();                    
                var reader = database.GetReader(command);
                while (reader.Read())
                {
                    textBox2.Text = reader.GetString("information");
                   
                }
                reader.Close();
                adapter.SelectCommand = command;
                adapter.Fill(table);

            
        }
        
        private void button2_Click(object sender, EventArgs e)
        {

            database.openCon();
            //MySqlCommand command1 = new MySqlCommand("INSERT INTO users(information) WHERE `login`='" + Log + "' VALUES(@uText)", database.GetConnection());
            //command1.Parameters.Add("@uText", MySqlDbType.Text).Value = Note;
            
            String S = textBox2.Text + " " + textBox1.Text;         
            string S1 = $"UPDATE users SET information = '{S}' WHERE login = '" + Log + $"'";        
            MySqlCommand command = new MySqlCommand(S1, database.GetConnection());
            command.ExecuteNonQuery();


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Note += " " + textBox2.Text;
        }
    }
}
