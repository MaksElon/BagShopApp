using MyOwnApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyOwnApp.Data.Interfaces
{
    public interface IMaterials
    {
        IEnumerable<Material> GetMaterials { get; set; }
        bool DeleteMaterial(int id);
        bool AddMaterial(Material material);
    }
}
