using EmployeeManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace EmployeeManagement.API.Controllers
{
    public class CountryController: ApiController
    {

        //Here I created a list of country and the return type is list of CountryModel in CountryModel we have 2 data 
        //one is Country_Id which is int and Country_Name which is string so thats why Here I User List Data Type to
        //store data becoz ----A list is a collection of items which can contain elements of multiple datatypes.

        [HttpGet]
        public List<CountryModel> GetCountryList()
        {
            List<CountryModel> listOfCountry = new List<CountryModel>();
            //CountryModel Country = new CountryModel();


            //Country.Country_Id = 1;
            //Country.Country_Name = "Select";
            //listOfCountry.Add(Country);
            CountryModel Country1 = new CountryModel();
            Country1.Country_Id = 2;
            Country1.Country_Name = "India";
            listOfCountry.Add(Country1);
            CountryModel Country2 = new CountryModel();
            Country2.Country_Id = 3;
            Country2.Country_Name = "China";
            listOfCountry.Add(Country2);
            CountryModel Country3 = new CountryModel();
            Country3.Country_Id = 4;
            Country3.Country_Name = "Nepal";
            listOfCountry.Add(Country3);
            CountryModel Country4 = new CountryModel();
            Country4.Country_Id = 5;
            Country4.Country_Name = "USA";
            listOfCountry.Add(Country4);
            CountryModel Country5 = new CountryModel();
            Country5.Country_Id = 6;
            Country5.Country_Name = "UK";
            listOfCountry.Add(Country5);
            CountryModel Country6 = new CountryModel();
            Country6.Country_Id = 7;
            Country6.Country_Name = "Russia";
            listOfCountry.Add(Country6);
            CountryModel Country7 = new CountryModel();
            Country7.Country_Id = 8;
            Country7.Country_Name = "Australia";
            listOfCountry.Add(Country7);
            CountryModel Country8 = new CountryModel();
            Country8.Country_Id = 9;
            Country8.Country_Name = "Pakistan";
            listOfCountry.Add(Country8);
            return listOfCountry;


        }
    }
}