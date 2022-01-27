using System.Threading.Tasks;

namespace MyProject.Service
{
    public class ResultService
    {
        public BmiResult RecentOverweightResult { get; private set; }
        private readonly IResultRepository _resultRepository;

        public ResultService(IResultRepository resultRepository)
        {
            _resultRepository = resultRepository;
        }

        public void SetRecentOverweightResult(BmiResult result)
        {
            if (result.BmiClassification == BmiClassification.Overweight)
            {
                RecentOverweightResult = result;
            }
        }

        public async Task SaveUnderweightResultAsync(BmiResult result)
        {
            if (result.BmiClassification == BmiClassification.Underweight)
            {
                await _resultRepository.SaveResultAsync(result);
            }
        }
    }
}