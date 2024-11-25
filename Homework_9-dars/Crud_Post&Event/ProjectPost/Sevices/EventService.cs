using ProjectPost.Models;

namespace ProjectPost.Sevices;

public class EventService
{
    private List<Event> events;

    public EventService()
    {
        events = new List<Event>();
    }

    // Create
    public Event AddEvent(Event addEvent)
    {
        addEvent.Id = Guid.NewGuid();
        events.Add(addEvent);

        return addEvent;
    }

    // Read
    public List<Event> GetAllEvent()
    {
        return events;
    }

    public Event GetEventById(Guid id)
    {
        foreach (var eventItem in events)
        {
            if (eventItem.Id == id)
            {
                return eventItem;
            }
        }

        return null;
    }

    public List<Event> GetEventsByLocation(string location)
    {
        var locationEvents = new List<Event>();
        foreach (var eventItem in events)
        {
            var locationEvent = eventItem.Location;
            if (locationEvent == location)
            {
                locationEvents.Add(eventItem);
            }
        }

        return locationEvents;
    }

    public Event GetPopularEvent()
    {
        var responseEvent = new Event();
        foreach (var eventItem in events)
        {
            if (eventItem.Attendees.Count > responseEvent.Attendees.Count)
            {
                responseEvent = eventItem;
            }
        }

        return responseEvent;
    }

    public Event GetMaxTaggedEvent()
    {
        var responseEvent = new Event();
        foreach (var eventItem in events)
        {
            if (eventItem.Tags.Count > responseEvent.Tags.Count)
            {
                responseEvent = eventItem;
            }
        }

        return responseEvent;
    }

    // Update
    public bool UpdateEvent(Event updateEvent)
    {
        var eventFromDb = GetEventById(updateEvent.Id);
        if (eventFromDb == null)
        {
            return false;
        }
        var index = events.IndexOf(updateEvent);
        events[index] = updateEvent;

        return true;
    }

    // Delate
    public bool DeleteEvent(Guid id)
    {
        var eventFromD = GetEventById(id);
        if (eventFromD == null)
        {
            return false;
        }
        events.Remove(eventFromD);

        return true;
    }
}
