namespace MasterChiefRoom
{
    public class Sleeper
    {
        private static Sleeper _instance = null;

        public static Sleeper Instance
        {
            get { return _instance ?? (_instance = new Sleeper()); }
        }

        public int Interval { get; set; }
        public bool IsPaused { get; set; }
        public int TimeElapsed { get; set; } //TODO Log
        public bool IsEnd { get; set; }
        public int Period
        {
            get
            {
                return 1000 / Interval;
            }
        }

        private Sleeper()
        {
            Interval = 1;
            IsPaused = false;
            TimeElapsed = 0;
            IsEnd = false;
        }

    }
}