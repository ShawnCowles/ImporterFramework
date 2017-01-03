namespace ImporterFramework.Data
{
    public abstract class ImportContext
    {
        public string ImportPath { get; private set; }
        
        public string ExportPath { get; private set; }
        
        protected ImportContext(string importPath, string exportPath)
        {
            ImportPath = importPath;
            ExportPath = exportPath;
        }
    }
}
