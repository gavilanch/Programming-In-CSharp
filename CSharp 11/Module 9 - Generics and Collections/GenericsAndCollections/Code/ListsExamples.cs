using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsAndCollections.Code
{
    internal class ListsExamples
    {
        public void TheCode()
        {
            int[] numbers = { 1, 2, 3 };

            List<int> numbersList = new List<int>() { 1, 2, 3 };

            numbersList.Add(4);

            // error
            //numbersList.Add("Felipe");

            numbersList[1] = 5;

            //numbersList.Remove(3);

            numbersList.RemoveAt(1);

            numbersList.Clear();

            if (numbersList.Count == 0)
            {
                Console.WriteLine("The list is empty");
            }

            foreach (var number in numbersList)
            {
                Console.WriteLine(number);
            }

            var anotherList = new List<int>() { 5, 1, 12, -4 };
            anotherList.Sort();

            foreach (var number in anotherList)
            {
                Console.WriteLine(number);
            }
        }
    }
}
