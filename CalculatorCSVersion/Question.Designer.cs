namespace CalculatorCSVersion
{
    partial class Question
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ansText = new System.Windows.Forms.TextBox();
            this.timerText = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.scoreText = new System.Windows.Forms.Label();
            this.hp = new System.Windows.Forms.Label();
            this.history = new System.Windows.Forms.Button();
            this.re = new System.Windows.Forms.Label();
            this.record = new System.Windows.Forms.Label();
            this.reto = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(241, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "四则运算练习";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(295, 293);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 68);
            this.button1.TabIndex = 1;
            this.button1.Text = "开始做题";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("黑体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(566, 218);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 49);
            this.button2.TabIndex = 2;
            this.button2.Text = "提交答案";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ansText
            // 
            this.ansText.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ansText.Location = new System.Drawing.Point(275, 218);
            this.ansText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ansText.Name = "ansText";
            this.ansText.Size = new System.Drawing.Size(185, 34);
            this.ansText.TabIndex = 3;
            this.ansText.Visible = false;
            // 
            // timerText
            // 
            this.timerText.AutoSize = true;
            this.timerText.Font = new System.Drawing.Font("黑体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.timerText.Location = new System.Drawing.Point(135, 152);
            this.timerText.Name = "timerText";
            this.timerText.Size = new System.Drawing.Size(0, 24);
            this.timerText.TabIndex = 4;
            this.timerText.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // scoreText
            // 
            this.scoreText.AutoSize = true;
            this.scoreText.Font = new System.Drawing.Font("黑体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.scoreText.Location = new System.Drawing.Point(291, 152);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(0, 24);
            this.scoreText.TabIndex = 5;
            // 
            // hp
            // 
            this.hp.AutoSize = true;
            this.hp.Font = new System.Drawing.Font("黑体", 14F);
            this.hp.Location = new System.Drawing.Point(444, 152);
            this.hp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.hp.Name = "hp";
            this.hp.Size = new System.Drawing.Size(0, 24);
            this.hp.TabIndex = 6;
            // 
            // history
            // 
            this.history.Font = new System.Drawing.Font("黑体", 14F);
            this.history.Location = new System.Drawing.Point(566, 317);
            this.history.Margin = new System.Windows.Forms.Padding(4);
            this.history.Name = "history";
            this.history.Size = new System.Drawing.Size(144, 44);
            this.history.TabIndex = 7;
            this.history.Text = "历史记录";
            this.history.UseVisualStyleBackColor = true;
            this.history.Visible = false;
            this.history.Click += new System.EventHandler(this.history_Click);
            // 
            // re
            // 
            this.re.AutoSize = true;
            this.re.Font = new System.Drawing.Font("黑体", 14F);
            this.re.Location = new System.Drawing.Point(16, 11);
            this.re.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.re.Name = "re";
            this.re.Size = new System.Drawing.Size(118, 24);
            this.re.TabIndex = 8;
            this.re.Text = "历史记录:";
            this.re.Visible = false;
            // 
            // record
            // 
            this.record.AutoSize = true;
            this.record.Font = new System.Drawing.Font("黑体", 14F);
            this.record.Location = new System.Drawing.Point(19, 50);
            this.record.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.record.Name = "record";
            this.record.Size = new System.Drawing.Size(0, 24);
            this.record.TabIndex = 9;
            this.record.Visible = false;
            // 
            // reto
            // 
            this.reto.Font = new System.Drawing.Font("黑体", 14F);
            this.reto.Location = new System.Drawing.Point(566, 317);
            this.reto.Margin = new System.Windows.Forms.Padding(4);
            this.reto.Name = "reto";
            this.reto.Size = new System.Drawing.Size(145, 45);
            this.reto.TabIndex = 10;
            this.reto.Text = "返回";
            this.reto.UseVisualStyleBackColor = true;
            this.reto.Visible = false;
            this.reto.Click += new System.EventHandler(this.reto_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("宋体", 13F);
            this.button3.Location = new System.Drawing.Point(643, 66);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(123, 64);
            this.button3.TabIndex = 11;
            this.button3.Text = "生成文件";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Question
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 479);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.reto);
            this.Controls.Add(this.record);
            this.Controls.Add(this.re);
            this.Controls.Add(this.history);
            this.Controls.Add(this.hp);
            this.Controls.Add(this.scoreText);
            this.Controls.Add(this.timerText);
            this.Controls.Add(this.ansText);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Question";
            this.Text = "Question";
            this.Load += new System.EventHandler(this.Question_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox ansText;
        private System.Windows.Forms.Label timerText;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label scoreText;
        private System.Windows.Forms.Label hp;
        private System.Windows.Forms.Button history;
        private System.Windows.Forms.Label re;
        private System.Windows.Forms.Label record;
        private System.Windows.Forms.Button reto;
        private System.Windows.Forms.Button button3;
    }
}