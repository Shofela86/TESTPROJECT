using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

    public class StudentProperties
    {
        public string StudentMatricNo { get; set; }
        public string ProgramId { get; set; }
        public string Program { get; set; }   
        public string FacultyId { get; set; }
        public string Faculty { get; set; }
        public string DepartmentId { get; set; }
        public string Department { get; set; }

        public string Level { get; set; }
        public string Nationality { get; set; }
        public string StudentName { get; set; }
        public int NoInBatch { get; set; }
        public string SessionName { get; set; }
        public string TotalFeeAmount { get; set; }
        public string PaymentInvoice { get; set; }
    }