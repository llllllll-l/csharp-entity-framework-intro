﻿using System.ComponentModel.DataAnnotations.Schema;

namespace exercise.webapi.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        
        public int AuthorId { get; set; }
        public Author Author { get; set; }

        // extension
        public int PublisherId { get; set; }
        public Publisher Publisher { get; set; }

        // extension many-to-many
        public ICollection<BookAuthor> BookAuthors { get; set; } = new List<BookAuthor>();
        
    }
}
