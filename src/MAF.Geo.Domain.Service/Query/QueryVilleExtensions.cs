namespace MAF.Geo.Domain.Service
{
    public static class QueryVilleExtensions
    {
        public static QueryVille WithCodePostal(this QueryVille query, string codePostal)
        {
            query.CodePostal = codePostal;
            return query;
        }

        public static QueryVille WithCodeInsee(this QueryVille query, string codeInsee)
        {
            query.CodeInsee = codeInsee;
            return query;
        }

        public static QueryVille WithAutoComplete(this QueryVille query, string autocomplete)
        {
            query.AutoComplete = autocomplete;
            return query;
        }
    }
}
