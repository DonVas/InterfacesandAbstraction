using System;
using System.Linq;
using CollectionHierarchy.Models;

namespace CollectionHierarchy
{
    public class Program
    {
        public static void Main()
        {
            AddCollection addCollectionc = new AddCollection();
            AddRemoveCollection addRemoveCollection = new AddRemoveCollection();
            MyList myList = new MyList();
            
            var input = Console.ReadLine()
                .Split();
            int[][] indexes = new int[3][];

            for (int i = 0; i < 3; i++)
            {
                indexes[i]= new int[input.Length];
                for (int j = 0; j < input.Length; j++)
                {                    
                    switch (i)
                    {
                        case 0:
                            indexes[i][j]=addCollectionc.Add(input[j]);
                            break;
                        case 1:
                            indexes[i][j] = addRemoveCollection.Add(input[j]);
                            break;
                        case 2:
                            indexes[i][j] = myList.Add(input[j]);
                            break;
                    }
                }
            }

            Console.WriteLine(string.Join(Environment.NewLine, indexes.Select(x => string.Join(" ", x))));
            int count = int.Parse(Console.ReadLine());

            string[][] result = new string[2][];
            for (int row = 0; row < 2; row++)
            {
                result[row]= new string[count];
                for (int col = 0; col < count; col++)
                {
                    switch (row)
                    {
                        case 0:
                            result[row][col] = addRemoveCollection.Remove();
                            break;
                        case 1:
                            result[row][col] = myList.Remove();
                            break;
                    }
                }
            }
            Console.WriteLine(string.Join(Environment.NewLine, result.Select(x => string.Join(" ", x))));
        }
    }
}
