using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    class ShootingRacket : Racket
    {
        public ShootingRacket(MatrixCoords topLeft, int width)
            : base(topLeft, 6)
        {
        }
        public void ShootPlayerRacket()
        {
        }
        public override IEnumerable<GameObject> ProduceObjects()
        {
            List<Bullet> bullet = new List<Bullet>();
            int x = this.TopLeft.Row;
            int y = this.TopLeft.Col;
            bullet.Add(new Bullet(new MatrixCoords(x, y + 2), new char[,] {{'|'}}, new MatrixCoords(-1, 0)));
            return bullet;
        }
    }
}
