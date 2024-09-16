using System;

namespace SimpleCalculator
{
    public static class InputConverter
    {
        public static double ConvertInputToNumeric(string argTextInput)
        {
            double c = 0 ;
            
            
                
                if(!double.TryParse(argTextInput, out c)){
                throw new ArgumentException("enter a number");
                
            }
            
            
                
            
            
            
                return c;
            
        }
    }
}
