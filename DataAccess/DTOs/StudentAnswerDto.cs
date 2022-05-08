using Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.DTOs
{
    public class StudentAnswerDto:IDto
    {
        public int StudentId { get; set; }
        public int QuestionId { get; set; }
        public string QuestionText { get; set; }
        public int SigmaCount { get; set; }
        public int UnitId { get; set; }
        public string UnitName { get; set; }

    }
}
