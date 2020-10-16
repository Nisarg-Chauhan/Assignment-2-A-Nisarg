using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

//ProblemJ1:TheNewCCC(CanadianCalorieCounting)

namespace Assignment_2_A_Nisarg.Controllers
{
    public class J1Controller : ApiController
    {
        /// <summary>
        /// Count total calories
        /// </summary>
        /// <param name="burger">Burger Choice</param>
        /// <param name="drink">Drink Choice</param>
        /// <param name="side">Side Choice</param>
        /// <param name="dessert">Dessert Choice</param>
        /// <returns>Total calories of the meal</returns>
        /// <example>
        ///     GET: /api/J1/Menu/1/2/3/4    -> Your total calorie count is 691 
        /// </example>
        [HttpGet]
        [Route("api/J1/menu/{burger}/{drink}/{side}/{dessert}")]
        public string menu(int burger, int drink, int side, int dessert)
        {
            int totalCalories;
            string calorieCount;

            //Input validation
            if ((burger < 1 || burger > 4) || (drink < 1 || drink > 4) || (side < 1 || side > 4) || (dessert < 1 || dessert > 4))
            {
                calorieCount = "Please enter a valid choice!";
                return calorieCount;
            }

            else
            {
                if (burger == 1)
                {
                    totalCalories = 461;
                }
                else if (burger == 2)
                {
                    totalCalories = 431;
                }
                else if (burger == 3)
                {
                    totalCalories = 420;
                }
                else
                {
                    totalCalories = 0;
                }



                if (drink == 1)
                {
                    totalCalories = totalCalories + 130;
                }
                else if (drink == 2)
                {
                    totalCalories = totalCalories + 160;
                }
                else if (drink == 3)
                {
                    totalCalories = totalCalories + 118;
                }
                else
                {
                    totalCalories = totalCalories + 0;

                }


                if (side == 1)
                {
                    totalCalories = totalCalories + 100;
                }
                else if (side == 2)
                {
                    totalCalories = totalCalories + 57;
                }
                else if (side == 3)
                {
                    totalCalories = totalCalories + 70;
                }
                else
                {
                    totalCalories = totalCalories + 0;

                }


                if (dessert == 1)
                {
                    totalCalories = totalCalories + 167;
                }
                else if (dessert == 2)
                {
                    totalCalories = totalCalories + 266;
                }
                else if (dessert == 3)
                {
                    totalCalories = totalCalories + 75;
                }
                else
                {
                    totalCalories = totalCalories + 0;

                }

                calorieCount = "Your total calorie count is " + totalCalories;

                return calorieCount;
            }


        }
    }
}
