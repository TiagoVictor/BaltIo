﻿using Balta.ContentContext;
using Balta.NotificationContext;
using Balta.SharedContext;

public class CareerItem : Base
{
    public CareerItem(int order, string title, string description, Course course)
    {
        if(course == null)
            AddNotification(new Notification("Course", "Curso invalido"));

        Order = order;
        Title = title;
        Description = description;
        Course = course;
    }

    public int Order { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public Course Course { get; set; }
}