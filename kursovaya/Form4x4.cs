using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursovaya
{
    public partial class Form4x4 : Form
    {
        public Form4x4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int а1 = int.Parse(textBox1.Text);
            int б1 = int.Parse(textBox2.Text);
            int в1 = int.Parse(textBox3.Text);
            int г1 = int.Parse(textBox4.Text);
            int а2 = int.Parse(textBox5.Text);
            int б2 = int.Parse(textBox6.Text);
            int в2 = int.Parse(textBox7.Text);
            int г2 = int.Parse(textBox8.Text);
            int а3 = int.Parse(textBox9.Text);
            int б3 = int.Parse(textBox10.Text);
            int в3 = int.Parse(textBox11.Text);
            int г3 = int.Parse(textBox12.Text);
            int а4 = int.Parse(textBox13.Text);
            int б4 = int.Parse(textBox14.Text);
            int в4 = int.Parse(textBox15.Text);
            int г4 = int.Parse(textBox16.Text);

            //textBox17.Text += $"X2      0  1  0  1   2  0  1   2   3  0  1    2   3   4" + Environment.NewLine;
            //textBox17.Text += $"Y2(x2)  0  {б1}  0  {б1}  {б2}  0  {б1}  {б2}  {б3}  0  {б1}  {б2}  {б3}  {б4}" + Environment.NewLine;
            //textBox17.Text += $"f1(x-x2)  {а1}  0  {а2}  {а1}  0  {а3}  {а2}  {а1}  0  {а4}  {а3}  {а2}  {а1}  0" + Environment.NewLine;
            //textBox17.Text += $"Y2+f1  {а1}  {б1}     {а2}  {б1+а1}  {б2}    {а3}  {б1+а2}  {б2+а1}  {б3}    {а4}  {б1+а3}  {б2+а2}  {б3+а1}  {б4}" + Environment.NewLine;
            int а11 = Math.Min(а1, б1);
            int б11 = new[] { а2, б1 + а1, б2 }.Min();
            int в11 = new[] { а3, б3, б1 + а2, б2 + а1}.Min();
            int г11 = new[] { а4, б4, б1 + а3, б2 + а2, б3 + а1 }.Min();
            //textBox17.Text += $"F2(x)  {а11}   {б11}   {в11}   {г11}" + Environment.NewLine;

            //textBox17.Text += "--------------------------------------------------------" + Environment.NewLine;

            //textBox17.Text += $"X3      0  1  0  1   2  0  1   2   3  0  1    2   3   4" + Environment.NewLine;
            //textBox17.Text += $"Y3(x3)  0  {в1}  0  {в1}  {в2}  0  {в1}  {в2}  {в3}  0  {в1}  {в2}  {в3}  {в4}" + Environment.NewLine;
            //textBox17.Text += $"f2(x-x3)  {а11}  0   {б11} {а11} 0 {в11} {б11} {а11} 0 {г11} {в11} {б11} {а11} 0" + Environment.NewLine;
            //textBox17.Text += $"Y3+f2  {а11} {в1}   {б11} {а11+ в1} {в2}   {в11} {б11+в1} {а11+в2} {в3}   {г11} {в11+в1} {б11+в2} {а11+в3} {в4}" + Environment.NewLine;
            int а22 = Math.Min(а11, в1);
            int б22 = new[] { б11, а11 + в1, в2 }.Min(); 
            int в22 = new[] { в11, б11 + в1, а11 + в2, в3 }.Min(); 
            int г22 = new[] { г11, в11 + в1, б11 + в2, а11 + в3, в4 }.Min();
            //textBox17.Text += $"F3(x)  {а22}   {б22}   {в22}   {г22}" + Environment.NewLine;

            //textBox17.Text += "--------------------------------------------------------" + Environment.NewLine;

            //textBox17.Text += $"X3      0  1  0  1   2  0  1   2   3  0  1    2   3   4" + Environment.NewLine;
            //textBox17.Text += $"Y4(x4)  0  {г1}  0  {г1}  {г2}  0  {г1}  {г2}  {г3}  0  {г1}  {г2}  {г3}  {г4}" + Environment.NewLine;
            //textBox17.Text += $"f3(x-x4)  {а22}  0   {б22} {а22} 0 {в22} {б22} {а22} 0 {г22} {в22} {б22} {а22} 0" + Environment.NewLine;
            //textBox17.Text += $"Y4+f3  {а22} {г1}   {б22} {а22+г1} {г2}   {в22} {б22+г1} {г2+а22} {г3}   {г22} {г1+в22} {г2+б22} {г3+а22} {г4}" + Environment.NewLine;
            int а33 = Math.Min(а22, г1);
            int б33 = new[] { б22, а22 + г1, г2 }.Min(); 
            int в33 = new[] { в22, б22 + г1, г2 + а22, г3 }.Min();
            int г33 = new[] { г22, г1 + в22, г2 + б22, г3 + а22, г4 }.Min();
            //textBox17.Text += $"F4(x)  {а33}     {б33}   {в33}   {г33}" + Environment.NewLine;
            textBox17.Text += $"Минимальное значение суммарных затрат равно {г33}" + Environment.NewLine;

            if (г33 != 0)
                {
                var числовыеПеременные = new Dictionary<string, int>
                {
                    {"а22", а22},{"г1", г1},{"б22", б22},{"а22+г1", а22 + г1},{"г2", г2},{"в22", в22},{"б22+г1", б22 + г1},{"г2+а22", г2 + а22},{"г3", г3},{"г22", г22},{"г1+в22", г1 + в22},{"г2+б22", г2 + б22},{"г3+а22", г3 + а22},{"г4", г4}
                };
                string matchingVariable = числовыеПеременные.FirstOrDefault(pair => pair.Value == г33).Key;

                int stolbik = 0;
                int stroka = 0;
                if (matchingVariable == "а22") { stolbik = 0; stroka = 1; }
                if (matchingVariable == "г1") { stolbik = 1; stroka = 1;  }
                if (matchingVariable == "б22") { stolbik = 0; stroka = 2; }
                if (matchingVariable == "а22+г1") { stolbik = 1; stroka = 2; }
                if (matchingVariable == "г2") { stolbik = 2; stroka = 2; }
                if (matchingVariable == "в22") { stolbik = 0; stroka = 3; }
                if (matchingVariable == "б22+г1") { stolbik = 1; stroka = 3; }
                if (matchingVariable == "г2+а22") { stolbik = 2; stroka = 3; }
                if (matchingVariable == "г3") { stolbik = 3; stroka = 3; }
                if (matchingVariable == "г22") { stolbik = 0; stroka = 4; }
                if (matchingVariable == "г1+в22") { stolbik = 1; stroka = 4; }
                if (matchingVariable == "г2+б22") { stolbik = 2; stroka = 4; }
                if (matchingVariable == "г3+а22") { stolbik = 3; stroka = 4; }
                if (matchingVariable == "г4") { stolbik = 4; stroka = 4; }
                if (stolbik != 0) { textBox17.Text += $"Оборудование №4 выполняет V={stolbik}" + Environment.NewLine; }
                if (stolbik == 1) { г33 -= г1; }
                if (stolbik == 2) { г33 -= г2; }
                if (stolbik == 3) { г33 -= г3; }
                if (stolbik == 4) { г33 -= г4; }
                if (г33 == 0) { goto END; }
            }

            if (г33 != а11 && г33 != б11 && г33 != в11 && г33 != г11)
                {
                int matchingVariable = 0; // объявляем переменную здесь
                int[] переменные = { а22, б22, в22, г22 };
                foreach (int переменная in переменные)
                {
                    if (г33 == переменная)
                    {
                        matchingVariable = переменная;
                        break;
                    }
                }
                int stolbik = 0;
                int stroka = 0;
                if (matchingVariable == а11) { stolbik = 0; stroka = 1;}
                if (matchingVariable == в1) { stolbik = 1; stroka = 1; }
                if (matchingVariable == б11) { stolbik = 0; stroka = 2; }
                if (matchingVariable == а11+ в1) { stolbik = 1; stroka = 2; }
                if (matchingVariable == в2) { stolbik = 2; stroka = 2; }
                if (matchingVariable == в11) { stolbik = 0; stroka = 3; }
                if (matchingVariable == б11+в1) { stolbik = 1; stroka = 3; }
                if (matchingVariable == а11+в2) { stolbik = 2; stroka = 3; }
                if (matchingVariable == в3) { stolbik = 3; stroka = 3; }
                if (matchingVariable == г11) { stolbik = 0; stroka = 4; }
                if (matchingVariable == в11+в1) { stolbik = 1; stroka = 4; }
                if (matchingVariable == б11+в2) { stolbik = 2; stroka = 4; }
                if (matchingVariable == а11+в3) { stolbik = 3; stroka = 4; }
                if (matchingVariable == в4) { stolbik = 4; stroka = 4; }
                textBox17.Text += $"Оборудование №3 выполняет V={stolbik}" + Environment.NewLine;
                if (stolbik == 1) { г33 -= в1;  }
                if (stolbik == 2) { г33 -= в2;  }
                if (stolbik == 3) { г33 -= в3; }
                if (stolbik == 4) { г33 -= в4; }
                if (г33 == 0) { goto END; }
            }

            if (г33 != 0)
            {
                int matchingVariable = 0; // объявляем переменную здесь
                int[] переменные = { а11, б11, в11, г11 };
                foreach (int переменная in переменные)
                {
                    if (г33 == переменная)
                    {
                        matchingVariable = переменная;
                        break;
                    }
                }
                int stolbik = 0;
                int stroka = 0;
                if (matchingVariable == а1) { stolbik = 0; stroka = 1; }
                if (matchingVariable == б1) { stolbik = 1; stroka = 1; }
                if (matchingVariable == а2) { stolbik = 0; stroka = 2; }
                if (matchingVariable == б1 + а1) { stolbik = 1; stroka = 2; }
                if (matchingVariable == б2) { stolbik = 2; stroka = 2; }
                if (matchingVariable == а3) { stolbik = 0; stroka = 3; }
                if (matchingVariable == б1 + а2) { stolbik = 1; stroka = 3; }
                if (matchingVariable == б2 + а1) { stolbik = 2; stroka = 3; }
                if (matchingVariable == б3) { stolbik = 3; stroka = 3; }
                if (matchingVariable == а4) { stolbik = 0; stroka = 4; }
                if (matchingVariable == б1 + а3) { stolbik = 1; stroka = 4; }
                if (matchingVariable == б2 + а2) { stolbik = 2; stroka = 4; }
                if (matchingVariable == б3 + а1) { stolbik = 3; stroka = 4; }
                if (matchingVariable == б4) { stolbik = 4; stroka = 4; }
                if (stolbik != 0) { textBox17.Text += $"Оборудование №2 выполняет V={stolbik}" + Environment.NewLine; }
                if (stolbik == 1) { г33 -= б1; }
                if (stolbik == 2) { г33 -= б2;  }
                if (stolbik == 3) { г33 -= б3; }
                if (stolbik == 4) { г33 -= б4;  }
                if (г33 == 0) { goto END; }
            }

            if (г33 != 0)
            {
                if (г33 == а1) { textBox17.Text += $"Оборудование №1 выполняет V=1" + Environment.NewLine; }
                if (г33 == а2) { textBox17.Text += $"Оборудование №1 выполняет V=2" + Environment.NewLine; }
                if (г33 == а3) { textBox17.Text += $"Оборудование №1 выполняет V=3" + Environment.NewLine; }
                if (г33 == а4) { textBox17.Text += $"Оборудование №1 выполняет V=4" + Environment.NewLine; }
            }

        END: textBox17.Text += $"" + Environment.NewLine;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox17.Clear();
        }
    }
}