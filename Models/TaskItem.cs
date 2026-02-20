using System;

namespace TaskManagementSystem.Models;

public enum TaskPriority
{
    Low,
    Medium,
    High
}

public enum TaskStatus
{
    Pending,
    InProgress,
    Completed
}

public class TaskItem
{
    public Guid Id { get; set; }

    public string Title { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public TaskPriority Priority { get; set; }

    public TaskStatus Status { get; set; } = TaskStatus.Pending;

    public DateTime? DueDate { get; set; }

    public bool IsDeleted { get; set; } = false;

    public Guid ProjectId { get; set; }

    public Project Project { get; set; } = null!;
}
