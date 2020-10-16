using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment_2_A_Nisarg.Controllers
{
   
    public class J3Controller : ApiController
    {
        [HttpGet]
        [Route("api/{J3}/{minimalTime}/{text}")]
        public int minimalTime(string text)
        {
            int time = 0;

            for(int i=0; i<text.Length; i++)
            {
                if(text.IndexOf("adgjmptw", 0) >0) {

                    time = time + 1;
                }
                else if(text.IndexOf("behknqux", 0) > 0)
                {
                    time = time + 2;
                }
                else if (text.IndexOf("cfilorvy", 0) > 0)
                {
                    time = time + 3;
                }
                else if (text.IndexOf("sz", 0) > 0)
                {
                    time = time + 4;
                }

            }

            return time;

        }

    }
}
