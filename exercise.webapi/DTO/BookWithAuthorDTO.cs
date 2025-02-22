﻿using exercise.webapi.Models;

namespace exercise.webapi.DTO
{
    public class BookWithAuthorDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public AuthorDTO Author { get; set; }

        public BookWithAuthorDTO(Book book)
        {
            Id = book.Id;
            Title = book.Title;

            Author = new AuthorDTO(book.Author);
        }
    }
}
