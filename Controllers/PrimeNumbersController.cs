using ListPrimeNumbers.Models;
using ListPrimeNumbers.Views;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListPrimeNumbers.Controllers
{
    public class PrimeNumbersController
    {
        Display display=new Display();
        PrimeNumbers model = new PrimeNumbers();
        public PrimeNumbersController()
        {
            display.Input();
            //model.ListAllNumbers = ;
            //!!!! do tuk za IE
            
            display.ListPrimeNumbers=
            model.OnlyPrimeNumbers(display.ListAllNumbers);
        
            display.Output();
        }
    }
}
