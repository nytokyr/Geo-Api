namespace MAF.Geo.Domain.Model.RefMaf
{
    public class Ville
    {
        public int VilleId { get; set; }
        public int PaysId { get; set; }
        public int? RegionAdministrativeId { get; set; }
        public int? DepartementId { get; set; }
        public int? RisqueId { get; set; }
        public int NiveauSismiciteId { get; set; }
        public string CodeInsee { get; set; }
        public string CodePostal { get; set; }
        public string NomVille { get; set; }
        public string SimpleVille { get; set; }
        public decimal? Latitude { get; set; }
        public decimal? Longitude { get; set; }
    }
}
