using EDDLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDHarnessScan.Models
{
    public class Harness : BaseModel
    {
        public static Harness CreateHarness(string prefix) { return new Harness() { ProgramPrefix = prefix }; }
        public static Harness CreateHarness(string id_harness, string id_harnessGroup, string id_program, string programPrefix, string harnessBase, string harnessSuffix,
                                            string owner, bool toolsScanBool, bool pmiBool, bool dtSyncBool, bool ffa2Bool, bool renamingBool, bool harnessCheckBool)
        {
            return new Harness()
            {
                Id_Harness = id_harness,

                Id_HarnessGroup = id_harnessGroup,
                Id_Program = id_program,

                ProgramPrefix = programPrefix,

                HarnessBase = harnessBase,
                HarnessSuffix = harnessSuffix,

                Owner = owner,

                ToolsScanBool = toolsScanBool,
                PMIBool = pmiBool,
                DTSyncBool = dtSyncBool,
                FFA2Bool = ffa2Bool,
                RenamingBool = renamingBool,
                HarnessCheckBool = harnessCheckBool
            };
        }

        #region Properties

        public string Id_Harness { get; set; }

        public string Id_HarnessGroup { get; set; }
        public string Id_Program { get; set; }

        public string ProgramPrefix { get; set; }

        public string HarnessBase { get; set; }
        public string HarnessSuffix { get; set; }

        public string Owner { get; set; }

        public bool ToolsScanBool { get; set; }
        public bool PMIBool { get; set; }
        public bool DTSyncBool { get; set; }
        public bool FFA2Bool { get; set; }
        public bool RenamingBool { get; set; }
        public bool HarnessCheckBool { get; set; }

        #endregion

        #region Validation

        protected override string[] ValidatedProperties
        {
            get
            {
                if (base.ValidatedProperties == null)
                    base.ValidatedProperties = new string[] { "Owner" };
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

            if (propertyName == "Owner")
                error = ValidateOwner();

            return error;
        }

        string ValidateOwner()
        {
            if (IsStringMissing(this.Owner))
                return "Owner name required";
            return null;
        }

        #endregion
    }
}
