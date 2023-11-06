using System.Net.Http;
using System.Web.Http;
using Testing.Models;
using Testing.Models.Services;

namespace Testing.Controllers
{
    public class ContactController : ApiController
    {

        private ContactRepository contactRepository;

        public ContactController()
        {
            this.contactRepository = new ContactRepository();
        }
        public Contact[] Get()
        {
            return this.contactRepository.GetAllContacts();
        }

        public HttpResponseMessage Post(Contact contact)
        {
            this.contactRepository.SaveContact(contact);

            var response = Request.CreateResponse<Contact>(System.Net.HttpStatusCode.Created, contact);

            return response;
        }
    }
}
