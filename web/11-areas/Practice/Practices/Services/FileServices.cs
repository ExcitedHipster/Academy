using Practices.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices.Services
{
    public class FileServices : IFileServices
    {
        public string GetFile()
        {
            string FileContents = File.ReadAllText("AccountInfo.txt");
            return FileContents;
        }

        public void SaveToFile(AccountInfo account)
        {
            var sBuilder = new StringBuilder();

            sBuilder.AppendFormat("ClientID: {0},\t UserName: {1},\t Password: {2},\t CodeQuestion: {3},\t CodeAnswer: {4}\n",
                account.ClientId,
                account.UserName,
                account.Password,
                account.CodeQuestion,
                account.CodeAnswear                
                );
            File.WriteAllText("AccountInfo.txt", sBuilder.ToString());
        }
    }
}
