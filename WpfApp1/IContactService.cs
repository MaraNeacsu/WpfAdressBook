

using WpfApp1.Mvvm.Models;

namespace WpfApp1;
public interface IContactService
{
    IEnumerable<Contact> GetContacts();
    void AddContact(Contact contact);
    void DeleteContact(Contact contact);
}

   