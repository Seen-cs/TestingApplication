using Businiess.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Businiess.Concrete
{
    public class QuestionToAddManager : IQuestionToAddService
    {
        IQuestionToAddDal _questionToAdd;
        public QuestionToAddManager(IQuestionToAddDal questionToAddDal)
        {
            _questionToAdd = questionToAddDal;
        }
        public IResult Add(QuestionToAdd questionToAdd)
        {
            _questionToAdd.Add(questionToAdd);
            return new SuccessResult();
        }

        public IResult Delete(QuestionToAdd questionToAdd)
        {
            _questionToAdd.Delete(questionToAdd);
            return new SuccessResult();
        }

        public IDataResult<List<QuestionToAdd>> GetAll()
        {
            return new SuccessDataResult<List<QuestionToAdd>>(_questionToAdd.GetAll());
        }

        public IDataResult<QuestionToAdd> GetQuestionsById(int Id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<QuestionToAdd> GetQuestionToAddWithQuestionText(string questionText)
        {
            return new SuccessDataResult <QuestionToAdd>( _questionToAdd.Get(p => p.QuestionText == questionText));
        }

        public IResult Update(QuestionToAdd questionToAdd)
        {
            _questionToAdd.Update(questionToAdd);
            return new SuccessResult();
        }
    }
}
