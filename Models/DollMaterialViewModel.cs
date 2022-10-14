using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Barbie_Dolls.Models
{
    public class DollMaterialViewModel
    {
        public List<Doll> Movies { get; set; }
        public SelectList Material{ get; set; }
        public string DollMaterial{ get; set; }
        public string SearchString { get; set; }
    }
}
