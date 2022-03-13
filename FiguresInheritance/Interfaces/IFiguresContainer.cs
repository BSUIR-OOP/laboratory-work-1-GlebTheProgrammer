﻿using FiguresInheritance.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresInheritance.Interfaces
{
    internal interface IFiguresContainer
    {
        bool PrintAllFigures();
        bool PrintFigureByIndex(int index);
        bool DeleteFigureByIndex(int index);
        bool AddFigure(Figure figure);
    }
}
