namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbNombres = new System.Windows.Forms.ListBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.btnNombres = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbNombrespasados = new System.Windows.Forms.ListBox();
            this.btnPasar1 = new System.Windows.Forms.Button();
            this.btnPasarTodos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbNombres
            // 
            this.lbNombres.BackColor = System.Drawing.SystemColors.Window;
            this.lbNombres.FormattingEnabled = true;
            this.lbNombres.Location = new System.Drawing.Point(38, 136);
            this.lbNombres.Name = "lbNombres";
            this.lbNombres.Size = new System.Drawing.Size(254, 251);
            this.lbNombres.TabIndex = 0;
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(198, 62);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(326, 20);
            this.txtNombres.TabIndex = 1;
            this.txtNombres.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnNombres
            // 
            this.btnNombres.Location = new System.Drawing.Point(552, 51);
            this.btnNombres.Name = "btnNombres";
            this.btnNombres.Size = new System.Drawing.Size(109, 40);
            this.btnNombres.TabIndex = 2;
            this.btnNombres.Text = "Agregar";
            this.btnNombres.UseVisualStyleBackColor = true;
            this.btnNombres.Click += new System.EventHandler(this.btnNombres_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ingresar nombres:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbNombrespasados
            // 
            this.lbNombrespasados.FormattingEnabled = true;
            this.lbNombrespasados.Location = new System.Drawing.Point(454, 136);
            this.lbNombrespasados.Name = "lbNombrespasados";
            this.lbNombrespasados.Size = new System.Drawing.Size(254, 251);
            this.lbNombrespasados.TabIndex = 5;
            // 
            // btnPasar1
            // 
            this.btnPasar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPasar1.Location = new System.Drawing.Point(332, 188);
            this.btnPasar1.Name = "btnPasar1";
            this.btnPasar1.Size = new System.Drawing.Size(75, 23);
            this.btnPasar1.TabIndex = 6;
            this.btnPasar1.Text = ">";
            this.btnPasar1.UseVisualStyleBackColor = true;
            this.btnPasar1.Click += new System.EventHandler(this.btnPasar1_Click);
            // 
            // btnPasarTodos
            // 
            this.btnPasarTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPasarTodos.Location = new System.Drawing.Point(332, 293);
            this.btnPasarTodos.Name = "btnPasarTodos";
            this.btnPasarTodos.Size = new System.Drawing.Size(75, 23);
            this.btnPasarTodos.TabIndex = 7;
            this.btnPasarTodos.Text = ">>";
            this.btnPasarTodos.UseVisualStyleBackColor = true;
            this.btnPasarTodos.Click += new System.EventHandler(this.btnPasarTodos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPasarTodos);
            this.Controls.Add(this.btnPasar1);
            this.Controls.Add(this.lbNombrespasados);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnNombres);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.lbNombres);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbNombres;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.Button btnNombres;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbNombrespasados;
        private System.Windows.Forms.Button btnPasar1;
        private System.Windows.Forms.Button btnPasarTodos;
    }
}

