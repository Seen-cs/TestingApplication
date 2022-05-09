using Core.Utilities.Results;
using DataAccess.DTOs;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Businiess.Abstract
{
    public interface IUserService
    {
        IDataResult<List<User>> GetAll();
        IDataResult<User> GetUserWithUserNameAndPassword(string userName,string Password);
        IDataResult<User> GetUserWithUserNameAndEmail(string userName, string email);
        IDataResult<List<UserTypeDto>> GetAllUserWithUserType(int userTypeId);
        IDataResult<User> GetUserWithId(int id);
        IResult Add(User user);
        IResult Delete(User user);
        IResult Update(User user);

    }
}
