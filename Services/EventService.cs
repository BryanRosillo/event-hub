public class EventService
{
    private readonly List<Event> _eventList;

    public EventService()
    {
        _eventList = new List<Event>();
        _eventList.Add(new Event
        {
            Name = "Conference",
            Description = "A conference about technology",
            Date = DateTime.Now.AddMonths(1),
            Location = "New York"
        });

        _eventList.Add(new Event
        {
            Name = "Workshop",
            Description = "A hands-on workshop",
            Date = DateTime.Now.AddMonths(2),
            Location = "Online"
        });
    }
    public async Task<IEnumerable<Event>> GetAllEventsAsync()
    {
        await Task.Delay(1000);
        return _eventList;
    }
}
