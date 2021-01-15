using System;
using FPLForecaster.Models;
using System.Collections.Generic;
using System.Net;   
using Newtonsoft.Json;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using FPLForecaster.Models.Manager;
using System.Linq;

namespace FPLForecaster.Clients
{
    public class TeamClient
    {
        public async Task<ICollection<Team>> GetTeamsGeneralData()
        {
            //gets general data for teams from current season 
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            var json = await FPLClient.HttpClient.GetStringAsync("bootstrap-static/");
            var jsonTeams = JObject.Parse(json)["teams"].ToString();
            return JsonConvert.DeserializeObject<ICollection<Team>>(jsonTeams);
        }

        public void UpdateTeamMatchData()
        {
            if (DataService.Data.Fixtures != null && DataService.Data.Fixtures.Count > 0)
            {
                foreach (Team team in DataService.Data.Teams)
                {
                    foreach (Fixture fix in DataService.Data.Fixtures.Where(x => x?.finished == true && 
                                (x?.team_a == team.id || x?.team_h == team.id)).ToList())
                    {
                        bool teamIsHome = team.id == fix?.team_h;
                        if (teamIsHome)
                        {
                            if (fix.team_h_score > fix.team_a_score) 
                            {
                                team.points += 3;
                                team.win += 1;
                            }
                            else if (fix.team_h_score == fix.team_a_score)
                            {
                                team.points += 1;  
                                team.draw += 1;
                            }
                            else team.loss += 1; 
                            team.goals_for += fix?.team_h_score.Value ?? 0;  
                            team.goals_against += fix?.team_a_score.Value ?? 0;     
                        }
                        else
                        {
                            if (fix.team_h_score < fix.team_a_score) 
                            {
                                team.points += 3;
                                team.win += 1;
                            }
                            else if (fix.team_h_score == fix.team_a_score)
                            {
                                team.points += 1;  
                                team.draw += 1;
                            }
                            else team.loss += 1;
                            team.goals_for += fix?.team_a_score.Value ?? 0;  
                            team.goals_against += fix?.team_h_score.Value ?? 0; 
                        }
                        team.played += 1;
                    }
                }
            }
        }
    }
}