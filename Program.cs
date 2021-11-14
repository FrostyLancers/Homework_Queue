using System;
using System.Collections;
using System.Collections.Generic;


namespace Queue_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            char cpu;
            char data;
            string word;
            int Cycles = 1;

            Queue CPU = new Queue();
            List<char> Data = new List<char>();
            Queue TemporaryCPU = new Queue();
            List<char> TemporaryData = new List<char>();


            while (true)
            {
                word = Console.ReadLine();
                cpu = Convert.ToChar(word.Split(' ')[0]);

                if (cpu == '?')
                {
                    break;
                }
                data = Convert.ToChar(word.Split(' ')[1]);

                if (!(CPU.Contains(cpu)))
                {
                    CPU.Enqueue(cpu);
                    Data.Add(data);
                }
              
                else if (CPU.Contains(cpu) && !(Data.Contains(data)))
                {
                    Data.Add(data);
                }

                if(CPU.Count > 4)
                {
                    Cycles++;                  

                    if (!(TemporaryCPU.Contains(cpu)))
                    {
                        TemporaryCPU.Enqueue(cpu);
                        TemporaryData.Add(data);
                    }

                    else if (TemporaryCPU.Contains(cpu) && !(TemporaryData.Contains(data)))
                    {
                        TemporaryData.Add(data);
                    }

                    if (TemporaryCPU.Count > 4)
                    {
                        CPU.Clear();
                        Data.Clear();
                    }
                }
            }
            Console.WriteLine("CPU cycles needed: " + Cycles);
        }
    }
}
