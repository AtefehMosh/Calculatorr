using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculatorr
{
    public partial class Form1 : Form
    {
        
        double  finalresalt,result, num1, num2 = 0;
        string op;



        public Form1()
        {
            InitializeComponent();
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            if (txt_Result.Text == "0")
                txt_Result.Text = "";
            txt_Result.Text += "1";
            lbl_result.Text += "1";

        }

        private void txt_Result_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            if (txt_Result.Text == "0")
                txt_Result.Text = "";
            txt_Result.Text += "2";
            lbl_result.Text += "2";
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            if (txt_Result.Text == "0")
                txt_Result.Text = "";
            txt_Result.Text += "3";
            lbl_result.Text += "3";
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            if (txt_Result.Text == "0")
                txt_Result.Text = "";
            txt_Result.Text += "4";
            lbl_result.Text += "4";
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            if (txt_Result.Text == "0")
                txt_Result.Text = "";
            txt_Result.Text += "5";
            lbl_result.Text += "5";
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            if (txt_Result.Text == "0")
                txt_Result.Text = "";
            txt_Result.Text += "6";
            lbl_result.Text += "6";
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            if(txt_Result.Text == "0")
                txt_Result.Text = "";
            txt_Result.Text += "7";
            lbl_result.Text += "7";
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            if (txt_Result.Text == "0")
                txt_Result.Text = "";
            txt_Result.Text += "8";
            lbl_result.Text += "8";
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            if (txt_Result.Text == "0")
                txt_Result.Text = "";
            txt_Result.Text += "9";
            lbl_result.Text += "9";
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            if (txt_Result.Text != " ")
                txt_Result.Text += "0";
            lbl_result.Text += "0";

        }

        private void btn_sum_Click(object sender, EventArgs e)
        {

            if(txt_Result.Text != "" || txt_Result.Text!= "0")
            {
               
                num1 = Convert.ToDouble(txt_Result.Text);
                txt_Result.Text = "";
                op = "+";
                if (finalresalt == 0)
                    lbl_result.Text += "+";
                else
                {
                    lbl_result.Text = "";
                    lbl_result.Text += finalresalt.ToString() + "+";
                }
            }


        }

        private void btn_sub_Click(object sender, EventArgs e)
        {
            if (txt_Result.Text != "" || txt_Result.Text != "0")
            {
               
                num1 = Convert.ToDouble(txt_Result.Text);
                txt_Result.Text = "";
                op = "-";
                if (finalresalt == 0)
                    lbl_result.Text += "-";
                else
                {
                    lbl_result.Text = "";
                    lbl_result.Text = finalresalt.ToString() + "-";
                }

            }
            

        }

        private void btn_mul_Click(object sender, EventArgs e)
        {
            if (txt_Result.Text != "" || txt_Result.Text != "0")
            {
               
                num1 = Convert.ToDouble(txt_Result.Text);
                txt_Result.Text = "";
                op = "*";
                if (finalresalt == 0)
                    lbl_result.Text += "*";
                else
                {
                    lbl_result.Text = "";
                    lbl_result.Text = finalresalt.ToString() + "*";
                }

            }

        }

        private void btn_div_Click(object sender, EventArgs e)
        {

            if (txt_Result.Text != "" || txt_Result.Text != "0")
            {
                
                num1 = Convert.ToDouble(txt_Result.Text);
                txt_Result.Text = "";
                op = "/";
                if (finalresalt == 0)
                    lbl_result.Text += "/";
                else
                {
                    lbl_result.Text = "";
                    lbl_result.Text = finalresalt.ToString()+ "/" ;
                }

            }

        }

        private void btn_equl_Click(object sender, EventArgs e)
        {
            
            num2 = Convert.ToDouble(txt_Result.Text);
            if (num2 == 0 && op == "/")
            {
               MessageBox.Show( "Eror! Divide By zero!!");
                txt_Result.Text = "";
                lbl_result.Text = "";
               return;
            }
            else
            {
                switch (op)
                {
                    case "+":
                        result = num1 + num2;
                        break;
                    case "-":
                        result = num1 - num2;
                        break;
                    case "*":
                        result = num1 * num2;
                        break;
                    case "/":
                       result = num1 / num2;
                        break;
                    default:
                        result = 0;
                        break;
                }

                txt_Result.Text = result.ToString();
                finalresalt = Convert.ToDouble(txt_Result.Text);
                lbl_result.Text += "=" + finalresalt.ToString();
            } 


        }

        private void btn_clr_Click(object sender, EventArgs e)
        {
            txt_Result.Text ="";
            lbl_result.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txt_Result.Text = "0";
        }
    }
}
