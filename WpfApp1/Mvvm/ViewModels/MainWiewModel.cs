

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using WpfApp1.Mvvm.Models;

namespace WpfApp1.Mvvm.ViewModels;

public partial class MainWiewModel : ObservableObject
{




    [ObservableProperty]
    private Contact contactForm = new();

    [ObservableProperty]
    private ObservableCollection<Contact> contactList = [];
    [RelayCommand]
    public void AddContactToList()
    {
        if (!string.IsNullOrWhiteSpace(ContactForm.FirstName) && string.IsNullOrWhiteSpace(ContactForm.LastName)) 
        {
            ContactList.Add(ContactForm);
            ContactForm = new();
        }
    }
}