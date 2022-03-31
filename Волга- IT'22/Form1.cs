using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Волга__IT_22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Проверка на то, почта уже зарегистрирована или нет.
            //if (textBox1.Text == "Уже существующему email");
            string demo = "oskonbaev@gmail.com";
            if (textBox1.Text == demo) //Демо версия проверки почты
                MessageBox.Show("Эта почта уже зарегистрирована");

            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "") //Заполнены ли все поля
                MessageBox.Show("Пожалуйста, заполните все поля!");
            if (textBox2.Text != "" && textBox3.Text != "" && textBox2.Text != textBox3.Text) //Совпадают ли пароли
                MessageBox.Show("Пароли не совпадают!");
            if (textBox1.Text != "" && textBox1.Text != demo && textBox2.Text == textBox3.Text && textBox2.Text != "" && textBox3.Text != "") //Всё успешно
            {
                    Form2 frm = new Form2();
                    frm.Show();
            }
        }
    }
}
