using EmployeeManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EmployeeManagement.API.Controllers
{

    public class Register_FormController : ApiController
    {
        [HttpGet]
        public List<Register_FormModel> GetGenderList()
        { 
            List<Register_FormModel> listOfGender = new List<Register_FormModel>();
            

            Register_FormModel gen1 = new Register_FormModel();
            gen1.GenderID = 1;
            gen1.Gender = "Male";
            listOfGender.Add(gen1);

            Register_FormModel gen2 = new Register_FormModel();
            gen2.GenderID = 2;
            gen2.Gender = "Female";
            listOfGender.Add(gen2);

            return listOfGender;

            //List<Gender> objGen = new List<Gender>();
            //objGen.Add(new Gender { ID = 0, GenderName = "Select" });
            //objGen.Add(new Gender { ID = 1, GenderName = "Male" });
            //objGen.Add(new Gender { ID = 2, GenderName = "Female" });

            //return objGen;

        }


    }
}
