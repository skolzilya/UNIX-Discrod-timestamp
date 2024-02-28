using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace UNIX_Discrod_timestamp
{
    public partial class Forma : Form
    {
        public Forma()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            bool[] arr = new bool[8] {checkBox1.Checked, checkBox2.Checked, checkBox3.Checked, checkBox4.Checked, checkBox5.Checked, checkBox6.Checked, checkBox7.Checked, checkBox8.Checked };

             for (int i = 0; i < arr.GetLength(0); i++)
             {
                if (arr[i] == true)
                {
                    if (i == 0)
                    {
                        DateTimeOffset Deafult = dateTimePicker1.Value;
                        textBox1.Text += Environment.NewLine + checkBox1.Text + " " + "<t:" + Deafult.ToUnixTimeSeconds() + ">" + '\n';
                        arr[i] = false;
                    }
                    if (i == 1)
                    {
                        DateTimeOffset Deafult = dateTimePicker1.Value;
                        textBox1.Text += Environment.NewLine + checkBox2.Text + " " + "<t:" + Deafult.ToUnixTimeSeconds() + ":t>" + '\n';
                        arr[i] = false;
                    }
                    if (i == 2)
                    {
                        DateTimeOffset Deafult = dateTimePicker1.Value;
                        textBox1.Text += Environment.NewLine + checkBox3.Text + " " + "<t:" + Deafult.ToUnixTimeSeconds() + ":T>" + '\n';
                        arr[i] = false;
                    }
                    if (i == 3)
                    {
                        DateTimeOffset Deafult = dateTimePicker1.Value;
                        textBox1.Text += Environment.NewLine + checkBox4.Text + " " + "<t:" + Deafult.ToUnixTimeSeconds() + ":d>" + '\n';
                        arr[i] = false;
                    }
                    if (i == 4)
                    {
                        DateTimeOffset Deafult = dateTimePicker1.Value;
                        textBox1.Text += Environment.NewLine + checkBox5.Text + " " + "<t:" + Deafult.ToUnixTimeSeconds() + ":D>" + '\n';
                        arr[i] = false;
                    }
                    if (i == 5)
                    {
                        DateTimeOffset Deafult = dateTimePicker1.Value;
                        textBox1.Text += Environment.NewLine + checkBox6.Text + " " + "<t:" + Deafult.ToUnixTimeSeconds() + ":f>" + '\n';
                        arr[i] = false;
                    }
                    if (i == 6)
                    {
                        DateTimeOffset Deafult = dateTimePicker1.Value;
                        textBox1.Text += Environment.NewLine + checkBox7.Text + " " + "<t:" + Deafult.ToUnixTimeSeconds() + ":F>" + '\n';
                        arr[i] = false;
                    }
                    if (i == 7)
                    {
                        DateTimeOffset Deafult = dateTimePicker1.Value;
                        textBox1.Text += Environment.NewLine + checkBox8.Text + " " + "<t:" + Deafult.ToUnixTimeSeconds() + ":R>" + '\n';
                        arr[i] = false;
                    }
                }
             }
        }
    }
}
