using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReconhecimentoLetras
{
    public partial class Form1 : Form
    {
        double[,] Fontes = new double[21, 64] { {-1,-1,1,1,-1,-1,-1, -1,-1,-1,1,-1,-1,-1, -1,-1,-1,1,-1,-1,-1, -1,-1,1,-1,1,-1,-1, -1,-1,1,-1,1,-1,-1, -1,1,1,1,1,1,-1, -1,1,-1,-1,-1,1,-1, -1,1,-1,-1,-1,1,-1, 1,1,1,-1,1,1,1,1}, // A fonte 1
       {1,1,1,1,1,1,-1, -1,1,-1,-1,-1,-1,1, -1,1,-1,-1,-1,-1,1, -1,1,-1,-1,-1,-1,1, -1,1,1,1,1,1,-1, -1,1,-1,-1,-1,-1,1, -1,1,-1,-1,-1,-1,1, -1,1,-1,-1,-1,-1,1, 1,1,1,1,1,1,-1,1 }, // B fonte 1
       {-1,-1,1,1,1,1,1, -1,1,-1,-1,-1,-1,1, 1,-1,-1,-1,-1,-1,-1, 1,-1,-1,-1,-1,-1,-1, 1,-1,-1,-1,-1,-1,-1, 1,-1,-1,-1,-1,-1,-1, 1,-1,-1,-1,-1,-1,-1, -1,1,-1,-1,-1,-1,1, -1,-1,1,1,1,1,-1,1},//C fonte 1
       {1,1,1,1,1,-1,-1, -1,1,-1,-1,-1,1,-1, -1,1,-1,-1,-1,-1,1, -1,1,-1,-1,-1,-1,1, -1,1,-1,-1,-1,-1,1, -1,1,-1,-1,-1,-1,1, -1,1,-1,-1,-1,-1,1, -1,1,-1,-1,-1,1,-1, 1,1,1,1,1,-1,-1,1 },// d fonte 1
       {1,1,1,1,1,1,1, -1,1,-1,-1,-1,-1,1, -1,1,-1,-1,-1,-1,-1, -1,1,-1,1,-1,-1,-1, -1,1,1,1,-1,-1,-1, -1,1,-1,1,-1,-1,-1, -1,1,-1,-1,-1,-1,-1, -1,1,-1,-1,-1,-1,1, 1,1,1,1,1,1,1,1 },// e fonte 1
       {-1,-1,-1,1,1,1,1, -1,-1,-1,-1,-1,1,-1, -1,-1,-1,-1,-1,1,-1, -1,-1,-1,-1,-1,1,-1, -1,-1,-1,-1,-1,1,-1, -1,-1,-1,-1,-1,1,-1, -1,1,-1,-1,-1,1,-1, -1,1,-1,-1,-1,1,-1, -1,-1,1,1,1,-1,-1,1 },//j fonte 1
       {1,1,1,-1,-1,1,1, -1,1,-1,-1,1,-1,-1, -1,1,-1,1,-1,-1,-1, -1,1,1,-1,-1,-1,-1, -1,1,1,-1,-1,-1,-1, -1,1,-1,1,-1,-1,-1, -1,1,-1,-1,1,-1,-1, -1,1,-1,-1,-1,1,-1, 1,1,1,-1,-1,1,1,1 },//k fonte 1
       {-1,-1,-1,1,-1,-1,-1, -1,-1,-1,1,-1,-1,-1, -1,-1,-1,1,-1,-1,-1, -1,-1,1,-1,1,-1,-1, -1,-1,1,-1,1,-1,-1, -1,1,-1,-1,-1,1,-1, -1,1,1,1,1,1,-1, -1,1,-1,-1,-1,1,-1, -1,1,-1,-1,-1,1,-1,1 },//A fonte 2
       {1,1,1,1,1,1,-1, 1,-1,-1,-1,-1,-1,1, 1,-1,-1,-1,-1,-1,1, 1,-1,-1,-1,-1,-1,1, 1,1,1,1,1,1,-1, 1,-1,-1,-1,-1,-1,1, 1,-1,-1,-1,-1,-1,1, 1,-1,-1,-1,-1,-1,1, 1,1,1,1,1,1,-1,1 },//b fonte2
       {-1,-1,1,1,1,-1,-1, -1,1,-1,-1,-1,1,-1, 1,-1,-1,-1,-1,-1,1, 1,-1,-1,-1,-1,-1,-1, 1,-1,-1,-1,-1,-1,-1, 1,-1,-1,-1,-1,-1,-1, 1,-1,-1,-1,-1,-1,1, -1,1,-1,-1,-1,1,-1, -1,-1,1,1,1,-1,-1,1 },//c fonte 2
       {1,1,1,1,1,-1,-1, 1,-1,-1,-1,-1,1,-1, 1,-1,-1,-1,-1,-1,1, 1,-1,-1,-1,-1,-1,1, 1,-1,-1,-1,-1,-1,1, 1,-1,-1,-1,-1,-1,1, 1,-1,-1,-1,-1,-1,1, 1,-1,-1,-1,-1,1,-1, 1,1,1,1,1,-1,-1,1 }, //d fonte 2
       {1,1,1,1,1,1,1, 1,-1,-1,-1,-1,-1,-1, 1,-1,-1,-1,-1,-1,-1, 1,-1,-1,-1,-1,-1,-1, 1,1,1,1,1,-1,-1, 1,-1,-1,-1,-1,-1,-1, 1,-1,-1,-1,-1,-1,-1, 1,-1,-1,-1,-1,-1,-1, 1,1,1,1,1,1,1,1 },// e fonte 2
       {-1,-1,-1,-1,-1,1,-1, -1,-1,-1,-1,-1,1,-1, -1,-1,-1,-1,-1,1,-1, -1,-1,-1,-1,-1,1,-1, -1,-1,-1,-1,-1,1,-1, -1,-1,-1,-1,-1,1,-1, -1,1,-1,-1,-1,1,-1, -1,1,-1,-1,-1,1,-1, -1,-1,1,1,1,-1,-1,1 }, //j fonte 2
       {1,-1,-1,-1,-1,1,-1, 1,-1,-1,-1,1,-1,-1, 1,-1,-1,1,-1,-1,-1, 1,-1,1,-1,-1,-1,-1, 1,1,-1,-1,-1,-1,-1, 1,-1,1,-1,-1,-1,-1, 1,-1,-1,1,-1,-1,-1, 1,-1,-1,-1,1,-1,-1, 1,-1,-1,-1,-1,1,-1,1 },//k fonte 2 
       {-1,-1,-1,1,-1,-1,-1, -1,-1,-1,1,-1,-1,-1, -1,-1,1,-1,1,-1,-1, -1,-1,1,-1,1,-1,-1, -1,1,-1,-1,-1,1,-1, -1,1,1,1,1,1,-1, -1,1,1,1,1,1,-1, 1,-1,-1,-1,-1,-1,1, 1,1,-1,-1,-1,1,1,1 }, //a fonte 3
       {1,1,1,1,1,1,-1, -1,1,-1,-1,-1,-1,1, -1,1,-1,-1,-1,-1,1, -1,1,1,1,1,1,-1, -1,1,-1,-1,-1,-1,1, -1,1,-1,-1,-1,-1,1, -1,1,-1,-1,-1,-1,1, -1,1,-1,-1,-1,-1,1, 1,1,1,1,1,1,-1,1 },//b fonte 3
       {-1,-1,1,1,1,-1,1, -1,1,-1,-1,-1,1,1, 1,-1,-1,-1,-1,-1,1, 1,-1,-1,-1,-1,-1,-1, 1,-1,-1,-1,-1,-1,-1, 1,-1,-1,-1,-1,-1,-1, 1,-1,-1,-1,-1,-1,1, -1,1,-1,-1,-1,1,-1, -1,-1,1,1,1,-1,-1,1 },//c fonte 3
       {1,1,1,1,1,-1,-1, -1,1,-1,-1,-1,1,-1, -1,1,-1,-1,-1,-1,1, -1,1,-1,-1,-1,-1,1, -1,1,-1,-1,-1,-1,1, -1,1,-1,-1,-1,-1,1, -1,1,-1,-1,-1,-1,1, -1,1,-1,-1,-1,1,-1, 1,1,1,1,1,-1,-1,1 },//d fonte 3
       {1,1,1,1,1,1,1, -1,1,-1,-1,-1,-1,1, -1,1,-1,-1,1,-1,-1, -1,1,1,1,1,-1,-1, -1,1,-1,-1,1,-1,-1, -1,1,-1,-1,-1,-1,-1, -1,1,-1,-1,-1,-1,-1, -1,1,-1,-1,-1,-1,1, 1,1,1,1,1,1,1,1 },//e fonte 3           
       {-1,-1,-1,-1,1,1,1, -1,-1,-1,-1,-1,1,-1, -1,-1,-1,-1,-1,1,-1, -1,-1,-1,-1,-1,1,-1, -1,-1,-1,-1,-1,1,-1, -1,-1,-1,-1,-1,1,-1, -1,-1,-1,-1,-1,1,-1, -1,1,-1,-1,-1,1,-1, -1,-1,1,1,1,-1,-1,1 },//j fonte 3
        {1,1,1,-1,-1,1,1, -1,1,-1,-1,-1,1,-1, -1,1,-1,-1,1,-1,-1, -1,1,-1,1,-1,-1,-1, -1,1,1,-1,-1,-1,-1, -1,1,-1,1,-1,-1,-1, -1,1,-1,-1,1,-1,-1, -1,1,-1,-1,-1,1,-1, 1,1,1,-1,-1,1,1,1   } };// k fonte 3

        double[,] Saidas_Desejadas = new double[,] {{ 1,-1,-1,-1,-1,-1,-1,1,-1,-1,-1,-1,-1,-1,1,-1,-1,-1,-1,-1,-1},  //A
                                                     {-1,1,-1,-1,-1,-1,-1,-1,1,-1,-1,-1,-1,-1,-1,1,-1,-1,-1,-1,-1}, //B
                                                     {-1,-1,1,-1,-1,-1,-1,-1,-1,1,-1,-1,-1,-1,-1,-1,1,-1,-1,-1,-1}, //c
                                                     {-1,-1,-1,1,-1,-1,-1,-1,-1,-1,1,-1,-1,-1,-1,-1,-1,1,-1,-1,-1}, //D
                                                     {-1,-1,-1,-1,1,-1,-1,-1,-1,-1,-1,1,-1,-1,-1,-1,-1,-1,1,-1,-1}, //E
                                                     {-1,-1,-1,-1,-1,1,-1,-1,-1,-1,-1,-1,1,-1,-1,-1,-1,-1,-1,1,-1}, //J
                                                     {-1,-1,-1,-1,-1,-1,1,-1,-1,-1,-1,-1,-1,1,-1,-1,-1,-1,-1,-1,1}};//K



        double[,] Pesos = new double[7, 64];
        double TaxaAprendizagem = 0.002;
        int QuantidadeMaximaCiclos = 1000;
        double ErroMinimo = 0.0001;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 9; i++)
            {
                dataGridVisualizacao.Rows.Add();
                dataGridVisualizacao.Rows[i].HeaderCell.Value = (i + 1).ToString();

                dataGridTeste.Rows.Add();
                dataGridTeste.Rows[i].HeaderCell.Value = (i + 1).ToString();
            }
            for (int linha = 0; linha < 9; linha++) {
                for (int coluna = 0; coluna < 7; coluna++)
                {
                    dataGridTeste.Rows[linha].Cells[coluna].Value = ".";
                }
            }
            comboBoxFonte.SelectedIndex = 0;
            comboBoxLetra.SelectedIndex = 0;

            GraficoErroQuadratico.Series[0].Points.Add(0, 0);
        }

        
        void MostrarLetra()
        {
            int Fonte = comboBoxFonte.SelectedIndex;
            int Letra = comboBoxLetra.SelectedIndex;

            if (Fonte == 0)
            {
                if (Letra == 0)
                    PreencherGrid(0);

                if (Letra == 1)
                    PreencherGrid(1);

                if (Letra == 2)
                    PreencherGrid(2);

                if (Letra == 3)
                    PreencherGrid(3);

                if (Letra == 4)
                    PreencherGrid(4);

                if (Letra == 5)
                    PreencherGrid(5);

                if (Letra == 6)
                    PreencherGrid(6);
            }

            if (Fonte == 1)
            {
                if (Letra == 0)
                    PreencherGrid(7);

                if (Letra == 1)
                    PreencherGrid(8);

                if (Letra == 2)
                    PreencherGrid(9);

                if (Letra == 3)
                    PreencherGrid(10);

                if (Letra == 4)
                    PreencherGrid(11);

                if (Letra == 5)
                    PreencherGrid(12);

                if (Letra == 6)
                    PreencherGrid(13);
            }

            if (Fonte == 2)
            {
                if (Letra == 0)
                    PreencherGrid(14);

                if (Letra == 1)
                    PreencherGrid(15);

                if (Letra == 2)
                    PreencherGrid(16);

                if (Letra == 3)
                    PreencherGrid(17);

                if (Letra == 4)
                    PreencherGrid(18);

                if (Letra == 5)
                    PreencherGrid(19);

                if (Letra == 6)
                    PreencherGrid(20);
            }

        }
        void PreencherGrid(int index)
        {
            int Linha, Coluna;
            Linha = 0;
            Coluna = 0;

            for (int i = 0; i < 63; i++)
            {
                if (Fontes[index, i] == 1)
                {
                    dataGridVisualizacao.Rows[Linha].Cells[Coluna].Value = '#';
                }
                else
                {
                    dataGridVisualizacao.Rows[Linha].Cells[Coluna].Value = '.';
                }
                Coluna++;
                if (Coluna == 7)
                {
                    Coluna = 0;
                    Linha++;
                }
            }
        }

        private void buttonTreinar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 64; j++)
                    Pesos[i, j] = 0;
            }
            GraficoErroQuadratico.Series[0].Points.Clear();

            double ErroQuadraticoMedio = 1;
            double SomaErroQuadraticoCiclo = 0;
            double ErroQuadraticoMedioAtual = 0;
            double ErroQuadraticoMedioAnterior = 0;
            int Ciclos = 0;

            double Erro = 0;

            while ((Math.Abs(ErroQuadraticoMedio - ErroQuadraticoMedioAnterior) > ErroMinimo) && (Ciclos < QuantidadeMaximaCiclos))
            {
                SomaErroQuadraticoCiclo = 0;
                ErroQuadraticoMedioAnterior = ErroQuadraticoMedio;

                for (int AmostraTreinamento = 0; AmostraTreinamento < 21; AmostraTreinamento++)
                {
                    for (int NeuronioSaida = 0; NeuronioSaida < 7; NeuronioSaida++)
                    {
                        double sinapse = 0;

                        for (int j = 0; j < 64; j++)
                        {
                            sinapse = sinapse + (Fontes[AmostraTreinamento, j] * Pesos[NeuronioSaida, j]);
                        }
                        Erro = Saidas_Desejadas[NeuronioSaida, AmostraTreinamento] - sinapse;

                        for (int j = 0; j < 64; j++)
                        {
                            double DeltaW = Fontes[AmostraTreinamento, j] * Erro * TaxaAprendizagem;
                            Pesos[NeuronioSaida, j] = Pesos[NeuronioSaida, j] + DeltaW;
                        }
                        SomaErroQuadraticoCiclo = SomaErroQuadraticoCiclo + Math.Pow(Erro, 2);
                    }
                }// f neuronios 

                ErroQuadraticoMedio = SomaErroQuadraticoCiclo / 21;
                ErroQuadraticoMedioAtual = ErroQuadraticoMedio;

                Ciclos++;
                GraficoErroQuadratico.Series[0].Points.Add(Math.Abs(ErroQuadraticoMedio));
            }// fim do while
            QuantidadeCiclos.Text = Ciclos.ToString();
        }
    

        private void buttonTestar_Click(object sender, EventArgs e)
        {
            int[] VetorParaSerTestado = new int[64];
            int PosicaoAtual = 0;
            double Resultado;
            int Y;
            string[] Letras = new string[] { "A", "B", "C", "D", "E", "J", "K" };

            labelRespostaRede.Text = " ";;

            for (int Linha = 0; Linha < 9; Linha++)
            {
                for (int Coluna = 0; Coluna < 7; Coluna++)
                {
                    string entrada = dataGridTeste.Rows[Linha].Cells[Coluna].Value.ToString();
                    if (entrada == "#")
                        VetorParaSerTestado[PosicaoAtual] = 1;
                    else if (entrada == ".")
                        VetorParaSerTestado[PosicaoAtual] = -1;
                    else
                    {
                        VetorParaSerTestado[PosicaoAtual] = 0;
                    }

                    PosicaoAtual += 1;
                }
            }
            VetorParaSerTestado[63] = 1;

            for (int NeuronioSaida = 0; NeuronioSaida < 7; NeuronioSaida++)
            {
                Resultado = 0;
                for (int i = 0; i < 64; i++)
                {
                    Resultado = Resultado + (VetorParaSerTestado[i] * Pesos[NeuronioSaida, i]);
                }
                if (Resultado >= 0)
                    labelRespostaRede.Text = labelRespostaRede.Text + " " + Letras[NeuronioSaida];
            }

        }

        private void comboBoxFonte_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            MostrarLetra();
        }

        private void comboBoxLetra_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            MostrarLetra();
        }
    }
}