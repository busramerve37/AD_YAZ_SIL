namespace button.ornek._7
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
            this.btnyaz = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnyaz
            // 
            this.btnyaz.Location = new System.Drawing.Point(12, 54);
            this.btnyaz.Name = "btnyaz";
            this.btnyaz.Size = new System.Drawing.Size(105, 75);
            this.btnyaz.TabIndex = 0;
            this.btnyaz.Text = "YAZ";
            this.btnyaz.UseVisualStyleBackColor = true;
            this.btnyaz.Click += new System.EventHandler(this.btnyaz_Click);
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(12, 154);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(105, 75);
            this.btnsil.TabIndex = 1;
            this.btnsil.Text = "SİL";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(184, 115);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(266, 20);
            this.textBox1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 415);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnyaz);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnyaz;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.TextBox textBox1;
    }
}

