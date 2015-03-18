﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double num1; 
        double ans;
        int count;

        // 1
        private void button1_Click(object sender, EventArgs e){textBox1.Text = textBox1.Text + 1;}

        // 2
        private void button2_Click(object sender, EventArgs e){textBox1.Text = textBox1.Text + 2;}

        // 3
        private void button3_Click(object sender, EventArgs e){textBox1.Text = textBox1.Text + 3;}

        // 4
        private void button4_Click(object sender, EventArgs e){textBox1.Text = textBox1.Text + 4;}

        // 5 
        private void button5_Click(object sender, EventArgs e){textBox1.Text = textBox1.Text + 5;}

        // 6
        private void button6_Click(object sender, EventArgs e){textBox1.Text = textBox1.Text + 6;}
        
        // 7
        private void button7_Click(object sender, EventArgs e){textBox1.Text = textBox1.Text + 7;}

        // 8
        private void button8_Click(object sender, EventArgs e){textBox1.Text = textBox1.Text + 8;}

        // 9
        private void button9_Click(object sender, EventArgs e){textBox1.Text = textBox1.Text + 9;}

        // 0
        private void button10_Click(object sender, EventArgs e){textBox1.Text = textBox1.Text + 0;}

        // "="
        private void button16_Click(object sender, EventArgs e){
            compute(count);
        }
        public void compute(int count){
            switch (count){
                case 1:
                    ans = num1 - Double.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    break;
                case 2:
                    ans = num1 + float.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    break;
                case 3:
                    ans = num1 * float.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    break;
                case 4:
                    ans = num1 / float.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    break;
                case 5:
                    ans = num1 % float.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    break;
                case 6:
                    ans = Math.Pow(num1, Double.Parse(textBox1.Text));
                    textBox1.Text = ans.ToString();
                    break;
                default:
                    break;
            }
        }
        // Adição
        private void button13_Click(object sender, EventArgs e){
            if (textBox1.Text != ""){
                num1 = float.Parse(textBox1.Text);
                textBox1.Clear();
                textBox1.Focus();
                count = 2;
            }   
        }

        // "."
        private void button11_Click(object sender, EventArgs e){
            int c = textBox1.TextLength;
            int flag = 0;
            string text = textBox1.Text;
            for (int i = 0; i < c; i++){
                if (text[i].ToString() == ".") { flag = 1; break; } else { flag = 0; }}
                    if (flag == 0) { textBox1.Text = textBox1.Text + "."; }}

        // Subtração
        private void button12_Click(object sender, EventArgs e){
            num1 = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 1; 
        }

        // Multiplicação
        private void button14_Click(object sender, EventArgs e){
            num1 = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 3; 
        }

        // Divisão
        private void button15_Click(object sender, EventArgs e){
            num1 = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 4; 
        }

        // "C"
        private void button17_Click(object sender, EventArgs e){
            textBox1.Clear();
            count = 0; 
        }

        // "Raiz²"
        private void button18_Click(object sender, EventArgs e){
            double sqrt = Math.Sqrt(float.Parse(textBox1.Text));
            textBox1.Text = sqrt.ToString();
        }

        // Resto da Divisão
        private void button19_Click(object sender, EventArgs e){
            num1 = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 5;
        }

        // Potenciação
        private void button20_Click(object sender, EventArgs e){
            num1 = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 6;
        }

        // Seno
        private void button21_Click(object sender, EventArgs e){
            double seno = Math.Sin(float.Parse(textBox1.Text));
            textBox1.Text = seno.ToString();
        }

        // Cosseno
        private void button22_Click(object sender, EventArgs e){
            double Cosseno = Math.Cos(float.Parse(textBox1.Text));
            textBox1.Text = Cosseno.ToString();
        }

        // Tangente
        private void button23_Click(object sender, EventArgs e){
            double Tangente = Math.Tan(float.Parse(textBox1.Text));
            textBox1.Text = Tangente.ToString();
        }

        // Apagar
        private void button24_Click(object sender, EventArgs e)
        {
            int lenght = textBox1.TextLength - 1;
            string text = textBox1.Text;  
            textBox1.Clear();
            for (int i = 0; i < lenght; i++)
                textBox1.Text = textBox1.Text + text[i]; 
        }

        // CE
        private void button25_Click(object sender, EventArgs e){
            if (num1 == 0 && textBox1.TextLength > 0)
            { num1 = 0; textBox1.Clear(); }
            else if (num1 > 0 && textBox1.TextLength > 0)
            { textBox1.Clear(); }
        }

    }
}
