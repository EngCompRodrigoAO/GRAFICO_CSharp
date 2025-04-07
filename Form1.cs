using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GRAFICO
{
    public partial class Form1 : Form
    {

        //Data to be plotted
        List<double> xVals = new List<double>();
        List<double> yVals = new List<double>();
        
        //TESTE GIT kinecs-NOTE2
        public Random rnd = new Random();
        double tick = 0.0;
        double DataTime = 100.0; //Tempo de visualização do gráfico
        Color COR_STRIPLINE, COR_LINHA;

        public Form1()
        {
            InitializeComponent();
            // Aula 3 - Aula Gráfico scrolling and Data Binding

            //configura o gráfico
            LineGraph graph1 = new LineGraph(chart1, 0, DataTime, 1, true, 0, 30, 15, true, 1, 0, 0, Color.Red);

            //Configura a StripLine
            graph1.CreateStripLine(chart1, 10, 10, Color.BlueViolet, 125, true);
        }


        private void timer1_Tick(object sender, EventArgs e)
        {

            label11.Text = Convert.ToString(yVals.Count());
            label12.Text = Convert.ToString(xVals.Count());

            xVals.Add(tick); // Adiciona o valor de tick a lista de X
            yVals.Add((10.0 * rnd.NextDouble()) + 10); // Adiciona o valor de Y a lista de Y

            if (tick >= DataTime)
            {
                xVals.RemoveAt(0); // Remove o primeiro valor da lista de X
                yVals.RemoveAt(0); // Remove o primeiro valor da lista de Y
            }

            chart1.ChartAreas[0].AxisX.Minimum = xVals[0]; // Define o valor minimo do eixo X
            chart1.ChartAreas[0].AxisX.Maximum = tick; // Define o valor maximo do eixo X

            chart1.Series[0].Points.DataBindXY(xVals, yVals); // Plota os pontos do grafico
            tick += 1; // Incrementa o valor de tick
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {


                timer1.Enabled = false;

                xVals.Clear();
                yVals.Clear();

                DataTime = Convert.ToDouble(TXT_X_MAX.Text);
                tick = 0;
                timer1.Interval = Convert.ToInt16(TXT_ATUALIZA.Text);

                LineGraph graph1 = new LineGraph(chart1, Convert.ToDouble(TXT_X_MIN.Text), DataTime, Convert.ToDouble(TXT_X_INTERVALO.Text), CHK_GRADE_X.Checked, Convert.ToDouble(TXT_Y_MIN.Text), Convert.ToDouble(TXT_Y_MAX.Text), Convert.ToDouble(TXT_Y_INTERVALO.Text), CHK_GRADE_Y.Checked, Convert.ToInt16(TXT_LINHA_ESPESSURA.Text), Convert.ToInt16(TXT_MINOR_X.Text), Convert.ToInt16(TXT_MINOR_Y.Text), COR_LINHA);
                graph1.CreateStripLine(chart1, Convert.ToDouble(TXT_STRIPLINE_MIN.Text), (Convert.ToDouble(TXT_STRIPLINE_MAX.Text) - Convert.ToDouble(TXT_STRIPLINE_MIN.Text)), COR_STRIPLINE, Convert.ToInt16(TXT_STRIPLINE_OPACIDADE.Text), CHK_STRIPLINE.Checked); // Cria a StripLine
                timer1.Enabled = true;

            }
            catch(Exception)
            {

            }
        }

        private void LBL_COR_LINHA_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            COR_LINHA = colorDialog1.Color;
        }

        private void LBL_COR_STRIPLINE_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            COR_STRIPLINE = colorDialog1.Color;
        }

        private void chart1_DoubleClick(object sender, EventArgs e)
        {
            chart1.ChartAreas[0].AxisX.ScaleView.ZoomReset();
            chart1.ChartAreas[0].AxisY.ScaleView.ZoomReset();
        }
    }
}
