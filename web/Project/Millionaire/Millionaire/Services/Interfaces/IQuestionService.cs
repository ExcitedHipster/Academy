using Millionaire.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Millionaire.Services.Interfaces {
    public interface IQuestionService {
        IEnumerable<Question> GetQuestion();

        void UpdateQuestion(Question question);

        void SaveQuestion();
    }
}
