namespace Event.Application.Features.Queries.Event.GetByIdEvent
{
    public class GetByIdEventQueryResponse
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}