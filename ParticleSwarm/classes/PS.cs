using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParticleSwarm.classes
{
    class PS
    {
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

            localParticleList.Sort((x, y) => x.Distance.CompareTo(y.Distance));
           
            localParticleList = localParticleList.Skip(1).Take((int)RS).ToList();

            localParticleList.Sort((x, y) => y.Fx.CompareTo(x.Fx));
        
            return localParticleList;
        }

        public static void CountV (List<Particle> particles, Random generator, double c1, double c2, double c3, int round)
        {
            foreach (var particle in particles)
            {
                double r1 = generator.NextDouble();
                double r2 = generator.NextDouble();
                double r3 = generator.NextDouble();
                particle.V = Math.Round(c1 * r1 * particle.V + c2 * r2 * (particle.B.Xreal - particle.Xreal) + c3 * r3 * (particle.Bg.Xreal - particle.Xreal), round);
                if(particle.V + particle.Xreal > 11.999)
                {
                        particle.V = Math.Round(Math.Abs(particle.Xreal - 11.999), round);
                    
                }else if(particle.V + particle.Xreal < -4)
                {
                    particle.V = Math.Round(particle.Xreal + 4, round) * -1;
                }
                particle.Xreal = Math.Round(particle.Xreal + particle.V, round);
                CountFx(particle);
            }
        }
    }
}
