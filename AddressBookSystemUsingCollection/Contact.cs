// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Contact.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Aseem Anand"/>
// --------------------------------------------------------------------------------------------------------------------
namespace AddressBookSystemUsingCollection
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// UC 1 : CREATED CONTACT CLASS WITH PROPER REQUIRED FIELDS
    /// </summary>
    public class Contact
    {
        public string firstName;
        public string lastName;
        public string address;
        public string city;
        public string state;
        public double zip;
        public double phoneNumber;
        public string email;

        /// <summary>
        /// INITIALIZES A NEW INSTANCE OF CONTACT CLASS
        /// </summary>
        /// <param name="firstName">The first name.</param>
        /// <param name="lastName">The last name.</param>
        /// <param name="address">The address.</param>
        /// <param name="city">The city.</param>
        /// <param name="state">The state.</param>
        /// <param name="zip">The zip.</param>
        /// <param name="phoneNumber">The phone number.</param>
        /// <param name="email">The email.</param>
        public Contact(string firstName, string lastName, string address, string city, string state, double zip, double phoneNumber, string email)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.city = city;
            this.state = state;
            this.zip = zip;
            this.phoneNumber = phoneNumber;
            this.email = email;
        }
    }
}
