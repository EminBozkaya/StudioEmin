namespace PhotoEmin.Model
{
    public class RecordStatus
    {
        public int totalInserts { get; set; } = 0;
        public int successfulInserts { get; set; } = 0;
        public List<string> duplicateRecords { get; set; } = new List<string>();
        public List<string> errorFullNames { get; set; } = new List<string>();
        public List<string> noImageRecords { get; set; } = new List<string>();
        public List<string> faultyImageRecords { get; set; } = new List<string>();
    }
}
