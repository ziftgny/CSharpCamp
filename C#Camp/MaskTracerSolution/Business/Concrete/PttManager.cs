using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PttManager : ISupplierService
    {
         IApplicantService _applicantService;
        public PttManager(IApplicantService applicantService)
        {
            _applicantService = applicantService;
        }
        public void GiveMask(Person person)
        {
           
            if(_applicantService.checkPerson(person))
            {
                Console.WriteLine("Mask has given to "+person.Name);
            }
            else
            {
                Console.WriteLine("Couldn't give the mask");
            }
        }

      
    }
}
