using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class SaleManager : ISaleService
    {
        public void CampaignSales(Gamer gamer, Game game, Campaign campaign)
        {
            Console.WriteLine(gamer.FirstName + game.GameName + campaign.CampaingnName + "aldı");
        }

        public void Sales(Gamer gamer, Game game)
        {
            Console.WriteLine(gamer.FirstName + game.GameName + "aldı");
        }
    }
}
