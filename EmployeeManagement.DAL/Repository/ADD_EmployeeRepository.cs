using EmployeeManagement.DAL.Interfaces;
using EmployeeManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.DAL.Repository
{
    public class ADD_EmployeeRepository
    {
        public List<ADD_EmployeeModel> GetCountryList()
        {
            List<ADD_EmployeeModel> listOfCountry = new List<ADD_EmployeeModel>();
            ADD_EmployeeModel Country = new ADD_EmployeeModel();


            Country.Country_Id = 1;
            Country.Country_Name = "India";
            listOfCountry.Add(Country);
            ADD_EmployeeModel Country1 = new ADD_EmployeeModel();
            Country1.Country_Id = 2;
            Country1.Country_Name = "Pakistan";
            listOfCountry.Add(Country1);
            ADD_EmployeeModel Country2 = new ADD_EmployeeModel();
            Country2.Country_Id = 3;
            Country2.Country_Name = "China";
            listOfCountry.Add(Country2);
            ADD_EmployeeModel Country3 = new ADD_EmployeeModel();
            Country3.Country_Id = 4;
            Country3.Country_Name = "Nepal";
            listOfCountry.Add(Country3);
            ADD_EmployeeModel Country4 = new ADD_EmployeeModel();
            Country4.Country_Id = 5;
            Country4.Country_Name = "USA";
            listOfCountry.Add(Country4);
            ADD_EmployeeModel Country5 = new ADD_EmployeeModel();
            Country5.Country_Id = 6;
            Country5.Country_Name = "UK";
            listOfCountry.Add(Country5);
            ADD_EmployeeModel Country6 = new ADD_EmployeeModel();
            Country6.Country_Id = 7;
            Country6.Country_Name = "Russia";
            listOfCountry.Add(Country6);
            ADD_EmployeeModel Country7 = new ADD_EmployeeModel();
            Country7.Country_Id = 8;
            Country7.Country_Name = "Australia";
            listOfCountry.Add(Country7);
            return listOfCountry;


        }
    }
}
