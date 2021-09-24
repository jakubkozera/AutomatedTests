using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xunit.Sdk;

namespace MyProject.Tests
{
    public class JsonFileData : DataAttribute
    {
        private readonly string _jsonPath;

        public JsonFileData(string jsonPath)
        {
            _jsonPath = jsonPath;
        }
        public override IEnumerable<object[]> GetData(MethodInfo testMethod)
        {
            if(testMethod == null) throw new ArgumentNullException(nameof(testMethod));

            var currectDir = Directory.GetCurrentDirectory();
            var jsonFullPath = Path.GetRelativePath(currectDir, _jsonPath);

            if (!File.Exists(jsonFullPath))
            {
                throw new ArgumentException($"Couldn't find file: {jsonFullPath}");
            }

            var jsonData = File.ReadAllText(jsonFullPath);
            var allCases = JsonConvert.DeserializeObject<IEnumerable<object[]>>(jsonData);

            return allCases;

        }
    }
}
