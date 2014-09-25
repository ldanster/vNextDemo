using System.Collections.Generic;

namespace ConsoleApp1 {

  public class PhoneBook {

    public PhoneBook() {
      contacts = new List<Contact>();
    }

    private List<Contact> contacts;

    public void AddContact(string name, string surname, string phoneNumber) {
      contacts.Add(new Contact() { Name=name, Surname=surname, PhoneNumber=phoneNumber});
    }

    public string DisplayContacts() {
      string names = "";
      foreach (Contact contact in contacts) {
        names += contact.Name + " " + contact.Surname + " - " + contact.PhoneNumber +"\n";
      }
      return names;
    }

  }


}