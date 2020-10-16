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
        /// <summary>
        /// Determine how many times one can roll the value of 10 with two dice.
        /// </summary>
        /// <param name="m">total sides of dice1</param>
        /// <param name="n">total sides of dice 2</param>
        /// <returns>Number of ways one can roll the value of 10</returns>
        /// <example>
        ///     GET: /api/J2/DiceGame/6/8    -> There are 5 total ways to get the sum 10.
        /// </example>
        [HttpGet]
        [Route("api/J2/diceGame/{m}/{n}")]
        public string diceGame(int m, int n)
        {

            int noOfWays = 0;
            string message;

            //Input validation
            if (m < 1 || n < 1)
            {
                message = "Please enter a valid number of sides";
                return message;
            }
            else
            {
                for (int i = 1; i <= m; i++)
                {
                    for (int j = 1; j <= n; j++)
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
}
