using System;
using System.Collections.Generic;

namespace SportRanker.Feeds.SportRadar.MLB.Definitions
{

    public class FeedSchedule
    {
        public League league { get; set; }
        public string _comment { get; set; }
    }

    public class League
    {
        public string alias { get; set; }
        public string name { get; set; }
        public string id { get; set; }
        public string date { get; set; }
        public ICollection<Game> games { get; set; }
    }

    public class Game
    {
        public Game1 game { get; set; }
    }

    public class Game1
    {
        public string id { get; set; }
        public string status { get; set; }
        public string coverage { get; set; }
        public int game_number { get; set; }
        public string day_night { get; set; }
        public DateTime scheduled { get; set; }
        public string home_team { get; set; }
        public string away_team { get; set; }
        public int attendance { get; set; }
        public string duration { get; set; }
        public Venue venue { get; set; }
        public Broadcast broadcast { get; set; }
        public Final final { get; set; }
        public Home home { get; set; }
        public Away away { get; set; }
        public Pitching4 pitching { get; set; }
        public ICollection<Official> officials { get; set; }
        public ICollection<Rescheduled> rescheduled { get; set; }
    }

    public class Venue
    {
        public string name { get; set; }
        public string market { get; set; }
        public int capacity { get; set; }
        public string surface { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zip { get; set; }
        public string country { get; set; }
        public string id { get; set; }
    }

    public class Broadcast
    {
        public string network { get; set; }
    }

    public class Final
    {
        public int inning { get; set; }
        public string inning_half { get; set; }
    }

    public class Home
    {
        public string name { get; set; }
        public string market { get; set; }
        public string abbr { get; set; }
        public string id { get; set; }
        public int runs { get; set; }
        public int hits { get; set; }
        public int errors { get; set; }
        public int win { get; set; }
        public int loss { get; set; }
        public Probable_Pitcher probable_pitcher { get; set; }
        public Starting_Pitcher starting_pitcher { get; set; }
        public ICollection<Roster> roster { get; set; }
        public ICollection<Lineup> lineup { get; set; }
        public ICollection<Scoring> scoring { get; set; }
        public Statistics statistics { get; set; }
        public ICollection<Player> players { get; set; }
    }

    public class Probable_Pitcher
    {
        public string preferred_name { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string jersey_number { get; set; }
        public string id { get; set; }
        public int win { get; set; }
        public int loss { get; set; }
        public string era { get; set; }
    }

    public class Starting_Pitcher
    {
        public string preferred_name { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string jersey_number { get; set; }
        public string id { get; set; }
        public int win { get; set; }
        public int loss { get; set; }
        public string era { get; set; }
    }

    public class Statistics
    {
        public Hitting hitting { get; set; }
        public Pitching pitching { get; set; }
        public Fielding fielding { get; set; }
    }

    public class Hitting
    {
        public Overall overall { get; set; }
    }

    public class Overall
    {
        public int ab { get; set; }
        public int lob { get; set; }
        public int rbi { get; set; }
        public string abhr { get; set; }
        public string abk { get; set; }
        public int bip { get; set; }
        public string babip { get; set; }
        public string bbk { get; set; }
        public string bbpa { get; set; }
        public string iso { get; set; }
        public string obp { get; set; }
        public string ops { get; set; }
        public string seca { get; set; }
        public string slg { get; set; }
        public int xbh { get; set; }
        public int pitch_count { get; set; }
        public int lob_risp_2out { get; set; }
        public int team_lob { get; set; }
        public int ab_risp { get; set; }
        public int hit_risp { get; set; }
        public int rbi_2out { get; set; }
        public int linedrive { get; set; }
        public int groundball { get; set; }
        public int popup { get; set; }
        public int flyball { get; set; }
        public int ap { get; set; }
        public string avg { get; set; }
        public string gofo { get; set; }
        public Onbase onbase { get; set; }
        public Runs runs { get; set; }
        public Outcome outcome { get; set; }
        public Outs outs { get; set; }
        public Steal steal { get; set; }
    }

    public class Onbase
    {
        public int s { get; set; }
        public int d { get; set; }
        public int t { get; set; }
        public int hr { get; set; }
        public int tb { get; set; }
        public int bb { get; set; }
        public int ibb { get; set; }
        public int hbp { get; set; }
        public int fc { get; set; }
        public int roe { get; set; }
        public int h { get; set; }
        public int cycle { get; set; }
    }

    public class Runs
    {
        public int total { get; set; }
    }

    public class Outcome
    {
        public int klook { get; set; }
        public int kswing { get; set; }
        public int ktotal { get; set; }
        public int ball { get; set; }
        public int iball { get; set; }
        public int dirtball { get; set; }
        public int foul { get; set; }
    }

    public class Outs
    {
        public int po { get; set; }
        public int fo { get; set; }
        public int fidp { get; set; }
        public int lo { get; set; }
        public int lidp { get; set; }
        public int go { get; set; }
        public int gidp { get; set; }
        public int klook { get; set; }
        public int kswing { get; set; }
        public int ktotal { get; set; }
        public int sacfly { get; set; }
        public int sachit { get; set; }
    }

    public class Steal
    {
        public int caught { get; set; }
        public int stolen { get; set; }
        public string pct { get; set; }
        public int pickoff { get; set; }
    }

    public class Pitching
    {
        public Overall1 overall { get; set; }
        public Starters starters { get; set; }
        public Bullpen bullpen { get; set; }
    }

    public class Overall1
    {
        public string oba { get; set; }
        public int lob { get; set; }
        public string era { get; set; }
        public string k9 { get; set; }
        public string whip { get; set; }
        public string kbb { get; set; }
        public int pitch_count { get; set; }
        public int wp { get; set; }
        public int bk { get; set; }
        public int ip_1 { get; set; }
        public string ip_2 { get; set; }
        public int bf { get; set; }
        public string gofo { get; set; }
        public Onbase1 onbase { get; set; }
        public Runs1 runs { get; set; }
        public Outcome1 outcome { get; set; }
        public Outs1 outs { get; set; }
        public Steal1 steal { get; set; }
        public Games games { get; set; }
    }

    public class Onbase1
    {
        public int s { get; set; }
        public int d { get; set; }
        public int t { get; set; }
        public int hr { get; set; }
        public int tb { get; set; }
        public int bb { get; set; }
        public int ibb { get; set; }
        public int hbp { get; set; }
        public int fc { get; set; }
        public int roe { get; set; }
        public int h { get; set; }
    }

    public class Runs1
    {
        public int total { get; set; }
        public int unearned { get; set; }
        public int earned { get; set; }
    }

    public class Outcome1
    {
        public int klook { get; set; }
        public int kswing { get; set; }
        public int ktotal { get; set; }
        public int ball { get; set; }
        public int iball { get; set; }
        public int dirtball { get; set; }
        public int foul { get; set; }
    }

    public class Outs1
    {
        public int po { get; set; }
        public int fo { get; set; }
        public int fidp { get; set; }
        public int lo { get; set; }
        public int lidp { get; set; }
        public int go { get; set; }
        public int gidp { get; set; }
        public int klook { get; set; }
        public int kswing { get; set; }
        public int ktotal { get; set; }
        public int sacfly { get; set; }
        public int sachit { get; set; }
    }

    public class Steal1
    {
        public int caught { get; set; }
        public int stolen { get; set; }
        public int pickoff { get; set; }
    }

    public class Games
    {
        public int svo { get; set; }
        public int qstart { get; set; }
        public int shutout { get; set; }
        public int complete { get; set; }
        public int win { get; set; }
        public int loss { get; set; }
        public int save { get; set; }
        public int hold { get; set; }
        public int blown_save { get; set; }
    }

    public class Starters
    {
        public string oba { get; set; }
        public int lob { get; set; }
        public string era { get; set; }
        public string k9 { get; set; }
        public string whip { get; set; }
        public string kbb { get; set; }
        public int pitch_count { get; set; }
        public int wp { get; set; }
        public int bk { get; set; }
        public int ip_1 { get; set; }
        public string ip_2 { get; set; }
        public int bf { get; set; }
        public string gofo { get; set; }
        public Onbase2 onbase { get; set; }
        public Runs2 runs { get; set; }
        public Outcome2 outcome { get; set; }
        public Outs2 outs { get; set; }
        public Steal2 steal { get; set; }
        public Games1 games { get; set; }
    }

    public class Onbase2
    {
        public int s { get; set; }
        public int d { get; set; }
        public int t { get; set; }
        public int hr { get; set; }
        public int tb { get; set; }
        public int bb { get; set; }
        public int ibb { get; set; }
        public int hbp { get; set; }
        public int fc { get; set; }
        public int roe { get; set; }
        public int h { get; set; }
    }

    public class Runs2
    {
        public int total { get; set; }
        public int unearned { get; set; }
        public int earned { get; set; }
    }

    public class Outcome2
    {
        public int klook { get; set; }
        public int kswing { get; set; }
        public int ktotal { get; set; }
        public int ball { get; set; }
        public int iball { get; set; }
        public int dirtball { get; set; }
        public int foul { get; set; }
    }

    public class Outs2
    {
        public int po { get; set; }
        public int fo { get; set; }
        public int fidp { get; set; }
        public int lo { get; set; }
        public int lidp { get; set; }
        public int go { get; set; }
        public int gidp { get; set; }
        public int klook { get; set; }
        public int kswing { get; set; }
        public int ktotal { get; set; }
        public int sacfly { get; set; }
        public int sachit { get; set; }
    }

    public class Steal2
    {
        public int caught { get; set; }
        public int stolen { get; set; }
        public int pickoff { get; set; }
    }

    public class Games1
    {
        public int svo { get; set; }
        public int qstart { get; set; }
        public int shutout { get; set; }
        public int complete { get; set; }
        public int win { get; set; }
        public int loss { get; set; }
        public int save { get; set; }
        public int hold { get; set; }
        public int blown_save { get; set; }
    }

    public class Bullpen
    {
        public string oba { get; set; }
        public int lob { get; set; }
        public string era { get; set; }
        public string k9 { get; set; }
        public string whip { get; set; }
        public string kbb { get; set; }
        public int pitch_count { get; set; }
        public int wp { get; set; }
        public int bk { get; set; }
        public int ip_1 { get; set; }
        public string ip_2 { get; set; }
        public int bf { get; set; }
        public string gofo { get; set; }
        public Onbase3 onbase { get; set; }
        public Runs3 runs { get; set; }
        public Outcome3 outcome { get; set; }
        public Outs3 outs { get; set; }
        public Steal3 steal { get; set; }
        public Games2 games { get; set; }
    }

    public class Onbase3
    {
        public int s { get; set; }
        public int d { get; set; }
        public int t { get; set; }
        public int hr { get; set; }
        public int tb { get; set; }
        public int bb { get; set; }
        public int ibb { get; set; }
        public int hbp { get; set; }
        public int fc { get; set; }
        public int roe { get; set; }
        public int h { get; set; }
    }

    public class Runs3
    {
        public int total { get; set; }
        public int unearned { get; set; }
        public int earned { get; set; }
    }

    public class Outcome3
    {
        public int klook { get; set; }
        public int kswing { get; set; }
        public int ktotal { get; set; }
        public int ball { get; set; }
        public int iball { get; set; }
        public int dirtball { get; set; }
        public int foul { get; set; }
    }

    public class Outs3
    {
        public int po { get; set; }
        public int fo { get; set; }
        public int fidp { get; set; }
        public int lo { get; set; }
        public int lidp { get; set; }
        public int go { get; set; }
        public int gidp { get; set; }
        public int klook { get; set; }
        public int kswing { get; set; }
        public int ktotal { get; set; }
        public int sacfly { get; set; }
        public int sachit { get; set; }
    }

    public class Steal3
    {
        public int caught { get; set; }
        public int stolen { get; set; }
        public int pickoff { get; set; }
    }

    public class Games2
    {
        public int svo { get; set; }
        public int qstart { get; set; }
        public int shutout { get; set; }
        public int complete { get; set; }
        public int win { get; set; }
        public int loss { get; set; }
        public int save { get; set; }
        public int hold { get; set; }
        public int blown_save { get; set; }
    }

    public class Fielding
    {
        public Overall2 overall { get; set; }
    }

    public class Overall2
    {
        public int po { get; set; }
        public int a { get; set; }
        public int dp { get; set; }
        public int tp { get; set; }
        public int error { get; set; }
        public int tc { get; set; }
        public string fpct { get; set; }
        public int c_wp { get; set; }
        public int pb { get; set; }
        public Errors errors { get; set; }
    }

    public class Errors
    {
        public int throwing { get; set; }
        public int fielding { get; set; }
        public int interference { get; set; }
        public int total { get; set; }
    }

    public class Roster
    {
        public string preferred_name { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string jersey_number { get; set; }
        public string id { get; set; }
        public string status { get; set; }
        public string position { get; set; }
        public string primary_position { get; set; }
    }

    public class Lineup
    {
        public string id { get; set; }
        public int inning { get; set; }
        public int order { get; set; }
        public int position { get; set; }
        public int sequence { get; set; }
        public string inning_half { get; set; }
    }

    public class Scoring
    {
        public int number { get; set; }
        public int sequence { get; set; }
        public object runs { get; set; }
        public string type { get; set; }
    }

    public class Player
    {
        public string preferred_name { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string jersey_number { get; set; }
        public string id { get; set; }
        public string status { get; set; }
        public string position { get; set; }
        public string primary_position { get; set; }
        public Statistics1 statistics { get; set; }
    }

    public class Statistics1
    {
        public Hitting1 hitting { get; set; }
        public Pitching1 pitching { get; set; }
        public Fielding1 fielding { get; set; }
    }

    public class Hitting1
    {
        public Overall3 overall { get; set; }
    }

    public class Overall3
    {
        public int ab { get; set; }
        public int lob { get; set; }
        public int rbi { get; set; }
        public string abhr { get; set; }
        public string abk { get; set; }
        public int bip { get; set; }
        public string babip { get; set; }
        public string bbk { get; set; }
        public string bbpa { get; set; }
        public string iso { get; set; }
        public string obp { get; set; }
        public string ops { get; set; }
        public string seca { get; set; }
        public string slg { get; set; }
        public int xbh { get; set; }
        public int pitch_count { get; set; }
        public int lob_risp_2out { get; set; }
        public int team_lob { get; set; }
        public int ab_risp { get; set; }
        public int hit_risp { get; set; }
        public int rbi_2out { get; set; }
        public int linedrive { get; set; }
        public int groundball { get; set; }
        public int popup { get; set; }
        public int flyball { get; set; }
        public int ap { get; set; }
        public string avg { get; set; }
        public string gofo { get; set; }
        public Onbase4 onbase { get; set; }
        public Runs4 runs { get; set; }
        public Outcome4 outcome { get; set; }
        public Outs4 outs { get; set; }
        public Steal4 steal { get; set; }
        public Games3 games { get; set; }
    }

    public class Onbase4
    {
        public int s { get; set; }
        public int d { get; set; }
        public int t { get; set; }
        public int hr { get; set; }
        public int tb { get; set; }
        public int bb { get; set; }
        public int ibb { get; set; }
        public int hbp { get; set; }
        public int fc { get; set; }
        public int roe { get; set; }
        public int h { get; set; }
        public int cycle { get; set; }
    }

    public class Runs4
    {
        public int total { get; set; }
    }

    public class Outcome4
    {
        public int klook { get; set; }
        public int kswing { get; set; }
        public int ktotal { get; set; }
        public int ball { get; set; }
        public int iball { get; set; }
        public int dirtball { get; set; }
        public int foul { get; set; }
    }

    public class Outs4
    {
        public int po { get; set; }
        public int fo { get; set; }
        public int fidp { get; set; }
        public int lo { get; set; }
        public int lidp { get; set; }
        public int go { get; set; }
        public int gidp { get; set; }
        public int klook { get; set; }
        public int kswing { get; set; }
        public int ktotal { get; set; }
        public int sacfly { get; set; }
        public int sachit { get; set; }
    }

    public class Steal4
    {
        public int caught { get; set; }
        public int stolen { get; set; }
        public string pct { get; set; }
        public int pickoff { get; set; }
    }

    public class Games3
    {
        public int start { get; set; }
        public int play { get; set; }
        public int finish { get; set; }
        public int complete { get; set; }
    }

    public class Pitching1
    {
        public Overall4 overall { get; set; }
        public Bullpen1 bullpen { get; set; }
        public Starters1 starters { get; set; }
    }

    public class Overall4
    {
        public string oba { get; set; }
        public int lob { get; set; }
        public string era { get; set; }
        public string k9 { get; set; }
        public string whip { get; set; }
        public string kbb { get; set; }
        public int pitch_count { get; set; }
        public int wp { get; set; }
        public int bk { get; set; }
        public int ip_1 { get; set; }
        public string ip_2 { get; set; }
        public int bf { get; set; }
        public string gofo { get; set; }
        public Onbase5 onbase { get; set; }
        public Runs5 runs { get; set; }
        public Outcome5 outcome { get; set; }
        public Outs5 outs { get; set; }
        public Steal5 steal { get; set; }
        public Games4 games { get; set; }
    }

    public class Onbase5
    {
        public int s { get; set; }
        public int d { get; set; }
        public int t { get; set; }
        public int hr { get; set; }
        public int tb { get; set; }
        public int bb { get; set; }
        public int ibb { get; set; }
        public int hbp { get; set; }
        public int fc { get; set; }
        public int roe { get; set; }
        public int h { get; set; }
    }

    public class Runs5
    {
        public int total { get; set; }
        public int unearned { get; set; }
        public int earned { get; set; }
    }

    public class Outcome5
    {
        public int klook { get; set; }
        public int kswing { get; set; }
        public int ktotal { get; set; }
        public int ball { get; set; }
        public int iball { get; set; }
        public int dirtball { get; set; }
        public int foul { get; set; }
    }

    public class Outs5
    {
        public int po { get; set; }
        public int fo { get; set; }
        public int fidp { get; set; }
        public int lo { get; set; }
        public int lidp { get; set; }
        public int go { get; set; }
        public int gidp { get; set; }
        public int klook { get; set; }
        public int kswing { get; set; }
        public int ktotal { get; set; }
        public int sacfly { get; set; }
        public int sachit { get; set; }
    }

    public class Steal5
    {
        public int caught { get; set; }
        public int stolen { get; set; }
        public int pickoff { get; set; }
    }

    public class Games4
    {
        public int start { get; set; }
        public int play { get; set; }
        public int finish { get; set; }
        public int svo { get; set; }
        public int qstart { get; set; }
        public int shutout { get; set; }
        public int complete { get; set; }
        public int win { get; set; }
        public int loss { get; set; }
        public int save { get; set; }
        public int hold { get; set; }
        public int blown_save { get; set; }
        public int team_win { get; set; }
        public int team_loss { get; set; }
    }

    public class Bullpen1
    {
        public string oba { get; set; }
        public int lob { get; set; }
        public string era { get; set; }
        public string k9 { get; set; }
        public string whip { get; set; }
        public string kbb { get; set; }
        public int pitch_count { get; set; }
        public int wp { get; set; }
        public int bk { get; set; }
        public int ip_1 { get; set; }
        public string ip_2 { get; set; }
        public int bf { get; set; }
        public string gofo { get; set; }
        public Onbase6 onbase { get; set; }
        public Runs6 runs { get; set; }
        public Outcome6 outcome { get; set; }
        public Outs6 outs { get; set; }
        public Steal6 steal { get; set; }
        public Games5 games { get; set; }
    }

    public class Onbase6
    {
        public int s { get; set; }
        public int d { get; set; }
        public int t { get; set; }
        public int hr { get; set; }
        public int tb { get; set; }
        public int bb { get; set; }
        public int ibb { get; set; }
        public int hbp { get; set; }
        public int fc { get; set; }
        public int roe { get; set; }
        public int h { get; set; }
    }

    public class Runs6
    {
        public int total { get; set; }
        public int unearned { get; set; }
        public int earned { get; set; }
    }

    public class Outcome6
    {
        public int klook { get; set; }
        public int kswing { get; set; }
        public int ktotal { get; set; }
        public int ball { get; set; }
        public int iball { get; set; }
        public int dirtball { get; set; }
        public int foul { get; set; }
    }

    public class Outs6
    {
        public int po { get; set; }
        public int fo { get; set; }
        public int fidp { get; set; }
        public int lo { get; set; }
        public int lidp { get; set; }
        public int go { get; set; }
        public int gidp { get; set; }
        public int klook { get; set; }
        public int kswing { get; set; }
        public int ktotal { get; set; }
        public int sacfly { get; set; }
        public int sachit { get; set; }
    }

    public class Steal6
    {
        public int caught { get; set; }
        public int stolen { get; set; }
        public int pickoff { get; set; }
    }

    public class Games5
    {
        public int start { get; set; }
        public int play { get; set; }
        public int finish { get; set; }
        public int svo { get; set; }
        public int qstart { get; set; }
        public int shutout { get; set; }
        public int complete { get; set; }
        public int win { get; set; }
        public int loss { get; set; }
        public int save { get; set; }
        public int hold { get; set; }
        public int blown_save { get; set; }
        public int team_win { get; set; }
        public int team_loss { get; set; }
    }

    public class Starters1
    {
        public string oba { get; set; }
        public int lob { get; set; }
        public string era { get; set; }
        public string k9 { get; set; }
        public string whip { get; set; }
        public string kbb { get; set; }
        public int pitch_count { get; set; }
        public int wp { get; set; }
        public int bk { get; set; }
        public int ip_1 { get; set; }
        public string ip_2 { get; set; }
        public int bf { get; set; }
        public string gofo { get; set; }
        public Onbase7 onbase { get; set; }
        public Runs7 runs { get; set; }
        public Outcome7 outcome { get; set; }
        public Outs7 outs { get; set; }
        public Steal7 steal { get; set; }
        public Games6 games { get; set; }
    }

    public class Onbase7
    {
        public int s { get; set; }
        public int d { get; set; }
        public int t { get; set; }
        public int hr { get; set; }
        public int tb { get; set; }
        public int bb { get; set; }
        public int ibb { get; set; }
        public int hbp { get; set; }
        public int fc { get; set; }
        public int roe { get; set; }
        public int h { get; set; }
    }

    public class Runs7
    {
        public int total { get; set; }
        public int unearned { get; set; }
        public int earned { get; set; }
    }

    public class Outcome7
    {
        public int klook { get; set; }
        public int kswing { get; set; }
        public int ktotal { get; set; }
        public int ball { get; set; }
        public int iball { get; set; }
        public int dirtball { get; set; }
        public int foul { get; set; }
    }

    public class Outs7
    {
        public int po { get; set; }
        public int fo { get; set; }
        public int fidp { get; set; }
        public int lo { get; set; }
        public int lidp { get; set; }
        public int go { get; set; }
        public int gidp { get; set; }
        public int klook { get; set; }
        public int kswing { get; set; }
        public int ktotal { get; set; }
        public int sacfly { get; set; }
        public int sachit { get; set; }
    }

    public class Steal7
    {
        public int caught { get; set; }
        public int stolen { get; set; }
        public int pickoff { get; set; }
    }

    public class Games6
    {
        public int start { get; set; }
        public int play { get; set; }
        public int finish { get; set; }
        public int svo { get; set; }
        public int qstart { get; set; }
        public int shutout { get; set; }
        public int complete { get; set; }
        public int win { get; set; }
        public int loss { get; set; }
        public int save { get; set; }
        public int hold { get; set; }
        public int blown_save { get; set; }
        public int team_win { get; set; }
        public int team_loss { get; set; }
    }

    public class Fielding1
    {
        public Overall5 overall { get; set; }
    }

    public class Overall5
    {
        public int po { get; set; }
        public int a { get; set; }
        public int dp { get; set; }
        public int tp { get; set; }
        public int error { get; set; }
        public int tc { get; set; }
        public string fpct { get; set; }
        public int c_wp { get; set; }
        public int pb { get; set; }
        public string rf { get; set; }
        public Errors1 errors { get; set; }
        public Games7 games { get; set; }
    }

    public class Errors1
    {
        public int throwing { get; set; }
        public int fielding { get; set; }
        public int interference { get; set; }
        public int total { get; set; }
    }

    public class Games7
    {
        public int start { get; set; }
        public int play { get; set; }
        public int finish { get; set; }
        public int complete { get; set; }
    }

    public class Away
    {
        public string name { get; set; }
        public string market { get; set; }
        public string abbr { get; set; }
        public string id { get; set; }
        public int runs { get; set; }
        public int hits { get; set; }
        public int errors { get; set; }
        public int win { get; set; }
        public int loss { get; set; }
        public Probable_Pitcher1 probable_pitcher { get; set; }
        public Starting_Pitcher1 starting_pitcher { get; set; }
        public Roster1[] roster { get; set; }
        public Lineup1[] lineup { get; set; }
        public Scoring1[] scoring { get; set; }
        public Statistics2 statistics { get; set; }
        public Player1[] players { get; set; }
    }

    public class Probable_Pitcher1
    {
        public string preferred_name { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string jersey_number { get; set; }
        public string id { get; set; }
        public int win { get; set; }
        public int loss { get; set; }
        public string era { get; set; }
    }

    public class Starting_Pitcher1
    {
        public string preferred_name { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string jersey_number { get; set; }
        public string id { get; set; }
        public int win { get; set; }
        public int loss { get; set; }
        public string era { get; set; }
    }

    public class Statistics2
    {
        public Hitting2 hitting { get; set; }
        public Pitching2 pitching { get; set; }
        public Fielding2 fielding { get; set; }
    }

    public class Hitting2
    {
        public Overall6 overall { get; set; }
    }

    public class Overall6
    {
        public int ab { get; set; }
        public int lob { get; set; }
        public int rbi { get; set; }
        public string abhr { get; set; }
        public string abk { get; set; }
        public int bip { get; set; }
        public string babip { get; set; }
        public string bbk { get; set; }
        public string bbpa { get; set; }
        public string iso { get; set; }
        public string obp { get; set; }
        public string ops { get; set; }
        public string seca { get; set; }
        public string slg { get; set; }
        public int xbh { get; set; }
        public int pitch_count { get; set; }
        public int lob_risp_2out { get; set; }
        public int team_lob { get; set; }
        public int ab_risp { get; set; }
        public int hit_risp { get; set; }
        public int rbi_2out { get; set; }
        public int linedrive { get; set; }
        public int groundball { get; set; }
        public int popup { get; set; }
        public int flyball { get; set; }
        public int ap { get; set; }
        public string avg { get; set; }
        public string gofo { get; set; }
        public Onbase8 onbase { get; set; }
        public Runs8 runs { get; set; }
        public Outcome8 outcome { get; set; }
        public Outs8 outs { get; set; }
        public Steal8 steal { get; set; }
    }

    public class Onbase8
    {
        public int s { get; set; }
        public int d { get; set; }
        public int t { get; set; }
        public int hr { get; set; }
        public int tb { get; set; }
        public int bb { get; set; }
        public int ibb { get; set; }
        public int hbp { get; set; }
        public int fc { get; set; }
        public int roe { get; set; }
        public int h { get; set; }
        public int cycle { get; set; }
    }

    public class Runs8
    {
        public int total { get; set; }
    }

    public class Outcome8
    {
        public int klook { get; set; }
        public int kswing { get; set; }
        public int ktotal { get; set; }
        public int ball { get; set; }
        public int iball { get; set; }
        public int dirtball { get; set; }
        public int foul { get; set; }
    }

    public class Outs8
    {
        public int po { get; set; }
        public int fo { get; set; }
        public int fidp { get; set; }
        public int lo { get; set; }
        public int lidp { get; set; }
        public int go { get; set; }
        public int gidp { get; set; }
        public int klook { get; set; }
        public int kswing { get; set; }
        public int ktotal { get; set; }
        public int sacfly { get; set; }
        public int sachit { get; set; }
    }

    public class Steal8
    {
        public int caught { get; set; }
        public int stolen { get; set; }
        public string pct { get; set; }
        public int pickoff { get; set; }
    }

    public class Pitching2
    {
        public Overall7 overall { get; set; }
        public Starters2 starters { get; set; }
        public Bullpen2 bullpen { get; set; }
    }

    public class Overall7
    {
        public string oba { get; set; }
        public int lob { get; set; }
        public string era { get; set; }
        public string k9 { get; set; }
        public string whip { get; set; }
        public string kbb { get; set; }
        public int pitch_count { get; set; }
        public int wp { get; set; }
        public int bk { get; set; }
        public int ip_1 { get; set; }
        public string ip_2 { get; set; }
        public int bf { get; set; }
        public string gofo { get; set; }
        public Onbase9 onbase { get; set; }
        public Runs9 runs { get; set; }
        public Outcome9 outcome { get; set; }
        public Outs9 outs { get; set; }
        public Steal9 steal { get; set; }
        public Games8 games { get; set; }
    }

    public class Onbase9
    {
        public int s { get; set; }
        public int d { get; set; }
        public int t { get; set; }
        public int hr { get; set; }
        public int tb { get; set; }
        public int bb { get; set; }
        public int ibb { get; set; }
        public int hbp { get; set; }
        public int fc { get; set; }
        public int roe { get; set; }
        public int h { get; set; }
    }

    public class Runs9
    {
        public int total { get; set; }
        public int unearned { get; set; }
        public int earned { get; set; }
    }

    public class Outcome9
    {
        public int klook { get; set; }
        public int kswing { get; set; }
        public int ktotal { get; set; }
        public int ball { get; set; }
        public int iball { get; set; }
        public int dirtball { get; set; }
        public int foul { get; set; }
    }

    public class Outs9
    {
        public int po { get; set; }
        public int fo { get; set; }
        public int fidp { get; set; }
        public int lo { get; set; }
        public int lidp { get; set; }
        public int go { get; set; }
        public int gidp { get; set; }
        public int klook { get; set; }
        public int kswing { get; set; }
        public int ktotal { get; set; }
        public int sacfly { get; set; }
        public int sachit { get; set; }
    }

    public class Steal9
    {
        public int caught { get; set; }
        public int stolen { get; set; }
        public int pickoff { get; set; }
    }

    public class Games8
    {
        public int svo { get; set; }
        public int qstart { get; set; }
        public int shutout { get; set; }
        public int complete { get; set; }
        public int win { get; set; }
        public int loss { get; set; }
        public int save { get; set; }
        public int hold { get; set; }
        public int blown_save { get; set; }
    }

    public class Starters2
    {
        public string oba { get; set; }
        public int lob { get; set; }
        public string era { get; set; }
        public string k9 { get; set; }
        public string whip { get; set; }
        public string kbb { get; set; }
        public int pitch_count { get; set; }
        public int wp { get; set; }
        public int bk { get; set; }
        public int ip_1 { get; set; }
        public string ip_2 { get; set; }
        public int bf { get; set; }
        public string gofo { get; set; }
        public Onbase10 onbase { get; set; }
        public Runs10 runs { get; set; }
        public Outcome10 outcome { get; set; }
        public Outs10 outs { get; set; }
        public Steal10 steal { get; set; }
        public Games9 games { get; set; }
    }

    public class Onbase10
    {
        public int s { get; set; }
        public int d { get; set; }
        public int t { get; set; }
        public int hr { get; set; }
        public int tb { get; set; }
        public int bb { get; set; }
        public int ibb { get; set; }
        public int hbp { get; set; }
        public int fc { get; set; }
        public int roe { get; set; }
        public int h { get; set; }
    }

    public class Runs10
    {
        public int total { get; set; }
        public int unearned { get; set; }
        public int earned { get; set; }
    }

    public class Outcome10
    {
        public int klook { get; set; }
        public int kswing { get; set; }
        public int ktotal { get; set; }
        public int ball { get; set; }
        public int iball { get; set; }
        public int dirtball { get; set; }
        public int foul { get; set; }
    }

    public class Outs10
    {
        public int po { get; set; }
        public int fo { get; set; }
        public int fidp { get; set; }
        public int lo { get; set; }
        public int lidp { get; set; }
        public int go { get; set; }
        public int gidp { get; set; }
        public int klook { get; set; }
        public int kswing { get; set; }
        public int ktotal { get; set; }
        public int sacfly { get; set; }
        public int sachit { get; set; }
    }

    public class Steal10
    {
        public int caught { get; set; }
        public int stolen { get; set; }
        public int pickoff { get; set; }
    }

    public class Games9
    {
        public int svo { get; set; }
        public int qstart { get; set; }
        public int shutout { get; set; }
        public int complete { get; set; }
        public int win { get; set; }
        public int loss { get; set; }
        public int save { get; set; }
        public int hold { get; set; }
        public int blown_save { get; set; }
    }

    public class Bullpen2
    {
        public string oba { get; set; }
        public int lob { get; set; }
        public string era { get; set; }
        public string k9 { get; set; }
        public string whip { get; set; }
        public string kbb { get; set; }
        public int pitch_count { get; set; }
        public int wp { get; set; }
        public int bk { get; set; }
        public int ip_1 { get; set; }
        public string ip_2 { get; set; }
        public int bf { get; set; }
        public string gofo { get; set; }
        public Onbase11 onbase { get; set; }
        public Runs11 runs { get; set; }
        public Outcome11 outcome { get; set; }
        public Outs11 outs { get; set; }
        public Steal11 steal { get; set; }
        public Games10 games { get; set; }
    }

    public class Onbase11
    {
        public int s { get; set; }
        public int d { get; set; }
        public int t { get; set; }
        public int hr { get; set; }
        public int tb { get; set; }
        public int bb { get; set; }
        public int ibb { get; set; }
        public int hbp { get; set; }
        public int fc { get; set; }
        public int roe { get; set; }
        public int h { get; set; }
    }

    public class Runs11
    {
        public int total { get; set; }
        public int unearned { get; set; }
        public int earned { get; set; }
    }

    public class Outcome11
    {
        public int klook { get; set; }
        public int kswing { get; set; }
        public int ktotal { get; set; }
        public int ball { get; set; }
        public int iball { get; set; }
        public int dirtball { get; set; }
        public int foul { get; set; }
    }

    public class Outs11
    {
        public int po { get; set; }
        public int fo { get; set; }
        public int fidp { get; set; }
        public int lo { get; set; }
        public int lidp { get; set; }
        public int go { get; set; }
        public int gidp { get; set; }
        public int klook { get; set; }
        public int kswing { get; set; }
        public int ktotal { get; set; }
        public int sacfly { get; set; }
        public int sachit { get; set; }
    }

    public class Steal11
    {
        public int caught { get; set; }
        public int stolen { get; set; }
        public int pickoff { get; set; }
    }

    public class Games10
    {
        public int svo { get; set; }
        public int qstart { get; set; }
        public int shutout { get; set; }
        public int complete { get; set; }
        public int win { get; set; }
        public int loss { get; set; }
        public int save { get; set; }
        public int hold { get; set; }
        public int blown_save { get; set; }
    }

    public class Fielding2
    {
        public Overall8 overall { get; set; }
    }

    public class Overall8
    {
        public int po { get; set; }
        public int a { get; set; }
        public int dp { get; set; }
        public int tp { get; set; }
        public int error { get; set; }
        public int tc { get; set; }
        public string fpct { get; set; }
        public int c_wp { get; set; }
        public int pb { get; set; }
        public Errors2 errors { get; set; }
    }

    public class Errors2
    {
        public int throwing { get; set; }
        public int fielding { get; set; }
        public int interference { get; set; }
        public int total { get; set; }
    }

    public class Roster1
    {
        public string preferred_name { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string jersey_number { get; set; }
        public string id { get; set; }
        public string status { get; set; }
        public string position { get; set; }
        public string primary_position { get; set; }
    }

    public class Lineup1
    {
        public string id { get; set; }
        public int inning { get; set; }
        public int order { get; set; }
        public int position { get; set; }
        public int sequence { get; set; }
        public string inning_half { get; set; }
    }

    public class Scoring1
    {
        public int number { get; set; }
        public int sequence { get; set; }
        public int runs { get; set; }
        public string type { get; set; }
    }

    public class Player1
    {
        public string preferred_name { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string jersey_number { get; set; }
        public string id { get; set; }
        public string status { get; set; }
        public string position { get; set; }
        public string primary_position { get; set; }
        public Statistics3 statistics { get; set; }
    }

    public class Statistics3
    {
        public Hitting3 hitting { get; set; }
        public Pitching3 pitching { get; set; }
        public Fielding3 fielding { get; set; }
    }

    public class Hitting3
    {
        public Overall9 overall { get; set; }
    }

    public class Overall9
    {
        public int ab { get; set; }
        public int lob { get; set; }
        public int rbi { get; set; }
        public string abhr { get; set; }
        public string abk { get; set; }
        public int bip { get; set; }
        public string babip { get; set; }
        public string bbk { get; set; }
        public string bbpa { get; set; }
        public string iso { get; set; }
        public string obp { get; set; }
        public string ops { get; set; }
        public string seca { get; set; }
        public string slg { get; set; }
        public int xbh { get; set; }
        public int pitch_count { get; set; }
        public int lob_risp_2out { get; set; }
        public int team_lob { get; set; }
        public int ab_risp { get; set; }
        public int hit_risp { get; set; }
        public int rbi_2out { get; set; }
        public int linedrive { get; set; }
        public int groundball { get; set; }
        public int popup { get; set; }
        public int flyball { get; set; }
        public int ap { get; set; }
        public string avg { get; set; }
        public string gofo { get; set; }
        public Onbase12 onbase { get; set; }
        public Runs12 runs { get; set; }
        public Outcome12 outcome { get; set; }
        public Outs12 outs { get; set; }
        public Steal12 steal { get; set; }
        public Games11 games { get; set; }
    }

    public class Onbase12
    {
        public int s { get; set; }
        public int d { get; set; }
        public int t { get; set; }
        public int hr { get; set; }
        public int tb { get; set; }
        public int bb { get; set; }
        public int ibb { get; set; }
        public int hbp { get; set; }
        public int fc { get; set; }
        public int roe { get; set; }
        public int h { get; set; }
        public int cycle { get; set; }
    }

    public class Runs12
    {
        public int total { get; set; }
    }

    public class Outcome12
    {
        public int klook { get; set; }
        public int kswing { get; set; }
        public int ktotal { get; set; }
        public int ball { get; set; }
        public int iball { get; set; }
        public int dirtball { get; set; }
        public int foul { get; set; }
    }

    public class Outs12
    {
        public int po { get; set; }
        public int fo { get; set; }
        public int fidp { get; set; }
        public int lo { get; set; }
        public int lidp { get; set; }
        public int go { get; set; }
        public int gidp { get; set; }
        public int klook { get; set; }
        public int kswing { get; set; }
        public int ktotal { get; set; }
        public int sacfly { get; set; }
        public int sachit { get; set; }
    }

    public class Steal12
    {
        public int caught { get; set; }
        public int stolen { get; set; }
        public string pct { get; set; }
        public int pickoff { get; set; }
    }

    public class Games11
    {
        public int start { get; set; }
        public int play { get; set; }
        public int finish { get; set; }
        public int complete { get; set; }
    }

    public class Pitching3
    {
        public Overall10 overall { get; set; }
        public Bullpen3 bullpen { get; set; }
        public Starters3 starters { get; set; }
    }

    public class Overall10
    {
        public string oba { get; set; }
        public int lob { get; set; }
        public string era { get; set; }
        public string k9 { get; set; }
        public string whip { get; set; }
        public string kbb { get; set; }
        public int pitch_count { get; set; }
        public int wp { get; set; }
        public int bk { get; set; }
        public int ip_1 { get; set; }
        public string ip_2 { get; set; }
        public int bf { get; set; }
        public string gofo { get; set; }
        public Onbase13 onbase { get; set; }
        public Runs13 runs { get; set; }
        public Outcome13 outcome { get; set; }
        public Outs13 outs { get; set; }
        public Steal13 steal { get; set; }
        public Games12 games { get; set; }
    }

    public class Onbase13
    {
        public int s { get; set; }
        public int d { get; set; }
        public int t { get; set; }
        public int hr { get; set; }
        public int tb { get; set; }
        public int bb { get; set; }
        public int ibb { get; set; }
        public int hbp { get; set; }
        public int fc { get; set; }
        public int roe { get; set; }
        public int h { get; set; }
    }

    public class Runs13
    {
        public int total { get; set; }
        public int unearned { get; set; }
        public int earned { get; set; }
    }

    public class Outcome13
    {
        public int klook { get; set; }
        public int kswing { get; set; }
        public int ktotal { get; set; }
        public int ball { get; set; }
        public int iball { get; set; }
        public int dirtball { get; set; }
        public int foul { get; set; }
    }

    public class Outs13
    {
        public int po { get; set; }
        public int fo { get; set; }
        public int fidp { get; set; }
        public int lo { get; set; }
        public int lidp { get; set; }
        public int go { get; set; }
        public int gidp { get; set; }
        public int klook { get; set; }
        public int kswing { get; set; }
        public int ktotal { get; set; }
        public int sacfly { get; set; }
        public int sachit { get; set; }
    }

    public class Steal13
    {
        public int caught { get; set; }
        public int stolen { get; set; }
        public int pickoff { get; set; }
    }

    public class Games12
    {
        public int start { get; set; }
        public int play { get; set; }
        public int finish { get; set; }
        public int svo { get; set; }
        public int qstart { get; set; }
        public int shutout { get; set; }
        public int complete { get; set; }
        public int win { get; set; }
        public int loss { get; set; }
        public int save { get; set; }
        public int hold { get; set; }
        public int blown_save { get; set; }
        public int team_win { get; set; }
        public int team_loss { get; set; }
    }

    public class Bullpen3
    {
        public string oba { get; set; }
        public int lob { get; set; }
        public string era { get; set; }
        public string k9 { get; set; }
        public string whip { get; set; }
        public string kbb { get; set; }
        public int pitch_count { get; set; }
        public int wp { get; set; }
        public int bk { get; set; }
        public int ip_1 { get; set; }
        public string ip_2 { get; set; }
        public int bf { get; set; }
        public string gofo { get; set; }
        public Onbase14 onbase { get; set; }
        public Runs14 runs { get; set; }
        public Outcome14 outcome { get; set; }
        public Outs14 outs { get; set; }
        public Steal14 steal { get; set; }
        public Games13 games { get; set; }
    }

    public class Onbase14
    {
        public int s { get; set; }
        public int d { get; set; }
        public int t { get; set; }
        public int hr { get; set; }
        public int tb { get; set; }
        public int bb { get; set; }
        public int ibb { get; set; }
        public int hbp { get; set; }
        public int fc { get; set; }
        public int roe { get; set; }
        public int h { get; set; }
    }

    public class Runs14
    {
        public int total { get; set; }
        public int unearned { get; set; }
        public int earned { get; set; }
    }

    public class Outcome14
    {
        public int klook { get; set; }
        public int kswing { get; set; }
        public int ktotal { get; set; }
        public int ball { get; set; }
        public int iball { get; set; }
        public int dirtball { get; set; }
        public int foul { get; set; }
    }

    public class Outs14
    {
        public int po { get; set; }
        public int fo { get; set; }
        public int fidp { get; set; }
        public int lo { get; set; }
        public int lidp { get; set; }
        public int go { get; set; }
        public int gidp { get; set; }
        public int klook { get; set; }
        public int kswing { get; set; }
        public int ktotal { get; set; }
        public int sacfly { get; set; }
        public int sachit { get; set; }
    }

    public class Steal14
    {
        public int caught { get; set; }
        public int stolen { get; set; }
        public int pickoff { get; set; }
    }

    public class Games13
    {
        public int start { get; set; }
        public int play { get; set; }
        public int finish { get; set; }
        public int svo { get; set; }
        public int qstart { get; set; }
        public int shutout { get; set; }
        public int complete { get; set; }
        public int win { get; set; }
        public int loss { get; set; }
        public int save { get; set; }
        public int hold { get; set; }
        public int blown_save { get; set; }
        public int team_win { get; set; }
        public int team_loss { get; set; }
    }

    public class Starters3
    {
        public string oba { get; set; }
        public int lob { get; set; }
        public string era { get; set; }
        public string k9 { get; set; }
        public string whip { get; set; }
        public string kbb { get; set; }
        public int pitch_count { get; set; }
        public int wp { get; set; }
        public int bk { get; set; }
        public int ip_1 { get; set; }
        public string ip_2 { get; set; }
        public int bf { get; set; }
        public string gofo { get; set; }
        public Onbase15 onbase { get; set; }
        public Runs15 runs { get; set; }
        public Outcome15 outcome { get; set; }
        public Outs15 outs { get; set; }
        public Steal15 steal { get; set; }
        public Games14 games { get; set; }
    }

    public class Onbase15
    {
        public int s { get; set; }
        public int d { get; set; }
        public int t { get; set; }
        public int hr { get; set; }
        public int tb { get; set; }
        public int bb { get; set; }
        public int ibb { get; set; }
        public int hbp { get; set; }
        public int fc { get; set; }
        public int roe { get; set; }
        public int h { get; set; }
    }

    public class Runs15
    {
        public int total { get; set; }
        public int unearned { get; set; }
        public int earned { get; set; }
    }

    public class Outcome15
    {
        public int klook { get; set; }
        public int kswing { get; set; }
        public int ktotal { get; set; }
        public int ball { get; set; }
        public int iball { get; set; }
        public int dirtball { get; set; }
        public int foul { get; set; }
    }

    public class Outs15
    {
        public int po { get; set; }
        public int fo { get; set; }
        public int fidp { get; set; }
        public int lo { get; set; }
        public int lidp { get; set; }
        public int go { get; set; }
        public int gidp { get; set; }
        public int klook { get; set; }
        public int kswing { get; set; }
        public int ktotal { get; set; }
        public int sacfly { get; set; }
        public int sachit { get; set; }
    }

    public class Steal15
    {
        public int caught { get; set; }
        public int stolen { get; set; }
        public int pickoff { get; set; }
    }

    public class Games14
    {
        public int start { get; set; }
        public int play { get; set; }
        public int finish { get; set; }
        public int svo { get; set; }
        public int qstart { get; set; }
        public int shutout { get; set; }
        public int complete { get; set; }
        public int win { get; set; }
        public int loss { get; set; }
        public int save { get; set; }
        public int hold { get; set; }
        public int blown_save { get; set; }
        public int team_win { get; set; }
        public int team_loss { get; set; }
    }

    public class Fielding3
    {
        public Overall11 overall { get; set; }
    }

    public class Overall11
    {
        public int po { get; set; }
        public int a { get; set; }
        public int dp { get; set; }
        public int tp { get; set; }
        public int error { get; set; }
        public int tc { get; set; }
        public string fpct { get; set; }
        public int c_wp { get; set; }
        public int pb { get; set; }
        public string rf { get; set; }
        public Errors3 errors { get; set; }
        public Games15 games { get; set; }
    }

    public class Errors3
    {
        public int throwing { get; set; }
        public int fielding { get; set; }
        public int interference { get; set; }
        public int total { get; set; }
    }

    public class Games15
    {
        public int start { get; set; }
        public int play { get; set; }
        public int finish { get; set; }
        public int complete { get; set; }
    }

    public class Pitching4
    {
        public Win win { get; set; }
        public Loss loss { get; set; }
        public Save save { get; set; }
        public Hold[] hold { get; set; }
        public Blown_Save[] blown_save { get; set; }
    }

    public class Win
    {
        public string preferred_name { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string jersey_number { get; set; }
        public string status { get; set; }
        public string position { get; set; }
        public string primary_position { get; set; }
        public string id { get; set; }
        public int win { get; set; }
        public int loss { get; set; }
        public int save { get; set; }
        public int hold { get; set; }
        public int blown_save { get; set; }
    }

    public class Loss
    {
        public string preferred_name { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string jersey_number { get; set; }
        public string status { get; set; }
        public string position { get; set; }
        public string primary_position { get; set; }
        public string id { get; set; }
        public int win { get; set; }
        public int loss { get; set; }
        public int save { get; set; }
        public int hold { get; set; }
        public int blown_save { get; set; }
    }

    public class Save
    {
        public string preferred_name { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string jersey_number { get; set; }
        public string status { get; set; }
        public string position { get; set; }
        public string primary_position { get; set; }
        public string id { get; set; }
        public int win { get; set; }
        public int loss { get; set; }
        public int save { get; set; }
        public int hold { get; set; }
        public int blown_save { get; set; }
    }

    public class Hold
    {
        public string preferred_name { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string jersey_number { get; set; }
        public string status { get; set; }
        public string position { get; set; }
        public string primary_position { get; set; }
        public string id { get; set; }
        public int win { get; set; }
        public int loss { get; set; }
        public int save { get; set; }
        public int hold { get; set; }
        public int blown_save { get; set; }
    }

    public class Blown_Save
    {
        public string preferred_name { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string jersey_number { get; set; }
        public string status { get; set; }
        public string position { get; set; }
        public string primary_position { get; set; }
        public string id { get; set; }
        public int win { get; set; }
        public int loss { get; set; }
        public int save { get; set; }
        public int hold { get; set; }
        public int blown_save { get; set; }
    }

    public class Official
    {
        public string id { get; set; }
        public string full_name { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string assignment { get; set; }
        public string experience { get; set; }
    }

    public class Rescheduled
    {
        public DateTime from { get; set; }
        public string reason { get; set; }
    }

}
