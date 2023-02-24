using System;
using Service.UserService;

namespace Controller.UserController
{
    public class OnDutyController : IOnDutyController
    {
        private static OnDutyController instance { get; set; }
        private OnDutyService onDutyService { get; set; }

        public static OnDutyController GetInstance(OnDutyService onDutyService)
        {
            if (instance == null)
            {
                instance = new OnDutyController(onDutyService);
            }
            return instance;
        }

        private OnDutyController(OnDutyService onDutyService)
        {
            this.onDutyService = onDutyService;
        }

        public object Add(object obj)
        {
            return onDutyService.Add(obj);
        }

        public object Edit(object obj)
        {
            return onDutyService.Edit(obj);
        }

        public object Delete(object obj)
        {
            return onDutyService.Delete(obj);

        }
    }
}