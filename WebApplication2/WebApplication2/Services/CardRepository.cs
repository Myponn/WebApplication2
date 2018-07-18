using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication2.Models;
using System.Text.RegularExpressions;

namespace WebApplication2.Services
{
    public class CardRepository
    {
        public CardInfo GetCardInfobyNumber(string cardNumber)
        {
            return CardInfo.Create("Name LastName","4567890123456789","012012");
        }

        public ValidateResult ValidateCardInfo(CardInfo card)
        {
            ValidateResult CheckCard = new ValidateResult();
            string res = ValidateStatus.Invalid;
            string cType = ValidateCardType.Unknown;
            //Verify Input Data
            Regex regCard = new Regex(@"\d{15,16}");
            Regex regExpDate = new Regex(@"^(0[1-9]|1[0-2])(?<year>20[0-9][0-9])$");
            if (regCard.IsMatch(card.CardNumber) && regExpDate.IsMatch(card.ExpiryDate))
            {
                //Check Card Exist On DB

                //Verify
                CheckCard.CardType = VerifyCardType(card.CardNumber);
                CheckCard.Result = ValidateCardExpire(CheckCard.CardType, card.ExpiryDate);
            }
            else
            {
                cType = ValidateCardType.Unknown;
                res = ValidateStatus.Invalid;
            }
            CheckCard.CardType = cType;
            CheckCard.Result = res;
            return CheckCard;
            //return ValidateFunction.VerifyCardInfo(card);
        }

        private bool CheckPrimeNumber(int value)
        {
            if (value == 1)
            {
                return false;
            }
            else if (value == 2)
            {
                return true;
            }
            else
            {

                for (int i = 2; i < Math.Ceiling(Math.Sqrt(value)); i++)
                {
                    if (value % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
        }

        private bool CheckLeapYear(int vYear)
        {
            return vYear % 4 == 0 ? true : false;
        }

        private string VerifyCardType(string CardNo)
        {
            switch (CardNo.Substring(0, 1))
            {
                case "4":
                    return ValidateCardType.VISA;
                case "5":
                    return ValidateCardType.MASTER;
                case "3":
                    if (CardNo.Length == 15)
                        return ValidateCardType.AMEX;
                    else if (CardNo.Length == 16)
                        return ValidateCardType.JCB;
                    else
                        return ValidateCardType.Unknown;
                default:
                    return ValidateCardType.Unknown;
            }
        }
        private string ValidateCardExpire(string CardType, string Exp_Date)
        {
            int ExpYear = Convert.ToInt32(Exp_Date.Substring(2, 4));
            if (CardType == ValidateCardType.VISA)
            {
                return CheckLeapYear(ExpYear) ? ValidateStatus.Valid : ValidateStatus.Invalid;
            }
            else if (CardType == ValidateCardType.MASTER)
            {
                return CheckPrimeNumber(ExpYear) ? ValidateStatus.Valid : ValidateStatus.Invalid;
            }
            else if (CardType == ValidateCardType.JCB)
            {
                return ValidateStatus.Valid;
            }
            else
            {
                return ValidateStatus.Invalid;
            }

        }
    }
}