using EDDLL.ViewModels;
using EDDLL.Utilities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using EDTools.ViewModels.ModelsVM;
using EDTools.Utilities;
using EDDLL.Tickets;

namespace EDTools.ViewModels
{
    public class vmTool : vmBase
    {
        public vmTool(string name, string shortname, string path, string type, string imagesource, string description, string status, List<string> processes)
        {
            Name = name;
            ShortName = shortname;
            Path = path;
            Type = type;
            ImageSource = imagesource;
            Description = description;
            Status = status;
            processNames = processes;

            RunningVisibility = Visibility.Collapsed;

            checkProcess();
        }

        #region Properties

        public Process p { get; set; }

        private List<string> _processNames;
        public List<string> processNames
        {
            get
            {
                if (_processNames == null)
                    _processNames = new List<string>();
                return _processNames;
            }
            set { _processNames = value; }
        }

        #endregion

        #region Data Binds

        private string _Name;
        public string Name
        {
            get { return _Name; }
            set
            {
                if (this._Name != value)
                {
                    this._Name = value;
                    this.RaisePropertyChangedEvent("Name");
                }
            }
        }

        private string _ShortName;
        public string ShortName
        {
            get { return _ShortName; }
            set
            {
                if (this._ShortName != value)
                {
                    this._ShortName = value;
                    this.RaisePropertyChangedEvent("ShortName");
                }
            }
        }

        private string _Path;
        public string Path
        {
            get { return _Path; }
            set
            {
                if (this._Path != value)
                {
                    this._Path = value;
                    this.RaisePropertyChangedEvent("Path");
                }
            }
        }

        private string _Type;
        public string Type
        {
            get { return _Type; }
            set
            {
                if (this._Type != value)
                {
                    this._Type = value;
                    this.RaisePropertyChangedEvent("Type");
                }
            }
        }

        private string _ImageSource;
        public string ImageSource
        {
            get { return _ImageSource; }
            set
            {
                if (this._ImageSource != value)
                {
                    this._ImageSource = value;
                    this.RaisePropertyChangedEvent("ImageSource");
                }
            }
        }

        private string _Description;
        public string Description
        {
            get { return _Description; }
            set
            {
                if (this._Description != value)
                {
                    this._Description = value;
                    this.RaisePropertyChangedEvent("Description");
                }
            }
        }

        public string Status { get; set; }

        private bool _IsRunning;
        public bool IsRunning
        {
            get { return _IsRunning; }
            set
            {
                if (this._IsRunning != value)
                {
                    this._IsRunning = value;
                    this.RaisePropertyChangedEvent("IsRunning");
                }
            }
        }

        private Visibility _RunningVisibility;
        public Visibility RunningVisibility
        {
            get { return _RunningVisibility; }
            set
            {
                if (this._RunningVisibility != value)
                {
                    this._RunningVisibility = value;
                    this.RaisePropertyChangedEvent("RunningVisibility");
                }
            }
        }

        #endregion

        #region Commands

        private RelayCommand _Execute;
        public ICommand Execute
        {
            get
            {
                if (_Execute == null) _Execute = new RelayCommand(param => execute(), param => { return (!IsRunning); });

                return _Execute;
            }
        }
        private async void execute()
        {
            await Task.Run(() =>
            {
                p = new Process();
                p.StartInfo.FileName = Path;
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.RedirectStandardOutput = true;

                IsRunning = true;
                RunningVisibility = Visibility.Visible;

                p.Start();

                listen();
            });

        }

        private RelayCommand _CloseTool;
        public ICommand CloseTool
        {
            get
            {
                if (_CloseTool == null) _CloseTool = new RelayCommand(param => closeTool(), param => { return (true); });

                return _CloseTool;
            }
        }
        public void closeTool()
        {
            p.Kill();
            cleanup();
        }

        private RelayCommand _BringToFront;
        public ICommand BringToFront
        {
            get
            {
                if (_BringToFront == null) _BringToFront = new RelayCommand(param => bringToFront(), param => { return (true); });

                return _BringToFront;
            }
        }
        private void bringToFront()
        {
            WindowHelper.BringProcessToFront(p);
        }

        private RelayCommand _CreateToolSpecificTicketCommand;
        public ICommand CreateToolSpecificTicketCommand
        {
            get
            {
                if (_CreateToolSpecificTicketCommand == null) _CreateToolSpecificTicketCommand = new RelayCommand(param => createToolSpecificTicket(), param => { return (true); });

                return _CreateToolSpecificTicketCommand;
            }
        }
        private void createToolSpecificTicket()
        {
            vmEDToolsTicket ticket = new vmEDToolsTicket(Ticket.createTicket(ShortName, "", Environment.UserName, DateTime.Today, DateTime.Today));

            PopupHelper.TabIndex(0, ticket);
            PopupHelper.SetVisibility(true);
        }

        #endregion

        #region Methods

        private void checkProcess()
        {
            foreach (string name in processNames)
            {
                Process[] pname = Process.GetProcessesByName(name);

                if (pname.Length > 0)
                {
                    p = pname[0];

                    IsRunning = true;
                    RunningVisibility = Visibility.Visible;

                    listen();

                    return;
                }
            }
        }
        private void cleanup()
        {
            p.Dispose();

            IsRunning = false;
            RunningVisibility = Visibility.Collapsed;
        }
        private async void listen()
        {
            await Task.Run(() =>
            {
                //string output = p.StandardOutput.ReadToEnd();

                p.WaitForExit();

                cleanup();
            });
        }

        #endregion

    }
}
