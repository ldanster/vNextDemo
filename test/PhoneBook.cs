using System.Collections.Generic;

namespace ConsoleApp1 {

  public class PhoneBook {

    public PhoneBook() {
      contacts = new List<User>();
    }

    private List<User> contacts;

    public void AddContact(string name, string surname, string phoneNumber) {
      contacts.Add(new User() { Name=name, Surname=surname, PhoneNumber=phoneNumber});
    }

    public string DisplayContacts() {
      string names = "";
      foreach (User user in contacts) {
        names += user.Name + " " + user.Surname + " - " + user.PhoneNumber +"\n";
      }
      return names;
    }

  }


}