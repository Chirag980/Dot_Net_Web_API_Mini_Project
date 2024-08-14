using EmployeeManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;



//CONTROLLER: CONTROLLER CONTAIN BUSINESS LOGIC AND PROVIDE LINK BEWTWEEN MODEL AND VIEW
namespace EmployeeManagement.API.Controllers
{
    public class StateController : ApiController
    {
        [HttpGet]
        public List<StateModel> GetStateList()
        {
            List<StateModel> listOfUser = new List<StateModel>();
            StateModel st = new StateModel();
            st.StateID = 1;
            st.State = "Select";
            listOfUser.Add(st);

            StateModel st1 = new StateModel();
            st1.StateID = 2;
            st1.State = "Maharashtra";
            listOfUser.Add(st1);

            StateModel st2 = new StateModel();
            st2.StateID = 3;
            st2.State = "Chhattisgarh";
            listOfUser.Add(st2);

            StateModel st16 = new StateModel();
            st16.StateID = 4;
            st16.State = "Andhra Pradesh";
            listOfUser.Add(st16);

            StateModel st3 = new StateModel();
            st3.StateID = 2;
            st3.State = "Delhi";
            listOfUser.Add(st3);

            StateModel st4 = new StateModel();
            st4.StateID = 3;
            st4.State = "Assam";
            listOfUser.Add(st4);

            StateModel st5 = new StateModel();
            st5.StateID = 4;
            st5.State = "Bihar";
            listOfUser.Add(st5);

            StateModel st6 = new StateModel();
            st6.StateID = 5;
            st6.State = "Andhra Pradesh";
            listOfUser.Add(st6);


            StateModel st7 = new StateModel();
            st7.StateID = 6;
            st7.State = "Goa";
            listOfUser.Add(st7);

            StateModel st8 = new StateModel();
            st8.StateID = 7;
            st8.State = "Gujrat";
            listOfUser.Add(st8);

            StateModel st9 = new StateModel();
            st9.StateID = 8;
            st9.State = "Haryana";
            listOfUser.Add(st9);

            StateModel st10 = new StateModel();
            st10.StateID = 9;
            st10.State = "Himanchal Pardesh";
            listOfUser.Add(st10);

            StateModel st11 = new StateModel();
            st11.StateID = 10;
            st11.State = "Jharkhand";
            listOfUser.Add(st11);

            StateModel st12 = new StateModel();
            st12.StateID = 11;
            st12.State = "Karnataka";
            listOfUser.Add(st12);

            StateModel st13 = new StateModel();
            st13.StateID = 12;
            st13.State = "Kerala";
            listOfUser.Add(st13);

            StateModel st14 = new StateModel();
            st14.StateID = 13;
            st14.State = "Madhya Pradesh";
            listOfUser.Add(st14);

            StateModel st15 = new StateModel();
            st15.StateID = 14;
            st15.State = "Arunachal Pradesh";
            listOfUser.Add(st15);

            return listOfUser;

            //List<UserAddModel> listOfUser = new List<UserAddModel>();
            //UserAddModel User = new UserAddModel();
            
            //User.User_EmailID = 1;
            //User.User_FirstName = "Chirag";
            //User.User_LastName = "Sahu";
            //User.User_Password = "123";
            //User.User_ConfirmPassword = "123";
            //listOfUser.Add(User);
            //UserAddModel User1 = new UserAddModel();
            //User1.User_EmailID = 2;
            //User1.User_FirstName = "Chirag";
            //User1.User_LastName = "Sahu";
            //User1.User_Password = "123";
            //User1.User_ConfirmPassword = "123";
            //listOfUser.Add(User);
            //return listOfUser;

        }
    }
}
