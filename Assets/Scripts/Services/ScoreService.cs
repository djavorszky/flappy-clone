using System.Collections;
using System.Collections.Generic;
using System;


namespace Service
{
    public static class ScoreService
    {
        private static int score = 0;

        private static List<Action<int>> listeners = new List<Action<int>>();

        public static void Increment()
        {
            score++;
            foreach (var listener in listeners)
            {
                listener(score);
            }
        }

        public static void OnScoreChange(Action<int> listener)
        {
            listeners.Add(listener);
        }

    }

}
