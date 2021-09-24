using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Tests
{
    public class MetricBmiCalculatorTestsData : IEnumerable<object[]>
    {
        private const string JSON_PATH = "Data/MetricBmiCalculatorData.json";
        public IEnumerator<object[]> GetEnumerator()
        {
            var currectDir = Directory.GetCurrentDirectory();
            var jsonFullPath = Path.GetRelativePath(currectDir, JSON_PATH);

            if (!File.Exists(jsonFullPath))
            {
                throw new ArgumentException($"Couldn't find file: {jsonFullPath}");
            }

            var jsonData = File.ReadAllText(jsonFullPath);
            var allCases = JsonConvert.DeserializeObject<IEnumerable<object[]>>(jsonData);

            return allCases.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
