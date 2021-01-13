using ICities;

namespace TechFlag
{
    public class KajsTechFlag : IUserMod
    {
        public string Name
        {
            get { return "Kajs Tech Support flag replacer"; }
        }

        public string Description
        {
            get { return "Replaces the stock flags with the Kajs Tech Support Flag"; }
        }

        public string[][] CustomFlags()
        {
            return new[]
            {
                new[] {"kajstech", "Kajs Tech Support"},
            };
        }
    }
}
