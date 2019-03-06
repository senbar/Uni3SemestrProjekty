using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciagi
{
    class Program
    {
        delegate bool comparisonFunction(double a, double b); 

        static bool NonDecreasingComp(double a, double b)
        {
            return a <= b;
        }
        static bool NonIncreasingComp(double a, double b)
        {
            return a >= b;
        }
        static bool IncreasingComp(double a, double b)
        {
            return b > a;
        }
        static bool DecreasingComp(double a, double b)
        {
            return b < a;
        }


        static List<List<double>> AnalyzeSeq(List<double> sequence, comparisonFunction func)
        {
            List<List<double>> doneSequences = new List<List<double>>();
            foreach (double word in sequence)
            {
                foreach(List<double> doneSequence in doneSequences)
                {
                    if(func.Invoke(doneSequence[doneSequence.Count-1],word))
                    {
                        doneSequence.Add(word);
                    }
                }
                doneSequences.Add(new List<double>() {word});
            }
            return doneSequences;
        }


        static void Main(string[] args)
        {
            Console.Write("podaj kolejne wyrazy ciagu:");
            List<double> sequence = new List<double>();
            for (int i = 0; ;i++)
            {
                string hWord=Console.ReadLine();
                try
                {
                    sequence.Add(double.Parse(hWord));
                }catch (FormatException e)
                {
                    break;
                }
            }

            Console.WriteLine("Qybierz rodzaj podciagow jakie chcesz uzyskac" + '\n' + "Nierosnace- 1" + '\n' + "Niemalejace- 2" +'\n' + "Rosnace- 3" + '\n' + "Malejace- 4");
            int choice = 0;
            while (true)
            {
                ConsoleKeyInfo hChoice = Console.ReadKey();
                if ((new[] { '1', '2', '3', '4' }).Contains(hChoice.KeyChar) && int.TryParse(hChoice.KeyChar.ToString(), out choice))
                    break;
            }

            comparisonFunction func= null;
            switch (choice)
            {
                case (1):
                    func = new comparisonFunction(NonIncreasingComp);
                    break;
                case (2):
                    func = new comparisonFunction(NonDecreasingComp);
                    break;
                case (3):
                    func = new comparisonFunction(IncreasingComp);
                    break;
                case(4):
                    func = new comparisonFunction(DecreasingComp);
                    break;
            }
            List<List<double>> seqs = AnalyzeSeq(sequence, func);

            Console.Clear();
            foreach(List<double> seq in seqs)
            {
                foreach(double word in seq)
                {
                    Console.Write(word.ToString() + " ");
                }
                Console.Write('\n');
            }


            Console.ReadKey();
        }

    }
}
