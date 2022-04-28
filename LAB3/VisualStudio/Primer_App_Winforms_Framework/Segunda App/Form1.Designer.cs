namespace Segunda_App
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
            this.lblTexto1 = new System.Windows.Forms.Label();
            this.tbTexto1 = new System.Windows.Forms.TextBox();
            this.btnTexto1 = new System.Windows.Forms.Button();
            this.lblOutTexto1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTexto1
            // 
            this.lblTexto1.AutoSize = true;
            this.lblTexto1.Location = new System.Drawing.Point(12, 42);
            this.lblTexto1.Name = "lblTexto1";
            this.lblTexto1.Size = new System.Drawing.Size(90, 13);
            this.lblTexto1.TabIndex = 0;
            this.lblTexto1.Text = "Ingrese un Texto:";
            // 
            // tbTexto1
            // 
            this.tbTexto1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbTexto1.Location = new System.Drawing.Point(108, 39);
            this.tbTexto1.Name = "tbTexto1";
            this.tbTexto1.Size = new System.Drawing.Size(288, 20);
            this.tbTexto1.TabIndex = 1;
            this.tbTexto1.Tag = "";
            this.tbTexto1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbTexto1_KeyDown);
            // 
            // btnTexto1
            // 
            this.btnTexto1.Location = new System.Drawing.Point(448, 42);
            this.btnTexto1.Name = "btnTexto1";
            this.btnTexto1.Size = new System.Drawing.Size(75, 23);
            this.btnTexto1.TabIndex = 2;
            this.btnTexto1.Text = "Enviar";
            this.btnTexto1.UseVisualStyleBackColor = true;
            this.btnTexto1.Click += new System.EventHandler(this.btnTexto1_Click);
            // 
            // lblOutTexto1
            // 
            this.lblOutTexto1.AutoSize = true;
            this.lblOutTexto1.Location = new System.Drawing.Point(105, 111);
            this.lblOutTexto1.Name = "lblOutTexto1";
            this.lblOutTexto1.Size = new System.Drawing.Size(35, 13);
            this.lblOutTexto1.TabIndex = 3;
            this.lblOutTexto1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 140);
            this.Controls.Add(this.lblOutTexto1);
            this.Controls.Add(this.btnTexto1);
            this.Controls.Add(this.tbTexto1);
            this.Controls.Add(this.lblTexto1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTexto1;
        private System.Windows.Forms.TextBox tbTexto1;
        private System.Windows.Forms.Button btnTexto1;
        private System.Windows.Forms.Label lblOutTexto1;
    }
}

