namespace GuessTheNumber
{
    partial class Form1
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
            this.number = new System.Windows.Forms.NumericUpDown();
            this.GuessBtn = new System.Windows.Forms.Button();
            this.NewBtn = new System.Windows.Forms.Button();
            this.Output = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.number)).BeginInit();
            this.SuspendLayout();
            // 
            // number
            // 
            this.number.Location = new System.Drawing.Point(12, 244);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(85, 22);
            this.number.TabIndex = 0;
            // 
            // GuessBtn
            // 
            this.GuessBtn.Location = new System.Drawing.Point(112, 244);
            this.GuessBtn.Name = "GuessBtn";
            this.GuessBtn.Size = new System.Drawing.Size(75, 23);
            this.GuessBtn.TabIndex = 1;
            this.GuessBtn.Text = "Guess";
            this.GuessBtn.UseVisualStyleBackColor = true;
            this.GuessBtn.Click += new System.EventHandler(this.GuessTheNumber);
            // 
            // NewBtn
            // 
            this.NewBtn.Location = new System.Drawing.Point(204, 244);
            this.NewBtn.Name = "NewBtn";
            this.NewBtn.Size = new System.Drawing.Size(75, 23);
            this.NewBtn.TabIndex = 2;
            this.NewBtn.Text = "New";
            this.NewBtn.UseVisualStyleBackColor = true;
            this.NewBtn.Click += new System.EventHandler(this.CreateNew);
            // 
            // Output
            // 
            this.Output.Location = new System.Drawing.Point(12, 25);
            this.Output.Name = "Output";
            this.Output.ReadOnly = true;
            this.Output.Size = new System.Drawing.Size(267, 198);
            this.Output.TabIndex = 3;
            this.Output.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 293);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.NewBtn);
            this.Controls.Add(this.GuessBtn);
            this.Controls.Add(this.number);
            this.Name = "Form1";
            this.Text = "GuessTheNumber";
            ((System.ComponentModel.ISupportInitialize)(this.number)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown number;
        private System.Windows.Forms.Button GuessBtn;
        private System.Windows.Forms.Button NewBtn;
        private System.Windows.Forms.RichTextBox Output;
    }
}

