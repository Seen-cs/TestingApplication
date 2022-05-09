using Core.Utilities.Results;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Businiess.Abstract
{
    public interface IQuestionToAddService
    {
        IDataResult<List<QuestionToAdd>> GetAll();
        IResult Add(QuestionToAdd questionToAdd);
        IResult Delete(QuestionToAdd questionToAdd);
        IResult Update(QuestionToAdd questionToAdd);
        IDataResult<QuestionToAdd> GetQuestionToAddWithQuestionText(string questionText);
    }
}
