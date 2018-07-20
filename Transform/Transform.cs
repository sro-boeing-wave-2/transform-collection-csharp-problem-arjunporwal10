using System;
using System.Linq;
using System.Collections.Generic;

namespace Transform
{
    public static class Transform 
    {
        public static T[] Map<T>(this int[] numberArray, Func<int , T> property)
        {
            //throw new NotImplementdException();
            T[] myArray = new T[numberArray.Length];
            for(int i=0;i<numberArray.Length;i++)
            {
                myArray[i] = property(numberArray[i]);

            }
            return myArray;

        }
    }
}
