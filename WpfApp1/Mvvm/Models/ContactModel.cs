

namespace WpfApp1.Mvvm.Models
{
    // ContactModel class represents the data structure for a contact in the address book.
    public class ContactModel
    {
        // Unique identifier for each contact.
        // Automatically generated when a new instance of ContactModel is created.
        public Guid Id { get; set; } = Guid.NewGuid();

        // First name of the contact.
        // The 'null!' syntax is used to indicate that these properties should not be null,
        // but they are not initialized in the constructor.
        public string FirstName { get; set; } = null!;

        // Last name of the contact.
        public string LastName { get; set; } = null!;

        // Email address of the contact.
        public string Email { get; set; } = null!;

        // Phone number of the contact.
        public string PhoneNumber { get; set; } = null!;

        //  Address of the contact.
        public string Address { get; set; } = null!;
    }
}
