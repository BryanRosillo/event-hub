using System.ComponentModel.DataAnnotations;

public class Event
{
    [Required(ErrorMessage = "Event name is required.")]
    [MaxLength(100, ErrorMessage = "Event name cannot exceed 100 characters.")]
    public string Name { get; set; }

    [Required(ErrorMessage = "Description is required.")]
    [MaxLength(500, ErrorMessage = "Description cannot exceed 500 characters.")]
    public string Description { get; set; }

    [Required(ErrorMessage = "Date is required.")]
    [DataType(DataType.Date)]
    public DateTime Date { get; set; }

    [Required(ErrorMessage = "Location is required.")]
    [MaxLength(200, ErrorMessage = "Location cannot exceed 200 characters.")]
    public string Location { get; set; }
}