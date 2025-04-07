using System;
using System.Drawing;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;
using System.Collections.Generic;
using System.Windows.Forms;




namespace GRAFICO
{
    internal class LineGraph
    {
        #region Docs
        //ira ficar a descrição da class LineGraph
        //
        //
        //


        #endregion

        #region Fields
        //Variaveis Globais da Classe
       
       
        #endregion Fields

        #region Properties
        //Propriedades da Class

        public double xAxisMin { get; set; }
        public double xAxisMax { get; set; }
        public double xAxisInterval { get; set; }
        public double yAxisMin { get; set; }
        public double yAxisMax { get; set; }
        public double yAxisInterval { get; set; }
        public double xMinorInt { get; set; }
        public int lineWhith { get; set; } = 1; // Default line width
        public double yMinorInt { get; set; }
        public double numMinorYGrid { get; set; }
        public double numMinorXGrid { get; set; }
        public Color lineColor { get; set; } = Color.Blue; // Default color for the line graph
                                                           


        //StripLine

        public double striplineyValue { get; set; } = 0.0; // Default yValue for the strip line
        public Color stripLinecolor { get; set; } = Color.Red; // Default color for the strip line
        public int stripLineColorAlpha { get; set; } = 255; // Default alpha value for the strip line color
        public double stripLineWidth { get; set; } = 0.1; // Default width for the strip line


        #endregion Properties

        #region Contructor
        //Contrutor da Class
        public LineGraph(Chart chart1, double xAxisMin, double xAxisMax, double xAxisInterval, double yAxisMin, double yAxisMax, double yAxisInterval, int lineWidth, int numMinorXGrid, int numMinorYGrid, Color lineColor)
        {
            this.xAxisMin = xAxisMin;
            this.xAxisMax = xAxisMax;
            this.xAxisInterval = xAxisInterval;
            this.yAxisMin = yAxisMin;
            this.yAxisMax = yAxisMax;
            this.yAxisInterval = yAxisInterval;
            this.lineWhith = lineWidth;
            this.numMinorYGrid = numMinorYGrid;
            this.numMinorXGrid = numMinorXGrid;
            this.yMinorInt = yAxisInterval / (1.0 + numMinorYGrid); // Assuming numMinorYGrig is 5
            this.xMinorInt = xAxisInterval / (1.0 + numMinorXGrid);
            this.lineColor = lineColor;
            //this.typeGrafic = typeGrafic;


            chart1.ChartAreas[0].AxisX.Minimum = xAxisMin;
            chart1.ChartAreas[0].AxisX.Maximum = xAxisMax;
            chart1.ChartAreas[0].AxisX.Interval = xAxisInterval;
            chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.DarkGray;

            chart1.ChartAreas[0].AxisY.Minimum = yAxisMin;
            chart1.ChartAreas[0].AxisY.Maximum = yAxisMax;
            chart1.ChartAreas[0].AxisY.Interval = yAxisInterval;
            chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.DarkGray;

            //zoom graph
            chart1.ChartAreas[0].CursorX.Interval = 0.01;
            chart1.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            chart1.ChartAreas[0].CursorX.AutoScroll = true;
            chart1.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            chart1.ChartAreas[0].AxisX.Interval = xAxisInterval;
            //chart1.ChartAreas[0].Axes[0].MajorGrid.Interval = xMinorInt;

            chart1.ChartAreas[0].CursorY.Interval = 0.01;
            chart1.ChartAreas[0].AxisY.ScaleView.Zoomable = true;
            chart1.ChartAreas[0].CursorY.AutoScroll = true;
            chart1.ChartAreas[0].CursorY.IsUserSelectionEnabled = true;
            chart1.ChartAreas[0].AxisY.Interval = yAxisInterval;
            //chart1.ChartAreas[0].Axes[0].MajorGrid.Interval = 500;


            chart1.ChartAreas[0].AxisX.MinorGrid.Enabled = true; //Habilita a grade menor do eixo X
            chart1.ChartAreas[0].AxisX.MinorGrid.LineColor = Color.DarkGray; //Define a cor da grade menor do eixo X
            chart1.ChartAreas[0].AxisX.MinorGrid.Interval = xMinorInt; //Define o intervalo da grade menor do eixo X
            chart1.ChartAreas[0].AxisX.MinorGrid.LineDashStyle = ChartDashStyle.Dash; //Define o estilo da grade menor do eixo X


            chart1.ChartAreas[0].AxisY.MinorGrid.Enabled = true; //Habilita a grade menor do eixo Y
            chart1.ChartAreas[0].AxisY.MinorGrid.LineColor = Color.DarkGray; //Define a cor da grade menor do eixo Y
            chart1.ChartAreas[0].AxisY.MinorGrid.Interval = yMinorInt; //Define o intervalo da grade menor do eixo Y
            chart1.ChartAreas[0].AxisY.MinorGrid.LineDashStyle = ChartDashStyle.Dash; //Define o estilo da grade menor do eixo Y

            chart1.ChartAreas[0].BackColor = Color.Black;
            chart1.ChartAreas[0].BorderColor = Color.White;

            chart1.Series[0].ChartType = SeriesChartType.FastLine; //Define o tipo de gráfico como linha
            chart1.Series[0].BorderWidth = (int)lineWhith; //Espessura da borda do grafico
            chart1.Series[0].Color = lineColor; //Cor do grafico
            chart1.Legends.Clear(); // Desabilita as legendas
            

        }


        #endregion Contructor



        #region Methods

        public void CreateStripLine(Chart chart1, double striplineyValue, double stripLineWidth, Color stripLinecolor, int stripLineColorAlpha)
        {
            this.striplineyValue = striplineyValue;
            this.stripLinecolor = stripLinecolor;
            this.stripLineWidth = stripLineWidth;
            this.stripLineColorAlpha = stripLineColorAlpha;

            StripLine stripLine1 = new StripLine();

            stripLine1.IntervalOffset = striplineyValue;
            stripLine1.StripWidth = stripLineWidth;
            stripLine1.BackColor = Color.FromArgb(stripLineColorAlpha, stripLinecolor);
            stripLine1.BorderColor = Color.Black;
            stripLine1.BorderDashStyle = ChartDashStyle.Solid;
            chart1.ChartAreas[0].AxisY.StripLines.Add(stripLine1);
        }


        #endregion Methods
    }

}
