using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MovieReviews.Models
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        [Key]
        public Guid UserId { get; set; }
        public List<Account> Accounts { get; set; }

        public User(string firstName, string lastName, string phone, Guid userId)
        {
            FirstName = firstName;
            LastName = lastName;
            Phone = phone;
            UserId = userId;
        }
        public User()
        {

        }

        public void AddAccount(Account account)
        {
            Accounts.Add(account);
        }

        public void RemoveAccount(Guid accountId)
        {
            for(sbyte i = 0; i < Accounts.Count; i++)
            {
                if(Accounts[i].AccountId == accountId)
                {
                    Accounts.RemoveAt(i);
                    return;
                }
            }
        }

        public void UpdateAccountInfo(User user)
        {
            FirstName = user.FirstName;
            LastName = user.LastName;
            Phone = user.Phone;
        }
    }
}