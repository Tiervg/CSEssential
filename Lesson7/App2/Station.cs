using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2
{
    class Station
    {
        Train[] trains = new Train[8];

        public void AddTrain(string destination, int number, DateTime departuteTime)
        {
            for (int i = 0; i < trains.Length; i++)
            {
                if (trains[i].DestinatoinPoint == null && trains[i].Number == 0)
                {
                    trains[i] = new Train(destination, number, departuteTime);
                    break;
                }
            }

        }

        public void SortTrains()
        {
            for (int i = 0; i < trains.Length; i++)
            {
                for (int j = 0; j < trains.Length; j++)
                {
                    if (trains[j].Number > trains[i].Number)
                    {
                        string temp = null;
                        DateTime tempdate;
                        
                        trains[i].Number = trains[j].Number + trains[i].Number;
                        trains[j].Number = trains[i].Number - trains[j].Number;
                        trains[i].Number = trains[i].Number - trains[j].Number;
                        temp = trains[j].DestinatoinPoint;
                        trains[j].DestinatoinPoint = trains[i].DestinatoinPoint;
                        trains[i].DestinatoinPoint = temp;
                        tempdate = trains[j].DepartureTime;
                        trains[j].DepartureTime = trains[i].DepartureTime;
                        trains[i].DepartureTime = tempdate;
                    }
                }
            }
        }

        public string this[int number]
        {
            get
            {
                for (int i = 0; i < trains.Length; i++)
                {
                    if (number == trains[i].Number)
                        return string.Format("Searched train:\nNumber: {0}, Destinamtion: {1}, Departure: {2}", trains[i].Number, trains[i].DestinatoinPoint, trains[i].DepartureTime);
                }
                return "There is no trains with this number";
            }
        }

        public void ShowTrains()
        {
            for (int i = 0; i < trains.Length; i++)
            {
                Console.WriteLine("{0,-10} | {1,-20} | {2,-20} |",trains[i].Number,trains[i].DestinatoinPoint,trains[i].DepartureTime);
            }
        }
    }
}
