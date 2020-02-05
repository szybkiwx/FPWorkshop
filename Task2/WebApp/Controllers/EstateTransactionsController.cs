using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Model;
using Repositories;
using FSharpInterop.BusinessRules;
using Microsoft.FSharp.Collections;

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
        public ActionResult<IEnumerable<EstateTransaction>> Get() => _repo.GetEstateTransactions().ToList();

        // GET api/getareal
        [HttpGet]
        [Route("areal")]
        public ActionResult<double> GetAreal(string city)
        {
            var transactions = _repo.GetEstateTransactions();
            return EstateTransactionServices.GetAverageResidentialArealInCity(city, transactions);
        }

        // GET api/amount
        [HttpGet]
        [Route("amount")]
        public ActionResult<decimal> GetTotalTransactionAmount(string zip)
        {
            var transactions = _repo.GetEstateTransactions();
            return EstateTransactionServices.GetTotalTransactionAmountFromAreaByZip(zip, transactions);
        }

        // GET api/bedrooms
        [HttpGet]
        [Route("bedrooms")]
        public ActionResult<double> GetAverageBedrooms(string date1, string date2)
        {
            var transactions = _repo.GetEstateTransactions();
            var result = EstateTransactionServices.GetAverageBedroomsSoldInBetweenDates(DateTime.Parse(date1), DateTime.Parse(date2), transactions);
            return Ok(result);
        }

        // GET api/bedrooms
        [HttpGet]
        [Route("avgprices")]
        public ActionResult<Dictionary<string, decimal>> GetAveragePrices()
        {
            var transactions = _repo.GetEstateTransactions();
            return EstateTransactionServices.GetAveragePricePerSquareFeetByCity(transactions).ToDictionary(x => x.Key, x => x.Value);
        }
    }
}
