public class EventService
{
    private readonly List<Event> _eventList;

    public EventService()
    {
        _eventList = new List<Event>();
    }
    public async Task<IEnumerable<Event>> GetAllEventsAsync()
    {
        await Task.Delay(1000);
        return _eventList;
    }

    public async Task<Event?> FindEventAsync(int id)
    {
        var ev = _eventList.FirstOrDefault(e => e.Id == id);
        return await Task.FromResult(ev);
    }
}
