using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    class Gift : MovingObject
    {
        public Gift(MatrixCoords topLeft, char[,] body)
            : base(topLeft, body, new MatrixCoords(1, 0))
        {
        }
        public override void RespondToCollision(CollisionData collisionData)
        {
            this.IsDestroyed = true;
        }
        public override bool CanCollideWith(string otherCollisionGroupString)
        {
            return otherCollisionGroupString == "racket";
        }
        public override IEnumerable<GameObject> ProduceObjects()
        {
            List<ShootingRacket> racket = new List<ShootingRacket>();
            if (this.IsDestroyed)
            {
                int x = this.TopLeft.Row;
                int y = this.TopLeft.Col;
                racket.Add(new ShootingRacket(new MatrixCoords(x + 1, y), 6));
            }
            return racket;
        }
    }
}
