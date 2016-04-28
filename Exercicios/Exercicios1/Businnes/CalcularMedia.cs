using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Exercicios1.Businnes
{
    public class CalcularMedia
    {
        public static double CalculateWithArray(double[] array) 
        {
             double[]notas = array;
            double media;



            media = (array[0] + array[1] + array[2])  /array.Count();

            return media;
             

        }

        public static double CalculateWithList(List<double> listadenotas ) 
        {
             double media;
            List<double> notas = listadenotas;

            media = notas.Average();
            return media;

        }

       

    }
}