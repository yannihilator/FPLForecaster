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
        public async Task<List<Team>> GetTeamsGeneralData()
        {
            //gets general data for teams from current season 
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            var json = await FPLClient.HttpClient.GetStringAsync("bootstrap-static/");
            var jsonTeams = JObject.Parse(json)["teams"].ToString();
            return JsonConvert.DeserializeObject<List<Team>>(jsonTeams);
        }

        /// <summary>
        /// Updates team data, as some parameters are left unfilled by the API.
        /// </summary>
        public void UpdateTeamData()
        {
            //updates team records and points if fixtures have been populated
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

                //rearranges team list by teams' table position
                DataService.Data.Teams = DataService.Data.Teams.OrderByDescending(x => x?.points)
                    .ThenByDescending(x => x.goal_differential).ThenByDescending(x => x.goals_for).ToList();
                
                //updates table position
                for (int i = 0; i < DataService.Data.Teams.Count; i++)
                {
                    Team team = DataService.Data.Teams.ElementAt(i);
                    team.position = i + 1;
                }
            }
        }
    }
}