using System.Collections.Generic;

namespace Construction
{
    public static class Creator
    {
        private static Dictionary<int, Building> buildings = new Dictionary<int, Building>();
        private static int uniqueNumber = 10;
        public static Building CreateBuilding(string name, string address, int floors)
        {
            Building building = new Building()
            {
                Name = name,
                Address = address,
                Floors = floors
            };

            int uniqueNumber = GenerateUniqueNumber();
            buildings.Add(uniqueNumber, building);
            building.UniqueNumber = uniqueNumber;

            return building;
        }

        public static void RemoveBuilding(int uniqueNumber)
        {
            buildings.Remove(uniqueNumber);
        }

        private static int GenerateUniqueNumber()
        {
            return uniqueNumber++;
        }
    }
}
