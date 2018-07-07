using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace CalculatorCSVersion
{
    public partial class Question : Form
    {
        public int[] save = new int[50];
        Calculate calculate = new Calculate();
        public static Random rd = new Random();
        Build build = new Build();
        private bool IsFirstBuild = true;
        private int score = 0;
        int totalTime = 20;
        private int chance=10;
        public Question()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int[] a = new int[] { 1, 101, 2, 102, 3 };
            //FileStream file = new FileStream(@"E:\1.txt", FileMode.Open);
            //calculate.GetAns(operation: a, length: 4).Print();

            if(IsFirstBuild)
            {
                ansText.Visible=true;
                button1.Visible = false;
                button2.Visible = true;
                timerText.Visible = true;
                history.Visible = true;
                scoreText.Text = "得分："+score.ToString();
                hp.Text = "剩余次数" + chance.ToString();
                timer1.Start();
            }
            ansText.Focus();
            for (int i = 0; i < 1; i++)
            {
                save = build.BuildExp(3);
                build.PrintExp();
                label1.Text = build.strsave;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ansText.Text == "")
            {
                ansText.Focus();
                return;
            }
            Ans ans = new Ans();
            MyNumber correctAnswer = calculate.GetAns(save, build.p);
            int ansflag = ans.GetResult(correctAnswer, this.ansText.Text);
            string correctAnswerStr = correctAnswer.M_ToString();
            if (ansflag == 1)
            {
                timer1.Stop();
                MessageBox.Show("Accepted!\n");
                timer1.Start();
                score++;
                scoreText.Text = "得分：" + score.ToString();
                button1_Click(null, null);
                this.ansText.Text = "";
                totalTime = 20;
            }
            else if (ansflag == 0)
            {
                timer1.Stop();
                MessageBox.Show("WrongAnswer\n"+ "Correct Answer:" + correctAnswerStr);
                timer1.Start();
                chance=chance-1;
                if (chance <= 0)
                {
                    MessageBox.Show("错误次数过多！");
                    Application.Exit();
                }
                hp.Text = "剩余次数" + chance.ToString();
                button1_Click(null, null);
                this.ansText.Text = "";
                totalTime = 20;
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("输入格式有误！");
                timer1.Start();
                this.ansText.Text = "";
                this.ansText.Focus();
            }
            record.Text += build.M_ToString() + "="+correctAnswerStr+"\r\n";//保存历史记录
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            timerText.Text = "倒计时："+(totalTime--).ToString();
            //Thread.Sleep(3000);
            if(totalTime==-1)
            {
                timer1.Stop();
                timerText.Visible = false;
                MessageBox.Show("时间到！");
                chance -= 1;
                hp.Text = "剩余次数" + chance.ToString();
                button1_Click(null, null);
                totalTime = 20;
            }
        }

        private void history_Click(object sender, EventArgs e)
        {
            re.Visible = true;
            record.Visible = true;
            reto.Visible = true;
            ansText.Visible = false;
            button2.Visible = false;
            timerText.Visible =false;
            scoreText.Visible = false;
            hp.Visible = false;
            history.Visible = false;
            label1.Visible = false;
            timer1.Stop();
        }

        private void Question_Load(object sender, EventArgs e)
        {

        }

        private void reto_Click(object sender, EventArgs e)
        {
            re.Visible = false;
            record.Visible = false;
            reto.Visible = false;
            ansText.Visible = true;
            button2.Visible = true;
            timerText.Visible = true;
            scoreText.Visible = true;
            hp.Visible = true;
            history.Visible = true;
            label1.Visible = true;
            timer1.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FileInfo myFile1 = new FileInfo(@"E:\Exercise.txt");
            FileInfo myFile2 = new FileInfo(@"E:\Answer.txt");
            StreamWriter sw1 = myFile1.CreateText();
            StreamWriter sw2 = myFile2.CreateText();
            for (int i=0;i<1000;i++)
            {
                save = build.BuildExp(3);
                build.PrintExp();
                sw1.WriteLine(build.M_ToString());
                //MyNumber correctAnswer = new MyNumber();
                sw2.WriteLine(calculate.GetAns(save, build.p).M_ToString());
                //sw2.WriteLine(save[1]);
                //string correctAnswerStr = correctAnswer.M_ToString();

            }
            sw1.Close();
            sw2.Close();
            MessageBox.Show("OK");
        }
    }
}
