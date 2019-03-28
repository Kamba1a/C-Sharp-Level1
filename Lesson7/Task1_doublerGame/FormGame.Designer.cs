namespace Task1_doublerGame
{
    partial class FormGame
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonPlusOne = new System.Windows.Forms.Button();
            this.buttonMultiTwo = new System.Windows.Forms.Button();
            this.buttonStepReturn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonReset = new System.Windows.Forms.Button();
            this.labelStepCount = new System.Windows.Forms.Label();
            this.labelNumber = new System.Windows.Forms.Label();
            this.buttonNumberGen = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.labelNewNumber = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelSteps = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonPlusOne
            // 
            this.buttonPlusOne.Location = new System.Drawing.Point(238, 83);
            this.buttonPlusOne.Name = "buttonPlusOne";
            this.buttonPlusOne.Size = new System.Drawing.Size(75, 23);
            this.buttonPlusOne.TabIndex = 0;
            this.buttonPlusOne.Text = "+1";
            this.buttonPlusOne.UseVisualStyleBackColor = true;
            this.buttonPlusOne.Click += new System.EventHandler(this.buttonPlusOne_Click);
            // 
            // buttonMultiTwo
            // 
            this.buttonMultiTwo.Location = new System.Drawing.Point(238, 121);
            this.buttonMultiTwo.Name = "buttonMultiTwo";
            this.buttonMultiTwo.Size = new System.Drawing.Size(75, 23);
            this.buttonMultiTwo.TabIndex = 1;
            this.buttonMultiTwo.Text = "x2";
            this.buttonMultiTwo.UseVisualStyleBackColor = true;
            this.buttonMultiTwo.Click += new System.EventHandler(this.buttonMultiTwo_Click);
            // 
            // buttonStepReturn
            // 
            this.buttonStepReturn.Location = new System.Drawing.Point(60, 179);
            this.buttonStepReturn.Name = "buttonStepReturn";
            this.buttonStepReturn.Size = new System.Drawing.Size(75, 38);
            this.buttonStepReturn.TabIndex = 2;
            this.buttonStepReturn.Text = "Отменить ход";
            this.buttonStepReturn.UseVisualStyleBackColor = true;
            this.buttonStepReturn.Click += new System.EventHandler(this.buttonStepReturn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Количество ваших ходов:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Текущее число:";
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(238, 194);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 5;
            this.buttonReset.Text = "Сброс";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // labelStepCount
            // 
            this.labelStepCount.AutoSize = true;
            this.labelStepCount.Location = new System.Drawing.Point(169, 145);
            this.labelStepCount.Name = "labelStepCount";
            this.labelStepCount.Size = new System.Drawing.Size(13, 13);
            this.labelStepCount.TabIndex = 6;
            this.labelStepCount.Text = "0";
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNumber.Location = new System.Drawing.Point(88, 103);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(17, 17);
            this.labelNumber.TabIndex = 7;
            this.labelNumber.Text = "1";
            this.labelNumber.TextChanged += new System.EventHandler(this.labelNumber_TextChanged);
            // 
            // buttonNumberGen
            // 
            this.buttonNumberGen.Location = new System.Drawing.Point(228, 26);
            this.buttonNumberGen.Name = "buttonNumberGen";
            this.buttonNumberGen.Size = new System.Drawing.Size(94, 23);
            this.buttonNumberGen.TabIndex = 8;
            this.buttonNumberGen.Text = "Новое число";
            this.buttonNumberGen.UseVisualStyleBackColor = true;
            this.buttonNumberGen.Click += new System.EventHandler(this.buttonNumberGen_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Достигните";
            // 
            // labelNewNumber
            // 
            this.labelNewNumber.AutoSize = true;
            this.labelNewNumber.Location = new System.Drawing.Point(85, 31);
            this.labelNewNumber.Name = "labelNewNumber";
            this.labelNewNumber.Size = new System.Drawing.Size(13, 13);
            this.labelNewNumber.TabIndex = 10;
            this.labelNewNumber.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(104, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "за";
            // 
            // labelSteps
            // 
            this.labelSteps.AutoSize = true;
            this.labelSteps.Location = new System.Drawing.Point(131, 31);
            this.labelSteps.Name = "labelSteps";
            this.labelSteps.Size = new System.Drawing.Size(13, 13);
            this.labelSteps.TabIndex = 12;
            this.labelSteps.Text = "1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(150, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "ходов";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 250);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelSteps);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelNewNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonNumberGen);
            this.Controls.Add(this.labelNumber);
            this.Controls.Add(this.labelStepCount);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonStepReturn);
            this.Controls.Add(this.buttonMultiTwo);
            this.Controls.Add(this.buttonPlusOne);
            this.MinimumSize = new System.Drawing.Size(384, 288);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Игра \"Удвоитель\"";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPlusOne;
        private System.Windows.Forms.Button buttonMultiTwo;
        private System.Windows.Forms.Button buttonStepReturn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Label labelStepCount;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.Button buttonNumberGen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelNewNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelSteps;
        private System.Windows.Forms.Label label6;
    }
}

