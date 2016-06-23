﻿using System;

namespace Methods
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string OtherInfo { get; set; }

        public bool IsOlderThan(string otherStudentInfo)
        {
            DateTime firstDate =
                DateTime.Parse(this.OtherInfo.Substring(this.OtherInfo.Length - 10));
            DateTime secondDate =
                DateTime.Parse(otherStudentInfo.Substring(otherStudentInfo.Length - 10));

            bool isOlder = firstDate > secondDate;
            return isOlder;
        }
    }
}
