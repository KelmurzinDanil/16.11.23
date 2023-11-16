using System;
using System.Collections.Generic;

namespace BigRaces
{
    public class BigRacesShow
    {
        readonly List<Team> teams = new List<Team>();
        readonly List<IBigRaces> bigRacesGame = new List<IBigRaces>();
        public static BigRacesShow show = null;
        public void addTeam(Team team, string name) //Добавляет команду
        {
            if (name == "Оливье Ганьян")
            {
                teams.Add(team);
            }
            else
            {
                Console.WriteLine("Нет доступа");
            }
            
        }
        public void addGame(IBigRaces game, string name) //Добавляет игру
        {
            if (name == "Оливье Ганьян")
            {
                bigRacesGame.Add(game);
            }
            else
            {
                Console.WriteLine("Нет доступа");
            }

        }
        public void StartShow(IBigRaces _show) // Начинает игру
        {           
                _show.startGame();
        }
        public static BigRacesShow Show // Позволяет создать только один экземпляр.
        {
            get
            {
                if (show == null)
                {
                    show = new BigRacesShow();
                }
                return show;
            }
        }
        

    }
}
