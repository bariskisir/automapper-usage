using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace automapper_usage
{
    class User
    {
        public User()
        {
            this.Id = Guid.NewGuid();
            this.CreateDate = DateTime.Now;
        }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string EmailAddress { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
