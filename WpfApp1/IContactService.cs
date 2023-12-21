

using WpfApp1.Mvvm.Models;

namespace WpfApp1;
public interface IContactService
{
    IEnumerable<ContactModel> GetContacts();
    void AddContact(ContactModel contact);
    void DeleteContact(ContactModel contact);
}

   