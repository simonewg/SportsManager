using System;
using System.Collections.Generic;
using System.Text;
using SportManager.Model;

namespace SportManager
{
    class LogicLayer : ILogic
    {

        public IPersistence MyPersitence { get; set; }

        public LogicLayer(IPersistence persistence)
        {
            //MyPersitence = new PersistenceLayer();
            MyPersitence = persistence;
        }
        public Athlete[] getAllAthletes()
        {
            Athlete[] athleteArray = MyPersitence.AllAthlete; //AllAthlete esiste in PersistenceLayer
            Athlete temp = null;

            for (int i = 1; i < athleteArray.Length; i++)
            {
                for (int j = 0; j < athleteArray.Length - i; j++)
                {
                    if (athleteArray[j].Name.CompareTo(athleteArray[j + 1].Name) > 0)
                    {
                        temp = athleteArray[j];
                        athleteArray[j] = athleteArray[j + 1];
                        athleteArray[j + 1] = temp;
                    }
                }
            }
            return athleteArray;
        }

        public void insertAthlete(Athlete athlete)
        {
            Console.WriteLine(athlete);
        }

        public Athlete searchAthlete(string name)
        {
            throw new NotImplementedException();
        }
    }
}
