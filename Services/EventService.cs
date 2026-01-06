public class EventService
{
    private readonly List<Event> _eventList;
    private int _nextId = 1;

    public EventService()
    {
        _eventList = new List<Event>();
    }

    public async Task AddEventAsync(Event ev)
    {
        ev.Id = _nextId++;
        _eventList.Add(ev);
        await Task.CompletedTask;
    }
    public async Task<IEnumerable<Event>> GetAllEventsAsync()
    {
        await Task.Delay(500);
        return _eventList;
    }

    public async Task<Event?> FindEventAsync(int id)
    {
        var ev = _eventList.FirstOrDefault(e => e.Id == id);
        return await Task.FromResult(ev);
    }
}
