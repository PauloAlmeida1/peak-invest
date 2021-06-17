using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace peak_invest.Application.ViewModel
{
    public class CalculaJurosVm
    {
        [Required]
        public int parcelas { get; set; }
        [Required]
        public decimal valor { get; set; }
    }
}
