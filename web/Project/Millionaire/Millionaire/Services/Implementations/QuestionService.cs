using Millionaire.Models;
using Millionaire.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Millionaire.Services {
    public class QuestionService : IQuestionService {
        private readonly IRepository<Question> _QuestionRepository;
        public QuestionService(IRepository<Question> QuestionRepository) {
            _QuestionRepository = QuestionRepository;
        }



        public IEnumerable<Question> GetQuestion() {
            return _QuestionRepository.GetAll();
        }

        public void SaveQuestion() {
            _QuestionRepository.Save();
        }

        public void UpdateQuestion(Question question) {
            _QuestionRepository.Update(question);
        }
    }
}
