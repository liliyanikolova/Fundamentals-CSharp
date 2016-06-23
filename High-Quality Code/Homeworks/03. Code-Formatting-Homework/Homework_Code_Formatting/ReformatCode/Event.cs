using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReformatCode
{
    public class Event : IComparable
    {
        public DateTime date;
        public String title;
        public String location;

        public Event(DateTime date, String title, String location)
        {
            this.date = date;
            this.title = title;
            this.location = location;
        }

        public int CompareTo(object obj)
        {
            Event otherEvent = obj as Event;

            int comparedByDate = this.date.CompareTo(otherEvent.date);
            int comparedByTitle = this.title.CompareTo(otherEvent.title);
            int comparedByLocation = this.location.CompareTo(otherEvent.location);
            if (comparedByDate == 0)
            {
                if (comparedByTitle == 0)
                {
                    return comparedByLocation;
                }
                else
                {
                    return comparedByTitle;
                }
            }
            else
            {
                return comparedByDate;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append(this.date.ToString("yyyy-MM-dd HH:mm:ss"));
            result.Append(" | " + this.title);
            if (this.location != null && this.location != "")
            {
                result.Append(" | " + this.location);
            }

            return result.ToString();
        }
    }
}
