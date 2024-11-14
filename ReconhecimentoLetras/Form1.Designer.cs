namespace ReconhecimentoLetras
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.comboBoxFonte = new System.Windows.Forms.ComboBox();
            this.comboBoxLetra = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.QuantidadeCiclos = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonTreinar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.GraficoErroQuadratico = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridVisualizacao = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonTestar = new System.Windows.Forms.Button();
            this.labelRespostaRede = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridTeste = new System.Windows.Forms.DataGridView();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GraficoErroQuadratico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVisualizacao)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTeste)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxFonte
            // 
            this.comboBoxFonte.FormattingEnabled = true;
            this.comboBoxFonte.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.comboBoxFonte.Location = new System.Drawing.Point(63, 111);
            this.comboBoxFonte.Name = "comboBoxFonte";
            this.comboBoxFonte.Size = new System.Drawing.Size(121, 24);
            this.comboBoxFonte.TabIndex = 0;
            this.comboBoxFonte.SelectedIndexChanged += new System.EventHandler(this.comboBoxFonte_SelectedIndexChanged_1);
            // 
            // comboBoxLetra
            // 
            this.comboBoxLetra.FormattingEnabled = true;
            this.comboBoxLetra.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "J",
            "K"});
            this.comboBoxLetra.Location = new System.Drawing.Point(63, 194);
            this.comboBoxLetra.Name = "comboBoxLetra";
            this.comboBoxLetra.Size = new System.Drawing.Size(121, 24);
            this.comboBoxLetra.TabIndex = 1;
            this.comboBoxLetra.SelectedIndexChanged += new System.EventHandler(this.comboBoxLetra_SelectedIndexChanged_1);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox1.Controls.Add(this.QuantidadeCiclos);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.buttonTreinar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.GraficoErroQuadratico);
            this.groupBox1.Controls.Add(this.dataGridVisualizacao);
            this.groupBox1.Controls.Add(this.comboBoxFonte);
            this.groupBox1.Controls.Add(this.comboBoxLetra);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(42, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(728, 750);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Base de Treinamento";
            // 
            // QuantidadeCiclos
            // 
            this.QuantidadeCiclos.AutoSize = true;
            this.QuantidadeCiclos.Location = new System.Drawing.Point(265, 684);
            this.QuantidadeCiclos.Name = "QuantidadeCiclos";
            this.QuantidadeCiclos.Size = new System.Drawing.Size(19, 16);
            this.QuantidadeCiclos.TabIndex = 8;
            this.QuantidadeCiclos.Text = "---";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "LETRA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(68, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "FONTE";
            // 
            // buttonTreinar
            // 
            this.buttonTreinar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonTreinar.Location = new System.Drawing.Point(615, 696);
            this.buttonTreinar.Name = "buttonTreinar";
            this.buttonTreinar.Size = new System.Drawing.Size(91, 48);
            this.buttonTreinar.TabIndex = 5;
            this.buttonTreinar.Text = "TREINAR";
            this.buttonTreinar.UseVisualStyleBackColor = false;
            this.buttonTreinar.Click += new System.EventHandler(this.buttonTreinar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(172, 684);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "CICLOS:";
            // 
            // GraficoErroQuadratico
            // 
            chartArea1.Name = "ChartArea1";
            this.GraficoErroQuadratico.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.GraficoErroQuadratico.Legends.Add(legend1);
            this.GraficoErroQuadratico.Location = new System.Drawing.Point(9, 420);
            this.GraficoErroQuadratico.Name = "GraficoErroQuadratico";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.GraficoErroQuadratico.Series.Add(series1);
            this.GraficoErroQuadratico.Size = new System.Drawing.Size(697, 233);
            this.GraficoErroQuadratico.TabIndex = 3;
            this.GraficoErroQuadratico.Text = "chart1";
            // 
            // dataGridVisualizacao
            // 
            this.dataGridVisualizacao.AllowUserToOrderColumns = true;
            this.dataGridVisualizacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridVisualizacao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataGridVisualizacao.Location = new System.Drawing.Point(218, 78);
            this.dataGridVisualizacao.Name = "dataGridVisualizacao";
            this.dataGridVisualizacao.RowHeadersWidth = 51;
            this.dataGridVisualizacao.RowTemplate.Height = 24;
            this.dataGridVisualizacao.Size = new System.Drawing.Size(453, 321);
            this.dataGridVisualizacao.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "1";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 43;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.HeaderText = "2";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 43;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column3.HeaderText = "3";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 43;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column4.HeaderText = "4";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 43;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column5.HeaderText = "5";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 43;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column6.HeaderText = "6";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 43;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column7.HeaderText = "7";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 43;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightGray;
            this.groupBox2.Controls.Add(this.buttonTestar);
            this.groupBox2.Controls.Add(this.labelRespostaRede);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.dataGridTeste);
            this.groupBox2.Location = new System.Drawing.Point(788, 36);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(655, 750);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Teste da Rede Neural";
            // 
            // buttonTestar
            // 
            this.buttonTestar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonTestar.Location = new System.Drawing.Point(533, 696);
            this.buttonTestar.Name = "buttonTestar";
            this.buttonTestar.Size = new System.Drawing.Size(98, 48);
            this.buttonTestar.TabIndex = 4;
            this.buttonTestar.Text = "TESTAR";
            this.buttonTestar.UseVisualStyleBackColor = false;
            this.buttonTestar.Click += new System.EventHandler(this.buttonTestar_Click);
            // 
            // labelRespostaRede
            // 
            this.labelRespostaRede.AutoSize = true;
            this.labelRespostaRede.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRespostaRede.ForeColor = System.Drawing.Color.Black;
            this.labelRespostaRede.Location = new System.Drawing.Point(317, 577);
            this.labelRespostaRede.Name = "labelRespostaRede";
            this.labelRespostaRede.Size = new System.Drawing.Size(34, 22);
            this.labelRespostaRede.TabIndex = 3;
            this.labelRespostaRede.Text = "----";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(213, 511);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(236, 22);
            this.label6.TabIndex = 2;
            this.label6.Text = "Resposta da rede neural:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightGray;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SteelBlue;
            this.label5.Location = new System.Drawing.Point(84, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(211, 18);
            this.label5.TabIndex = 1;
            this.label5.Text = "Desenhe a letra no grid abaixo:\r\n";
            // 
            // dataGridTeste
            // 
            this.dataGridTeste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTeste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column14});
            this.dataGridTeste.Location = new System.Drawing.Point(87, 78);
            this.dataGridTeste.Name = "dataGridTeste";
            this.dataGridTeste.RowHeadersWidth = 51;
            this.dataGridTeste.RowTemplate.Height = 24;
            this.dataGridTeste.Size = new System.Drawing.Size(422, 363);
            this.dataGridTeste.TabIndex = 0;
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column8.HeaderText = "1";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.Width = 43;
            // 
            // Column9
            // 
            this.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column9.HeaderText = "2";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.Width = 43;
            // 
            // Column10
            // 
            this.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column10.HeaderText = "3";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            this.Column10.Width = 43;
            // 
            // Column11
            // 
            this.Column11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column11.HeaderText = "4";
            this.Column11.MinimumWidth = 6;
            this.Column11.Name = "Column11";
            this.Column11.Width = 43;
            // 
            // Column12
            // 
            this.Column12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column12.HeaderText = "5";
            this.Column12.MinimumWidth = 6;
            this.Column12.Name = "Column12";
            this.Column12.Width = 43;
            // 
            // Column13
            // 
            this.Column13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column13.HeaderText = "6";
            this.Column13.MinimumWidth = 6;
            this.Column13.Name = "Column13";
            this.Column13.Width = 43;
            // 
            // Column14
            // 
            this.Column14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column14.HeaderText = "7";
            this.Column14.MinimumWidth = 6;
            this.Column14.Name = "Column14";
            this.Column14.Width = 43;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1455, 798);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GraficoErroQuadratico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVisualizacao)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTeste)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxFonte;
        private System.Windows.Forms.ComboBox comboBoxLetra;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonTreinar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart GraficoErroQuadratico;
        private System.Windows.Forms.DataGridView dataGridVisualizacao;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label QuantidadeCiclos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonTestar;
        private System.Windows.Forms.Label labelRespostaRede;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridTeste;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
    }
}

