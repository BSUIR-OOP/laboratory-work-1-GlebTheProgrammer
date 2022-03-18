using FiguresInheritance.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresInheritance.Models
{
    internal class Figure : IFigure
    {
        public static int Count { get; set; } = 0;
        public int Id { get; set; }

        public Figure()
        {
            Id = Count++;
        }

        public virtual void GetAllFields()
        {
            Console.WriteLine("\nI'm just a figure :)\n");
        }
    }
}
