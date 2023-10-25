using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.AgafonovKS.Sprint3.Task7.V18.Lib;

namespace Tyuiu.AgafonovKS.Sprint3.Task7.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;

            int len = stopValue - startValue + 1;
            double[] valueWaitArray;
            valueWaitArray = new double[len];

            valueWaitArray[0] = 8.00;
            valueWaitArray[1] = 7.00;
            valueWaitArray[2] = 7.00;
            valueWaitArray[3] = 8.00;
            valueWaitArray[4] = 16.00;
            valueWaitArray[5] = 2.00;
            valueWaitArray[6] = 4.00;
            valueWaitArray[7] = 6.00;
            valueWaitArray[8] = 6.00;
            valueWaitArray[9] = 6.00;
            valueWaitArray[10] = 6.00;

            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(valueWaitArray, res);
        }
    }
}
