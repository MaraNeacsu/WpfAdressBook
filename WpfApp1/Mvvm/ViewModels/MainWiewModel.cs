

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.Windows.Input;
using WpfApp1.Mvvm.Models;

namespace WpfApp1.Mvvm.ViewModels
{
    // MainViewModel is the primary ViewModel for the WPF application.
    // It holds the collection of contacts and manages the operations like adding and deleting contacts.
    public class MainViewModel
    {
        // Observable collection to hold and track changes in the contact list.
        public ObservableCollection<ContactModel> Contacts { get; set; }

        // The current contact being edited or added.
        public ContactModel CurrentContact { get; set; }

        // ICommand implementations for Add and Delete operations.
        public ICommand AddContactCommand { get; set; }
        public ICommand DeleteContactCommand { get; set; }

        // Constructor for MainViewModel.
        public MainViewModel()
        {
            // Initialize the Contacts collection and the CurrentContact object.
            Contacts = new ObservableCollection<ContactModel>();
            CurrentContact = new ContactModel();

            // Initialize the commands with their respective execution and can-execute logic.
            AddContactCommand = new RelayCommand(AddContact, CanAddContact);
            DeleteContactCommand = new RelayCommand(DeleteContact, CanDeleteContact);
        }

        // Method to add a new contact to the Contacts collection.
        private void AddContact()
        {
            Contacts.Add(CurrentContact);
            // Reset CurrentContact to be ready for a new entry.
            CurrentContact = new ContactModel();
        }

        // Method to determine if a new contact can be added.
        // Returns true if both FirstName and LastName are not empty or whitespace.
        private bool CanAddContact()
        {
            // Validate that the current contact has both a first and last name.
            return !string.IsNullOrWhiteSpace(CurrentContact.FirstName)
                && !string.IsNullOrWhiteSpace(CurrentContact.LastName);
        }

        // Method to delete the currently selected contact from the Contacts collection.
        private void DeleteContact()
        {
            if (Contacts.Contains(CurrentContact))
            {
                Contacts.Remove(CurrentContact);
                // Reset CurrentContact after deletion.
                CurrentContact = new ContactModel();
            }
        }

        // Method to determine if the current contact can be deleted.
        // Returns true if the current contact is in the Contacts collection.
        private bool CanDeleteContact()
        {
            return Contacts.Contains(CurrentContact);
        }
    }
}
