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
        readonly CardServices _Repo;
        public CardInfoController()
        {
            this._Repo = new CardServices();
        }

        [HttpGet]
        public Response<CardInfo> Get(string CardNumber)
        {
            var res = new Response<CardInfo>();
            try
            {
                res.Obj = this._Repo.GetCardbyNumber(CardNumber);
                if (res.Obj == null)
                {
                    res.IsError = true;
                    res.ResultMessage = ValidateStatus.DoesNotExists;
                }
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
                res.Obj = this._Repo.ValidateCardInfo(card);
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
