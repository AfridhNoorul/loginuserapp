using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginApp.Models
{
    public class UserDetailsModel
    {
        public UserDetailsModel(int mathsmarks, int sciencemarks)
        {
            MathsMarks = mathsmarks;
            ScienceMarks = sciencemarks;
        }

        public UserDetailsModel()
        {
        }

        public int MathsMarks { get; set; }
        public int ScienceMarks { get; set; }
    }
}
