
namespace Tyuiu.HubulovaVI.Sprint6.Task0.V20
{
    partial class FormBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBox));
            this.Condition = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxPrimer = new System.Windows.Forms.PictureBox();
            this.groupBoxInput = new System.Windows.Forms.GroupBox();
            this.groupBoxOutput = new System.Windows.Forms.GroupBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.labelVarX = new System.Windows.Forms.Label();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.textBoxVarX = new System.Windows.Forms.TextBox();
            this.buttonWork = new System.Windows.Forms.Button();
            this.buttonQuestion = new System.Windows.Forms.Button();
            this.Condition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPrimer)).BeginInit();
            this.groupBoxInput.SuspendLayout();
            this.groupBoxOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // Condition
            // 
            this.Condition.Controls.Add(this.pictureBoxPrimer);
            this.Condition.Controls.Add(this.label1);
            this.Condition.Location = new System.Drawing.Point(12, 25);
            this.Condition.Name = "Condition";
            this.Condition.Size = new System.Drawing.Size(776, 194);
            this.Condition.TabIndex = 0;
            this.Condition.TabStop = false;
            this.Condition.Text = "Условие";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Вычислить выражение по формуле при х = 3";
            // 
            // pictureBoxPrimer
            // 
            this.pictureBoxPrimer.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPrimer.Image")));
            this.pictureBoxPrimer.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxPrimer.InitialImage")));
            this.pictureBoxPrimer.Location = new System.Drawing.Point(594, 25);
            this.pictureBoxPrimer.Name = "pictureBoxPrimer";
            this.pictureBoxPrimer.Size = new System.Drawing.Size(157, 73);
            this.pictureBoxPrimer.TabIndex = 1;
            this.pictureBoxPrimer.TabStop = false;
            // 
            // groupBoxInput
            // 
            this.groupBoxInput.Controls.Add(this.textBoxVarX);
            this.groupBoxInput.Controls.Add(this.labelVarX);
            this.groupBoxInput.Location = new System.Drawing.Point(12, 242);
            this.groupBoxInput.Name = "groupBoxInput";
            this.groupBoxInput.Size = new System.Drawing.Size(276, 122);
            this.groupBoxInput.TabIndex = 1;
            this.groupBoxInput.TabStop = false;
            this.groupBoxInput.Text = "Ввод данных";
            // 
            // groupBoxOutput
            // 
            this.groupBoxOutput.Controls.Add(this.textBoxResult);
            this.groupBoxOutput.Controls.Add(this.labelResult);
            this.groupBoxOutput.Location = new System.Drawing.Point(314, 242);
            this.groupBoxOutput.Name = "groupBoxOutput";
            this.groupBoxOutput.Size = new System.Drawing.Size(281, 122);
            this.groupBoxOutput.TabIndex = 2;
            this.groupBoxOutput.TabStop = false;
            this.groupBoxOutput.Text = "Вывод данных";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(16, 33);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(62, 13);
            this.labelResult.TabIndex = 0;
            this.labelResult.Text = "Результат:";
            // 
            // labelVarX
            // 
            this.labelVarX.AutoSize = true;
            this.labelVarX.Location = new System.Drawing.Point(15, 33);
            this.labelVarX.Name = "labelVarX";
            this.labelVarX.Size = new System.Drawing.Size(84, 13);
            this.labelVarX.TabIndex = 0;
            this.labelVarX.Text = "Переменная Х:";
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(19, 49);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.Size = new System.Drawing.Size(100, 20);
            this.textBoxResult.TabIndex = 1;
            // 
            // textBoxVarX
            // 
            this.textBoxVarX.Location = new System.Drawing.Point(18, 48);
            this.textBoxVarX.Name = "textBoxVarX";
            this.textBoxVarX.Size = new System.Drawing.Size(100, 20);
            this.textBoxVarX.TabIndex = 1;
            this.textBoxVarX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxVarX_KeyPress);
            // 
            // buttonWork
            // 
            this.buttonWork.Location = new System.Drawing.Point(636, 256);
            this.buttonWork.Name = "buttonWork";
            this.buttonWork.Size = new System.Drawing.Size(127, 50);
            this.buttonWork.TabIndex = 3;
            this.buttonWork.Text = "Выполнить";
            this.buttonWork.UseVisualStyleBackColor = true;
            this.buttonWork.Click += new System.EventHandler(this.buttonWork_Click);
            // 
            // buttonQuestion
            // 
            this.buttonQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonQuestion.Location = new System.Drawing.Point(732, 374);
            this.buttonQuestion.Name = "buttonQuestion";
            this.buttonQuestion.Size = new System.Drawing.Size(45, 46);
            this.buttonQuestion.TabIndex = 4;
            this.buttonQuestion.Text = "?";
            this.buttonQuestion.UseVisualStyleBackColor = true;
            this.buttonQuestion.Click += new System.EventHandler(this.buttonQuestion_Click);
            // 
            // FormBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonQuestion);
            this.Controls.Add(this.buttonWork);
            this.Controls.Add(this.groupBoxOutput);
            this.Controls.Add(this.groupBoxInput);
            this.Controls.Add(this.Condition);
            this.Name = "FormBox";
            this.Text = "Спринт 6 | Таск 0 | Вариант 20 | Хубулова В. И.";
            this.Condition.ResumeLayout(false);
            this.Condition.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPrimer)).EndInit();
            this.groupBoxInput.ResumeLayout(false);
            this.groupBoxInput.PerformLayout();
            this.groupBoxOutput.ResumeLayout(false);
            this.groupBoxOutput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Condition;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxPrimer;
        private System.Windows.Forms.GroupBox groupBoxInput;
        private System.Windows.Forms.TextBox textBoxVarX;
        private System.Windows.Forms.Label labelVarX;
        private System.Windows.Forms.GroupBox groupBoxOutput;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button buttonWork;
        private System.Windows.Forms.Button buttonQuestion;
    }
}

