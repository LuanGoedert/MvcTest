using SalesWebMvc.Models.Enums;
using System;


namespace SalesWebMvc.Models
{
    public class SalesRecord
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public double Ammount { get; set; }
        public SaleStatus Status { get; set; }
        public Seller Seller { get; set; }

        public SalesRecord()
        {
        }

        public SalesRecord(int iD, DateTime date, double ammount, SaleStatus status, Seller seller)
        {
            ID = iD;
            Date = date;
            Ammount = ammount;
            Status = status;
            Seller = seller;
        }
    }
}
