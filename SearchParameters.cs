﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace Phobiae.PathFinding
{
    class SearchParameters
    {
        public Point StartLocation { get; set; }

        public Point EndLocation { get; set; }

        public bool[,] Map { get; set; }

        public SearchParameters(Point startLocation, Point endLocation, bool[,] map)
        {
            this.StartLocation = startLocation;
            this.EndLocation = endLocation;
            this.Map = map;
        }
    }
}
