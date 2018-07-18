using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication2.Models;
using WebApplication2.Services;

namespace WebApplication2.Controllers
{
    public class CardInfoController : ApiController
    {
        private CardRepository cardrepo;

        public CardInfoController()
        {
            this.cardrepo = new CardRepository();
        }
        [HttpGet]
        public Response<CardInfo> Get(string CardNumber)
        {
            var res = new Response<CardInfo>();
            try
            {
                res.Obj = this.cardrepo.GetCardInfobyNumber(CardNumber);
            }
            catch(Exception ex)
            {
                res.IsError = true;
                res.ResultMessage = ex.Message;
            }
            return res;
        }

        [HttpPost]
        public Response<ValidateResult> ValidateCardInfo([FromBody] CardInfo card)
        {
            var res = new Response<ValidateResult>();
            try
            {
                res.Obj = this.cardrepo.ValidateCardInfo(card);
            }
            catch (Exception ex)
            {
                res.IsError = true;
                res.ResultMessage = ex.Message;
            }
            return res;
        }
    }
}
