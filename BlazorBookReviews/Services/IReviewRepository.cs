﻿using BlazorBookReviews.Models;

namespace BlazorBookReviews.Services
{
    public interface IReviewRepository
    {
        Task<IEnumerable<BookReview>> GetReviewsAsync();
    }
}