using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Input;

using EDDLL.Utilities;

namespace EDDLL.ViewModels
{
    public class vmBase : ObservableObject, IDisposable
    {
        #region Constructor

        protected vmBase() { }

        #endregion // Constructor

        #region Properties       

        public bool PopupActive { get; set; }

        private bool _EditBool;
        public bool EditBool
        {
            get { return _EditBool; }
            set
            {
                if (this._EditBool != value)
                {
                    this._EditBool = value;
                    this.RaisePropertyChangedEvent("EditBool");
                }
            }
        }

        #endregion

        #region Methods     

        public virtual void save() { }
        public virtual void cancel() { }
        public virtual void remove() { }
        public virtual void revert() { }

        #endregion

        #region Debugging Aides

        /// <summary>
        /// Warns the developer if this object does not have
        /// a public property with the specified name. This 
        /// method does not exist in a Release build.
        /// </summary>
        [Conditional("DEBUG")]
        [DebuggerStepThrough]
        public void VerifyPropertyName(string propertyName)
        {
            // Verify that the property name matches a real,  
            // public, instance property on this object.
            if (TypeDescriptor.GetProperties(this)[propertyName] == null)
            {
                string msg = "Invalid property name: " + propertyName;

                if (this.ThrowOnInvalidPropertyName)
                    throw new Exception(msg);
                else
                    Debug.Fail(msg);
            }
        }

        /// <summary>
        /// Returns whether an exception is thrown, or if a Debug.Fail() is used
        /// when an invalid property name is passed to the VerifyPropertyName method.
        /// The default value is false, but subclasses used by unit tests might 
        /// override this property's getter to return true.
        /// </summary>
        protected virtual bool ThrowOnInvalidPropertyName { get; private set; }

        #endregion // Debugging Aides

        #region IDisposable Members

        /// <summary>
        /// Invoked when this object is being removed from the application
        /// and will be subject to garbage collection.
        /// </summary>
        public void Dispose()
        {
            this.OnDispose();
        }

        /// <summary>
        /// Child classes can override this method to perform 
        /// clean-up logic, such as removing event handlers.
        /// </summary>
        protected virtual void OnDispose()
        {
        }

        #endregion // IDisposable Members
    }
}
