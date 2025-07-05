using System;
using System.Collections.Generic;

namespace Todo.DalLayer.Models;

public partial class Task
{
    public int TaskId { get; set; }

    public string Title { get; set; }

    public string Description { get; set; }

    public DateOnly? DueDate { get; set; }

    public bool? IsCompleted { get; set; }

    public int? UserId { get; set; }

    public virtual User User { get; set; }
}
