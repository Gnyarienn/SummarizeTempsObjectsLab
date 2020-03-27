using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace SummarizeTempsObjects
{
    public class TempCalculationEngine
    {
        List<int> _temperatures;
        public TempCalculationEngine(List<int> temperatures)
        {
            _temperatures = temperatures;
        }

        public int AverageTemperature()
        {
            // add logic to calculate the average
            // sum temperatures in the list 
            // divide by the total number of temperatures in the list 
            int numoftemp=0;
            int sumoftemp=0;
            numoftemp = _temperatures.Count;
            int avgtemp = 0;
            foreach (int element in _temperatures)
            {
                sumoftemp +=element;
            }
            avgtemp = sumoftemp/numoftemp;
            return avgtemp;
            
       
        }

        public int TempsAboveThreshold(int threshold)
        {
            int abovecounter =0;
            int tempabove=0;

            foreach (int element in _temperatures)
            {
                if (element>threshold)
                {
                    abovecounter += 1;

                }
                
             
               
                
            }


            // add logic to calculate temps above the threshold
            return abovecounter; // <-- Replace this with the number
        }

        public int TempsBelowThreshold(int threshold)
        {
            int belowcounter = 0;
            int tempbelow = 0;
            foreach (int element in _temperatures)
            {
                if (element< threshold)
                {
                    belowcounter += 1; 
                }

            }
            // add logic to calculate and return temps below the threshold
            return belowcounter; // <-- Replace this with the number
        }

        public int TempsAtThreshold(int threshold)
        {
            int thresholdcounter=0;
            int thresholdtemps=0;
            foreach (int element in _temperatures)
            {
                if (element == threshold)
                {
                    thresholdcounter +=1;
                }
            }
            // add logic to calculate and return temps at the threshold
            return thresholdcounter; // <-- Replace this with the number
        }

        public int NumberOfTemperatures()
        {
            // add logic to return the number of temparature readings
            // <-- Replace this with the number
            return _temperatures.Count; 
        }
    }
}
