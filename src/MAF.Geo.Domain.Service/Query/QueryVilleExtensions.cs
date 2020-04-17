using System;

namespace MAF.Geo.Domain.Service
{
    public static class QueryVilleExtensions
    {
        public static QueryVille WithCodePostal(this QueryVille query, string codePostal)
        {
            if (query == null)
            {
                throw new ArgumentNullException(nameof(query));
            }

            query.CodePostal = codePostal;
            return query;
        }

        public static QueryVille WithCodeInsee(this QueryVille query, string codeInsee)
        {
            if (query == null)
            {
                throw new ArgumentNullException(nameof(query));
            }

            query.CodeInsee = codeInsee;
            return query;
        }

        public static QueryVille WithAutoComplete(this QueryVille query, string autocomplete)
        {
            if (query == null)
            {
                throw new ArgumentNullException(nameof(query));
            }

            query.AutoComplete = autocomplete;
            return query;
        }
    }
}
