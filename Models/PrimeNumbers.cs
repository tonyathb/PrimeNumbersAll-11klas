using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListPrimeNumbers.Models
{
    public class PrimeNumbers
    {
		private List<int> listAllNumbers;

		public List<int> ListAllNumbers
		{
			get { return listAllNumbers; }
			set { listAllNumbers = value; }
		}

        
        private List<int> listPrimeNumbers;

        public List<int> ListPrimeNumbers
        {
            get { return listAllNumbers; }
            set { listAllNumbers = value; }
        }


        public PrimeNumbers(List<int> listNumbers)
        {
            this.listAllNumbers = listNumbers;
        }
        public PrimeNumbers(): this(new List<int>()) { }
            
        private bool IsPrime(int number)
        {
            bool result = true;

            for (int delitel = 2; delitel < number; delitel++)
            {
                if (number % delitel == 0) //se deli!!!
                {
                    result = false;
                    break;
                }
            }
            return result;
        }

        public List<int> OnlyPrimeNumbers(List<int> numbers)
        {
            List<int> resultPrimeNumbers = new List<int>();
            foreach (int item in numbers)
            {
                if (IsPrime(item))
                {
                    resultPrimeNumbers.Add(item);
                }
            }
            return resultPrimeNumbers;
        }

    }
}
