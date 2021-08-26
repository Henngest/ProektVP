﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter
{
    class ConverterClass
    {
        private Dictionary<String, List<Unit>> unitsDictionary;
        private Unit unitObject;
        public ConverterClass()
        {
            unitsDictionary = new Dictionary<string, List<Unit>>();
            
            List<Unit> lengthUnits = new List<Unit>();
            unitObject = new Unit("nm", 0.000000001);
            lengthUnits.Add(unitObject);
            unitObject = new Unit("μm", 0.000001);
            lengthUnits.Add(unitObject);
            unitObject = new Unit("mm", 0.001);
            lengthUnits.Add(unitObject);
            unitObject = new Unit("cm", 0.01);
            lengthUnits.Add(unitObject);
            unitObject = new Unit("m", 1);
            lengthUnits.Add(unitObject);
            unitObject = new Unit("km", 1000);
            lengthUnits.Add(unitObject);
            unitObject = new Unit("in", 0.0254);
            lengthUnits.Add(unitObject);
            unitObject = new Unit("ft", 0.3048);
            lengthUnits.Add(unitObject);
            unitObject = new Unit("yd", 0.9144);
            lengthUnits.Add(unitObject);
            unitObject = new Unit("mi", 1609.34);
            lengthUnits.Add(unitObject);
            unitsDictionary.Add("Length", lengthUnits);

            List<Unit> weightUnits = new List<Unit>();
            unitObject = new Unit("mg", 0.000001);
            weightUnits.Add(unitObject);
            unitObject = new Unit("g", 0.001);
            weightUnits.Add(unitObject);
            unitObject = new Unit("kg", 1);
            weightUnits.Add(unitObject);
            unitObject = new Unit("t", 1000);
            weightUnits.Add(unitObject);
            unitObject = new Unit("lbs", 0.453592);
            weightUnits.Add(unitObject);
            unitObject = new Unit("oz", 0.0283495);
            weightUnits.Add(unitObject);
            unitsDictionary.Add("Weight", weightUnits);
        }
        public List<String> getUnitTypes() 
        {
            return unitsDictionary.Keys.ToList();
        }
        public List<Unit> getUnits(String unitType) 
        {
            return unitsDictionary[unitType];
        }
        public double convert(String fromUnit, String toUnit, double value, string selectedUnitType) 
        {
            double result = 0;
            double tempMultiplier = 0;
            double tempDenominator = 0;
            if (selectedUnitType == "Length")
            {
                foreach (Unit unit in unitsDictionary["Length"])
                {
                    if (unit.name == fromUnit)
                        tempMultiplier = unit.multiplier;
                    if (unit.name == toUnit)
                        tempDenominator = unit.multiplier;
                }
                return result = value * tempMultiplier / tempDenominator;
            }
            else if (selectedUnitType == "Weight")
            {
                foreach (Unit unit in unitsDictionary["Weight"])
                {
                    if (unit.name == fromUnit)
                        tempMultiplier = unit.multiplier;
                    if (unit.name == toUnit)
                        tempDenominator = unit.multiplier;
                }
                return result = value * tempMultiplier / tempDenominator;
            }
            return 0;
        }
    }
}
