using APIRIOT.API;
using APIRIOT.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIRIOT.Controller
{
    public class ControllerMain
    {
        /* public bool GetSummoner(string region,string name)
         {
             Summoner_V4 summoner_V4 = new Summoner_V4(region);
             var summonner=summoner_V4.GetSummonerByName(name);

             return summonner != null;
         } */
        public bool GetSummoner(string summonerName)
        {
            Summoner_V4 summoner_V4 = new Summoner_V4(Constants.Region);
            var summonner = summoner_V4.GetSummonerByName(summonerName);    
            Constants.summoner=summonner;
            return summonner != null;
        }
    }
}
