namespace WindowsFormsApp1
{
    partial class Form3
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
            this.rbtnFem = new System.Windows.Forms.RadioButton();
            this.clbOpcs = new System.Windows.Forms.CheckedListBox();
            this.rbtnMasc = new System.Windows.Forms.RadioButton();
            this.btnShow = new System.Windows.Forms.Button();
            this.rbtnSoltero = new System.Windows.Forms.RadioButton();
            this.rbtnCasado = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblPosiciones = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbtnFem
            // 
            this.rbtnFem.AutoSize = true;
            this.rbtnFem.Checked = true;
            this.rbtnFem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnFem.Location = new System.Drawing.Point(32, 19);
            this.rbtnFem.Name = "rbtnFem";
            this.rbtnFem.Size = new System.Drawing.Size(115, 28);
            this.rbtnFem.TabIndex = 0;
            this.rbtnFem.TabStop = true;
            this.rbtnFem.Text = "Femenino";
            this.rbtnFem.UseVisualStyleBackColor = true;
            // 
            // clbOpcs
            // 
            this.clbOpcs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbOpcs.FormattingEnabled = true;
            this.clbOpcs.Items.AddRange(new object[] {
            "Data entry",
            "Operador de PC",
            "Programador",
            "Reparador de PC",
            "Taller"});
            this.clbOpcs.Location = new System.Drawing.Point(281, 113);
            this.clbOpcs.Name = "clbOpcs";
            this.clbOpcs.Size = new System.Drawing.Size(178, 106);
            this.clbOpcs.TabIndex = 2;
            // 
            // rbtnMasc
            // 
            this.rbtnMasc.AutoSize = true;
            this.rbtnMasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnMasc.Location = new System.Drawing.Point(32, 42);
            this.rbtnMasc.Name = "rbtnMasc";
            this.rbtnMasc.Size = new System.Drawing.Size(114, 28);
            this.rbtnMasc.TabIndex = 3;
            this.rbtnMasc.Text = "Masculino";
            this.rbtnMasc.UseVisualStyleBackColor = true;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(301, 225);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(138, 29);
            this.btnShow.TabIndex = 4;
            this.btnShow.Text = "Mostrar elecciones";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.button1_Click);
            // 
            // rbtnSoltero
            // 
            this.rbtnSoltero.AutoSize = true;
            this.rbtnSoltero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnSoltero.Location = new System.Drawing.Point(51, 42);
            this.rbtnSoltero.Name = "rbtnSoltero";
            this.rbtnSoltero.Size = new System.Drawing.Size(87, 28);
            this.rbtnSoltero.TabIndex = 6;
            this.rbtnSoltero.Text = "Soltero";
            this.rbtnSoltero.UseVisualStyleBackColor = true;
            // 
            // rbtnCasado
            // 
            this.rbtnCasado.AutoSize = true;
            this.rbtnCasado.Checked = true;
            this.rbtnCasado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnCasado.Location = new System.Drawing.Point(51, 19);
            this.rbtnCasado.Name = "rbtnCasado";
            this.rbtnCasado.Size = new System.Drawing.Size(92, 28);
            this.rbtnCasado.TabIndex = 5;
            this.rbtnCasado.TabStop = true;
            this.rbtnCasado.Text = "Casado";
            this.rbtnCasado.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnFem);
            this.groupBox1.Controls.Add(this.rbtnMasc);
            this.groupBox1.Location = new System.Drawing.Point(67, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 79);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sexo";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtnCasado);
            this.groupBox2.Controls.Add(this.rbtnSoltero);
            this.groupBox2.Location = new System.Drawing.Point(479, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 79);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Estado civil";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(139, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 9;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.Location = new System.Drawing.Point(139, 297);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(0, 16);
            this.lblSexo.TabIndex = 10;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(139, 322);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(0, 16);
            this.lblEstado.TabIndex = 11;
            // 
            // lblPosiciones
            // 
            this.lblPosiciones.AutoSize = true;
            this.lblPosiciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosiciones.Location = new System.Drawing.Point(139, 347);
            this.lblPosiciones.Name = "lblPosiciones";
            this.lblPosiciones.Size = new System.Drawing.Size(0, 16);
            this.lblPosiciones.TabIndex = 12;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPosiciones);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.clbOpcs);
            this.Name = "Form3";
            this.Text = "Form3";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtnFem;
        private System.Windows.Forms.CheckedListBox clbOpcs;
        private System.Windows.Forms.RadioButton rbtnMasc;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.RadioButton rbtnSoltero;
        private System.Windows.Forms.RadioButton rbtnCasado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblPosiciones;
    }
}