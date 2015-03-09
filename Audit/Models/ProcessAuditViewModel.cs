using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Audit.Data.DataModel;

namespace Audit.Web.Models
{
    public class ProcessAuditViewModel : AuditViewModel
    {

        
        public List<CellViewModel> Cells { get; set; }

        [Required(ErrorMessage = "Please select atleast one cell")]
        public object CellID { get; set; }
        public ProcessAuditViewModel()
        {
            Cells = new List<CellViewModel>();
            Type = AuditType.Process;
        }

        public void AttachCells(List<Cell> cellEntities)
        {
            foreach (var cellEntity in cellEntities)
            {
                Cells.Add(new CellViewModel(cellEntity));
            }
        }
    }
}