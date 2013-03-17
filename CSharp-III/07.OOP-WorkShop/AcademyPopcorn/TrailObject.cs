using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    class TrailObject : GameObject
    {
        public new const string CollisionGroupString = "trailObject";
        public int LifeTime { get; set; }

        public TrailObject(MatrixCoords topLeft, char[,] body, int lifeTime) : base(topLeft, body)
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
        public override void RespondToCollision(CollisionData collisionData)
        {
            this.IsDestroyed = true;
        }
        public override bool CanCollideWith(string otherCollisionGroupString)
        {
            return otherCollisionGroupString == "block";
        }
        public override string GetCollisionGroupString()
        {
            return TrailObject.CollisionGroupString;
        }
    }
}
