using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MetalixDemoErp.Entitiy
{
    public class Company
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }

        public string CompanyCity { get; set; }

        public List<DangilNo> DangilNo { get; set; }

       

    }
}
