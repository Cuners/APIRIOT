using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIRIOT.ViewModels
{
    public class ViewModelProfile
    {
        public string SummonerName { get; set; }
        public string Icon { get; set; }
        public long Level { get; set; }
        public string Tier { get; set; }
        public string Rank { get; set; }
        public string Emblem { get; set; }
        public int Wins { get; set; }
        public int Losses { get; set; }
        public ViewModelProfile(string summonerName, int icon, long level, string tier,string rank, int wins, int losses)
        {
            SummonerName = summonerName;
            Icon = "http://opgg-static.akamaized.net/images/profile_icons/profileIcon" + icon + ".jpg";
            Level = level;
            Tier = tier;
            Rank = rank;
            Emblem = "C:/Users/Марат/source/repos/APIRIOT/APIRIOT/Assets/emblems/Season_2022_-_" + tier + ".png";
            Wins = wins;    
            Losses = losses;
        }
    }
}
