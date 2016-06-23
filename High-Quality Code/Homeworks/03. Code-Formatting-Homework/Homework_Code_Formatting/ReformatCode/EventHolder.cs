using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReformatCode
{
    public class EventHolder
    {
        MultiDictionary<string, Event> eventsByTitle = new MultiDictionary<string, Event>(true);
        OrderedBag<Event> eventsByDate = new OrderedBag<Event>();
        
        public void AddEvent(DateTime date, string title, string location)
        {
            Event newEvent = new Event(date, title, location);
            eventsByTitle.Add(title.ToLower(), newEvent);
            eventsByDate.Add(newEvent);
            Messages.EventAdded();
        }

        public void DeleteEvents(string titleToDelete)
        {
            string title = titleToDelete.ToLower();
            int removedEvents = 0;
            foreach (var eventToRemove in eventsByTitle[title])
            {
                removedEvents++;
                eventsByDate.Remove(eventToRemove);
            }

            eventsByTitle.Remove(title);
            Messages.EventDeleted(removedEvents);
        }

        public void ListEvents(DateTime date, int count)
        {
            OrderedBag<Event>.View eventsToShow = eventsByDate.RangeFrom(
                new Event(date, "", ""),
                true);
            int showed = 0;
            foreach (var eventToShow in eventsToShow)
            {
                if (showed == count)
                {
                    break;
                }

                Messages.PrintEvent(eventToShow);

                showed++;
            }

            if (showed == 0)
            {
                Messages.NoEventsFound();
            }
        }
    }
}
