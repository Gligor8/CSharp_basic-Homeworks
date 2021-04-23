using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Models
{
    public class User : Member
    {
        public int MemberNumber { get; set; }
        public Enums.TypeSub TypeOfSubscription { get; set; }
        

    }
}
