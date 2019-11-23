//-----------------------------------------------------------------------
// <copyright file="Form1.cs" company="none">
//     Copyright (c) Sprocket Enterprises. All rights reserved.
// </copyright>
// <author>Tong Yujie</author>
//-----------------------------------------------------------------------

namespace Calculate
{
    using System;
    using System.Windows.Forms;

    /// <summary>
    /// this is a form
    /// </summary>
    public partial class 计算器 : Form
    {
        private bool flag; ////是否计算完毕
        private int time = 0; ////历史记录的条数

        public 计算器()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// none
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// none
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void 计算器_Load(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// none
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">PaintEventArgs</param>
        private void 计算器_Paint(object sender, PaintEventArgs e)
        {
        }

        /// <summary>
        /// none
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void Input_TextChanged(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// number 1
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void Button25_Click(object sender, EventArgs e)
        {
            if (this.flag)
            {
                this.input.Text = string.Empty;
                this.flag = false;
            }

            if (this.input.Text.Length < 19)
            {
                this.input.Text += "1";
            }
        }

        /// <summary>
        /// number 2
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void Button24_Click(object sender, EventArgs e)
        {
            if (this.flag)
            {
                this.input.Text = string.Empty;
                this.flag = false;
            }

            if (this.input.Text.Length < 19)
            {
                this.input.Text += "2";
            }
        }

        /// <summary>
        /// number 3
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void Button23_Click(object sender, EventArgs e)
        {
            if (this.flag)
            {
                this.input.Text = string.Empty;
                this.flag = false;
            }

            if (this.input.Text.Length < 19)
            {
                this.input.Text += "3";
            }
        }

        /// <summary>
        /// number 4
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void Button20_Click(object sender, EventArgs e)
        {
            if (this.flag)
            {
                this.input.Text = string.Empty;
                this.flag = false;
            }

            if (this.input.Text.Length < 19)
            {
                this.input.Text += "4";
            }
        }

        /// <summary>
        /// number 5
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void Button19_Click(object sender, EventArgs e)
        {
            if (this.flag)
            {
                this.input.Text = string.Empty;
                this.flag = false;
            }

            if (this.input.Text.Length < 19)
            {
                this.input.Text += "5";
            }
        }

        /// <summary>
        /// number 6
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void Button18_Click(object sender, EventArgs e)
        {
            if (this.flag)
            {
                this.input.Text = string.Empty;
                this.flag = false;
            }

            if (this.input.Text.Length < 19)
            {
                this.input.Text += "6";
            }
        }

        /// <summary>
        /// number 7
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void Button15_Click(object sender, EventArgs e)
        {
            if (this.flag)
            {
                this.input.Text = string.Empty;
                this.flag = false;
            }

            if (this.input.Text.Length < 19)
            {
                this.input.Text += "7";
            }
        }

        /// <summary>
        /// number 8
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void Button14_Click(object sender, EventArgs e)
        {
            if (this.flag)
            {
                this.input.Text = string.Empty;
                this.flag = false;
            }

            if (this.input.Text.Length < 19)
            {
                this.input.Text += "8";
            }
        }

        /// <summary>
        /// number 9
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void Button13_Click(object sender, EventArgs e)
        {
            if (this.flag)
            {
                this.input.Text = string.Empty;
                this.flag = false;
            }

            if (this.input.Text.Length < 19)
            {
                this.input.Text += "9";
            }
        }

        /// <summary>
        /// number 0
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void Button30_Click(object sender, EventArgs e)
        {
            if (this.flag)
            {
                this.input.Text = string.Empty;
                this.flag = false;
            }

            if (this.input.Text.Length < 19)
            {
                this.input.Text += "0";
            }
        }

        /// <summary>
        /// char .
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void Button28_Click(object sender, EventArgs e)
        {
            // 保证输入最多只有一个小数点
            if (this.input.Text.Length < 19 && !this.input.Text.Contains('.'.ToString()))
            {
                this.input.Text += ".";
            }
        }

        /// <summary>
        /// char (
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void Button27_Click(object sender, EventArgs e)
        {
            if (this.input.Text.Length < 19)
            {
                this.input.Text += "(";
            }
        }

        /// <summary>
        /// char )
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void Button26_Click(object sender, EventArgs e)
        {
            if (this.input.Text.Length < 19)
            {
                this.input.Text += ")";
            }
        }

        /// <summary>
        /// sqrt
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void Button11_Click(object sender, EventArgs e)
        {
            decimal result;
            Tools tools = new Tools();
            tools.Transform(this.input.Text);
            result = tools.CalResult();
            Console.WriteLine(result);
            this.equation.Text += Math.Sqrt(Convert.ToDouble(result)).ToString();
            this.flag = true; // 是否计算出结果
        }

        /// <summary>
        /// char ^
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void Button6_Click(object sender, EventArgs e)
        {
            if (this.input.Text.Length < 19)
            {
                this.input.Text += "^";
            }
        }

        /// <summary>
        /// char +
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void Button17_Click(object sender, EventArgs e)
        {
            this.input.Text += "+";
            if (!this.input.Text.Contains("("))
            {
                this.equation.Text += this.input.Text;
                this.input.Text = string.Empty;
            }
        }

        /// <summary>
        /// X
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void Button22_Click(object sender, EventArgs e)
        {
            this.input.Text += "×";
            if (!this.input.Text.Contains("("))
            {
                this.equation.Text += this.input.Text;
                this.input.Text = string.Empty;
            }
        }

        /// <summary>
        /// char /
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void Button21_Click(object sender, EventArgs e)
        {
            this.input.Text += "÷";
            if (!this.input.Text.Contains("("))
            {
                this.equation.Text += this.input.Text;
                this.input.Text = string.Empty;
            }
        }

        /// <summary>
        /// none
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void Button16_Click(object sender, EventArgs e)
        {
            this.input.Text += "-";
            if (!this.input.Text.Contains("("))
            {
                this.equation.Text += this.input.Text;
                this.input.Text = string.Empty;
            }
        }

        /// <summary>
        /// none
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void Button4_Click(object sender, EventArgs e)
        {
            this.input.Text = string.Empty;
            this.equation.Text = string.Empty;
        }

        /// <summary>
        /// none
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void Button5_Click(object sender, EventArgs e)
        {
            this.input.Text = string.Empty;
        }

        /// <summary>
        /// delete one letter
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void Button10_Click(object sender, EventArgs e)
        {
            if (this.input.Text.Length > 0)
            {
                this.input.Text = this.input.Text.Remove(this.input.Text.Length - 1);
            }
        }

        /// <summary>
        /// equal
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void Button12_Click(object sender, EventArgs e)
        {
            // 如果没有输入数字直接按等号
            // 修复2+2!按等号没有输出历史记录的情况
            if (this.input.Text.Length == 0 && this.equation.Text == string.Empty)
            {
                return;
            }

            // 含有次方的情况
            // 语句块1
            if (this.input.Text.Contains("^"))
            {
                double num;
                string[] vs = this.input.Text.Split('^');
                // Console.WriteLine(vs[1]);
                num = Math.Pow(Convert.ToDouble(vs[0]), Convert.ToDouble(vs[1]));
                this.equation.Text += num.ToString();
                this.input.Text = string.Empty;
            }
            else
            {
                //语句块2
                this.time++; // 当历史记录多于6条自动清除历史记录
                if (this.time >= 6)
                {
                    this.label1.Text = string.Empty;
                    this.del.Visible = false;
                    this.time = 0;
                }

                this.equation.Text += this.input.Text;
                Console.WriteLine(this.equation.Text);
                Tools tools = new Tools();
                tools.Transform(this.equation.Text);
                this.input.Text = tools.CalResult().ToString();
                this.label1.Text = this.label1.Text + this.equation.Text + "=" + this.input.Text + "\r\n" + "\r\n"; // 历史记录
                this.del.Visible = true; // 删除图标出现
                this.equation.Text = string.Empty;
            }

            this.flag = true;
        }

        /// <summary>
        /// fac
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void Button7_Click(object sender, EventArgs e)
        {
            int index = 0;
            int sum = 1;
            bool flag = false; // 是否有左括号
            Tools tools = new Tools();
            tools.Transform(this.input.Text);
            string temp = tools.CalResult().ToString();
            while (temp[index] == '(')
            {
                index++;
                flag = true;
            }

            if (flag)
            {
                // 判断并截取数字
                if (!Tools.IsDecimal(temp.Substring(index, temp.Length - index - 1)))
                {
                    this.equation.Text += '(';
                    for (int i = 1; i <= int.Parse(temp.Substring(index, temp.Length - index)); i++)
                    {
                        sum *= i;
                    }
                }
                else
                {
                    this.input.Text = string.Empty;
                    return;
                }

                this.equation.Text += sum.ToString();
            }
            else
            {
                if (!Tools.IsDecimal(temp.Substring(index, temp.Length - index)))
                {
                    for (int i = 1; i <= int.Parse(temp.Substring(index, temp.Length - index)); i++)
                    {
                        sum *= i;
                    }
                }
                else
                {
                    this.input.Text = string.Empty;
                    return;
                }

                this.equation.Text += sum.ToString();
            }

            this.input.Text = string.Empty;
        }

        /// <summary>
        /// delete history
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void Del_Click(object sender, EventArgs e)
        {
            this.label1.Text = string.Empty;
            this.del.Visible = false;
        }

        /// <summary>
        /// Sin
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void Button1_Click(object sender, EventArgs e)
        {
            decimal result;
            Tools tools = new Tools();
            tools.Transform(this.input.Text);
            result = tools.CalResult();
            Console.WriteLine(result);
            this.equation.Text += Math.Sin(Math.PI * (Convert.ToDouble(result) / 180));
            this.flag = true; // 是否计算出结果
        }

        /// <summary>
        /// Cos
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void Button2_Click(object sender, EventArgs e)
        {
            decimal result;
            Tools tools = new Tools();
            tools.Transform(this.input.Text);
            result = tools.CalResult();
            Console.WriteLine(result);
            this.equation.Text += Math.Cos(Math.PI * (Convert.ToDouble(result) / 180));
            this.flag = true; // 是否计算出结果
        }

        /// <summary>
        /// log
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void Button8_Click(object sender, EventArgs e)
        {
            decimal result;
            Tools tools = new Tools();
            tools.Transform(this.input.Text);
            result = tools.CalResult();
            Console.WriteLine(result);
            this.equation.Text += Math.Log10(Convert.ToDouble(result));
            this.flag = true; // 是否计算出结果
        }

        /// <summary>
        /// ln
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void Button9_Click(object sender, EventArgs e)
        {
            decimal result;
            Tools tools = new Tools();
            tools.Transform(this.input.Text);
            result = tools.CalResult();
            Console.WriteLine(result);
            this.equation.Text += Math.Log(Convert.ToDouble(result));
            this.flag = true; // 是否计算出结果
        }

        /// <summary>
        /// tan
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void Button3_Click(object sender, EventArgs e)
        {
            decimal result;
            Tools tools = new Tools();
            tools.Transform(this.input.Text);
            result = tools.CalResult();
            Console.WriteLine(result);
            this.equation.Text += Math.Tan(Math.PI * (Convert.ToDouble(result) / 180));
            this.flag = true; // 是否计算出结果
        }
    }
}