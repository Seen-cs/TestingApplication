using Businiess.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.DTOs;
using Entity.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace Businiess.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;
        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }
        public IResult Add(User user)
        {
            _userDal.Add(user);
            return new SuccessResult();
        }

        public IResult Delete(User user)
        {
            _userDal.Delete(user);
            return new SuccessResult();
        }

        public IDataResult<List<User>> GetAll()
        {
            if (_userDal.GetAll()==null)
            {
                return new ErrorDataResult<List<User>>();
            }
            return new SuccessDataResult<List<User>>(_userDal.GetAll());
        }

        public IDataResult<List<UserTypeDto>> GetAllUserWithUserType(int userTypeId)
        {
            return new SuccessDataResult<List<UserTypeDto>>(_userDal.GetAllUserWithUserType(userTypeId));
        }

        public IDataResult<User> GetUserWithId(int id)
        {
            return new SuccessDataResult<User>(_userDal.Get(u=>u.Id==id));
        }

        public IDataResult<User> GetUserWithUserNameAndEmail(string userName, string email)
        {
            if (_userDal.Get(u => u.UserName == userName && u.Mail == email) == null)
            {
                return new ErrorDataResult<User>();
            }
            return new SuccessDataResult<User>(_userDal.Get(u => u.UserName == userName && u.Mail == email));
        }

        public IDataResult<User> GetUserWithUserNameAndPassword(string userName, string Password)
        {
            if (_userDal.Get(u => u.UserName == userName && u.Password == Password)==null)
            {
                return new ErrorDataResult<User>();
            }
            return new SuccessDataResult<User>(_userDal.Get(u => u.UserName == userName && u.Password == Password));
        }

        public IResult Update(User user)
        {
            _userDal.Update(user);
            return new SuccessResult();
        }
        public bool UserValidation(string userName,string password)
        {
            int result = _userDal.GetAll(u => u.UserName == userName && u.Password == password).Count;
            if (result!=0)
            {
                return true; 
            }
            return false;
        }
        
    }
}
