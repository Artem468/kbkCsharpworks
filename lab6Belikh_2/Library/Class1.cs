using System;

namespace Library
{
    public class Matrix
    {
        public static double GetMaxSquares(double[,] matrix)
        {
            double[] vector = new double [matrix.GetLength(1)];
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                double maxItem = 0;
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    if (matrix[j, i] > maxItem)
                    {
                        maxItem = matrix[j, i];
                    }       
                }

                vector[i] = maxItem;
            }

            double underAbs = 0;
            foreach (double item in vector)
            {
                double mult = 1;
                for (int k = vector.Length - 1; k <= vector.Length; k++)
                {
                    mult *= k;
                } 
                
                underAbs += Math.Pow(item, 3) + mult;
            }
            return Math.Sqrt(Math.Abs(underAbs));
        }
        
        
    }
}