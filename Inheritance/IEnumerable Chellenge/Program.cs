using System;
using System.Collections.Generic;

namespace IEnumerablechallenge
{
    internal class Program
    {
        static public void Main(string[] args)
        {
            PhoneBook MyPhoneBook = new PhoneBook();

            foreach (Contact contact in MyPhoneBook)
            {
                contact.Call();
            }
        }
}
