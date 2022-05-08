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
    public class EfStudentAnswerDal : EfEntityRepositoryBase<StudentAnswer, TestingApplicationContext>, IStudentAnswerDal
    {
        public List<StudentAnswerDto> GetAllStudentAnswerWithStudentIdAndQuestionUnit(int studentId, int UnitId)
        {
                using (TestingApplicationContext context = new TestingApplicationContext())
                {


                    var result = from sa in context.StudentsAnswers
                                 join q in context.Questions
                                 on sa.QuestionId equals q.Id
                                 join u in context.Units
                                 on q.UnitId equals u.UnitId
                                 where sa.StudentId==studentId
                                 where u.UnitId == UnitId
                                 select new StudentAnswerDto 
                                 {
                                     StudentId= sa.StudentId,
                                     QuestionId = q.Id,
                                     QuestionText=q.QuestionText,
                                     SigmaCount= sa.SigmaCount,
                                     UnitId=u.UnitId,
                                     UnitName=u.UnitName
                                 };
                    return result.ToList();
                }
            
        }

        public StudentAnswerDto GetStudentQuestionWithStudentIdAndQuestionId(int studentId, int questionId)
        {
            using (TestingApplicationContext context = new TestingApplicationContext())
            {


                var result = from sa in context.StudentsAnswers
                             join q in context.Questions
                             on sa.QuestionId equals q.Id
                             where sa.StudentId == studentId
                             where q.Id == questionId
                             select new StudentAnswerDto
                             {
                                 StudentId = sa.StudentId,
                                 QuestionId = q.Id,
                                 QuestionText = q.QuestionText,
                                 SigmaCount = sa.SigmaCount,
                             };
                return result.FirstOrDefault();
            }
        }
    }
}
