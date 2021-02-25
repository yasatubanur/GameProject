using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    interface ISaleService
    {
        void Sales(Gamer gamer, Game game);
        void CampaignSales(Gamer gamer, Game game, Campaign gampaign);
    }
}
