using System;

namespace DSAL2_KFS
{
    class Program
    {
        static void Main(string[] args)
        {
            DecisionTree decisionTree = new DecisionTree();
            Console.WriteLine("first is yes yes yes yes");
            Console.WriteLine(decisionTree.StudentActivity(true, true, true, true));
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("second is no yes no yes");
            Console.WriteLine(decisionTree.StudentActivity(false, true, false, true));
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("third is no no yes yes");
            Console.WriteLine(decisionTree.StudentActivity(false, false, true, true));
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("fouth is yes no no yes");
            Console.WriteLine(decisionTree.StudentActivity(true, false, false, true));
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("fifth is yes no yes no");
            Console.WriteLine(decisionTree.StudentActivity(true, false, true, false));
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("sixth is yes yes yes no");
            Console.WriteLine(decisionTree.StudentActivity(true, true, true, false));
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("seventh is yes no yes yes");
            Console.WriteLine(decisionTree.StudentActivity(true, false, true, true));
            Console.WriteLine("---------------------------------------------------------------");
            Console.ReadKey();
        }
    }
}
