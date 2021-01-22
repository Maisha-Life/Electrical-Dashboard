using EDDLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDRules.Models
{
    public class Milestone : BaseModel
    {
        public static Milestone CreateMilestone() => new Milestone() { };
        public static Milestone CreateMilestone(int id_milestone, string abbreviation, string description, string group) => new Milestone() 
        { 
            Id_Milestone = id_milestone,
            Abbreviation = abbreviation,
            Description = description,
            Group = group
        };

        #region Properties

        public int Id_Rule { get; set; }

        public int Id_Milestone { get; set; }
        public string Abbreviation { get; set; }
        public string Description { get; set; }
        public string Group { get; set; }

        #endregion
    }
}
