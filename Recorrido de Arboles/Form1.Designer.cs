namespace Recorrido_de_Arboles
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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblRaiz = new System.Windows.Forms.Label();
            this.lblPadre = new System.Windows.Forms.Label();
            this.lblHijo = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.cbPadre = new System.Windows.Forms.ComboBox();
            this.btnRaiz = new System.Windows.Forms.Button();
            this.btnHijo = new System.Windows.Forms.Button();
            this.btnExpand = new System.Windows.Forms.Button();
            this.btnRecorrido = new System.Windows.Forms.Button();
            this.btnColapse = new System.Windows.Forms.Button();
            this.btnEjemplo = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(472, 438);
            this.treeView1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(519, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // lblRaiz
            // 
            this.lblRaiz.AutoSize = true;
            this.lblRaiz.Location = new System.Drawing.Point(478, 15);
            this.lblRaiz.Name = "lblRaiz";
            this.lblRaiz.Size = new System.Drawing.Size(30, 13);
            this.lblRaiz.TabIndex = 3;
            this.lblRaiz.Text = "Raíz";
            // 
            // lblPadre
            // 
            this.lblPadre.AutoSize = true;
            this.lblPadre.Location = new System.Drawing.Point(478, 56);
            this.lblPadre.Name = "lblPadre";
            this.lblPadre.Size = new System.Drawing.Size(35, 13);
            this.lblPadre.TabIndex = 4;
            this.lblPadre.Text = "Padre";
            // 
            // lblHijo
            // 
            this.lblHijo.AutoSize = true;
            this.lblHijo.Location = new System.Drawing.Point(657, 56);
            this.lblHijo.Name = "lblHijo";
            this.lblHijo.Size = new System.Drawing.Size(25, 13);
            this.lblHijo.TabIndex = 5;
            this.lblHijo.Text = "Hijo";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(688, 56);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 6;
            // 
            // cbPadre
            // 
            this.cbPadre.FormattingEnabled = true;
            this.cbPadre.Location = new System.Drawing.Point(519, 53);
            this.cbPadre.Name = "cbPadre";
            this.cbPadre.Size = new System.Drawing.Size(121, 21);
            this.cbPadre.TabIndex = 7;
            // 
            // btnRaiz
            // 
            this.btnRaiz.Location = new System.Drawing.Point(644, 12);
            this.btnRaiz.Name = "btnRaiz";
            this.btnRaiz.Size = new System.Drawing.Size(75, 23);
            this.btnRaiz.TabIndex = 8;
            this.btnRaiz.Text = "Add";
            this.btnRaiz.UseVisualStyleBackColor = true;
            // 
            // btnHijo
            // 
            this.btnHijo.Location = new System.Drawing.Point(817, 56);
            this.btnHijo.Name = "btnHijo";
            this.btnHijo.Size = new System.Drawing.Size(75, 23);
            this.btnHijo.TabIndex = 9;
            this.btnHijo.Text = "button2";
            this.btnHijo.UseVisualStyleBackColor = true;
            // 
            // btnExpand
            // 
            this.btnExpand.Location = new System.Drawing.Point(519, 98);
            this.btnExpand.Name = "btnExpand";
            this.btnExpand.Size = new System.Drawing.Size(75, 23);
            this.btnExpand.TabIndex = 10;
            this.btnExpand.Text = "Expand";
            this.btnExpand.UseVisualStyleBackColor = true;
            // 
            // btnRecorrido
            // 
            this.btnRecorrido.Location = new System.Drawing.Point(607, 98);
            this.btnRecorrido.Name = "btnRecorrido";
            this.btnRecorrido.Size = new System.Drawing.Size(75, 23);
            this.btnRecorrido.TabIndex = 11;
            this.btnRecorrido.Text = "Recorrido";
            this.btnRecorrido.UseVisualStyleBackColor = true;
            // 
            // btnColapse
            // 
            this.btnColapse.Location = new System.Drawing.Point(519, 127);
            this.btnColapse.Name = "btnColapse";
            this.btnColapse.Size = new System.Drawing.Size(75, 23);
            this.btnColapse.TabIndex = 12;
            this.btnColapse.Text = "Colapse";
            this.btnColapse.UseVisualStyleBackColor = true;
            // 
            // btnEjemplo
            // 
            this.btnEjemplo.Location = new System.Drawing.Point(607, 127);
            this.btnEjemplo.Name = "btnEjemplo";
            this.btnEjemplo.Size = new System.Drawing.Size(75, 23);
            this.btnEjemplo.TabIndex = 13;
            this.btnEjemplo.Text = "Ejemplo";
            this.btnEjemplo.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(688, 127);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 14;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 450);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnEjemplo);
            this.Controls.Add(this.btnColapse);
            this.Controls.Add(this.btnRecorrido);
            this.Controls.Add(this.btnExpand);
            this.Controls.Add(this.btnHijo);
            this.Controls.Add(this.btnRaiz);
            this.Controls.Add(this.cbPadre);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.lblHijo);
            this.Controls.Add(this.lblPadre);
            this.Controls.Add(this.lblRaiz);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblRaiz;
        private System.Windows.Forms.Label lblPadre;
        private System.Windows.Forms.Label lblHijo;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox cbPadre;
        private System.Windows.Forms.Button btnRaiz;
        private System.Windows.Forms.Button btnHijo;
        private System.Windows.Forms.Button btnExpand;
        private System.Windows.Forms.Button btnRecorrido;
        private System.Windows.Forms.Button btnColapse;
        private System.Windows.Forms.Button btnEjemplo;
        private System.Windows.Forms.Button btnLimpiar;
    }
}

