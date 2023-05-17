using System;
using System.Collections.Generic;
using day9.Foot_Ball_Team_App.Models;
using day9.Foot_Ball_Team_App.Services;

namespace day9.Foot_Ball_Team_App.Fuctionality
{
    internal interface IPlayerServices
    { // interfaces.......menu
         void AddPlayer();
         void RemovePlayer();
         void ReadPlayer();
        void SearchPlayer();
        void updatePlayer();
        int GetPlayerCount();
    }
}
