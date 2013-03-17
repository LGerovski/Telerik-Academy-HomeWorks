using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    class UnpassableBlock : Block
    {
        public new const string CollisionGroupString = "unpassableBlock";

        public UnpassableBlock(MatrixCoords topLeft)
            : base(topLeft, new char[,] {{'@'}})
        {
        }
        public override void RespondToCollision(CollisionData collisionData)
        {
        }
        public override void Update()
        {
        }
        public override string GetCollisionGroupString()
        {
            return UnpassableBlock.CollisionGroupString;
        }
    }
}
