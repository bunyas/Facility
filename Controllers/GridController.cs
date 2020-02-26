using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Syncfusion.JavaScript;
using System.ComponentModel.DataAnnotations;
using System.Collections;
using Syncfusion.JavaScript.DataSources;
using Syncfusion.Linq;
namespace SyncfusionASPNETCoreApplication2.Controllers
{
    public partial class GridController : Controller
    {
        public ActionResult DataSource([FromBody]DataManager dm)
        {
            IEnumerable data = "";
            DataOperations operation = new DataOperations();
            if (dm.Sorted != null && dm.Sorted.Count > 0) //Sorting
            {
                data = operation.PerformSorting(data, dm.Sorted);
            }
            if (dm.Where != null && dm.Where.Count > 0) //Filtering
            {
                data = operation.PerformWhereFilter(data, dm.Where, dm.Where[0].Operator);
            }
            if (dm.Search != null && dm.Search.Count > 0) //Searching
            {
                data = operation.PerformSearching(data, dm.Search);
            }
            var count = data.AsQueryable().Count();
            if (dm.Skip != 0)
            {
                data = operation.PerformSkip(data, dm.Skip);
            }
            if (dm.Take != 0)
            {
                data = operation.PerformTake(data, dm.Take);
            }
            return Json(new { result = data, count = count });
        }
      
        public ActionResult GridFeatures()
        {
            return View();
        }
       
    }
}
