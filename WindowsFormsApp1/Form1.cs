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



    public partial class Form1 : Form
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
                    label2.Text = "Что выведет программа?\r\nкод:\r\nstring s1 = \"Привет,\";\r\nstring s2 =  \"мир!\";\r\nstring s3 = s1 + s2;\r\nConsole.WriteLine(s3.Length);";
                    radioButton3.Text = $"10";
                    radioButton2.Text = $"11";
                    radioButton1.Text = $"12";//1

                    break;
                case 2:
                    label1.Text = $"Вопрос {n1}";
                    label2.Text = "Что выведет программа?\r\nкод:\r\nstring text = \"Hello! Have a good day!\";\r\nConsole.WriteLine(text.LastIndexOf(l));";
                    radioButton3.Text = $"3";//3
                    radioButton2.Text = $"4";
                    radioButton1.Text = $"2";
                    break;
                case 3:
                    label1.Text = $"Вопрос {n1}";
                    label2.Text = "Какие числа могут быть выведены в результате  программы?\r\nкод:\r\nRandom rnd = new Random();\r\nint value = rnd.Next(1, 3);\r\nConsole.WriteLine(value);";
                    radioButton3.Text = $"1, 3";
                    radioButton2.Text = $"1, 2";//2
                    radioButton1.Text = $"1, 2, 3";
                    break;
                case 4:
                    label1.Text = $"Вопрос {n1}";
                    label2.Text = "Если некоторые поля класса A\r\n должны быть доступны для методов класса B,\r\n являющегося потомком класса A,\r\nто эти поля следует снабдить атрибутом";
                    radioButton3.Text = $"private";
                    radioButton2.Text = $"public";
                    radioButton1.Text = $"protected";//1
                    break;
                case 5:
                    label1.Text = $"Вопрос {n1}";
                    label2.Text = "Выберите правильное утверждение";
                    radioButton3.Text = $"Деструктор вызывается автоматически в момент, предшествующий уничтожению объекта";//3
                    radioButton2.Text = $"Деструктор вызывается автоматически после уничтожения объекта";
                    radioButton1.Text = $"Деструктор вызывается автоматически после объявления объекта ";
                    break;
                case 6:
                    label1.Text = $"Вопрос {n1}";
                    label2.Text = "В регулярных выражения точка -";
                    radioButton3.Text = $"соответствует любому символу";
                    radioButton2.Text = $"соответствует любому символу, за исключением символа конца строки";//2
                    radioButton1.Text = $"соответствует любому множеству символов ";
                    break;
                case 7:
                    label1.Text = $"Вопрос {n1}";
                    label2.Text = "Является ли данный фрагмент кода перегрузкой?\r\nкод:\r\nint fun (int i, int j) {\r\nint k; …return k;" + "\r\n" + "int fun (double a) {\r\n int k; …return k;}";
                    radioButton3.Text = $"Да";//3
                    radioButton2.Text = $"нет, так как здесь разное количество аргументов";
                    radioButton1.Text = $"нет, так как имена должны быть разными";
                    break;
                case 8:
                    label1.Text = $"Вопрос {n1}";
                    label2.Text = "Что надо написать вместо ***, чтобы программа вывела 8?\r\nкод:\r\nint[] numbers = {5, 2, 6, 1, 8};\r\nint sum = 0;\r\nfor (int i = ***; i < 3; i++)\r\n{\r\nsum += numbers[i];\r\n}\r\nConsole.WriteLine(sum);";
                    radioButton3.Text = $"5";
                    radioButton2.Text = $"1";//2
                    radioButton1.Text = $"4";
                    break;
                case 9:
                    label1.Text = $"Вопрос {n1}";
                    label2.Text = "Что будет в результате работы данной программы?\r\nкод:\r\nint[,] numbers = {{ 5, 2, 6, 1, 7 }, { 5, 4, 6, 7, 9 }};\r\nint sum = 0;\r\nsum = numbers[0, 1] + numbers[1, 3];\r\nConsole.WriteLine(sum);";
                    radioButton3.Text = $"9";//3
                    radioButton2.Text = $"11";
                    radioButton1.Text = $"ошибка";
                    break;
                case 10:
                    label1.Text = $"Вопрос {n1}";
                    label2.Text = "Что выведет программа?\r\nstring str = \"Лимпопо\";\r\nstring strpat = \"по\";\r\nRegex pat = new Regex(strpat);\r\nMatchCollection match = pat.Matches(str);\r\nConsole.WriteLine(match.Count);";
                    radioButton3.Text = $"0";
                    radioButton2.Text = $"1";
                    radioButton1.Text = $"2";//1
                    break;
                case 11:
                    label1.Text = $"Вопрос {n1}";
                    label2.Text = "Что выведет программа?\r\nint[] a = { 3, 6, 5, -3, 2, -4 };\r\nint sum = 0; \r\nforeach (int elem in a)\r\nsum+=elem\r\nConsole.WriteLine(sum);";
                    radioButton3.Text = $"23";
                    radioButton2.Text = $"9";//2
                    radioButton1.Text = $"10";
                    break;
                case 12:
                    label1.Text = $"Вопрос {n1}";
                    label2.Text = "Что выведет программа?\r\nint n = Convert.ToInt32(16);\r\nbool b = true;\r\nConsole.WriteLine($\"n={n} d={d}\");\r\n";
                    radioButton3.Text = $"n=16 d=0";//3
                    radioButton2.Text = $"n=16 d=1";
                    radioButton1.Text = $"Выдаст ошибку";
                    break;
                case 13:
                    label1.Text = $"Вопрос {n1}";
                    label2.Text = "Что выведет программа?\r\nint b = -63;\r\nbool d = true;\r\nConsole.Write(!d);\r\nConsole.Write();\r\nConsole.Write(~b);";
                    radioButton3.Text = $"True 63";
                    radioButton2.Text = $"False 63";
                    radioButton1.Text = $"False 62";//1
                    break;
                case 14:
                    label1.Text = $"Вопрос {n1}";
                    label2.Text = "Что выведет программа?\r\nfloat z = 4;\r\nConsole.WriteLine(z * 1e308);";
                    radioButton3.Text = $"Выдаст ошибку ";
                    radioButton2.Text = $"?";//2
                    radioButton1.Text = $"4000";
                    break;
                case 15:
                    label1.Text = $"Вопрос {n1}";
                    label2.Text = "Для чего используется TextBox в WPF?";
                    radioButton3.Text = $"Для ввода данных пользователем";//3
                    radioButton2.Text = $"Для записи туда чего-либо,чтоб это читал пользователь";
                    radioButton1.Text = $"Нет верного ответа.";
                    break;
                case 16:
                    label1.Text = $"Вопрос {n1}";
                    label2.Text = "Для передвежения между страницами в WPF\r\nс помощью метода Navigation надо использовать:";
                    radioButton3.Text = $"NavigationService.NewPage1()";
                    radioButton2.Text = $"NavigationService.Navigate(new ...)";//2
                    radioButton1.Text = $"NavigationService.Refresh(new...);";
                    break;
                case 17:
                    label1.Text = $"Вопрос {n1}";
                    label2.Text = "Можно ли в WPF добавлять картинки с .gif?";
                    radioButton3.Text = $"Нет,она сразу превратится в .png";
                    radioButton2.Text = $"Нет,выдаст ошибку,это же гифка.";
                    radioButton1.Text = $"Да";//1
                    break;
                case 18:
                    label1.Text = $"Вопрос {n1}";
                    label2.Text = "Можно ли использовать гиперссылки в WPF?";
                    radioButton3.Text = $"Нельзя";
                    radioButton2.Text = $"Можно";//2
                    radioButton1.Text = $"Раньше это было возможно,но с последними обновлениями такая возможность пропала ";
                    break;
                case 19:
                    label1.Text = $"Вопрос {n1}";
                    label2.Text = "В каком году появился язык с#?";
                    radioButton3.Text = $"2001";//3
                    radioButton2.Text = $"2002";
                    radioButton1.Text = $"1997";
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

        public Form1()
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
            if (answer[0] == 2)
                correct++;
            if (answer[1] == 1)
                correct++;
            if (answer[2] == 3)
                correct++;
            if (answer[3] == 2)
                correct++;
            if (answer[4] == 1)
                correct++;
            if (answer[5] == 3)
                correct++;
            if (answer[6] == 2)
                correct++;
            if (answer[7] == 3)
                correct++;
            if (answer[8] == 2)
                correct++;
            if (answer[9] == 3)
                correct++;
            if (answer[10] == 1)
                correct++;
            if (answer[11] == 2)
                correct++;
            if (answer[12] == 3)
                correct++;
            if (answer[13] == 1)
                correct++;
            if (answer[14] == 2)
                correct++;
            if (answer[15] == 3)
                correct++;
            if (answer[16] == 2)
                correct++;
            if (answer[17] == 1)
                correct++;
            if (answer[18] == 2)
                correct++;
            if (answer[19] == 3)
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
                    File.AppendAllText(@"C:\Users\Public\Variant1.txt", "Имя:" + text + "\n" + "Оценка:" + 5 + " Ваши баллы:" + correct + "\n");
                    Form_o5 frm = new Form_o5();
                    frm.Show();
                    this.Hide();
                }
                else if (correct >= 15 && correct <= 17)
                {
                    MessageBox.Show($"Вы ответили верно на {correct} из 20 вопросов. Ваша оценка 4");
                    string strWrite = "Имя:" + text;
                    File.AppendAllText(@"C:\Users\Public\Variant1.txt", "Имя:" + text + "\n" + "Оценка:" + 4 + " Ваши баллы:" + correct + "\n");
                    Form_o4 frm = new Form_o4();
                    frm.Show();
                    this.Hide();
                }
                else if (correct >= 10 && correct <= 14)
                {
                    MessageBox.Show($"Вы ответили верно на {correct} из 20 вопросов. Ваша оценка 3");
                    string strWrite = "Имя:" + text;
                    File.AppendAllText(@"C:\Users\Public\Variant1.txt", "Имя:" + text + "\n" + "Оценка:" + 3 + " Ваши баллы:" + correct + "\n");
                    Form_o3 frm = new Form_o3();
                    frm.Show();
                    this.Hide();
                }
                else if (correct <= 9)
                {

                    MessageBox.Show($"Вы ответили верно на {correct} из 20 вопросов. Ваша оценка 2");
                    string strWrite = "Имя:" + text;
                    File.AppendAllText(@"C:\Users\Public\Variant1.txt", "Имя:" + text + "\n" + "Оценка:" + 2 + " Ваши баллы:" + correct + "\n");
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }


}
