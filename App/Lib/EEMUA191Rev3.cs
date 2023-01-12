namespace App.Lib {
    public static class EEMUA191Rev3
    {
        public static string GetZoneForPoint(double x, double y){
            
            if(IsOutsideGraph(x,y)) return StateNames.NotOnGraph;
            
            if (IsRobust(x,y)) return StateNames.Robust;
            if (IsStable(x,y)) return StateNames.Stable;
            if (IsReactive(x,y)) return StateNames.Reactive;
            if (IsOverloaded(x,y)) return StateNames.Overloaded;
            
            return StateNames.NotOnGraph;
        }

        private static bool IsOutsideGraph(double x, double y)
        {
            return x < 0 || y < 0 || x > 100 || y > 50;
        }

        private static bool IsOverloaded(double x, double y)
        {
            return x <= 100;
        }

        private static bool IsReactive(double x, double y)
        {
            return x <= 10 
                && y <= 56.25 - 3.125 * x;
        }

        private static bool IsRobust(double x, double y){
            return x <= 1 
                && y <= 15 - 15 * y;
        }

        private static bool IsStable(double x, double y){
            return x <= 2 
                && y <= 75 - 25 * x;
        }

        public static class StateNames
        {
            public const string
                Robust = "Robust",
                Stable = "Stable",
                Reactive = "Reactive",
                Overloaded = "Overloaded",
                NotOnGraph = "Not on graph";

        }
    }
}