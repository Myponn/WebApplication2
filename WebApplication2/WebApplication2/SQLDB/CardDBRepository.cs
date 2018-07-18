using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication2.Services;
using WebApplication2.Models;

namespace WebApplication2.SQLDB
{
    public class CardDBRepository : ICardRepository<CardInfo>
    {
        CardContext _db;
        public CardDBRepository(CardContext repo)
        {
            _db = repo;
        }

        public void Add(CardInfo Entity)
        {
            _db.cardInfo.Add(Entity);
            _db.SaveChanges();
        }

        public CardInfo GetData(Specification<CardInfo> Spec)
        {
            return _db.cardInfo.SingleOrDefault(Spec.TSpec);
        }

        DBRepository<CardInfo> _repo;
        public CardDBRepository(DBRepository<CardInfo> dbRepo)
        {
            _repo = dbRepo;

            //Temp Data for Test
            _repo.Add(CardInfo.Create("Name LastName", "4567890123456789", "012020"));
            _repo.Add(CardInfo.Create("Name LastName", "4567890123456790", "012021"));
            _repo.Add(CardInfo.Create("Name LastName", "4567890123456791", "012022"));
            _repo.Add(CardInfo.Create("Name LastName", "4567890123456792", "012023"));
            _repo.Add(CardInfo.Create("Name LastName", "3456789012345678", "012099"));
            _repo.Add(CardInfo.Create("Name LastName", "3456789012345679", "022099"));
            _repo.Add(CardInfo.Create("Name LastName", "3456789012345680", "032099"));
            _repo.Add(CardInfo.Create("Name LastName", "3456789012345681", "042099"));
            _repo.Add(CardInfo.Create("Name LastName", "5678901234567890", "012021"));
            _repo.Add(CardInfo.Create("Name LastName", "5678901234567891", "012023"));
            _repo.Add(CardInfo.Create("Name LastName", "5678901234567892", "012017"));
            _repo.Add(CardInfo.Create("Name LastName", "5678901234567893", "012020"));
            _repo.Add(CardInfo.Create("Name LastName", "345678901234567", "012099"));
            _repo.Add(CardInfo.Create("Name LastName", "345678901234568", "012099"));
            _repo.Add(CardInfo.Create("Name LastName", "345678901234569", "012099"));
            _repo.Add(CardInfo.Create("Name LastName", "345678901234570", "012099"));
        }

        public CardInfo GetTempData(Specification<CardInfo> Spec)
        {
            return _repo.GetData(Spec);
        }
    }
}