using System;
using System.Collections.Generic;
using System.Linq;

namespace sr_1
{
    class Cars
    {
        private List<Car> cars = new List<Car>();

        public Cars()
        {
            string[] colors_1 = { "Red", "Blue" };
            string[] colors_2 = { "Blue", "Black" };
            string[] colors_3 = { "White", "Yellow" };
            cars.Add(new Car(colors_1, 1993, 930000, 20));
            cars.Add(new Car(colors_2, 1994, 50000, 25));
            cars.Add(new Car(colors_1, 1995, 110000, 30));
            cars.Add(new Car(colors_2, 1998, 670000, 20));
            cars.Add(new Car(colors_3, 2000, 100000, 50));
        }

        public void showInfoAboutCars()
        {
            foreach (var car in cars)
                car.showInfo();
        }
        private void showInfoAboutCarsFromIndex(in List<sbyte> index)
        {
            for (var i = 0; i < index.Count(); i++)
                cars[index.ElementAt(i)].showInfo();
        }
        private List<sbyte> indexCarsWithColor(string color)
        {
            List<sbyte> listIndex = new List<sbyte>();
            color = color.ToLower();
            for (var i = 0; i < cars.Count; i++)
                for (var j = 0; j < cars[i].colors.Count; j++)
                    if (cars[i].colors[j].ToLower() == color)
                        listIndex.Add((sbyte)i);
            return listIndex;
        }
        private List<sbyte> indexCarsWithYearOfMade(int yearOfMade)
        {
            List<sbyte> listIndex = new List<sbyte>();
            for (var i = 0; i < 5; i++)
                if (cars[i].yearOfMade == yearOfMade)
                    listIndex.Add((sbyte)i);

            return listIndex;
        }
        private List<sbyte> indexCarsWithPrice(int price)
        {
            List<sbyte> listIndex = new List<sbyte>();
            for (var i = 0; i < 5; i++)
                if (cars[i].price == price)
                    listIndex.Add((sbyte)i);
            return listIndex;
        }
        private List<sbyte> indexCarsWithEnginePower(int enginePower)
        {
            List<sbyte> listIndex = new List<sbyte>();
            for (var i = 0; i < 5; i++)
                if (cars[i].enginePower == enginePower)
                    listIndex.Add((sbyte)i);
            return listIndex;
        }
        private List<sbyte> uniteListsOfIndex(in List<sbyte> lb_1, in List<sbyte> lb_2)
        {
            List<sbyte> result = new List<sbyte>();
            if (lb_1.Count != 0 || lb_2.Count != 0)
            {
                foreach (sbyte elem in lb_1)
                    result.Add(elem);
                foreach (sbyte elem in lb_2)
                    result.Add(elem);
            }
            return result;
        }
        private List<sbyte> MyDistinct(in List<sbyte> lb)
        {
            List<sbyte> result = lb;
            for (var i = 0; i < result.Count; i++)
                for (var j = 0; j < result.Count; j++)
                    if (result[i] == result[j] && i != j)
                        result.RemoveAt(j);
            return result;
        }
        private List<sbyte> createListFromDublicatesOfIndex(in List<sbyte> lb)
        {
            List<sbyte> result = new List<sbyte>();
            for (var i = 0; i < lb.Count; i++)
                for (var j = 0; j < lb.Count; j++)
                    if (lb[i] == lb[j] && i != j)
                    {
                        result.Add(lb[i]);
                        break;
                    }
            return MyDistinct(in result);
        }
        public void findCar(byte amount, string color, int yearOfMade = 0, int price = 0, int enginePower = 0)
        {
            var carsWithColor = indexCarsWithColor(color);
            var carsWithYearOfMade = indexCarsWithYearOfMade(yearOfMade);
            var carsWithPrice = indexCarsWithPrice(price);
            var carsWithEnginePower = indexCarsWithEnginePower(enginePower);

            List<sbyte> result = uniteListsOfIndex(in carsWithColor, in carsWithYearOfMade);
            result = uniteListsOfIndex(in result, in carsWithPrice);
            result = uniteListsOfIndex(in result, in carsWithEnginePower);
            if(amount != 3)
                result = createListFromDublicatesOfIndex(in result);

            if (result.Count() != 0)
                showInfoAboutCarsFromIndex(in result);
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n-Извините, пока машини с такими параметрами нет на складе ):");
            }
        }

    }
}
