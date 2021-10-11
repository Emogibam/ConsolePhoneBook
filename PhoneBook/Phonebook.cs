using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    public class Phonebook
    {
        private List<Contact> contacts = new List<Contact>();

        public void AddContact(Contact contact)
        {
            contacts.Add(contact);
        }

        public void DisplayContact(string number)
        {
            Contact contact = contacts.FirstOrDefault(x => x.Number == number);

            if(contact == null)
            {
                Console.WriteLine("COntact not found");
            }
            else
            {
                Display(contact);
            }

        }

        public void DisplayAllContacts()
        {
            foreach(Contact contact in contacts)
            {
                Display(contact);
            }
        }

        public void DisplayMatchingContacts(string searchPhrase)
        {
            List<Contact> matchingContact = contacts.Where(x => x.Name.Contains(searchPhrase)).ToList();

            foreach(Contact contact in matchingContact)
            {
                Display(contact);
            }
        }


        private void Display(Contact contact)
        {
            Console.WriteLine($"Contact Name: {contact.Name} \n Contact Number{contact.Number}");
        }
    }
}
