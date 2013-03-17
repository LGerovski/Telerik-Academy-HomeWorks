using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    class GiftBlock : Block
    {
        public GiftBlock(MatrixCoords topLeft, char[,] symbols)
            : base(topLeft, symbols)
        {

        }
        public override IEnumerable<GameObject> ProduceObjects()
        {
            List<Gift> gift = new List<Gift>();
            if (this.IsDestroyed)
            {
                int x = this.TopLeft.Row;
                int y = this.TopLeft.Col;
                gift.Add(new Gift(new MatrixCoords(x, y), new char[,] {{'*'}}));
                
            }
            return gift;
        }
    }
}
