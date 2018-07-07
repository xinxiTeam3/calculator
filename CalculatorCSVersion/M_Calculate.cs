using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorCSVersion
{
    class Calculate
    {
        MyNumber OneStepCalculate(MyNumber num1, MyNumber num2, int opera)
        {
            if (opera == 101)
                return num1 + num2;
            else if (opera == 102)
                return num1 - num2;
            else if (opera == 103)
                return num1 * num2;
            else if (opera == 104)
                return num1 / num2;
            else if (opera == 105)
                return num1 ^ num2;
            else
            {
                MyNumber error = new MyNumber(-1);
                return error;
            }
        }
        public MyNumber GetAns(int[] operation,int length)
        {
            /*将四则运算映射到一串十进制数，0-100为运算数，
            101-104分别代表+，-，*，/，105为乘方，106为左括号,107为右括号*/
            Stack<int> operators=new Stack<int>();
            Stack<MyNumber> operand=new Stack<MyNumber>();
            for (int i = 0; i<length; i++)
            {
                if (operation[i] >= 0 && operation[i] <= 100)
                {
                    MyNumber temp=new MyNumber(operation[i]);
                    operand.Push(temp);
                }
                else if (operation[i] == 105 || operation[i] == 106)    //左括号与乘方必定入栈
                    operators.Push(operation[i]);
                else if (operation[i] == 103 || operation[i] == 104)    //乘除会弹出乘方与乘除
                {
                    while (operators.Count!=0 && (operators.Peek() == 103 || operators.Peek() == 104 || operators.Peek() == 105))
                    {
                        int opera = operators.Pop();
                        //operators.Pop();
                        MyNumber num1 = operand.Pop();
                        //operand.Pop();
                        MyNumber num2 = operand.Pop();
                        //operand.Pop();
                        operand.Push(OneStepCalculate(num2, num1, opera));
                    }
                    operators.Push(operation[i]);
                }
                else if (operation[i] == 101 || operation[i] == 102)        //加减可能弹出乘除与乘方
                {
                    while (operators.Count != 0 && (operators.Peek() != 106 && operators.Peek() != 107))
                    {
                        int opera = operators.Pop();
                        //operators.pop();
                        MyNumber num1 = operand.Pop();
                        //operand.pop();
                        MyNumber num2 = operand.Pop();
                        //operand.pop();
                        operand.Push(OneStepCalculate(num2, num1, opera));
                    }
                    operators.Push(operation[i]);
                }
                else if (operation[i] == 107)               //右括号会一直弹出直至左括号
                {
                    while (operators.Peek() != 106)
                    {
                        int opera = operators.Pop();
                        //operators.pop();
                        MyNumber num1 = operand.Pop();
                        //operand.Pop();
                        MyNumber num2 = operand.Pop();
                        //operand.pop();
                        operand.Push(OneStepCalculate(num2, num1, opera));
                    }
                    operators.Pop();
                }
            }
            while (operators.Count != 0)
            {
                int opera = operators.Pop();
                //operators.Pop();
                MyNumber num1 = operand.Pop();
                //operand.Pop();
                MyNumber num2 = operand.Pop();
                //operand.pop();
                operand.Push(OneStepCalculate(num2, num1, opera));
            }
            return operand.Pop();
        }
    }
}
