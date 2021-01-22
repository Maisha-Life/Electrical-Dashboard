using EDDLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDRules.Models
{
    public class Component : BaseModel
    {
        public static Component CreateComponent() => new Component() { };
        public static Component CreateComponent(int id_component, string description) => new Component() 
        { 
            Id_Component = id_component,
            Description = description
        };

        #region Properties

        public int Id_Rule { get; set; }

        public int Id_Component { get; set; }
        public string Description { get; set; }

        #endregion
    }
}
