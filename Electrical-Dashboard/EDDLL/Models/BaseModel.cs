using System;
using System.ComponentModel;
using System.Text.RegularExpressions;

namespace EDDLL.Models
{
    public class BaseModel : IDataErrorInfo
    {
        //
        //could add ID here, but for clarity on what it is in the database will leave it as database name for all models (i.e. Id_Harness -> Id for all...)
        //

        #region Variables

        static string regexOnlyNumbers = @"^[+-]?(\d*|\d{1,3}(,\d{3})*)(\.\d+)?\b$";

        #endregion

        #region IDataErrorInfo Members

        string IDataErrorInfo.Error { get { return null; } }

        string IDataErrorInfo.this[string propertyName]
        {
            get { return this.GetValidationError(propertyName); }
        }

        #endregion // IDataErrorInfo Members

        #region Validation

        /// <summary>
        /// Returns true if this object has no validation errors.
        /// </summary>
        public bool IsValid
        {
            get
            {
                foreach (string property in ValidatedProperties)
                    if (GetValidationError(property) != null)
                        return false;

                return true;
            }
        }

        protected virtual string[] ValidatedProperties { get; set; }

        protected virtual string GetValidationError(string propertyName)
        {
            return "";
        }

        protected static bool IsStringMissing(string value)
        {
            return String.IsNullOrEmpty(value) || value.Trim() == String.Empty;
        }

        protected static bool IsNotValidNumber(string value)
        {
            if (String.IsNullOrEmpty(value))
                return true;

            return !Regex.IsMatch(value, regexOnlyNumbers);
        }

        protected static bool IsDateValid(DateTime value)
        {
            if (value == null)
                return false;

            return true;
        }

        #endregion // Validation
    }
}
