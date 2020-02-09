using System;
using System.IO;
using Analogy.Interfaces;
using Newtonsoft.Json;

namespace Analogy.Tools
{
    internal class JsonFormatter
    {
        private readonly string _fileName;

        public JsonFormatter(string fileName)
        {
            _fileName = fileName;
        }

        //public void WriteMessage(byte[] data)
        //{
        //    this.WriteMessage(AnalogyLogMessage.Deserialize(data));
        //}

        public void WriteMessage(AnalogyLogMessage message)
        {
            string jsonMessage;
            WriteMessage(message, out jsonMessage);
        }

        public void WriteMessage(AnalogyLogMessage message, out string jsonMessage)
        {
            JsonDataContract jsonDataContract = new JsonDataContract(message);
            jsonMessage = JsonConvert.SerializeObject(jsonDataContract);
            File.AppendAllText(_fileName, jsonMessage + "\r\n");
        }
    }

    internal class JsonDataContract
    {
        public string category;
        public DateTime dateTime;
        public string fileName;
        public string host;
        public string id;
        public string level;
        public string lineNumber;
        public string logClass;
        public string method;
        public string module;
        public string processId;
        public string source;
        public string text;
        public string user;

        public JsonDataContract(AnalogyLogMessage message)
        {
            id = message.ID.ToString();
            dateTime = message.Date;
            text = message.Text;
            category = message.Category;
            source = message.Source;
            level = message.Level.ToString();
            logClass = message.Class.ToString();
            module = message.Module;
            method = message.MethodName;
            fileName = message.FileName;
            lineNumber = message.LineNumber.ToString();
            processId = message.ProcessID.ToString();
            user = message.User;
            host = Environment.MachineName;
        }
    }
}

