using System;

namespace TEST01
{
    public class Doors
    {
        #region singleton
        private static Doors _instance;
        
        public static Doors Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Doors();
                
                return _instance;
            }
        }
        
        private Doors()
        {
        }
        #endregion

        public bool CanGo(Point from, Point to)
        {
            throw new Exception();
        }
    }
}