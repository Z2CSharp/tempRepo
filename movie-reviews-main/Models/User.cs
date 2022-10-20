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

        public void AddAccount(Account account)
        {
            Accounts.Add(account);
        }

        public void RemoveAccount(Account account)
        {
            Accounts.Remove(account);
        }

        public void UpdateAccountInfo(User user)
        {
            FirstName = user.FirstName;
            LastName = user.LastName;
            Phone = user.Phone;
        }
    }
}