using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class Member
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int MembershipId { get; set; }
        public List<Book> BorrowedBooks { get; set; }

        public Member(string firstName, string lastName, int membershipId)
        {
            FirstName = firstName;
            LastName = lastName;
            MembershipId = membershipId;
            BorrowedBooks = new List<Book>();
        }
    }
}
