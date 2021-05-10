using ParticleSwarm.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ParticleSwarm
{
    public partial class Form1 : Form
    {
        private List<List<Particle>> ParticlesIteration = new List<List<Particle>>();
        Thread cpuThread;
        public Form1()
        {
            InitializeComponent();
            testPanel.Visible = false;
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            ParticlesIteration.Clear();
            double a = Convert.ToDouble(aBox.Text);
            double b = Convert.ToDouble(bBox.Text);
            double d = Convert.ToDouble(dBox.Text);
            int n = Convert.ToInt32(NBox.Text);
            double c1 = Convert.ToDouble(C1Box.Text);
            double c2 = Convert.ToDouble(C2Box.Text);
            double c3 = Convert.ToDouble(C3Box.Text);
            double RS = Convert.ToDouble(RSBox.Text);
            double t = Convert.ToDouble(Tbox.Text);
            RS = Math.Round((n * (RS / 100)), 1);
            Random generator = new Random();
            int round = 0;
            int l = (int)Math.Ceiling(Math.Log(((b - a) * (1 / d)) + 1, 2));
            bool err = false;
            double pom = d;

            while (pom < 1)
            {
                round++;
                pom *= 10;
            }
            List<double> bestList = new List<double>();
            List<double> avgList = new List<double>();
            List<double> minList = new List<double>();
            List<List<Particle>> iterationList = new List<List<Particle>>();
            List<Particle> particles = PS.MakeParticles(a, b, d, l, n, generator);
            iterationList.Add(particles.ConvertAll(p => p.Clone()));
            Particle Best = particles.First().Clone();
            Particle localBgMax;
            do
            {
                for (int j = 0; j < particles.Count; j++)
                {
                    Particle particle = particles[j];
                    if (particle.Fx > particle.B.Fx)
                    {
                        particle.B = particle.Clone();
                    }
                    List<Particle> localParticles = PS.TakeLocalParticles(particles, particle, RS);

                    if (localParticles.First().Bg.Fx > particle.Bg.Fx)
                    {
                        localBgMax = localParticles.First().Clone();
                        if (particle.Bg.Fx < localBgMax.Fx)
                        {
                            particle.Bg = localBgMax.Clone();
                        }
                    }
                    else
                    {
                        localBgMax = particle.Bg.Clone();
                    }

                    for (int i = 0; i < localParticles.Count; i++)
                    {
                        if (localParticles[i].Bg.Fx < localBgMax.Fx)
                        {
                            localParticles[i].Bg = localBgMax.Clone();
                        }
                    }
                }

                PS.CountV(particles, generator, c1, c2, c3, round);

                var max = particles.Max(p => p.Fx);
                if (max > Best.Fx)
                {
                    Best = particles.First(p => p.Fx == max).Clone();
                }
                bestList.Add(Best.Fx);
                avgList.Add(particles.Average(p => p.Fx));
                minList.Add(particles.Min(p => p.Fx));

                foreach (var particle1 in particles)
                {
                    if (particles.All(p => Math.Abs(p.Xreal - particle1.Xreal) <= d))
                    {
                        err = true;
                    }
                    else
                    {
                        err = false;
                    }
                    if (!err) break;
                }
                ParticlesIteration.Add(particles.ConvertAll(p => p.Clone()));
                t--;
            } while (t > 0 && !err);

            List<Particle> pList = new List<Particle>();
            pList.Add(Best);
            var bindingList = new BindingList<Particle>(pList);
            var source = new BindingSource(bindingList, null);
            table.DataSource = source;
            MakeChart(bestList, avgList, minList);
        }


        private void MakeChart(List<double> max, List<double> avg, List<double> min)
        {
            chart.Series.Clear();
            var chartMaker = chart.ChartAreas[0];
            ChartArea CA = chart.ChartAreas[0];
            CA.AxisX.ScaleView.Zoomable = true;
            chartMaker.AxisX.LabelStyle.Format = "";
            chartMaker.AxisY.LabelStyle.Format = "";
            chartMaker.AxisX.LabelStyle.IsEndLabelVisible = true;

            chartMaker.AxisX.Minimum = 0;
            chartMaker.AxisX.Maximum = max.Count;
            chartMaker.AxisY.Interval = 0.1;

            if (max.Count > 1)
            {
                chartMaker.AxisX.Interval = 1;
            }
            if (max.Count > 40)
            {
                chartMaker.AxisX.Interval = 2;
            }
            if (max.Count > 99)
            {
                chartMaker.AxisX.Interval = 10;
            }
            if (max.Count > 100)
            {
                chartMaker.AxisX.Interval = 10;
            }
            if (max.Count > 500)
            {
                chartMaker.AxisX.Interval = 50;
            }
            if (max.Count > 999)
            {
                chartMaker.AxisX.Interval = 100;
            }
            if (max.Count > 1999)
            {
                chartMaker.AxisX.Interval = 200;
            }

            if (chart.Series.Count == 0)
            {
                chart.Series.Add("Best");
                chart.Series.Add("Avg");
                chart.Series.Add("Min");
            }
            else
            {
                chart.Series["Best"].Points.Clear();
                chart.Series["Avg"].Points.Clear();
                chart.Series["Min"].Points.Clear();
            }

            chart.Series["Best"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart.Series["Best"].Color = Color.Red;
            chart.Series["Best"].BorderWidth = 2;

            chart.Series["Avg"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart.Series["Avg"].Color = Color.Green;
            chart.Series["Avg"].BorderWidth = 2;

            chart.Series["Min"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart.Series["Min"].Color = Color.Blue;
            chart.Series["Min"].BorderWidth = 1;

            for (int i = 0; i < max.Count; i++)
            {
                chart.Series["Best"].Points.AddXY(i, max[i]);
                chart.Series["Avg"].Points.AddXY(i, avg[i]);
                chart.Series["Min"].Points.AddXY(i, min[i]);
            }
        }

        private void animationBtn_Click(object sender, EventArgs e)
        {
            var chartMaker = animationChart.ChartAreas[0];
            ChartArea CA = animationChart.ChartAreas[0];
            CA.AxisX.ScaleView.Zoomable = true;
            chartMaker.AxisX.Minimum = -4;
            chartMaker.AxisX.Maximum = 12;
            chartMaker.AxisX.Interval = 0.2;
            chartMaker.AxisY.Minimum = 0;
            if (animationChart.Series.Count == 1)
            {
                animationChart.Series.Add("Iter");
            }
            else
            {
                animationChart.Series["Iter"].Points.Clear();
            }

            animationChart.Series["Iter"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            animationChart.Series["Iter"].Color = Color.Blue;
            animationChart.Series["Iter"].MarkerSize = 5;
            cpuThread = new Thread(new ThreadStart(drawChart));
            cpuThread.Start();

        }

        private void drawChart()
        {
            foreach (var particles in ParticlesIteration)
            {
                Invoke((MethodInvoker)delegate { drawPoints(particles); });
                Thread.Sleep(200);
                animationChart.Series["Iter"].Points.Clear();
            }

        }

        private void drawPoints(List<Particle> particles)
        {
            foreach (var particle in particles)
            {
                animationChart.Series["Iter"].Points.AddXY(particle.Xreal, 0);
            }
        }

        private void startTestBtn_Click(object sender, EventArgs e)
        {
            ParticlesIteration.Clear();
            double a = Convert.ToDouble(aBox.Text);
            double b = Convert.ToDouble(bBox.Text);
            double d = Convert.ToDouble(dBox.Text);
            int n;

            double RS = 0;
            int count = 0;
            Random generator = new Random();
            int round = 0;

            double pom = d;
            double BestTest = 0;
            int l = (int)Math.Ceiling(Math.Log(((b - a) * (1 / d)) + 1, 2));
            while (pom < 1)
            {
                round++;
                pom *= 10;
            }
            int t = 0;
            List<TestClass> testList = new List<TestClass>();
            List<Particle> testListMax = new List<Particle>();
            List<double> testAvgList = new List<double>();
            DateTime start = DateTime.Now;
            double pomCounter = 0.5;
            for (double c1 = 0.5; c1 <= 1; c1 += 0.5)
            {
                Console.WriteLine("siema lece  " + pomCounter + " czasik : " + (DateTime.Now - start));
                pomCounter += 0.5;
                for (double c2 = c1; c2 <= 2; c2 += 0.5)
                {
                    for (double c3 = c2; c3 <= 2; c3 += 0.5)
                    {
                        for (int iter = 100; iter <= 1000; iter += 100)
                        {
                            for (double RSi = 20; RSi < 60; RSi += 10)
                            {
                                for (n = 10; n <= 50; n += 10)
                                {
                                    RS = Math.Round((n * (RSi / 100)), 1);
                                    count = 0;

                                    for (int r = 0; r < 20; r++)
                                    {
                                        List<double> bestList = new List<double>();
                                        List<double> avgList = new List<double>();
                                        List<double> minList = new List<double>();
                                        List<Particle> particles = PS.MakeParticles(a, b, d, l, n, generator);
                                        Particle Best = particles.First().Clone();
                                        Particle localBgMax;
                                        t = iter;
                                        do
                                        {
                                            for (int j = 0; j < particles.Count; j++)
                                            {
                                                Particle particle = particles[j];
                                                if (particle.Fx > particle.B.Fx)
                                                {
                                                    particle.B = particle.Clone();
                                                }
                                                List<Particle> localParticles = PS.TakeLocalParticles(particles, particle, RS);

                                                if (localParticles.First().Bg.Fx > particle.Bg.Fx)
                                                {
                                                    localBgMax = localParticles.First().Clone();
                                                    if (particle.Bg.Fx < localBgMax.Fx)
                                                    {
                                                        particle.Bg = localBgMax.Clone();
                                                    }
                                                }
                                                else
                                                {
                                                    localBgMax = particle.Bg.Clone();
                                                }

                                                for (int i = 0; i < localParticles.Count; i++)
                                                {
                                                    if (localParticles[i].Bg.Fx < localBgMax.Fx)
                                                    {
                                                        localParticles[i].Bg = localBgMax.Clone();
                                                    }
                                                }
                                            }

                                            PS.CountV(particles, generator, c1, c2, c3, round);

                                            var max = particles.Max(p => p.Fx);
                                            if (max > Best.Fx)
                                            {
                                                Best = particles.First(p => p.Fx == max).Clone();
                                                BestTest = Best.Fx;
                                            }
                                            bestList.Add(Best.Fx);
                                            avgList.Add(particles.Average(p => p.Fx));
                                            minList.Add(particles.Min(p => p.Fx));

                                            t--;
                                        } while (t > 0);

                                        if (Best.Xreal == 10.999)
                                        {
                                            count++;
                                        }

                                        testAvgList.Add(avgList.Average(avg => avg));
                                        avgList.Clear();
                                        minList.Clear();
                                        bestList.Clear();
                                    }
                                    TestClass test = new TestClass
                                    {
                                        c1 = c1,
                                        c2 = c2,
                                        c3 = c3,
                                        n = n,
                                        t = iter,
                                        RS = RSi,
                                        CountBest = count,
                                        Max = BestTest,
                                        Avg = testAvgList.Average(avg => avg)
                                    };
                                    testList.Add(test);
                                }
                            }
                        }
                    }
                }
            }

            testList.Sort((x, y) => y.Avg.CompareTo(x.Avg));
            testList.Sort((x, y) => y.Max.CompareTo(x.Max));
            testList.Sort((x, y) => y.CountBest.CompareTo(x.CountBest));

            var bindingList = new BindingList<TestClass>(testList);
            var source = new BindingSource(bindingList, null);
            testTable.DataSource = source;
        }

        private void testBtn_Click(object sender, EventArgs e)
        {
            testPanel.Visible = true;
        }

        private void zad1Btn_Click(object sender, EventArgs e)
        {
            testPanel.Visible = false;
        }
    }
}



