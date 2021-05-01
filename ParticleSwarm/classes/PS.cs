using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParticleSwarm.classes
{
    class PS
    {
        //oblicz Int z Real
        public static void IntFromReal(Particle particle, double a, double b, double l)
        {
            particle.Xint = (int)Math.Round(((1 / (b - a)) * (particle.Xreal - a) * (Math.Pow(2, l) - 1)));
        }

        //oblicz Int z Bit
        public static void IntFromXbit(Particle particle)
        {
            particle.Xint = int.Parse(Convert.ToString(Convert.ToInt32(particle.Xbit + "", 2), 10));
        }

        public static void RealFromInt(Particle particle, double a, double b, double l, int round)
        {
            particle.Xreal = Math.Round(a + ((b - a) * particle.Xint) / (Math.Pow(2, l) - 1), round);
        }

        public static void BinFromInt(Particle particle, double l)
        {
            string bin = Convert.ToString(particle.Xint, 2);
            for (int k = bin.Length; k < l; k++)
            {
                bin = "0" + bin;
            }
            particle.Xbit = bin;
        }

        public static void CountFx(Particle particle)
        {
            double x = particle.Xreal;
            double v = x % 1 * (Math.Cos(20 * Math.PI * x) - Math.Sin(x));
            particle.Fx = v;
        }

        public static List<Particle> MakeParticles(double a, double b, double d, double l, int n, Random generator)
        {
            List<Particle> particles = new List<Particle>();
            for (int i = 0; i < n; i++)
            {
                Particle particle = new Particle
                {
                    Id = i,
                    Xreal = generator.Next((int)(a / d), (int)(b / d)) * d
                };
                IntFromReal(particle, a, b, l);
                BinFromInt(particle, l);
                CountFx(particle);
                particle.B = particle.Clone();
                particle.Bg = particle.Clone();
                particles.Add(particle);
            }
            return particles;
        }

        public static List<Particle> TakeLocalParticles(List<Particle> particles, Particle particle, double RS)
        {

            List<Particle> localParticleList = new List<Particle>(particles);

            foreach (var p in localParticleList)
            {
                p.Distance = Math.Abs(p.Xreal - particle.Xreal);
            }

            localParticleList.Sort(delegate (Particle x, Particle y)
            {
                return y.Distance.CompareTo(x.Distance);
            });

            return localParticleList.Take((int)RS).ToList();
        }
    }
}
