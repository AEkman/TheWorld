﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace TheWorld.Models
{
    public class WorldUser : IdentityUser
    {
        public WorldContextSeedData FirstTrip { get; set; }
    }
}