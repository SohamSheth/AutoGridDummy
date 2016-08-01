using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoGrid_KANDA
{
    public class GridPropsClass
    {

        public int Nx { get { return _Nx; } set { _Nx = value; } }
        public int Ny { get { return _Ny; } set { _Ny = value; } }
        public double Lx { get { return _Lx; } set { _Lx = value; } }
        public double Ly { get { return _Ly; } set { _Ly = value; } }
        public double MinThick { get { return _MinThick; } set { _MinThick = value; } }

        private double _Lx;
        private double _Ly;
        private int _Nx;
        private int _Ny;
        private double _MinThick;
    }
}
