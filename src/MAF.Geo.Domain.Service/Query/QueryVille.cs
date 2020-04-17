namespace MAF.Geo.Domain.Service
{
    public class QueryVille
    {
        public int PaysId { get; internal set; }
        public string CodePostal { get; internal set; }
        public string CodeInsee { get; internal set; }
        public string AutoComplete { get; internal set; }

        private QueryVille() { }

        public static QueryVille Create(int paysId)
        {
            return new QueryVille() { PaysId = paysId };
        }
    }
}

