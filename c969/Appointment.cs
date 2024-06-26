﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c969
{
    public class Appointment
    {
        public int AppointmentId { get; set; }
        public int CustomerId { get; set; }
        public int UserId { get; set; }
        public string Type { get; set; }
        public DateTime Start {  get; set; }
        public DateTime End { get; set; }
        public DateTime CreateDate {  get; set; }
        public string CreatedBy {  get; set; }
        public DateTime LastUpdate {  get; set; }
        public string LastUpdateBy { get; set;}

        public Appointment(int appointmentID, int customerID, int userID, string type, DateTime start, DateTime end, DateTime createDate, string createdBy, DateTime lastUpdate, string lastUpdateBy) 
        { 
            AppointmentId = appointmentID;
            CustomerId = customerID;
            UserId = userID;
            Type = type;
            Start = start;
            End = end;
            CreateDate = createDate;
            CreatedBy = createdBy;
            LastUpdate = lastUpdate;
            LastUpdateBy = lastUpdateBy;
        }

    }
}
