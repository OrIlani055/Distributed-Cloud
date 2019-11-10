using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace webapp_school.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values/GetFiveRandomNumbers
        [HttpGet("GetFiveRandomNumbers")]
        public List<int> GetFiveRandomNumbers()
        {
            var numbers = new List<int>();
            var rnd = new Random();
            int count = 0;

            while (count < 5)
            {
                int newNum = rnd.Next(1, 21); // generate a random number between 1- 20

                if (!numbers.Contains(newNum))
                {
                    numbers.Add(newNum);
                    count++;
                }
            }
            return numbers;
        }

        // GET api/values/ex15
        [HttpGet("ex15Max")]
        public int MaxNumber(List<int> nums)
        {
            return nums.Max();
        }

        // GET api/values/ex15
        [HttpGet("ex16Min")]
        public int MinNumber(List<int> nums)
        {
            return nums.Min();
        }
        [HttpGet("ex2Reverse")]
        public String reverse(String text)
        {
            return text = String.Join(" ", text.Split(' ').Reverse().ToArray());
        }
        [HttpGet("ex12Trim")]
        public String trimchar(String text)
        {
            return text = text.Substring(1, text.Length - 2);
        }
        [HttpGet("ex9NextC")]
        public String nextchar(String text)
        {
            char[] arr = text.ToCharArray();
            for(int i=0; i< arr.Length; i++)
            {
                arr[i]++;
            }
            String next = new String(arr);
            return next;
        }
    }
}