using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    class Bullet : MovingObject    
    {
        public new const string CollisionGroupString = "bullet";

        public Bullet(MatrixCoords topLeft, char[,] body, MatrixCoords speed)
            : base(topLeft, body, speed)
        {
            
        }
        public override void RespondToCollision(CollisionData collisionData)
        {
            this.IsDestroyed = true;
        }
        public override bool CanCollideWith(string otherCollisionGroupString)
        {
            return true;
        }
        public override string GetCollisionGroupString()
        {
            return Block.CollisionGroupString;
        }
    }
}
