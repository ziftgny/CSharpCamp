using Business.Abstract;
using Entities.Concrete;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PersonManager : IApplicantService
    {
        public void ApplyForMask(Person person)
        {

        }
        public List<Person> getList()
        {
            return null;
        }
        public bool checkPerson(Person person)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(
                new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody(person.NationalIdentity,person.Name,person.Surname,person.DateOfBirthYear)))
                .Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
