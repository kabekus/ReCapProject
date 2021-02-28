using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _ıuserDal;

        public UserManager(IUserDal userDal)
        {
            _ıuserDal = userDal;
        }
        public IResult Add(User user)
        {
            _ıuserDal.Add(user);
            return new SuccessResult(Messages.AddingComplete);
        }

        public IResult Delete(User user)
        {
            return new SuccessResult(Messages.DeletingComplete);
        }
    

        public IDataResult<List<User>> GetAll()
        {
            return new SuccessDataResult<List<User>>(_ıuserDal.GetAll());
        }

        public IDataResult<User> GetByUserId(int id)
        {
            return new SuccessDataResult<User>(_ıuserDal.Get(u=>u.UserId==id));
        }

        public IResult Update(User user)
        {
            _ıuserDal.Equals(user);
            return new SuccessResult(Messages.UpdatingComplete);
        }
    }
}
