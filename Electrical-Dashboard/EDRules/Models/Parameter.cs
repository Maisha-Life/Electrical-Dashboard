using EDDLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDRules.Models
{
    public class Parameter : BaseModel
    {
        public static Parameter CreateParameter() => new Parameter() { };
        public static Parameter CreateParameter(int id_parameter, string type, string group, string description) => new Parameter() 
        { 
            Id_Parameter = id_parameter,
            Type = type,
            Group = group,
            Description = description
        };

        #region Properties

        public int Id_Parameter { get; set; }
        public string Type { get; set; }
        public string Group { get; set; }
        public string Description { get; set; }

        #endregion
    }
}
