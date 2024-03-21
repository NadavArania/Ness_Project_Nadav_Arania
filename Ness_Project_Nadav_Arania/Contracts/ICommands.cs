using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ness_Project_Nadav_Arania.Contracts
{
    public interface ICommands
    {
        public void AddAssignment();
        public void RemoveAssignment();
        public void UpdateAssignment();
        public void Exit();
    }
}
