using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ness_Project_Nadav_Arania.Models
{
    public class Assignment
    {
        public string AssignmentTitle { get; set; }
        public DateTime AssignmentDate { get; set; }
        public string AssignmentStatus { get; set; }

        public Assignment(string assignmentTitle, DateTime assignmentDate, string assignmentStatus)
        {
            AssignmentTitle = assignmentTitle;
            AssignmentDate = assignmentDate;
            AssignmentStatus = assignmentStatus;
        }
    }
}
