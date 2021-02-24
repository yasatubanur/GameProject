using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class CampaignManager: ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignId + campaign.CampaingnName + campaign.DiscountRate + "eklendi");
        }

        public void Add(Campaign campaign)
        {
            throw new NotImplementedException();
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignId + campaign.CampaingnName + campaign.DiscountRate + "güncellendi");
        }

        

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignId + campaign.CampaingnName + campaign.DiscountRate + "silindi");
        }

       
    }
}
