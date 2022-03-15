using FiguresInheritance.domain;
using FiguresInheritance.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Единственное, нет проверок на отрицательные числа и на стороны (потипу как для треугольника)
            // Надеюсь, это не проблема
            var figuresContainer = new FiguresContainer();

            figuresContainer.AddFigure(new Figure());
            figuresContainer.AddFigure(new LineSegment(10.5f));
            figuresContainer.AddFigure(new Square(7.8f));
            figuresContainer.AddFigure(new Cube(15.6f));
            figuresContainer.AddFigure(new Rectangle(4.2f, 2.1f));
            figuresContainer.AddFigure(new Rhombus(11, 5.5f));
            figuresContainer.AddFigure(new Triangle(5, 8, 10));
            figuresContainer.AddFigure(new TrianglePrism(5.5f, 8.8f, 10.1f, 12.4f));
            figuresContainer.AddFigure(new Circle(11.1f));
            figuresContainer.AddFigure(new Cylinder(21.3f, 7));
            figuresContainer.AddFigure(new Cone(18.2f, 8.9f));

            if(!figuresContainer.PrintAllFigures())
                throw new ArgumentNullException(nameof(figuresContainer));
            Console.WriteLine("-------------------------------------------------------");
            figuresContainer.PrintFigureByIndex(3);
            Console.WriteLine("-------------------------------------------------------");
            figuresContainer.DeleteFigureByIndex(3);

            if (!figuresContainer.PrintAllFigures())
                throw new ArgumentNullException(nameof(figuresContainer));

            Console.WriteLine("Done :)");
            Console.ReadLine();
        }
    }
}
