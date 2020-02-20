using System;
using System.Linq;
using System.Collections.Generic;


namespace Zoo
{
    class Result
    {
        public int output1;
        public int output2;
    }
    class Program
    {
        static void Main(string[] args)
        {
            //var 

            Console.WriteLine(45/60);
            Console.WriteLine(45%60);
        }

        public Result calculateTime(int input1, int[] input2,int[] input3 ,int[] input4,int[] input5)
        {
            var timeValues = new int[3];
            var finalTime = new Result()
            {
                output1 = 0,
                output2 = 0
            };
            for (int i = 1; i <= input1; i++)
            {
                if (input1 == 2)
                {
                    timeValues = input2;
                    
                }
                else if (input1 == 3)
                {
                    timeValues = input3;
                }
                else if (input1 == 4)
                {
                    timeValues = input4;
                }
                else
                {
                    timeValues = input5;
                }
                var temp = getTime(timeValues);
                if (temp.output1 > finalTime.output1)
                {
                    finalTime = temp;
                }
            }
            return finalTime;           

        }
        public Result getTime(int[] timeValues)
        {
            var hour = timeValues[0];
            var minutes = timeValues[1];
            var duration = timeValues[2];

            var extraHours = duration / 60;
            var extraMinutes = duration % 60;

            hour += extraHours;
            minutes += extraMinutes;

            if (minutes > 60)
            {
                minutes -= 60;
                hour++;
            }

            if (hour > 23)
            {
                hour -= 24;
            }

            var result = new Result()
            {
                output1 = hour,
                output2 = minutes
            };
            return result;

        }
    }
}
