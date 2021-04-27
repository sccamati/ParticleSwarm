using ParticleSwarm.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParticleSwarm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(aBox.Text);
            double b = Convert.ToDouble(bBox.Text);
            double d = Convert.ToDouble(dBox.Text);
            int n = Convert.ToInt32(NBox.Text);
            double c1 = Convert.ToDouble(C1Box.Text);
            double c2 = Convert.ToDouble(C2Box.Text);
            double c3 = Convert.ToDouble(C3Box.Text);
            double RS = Convert.ToDouble(RSBox.Text);
            double t = Convert.ToDouble(Tbox.Text);
            double r1, r2, r3;
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
            List<List<Particle>> iterationList = new List<List<Particle>>();
            List<Particle> particles = PS.MakeParticles(a, b, d, l, n, generator);
            iterationList.Add(particles.ConvertAll(p => p.Clone()));
            Particle bg = particles.First().Clone();
            Particle Best = particles.First().Clone();
            do
            {
                List<Particle> copyList = new List<Particle>();
                for (int j = 0; j < particles.Count; j++)
                {
                    Particle particle = particles[j];
                    if (particle.Fx > particle.B.Fx)
                    {
                        particle.B = particle.Clone();
                    }
                    PS.CountDistance(particles, particle);

                    var locals = particles.Take((int)RS);

                    var locmax = locals.Max(loc => loc.Bg.Fx);

                    Particle localBgMax = locals.First(lbg => lbg.Bg.Fx == locmax);

                    for (int i = 0; i < RS; i++)
                    {
                        if(particles[i].Bg.Fx < localBgMax.Bg.Fx)
                        {
                            particles[i].Bg = localBgMax.Clone();
                        }
                    }
                    if (particle.Bg.Fx < localBgMax.Bg.Fx)
                    {
                        particle.Bg = localBgMax.Clone();
                    }
                    r1 = generator.NextDouble();
                    r2 = generator.NextDouble();
                    r3 = generator.NextDouble();
                    particle.V = c1 * r1 * particle.V + c2 * r2 * (particle.B.Xreal - particle.Xreal) + c3 * r3 * (particle.Bg.Xreal - particle.Xreal);
                    particle.Xreal += particle.V;
                    PS.CountFx(particle);
                }
                var max = particles.Max(p => p.Fx);
                if (max > Best.Fx)
                {
                    Best = particles.First(p => p.Fx == max).Clone();
                }
                foreach (var particle1 in particles)
                {
                    foreach (var particle2 in particles)
                    {
                        if (Math.Abs(particle1.Xreal - particle2.Xreal) <= d)
                        {
                            err = true;
                            break;
                        }
                    }
                    if (err) break;
                }
                iterationList.Add(particles.ConvertAll(p => p.Clone()));
                t--;
            } while (t > 0 && !err);

            List<Particle> pList = new List<Particle>();
            pList.Add(bg);
            var bindingList = new BindingList<Particle>(pList);
            var source = new BindingSource(bindingList, null);
            table.DataSource = source;

        }
    }
}



