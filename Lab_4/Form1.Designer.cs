namespace Lab_4
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.FunctionNameLabel = new System.Windows.Forms.Label();
            this.FunctionTextbox = new System.Windows.Forms.TextBox();
            this.Zakres1 = new System.Windows.Forms.Label();
            this.Range_x1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Range_x2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // FunctionNameLabel
            // 
            this.FunctionNameLabel.AutoSize = true;
            this.FunctionNameLabel.Location = new System.Drawing.Point(13, 13);
            this.FunctionNameLabel.Name = "FunctionNameLabel";
            this.FunctionNameLabel.Size = new System.Drawing.Size(117, 13);
            this.FunctionNameLabel.TabIndex = 0;
            this.FunctionNameLabel.Text = "Wprowadz wzór funkcji";
            // 
            // FunctionTextbox
            // 
            this.FunctionTextbox.Location = new System.Drawing.Point(16, 30);
            this.FunctionTextbox.Name = "FunctionTextbox";
            this.FunctionTextbox.Size = new System.Drawing.Size(213, 20);
            this.FunctionTextbox.TabIndex = 1;
            // 
            // Zakres1
            // 
            this.Zakres1.AutoSize = true;
            this.Zakres1.Location = new System.Drawing.Point(16, 66);
            this.Zakres1.Name = "Zakres1";
            this.Zakres1.Size = new System.Drawing.Size(145, 13);
            this.Zakres1.TabIndex = 2;
            this.Zakres1.Text = "Podaj zakres zmienności (X1)";
            // 
            // Range_x1
            // 
            this.Range_x1.Location = new System.Drawing.Point(16, 82);
            this.Range_x1.Name = "Range_x1";
            this.Range_x1.Size = new System.Drawing.Size(213, 20);
            this.Range_x1.TabIndex = 3;
            this.Range_x1.TextChanged += new System.EventHandler(this.Range_x1_TextChanged);
            this.Range_x1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Range_x1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(164, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 4;
            // 
            // Range_x2
            // 
            this.Range_x2.Location = new System.Drawing.Point(16, 141);
            this.Range_x2.Name = "Range_x2";
            this.Range_x2.Size = new System.Drawing.Size(210, 20);
            this.Range_x2.TabIndex = 5;
            this.Range_x2.TextChanged += new System.EventHandler(this.Range_x2_TextChanged_1);
            this.Range_x2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Range_x2_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Podaj zakre zmiennosci (X2)";
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(16, 275);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(210, 23);
            this.SubmitButton.TabIndex = 7;
            this.SubmitButton.Text = "Licz";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(16, 182);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(16, 217);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(80, 17);
            this.checkBox2.TabIndex = 9;
            this.checkBox2.Text = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 454);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Range_x2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Range_x1);
            this.Controls.Add(this.Zakres1);
            this.Controls.Add(this.FunctionTextbox);
            this.Controls.Add(this.FunctionNameLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FunctionNameLabel;
        private System.Windows.Forms.TextBox FunctionTextbox;
        private System.Windows.Forms.Label Zakres1;
        private System.Windows.Forms.TextBox Range_x1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Range_x2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
    }
}

