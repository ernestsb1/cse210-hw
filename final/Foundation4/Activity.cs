using System;
using System.Collections.Generic;

namespace ExerciseTracking;

    
    public abstract class Activity
    {
        private DateTime date;
        public int lengthMinutes;

        public Activity(DateTime date, int lengthMinutes)
        {
            this.date = date;
            this.lengthMinutes = lengthMinutes;
        }

        public abstract double GetDistance();
        public abstract double GetSpeed();
        public abstract double GetPace();

        public string GetSummary()
        {
            return $"{date.ToString("yyyy MMM dd")} {GetType().Name} ({lengthMinutes} min) - " +
                   $"Distance: {GetDistance()}, Speed: {GetSpeed()}, Pace: {GetPace()}";
        }
    }

