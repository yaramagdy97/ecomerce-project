using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace adv.ecommerce.project.Models
{
    public class User
    {
        public string Name { get; set; }
        public int Password { get; set; }
        public string Email { get; set; }
        public string PersonalInfo { get; set; }
        public Fitness_course FitnessCourse { get; set; }
    }
}
