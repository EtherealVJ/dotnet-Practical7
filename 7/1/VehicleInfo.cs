using System;
namespace VehicleInfo{
class VehicleSelcSort
    {
        static public void Sort<T>(IList<T> SelcSort, Func<T, T, bool> comparison)
        {
            for (int i = 0; i < SelcSort.Count - 1; i++)
            {
                int key = i;
                for (int j = i + 1; j < SelcSort.Count; j++)
                {              
                    if (comparison(SelcSort[j], SelcSort[key]))
                    {
                        key = j;
                    }
                }                      
                T temp = SelcSort[i];
                SelcSort[i] = SelcSort[key];
                SelcSort[key] = temp;
            }
        }

    }
    
    public enum VehicleType{
        TwoWheeler=1,
        ThreeWheeler=2,
        FourWheeler=3,
        SixWheeler=4,
        EightWheeler=5              
    } 

        class Vehicle
        {
            int VehicleNo;
            public float Cost;
            public string Name;
            public VehicleType vehicleType;

            public Vehicle(int vehicleNo, float cost, string name, VehicleType vtype)
            {
                this.VehicleNo = vehicleNo;
                this.Cost = cost;
                this.Name = name;
                this.vehicleType = vtype;
            }

           internal static bool CompareCost(Vehicle v1, Vehicle v2)
            {
                return v1.Cost < v2.Cost;
            }

           internal static bool  CompareName(Vehicle v1, Vehicle v2)
            {
                if(v1.Name.CompareTo(v2.Name)== 1)
                {           
                    return true;
                }
                else
                {
                    return false;
                }

            }

           internal static bool  CompareVehicleType(Vehicle v1, Vehicle v2)
            {
                return v1.vehicleType < v2.vehicleType;
            }
        }
}