namespace FarmOOP
{
    public abstract class Crop
    {
        protected static readonly Random random = new();
        protected string cropType;
        protected string season;
        protected int growthTime;
        protected int regrowTime;
        protected int currentAge;
        protected (int, int) yield;
        protected bool isWateredToday;
        //private bool requiresFertiliser;
        protected bool canHarvest;

        public Crop(string cropType, string season, int growthTime, int regrowTime, (int, int) yield)
        {
            this.cropType = cropType;
            currentAge = 0;
            this.season = season;
            this.growthTime = growthTime;
            this.regrowTime = regrowTime;
            this.yield = yield;
            //requiresFertiliser = plantDetails[cropType].Item5;
            canHarvest = false;
        }

        public Dictionary<string, object> GetReport()
        {
            return new Dictionary<string, object>
            {
                { "cropType", cropType },
                { "season", season },
                { "growthTime", growthTime },
                { "regrowTime", regrowTime },
                { "currentAge", currentAge },
                { "yield", yield },
                { "isWateredToday", isWateredToday },
                // { "requiresFertiliser", requiresFertiliser },
                { "canHarvest", canHarvest }
            };
        }

        public void Water()
        {
            isWateredToday = true;
        }

        public int GetAge()
        {
            return currentAge;
        }

        public void IncrementDay()
        {
            if (isWateredToday)
            {
                currentAge++;
            }
            isWateredToday = false;
            if (currentAge >= growthTime)
            {
                currentAge = growthTime - regrowTime;
                canHarvest = true;
            }
        }

        public int GetHarvest()
        {
            canHarvest = false;
            return random.Next(yield.Item1, yield.Item2);
        }
    }
}