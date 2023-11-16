using System;

namespace BigRaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string organizerName = "Оливье Ганьян";
            string[] russianPlayers = { "Андрей", "Руслан", "Святослав", "Евгнений", "Иван", "Олег", "Петр",
                "Аркадий", "Динар", "Глеб", "Никита", "Динар", "Денис", "Артем", "Адель"};         
            Team russianTeam = new Team("Россия", russianPlayers);
            string[] francePlayers = {"Даниэль", "Виржини", "Доминик", "Анн", "Аднот", "Амеди", "Лазар",
                "Леопольд", "Лео", "Лоран", "Филипп", "Франк", "Теодор", "Тимоти", "Сириль"};
            Team franceTeam = new Team("Франция", francePlayers);
            string[] chinaPlayers = {"Бэй", "Бохай", "Ганг", "Да", "Джинг", "Зихао", "Ийнгджи",
                "Зэнгжонг", "Йи", "Ксин", "Ли", "Лонгвей", "Тао", "Хи", "Ши"};
            Team chinaTeam = new Team("Китай", chinaPlayers);
            string[] kazakhstanPlayers = {"Айгуль", "Чулпан", "Азамат", "Диас", "Камиль", "Ислам",
                "Амир", "Рамазан", "Шамиль", "Нурислам", "Мурат", "Казбек", "Тамерлан", "Хаким", "Расул"};
            Team kazakhstanTeam = new Team("Казахстан", kazakhstanPlayers);

            BigRacesShow bigRacesShow = new BigRacesShow();
            bigRacesShow.addTeam(russianTeam, organizerName);
            bigRacesShow.addTeam(franceTeam, organizerName);
            bigRacesShow.addTeam(chinaTeam, organizerName);
            bigRacesShow.addTeam(kazakhstanTeam, organizerName);

            Beach beach = new Beach();
            Mousetrap mousetrap = new Mousetrap();
            Sea sea = new Sea();
            Fishing fishing = new Fishing();
            Postman postman = new Postman();
            Slide slide = new Slide();

            bigRacesShow.addGame(beach, organizerName);
            bigRacesShow.addGame(sea, organizerName);
            bigRacesShow.addGame(mousetrap, organizerName);
            bigRacesShow.addGame(fishing, organizerName);
            bigRacesShow.addGame(postman, organizerName);
            bigRacesShow.addGame(slide, organizerName);

            bigRacesShow.StartShow(beach);
            bigRacesShow.StartShow(sea);
            bigRacesShow.StartShow(mousetrap);
            bigRacesShow.StartShow(fishing);
            bigRacesShow.StartShow(postman);
            bigRacesShow.StartShow(slide);
            
            Console.WriteLine("\nНовая игра:");

            Sauna sauna = new Sauna();
            bigRacesShow.addGame(sauna, organizerName);
            bigRacesShow.StartShow(sauna);

            Console.ReadKey();
        }
    }
}
