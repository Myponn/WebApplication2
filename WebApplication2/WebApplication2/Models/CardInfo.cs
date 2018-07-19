using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class CardInfo
    {
        public string NameOnCard { get; set; }
        public string CardNumber { get; set; }
        public string ExpiryDate { get; set; }

        public static CardInfo Create(string NameOnCard,string CardNumber, string ExpiryDate)
        {
            if (string.IsNullOrEmpty(NameOnCard))
                throw new Exception("Name on card can't be Emtry!.");
            if (string.IsNullOrEmpty(CardNumber))
                throw new Exception("Card Number can't be Emtry!.");
            if (string.IsNullOrEmpty(ExpiryDate))
                throw new Exception("Expiry Datee can't be Empty!.");

            return new CardInfo
            {
                NameOnCard = NameOnCard,
                CardNumber = CardNumber,
                ExpiryDate = ExpiryDate
            };
        }
        public override bool Equals(object obj)
        {
            CardInfo CardToCompare = obj as CardInfo;
            if (CardToCompare == null)
                throw new Exception("Can't compare two different objects to each other");

            return this.CardNumber == CardToCompare.CardNumber &&
                this.ExpiryDate == CardToCompare.ExpiryDate;
        }

        public override int GetHashCode()
        {
            if (String.IsNullOrEmpty(this.CardNumber))
                return 0;

            return this.CardNumber.GetHashCode();
        }
    }
}