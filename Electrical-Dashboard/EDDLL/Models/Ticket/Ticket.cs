﻿using EDS.Models;
using System;
using System.Collections.Generic;
using System.IO.Packaging;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace EDDLL.Tickets
{
    public class Ticket : BaseModel
    {
        //new blank
        public static Ticket createTicket() { return new Ticket(); }
        //new generic ticket
        public static Ticket createTicket(string tool, string category, string assigner, 
                                          DateTime dateAssigned) => new Ticket()
                                          {
                                              TicketID = -1,
                                              TicketNumber = -1,
                                              Tool = tool,
                                              Category = category,
                                              Assigner = assigner,
                                              DateAssigned = dateAssigned
                                          };
        //new with info
        public static Ticket createTicket(int ticketNumber, string importanceLevel, string tool, string category, string assigner, string assignee, DateTime dateAssigned,
                                          DateTime dateDue, string description, string status) => new Ticket()
                                          {
                                              TicketID = -1,
                                              TicketNumber = ticketNumber,
                                              ImportanceLevel = importanceLevel,
                                              Tool = tool,
                                              Category = category,
                                              Assigner = assigner,
                                              Assignee = assignee,
                                              DateAssigned = dateAssigned,
                                              DateDue = dateDue,
                                              Description = description,
                                              Status = status
                                          };
        //from database
        public static Ticket createTicket(int ticketID, int ticketNumber, string importanceLevel, string tool, string category, string assigner, string assignee, 
                                          DateTime dateAssigned, DateTime dateDue, string description, string status) => new Ticket()
                                          {
                                              TicketID = ticketID,
                                              TicketNumber = ticketNumber,
                                              ImportanceLevel = importanceLevel,
                                              Tool = tool,
                                              Category = category,
                                              Assigner = assigner,
                                              Assignee = assignee,
                                              DateAssigned = dateAssigned,
                                              DateDue = dateDue,
                                              Description = description,
                                              Status = status
                                          };

        #region Properties

        public int TicketID { get; set; }

        public int TicketNumber { get; set; }
        public string ImportanceLevel { get; set; }

        public string Tool { get; set; }
        public string Category { get; set; }
        public string Assigner { get; set; }
        public string Assignee { get; set; }
        
        public DateTime DateAssigned { get; set; }
        public DateTime DateDue { get; set; }
        
        public string Description { get; set; }
        public string Status { get; set; }

        #endregion

        #region Validation

        protected override string[] ValidatedProperties
        {
            get
            {
                if (base.ValidatedProperties == null)
                    base.ValidatedProperties = new string[] { "Category", "Assigner", "Assignee", "DateAssigned", "DateDue", "Description" };
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

            if (propertyName == "Category")
                error = this.ValidateCategory();
            else if (propertyName == "Assigner") 
                error = this.ValidateAssigner();
            else if (propertyName == "Assignee")
                error = this.ValidateAssignee();
            else if (propertyName == "DateAssigned")
                error = this.ValidateDateAssigned();
            else if (propertyName == "DateDue")
                error = this.ValidateDateDue();
            else if (propertyName == "Description")
                error = this.ValidateDescription();

            return error;
        }

        string ValidateCategory()
        {
            if (IsStringMissing(this.Category))
                return "valid category required";
            return null;
        }
        string ValidateAssigner()
        {
            if (IsStringMissing(this.Assigner))
                return "valid assigner required";
            return null;
        }
        string ValidateAssignee()
        {
            if (IsStringMissing(this.Assignee))
                return "valid assignee required";
            return null;
        }
        string ValidateDateAssigned()
        {
            if (IsDateValid(this.DateAssigned))
                return "valid date required";
            return null;
        }
        string ValidateDateDue()
        {
            if (IsDateValid(this.DateDue))
                return "valid date required";
            return null;
        }
        string ValidateDescription()
        {
            if (IsStringMissing(this.Description))
                return "valid string required";
            return null;
        }

        #endregion
    }
}