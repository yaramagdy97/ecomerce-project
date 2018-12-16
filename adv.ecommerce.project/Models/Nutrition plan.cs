using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace adv.ecommerce.project.Models
{
    public class Nutrition_plan
    {
        public int CaloriesGoal { get; set; }
        public int ProtienGoal { get; set; }
        public int FatGoal { get; set; }
        public int CarbsGoal { get; set; }
        public int FitnessCourseId { get; set; }
        public List<Fitness_course> FitnessCoursesList { get; set; }
    }
}
