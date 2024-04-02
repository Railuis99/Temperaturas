namespace Aula10
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listaMes = new System.Windows.Forms.ListBox();
            this.listaTemp = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTempReg = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.selMes = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNTemp = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtMesTxt = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.txtTempMedia = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTempMax = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.txtTempMin = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.selMes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(632, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Temperaturas registradas em Portugal em 2023";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Meses do ano";
            // 
            // listaMes
            // 
            this.listaMes.FormattingEnabled = true;
            this.listaMes.Location = new System.Drawing.Point(54, 102);
            this.listaMes.Name = "listaMes";
            this.listaMes.Size = new System.Drawing.Size(120, 264);
            this.listaMes.TabIndex = 2;
            this.listaMes.SelectedIndexChanged += new System.EventHandler(this.listaMes_SelectedIndexChanged);
            // 
            // listaTemp
            // 
            this.listaTemp.FormattingEnabled = true;
            this.listaTemp.Location = new System.Drawing.Point(180, 102);
            this.listaTemp.Name = "listaTemp";
            this.listaTemp.Size = new System.Drawing.Size(120, 264);
            this.listaTemp.TabIndex = 3;
            this.listaTemp.SelectedIndexChanged += new System.EventHandler(this.listaTemp_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(177, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Temperaturas médias";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(336, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Temperaturas registradas: ";
            // 
            // txtTempReg
            // 
            this.txtTempReg.Location = new System.Drawing.Point(465, 99);
            this.txtTempReg.Name = "txtTempReg";
            this.txtTempReg.ReadOnly = true;
            this.txtTempReg.Size = new System.Drawing.Size(97, 20);
            this.txtTempReg.TabIndex = 6;
            this.txtTempReg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(336, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Atualização de Temperaturas";
            // 
            // selMes
            // 
            this.selMes.Location = new System.Drawing.Point(465, 275);
            this.selMes.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.selMes.Name = "selMes";
            this.selMes.Size = new System.Drawing.Size(97, 20);
            this.selMes.TabIndex = 8;
            this.selMes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.selMes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.selMes.ValueChanged += new System.EventHandler(this.selMes_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(336, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Selecione o mês:";
            // 
            // txtNTemp
            // 
            this.txtNTemp.Location = new System.Drawing.Point(465, 313);
            this.txtNTemp.Name = "txtNTemp";
            this.txtNTemp.Size = new System.Drawing.Size(186, 20);
            this.txtNTemp.TabIndex = 11;
            this.txtNTemp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(336, 316);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Nova temperatura: ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(339, 345);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Gravar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(522, 345);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Eliminar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtMesTxt
            // 
            this.txtMesTxt.Location = new System.Drawing.Point(566, 274);
            this.txtMesTxt.Name = "txtMesTxt";
            this.txtMesTxt.ReadOnly = true;
            this.txtMesTxt.Size = new System.Drawing.Size(85, 20);
            this.txtMesTxt.TabIndex = 14;
            this.txtMesTxt.Text = "Janeiro";
            this.txtMesTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(566, 99);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(85, 21);
            this.button3.TabIndex = 15;
            this.button3.Text = "Refresh";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtTempMedia
            // 
            this.txtTempMedia.Location = new System.Drawing.Point(465, 127);
            this.txtTempMedia.Name = "txtTempMedia";
            this.txtTempMedia.ReadOnly = true;
            this.txtTempMedia.Size = new System.Drawing.Size(97, 20);
            this.txtTempMedia.TabIndex = 17;
            this.txtTempMedia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(355, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Temperatura média: ";
            // 
            // txtTempMax
            // 
            this.txtTempMax.Location = new System.Drawing.Point(465, 150);
            this.txtTempMax.Name = "txtTempMax";
            this.txtTempMax.ReadOnly = true;
            this.txtTempMax.Size = new System.Drawing.Size(97, 20);
            this.txtTempMax.TabIndex = 19;
            this.txtTempMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(357, 153);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Temperatura máxima: ";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(566, 153);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(85, 21);
            this.button4.TabIndex = 20;
            this.button4.Text = ">>";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(566, 182);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(39, 21);
            this.button5.TabIndex = 23;
            this.button5.Text = "1";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // txtTempMin
            // 
            this.txtTempMin.Location = new System.Drawing.Point(465, 179);
            this.txtTempMin.Name = "txtTempMin";
            this.txtTempMin.ReadOnly = true;
            this.txtTempMin.Size = new System.Drawing.Size(97, 20);
            this.txtTempMin.TabIndex = 22;
            this.txtTempMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(357, 182);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Temperatura mínima: ";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(612, 182);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(39, 21);
            this.button6.TabIndex = 24;
            this.button6.Text = "2";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(339, 127);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(19, 72);
            this.button7.TabIndex = 25;
            this.button7.Text = ">";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(657, 99);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(39, 21);
            this.button8.TabIndex = 26;
            this.button8.Text = "1T";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(657, 126);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(39, 21);
            this.button9.TabIndex = 27;
            this.button9.Text = "2T";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(657, 153);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(39, 21);
            this.button10.TabIndex = 28;
            this.button10.Text = "3T";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(657, 182);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(39, 21);
            this.button11.TabIndex = 29;
            this.button11.Text = "4T";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 411);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.txtTempMin);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.txtTempMax);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtTempMedia);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtMesTxt);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtNTemp);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.selMes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTempReg);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listaTemp);
            this.Controls.Add(this.listaMes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Temperatura";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.selMes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listaMes;
        private System.Windows.Forms.ListBox listaTemp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTempReg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown selMes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNTemp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtMesTxt;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtTempMedia;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTempMax;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox txtTempMin;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
    }
}

