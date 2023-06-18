using System.ComponentModel.DataAnnotations;

namespace MetalixDemoErp.Entitiy
{
    public class Company
    {
        [Key]
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }

        public string CompanyCity { get; set; }

        public List<DangilNo> DangilNo { get; set; }

    }
}
