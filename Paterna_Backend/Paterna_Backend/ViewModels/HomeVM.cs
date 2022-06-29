using Paterna_Backend.Models;
using System.Collections.Generic;

namespace Paterna_Backend.ViewModels
{
    public class HomeVM
    {
        public PageIntro PageIntro { get; set; }
        public Services Services { get; set; }
        public IEnumerable<ServicesCard> servicesCard { get; set; }  
        public Plan Plan { get; set; }
        public IEnumerable<PlanCard> planCards { get; set; }
    }
}
