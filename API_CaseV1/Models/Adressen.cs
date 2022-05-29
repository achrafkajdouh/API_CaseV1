namespace API_CaseV1
{ 
    public class Adressen
    {
        public long Id { get; set; }
        public string? Straat { get; set; }
        public int Huisnummer { get; set; }
        public string? Postcode { get; set; }
        public string? Plaats { get; set; }
        public string? Land { get; set; }
    }
}
