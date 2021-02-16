using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class CampaignManager : ICampaignServer
    {
        public void CampaignDelete()
        {
            Console.WriteLine("Yeni kampanya girildi.");
        }

        public void CampaignUpdate()
        {
            Console.WriteLine("Kampanya güncellendi.");
        }

        public void NewCampaignEntry()
        {
            Console.WriteLine("Kampanya silindi.");
        }
    }
}
