using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViewStructure.Models;

namespace ViewStructure.ViewComponents
{
    public class WorkChartViewComponent:ViewComponent
    {
        List<WorkChart> workChart = new List<WorkChart>()
        {
            new WorkChart("Metehan",new List<bool>(){ true,true,false,true,false }),
            new WorkChart("Esma",new List<bool>(){ false,true,false,false,false }),
            new WorkChart("Hakan",new List<bool>(){ false,true,true,true,true }),
            new WorkChart("Feyza",new List<bool>(){ true,false,false,true,true }),
        };
        public IViewComponentResult Invoke()
        {
            return View(workChart);
        }
    }
}
