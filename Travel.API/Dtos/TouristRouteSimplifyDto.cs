﻿using System;

namespace Travel.API.Dtos
{
    public class TouristRouteSimplifyDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
    }
}
