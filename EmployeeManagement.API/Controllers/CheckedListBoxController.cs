using EmployeeManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EmployeeManagement.API.Controllers
{
    public class CheckedListBoxController : ApiController
    {
        [HttpGet]
        public List<CheckedListBoxModel> GetCheckedListBox()
        {
            List<CheckedListBoxModel> listOfUser = new List<CheckedListBoxModel>();
            CheckedListBoxModel gen = new CheckedListBoxModel();
            gen.Name = 1;
            gen.Nameid = "Chirag";
            listOfUser.Add(gen);

            CheckedListBoxModel gen1 = new CheckedListBoxModel();
            gen1.Name = 2;
            gen1.Nameid = "Sahu";
            listOfUser.Add(gen1);

            CheckedListBoxModel gen2 = new CheckedListBoxModel();
            gen2.Name = 3;
            gen2.Nameid = "Abhishek";
            listOfUser.Add(gen2);

            return listOfUser;

        }
    }
}
