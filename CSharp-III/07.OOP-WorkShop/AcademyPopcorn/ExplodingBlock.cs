using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    class ExplodingBlock : GameObject
    {
        public new const string CollisionGroupString = "block";

        public ExplodingBlock(MatrixCoords topLeft)
            : base(topLeft, new char[,] { { '&' } })
        {
        }
        public override void Update()
        {

        }
        public override void RespondToCollision(CollisionData collisionData)
        {
            this.IsDestroyed = true;
        }
        public override bool CanCollideWith(string otherCollisionGroupString)
        {
            return otherCollisionGroupString == "ball";
        }
        public override IEnumerable<GameObject> ProduceObjects()
        {
            List<Splinter> splinters = new List<Splinter>();
            if (this.IsDestroyed)
            {
                int x = this.TopLeft.Row;
                int y = this.TopLeft.Col;
                splinters.Add(new Splinter(new MatrixCoords(x, y), new MatrixCoords(-1, -1), 0));
                splinters.Add(new Splinter(new MatrixCoords(x, y), new MatrixCoords(-1, 0), 0));
                splinters.Add(new Splinter(new MatrixCoords(x, y), new MatrixCoords(-1, 1), 0));
                splinters.Add(new Splinter(new MatrixCoords(x, y), new MatrixCoords(0, -1), 0));
                splinters.Add(new Splinter(new MatrixCoords(x, y), new MatrixCoords(0, 1), 0));
                splinters.Add(new Splinter(new MatrixCoords(x, y), new MatrixCoords(1, -1), 0));
                splinters.Add(new Splinter(new MatrixCoords(x, y), new MatrixCoords(1, 0), 0));
                splinters.Add(new Splinter(new MatrixCoords(x, y), new MatrixCoords(1, 1), 0));
            }
            return splinters;
        }
        public override string GetCollisionGroupString()
        {
            return ExplodingBlock.CollisionGroupString;
        }
    }
}
