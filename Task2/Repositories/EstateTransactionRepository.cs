using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using Model;

namespace Repositories
{
    public class EstateTransactionRepository
    {

        public IEnumerable<EstateTransaction> GetEstateTransactions()
        {
            return GetData();
        }

        private static IEnumerable<EstateTransaction> GetData()
        {
            var csvData = File.ReadAllLines("Sacramentorealestatetransactions.csv");
            return csvData
                .Skip(1)
                .Select(line => line.Split(','))
                .Select(data => new EstateTransaction
                {
                    Street = data[0],
                    City = data[1],
                    ZipCode = data[2],
                    Beds = int.Parse(data[4]),
                    Baths = int.Parse(data[5]),
                    SqFeet = int.Parse(data[6]),
                    Type = (PropertyType)Enum.Parse(typeof(PropertyType), data[7].Replace("-",""), true),
                    SaleDate = DateTime.ParseExact(data[8].Replace("EDT", "-4"), "ddd MMM dd HH:mm:ss z yyyy", new CultureInfo("en-US")),
                    Price = int.Parse(data[9])
                });
        }

    }
}
