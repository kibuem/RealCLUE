using System.Collections.Generic;

namespace TEST01
{
    public class PlayerManagerMock
    {
        #region singleton
        private static PlayerManagerMock _instance;
        
        public static PlayerManagerMock Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new PlayerManagerMock();
                
                return _instance;
            }
        }
        
        private PlayerManagerMock()
        {
        }
        #endregion

        public bool IsPlayerOn(Point point)
        {
            return false;
        }

        public HashSet<Point> PointsOfPlayrs { get; } = new HashSet<Point>();

        public void AddPlayerLocation(Point point)
        {
            PointsOfPlayrs.Add(point);
        }
    }
}