using System;
using System.Runtime.InteropServices;

namespace EDDLL.Utilities 
{
    [Serializable]
    public class CatiaConnectionException : Exception
    {
        public CatiaConnectionException() { }

        public CatiaConnectionException(string message) : base(message) { }

        public CatiaConnectionException(string message, Exception inner) : base(message, inner) { }
    }

    internal class CatiaLink
    {
        //private INFITF.Application catia;
        //public INFITF.Application CATIA
        //{
        //    get
        //    {
        //        if (catia == null || !IsConnected(catia))
        //        {
        //            Exception ex;
        //            if (!TryGetCatiaSession(out catia, out ex)) { }
        //            //    System.Windows.Forms.MessageBox.Show("A connection with CATIA could not be established. Please restart or load up CATIA before starting the application.", "CATIA Connection Exception");
        //        }
        //        return catia;
        //    }
        //}

        //private bool TryGetCatiaSession(out INFITF.Application session, out Exception exception)
        //{
        //    try
        //    {
        //        session = (INFITF.Application)Marshal.GetActiveObject("Catia.Application");
        //        exception = null;
        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        session = null;
        //        exception = ex;
        //        return false;
        //    }
        //}

        //private bool IsConnected(INFITF.Application session)
        //{
        //    try
        //    {
        //        bool test = session.Visible;
        //        return true;
        //    }
        //    catch
        //    {
        //        return false;
        //    }
        //}

        //public CatiaLink() { }
    }
}
