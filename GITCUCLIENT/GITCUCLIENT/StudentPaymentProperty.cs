using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for StudentPaymentProperty
/// </summary>
public class StudentPaymentProperty
{
    public StudentPaymentProperty()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public string StudentRegNo { get; set; }
    public string StudentMatricNo { get; set; }
    public string StudentName { get; set; }
    public string StudentProgram { get; set; }
    public string StudentLevel { get; set; }
    public string AmountPaid { get; set; }
    public string PaymentPurpose { get; set; }
    public string PaymentDesc { get; set; }
    public string PaymentDate { get; set; }
    public string Currency { get; set; }
    public int NoInBatch { get; set; }
}