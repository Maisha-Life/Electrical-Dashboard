using EDDLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDRules.Models
{
    public class CPSC : BaseModel
    {
        public static CPSC CreateCPSC() => new CPSC() { };
        public static CPSC CreateCPSC(int id_cpsc, string description, string number) => new CPSC() 
        { 
            Id_CPSC = id_cpsc,
            Description = description,
            Number = number
        };

        #region Properties

        public int Id_Rule { get; set; }

        public int Id_CPSC { get; set; }
        public string Description { get; set; }
        public string Number { get; set; }

        #endregion
    }
}
