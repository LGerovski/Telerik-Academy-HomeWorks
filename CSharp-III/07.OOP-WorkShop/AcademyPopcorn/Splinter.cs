using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    class Splinter : Ball
    {
        public int LifeTime { get; set; }

        public Splinter(MatrixCoords topLeft, MatrixCoords speed, int lifeTime)
            : base(topLeft, speed, new char[,] {{'`'}})
        {
            this.LifeTime = lifeTime;
        }
        public override void Update()
        {
            if (this.LifeTime > 0)
            {
                this.LifeTime--;
            }
            else
            {
                this.IsDestroyed = true;
            }
        }
    }
}
