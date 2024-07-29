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
            return new User("Pepito Grillo", 16);
        }

        public static User UserOverEighteenUnderThirty()
        {
            return new User("Pepito Grillo", 29);
        }

        public static User UserOverThirtyUnderSixtyFive()
        {
            return new User("Pepito Grillo", 46);
        }

        public static User UserOverSixtyFive()
        {
            return new User("Pepito Grillo", 67);
        }
    }
}
