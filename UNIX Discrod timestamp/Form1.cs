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
            //DateTimeOffset dto = new DateTimeOffset(1970, 1, 1, 0, 0, 0, TimeSpan.Zero);
            bool[] arr = new bool[8] {checkBox1.Checked, checkBox2.Checked, checkBox3.Checked, checkBox4.Checked, checkBox5.Checked, checkBox6.Checked, checkBox7.Checked, checkBox8.Checked };
            /*  arr[0] = checkBox1.Checked;
                arr[1] = checkBox2.Checked;
                arr[2] = checkBox3.Checked;
                arr[3] = checkBox4.Checked;
                arr[4] = checkBox5.Checked;
                arr[5] = checkBox6.Checked;
                arr[6] = checkBox7.Checked;
                arr[7] = checkBox8.Checked;
            */
             for (int i = 0; i< arr.GetLength(0); i++ )
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

               //     textBox1.Text += Environment.NewLine + i + arr[i] + '\n';
                 //   arr[i] = false;
                }
             //  textBox1.Text += Environment.NewLine + arr[i] + '\n';
             }
            
            /*
            if (checkBox1.Checked == true)
            {
                DateTimeOffset Deafult = dateTimePicker1.Value; 
                textBox1.Text = checkBox1.Text + " " + "<t:"+ Deafult.ToUnixTimeSeconds() + ">";
            }
            if (checkBox2.Checked == true)
            {
                DateTimeOffset Deafult = dateTimePicker1.Value;
                textBox1.Text = checkBox2.Text + " " + "<t:" + Deafult.ToUnixTimeSeconds() + ":t>";
            }
            if (checkBox3.Checked == true)
            {
                DateTimeOffset Deafult = dateTimePicker1.Value;
                textBox1.Text = checkBox3.Text + " " + "<t:" + Deafult.ToUnixTimeSeconds() + ":T>";
            }
            if (checkBox4.Checked == true)
            {
                DateTimeOffset Deafult = dateTimePicker1.Value;
                textBox1.Text = checkBox4.Text + " " + "<t:" + Deafult.ToUnixTimeSeconds() + ":d>";
            }
            if (checkBox5.Checked == true)
            {
                DateTimeOffset Deafult = dateTimePicker1.Value;
                textBox1.Text = checkBox5.Text + " " + "<t:" + Deafult.ToUnixTimeSeconds() + ":D>";
            }
            if (checkBox6.Checked == true)
            {
                DateTimeOffset Deafult = dateTimePicker1.Value;
                textBox1.Text = checkBox6.Text + " " + "<t:" + Deafult.ToUnixTimeSeconds() + ":f>";
            }
            if (checkBox7.Checked == true)
            {
                DateTimeOffset Deafult = dateTimePicker1.Value;
                textBox1.Text = checkBox7.Text + " " + "<t:" + Deafult.ToUnixTimeSeconds() + ":F>";
            }
            if (checkBox8.Checked == true)
            {
                DateTimeOffset Deafult = dateTimePicker1.Value;
                textBox1.Text = checkBox8.Text + " " + "<t:" + Deafult.ToUnixTimeSeconds() + ":R>";
            }

            */


        }
    }
}
