

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.Windows.Input;
using WpfApp1.Mvvm.Models;

// ViewModels/MainViewModel.cs



namespace WpfApp1.Mvvm.ViewModels
{
    public class MainViewModel
    {
        public ObservableCollection<ContactModel> Contacts { get; set; }

        public ContactModel CurrentContact { get; set; }

        public ICommand AddContactCommand { get; set; }
        public ICommand DeleteContactCommand { get; set; }

        public MainViewModel()
        {
            Contacts = new ObservableCollection<ContactModel>();
            CurrentContact = new ContactModel();

            AddContactCommand = new RelayCommand(AddContact, CanAddContact);
            DeleteContactCommand = new RelayCommand(DeleteContact, CanDeleteContact);
        }

        private void AddContact()
        {
            Contacts.Add(CurrentContact);
            CurrentContact = new ContactModel();
        }

        private bool CanAddContact()
        {
            // You can implement validation logic here
            return !string.IsNullOrWhiteSpace(CurrentContact.FirstName)
                && !string.IsNullOrWhiteSpace(CurrentContact.LastName);
        }

        private void DeleteContact()
        {
            if (Contacts.Contains(CurrentContact))
            {
                Contacts.Remove(CurrentContact);
                CurrentContact = new ContactModel();
            }
        }

        private bool CanDeleteContact()
        {
            return Contacts.Contains(CurrentContact);
        }
    }
}
