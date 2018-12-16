using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace adv.ecommerce.project.Models
{
    public class Workout_plan
    {
        public int NumberOfWorkOutsPerWeek { get; set; }
        public string TypeOfWorkout { get; set; }
        public int FitnessCourseId { get; set; }
        public List<Fitness_course> FitnessCoursesList { get; set; }
    }
}
