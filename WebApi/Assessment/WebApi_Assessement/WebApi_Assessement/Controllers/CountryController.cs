using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi_Assessement.Models;

namespace WebApi_Assessement.Controllers
{
    public class CountryController : ApiController
    {
        public List<Country> list = new List<Country>();
        public CountryController()
        {
            list.Add(new Country { Id = 1, CountryName = "India", Capital = "Delhi" });
            list.Add(new Country { Id = 2, CountryName = "Japan", Capital = "Tokyo" });
            list.Add(new Country { Id = 3, CountryName = "USA", Capital = "Washington" });
        }
        [HttpGet]
        public List<Country> GetCountries()
        {
            return list;
        }

        [HttpPost]
        public List<Country> Create([FromBody] Country country)
        {
            list.Add(country);
            return list;
        }
        [HttpPut]
        public List<Country> Update(int id, [FromBody] Country country)
        {
            var existingCountry = list.Find(c => c.Id == id);
            if (existingCountry == null)
            {
            }
            existingCountry.CountryName = country.CountryName;
            existingCountry.Capital = country.Capital;
            return list;
        }
        [HttpDelete]
        public List<Country> Delete(int id)
        {
            var country = list.Find(c => c.Id == id);
            if (country == null)
            {
            }
            list.Remove(country);
            return list;
        }
    }
}
