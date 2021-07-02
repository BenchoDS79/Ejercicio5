namespace Ejercicio5
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
            this.button1Ejecutar = new System.Windows.Forms.Button();
            this.button2Limpiar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FilastextBox1 = new System.Windows.Forms.TextBox();
            this.ColumnastextBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1Ejecutar
            // 
            this.button1Ejecutar.Location = new System.Drawing.Point(14, 134);
            this.button1Ejecutar.Name = "button1Ejecutar";
            this.button1Ejecutar.Size = new System.Drawing.Size(75, 23);
            this.button1Ejecutar.TabIndex = 0;
            this.button1Ejecutar.Text = "Ejecutar";
            this.button1Ejecutar.UseVisualStyleBackColor = true;
            this.button1Ejecutar.Click += new System.EventHandler(this.button1Ejecutar_Click);
            // 
            // button2Limpiar
            // 
            this.button2Limpiar.Location = new System.Drawing.Point(196, 134);
            this.button2Limpiar.Name = "button2Limpiar";
            this.button2Limpiar.Size = new System.Drawing.Size(75, 23);
            this.button2Limpiar.TabIndex = 1;
            this.button2Limpiar.Text = "Limpiar";
            this.button2Limpiar.UseVisualStyleBackColor = true;
            this.button2Limpiar.Click += new System.EventHandler(this.button2Limpiar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "FILAS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "COLUMNAS";
            // 
            // FilastextBox1
            // 
            this.FilastextBox1.Location = new System.Drawing.Point(109, 21);
            this.FilastextBox1.Name = "FilastextBox1";
            this.FilastextBox1.Size = new System.Drawing.Size(100, 20);
            this.FilastextBox1.TabIndex = 4;
            // 
            // ColumnastextBox2
            // 
            this.ColumnastextBox2.Location = new System.Drawing.Point(109, 64);
            this.ColumnastextBox2.Name = "ColumnastextBox2";
            this.ColumnastextBox2.Size = new System.Drawing.Size(100, 20);
            this.ColumnastextBox2.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 182);
            this.Controls.Add(this.ColumnastextBox2);
            this.Controls.Add(this.FilastextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2Limpiar);
            this.Controls.Add(this.button1Ejecutar);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1Ejecutar;
        private System.Windows.Forms.Button button2Limpiar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FilastextBox1;
        private System.Windows.Forms.TextBox ColumnastextBox2;
    }
}

