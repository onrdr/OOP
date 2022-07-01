using Abstract; 
using MernisServiceReference;

namespace Adapters
{
    public class MernisServiceAdapter : ICustomerCheckService
    {
        // https://tckimlik.nvi.gov.tr/Service/KPSPublic.asmx
        public bool CheckIfRealPerson(IEntity person)
        {  
            KPSPublicSoapClient client = new(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap); 

            bool isPersonReal = client.TCKimlikNoDogrula(Convert.ToInt64(person.NationalityId), person.FirstName.ToUpper(),
                person.LastName.ToUpper(), person.DateOfBirth.Year);

            return isPersonReal; 
        }
    }
}
