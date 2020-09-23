using EDDLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDRules.Models
{
    public class Measurement : BaseModel
    {
        public static Measurement CreateMeasurement() => new Measurement()
        {
            Id_Measurement = -1,
            Id_Rule = -1
        };

        public static Measurement CreateMeasurement(int id_rule, string measurementDesc) => new Measurement()
        {
            Id_Measurement = -1,
            Id_Rule = id_rule,
            MeasurementDesc = measurementDesc
        };

        public static Measurement CreateMeasurement(int id_measurement, int id_rule, string measurementDesc) => new Measurement()
        {
            Id_Measurement = id_measurement,
            Id_Rule = id_rule,
            MeasurementDesc = measurementDesc
        };

        #region Properties

        public int Id_Measurement { get; set; }
        public int Id_Rule { get; set; }
        public string MeasurementDesc { get; set; }

        #endregion

        #region Validation

        protected override string[] ValidatedProperties
        {
            get
            {
                if (base.ValidatedProperties == null)
                    base.ValidatedProperties = new string[] { "MeasurementDesc"};
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

            if (propertyName == "MeasurementDesc")
                error = ValidateDesignRule();
            return error;
        }

        string ValidateDesignRule()
        {
            if (IsStringMissing(this.MeasurementDesc))
                return "Invalid measurement";
            return null;
        }

        #endregion
    }
}
