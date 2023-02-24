using System;
using Repository.UserRepository;
using Model.UserModel;

namespace Service.UserService
{
    public class OnDutyService : IOnDutyService
    {
        private static OnDutyService instance { get; set; }
        private OnDutyRepository onDutyRepository { get; set; }

        public static OnDutyService GetInstance(OnDutyRepository onDutyRepository)
        {
            if (instance == null)
            {
                instance = new OnDutyService(onDutyRepository);
            }
            return instance;
        }

        private OnDutyService(OnDutyRepository onDutyRepository)
        {
            this.onDutyRepository = onDutyRepository;
        }

        public object Add(object obj)
        {
            return onDutyRepository.Add(obj);
        }

        public object Edit(object obj)
        {
            return onDutyRepository.Edit(obj);
        }

        public object Delete(object obj)
        {
            return onDutyRepository.Delete(obj);
        }
    }
}