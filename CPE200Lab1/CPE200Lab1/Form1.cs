using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPE200Lab1
{
    public partial class Form1 : Form
    {
        string first_Operand = null;
        string second_Operand = null;
        string result_Operand = null;
        bool set_first = false;
        bool plus = false;
        bool minus = false;
        bool multi = false;
        bool devide = false;
        bool persent = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblDisplay_Click(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            
           if (lblDisplay.Text == "0")
            {
                lblDisplay.Text = "";
            }
            if (set_first == true)
            {
                lblDisplay.Text = "";
                set_first = false;
            }
            if(lblDisplay.Text.Length<8)
            {
                lblDisplay.Text += "1";
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if(lblDisplay.Text == "0")
            {
                lblDisplay.Text = "";
            }
            if (set_first == true)
            {
                lblDisplay.Text = "";
                set_first = false;
            }
            if (lblDisplay.Text.Length<8)
            {
                lblDisplay.Text += "2";
            }           
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if(lblDisplay.Text == "0")
            {
                lblDisplay.Text = "";
            }
            if (set_first == true)
            {
                lblDisplay.Text = "";
                set_first = false;
            }
            if (lblDisplay.Text.Length < 8)
            {
                lblDisplay.Text += "3";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if(lblDisplay.Text == "0")
            {
                lblDisplay.Text = "";
            }
            if (set_first == true)
            {
                lblDisplay.Text = "";
                set_first = false;
            }
            if (lblDisplay.Text.Length < 8)
            {
                lblDisplay.Text += "4";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0")
            {
                lblDisplay.Text = "";
            }
            if (set_first == true)
            {
                lblDisplay.Text = "";
                set_first = false;
            }
            if (lblDisplay.Text.Length < 8)
            {
                lblDisplay.Text += "5";
            }
            
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0")
            {
                lblDisplay.Text = "";
            }
            if (set_first == true)
            {
                lblDisplay.Text = "";
                set_first = false;
            }
            if (lblDisplay.Text.Length < 8)
            {
                lblDisplay.Text += "6";
            } 
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0")
            {
                lblDisplay.Text = "";
            }
            if (set_first == true)
            {
                lblDisplay.Text = "";
                set_first = false;
            }
            if (lblDisplay.Text.Length < 8)
            {
                lblDisplay.Text += "7";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0")
            {
                lblDisplay.Text = "";
            }
            if (set_first == true)
            {
                lblDisplay.Text = "";
                set_first = false;
            }
            if(lblDisplay.Text.Length < 8)
            {
                lblDisplay.Text += "8";
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0")
            {
                lblDisplay.Text = "";
            }
            if (set_first == true)
            {
                lblDisplay.Text = "";
                set_first = false;
         
            }
            if (lblDisplay.Text.Length < 8)
            {
                lblDisplay.Text += "9";
            }
            //Console.WriteLine(lblDisplay.Text + " " +set_first );
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0")
            {
                lblDisplay.Text = "";
            }
            if (set_first == true)
            {
                lblDisplay.Text = "";
                set_first = false;
            }
            if (lblDisplay.Text.Length < 8)
            {
                lblDisplay.Text += "0";
            }  
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (set_first == true)
            {
                first_Operand = (float.Parse(first_Operand) - float.Parse(second_Operand)).ToString();
                lblDisplay.Text = result_Operand;
            }
            first_Operand = lblDisplay.Text;
            set_first = true;
            minus = true;
            
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            //Console.WriteLine(set_first);
            if (set_first == true)
            {
                first_Operand = (float.Parse(first_Operand) + float.Parse(second_Operand)).ToString();
                lblDisplay.Text = result_Operand;     
            }
            first_Operand = lblDisplay.Text;
           // Console.WriteLine(first_Operand + " " + set_first);
            set_first = true;
            plus = true;
            //Console.WriteLine(set_first);
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            if (set_first == true)
            {
                first_Operand = (float.Parse(first_Operand) * float.Parse(second_Operand)).ToString();
                lblDisplay.Text = result_Operand;
            }
            first_Operand = lblDisplay.Text;
            set_first = true;
            multi = true;
           
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            if (set_first == true)
            {
                first_Operand = (float.Parse(first_Operand) / float.Parse(second_Operand)).ToString();
                lblDisplay.Text = result_Operand;
            }
            first_Operand = lblDisplay.Text;
            set_first = true;
            devide = true;
           
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            second_Operand = lblDisplay.Text;
            if(plus == true)
            {
                result_Operand = (float.Parse(first_Operand) + float.Parse(second_Operand)).ToString();
            }
            if(minus == true)
            {
                result_Operand = (float.Parse(first_Operand) - float.Parse(second_Operand)).ToString();
            }
            if(multi == true)
            {
                result_Operand = (float.Parse(first_Operand) * float.Parse(second_Operand)).ToString();
            }
            if(devide == true)
            {
                result_Operand = (float.Parse(first_Operand) / float.Parse(second_Operand)).ToString();
            }
            if (persent == true)
            {
                float numper = 0;
                if (set_first == false)
                {

                        numper = ((float.Parse(first_Operand) / 100) * float.Parse(lblDisplay.Text));
                        lblDisplay.Text = numper.ToString(); 

                }
               else
                   lblDisplay.Text = (float.Parse(lblDisplay.Text) / 100).ToString();
            }
            lblDisplay.Text = result_Operand;

        }   

        private void btnDot_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text.Contains('.') == false)
            {
                lblDisplay.Text += ".";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "0";
            first_Operand = null;
            second_Operand = null;
            set_first = false;
            plus = false;
            minus = false;
            multi = false;
            devide = false;
            persent = false;
            
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = lblDisplay.Text.Remove(lblDisplay.Text.Length - 1);
            if (lblDisplay.Text.Length == 0)
            {
                lblDisplay.Text = "0";
            }
        }

        private void btnPercent_Click(object sender, EventArgs e)
        {
            float numper = 0;
           // Console.WriteLine(set_first);
            if(set_first == false) {
                
                numper = ((float.Parse(first_Operand) / 100) * float.Parse(lblDisplay.Text));
                lblDisplay.Text = numper.ToString();
                //Console.WriteLine(first_Operand + " " + numper);
            }else
                lblDisplay.Text = (float.Parse(lblDisplay.Text) /100 ).ToString();

            set_first = true;
            //Console.WriteLine(set_first);
            persent = true;
            
        }
        private void btnSign_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = (float.Parse(lblDisplay.Text) * (-1)).ToString();
        }
    }
}

