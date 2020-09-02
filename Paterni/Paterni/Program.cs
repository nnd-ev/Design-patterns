using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paterni {
    class Program {
        static void Main(string[] args) {
            ShapeFactory shapeFactory = new ShapeFactory();
            IShape shape1 = shapeFactory.GetShape("CIRCLE");
            shape1.draw();

            IShape shape2 = shapeFactory.GetShape("RACTANGLE");
            shape2.draw();


        }
    }
}
