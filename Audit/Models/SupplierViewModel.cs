using System;

namespace Audit.Web.Models
{
    public class SupplierViewModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string ContactPerson { get; set; }
        public string TelNo { get; set; }
        public string FaxNo { get; set; }
        public string MobileNo { get; set; }
        public string Email { get; set; }
        public string CertificationType { get; set; }
        public int CertificationTypeID { get; set; }
        public DateTime CertificationExpiryDate { get; set; }
        public string VendorNo { get; set; }
        public string Company { get; set; }
        public int? CompanyID { get; set; }
        public DateTime DateCaptured { get; set; }
        public string SupplierType { get; set; }
        public int SupplierTypeID { get; set; }
        public bool Active { get; set; }
        public int CategoryID { get; set; }
        public int CurrencyID { get; set; }
        public int NegotiatedBy { get; set; }
        public string Comments { get; set; }
        public bool IsPrimary { get; set; }
        public bool IsComplete { get; set; }
        public int Rating { get; set; }
        public int MSDS { get; set; }
        public string BackupSupplier { get; set; }
        public int? BackupSupplierID { get; set; }

    }
}