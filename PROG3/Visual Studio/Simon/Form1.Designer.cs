
namespace Simon {
    partial class Form1 {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.btn_b1 = new System.Windows.Forms.Button();
            this.btn_b2 = new System.Windows.Forms.Button();
            this.btn_b3 = new System.Windows.Forms.Button();
            this.btn_b4 = new System.Windows.Forms.Button();
            this.btn_inciar = new System.Windows.Forms.Button();
            this.lbl_nivel = new System.Windows.Forms.Label();
            this.btn_salir = new System.Windows.Forms.Button();
            this.timer_iluminar = new System.Windows.Forms.Timer(this.components);
            this.lbl_estado = new System.Windows.Forms.Label();
            this.btn_patron = new System.Windows.Forms.Button();
            this.lbl_patron = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_b1
            // 
            this.btn_b1.Location = new System.Drawing.Point(12, 12);
            this.btn_b1.Name = "btn_b1";
            this.btn_b1.Size = new System.Drawing.Size(175, 175);
            this.btn_b1.TabIndex = 0;
            this.btn_b1.Text = "button1";
            this.btn_b1.UseVisualStyleBackColor = true;
            this.btn_b1.Click += new System.EventHandler(this.btn_b1_Click);
            // 
            // btn_b2
            // 
            this.btn_b2.Location = new System.Drawing.Point(223, 12);
            this.btn_b2.Name = "btn_b2";
            this.btn_b2.Size = new System.Drawing.Size(175, 175);
            this.btn_b2.TabIndex = 1;
            this.btn_b2.Text = "button2";
            this.btn_b2.UseVisualStyleBackColor = true;
            this.btn_b2.Click += new System.EventHandler(this.btn_b2_Click);
            // 
            // btn_b3
            // 
            this.btn_b3.Location = new System.Drawing.Point(12, 223);
            this.btn_b3.Name = "btn_b3";
            this.btn_b3.Size = new System.Drawing.Size(175, 175);
            this.btn_b3.TabIndex = 2;
            this.btn_b3.Text = "button3";
            this.btn_b3.UseVisualStyleBackColor = true;
            this.btn_b3.Click += new System.EventHandler(this.btn_b3_Click);
            // 
            // btn_b4
            // 
            this.btn_b4.Location = new System.Drawing.Point(223, 223);
            this.btn_b4.Name = "btn_b4";
            this.btn_b4.Size = new System.Drawing.Size(175, 175);
            this.btn_b4.TabIndex = 3;
            this.btn_b4.Text = "button4";
            this.btn_b4.UseVisualStyleBackColor = true;
            this.btn_b4.Click += new System.EventHandler(this.btn_b4_Click);
            // 
            // btn_inciar
            // 
            this.btn_inciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_inciar.Location = new System.Drawing.Point(12, 561);
            this.btn_inciar.Name = "btn_inciar";
            this.btn_inciar.Size = new System.Drawing.Size(175, 70);
            this.btn_inciar.TabIndex = 4;
            this.btn_inciar.Text = "JUGAR";
            this.btn_inciar.UseVisualStyleBackColor = true;
            this.btn_inciar.Click += new System.EventHandler(this.btn_inciar_Click);
            // 
            // lbl_nivel
            // 
            this.lbl_nivel.AutoSize = true;
            this.lbl_nivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nivel.Location = new System.Drawing.Point(145, 193);
            this.lbl_nivel.Name = "lbl_nivel";
            this.lbl_nivel.Size = new System.Drawing.Size(60, 24);
            this.lbl_nivel.TabIndex = 5;
            this.lbl_nivel.Text = "label1";
            // 
            // btn_salir
            // 
            this.btn_salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.Location = new System.Drawing.Point(223, 561);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(175, 70);
            this.btn_salir.TabIndex = 6;
            this.btn_salir.Text = "SALIR";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // timer_iluminar
            // 
            this.timer_iluminar.Interval = 200;
            this.timer_iluminar.Tick += new System.EventHandler(this.timer_iluminar_Tick);
            // 
            // lbl_estado
            // 
            this.lbl_estado.AutoSize = true;
            this.lbl_estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_estado.Location = new System.Drawing.Point(16, 462);
            this.lbl_estado.Name = "lbl_estado";
            this.lbl_estado.Size = new System.Drawing.Size(60, 24);
            this.lbl_estado.TabIndex = 10;
            this.lbl_estado.Text = "label1";
            // 
            // btn_patron
            // 
            this.btn_patron.Location = new System.Drawing.Point(323, 520);
            this.btn_patron.Name = "btn_patron";
            this.btn_patron.Size = new System.Drawing.Size(75, 35);
            this.btn_patron.TabIndex = 11;
            this.btn_patron.Text = "Mostrar Patron";
            this.btn_patron.UseVisualStyleBackColor = true;
            this.btn_patron.Click += new System.EventHandler(this.btn_patron_Click);
            // 
            // lbl_patron
            // 
            this.lbl_patron.AutoSize = true;
            this.lbl_patron.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_patron.Location = new System.Drawing.Point(127, 531);
            this.lbl_patron.Name = "lbl_patron";
            this.lbl_patron.Size = new System.Drawing.Size(60, 24);
            this.lbl_patron.TabIndex = 12;
            this.lbl_patron.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 643);
            this.Controls.Add(this.lbl_patron);
            this.Controls.Add(this.btn_patron);
            this.Controls.Add(this.lbl_estado);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.lbl_nivel);
            this.Controls.Add(this.btn_inciar);
            this.Controls.Add(this.btn_b4);
            this.Controls.Add(this.btn_b3);
            this.Controls.Add(this.btn_b2);
            this.Controls.Add(this.btn_b1);
            this.Name = "Form1";
            this.Text = "Simon Dice";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_b1;
        private System.Windows.Forms.Button btn_b2;
        private System.Windows.Forms.Button btn_b3;
        private System.Windows.Forms.Button btn_b4;
        private System.Windows.Forms.Button btn_inciar;
        private System.Windows.Forms.Label lbl_nivel;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Timer timer_iluminar;
        private System.Windows.Forms.Label lbl_estado;
        private System.Windows.Forms.Button btn_patron;
        private System.Windows.Forms.Label lbl_patron;
    }
}

