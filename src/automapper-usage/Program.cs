using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace automapper_usage
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize AutoMapper
            AutoMapper.Mapper.Initialize(x => x.CreateMap<UserViewModel, User>());
            // Single Object
            UserViewModel userViewModel = new UserViewModel();
            userViewModel.Name = "Kemal";
            userViewModel.Surname = "Etikan";
            userViewModel.EmailAddress = "kemaletikan@example.com";
            // Mapping single object
            User user = AutoMapper.Mapper.Map<UserViewModel, User>(userViewModel);
            //Mapping list with custom object
            List<UserViewModel> userViewModelList = new List<UserViewModel>();
            userViewModelList.Add(userViewModel);
            List<User> userList = AutoMapper.Mapper.Map<List<UserViewModel>, List<User>>(userViewModelList);

            Console.ReadKey();
        }
    }
}
