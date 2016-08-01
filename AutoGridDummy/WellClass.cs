using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoGrid_KANDA
{
    public class WellClass
    {
        public WellClass(int WellNum )
        {
            _WellNumber = WellNum;        
        }
        public void SetDefault(CaseClass CaseObject, GridPropsClass GridProps)
        {
            _WellLength = CaseObject.WellLength;
            _NumberOfStagesPerWell = CaseObject.NumberOfStagesPerWell;
            _NumberOfPerfClustersPerStage = CaseObject.NumberOfPerfClustersPerStage;
            _SuccessRateOfPerforations = CaseObject.SuccessRateOfPerforations;
            _FractureHalfLength = CaseObject.FractureHalfLength;
            _WellStartingPointX = ( GridProps.Lx - _WellLength )/2.0 ;
            _WellStartingPointY = (GridProps.Ly / ((double)CaseObject.NumerOfWells)) * _WellNumber + (GridProps.Ly / ((double)CaseObject.NumerOfWells) / 2.0);
        }
        public int WellNumber { get { return _WellNumber; } }
        public double WellStartingPointX { get { return _WellStartingPointX; } set { _WellStartingPointX = value; } }
        public double WellStartingPointY { get { return _WellStartingPointY; } set { _WellStartingPointY = value; } }
        public double WellLength { get { return _WellLength; } set { _WellLength = value; } }
        public int NumberOfStagesPerWell { get { return _NumberOfStagesPerWell; } set { _NumberOfStagesPerWell = value; } }
        public int NumberOfPerfClustersPerStage { get { return _NumberOfPerfClustersPerStage; } set { _NumberOfPerfClustersPerStage = value; } }
        public double SuccessRateOfPerforations { get { return _SuccessRateOfPerforations; } set { _SuccessRateOfPerforations = value; } }
        public double FractureHalfLength { get { return _FractureHalfLength; } set { _FractureHalfLength = value; } }
        public List<double> IsFirstOpen { get { return _IsFirstOpen; } set { _IsFirstOpen = value;} }

        private int _WellNumber;
        private double _WellStartingPointX;
        private double _WellStartingPointY;
        private double _WellLength;
        private int _NumberOfStagesPerWell;
        private int _NumberOfPerfClustersPerStage;
        private double _SuccessRateOfPerforations;
        private double _FractureHalfLength;
        private List<double> _IsFirstOpen= new List<double>();
    }
}
