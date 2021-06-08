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

namespace AuthLog
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();

            userName.Text = "Введите имя";
            userName.ForeColor = Color.Gray;
            loginField.Text = "Введите логин";
            loginField.ForeColor = Color.Gray;
            userSurname.Text = "Введите фамилию";
            userSurname.ForeColor = Color.Gray;
        }


        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        Point lastPoint;
        private void RegisterForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void RegisterForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void userName_Enter(object sender, EventArgs e)
        {
            if(userName.Text == "Введите имя")
            userName.Text = "";
        }

        private void userName_Leave(object sender, EventArgs e)
        {
            if(userName.Text == "")
            {
                userName.Text = "Введите имя";
                userName.ForeColor = Color.Gray;
            }
        }

        private void loginField_Enter(object sender, EventArgs e)
        {
            if (loginField.Text == "Введите логин")
                loginField.Text = "";
        }

        private void loginField_Leave(object sender, EventArgs e)
        {
            if(loginField.Text == "")
            {
                loginField.Text = "Введите логин";
                loginField.ForeColor = Color.Gray;
            }
        }
        

        private void userSurname_Enter(object sender, EventArgs e)
        {
            if (userSurname.Text == "Введите фамилию")
                userSurname.Text = "";
        }

        private void userSurname_Leave(object sender, EventArgs e)
        {
            if(userSurname.Text == "")
            {
                userSurname.Text = "Введите фамилию";
                userSurname.ForeColor = Color.Gray;
            }
        }

        private void register_Click(object sender, EventArgs e)
        {
            if (userName.Text == "Введите имя")
            {
                MessageBox.Show("Введите имя");
                return;
            }
            if (loginField.Text == "Введите логин")
            {
                MessageBox.Show("Введите логин");
                return;
            }
            if(userSurname.Text == "Введите фамилию")
            {
                MessageBox.Show("Введите фамилию");
                return;
            }
            if(passField.Text == "")
            {
                MessageBox.Show("Введите пароль");
                return;
            }
            if (checkUser())
                return;

            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `users_inform`.`users` (`login`, `password`, `name`, `surname`) VALUES (@login, @password, @name, @surname)", db.getConnection());
            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = loginField.Text;
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = passField.Text;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = userName.Text;
            command.Parameters.Add("@surname", MySqlDbType.VarChar).Value = userSurname.Text;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Аккаунт был создан");
            else
                MessageBox.Show("Аккаунт не был создан");

            db.closeConnection();
        }

        public Boolean checkUser() {
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users_inform`.`users` WHERE `login` = @uL", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginField.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Такой логин уже есть, введите другой");
                return true;
            }
            else
            return false;

        }

        private void registerLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            BG loginForm = new BG();
            loginForm.Show();
        }

    }
}
