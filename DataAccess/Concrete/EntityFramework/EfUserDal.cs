using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.DTOs;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, TestingApplicationContext>, IUserDal
    {
        public List<UserTypeDto> GetAllUserWithUserType(int userTypeId)
        {
            using (TestingApplicationContext context = new TestingApplicationContext())
            {
                var result = from ut in context.UserTypes
                             join u in context.Users
                             on ut.UserTypeId equals u.UserTypeId
                             where ut.UserTypeId == userTypeId
                             select new UserTypeDto
                             {
                                 UserId = u.Id,
                                 UserName = u.UserName,
                                 Password= u.Password,
                                 UserTypeName = ut.UserTypeName
                             };
                return result.ToList();

            }
        }
    }
}
