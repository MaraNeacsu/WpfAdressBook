﻿using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace WpfApp1.Mvvm.Models
{
    public class ContactService : IContactService
    {
        private List<Contact> contacts;

        public ContactService()
        {
            // Initialize contacts list
            contacts = new List<Contact>();
        }

        public IEnumerable<Contact> GetContacts()
        {
            return contacts;
        }

        public void AddContact(Contact contact)
        {
            // Implement logic to check for duplicates, validations, etc., if needed
            contacts.Add(contact);
        }

        public void DeleteContact(Contact contact)
        {
            contacts.Remove(contact);
        }

        public void SaveContactsToJson(string filePath)
        {
            string json = JsonConvert.SerializeObject(contacts, Formatting.Indented);
            File.WriteAllText(filePath, json);
        }

        public void LoadContactsFromJson(string filePath)
        {
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                contacts = JsonConvert.DeserializeObject<List<Contact>>(json);
            }
        }
    }
}


