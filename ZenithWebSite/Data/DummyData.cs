using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using ZenithDataLib;

namespace ZenithWebSite.Data
{
    public class DummyData
    {
        public static System.Collections.Generic.List<Activity> getActivities()
        {
            List<Activity> activities = new List<Activity>()
            {
                new Activity() {
                    ActivityDescription = "Youth Bowling Tournament",
                    CreationDate = new DateTime(2017, 3, 1)
                },
                new Activity() {
                    ActivityDescription = "Lunch",
                    CreationDate = new DateTime(2017, 3, 2)
                },
                new Activity() {
                    ActivityDescription = "Senior's Golf Tournament",
                    CreationDate = new DateTime(2017, 3, 3)
                },
                new Activity() {
                    ActivityDescription = "Leadership General Assembly Meeting",
                    CreationDate = new DateTime(2017, 3, 4)
                },
                new Activity() {
                    ActivityDescription = "Cooking Lessons",
                    CreationDate = new DateTime(2017, 3, 5)
                },
                new Activity() {
                    ActivityDescription = "Pancake Breakfast",
                    CreationDate = new DateTime(2017, 3, 6)
                },
                new Activity() {
                    ActivityDescription = "Swimming Lessons for the youth",
                    CreationDate = new DateTime(2017, 3, 7)
                },
            };

            return activities;
        }

        public static List<Event> getEvents(ApplicationDbContext context)
        {
            List<Event> events = new List<Event>() {
                new Event {
                    EventFrom = new DateTime(2017, 4, 2, 11, 0, 0),
                    EventTo = new DateTime(2017, 4, 2, 14, 0, 0),
                    Username = "Dummy Seed",
                    CreationDate = new DateTime(2017, 4, 1),
                    IsActive = true
                },
                new Event {
                    EventFrom = new DateTime(2017, 4, 3, 12, 0, 0),
                    EventTo = new DateTime(2017, 4, 3, 13, 0, 0),
                    Username = "Dummy Seed",
                    CreationDate = new DateTime(2017, 4, 2),
                    IsActive = true
                },
                new Event {
                    EventFrom = new DateTime(2017, 4, 4, 10, 0, 0),
                    EventTo = new DateTime(2017, 4, 4, 13, 0, 0),
                    Username = "Dummy Seed",
                    CreationDate = new DateTime(2017, 4, 3),
                    IsActive = true
                },
                new Event {
                    EventFrom = new DateTime(2017, 4, 5, 13, 0, 0),
                    EventTo = new DateTime(2017, 4, 5, 14, 30, 0),
                    Username = "Dummy Seed",
                    CreationDate = new DateTime(2017, 4, 4),
                    IsActive = true
                },
                new Event {
                    EventFrom = new DateTime(2017, 4, 6, 12, 0, 0),
                    EventTo = new DateTime(2017, 4, 6, 14, 0, 0),
                    Username = "Dummy Seed",
                    CreationDate = new DateTime(2017, 4, 5),
                    IsActive = true
                },
                new Event {
                    EventFrom = new DateTime(2017, 4, 7, 9, 0, 0),
                    EventTo = new DateTime(2017, 4, 7, 10, 0, 0),
                    Username = "Dummy Seed",
                    CreationDate = new DateTime(2017, 4, 6),
                    IsActive = true
                },
                new Event {
                    EventFrom = new DateTime(2017, 4, 8, 12, 0, 0),
                    EventTo = new DateTime(2017, 4, 8, 14, 0, 0),
                    Username = "Dummy Seed",
                    CreationDate = new DateTime(2017, 4, 7),
                    IsActive = true
                },
            };

            return events;
        }

    }
}