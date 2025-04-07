namespace GRAFICO
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TXT_X_MIN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TXT_X_MAX = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TXT_X_INTERVALO = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TXT_Y_INTERVALO = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TXT_Y_MAX = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TXT_Y_MIN = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TXT_MINOR_X = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TXT_LINHA_ESPESSURA = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TXT_MINOR_Y = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.TXT_ATUALIZA = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(53, 85);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(719, 312);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            this.chart1.DoubleClick += new System.EventHandler(this.chart1_DoubleClick);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TXT_X_MIN
            // 
            this.TXT_X_MIN.Location = new System.Drawing.Point(63, 3);
            this.TXT_X_MIN.Name = "TXT_X_MIN";
            this.TXT_X_MIN.Size = new System.Drawing.Size(27, 20);
            this.TXT_X_MIN.TabIndex = 1;
            this.TXT_X_MIN.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "X MIN:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "X MAX:";
            // 
            // TXT_X_MAX
            // 
            this.TXT_X_MAX.Location = new System.Drawing.Point(63, 29);
            this.TXT_X_MAX.Name = "TXT_X_MAX";
            this.TXT_X_MAX.Size = new System.Drawing.Size(27, 20);
            this.TXT_X_MAX.TabIndex = 3;
            this.TXT_X_MAX.Text = "50";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "X INTER:";
            // 
            // TXT_X_INTERVALO
            // 
            this.TXT_X_INTERVALO.Location = new System.Drawing.Point(63, 54);
            this.TXT_X_INTERVALO.Name = "TXT_X_INTERVALO";
            this.TXT_X_INTERVALO.Size = new System.Drawing.Size(27, 20);
            this.TXT_X_INTERVALO.TabIndex = 9;
            this.TXT_X_INTERVALO.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Y INTER:";
            // 
            // TXT_Y_INTERVALO
            // 
            this.TXT_Y_INTERVALO.Location = new System.Drawing.Point(155, 54);
            this.TXT_Y_INTERVALO.Name = "TXT_Y_INTERVALO";
            this.TXT_Y_INTERVALO.Size = new System.Drawing.Size(27, 20);
            this.TXT_Y_INTERVALO.TabIndex = 15;
            this.TXT_Y_INTERVALO.Text = "10";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(96, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Y MAX:";
            // 
            // TXT_Y_MAX
            // 
            this.TXT_Y_MAX.Location = new System.Drawing.Point(155, 29);
            this.TXT_Y_MAX.Name = "TXT_Y_MAX";
            this.TXT_Y_MAX.Size = new System.Drawing.Size(27, 20);
            this.TXT_Y_MAX.TabIndex = 13;
            this.TXT_Y_MAX.Text = "30";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(96, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Y MIN:";
            // 
            // TXT_Y_MIN
            // 
            this.TXT_Y_MIN.Location = new System.Drawing.Point(155, 3);
            this.TXT_Y_MIN.Name = "TXT_Y_MIN";
            this.TXT_Y_MIN.Size = new System.Drawing.Size(27, 20);
            this.TXT_Y_MIN.TabIndex = 11;
            this.TXT_Y_MIN.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(188, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "X SUB INTER:";
            // 
            // TXT_MINOR_X
            // 
            this.TXT_MINOR_X.Location = new System.Drawing.Point(272, 3);
            this.TXT_MINOR_X.Name = "TXT_MINOR_X";
            this.TXT_MINOR_X.Size = new System.Drawing.Size(27, 20);
            this.TXT_MINOR_X.TabIndex = 19;
            this.TXT_MINOR_X.Text = "1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(612, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "ESPESSURA LINHA:";
            // 
            // TXT_LINHA_ESPESSURA
            // 
            this.TXT_LINHA_ESPESSURA.Location = new System.Drawing.Point(728, 7);
            this.TXT_LINHA_ESPESSURA.Name = "TXT_LINHA_ESPESSURA";
            this.TXT_LINHA_ESPESSURA.Size = new System.Drawing.Size(27, 20);
            this.TXT_LINHA_ESPESSURA.TabIndex = 17;
            this.TXT_LINHA_ESPESSURA.Text = "1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(188, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Y SUB INTER:";
            // 
            // TXT_MINOR_Y
            // 
            this.TXT_MINOR_Y.Location = new System.Drawing.Point(272, 29);
            this.TXT_MINOR_Y.Name = "TXT_MINOR_Y";
            this.TXT_MINOR_Y.Size = new System.Drawing.Size(27, 20);
            this.TXT_MINOR_Y.TabIndex = 21;
            this.TXT_MINOR_Y.Text = "2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(691, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 22);
            this.button1.TabIndex = 23;
            this.button1.Text = "APLICAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(612, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "ATUALIZA EM MS.:";
            // 
            // TXT_ATUALIZA
            // 
            this.TXT_ATUALIZA.Location = new System.Drawing.Point(712, 31);
            this.TXT_ATUALIZA.Name = "TXT_ATUALIZA";
            this.TXT_ATUALIZA.Size = new System.Drawing.Size(43, 20);
            this.TXT_ATUALIZA.TabIndex = 25;
            this.TXT_ATUALIZA.Text = "1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 224);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "label11";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(370, 400);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "label12";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 422);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.TXT_ATUALIZA);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TXT_MINOR_Y);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TXT_MINOR_X);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TXT_LINHA_ESPESSURA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TXT_Y_INTERVALO);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TXT_Y_MAX);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TXT_Y_MIN);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TXT_X_INTERVALO);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TXT_X_MAX);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXT_X_MIN);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox TXT_X_MIN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXT_X_MAX;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TXT_X_INTERVALO;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXT_Y_INTERVALO;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TXT_Y_MAX;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TXT_Y_MIN;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TXT_MINOR_X;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TXT_LINHA_ESPESSURA;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TXT_MINOR_Y;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TXT_ATUALIZA;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}

