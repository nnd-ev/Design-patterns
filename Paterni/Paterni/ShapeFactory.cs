using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paterni {
    class ShapeFactory {
        public IShape GetShape(string shapeType) {
            if(shapeType == null) {
                return null;
            }else if (shapeType.Equals("CIRCLE")) {
                return new Circle();
            }else if (shapeType.Equals("RACTANGLE")) {
                return new Ractangle();
            }else if (shapeType.Equals("SQUARE")) {
                return new Square();
            }
            
            return null;
             
        }
    }
}
