using Model.UserModel;
using Service.UserService;
using System;

namespace Controller.UserController
{
    public class GuestUserController : IGuestUserController
    {
        private static GuestUserController instance { get; set; }
        private GuestUserService guestUserService { get; set; }

        public static GuestUserController GetInstance(GuestUserService guestUserService)
        {
            if (instance == null)
            {
                instance = new GuestUserController(guestUserService);
            }
            return instance;
        }

        private GuestUserController(GuestUserService guestUserService)
        {
            this.guestUserService = guestUserService;
        }

        public object Add(object obj)
        {
            return guestUserService.Add(obj);
        }

        public object Edit(object obj)
        {
            return guestUserService.Edit(obj);
        }

        public object Delete(object obj)
        {
            return guestUserService.Delete(obj);
        }
    }
}