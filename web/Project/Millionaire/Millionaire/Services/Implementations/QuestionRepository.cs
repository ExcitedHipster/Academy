using Millionaire.Models;
using Millionaire.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Millionaire.Services.Implementations {
    public class QuestionRepository : IRepository<Question> {
        public static string FilePath = @"questions.txt";
        public static List<string> fileData = ReadFromFile();
        private static List<Question> _questions = readQuestions();

        public static List<Question> readQuestions()
        {
            fileData = ReadFromFile();
           List<Question> questions = new List<Question>();
            
            for(int i = 0; i <= 5; i++)
            {
                Question question = new Question
                {
                    Id = i+1,
                    QuestionContent = fileData[i*5],
                    Answers = new List<Answer>()
                    {
                        new Answer{IsRight=true,AnswerContent=fileData[i*5+1]},
                        new Answer{IsRight=false,AnswerContent=fileData[i*5+2]},
                        new Answer{IsRight=false,AnswerContent=fileData[i*5+3]},
                        new Answer{IsRight=false,AnswerContent=fileData[i*5+4]}
                    }
                };
                questions.Add(question);
            }
            _questions = questions;
            return questions;
        } 

        public void Add(Question item) {
            throw new NotImplementedException();
        }


        public IEnumerable<Question> GetAll() {
            return _questions;
        }

        public void Update(Question item) {
            var question = _questions.SingleOrDefault(x => x.Id == item.Id);

            var index = _questions.IndexOf(question);

            _questions[index].Answers = item.Answers;
            _questions[index].QuestionContent = item.QuestionContent;
            fileData = ReadFromFile();
            Save();
        }

        public void Save() {
            File.Delete(FilePath);
            foreach (var item in _questions) {

                SaveData(item.QuestionContent);

                for (int i = 0; i < item.Answers.Count; i++) {
                    SaveData(item.Answers[i].AnswerContent);
                }          
              
            }
        }

        public static void SaveData(string data) {
            data += "\n";
            using var fstream = new FileStream(FilePath, FileMode.Append, FileAccess.Write);
            var bytes = System.Text.Encoding.Default.GetBytes(data);
            fstream.Write(bytes, 0, bytes.Length);
        }

        public static List<string> ReadFromFile() {
            string fromFile = ReadData();
            List <string> fileData = fromFile.Split("\n").ToList();
            return fileData;
        }
        public static string ReadData() {
            using var fStream = File.OpenRead(FilePath);
            var bytes = new byte[fStream.Length];
            fStream.Read(bytes, 0, bytes.Length);
            string data = System.Text.Encoding.Default.GetString(bytes);
            return data;
        }

        public static void Randomize(Question question) {
            for (int k = 1; k <= 1000; k++) {
                Random rnd = new Random();
                int first = rnd.Next(0, 4), second = rnd.Next(0, 4);
                (question.Answers[first], question.Answers[second]) = (question.Answers[second], question.Answers[first]);
            }
        }

        

    }
}
