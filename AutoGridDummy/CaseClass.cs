using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoGrid_KANDA
{
    public class CaseClass
    {
        public CaseClass (int CNumber)
	{
        _CaseNumber = CNumber;
	}
        //Public properties - Access and Assign
        public int CaseNumber { get { return _CaseNumber; } }
        public string WellDirection { get { return _WellDirection; } set { _WellDirection = value;} }
        public int NumerOfWells { get { return _NumberOfWells; } set { _NumberOfWells = value;} }
        public double WellLength { get { return _WellLength; } set { _WellLength = value;} }
        public int NumberOfStagesPerWell { get { return _NumberOfStagesPerWell; } set { _NumberOfStagesPerWell = value;} }
        public int NumberOfPerfClustersPerStage { get { return _NumberOfPerfClustersPerStage; } set { _NumberOfPerfClustersPerStage = value; } }
        public double SuccessRateOfPerforations { get { return _SuccessRateOfPerforations; } set { _SuccessRateOfPerforations = value; } }
        public double FractureHalfLength { get { return _FractureHalfLength; } set { _FractureHalfLength = value; } }
        public double PerforationTolerance { get { return _PerforationTolerance; } set { _PerforationTolerance = value; } }
        public bool IsFirstOpen { get{return _IsFirstOpen;} set{_IsFirstOpen = value;} }

        
        //Private variables
        private int _CaseNumber;
        private string _WellDirection; 
        private int _NumberOfWells;
        private double _WellLength;
        private int _NumberOfStagesPerWell;
        private int _NumberOfPerfClustersPerStage;
        private double _SuccessRateOfPerforations;
        private double _FractureHalfLength;
        private double _PerforationTolerance;
        private bool _IsFirstOpen;

        public List<WellClass> WellObjects = new List<WellClass>();
        public void InitializeWellObjects() 
        {
            WellObjects.Clear();
            for (int i = 0; i < _NumberOfWells; i++)
            {
                WellObjects.Add(new WellClass(i));
            }
        }

        public void SetWellDefault(GridPropsClass GridProps) 
        {
            for (int i = 0; i < NumerOfWells; i++)
            {
                WellObjects[i].SetDefault(this, GridProps);
            }      
        }
    }
}
 