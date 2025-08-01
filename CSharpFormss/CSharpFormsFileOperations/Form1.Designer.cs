namespace CSharpFormsFileOperations
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
            this.txtYazdir = new System.Windows.Forms.TextBox();
            this.btnYazdir = new System.Windows.Forms.Button();
            this.txtOku = new System.Windows.Forms.TextBox();
            this.btnOku = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtYazdir
            // 
            this.txtYazdir.Location = new System.Drawing.Point(55, 29);
            this.txtYazdir.Name = "txtYazdir";
            this.txtYazdir.Size = new System.Drawing.Size(355, 22);
            this.txtYazdir.TabIndex = 0;
            // 
            // btnYazdir
            // 
            this.btnYazdir.Location = new System.Drawing.Point(125, 57);
            this.btnYazdir.Name = "btnYazdir";
            this.btnYazdir.Size = new System.Drawing.Size(212, 23);
            this.btnYazdir.TabIndex = 1;
            this.btnYazdir.Text = "Yazdır";
            this.btnYazdir.UseVisualStyleBackColor = true;
            this.btnYazdir.Click += new System.EventHandler(this.btnYazdir_Click);
            // 
            // txtOku
            // 
            this.txtOku.Location = new System.Drawing.Point(55, 154);
            this.txtOku.Name = "txtOku";
            this.txtOku.Size = new System.Drawing.Size(355, 22);
            this.txtOku.TabIndex = 2;
            // 
            // btnOku
            // 
            this.btnOku.Location = new System.Drawing.Point(125, 182);
            this.btnOku.Name = "btnOku";
            this.btnOku.Size = new System.Drawing.Size(212, 23);
            this.btnOku.TabIndex = 3;
            this.btnOku.Text = "Oku";
            this.btnOku.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOku);
            this.Controls.Add(this.txtOku);
            this.Controls.Add(this.btnYazdir);
            this.Controls.Add(this.txtYazdir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtYazdir;
        private System.Windows.Forms.Button btnYazdir;
        private System.Windows.Forms.TextBox txtOku;
        private System.Windows.Forms.Button btnOku;
    }
}

