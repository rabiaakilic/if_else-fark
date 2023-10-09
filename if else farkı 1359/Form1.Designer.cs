namespace if_else_farkı_1359
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
            this.rbRenk1 = new System.Windows.Forms.RadioButton();
            this.rbRenk2 = new System.Windows.Forms.RadioButton();
            this.rbRenk3 = new System.Windows.Forms.RadioButton();
            this.rbRenk4 = new System.Windows.Forms.RadioButton();
            this.btnDegistir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rbRenk1
            // 
            this.rbRenk1.AutoSize = true;
            this.rbRenk1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbRenk1.Location = new System.Drawing.Point(71, 57);
            this.rbRenk1.Name = "rbRenk1";
            this.rbRenk1.Size = new System.Drawing.Size(59, 24);
            this.rbRenk1.TabIndex = 0;
            this.rbRenk1.TabStop = true;
            this.rbRenk1.Text = "mavi";
            this.rbRenk1.UseVisualStyleBackColor = true;
            // 
            // rbRenk2
            // 
            this.rbRenk2.AutoSize = true;
            this.rbRenk2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbRenk2.Location = new System.Drawing.Point(71, 91);
            this.rbRenk2.Name = "rbRenk2";
            this.rbRenk2.Size = new System.Drawing.Size(76, 24);
            this.rbRenk2.TabIndex = 1;
            this.rbRenk2.TabStop = true;
            this.rbRenk2.Text = "pembe";
            this.rbRenk2.UseVisualStyleBackColor = true;
            // 
            // rbRenk3
            // 
            this.rbRenk3.AutoSize = true;
            this.rbRenk3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbRenk3.Location = new System.Drawing.Point(71, 130);
            this.rbRenk3.Name = "rbRenk3";
            this.rbRenk3.Size = new System.Drawing.Size(52, 24);
            this.rbRenk3.TabIndex = 2;
            this.rbRenk3.TabStop = true;
            this.rbRenk3.Text = "sarı";
            this.rbRenk3.UseVisualStyleBackColor = true;
            // 
            // rbRenk4
            // 
            this.rbRenk4.AutoSize = true;
            this.rbRenk4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbRenk4.Location = new System.Drawing.Point(71, 172);
            this.rbRenk4.Name = "rbRenk4";
            this.rbRenk4.Size = new System.Drawing.Size(70, 24);
            this.rbRenk4.TabIndex = 3;
            this.rbRenk4.TabStop = true;
            this.rbRenk4.Text = "kırmızı";
            this.rbRenk4.UseVisualStyleBackColor = true;
            // 
            // btnDegistir
            // 
            this.btnDegistir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDegistir.Location = new System.Drawing.Point(107, 231);
            this.btnDegistir.Name = "btnDegistir";
            this.btnDegistir.Size = new System.Drawing.Size(107, 47);
            this.btnDegistir.TabIndex = 4;
            this.btnDegistir.Text = "değistir";
            this.btnDegistir.UseVisualStyleBackColor = true;
            this.btnDegistir.Click += new System.EventHandler(this.btnDegistir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDegistir);
            this.Controls.Add(this.rbRenk4);
            this.Controls.Add(this.rbRenk3);
            this.Controls.Add(this.rbRenk2);
            this.Controls.Add(this.rbRenk1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbRenk1;
        private System.Windows.Forms.RadioButton rbRenk2;
        private System.Windows.Forms.RadioButton rbRenk3;
        private System.Windows.Forms.RadioButton rbRenk4;
        private System.Windows.Forms.Button btnDegistir;
    }
}

