﻿namespace Domain.Entities;
public class Class
{
    public int Id { get; set; }

    public int CourseId { get; set; }
    public Course? Course { get; set; }

    public int TeacherId { get; set; }
    public Teacher? Teacher { get; set; }
}