//-----------------------------------------------------------------------
// <copyright file="Tools.cs" company="none">
//     Copyright (c) Sprocket Enterprises. All rights reserved.
// </copyright>
// <author>Tong Yujie</author>
//-----------------------------------------------------------------------
namespace Calculate
{
    using NUnit.Framework;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    public class Tools
    {
        // 运算符栈
        private Stack<string> stack = new Stack<string>();

        // 计算后缀表达式栈
        private Stack<decimal> cal = new Stack<decimal>();

        // 计算结果
        private decimal result;

        // 后缀表达式
        public List<string> number = new List<string>();

        /// <summary>
        /// use reg to judge whether it is a decimal
        /// </summary>
        /// <param name="temp">string</param>
        /// <returns>bool</returns>
        [TestCase("12.3", ExpectedResult = true)]
        [TestCase("-245123", ExpectedResult = false)]
        [TestCase("245123123", ExpectedResult = false)]
        public static bool IsDecimal(string temp)
        {
            if (Regex.IsMatch(temp, "^([0-9]{1,}[.][0-9]*)$"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// get operator priority
        /// </summary>
        /// <param name="temp">char</param>
        /// <returns>int</returns>
        public int GetPrioraty(char temp)
        {
            switch (temp)
            {
                case '+':
                case '-':
                    return 1;

                case '×':
                case '/':
                    return 2;

                default:
                    return 0;
            }
        }

        /// <summary>
        /// judge priority
        /// </summary>
        /// <param name="temp1">string1</param>
        /// <param name="temp2">string2</param>
        /// <returns>bool</returns>
        public bool Prioraty(string temp1, char temp2)
        {
            return this.GetPrioraty(temp1.ToCharArray()[0]) < this.GetPrioraty(temp2);
        }

        /// <summary>
        /// Judge whether it is an integer
        /// </summary>
        /// <param name="temp">string</param>
        /// <returns>bool</returns>
        public bool IsNumberic(string temp)
        {
            for (int i = 0; i < temp.Length; i++)
            {
                if (temp[i] != '.' && (temp[i] < 48 || temp[i] > 57))
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Infix expression to suffix 
        /// </summary>
        /// <param name="equation">string</param>
        public void Transform(string equation)
        {
            string num = string.Empty;
            for (int i = 0; i < equation.Length; i++)
            {
                //语句块3
                if (equation[i] >= '0' && equation[i] <= '9')
                {
                    num += equation[i];
                    // 最后一个判断是5.=0的情况
                    if (i + 1 == equation.Length || equation[i + 1] == '+' || equation[i + 1] == '-' || equation[i + 1] == '×' ||
                                        equation[i + 1] == '÷' || equation[i + 1] == '(' || equation[i + 1] == ')' || (equation[i + 1] == '.' && equation.Length == i + 2))
                    {
                        this.number.Add(num);
                        num = string.Empty;
                    }
                }
                else if (equation[i] == '+' || equation[i] == '-' || equation[i] == '×' ||
                    equation[i] == '÷' || equation[i] == '(' || equation[i] == ')')
                {
                    string temp;
                    if (this.stack.Count == 0)
                    {
                        //语句块4
                        this.stack.Push(equation[i].ToString());
                    }
                    else
                    {
                        //语句块5
                        if (equation[i] == '(')
                        {
                            this.stack.Push(equation[i].ToString()); // 将左括号入栈
                        }
                        else if (equation[i] == ')')
                        {
                            // (270/3/3)
                            while (this.stack.Count > 0 && this.stack.Peek() != '('.ToString()) 
                            {
                                temp = this.stack.Pop();
                                this.number.Add(temp.ToString());
                            }

                            // (270/3/3)
                            if (this.stack.Count > 0) 
                            {
                                this.stack.Pop();
                            }
                        }
                        else if (this.stack.Peek() == '('.ToString())
                        {
                            this.stack.Push(equation[i].ToString());
                        }
                        else if (!this.Prioraty(this.stack.Peek(), equation[i]))
                        {
                            while (this.stack.Count > 0 && !this.Prioraty(this.stack.Peek(), equation[i]))
                            {
                                temp = this.stack.Pop();
                                this.number.Add(temp.ToString());
                            }

                            this.stack.Push(equation[i].ToString());
                        }
                        else
                        {
                            this.stack.Push(equation[i].ToString());
                        }
                    }
                }
                else if (equation[i] == '.')
                {
                    num += equation[i]; // 语句块6
                }
            }

            while (this.stack.Count > 0)
            {
                this.number.Add(this.stack.Pop().ToString()); // 语句块7
            }
            // Console.WriteLine(num);
        }

        /// <summary>
        /// calculate result
        /// </summary>
        /// <returns>decimal</returns>
        public decimal CalResult()
        {
            decimal temp1 = 0, temp2 = 0;
            for (int i = 0; i < this.number.Count; i++)
            {
                if (this.IsNumberic(this.number[i]))
                {
                    this.cal.Push(decimal.Parse(this.number[i])); // 语句块8
                }
                else
                {
                    // 可以避免左右括号没有匹配的问题
                    if (this.cal.Count > 1) 
                    {
                        temp1 = this.cal.Pop(); // 语句块9
                        temp2 = this.cal.Pop();
                    }
                    // Console.WriteLine(temp1 + " " + temp2);
                    switch (this.number[i].ToCharArray()[0])
                    {
                        case '+': this.cal.Push(temp2 + temp1); // 语句块10
                            break;
                        case '-': this.cal.Push(temp2 - temp1); // 语句块11
                            break;
                        case '×': this.cal.Push(temp2 * temp1); // 语句块12
                            break;
                        case '÷': this.cal.Push(temp2 / temp1); // 语句块13
                            break;
                        default:
                            break;
                    }
                }
            }

            if (this.cal.Count > 0)
            {
                this.result = this.cal.Pop();
                return this.result;
            }
            else
            {
                return 0;
            }
        }
    }
}