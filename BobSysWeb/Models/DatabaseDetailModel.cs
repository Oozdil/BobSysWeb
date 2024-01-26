namespace BobSysWeb.Models
{
    public class DatabaseDetailModel
    {
        public string? zip { get; set; }
        public string? city { get; set; }
        public string? state { get; set; }
        public string? employmentType { get; set; }
        public string publicDescription { get; set; }
        public string? title { get; set; }
        public double? salary { get; set; }
        public string? salaryUnit { get; set; }
        public bool? isOpen { get; set; }
        public bool? isDeleted { get; set; }
        public long? dateLastPublished { get; set; }
        public int? isPublic { get; set; }
        public int? id { get; set; }
        public int? weMatchid { get; set; }
        public string? name { get; set; }

        //Extra feauters
        public bool? isActive { get; set; }
        public bool? isFav { get; set; }
    }
}
