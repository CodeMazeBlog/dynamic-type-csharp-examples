using DynamicTypeExamples.Models;

namespace DynamicTypeExamples.Factories
{
    public class LoggerFactory
    {
        public static Logger GetLogger()
        {
            return new Logger();
        }
    }
}