using System;

namespace scrapysharp_dt2020
{

    public class ExistingProspectRanking
    {
        public string rank;
        public string change;
        public string playerName;
        public string school;
        public string position1;
        public string height;
        public string weight;
        public string position2;
        public string rankingDateString;

        public ExistingProspectRanking(string rank, string chg, string name, string school, string pos1, string height, string weight, string pos2, string date)
        {
            this.rank = rank;
            this.change = chg;
            this.playerName = name;
            this.school = school;
            this.position1 = pos1;
            this.height = height;
            this.weight = weight;
            this.position2 = pos2;
            this.rankingDateString = date;
        }
    }
}