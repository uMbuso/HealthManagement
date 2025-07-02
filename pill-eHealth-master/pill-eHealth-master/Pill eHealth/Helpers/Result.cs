namespace Pill_eHealth.Helpers
{
    public class Result
    {
        public enum ResultTypes { Success,Error};
        public ResultTypes ResultType;
        public string Message;
    }
}
