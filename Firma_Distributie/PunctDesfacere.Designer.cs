namespace Firma_Distributie
{
    partial class PunctDesfacere
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.id_articol = new System.Windows.Forms.TextBox();
            this.pret_vanzare = new System.Windows.Forms.TextBox();
            this.tip = new System.Windows.Forms.TextBox();
            this.titlu = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.nrBuc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Articol";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Titlu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pret Vanzare";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tip";
            // 
            // id_articol
            // 
            this.id_articol.Location = new System.Drawing.Point(133, 43);
            this.id_articol.Name = "id_articol";
            this.id_articol.Size = new System.Drawing.Size(100, 20);
            this.id_articol.TabIndex = 4;
            // 
            // pret_vanzare
            // 
            this.pret_vanzare.Location = new System.Drawing.Point(133, 142);
            this.pret_vanzare.Name = "pret_vanzare";
            this.pret_vanzare.Size = new System.Drawing.Size(100, 20);
            this.pret_vanzare.TabIndex = 5;
            // 
            // tip
            // 
            this.tip.Location = new System.Drawing.Point(133, 191);
            this.tip.Name = "tip";
            this.tip.Size = new System.Drawing.Size(100, 20);
            this.tip.TabIndex = 6;
            // 
            // titlu
            // 
            this.titlu.Location = new System.Drawing.Point(133, 95);
            this.titlu.Name = "titlu";
            this.titlu.Size = new System.Drawing.Size(100, 20);
            this.titlu.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 295);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 94);
            this.button1.TabIndex = 8;
            this.button1.Text = "Adauga";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(251, 411);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 27);
            this.button2.TabIndex = 26;
            this.button2.Text = "Back to menu";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // nrBuc
            // 
            this.nrBuc.Location = new System.Drawing.Point(133, 246);
            this.nrBuc.Name = "nrBuc";
            this.nrBuc.Size = new System.Drawing.Size(100, 20);
            this.nrBuc.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Nr. Bucati";
            // 
            // PunctDesfacere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nrBuc);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.titlu);
            this.Controls.Add(this.tip);
            this.Controls.Add(this.pret_vanzare);
            this.Controls.Add(this.id_articol);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PunctDesfacere";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PunctDesfacere";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox id_articol;
        private System.Windows.Forms.TextBox pret_vanzare;
        private System.Windows.Forms.TextBox tip;
        private System.Windows.Forms.TextBox titlu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox nrBuc;
        private System.Windows.Forms.Label label5;
    }
}