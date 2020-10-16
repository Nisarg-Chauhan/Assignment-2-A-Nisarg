using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

//ProblemJ2: RolltheDice

namespace Assignment_2_A_Nisarg.Controllers
{
    public class J2Controller : ApiController
    {
        [HttpGet]
        [Route("api/{J2}/{diceGame}/{m}/{n}")]
        public string diceGame(int m, int n)
        {
            /*int m = 12;
            int n = 4;*/
            int noOfWays=0;
            string message;

            //Add validation - Dice should be less than 10
            for(int i=1; i<=m; i++)
            {
                for(int j= 1; j<=n; j++)
                {
                    if (i + j == 10)
                    {
                        noOfWays++;
                    }
                }
            }

            message = "There are " + noOfWays + " total ways to get the sum 10";

            return message;
        }
    }
}
