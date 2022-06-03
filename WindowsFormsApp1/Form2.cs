using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        int n = 0;
        int[] answer;


        public void show(int n)
        {

            int n1 = n + 1;

            switch (n)
            {
                case 0:
                    break;
                case 1:
                    label1.Visible = true;
                    label1.Text = $"Вопрос {n1}";
                    label2.Text = "Что выведет программа:\r\nкод:\r\nstring s1 = \"35\"\r\nstring s2 =  \"30\";\r\nstring s3 = s1 + s2;\r\nConsole.WriteLine(s3);";
                    radioButton1.Text = $"65";
                    radioButton2.Text = $"3035";
                    radioButton3.Text = $"3530";//3

                    break;
                case 2:
                    label1.Text = $"Вопрос {n1}";
                    label2.Text = "Что выведет программа:\r\nкод:\r\nstring text = Hello! Have a good day!;\r\nConsole.WriteLine(text.Replace(\"l\", \"f\"));";
                    radioButton1.Text = $"Hello! Have a good day!";
                    radioButton2.Text = $"Helfo! Have a good day!";
                    radioButton3.Text = $"Heffo! Have a good day!";//3
                    break;
                case 3:
                    label1.Text = $"Вопрос {n1}";
                    label2.Text = "Какие числа могут быть выведены в результате работы данной программы?\r\nкод:\r\nRandom rnd = new Random();\r\nint value = rnd.Next(1, 4);\r\nConsole.WriteLine(value);";
                    radioButton1.Text = $"1, 2, 3"; //1
                    radioButton2.Text = $"1, 2";
                    radioButton3.Text = $"1,4";
                    break;
                case 4:
                    label1.Text = $"Вопрос {n1}";
                    label2.Text = "Если некоторые поля класса A должны быть доступны для методов класса B,\r\n являющегося потомком класса A,\r\nто эти поля следует снабдить атрибутом?";
                    radioButton1.Text = $"private";
                    radioButton2.Text = $"public";
                    radioButton3.Text = $"protected";//3
                    break;
                case 5:
                    label1.Text = $"Вопрос {n1}";
                    label2.Text = "Какая константа чаще всего используется в регулярных выражениях?";
                    radioButton1.Text = $"%-константа";
                    radioButton2.Text = $"@-константа";//2
                    radioButton3.Text = $"$-константа";
                    break;
                case 6:
                    label1.Text = $"Вопрос {n1}";
                    label2.Text = "Что надо написать вместо ***, чтобы программа вывела 7?\r\nкод:\r\nint[] numbers = {5, 2, 6, 1, 7};\r\nint sum = 0;\r\nfor (int i = ***; i < 4; i++)\r\n{\r\nsum += numbers[i];\r\n}\r\nConsole.WriteLine(sum);";
                    radioButton1.Text = $"2";//1
                    radioButton2.Text = $"4";
                    radioButton3.Text = $"5";
                    break;
                //8
                case 7:
                    label1.Text = $"Вопрос {n1}";
                    label2.Text = "Что выведет программа?\r\nDateTime dt = DateTime.Now;\r\nConsole.WriteLine(dt);";
                    radioButton1.Text = $"Текущее время";
                    radioButton2.Text = $"Текущую дату";
                    radioButton3.Text = $"Текущее дату и время";//3
                    break;
                case 8:
                    label1.Text = $"Вопрос {n1}";
                    label2.Text = "Что выведет программа?\r\nRegex r = new Regex(@\"(Венера)\");\r\nstring s = \"ВенераВенераВенераЮпитер\";\r\ns = r.Replace(s, \" - \", 2, 1);\r\nConsole.WriteLine(s);";
                    radioButton1.Text = $"Венера-Юпитер";
                    radioButton2.Text = $"Венера--Юпитер";//2
                    radioButton3.Text = $"ВенераВенера-Юпитер";
                    break;
                case 9:
                    label1.Text = $"Вопрос {n1}";
                    label2.Text = "Что выведет программа?\r\ndouble a = 1e-324 ;\r\ndouble b = 1e-324;\r\ndouble c = a / b;\r\nConsole.WriteLine(c);";
                    radioButton1.Text = $"не число";//1
                    radioButton2.Text = $"1";
                    radioButton3.Text = $"0";
                    break;
                case 10:
                    label1.Text = $"Вопрос {n1}";
                    label2.Text = "Что выведет программа?\r\nbyte a = 3;\r\nConsole.WriteLine(a<<1);";
                    radioButton1.Text = $"0";
                    radioButton2.Text = $"6";//2
                    radioButton3.Text = $"3";
                    break;
                case 11:
                    label1.Text = $"Вопрос {n1}";
                    label2.Text = "Что выведет программа?\r\nint[] a = { 3, 6, 5, -3, 2, -4 };\r\nint sum = 0; \r\nforeach (int elem in a)\r\nsum+=elem\r\nConsole.WriteLine(sum);";
                    radioButton1.Text = $"23";
                    radioButton2.Text = $"9";//2
                    radioButton3.Text = $"10";
                    break;
                case 12:
                    label1.Text = $"Вопрос {n1}";
                    label2.Text = "Что выведет программа?\r\nstring tatu = \"Нас не догонят!\";\r\nstring n = \"Нас\";\r\nstring s = tatu - n;\r\nConsole.WriteLine(s);";
                    radioButton1.Text = $"Выдаст ошибку";//1
                    radioButton2.Text = $"не догонят!";
                    radioButton3.Text = $"Нас не догонят!";
                    break;
                case 13:
                    label1.Text = $"Вопрос {n1}";
                    label2.Text = "Какой язык разметки испотльзуется в WPF?";
                    radioButton1.Text = $"HTML";
                    radioButton2.Text = $"XML";
                    radioButton3.Text = $"XAML";//3
                    break;
                case 14:
                    label1.Text = $"Вопрос {n1}";
                    label2.Text = "Что выведет программа?\r\nfloat z = 4;\r\nConsole.WriteLine(z * 1e308);";
                    radioButton1.Text = $"Выдаст ошибку ";
                    radioButton2.Text = $"?";//2
                    radioButton3.Text = $"4000";
                    break;
                case 15:
                    label1.Text = $"Вопрос {n1}";
                    label2.Text = "Для чего используется TextBox в WPF?";
                    radioButton1.Text = $"Для ввода данных пользователем";//1
                    radioButton2.Text = $"Для записи туда чего-либо,чтоб это читал пользователь";
                    radioButton3.Text = $"Нет верного ответа.";
                    break;
                case 16:
                    label1.Text = $"Вопрос {n1}";
                    label2.Text = "Для передвежения между страницами в WPF\r\n с помощью метода Navigation надо использовать:";
                    radioButton1.Text = $"NavigationService.NewPage1()";
                    radioButton2.Text = $"NavigationService.Navigate(new ...)";//2
                    radioButton3.Text = $"NavigationService.Refresh(new...);";
                    break;
                case 17:
                    label1.Text = $"Вопрос {n1}";
                    label2.Text = "Можно ли в WPF добавлять картинки с .gif?";
                    radioButton1.Text = $"Нет,она сразу превратится в .png";
                    radioButton2.Text = $"Да";//2
                    radioButton3.Text = $"Нет,выдаст ошибку,это же гифка.";
                    break;
                case 18:
                    label1.Text = $"Вопрос {n1}";
                    label2.Text = "Можно ли использовать гиперссылки в WPF?";
                    radioButton1.Text = $"Нельзя";
                    radioButton2.Text = $"Можно";//2
                    radioButton3.Text = $"Раньше это было возможно,но с последними обновлениями такая возможность пропала ";
                    break;
                case 19:
                    label1.Text = $"Вопрос {n1}";
                    label2.Text = "В каком году появился язык с#?";
                    radioButton1.Text = $"2001";//1
                    radioButton2.Text = $"2002";
                    radioButton3.Text = $"1997";
                    break;



                case 20:
                    radioButton1.Hide();
                    radioButton2.Hide();
                    radioButton3.Hide();
                    button1.Hide();
                    label1.Hide();
                    label2.Hide();
                    button3.Visible = true;
                    label3.Visible = true;
                    textBox1.Visible = true;

                    break;
            }
        }

        public Form2()
        {

            InitializeComponent();
            answer = new int[21];
            button3.Hide();
            label3.Hide();
            textBox1.Hide();


        }
        public void count(int n)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            n++;
            if (n > 20) n = 20;
            show(n);
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int correct = 0;
            if (answer[0] == 1)
                correct++;
            if (answer[1] == 3)
                correct++;
            if (answer[2] == 3)
                correct++;
            if (answer[3] == 1)
                correct++;
            if (answer[4] == 3)
                correct++;
            if (answer[5] == 2)
                correct++;
            if (answer[6] == 1)
                correct++;
            if (answer[7] == 3)
                correct++;
            if (answer[8] == 2)
                correct++;
            if (answer[9] == 1)
                correct++;
            if (answer[10] == 2)
                correct++;
            if (answer[11] == 2)
                correct++;
            if (answer[12] == 1)
                correct++;
            if (answer[13] == 3)
                correct++;
            if (answer[14] == 2)
                correct++;
            if (answer[15] == 1)
                correct++;
            if (answer[16] == 2)
                correct++;
            if (answer[17] == 2)
                correct++;
            if (answer[18] == 2)
                correct++;
            if (answer[19] == 1)
                correct++;

            int prcmt = correct;

            string text = textBox1.Text;
            if (textBox1.Text.Length < 4)
                MessageBox.Show("Данные введены с ошибкой!");
            else if (textBox1.Text.Length >= 4)
            {
                button3.Hide();
                if (correct >= 18)
                {
                    MessageBox.Show($"Вы ответили верно на {correct} из 20 вопросов. Ваша оценка 5");
                    string strWrite = "Имя:" + text;
                    File.AppendAllText(@"C:\Users\Public\Variant2.txt", "Имя:" + text + "\n" + "Оценка:" + 5 + " Ваши баллы:" + correct + "\n");
                    Form_o5 frm = new Form_o5();
                    frm.Show();
                    this.Hide();
                }
                else if (correct >= 15 && correct <= 17)
                {
                    MessageBox.Show($"Вы ответили верно на {correct} из 20 вопросов. Ваша оценка 4");
                    string strWrite = "Имя:" + text;
                    File.AppendAllText(@"C:\Users\Public\Variant2.txt", "Имя:" + text + "\n" + "Оценка:" + 4 + " Ваши баллы:" + correct + "\n");
                    Form_o4 frm = new Form_o4();
                    frm.Show();
                    this.Hide();
                }
                else if (correct >= 10 && correct <= 14)
                {
                    MessageBox.Show($"Вы ответили верно на {correct} из 20 вопросов. Ваша оценка 3");
                    string strWrite = "Имя:" + text;
                    File.AppendAllText(@"C:\Users\Public\Variant2.txt", "Имя:" + text + "\n" + "Оценка:" + 3 + " Ваши баллы:" + correct + "\n");
                    Form_o3 frm = new Form_o3();
                    frm.Show();
                    this.Hide();
                }
                else if (correct <= 9)
                {

                    MessageBox.Show($"Вы ответили верно на {correct} из 20 вопросов. Ваша оценка 2");
                    string strWrite = "Имя:" + text;
                    File.AppendAllText(@"C:\Users\Public\Variant2.txt", "Имя:" + text + "\n" + "Оценка:" + 2 + " Ваши баллы:" + correct + "\n");
                    Form_o2 frm = new Form_o2();
                    frm.Show();
                    this.Hide();
                }

            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            answer[n] = 1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            answer[n] = 2;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            answer[n] = 3;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Form2_Load_1(object sender, EventArgs e)
        {

        }
    }
}
