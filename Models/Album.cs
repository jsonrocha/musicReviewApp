﻿using Microsoft.AspNetCore.Identity;

namespace MusicReviewApp.Models
{
    public class Album
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Artist { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public string Dummy { get; set; }

    }


}
