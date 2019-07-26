using System;

namespace AverageScoresProject {
    class Program {
        static void Main(string[] args) {
            int[] scores =
                { 71, 78, 89, 73, 68, 73, 96, 71, 72, 65, 100, 100, 100, 100, 100, 100, 100};

            

            //int[] scores = new int[12];
            //scores[0] = 71;
            //scores[1] = 78;
            //scores[2] = 89;
            //scores[3] = 73;
            //scores[4] = 68;
            //scores[5] = 73;
            //scores[6] = 96;
            //scores[7] = 71;
            //scores[8] = 72;
            //scores[9] = 65;
            //scores[10] = 87;
            //scores[11] = 63; 

            int total = 0;
            int index = 0;
            while (index < scores.Length)
                {
                total = total + scores[index];
                index = index + 1;
            }
            
            Console.WriteLine($"The average score is {total/scores.Length}%.");


        }
    }
}
