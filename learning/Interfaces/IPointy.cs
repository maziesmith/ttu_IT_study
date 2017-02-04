using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces {
    public interface IPointy {
        //byte GetNumberOfPoints();

        // A read-write property in an interfaces would look like:
        // retType PropName { get; set; }
        // While a write-only propery in an interface would be:
        // retType PropName { set; }

        byte Points { get; }
    }

    public interface IDraw3D {
        void Draw3D();
    }

    public class Shape {
        protected string name { get;set; }

        public Shape() { }
        public Shape(string name) {
            this.name = name;
        }

        public virtual void Draw () {
            Console.WriteLine();
        }
    }

    public class Triangle: Shape, IPointy {
        public Triangle() { }
        public Triangle(string name): base(name) { }

        public override void Draw() {
            Console.WriteLine("Drawing {0} the triangle", name);
        }

        public byte Points {
            get { return 3; }
        }
    }

    public class Hexagon: Shape, IPointy, IDraw3D {
        public byte Points {
            get { return 5; }
        }

        public void Draw3D() {
            Console.WriteLine("Drawing Hexagon in 3D");
        }
    }

    public class Test : IPointy {
        public byte Points {
            get {
                throw new NotImplementedException();
            }
        }
    }

    public interface IDrawToForm {
        void Draw();
    }

    public interface IDrawToMemory {
        void Draw();
    }

    public interface IDrawToPrinter {
        void Draw();
    }

    class Octagon: IDrawToForm, IDrawToMemory, IDrawToPrinter {
        void IDrawToForm.Draw() {
            Console.WriteLine("Drawing to form...");
        }

        void IDrawToMemory.Draw() {
            Console.WriteLine("Drawing to a memory...");
        }

        void IDrawToPrinter.Draw() {
            Console.WriteLine("Drawing to a printer...");
        }
    }
}
