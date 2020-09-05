using EDDLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDRules.Models
{
    public class Rule : BaseModel
    {

        public static Rule CreateRule() => new Rule()
        {
            Id_Rule = "-1",

            RuleTypeDesc = "Consideration",

            DesignRule = "",
            LegacyIDDesc = "",
            RuleName = "",
            RuleDesc = "",

            Id_Status = 0,
        };
        public static Rule CreateRule(string ruleTypeDesc, string designRule, string ruleName, string ruleDesc, int id_status, string ruleCheckDesc, string ruleRepairDesc) => new Rule()
        {
            Id_Rule = "-1",

            RuleTypeDesc = ruleTypeDesc,

            DesignRule = designRule,
            RuleName = ruleName,
            RuleDesc = ruleDesc,

            Id_Status = id_status,

            RuleCheckDesc = ruleCheckDesc,
            RuleRepairDesc = ruleRepairDesc
        };
        public static Rule CreateRule(string id_rule, string ruleTypeDesc, string designRule, string ruleName, string ruleDesc, int id_status, string ruleCheckDesc, string ruleRepairDesc, string owner) => new Rule()
        {
            Id_Rule = id_rule,

            RuleTypeDesc = ruleTypeDesc,

            DesignRule = designRule,
            RuleName = ruleName,
            RuleDesc = ruleDesc,
            Owner = owner,

            Id_Status = id_status,

            RuleCheckDesc = ruleCheckDesc,
            RuleRepairDesc = ruleRepairDesc
        };

        #region Properties

        public string Id_Rule { get; set; }

        public string RuleTypeDesc { get; set; }

        public string DesignRule { get; set; }
        public string LegacyIDDesc { get; set; }
        public string RuleName { get; set; }
        public string RuleDesc { get; set; }
        public string Owner { get; set; }

        public int Id_Status { get; set; }

        public string RuleCheckDesc { get; set; }
        public string RuleRepairDesc { get; set; }

        #endregion

        #region Validation

        protected override string[] ValidatedProperties
        {
            get
            {
                if (base.ValidatedProperties == null)
                    base.ValidatedProperties = new string[] { "DesignRule", "RuleName", "RuleDesc" };
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

            if (propertyName == "DesignRule")
                error = ValidateDesignRule();
            else if (propertyName == "RuleName")
                error = ValidateRuleName();
            else if (propertyName == "RuleDesc")
                error = ValidateRuleDescription();

            return error;
        }

        string ValidateDesignRule()
        {
            if (IsStringMissing(this.DesignRule))
                return "Design Rule required";
            return null;
        }
        string ValidateRuleName()
        {
            if (IsStringMissing(this.RuleName))
                return "Rule Name required";
            return null;
        }
        string ValidateRuleDescription()
        {
            if (IsStringMissing(this.RuleDesc))
                return "Rule Description required";
            return null;
        }

        #endregion
    }
}
