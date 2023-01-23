namespace Strategy.Pattern
{
    public class CrucialService
    {
        public ILogger? Logger { get; set; }

        public void DoCrucialStuff(ILogger strategy) 
        {
            try
            {
                throw new Exception("CRUCIAL STUFF EPIC FAILURE.");
            }
            catch (Exception ex)
            {
                strategy?.LogMessage($"Crucial service failed --- {ex.Message}");
            }
        }

        public void DoCrucialStuff()
        {
            try
            {
                throw new Exception("CRUCIAL STUFF EPIC FAILURE.");
            }
            catch (Exception ex)
            {
                Logger?.LogMessage($"Crucial service failed --- {ex.Message}");
            }
        }
    }
}
