﻿using System;

namespace Travel.API.Dtos
{
    public class TouristRoutePictureDto
    {
        public int Id { get; set; }

        public string Url { get; set; }

        public Guid TouristRouteId { get; set; }
    }
}
