using System;
using System.Collections.Generic;
using System.Text;

namespace RealEstate
{
    class Property
    {
        private string city;
        private string address;
        private int askingPrice;
        private double purchasePrice;
        private double downPayment;
        private double mortgageRate;
        private int mortgageTerm;
        private double mortgagePayment;
        private double monthlyRent;
        private double condoFees;
        private double mgmtFee;
        private double monthlyUtility;
        private double propertyTax;
        private double profitLoss;
        private int user;

        public Property(string city, string address, int askingPrice, double purchasePrice, double downPayment, 
            double mortgageRate, int mortgageTerm, double mortgagePayment, double monthlyRent, 
            double condoFees, double mgmtFee, double monthlyUtility, double propertyTax, double profitLoss, int user)
        {
            this.city = city;
            this.address = address;
            this.askingPrice = askingPrice;
            this.purchasePrice = purchasePrice;
            this.downPayment = downPayment;
            this.mortgageRate = mortgageRate;
            this.mortgageTerm = mortgageTerm;
            this.mortgagePayment = mortgagePayment;
            this.monthlyRent = monthlyRent;
            this.condoFees = condoFees;
            this.mgmtFee = mgmtFee;
            this.monthlyUtility = monthlyUtility;
            this.propertyTax = propertyTax;
            this.profitLoss = profitLoss;
            this.user = user;
        }

        public string GetCity
        {
            get => city;
        }
        public string SetCity
        {
            set => city = value;
        }
        //=========================================================================
        public string GetAddress
        {
            get => address;
        }
        public string SetAddress
        {
            set => address = value;
        }
        //=========================================================================
        public int GetAskingPrice
        {
            get => askingPrice;
        }
        public int SetAskingPrice
        {
            set => askingPrice = value;
        }
        //=========================================================================
        public double GetPurchasePrice
        {
            get => purchasePrice;
        }
        public double SetPurchasePrice
        {
            set => purchasePrice = value;
        }
        //=========================================================================
        public double GetDownPayment
        {
            get => downPayment;
        }
        public double SetDownPayment
        {
            set => downPayment = value;
        }
        //=========================================================================
        public double GetMortgageRate
        {
            get => mortgageRate;
        }
        public double SetMortgageRate
        {
            set => mortgageRate = value;
        }
        //=========================================================================
        public int GetMortgageTerm
        {
            get => mortgageTerm;
        }
        public int SetMortgageTerm
        {
            set => mortgageTerm = value;
        }
        //=========================================================================
        public double GetMortgagePayment
        {
            get => mortgagePayment;
        }
        public double SetMortgagePayment
        {
            set => mortgagePayment = value;
        }
        //=========================================================================
        public double GetMonthlyRent
        {
            get => monthlyRent;
        }
        public double SetMonthlyRent
        {
            set => monthlyRent = value;
        }
        //=========================================================================
        public double GetCondoFees
        {
            get => condoFees;
        }
        public double SetCondoFees
        {
            set => condoFees = value;
        }
        //=========================================================================
        public double GetMgmtFee
        {
            get => mgmtFee;
        }
        public double SetMgmtFee
        {
            set => mgmtFee = value;
        }
        //=========================================================================
        public double GetMonthlyUtility
        {
            get => monthlyUtility;
        }
        public double SetMonthlyUtility
        {
            set => monthlyUtility = value;
        }
        //=========================================================================
        public double GetPropertyTax
        {
            get => propertyTax;
        }
        public double SetPropertyTax
        {
            set => propertyTax = value;
        }
        //=========================================================================
        public double GetProfitLoss
        {
            get => profitLoss;
        }
        public double SetProfitLoss
        {
            set => profitLoss = value;
        }
        //=========================================================================
        public int GetUser
        {
            get => user;
        }
        public int SetUser
        {
            set => user = value;
        }
    }
}
