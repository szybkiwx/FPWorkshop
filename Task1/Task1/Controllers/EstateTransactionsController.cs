using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Model;
using Repositories;
using FSharpInterop.BusinessRules;

namespace WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstateTransactionsController : ControllerBase
    {
        private readonly EstateTransactionRepository _repo;
        public EstateTransactionsController()
        {
             _repo = new EstateTransactionRepository();
        }

        // GET api/estatetransactions
        [HttpGet]
        public ActionResult<IEnumerable<EstateTransaction>> Get() => Ok(_repo.GetEstateTransactions());

        // GET api/getareal
        [HttpGet]
        [Route("areal")]
        public ActionResult<IEnumerable<EstateTransaction>> GetAreal(string city)
        {
            var transactions = _repo.GetEstateTransactions();
            var result = EstateTransactionServices.GetAverageResidentialArealInCity(city, transactions);
            return Ok(result);
        }

        // GET api/amount
        [HttpGet]
        [Route("amount")]
        public ActionResult<IEnumerable<EstateTransaction>> GetTotalTransactionAmount(string zip)
        {
            var transactions = _repo.GetEstateTransactions();
            var result = EstateTransactionServices.GetTotalTransactionAmountFromAreaByZip(zip, transactions);
            return Ok(result);
        }

        // GET api/bedrooms
        [HttpGet]
        [Route("bedrooms")]
        public ActionResult<IEnumerable<EstateTransaction>> GetAverageBedrooms(string date1, string date2)
        {
            var transactions = _repo.GetEstateTransactions();
            var result = EstateTransactionServices.GetAverageBedroomsSoldInBetweenDates(DateTime.Parse(date1), DateTime.Parse(date2), transactions);
            return Ok(result);
        }

        // GET api/bedrooms
        [HttpGet]
        [Route("avgprices")]
        public ActionResult<IEnumerable<EstateTransaction>> GetAveragePrices()
        {
            var transactions = _repo.GetEstateTransactions();
            var result = EstateTransactionServices.GetAveragePricePerSquareFeetByCity(transactions);
            return Ok(result);
        }
    }
}
