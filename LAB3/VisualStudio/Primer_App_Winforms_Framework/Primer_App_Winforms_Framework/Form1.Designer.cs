namespace Primer_App_Winforms_Framework
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnSaludo = new System.Windows.Forms.Button();
            this.lblSaludo = new System.Windows.Forms.Label();
            this.imgApretame = new System.Windows.Forms.PictureBox();
            this.imgHolis = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgApretame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgHolis)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSaludo
            // 
            this.btnSaludo.Location = new System.Drawing.Point(133, 228);
            this.btnSaludo.Name = "btnSaludo";
            this.btnSaludo.Size = new System.Drawing.Size(75, 23);
            this.btnSaludo.TabIndex = 0;
            this.btnSaludo.Text = "Holis!!";
            this.btnSaludo.UseVisualStyleBackColor = true;
            this.btnSaludo.Click += new System.EventHandler(this.btnSaludo_Click);
            this.btnSaludo.MouseEnter += new System.EventHandler(this.btnSaludo_MouseEnter);
            this.btnSaludo.MouseLeave += new System.EventHandler(this.btnSaludo_MouseLeave);
            // 
            // lblSaludo
            // 
            this.lblSaludo.AutoSize = true;
            this.lblSaludo.BackColor = System.Drawing.SystemColors.Control;
            this.lblSaludo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaludo.ForeColor = System.Drawing.Color.Red;
            this.lblSaludo.Location = new System.Drawing.Point(119, 142);
            this.lblSaludo.Name = "lblSaludo";
            this.lblSaludo.Size = new System.Drawing.Size(121, 25);
            this.lblSaludo.TabIndex = 1;
            this.lblSaludo.Text = "**Saludo**";
            this.lblSaludo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // imgApretame
            // 
            this.imgApretame.Image = ((System.Drawing.Image)(resources.GetObject("imgApretame.Image")));
            this.imgApretame.Location = new System.Drawing.Point(113, 12);
            this.imgApretame.Name = "imgApretame";
            this.imgApretame.Size = new System.Drawing.Size(140, 117);
            this.imgApretame.TabIndex = 2;
            this.imgApretame.TabStop = false;
            this.imgApretame.Visible = false;
            // 
            // imgHolis
            // 
            this.imgHolis.Image = ((System.Drawing.Image)(resources.GetObject("imgHolis.Image")));
            this.imgHolis.Location = new System.Drawing.Point(113, 12);
            this.imgHolis.Name = "imgHolis";
            this.imgHolis.Size = new System.Drawing.Size(140, 117);
            this.imgHolis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imgHolis.TabIndex = 3;
            this.imgHolis.TabStop = false;
            this.imgHolis.Visible = false;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(253, 228);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(94, 46);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Ni Noh VImoh";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Visible = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 286);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.imgHolis);
            this.Controls.Add(this.imgApretame);
            this.Controls.Add(this.lblSaludo);
            this.Controls.Add(this.btnSaludo);
            this.Name = "Form1";
            this.Text = "Mi Primer Programa";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgApretame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgHolis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSaludo;
        private System.Windows.Forms.Label lblSaludo;
        private System.Windows.Forms.PictureBox imgApretame;
        private System.Windows.Forms.PictureBox imgHolis;
        private System.Windows.Forms.Button btnExit;
    }
}

