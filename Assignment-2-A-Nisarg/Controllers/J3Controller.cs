using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment_2_A_Nisarg.Controllers
{

    //BONUS QUESTION
    //ProblemJ3:Cell-PhoneMessaging
    //This code gives incorrect output
    public class J3Controller : ApiController
    {
        /// <summary>
        /// Calculate the minimal number of seconds needed to type the word
        /// </summary>
        /// <param name="text">string of characters</param>
        /// <returns>minimal number of seconds needed to type the word</returns>
        /// <example>
        ///     GET: /api/j3/minimalTime/dada   -> 4 
        /// </example>
        [HttpGet]
        [Route("api/J3/minimalTime/{text}")]
        public int minimalTime(string text)
        {
            int time = 0;


            for (int i = 0; i < text.Length; i++)
            {
                //The first character in all the buttons
                if (text.IndexOf("adgjmptw", i) > 0)
                {

                    time = time + 1;
                }
                //The second character in all the buttons
                else if (text.IndexOf("behknqux", i) > 0)
                {
                    time = time + 2;
                }
                //The third character in all the buttons
                else if (text.IndexOf("cfilorvy", i) > 0)
                {
                    time = time + 3;
                }
                ////The first character the buttons
                else if (text.IndexOf("sz", i) > 0)
                {
                    time = time + 4;
                }

            }

            return time;

        }

    }
}
