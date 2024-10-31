namespace Guia9._1
{
    partial class FormEvaluacion
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbParametrica = new System.Windows.Forms.GroupBox();
            this.lbUnidad = new System.Windows.Forms.Label();
            this.tbMedido = new System.Windows.Forms.TextBox();
            this.tbMaximo = new System.Windows.Forms.TextBox();
            this.tbMinimo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbSimple = new System.Windows.Forms.GroupBox();
            this.cbFuncionamiento = new System.Windows.Forms.CheckBox();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.gbParametrica.SuspendLayout();
            this.gbSimple.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(122, 12);
            this.tbNombre.Multiline = true;
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.ReadOnly = true;
            this.tbNombre.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbNombre.Size = new System.Drawing.Size(380, 37);
            this.tbNombre.TabIndex = 1;
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.Location = new System.Drawing.Point(122, 55);
            this.tbDescripcion.Multiline = true;
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.ReadOnly = true;
            this.tbDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbDescripcion.Size = new System.Drawing.Size(380, 36);
            this.tbDescripcion.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descripción";
            // 
            // gbParametrica
            // 
            this.gbParametrica.Controls.Add(this.lbUnidad);
            this.gbParametrica.Controls.Add(this.tbMedido);
            this.gbParametrica.Controls.Add(this.tbMaximo);
            this.gbParametrica.Controls.Add(this.tbMinimo);
            this.gbParametrica.Controls.Add(this.label6);
            this.gbParametrica.Controls.Add(this.label5);
            this.gbParametrica.Controls.Add(this.label4);
            this.gbParametrica.Controls.Add(this.label3);
            this.gbParametrica.Location = new System.Drawing.Point(12, 97);
            this.gbParametrica.Name = "gbParametrica";
            this.gbParametrica.Size = new System.Drawing.Size(514, 85);
            this.gbParametrica.TabIndex = 4;
            this.gbParametrica.TabStop = false;
            this.gbParametrica.Text = "Evaluación parimetrica";
            // 
            // lbUnidad
            // 
            this.lbUnidad.AutoSize = true;
            this.lbUnidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUnidad.Location = new System.Drawing.Point(428, 45);
            this.lbUnidad.Name = "lbUnidad";
            this.lbUnidad.Size = new System.Drawing.Size(76, 17);
            this.lbUnidad.TabIndex = 7;
            this.lbUnidad.Text = "Porcentaje";
            // 
            // tbMedido
            // 
            this.tbMedido.Location = new System.Drawing.Point(322, 44);
            this.tbMedido.Name = "tbMedido";
            this.tbMedido.Size = new System.Drawing.Size(100, 20);
            this.tbMedido.TabIndex = 6;
            // 
            // tbMaximo
            // 
            this.tbMaximo.Location = new System.Drawing.Point(216, 44);
            this.tbMaximo.Name = "tbMaximo";
            this.tbMaximo.ReadOnly = true;
            this.tbMaximo.Size = new System.Drawing.Size(100, 20);
            this.tbMaximo.TabIndex = 5;
            // 
            // tbMinimo
            // 
            this.tbMinimo.Location = new System.Drawing.Point(110, 44);
            this.tbMinimo.Name = "tbMinimo";
            this.tbMinimo.ReadOnly = true;
            this.tbMinimo.Size = new System.Drawing.Size(100, 20);
            this.tbMinimo.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(319, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Valor medido";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(213, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Máximo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(107, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Mínimo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Valores";
            // 
            // gbSimple
            // 
            this.gbSimple.Controls.Add(this.cbFuncionamiento);
            this.gbSimple.Location = new System.Drawing.Point(12, 188);
            this.gbSimple.Name = "gbSimple";
            this.gbSimple.Size = new System.Drawing.Size(514, 82);
            this.gbSimple.TabIndex = 5;
            this.gbSimple.TabStop = false;
            this.gbSimple.Text = "Evaluación simple";
            // 
            // cbFuncionamiento
            // 
            this.cbFuncionamiento.AutoSize = true;
            this.cbFuncionamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFuncionamiento.Location = new System.Drawing.Point(151, 35);
            this.cbFuncionamiento.Name = "cbFuncionamiento";
            this.cbFuncionamiento.Size = new System.Drawing.Size(238, 21);
            this.cbFuncionamiento.TabIndex = 0;
            this.cbFuncionamiento.Text = "¿ El funcionamiento es correcto ?";
            this.cbFuncionamiento.UseVisualStyleBackColor = true;
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSiguiente.Location = new System.Drawing.Point(203, 276);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(144, 31);
            this.btnSiguiente.TabIndex = 6;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            // 
            // FormEvaluacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 319);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.gbSimple);
            this.Controls.Add(this.gbParametrica);
            this.Controls.Add(this.tbDescripcion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.label1);
            this.Name = "FormEvaluacion";
            this.Text = "Form Evaluacion";
            this.gbParametrica.ResumeLayout(false);
            this.gbParametrica.PerformLayout();
            this.gbSimple.ResumeLayout(false);
            this.gbSimple.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox tbNombre;
        public System.Windows.Forms.TextBox tbDescripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSiguiente;
        public System.Windows.Forms.TextBox tbMinimo;
        public System.Windows.Forms.TextBox tbMaximo;
        public System.Windows.Forms.GroupBox gbParametrica;
        public System.Windows.Forms.Label lbUnidad;
        public System.Windows.Forms.TextBox tbMedido;
        public System.Windows.Forms.GroupBox gbSimple;
        public System.Windows.Forms.CheckBox cbFuncionamiento;
    }
}