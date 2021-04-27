using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParticleSwarm.classes
{
    class Particle
    {
        public int Id { get; set; }
        public double Xreal { get; set; }
        public int Xint { get; set; }
        public string Xbit { get; set; }
        public double Fx { get; set; }
        public double P { get; set; }
        public double V { get; set; }
        public Particle B { get; set; }
        public Particle Bg { get; set; }
        public double Distance { get; set; }

        public Particle Clone()
        {
            return (Particle)this.MemberwiseClone();
        }
    }
}
