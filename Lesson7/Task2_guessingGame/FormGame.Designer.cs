namespace Task2_guessingGame
{
    partial class FormGame
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
            this.label1_static = new System.Windows.Forms.Label();
            this.labelCommunication = new System.Windows.Forms.Label();
            this.estimatedNumber = new System.Windows.Forms.NumericUpDown();
            this.buttonOK = new System.Windows.Forms.Button();
            this.labelAttempts = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.estimatedNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // label1_static
            // 
            this.label1_static.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1_static.Location = new System.Drawing.Point(186, 158);
            this.label1_static.Name = "label1_static";
            this.label1_static.Size = new System.Drawing.Size(359, 20);
            this.label1_static.TabIndex = 0;
            this.label1_static.Text = "Введите предполагаемое число:";
            this.label1_static.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCommunication
            // 
            this.labelCommunication.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCommunication.Location = new System.Drawing.Point(186, 51);
            this.labelCommunication.Name = "labelCommunication";
            this.labelCommunication.Size = new System.Drawing.Size(359, 20);
            this.labelCommunication.TabIndex = 1;
            this.labelCommunication.Text = "Компьютер загадал число - отгадай его!";
            this.labelCommunication.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // estimatedNumber
            // 
            this.estimatedNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.estimatedNumber.Location = new System.Drawing.Point(328, 192);
            this.estimatedNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.estimatedNumber.Name = "estimatedNumber";
            this.estimatedNumber.Size = new System.Drawing.Size(74, 30);
            this.estimatedNumber.TabIndex = 2;
            this.estimatedNumber.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // buttonOK
            // 
            this.buttonOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOK.Location = new System.Drawing.Point(327, 243);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 53);
            this.buttonOK.TabIndex = 3;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // labelAttempts
            // 
            this.labelAttempts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAttempts.Location = new System.Drawing.Point(186, 119);
            this.labelAttempts.Name = "labelAttempts";
            this.labelAttempts.Size = new System.Drawing.Size(359, 20);
            this.labelAttempts.TabIndex = 4;
            this.labelAttempts.Text = "Попытка 1";
            this.labelAttempts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormGame
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 347);
            this.Controls.Add(this.labelAttempts);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.estimatedNumber);
            this.Controls.Add(this.labelCommunication);
            this.Controls.Add(this.label1_static);
            this.MinimumSize = new System.Drawing.Size(757, 385);
            this.Name = "FormGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Игра \"Угадайка\"";
            this.Shown += new System.EventHandler(this.FormGame_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.estimatedNumber)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1_static;
        private System.Windows.Forms.Label labelCommunication;
        private System.Windows.Forms.NumericUpDown estimatedNumber;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label labelAttempts;
    }
}