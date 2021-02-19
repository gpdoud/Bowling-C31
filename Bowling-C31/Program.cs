using System;
using System.Collections.Generic;

namespace Bowling_C31 {
    class Program {

        static int Bowl1Game(Random rnd) {
            var game = new List<int>(10);
            for(var idx = 0; idx < 10; idx++) {
                var score = rnd.Next(0, 31);
                game.Add(score);
            }
            var total = 0;
            foreach(var score in game) {
                total += score;
            }
            //Console.WriteLine($"Bowling score is {total}");
            return total;
        }
        static void Main(string[] args) {
            var rnd = new Random();
            var series = 0;
            long counter = 1;
            var score = Bowl1Game(rnd);
            while(score != 300) {
                score = Bowl1Game(rnd);
                counter++;
                if(counter % 1000000 == 0) {
                    Console.WriteLine($"Current counter is {counter / 1000000} million");
                }
            }
            Console.WriteLine($"Games till 300 is {counter}");
        }
    }
}
