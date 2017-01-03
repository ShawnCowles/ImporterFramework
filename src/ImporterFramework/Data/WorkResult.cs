namespace ImporterFramework.Data
{
    public class WorkResult
    {
        public bool Success { get; private set; }
        
        public string Name { get; private set; }
        
        public string Message { get; private set; }
        
        public WorkResult(string name, bool success, string message)
        {
            Name = name;
            Success = success;
            Message = message;
        }
        
        public override string ToString()
        {
            if (Success)
            {
                return "Pass: " + Name;
            }

            return "FAILED: " + Name;
        }
    }
}
