using System;
namespace ExerciseTracking;

 public class Swimming : Activity
    {
        private int laps;

        public Swimming(DateTime date, int lengthMinutes, int laps) 
        :base(date, lengthMinutes)
        {
            this.laps = laps;
        }

        public override double GetDistance()
        {
            return laps * 50 / 1000;
        }

        public override double GetSpeed()
        {
            return (GetDistance() / lengthMinutes) * 60;
        }

        public override double GetPace()
        {
            return lengthMinutes / GetDistance();
        }
    }
