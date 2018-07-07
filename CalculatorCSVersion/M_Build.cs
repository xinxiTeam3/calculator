using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorCSVersion
{
    class Build
    {
        public int p = 0;
        public int []Expression=new int[50];
        public string strsave;
        //mode=1 基础，mode=2 带分数，mode=3，带乘方。
        int RandExpLen()
        {
            return Question.rd.Next(2, 11); 
        }
        int RandExpNum(int maxnum)
        {
            return Question.rd.Next(0, maxnum);
        }
        int RandSymbol(int mode)
        {
            int randnum=-1;
            if (mode == 1)
                randnum = Question.rd.Next(0,4) + 101;
            else if (mode == 2)
                randnum = Question.rd.Next(0, 4) + 101;
            else if (mode == 3)
                randnum = Question.rd.Next(0, 5) + 101;
            else if (mode == 4)
                randnum = Question.rd.Next(0, 5);
            return randnum;
        }
        int PownumEasy()
        {
            return Question.rd.Next(0,3) + 1;
        }
        public void PrintExp()
        {
            char []save = new char[100];
            int savep = 0;
            for (int i = 0; i < p; i++)
            {
                if (Expression[i] == 101)
                    save[savep++] = '+';
                else if (Expression[i] == 102)
                    save[savep++] = '-';
                else if (Expression[i] == 103)
                    save[savep++] = '*';
                else if (Expression[i] == 104)
                    save[savep++] = '/';
                else if (Expression[i] == 105)
                    save[savep++] = '^';
                else if (Expression[i] == 106)
                    save[savep++] = '(';
                else if (Expression[i] == 107)
                    save[savep++] = ')';
                else
                    save[savep++] = (char)(Expression[i]+48);
            }
            strsave = new string(save);
            //strsave += "= \n";
        }
        public string M_ToString()
        {
            string save = "";
            for (int i = 0; i < p; i++)
            {
                if (Expression[i] == 101)
                    save = save + '+';
                else if (Expression[i] == 102)
                    save = save + '-';
                else if (Expression[i] == 103)
                    save = save + '*';
                else if (Expression[i] == 104)
                    save = save + '/';
                else if (Expression[i] == 105)
                    save = save + '^';
                else if (Expression[i] == 106)
                    save = save + '(';
                else if (Expression[i] == 107)
                    save = save + ')';
                else
                    save = save + (char)(Expression[i] + 48);
            }
            return save;
        }
        public int[] BuildExp(int mode)
        {
            int lastbracket = 0;
            p = 0;
            bool HavePow = false;
            int expnum = RandExpLen();
            for (int j = 1; j <= expnum; j++)
            {
                if (j == expnum)//最后一个数字的判断
                {
                    Expression[p++] = RandExpNum(10);
                    if (p>1&&Expression[p - 2] == 105)
                        Expression[p - 1] = PownumEasy();
                    if (p>1&&Expression[p - 2] == 104 && Expression[p - 1] == 0)//判断分母0
                        Expression[p - 1] = 1;
                    if (lastbracket != 0)//若有未匹配左括号，则最后一位强制添加右括号
                        Expression[p++] = 107;
                    break;
                }
                else
                {
                    Expression[p++] = RandExpNum(10);//生成随机数
                    if (p>1&&Expression[p - 2] == 105)
                        Expression[p - 1] = PownumEasy();
                    if (p>1&&Expression[p - 2] == 104 && Expression[p - 1] == 0)//判断分母0
                        Expression[p - 1] = 1;
                    if (RandSymbol(4)==1 && lastbracket > 2)//右括号
                    {
                        Expression[p++] = 107;
                        lastbracket = 0;
                    }
                    Expression[p++] = RandSymbol(mode);//生成随机符号
                    {//检查乘方个数
                        if (Expression[p - 1] == 105 && HavePow)
                            Expression[p - 1] = RandSymbol(1);
                        else if (Expression[p - 1] == 105)
                            HavePow = true;
                    }
                    if (RandSymbol(4)==1 && j < expnum - 1 && lastbracket == 0 && Expression[p - 1] < 104)//左括号
                    {
                        Expression[p++] = 106;
                        lastbracket = 1;
                    }
                }
                if (lastbracket != 0)
                    lastbracket++;
            }
            return Expression;
        }
    }
}
