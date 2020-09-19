using LoginEditWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace LoginEditWebsite.ViewModels
{
    public class PersonViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Password { get; set; }
        public string LastLogin { get; set; }
    }

    public class PersonListViewModel
    {
        public List<PersonViewModel> Person { get; set; }
        internal LoginDBContext _context;

        internal void PopulatePerson(int id)
        {
            Person = (from a in _context.Person
                        where a.Id == id
                        select new PersonViewModel()
                        {
                            Id = a.Id,
                            Name = a.Name,
                            Surname = a.Surname,
                            Password = a.Password,
                            LastLogin = a.LastLogin.ToString()
                        }).ToList();
        }
    }
}
