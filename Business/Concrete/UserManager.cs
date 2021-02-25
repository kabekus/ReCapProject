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
        public IResult Add(Users user)
        {
            _ıuserDal.Add(user);
            return new SuccessResult(Messages.AddingComplete);
        }

        public IResult Delete(Users user)
        {
            return new SuccessResult(Messages.DeletingComplete);
        }
    

        public IDataResult<List<Users>> GetAll()
        {
            return new SuccessDataResult<List<Users>>(_ıuserDal.GetAll());
        }

        public IDataResult<Users> GetByUserId(int id)
        {
            return new SuccessDataResult<Users>(_ıuserDal.Get(u=>u.UserId==id));
        }

        public IResult Update(Users user)
        {
            _ıuserDal.Equals(user);
            return new SuccessResult(Messages.UpdatingComplete);
        }
    }
}
