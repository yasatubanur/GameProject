using GameProject.Concrete;
using System
    using GameProject.Entities;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            NewStateUserValidationManager newStateUserValidationManager = new NewStateUserValidationManager();
            GamerManager gamerManager = new GameManager(newStateUserValidationManager);
            Gamer gamer = new Gamer { NationalityId = "111111", FirstName = "Tuba", LastName = "Yaşa", DateOfBirth = 1998 };

            gamerManager.Add(gamer);

            GameManager gameManager = new GameManager(new CampaignManager());
            Game game = new Game { GamePrice = 200 };
            gameManager.GetGameSale(gamerManager, gamer, game);
        }

        
    }
}
