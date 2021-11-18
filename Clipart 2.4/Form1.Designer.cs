namespace Clipart_2._4
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLinje = new System.Windows.Forms.Button();
            this.btnCirkel = new System.Windows.Forms.Button();
            this.btnTriangel = new System.Windows.Forms.Button();
            this.tbxHöjd = new System.Windows.Forms.TextBox();
            this.tbxBredd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbxFigur = new System.Windows.Forms.ListBox();
            this.btnArea = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxArea = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLinje);
            this.groupBox1.Controls.Add(this.btnCirkel);
            this.groupBox1.Controls.Add(this.btnTriangel);
            this.groupBox1.Controls.Add(this.tbxHöjd);
            this.groupBox1.Controls.Add(this.tbxBredd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(21, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(390, 338);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Skapa";
            // 
            // btnLinje
            // 
            this.btnLinje.Location = new System.Drawing.Point(66, 261);
            this.btnLinje.Name = "btnLinje";
            this.btnLinje.Size = new System.Drawing.Size(139, 31);
            this.btnLinje.TabIndex = 6;
            this.btnLinje.Text = "Skapa Linje";
            this.btnLinje.UseVisualStyleBackColor = true;
            this.btnLinje.Click += new System.EventHandler(this.btnLinje_Click);
            // 
            // btnCirkel
            // 
            this.btnCirkel.Location = new System.Drawing.Point(66, 209);
            this.btnCirkel.Name = "btnCirkel";
            this.btnCirkel.Size = new System.Drawing.Size(139, 31);
            this.btnCirkel.TabIndex = 5;
            this.btnCirkel.Text = "Skapa Cirkel";
            this.btnCirkel.UseVisualStyleBackColor = true;
            this.btnCirkel.Click += new System.EventHandler(this.btnCirkel_Click);
            // 
            // btnTriangel
            // 
            this.btnTriangel.Location = new System.Drawing.Point(66, 155);
            this.btnTriangel.Name = "btnTriangel";
            this.btnTriangel.Size = new System.Drawing.Size(139, 31);
            this.btnTriangel.TabIndex = 4;
            this.btnTriangel.Text = "Skapa Triangel";
            this.btnTriangel.UseVisualStyleBackColor = true;
            this.btnTriangel.Click += new System.EventHandler(this.btnTriangel_Click);
            // 
            // tbxHöjd
            // 
            this.tbxHöjd.Location = new System.Drawing.Point(66, 83);
            this.tbxHöjd.Name = "tbxHöjd";
            this.tbxHöjd.Size = new System.Drawing.Size(125, 26);
            this.tbxHöjd.TabIndex = 3;
            // 
            // tbxBredd
            // 
            this.tbxBredd.Location = new System.Drawing.Point(66, 38);
            this.tbxBredd.Name = "tbxBredd";
            this.tbxBredd.Size = new System.Drawing.Size(125, 26);
            this.tbxBredd.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Höjd";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bredd";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(483, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Figurlista";
            // 
            // lbxFigur
            // 
            this.lbxFigur.FormattingEnabled = true;
            this.lbxFigur.ItemHeight = 20;
            this.lbxFigur.Location = new System.Drawing.Point(487, 50);
            this.lbxFigur.Name = "lbxFigur";
            this.lbxFigur.Size = new System.Drawing.Size(246, 284);
            this.lbxFigur.TabIndex = 2;
            // 
            // btnArea
            // 
            this.btnArea.Location = new System.Drawing.Point(87, 392);
            this.btnArea.Name = "btnArea";
            this.btnArea.Size = new System.Drawing.Size(166, 32);
            this.btnArea.TabIndex = 3;
            this.btnArea.Text = "Sammanlagd Area";
            this.btnArea.UseVisualStyleBackColor = true;
            this.btnArea.Click += new System.EventHandler(this.btnArea_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(483, 365);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Sammanlagd area";
            // 
            // tbxArea
            // 
            this.tbxArea.Location = new System.Drawing.Point(487, 397);
            this.tbxArea.Name = "tbxArea";
            this.tbxArea.Size = new System.Drawing.Size(137, 26);
            this.tbxArea.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbxArea);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnArea);
            this.Controls.Add(this.lbxFigur);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLinje;
        private System.Windows.Forms.Button btnCirkel;
        private System.Windows.Forms.Button btnTriangel;
        private System.Windows.Forms.TextBox tbxHöjd;
        private System.Windows.Forms.TextBox tbxBredd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbxFigur;
        private System.Windows.Forms.Button btnArea;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxArea;
    }
}

