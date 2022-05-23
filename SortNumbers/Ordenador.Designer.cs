namespace SortNumbers
{
    partial class Ordenador
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumbers = new System.Windows.Forms.TextBox();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnTxt = new System.Windows.Forms.Button();
            this.txtOrdered = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite números, separados por espaço";
            // 
            // txtNumbers
            // 
            this.txtNumbers.Location = new System.Drawing.Point(60, 43);
            this.txtNumbers.Name = "txtNumbers";
            this.txtNumbers.Size = new System.Drawing.Size(411, 27);
            this.txtNumbers.TabIndex = 2;
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(492, 43);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(94, 29);
            this.btnSort.TabIndex = 4;
            this.btnSort.Text = "Ordenar";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnTxt
            // 
            this.btnTxt.Location = new System.Drawing.Point(602, 43);
            this.btnTxt.Name = "btnTxt";
            this.btnTxt.Size = new System.Drawing.Size(165, 29);
            this.btnTxt.TabIndex = 5;
            this.btnTxt.Text = "Gerar documento.txt";
            this.btnTxt.UseVisualStyleBackColor = true;
            this.btnTxt.Click += new System.EventHandler(this.btnTxt_Click);
            // 
            // txtOrdered
            // 
            this.txtOrdered.BackColor = System.Drawing.Color.LightGray;
            this.txtOrdered.Location = new System.Drawing.Point(60, 135);
            this.txtOrdered.Name = "txtOrdered";
            this.txtOrdered.Size = new System.Drawing.Size(411, 27);
            this.txtOrdered.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Resultado ordenado:";
            // 
            // Ordenador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtOrdered);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnTxt);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.txtNumbers);
            this.Controls.Add(this.label1);
            this.Name = "Ordenador";
            this.Text = "Ordenador de Números";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtNumbers;
        private Button btnSort;
        private Button btnTxt;
        private TextBox txtOrdered;
        private Label label2;
    }
}