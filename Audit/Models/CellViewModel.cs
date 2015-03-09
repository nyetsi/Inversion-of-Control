using System.ComponentModel.DataAnnotations;
using Audit.Data.DataModel;

namespace Audit.Web.Models
{
    public class CellViewModel
    {
        public string ID { get; set; }
        [Display(Name = "Operation")]
        [DataType(DataType.Text)]
        [Required]
        public string Name { get; set; }
        public string Department { get; set; }
        public string DepartmentID { get; set; }
        [Display(Name = "Code")]
        [DataType(DataType.Text)]
        [Required]
        public string Code { get; set; }
        public string Company { get; set; }

       [Required(ErrorMessage = "Please select atleast one cell")]
        public bool IsSelected { get; set; }

        public CellViewModel()
        {

        }

        public CellViewModel(Cell cellEntity)
        {
            ID = cellEntity.ID.ToString();
            Name = cellEntity.Name;
        }
    }
}
