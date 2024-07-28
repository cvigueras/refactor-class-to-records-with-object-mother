using ClassToRecords.App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassToRecords.App.Tests
{
    public class UserMother
    {
        public static User UserUnderEighteen()
        {
            return User.Create("Pepito Grillo", 16);
        }

        public static User UserOverEighteenUnderThirty()
        {
            return User.Create("Pepito Grillo", 29);
        }

        public static User UserOverThirtyUnderSixtyFive()
        {
            return User.Create("Pepito Grillo", 46);
        }

        public static User UserOverSixtyFive()
        {
            return User.Create("Pepito Grillo", 67);
        }
    }
}
