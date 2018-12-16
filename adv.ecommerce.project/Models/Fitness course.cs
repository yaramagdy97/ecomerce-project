using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace adv.ecommerce.project.Models
{
    public class Fitness_course
    {
        public int WeeklyGoal { get; set; }
        public int TargetWeight { get; set; }
        public string ActivityLevel { get; set; }
        public int FitnessCourseId { get; set; }
        public string UserName { get; set; }
        public List<User> users { get; set; }
        public List<Workout_plan> WorkoutPlansList { get; set; }
        public List<Nutrition_plan> NutritionPlansList { get; set; }
    }
}
