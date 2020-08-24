namespace EDDLL.Utilities
{
    public class ThreeNOne : ObservableObject
    {
        public ThreeNOne(string value)
        {
            Original = value;
            Default();
        }
        public bool ChangedBool { get; set; }

        public string Original { get; set; }

        private string m_Changed;
        public string Changed
        {
            get { return m_Changed ?? (m_Changed = ""); }
            set
            {
                if (this.m_Changed != value)
                {
                    this.m_Changed = value;
                    this.RaisePropertyChangedEvent("Changed");
                }
            }
        }

        private string m_Saved;
        public string Saved
        {
            get { return m_Saved; }
            set
            {
                if (this.m_Saved != value)
                {
                    this.m_Saved = value;
                    this.RaisePropertyChangedEvent("Saved");
                }
            }
        }

        public void Save()
        {
            if (this.m_Saved == this.Changed)
                ChangedBool = false;
            else
                ChangedBool = true;

            Saved = Changed;            
        }

        public void Default()
        {
            Saved = Original;
            Changed = Original;
        }

        public void Cancel()
        {
            Changed = Saved;
        }

        public void setOriginal()
        {
            Original = Saved;
            Changed = Saved;
        }
    }
}
