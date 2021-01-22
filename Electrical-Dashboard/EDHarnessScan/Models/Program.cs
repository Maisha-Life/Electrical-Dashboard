using EDDLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDHarnessScan.Models
{
    public class Program : BaseModel
    {
        public static Program CreateProgram() => new Program()
        {
            Id_Program = -1
        };

        public static Program CreateProgram(string programDesc, string owner, string milestone) => new Program()
        {
            Id_Program = -1,
            ProgramDesc = programDesc,
            Owner = owner,
            Milestone = milestone
        };

        public static Program CreateProgram(int id_program, string programDesc, string owner, string milestone) => new Program()
        {
            Id_Program = id_program,
            ProgramDesc = programDesc,
            Owner = owner,
            Milestone = milestone
        };

        #region Properties

        public int Id_Program { get; set; }
        public string ProgramDesc { get; set; }
        public string Owner { get; set; }
        public string Milestone { get; set; }

        #endregion

        #region Validation

        protected override string[] ValidatedProperties
        {
            get
            {
                if (base.ValidatedProperties == null)
                    base.ValidatedProperties = new string[] { "ProgramDesc", "Owner", "Milestone" };
                return base.ValidatedProperties;
            }
            set
            {
                base.ValidatedProperties = value;
            }
        }

        protected override string GetValidationError(string propertyName)
        {
            if (Array.IndexOf(ValidatedProperties, propertyName) < 0)
                return null;

            string error = null;

            if (propertyName == "ProgramDesc")
                error = ValidateProgramDesc();
            else if (propertyName == "Owner")
                error = ValidateOwner();
            else if (propertyName == "Milestone")
                error = ValidateMilestone();

            return error;
        }

        string ValidateProgramDesc()
        {
            if (IsStringMissing(this.ProgramDesc))
                return "Program description required";
            return null;
        }
        string ValidateOwner()
        {
            if (IsStringMissing(this.Owner))
                return "Owner Name required";
            return null;
        }
        string ValidateMilestone()
        {
            if (IsStringMissing(this.Milestone))
                return "Milestone required";
            return null;
        }

        #endregion
    }
}
