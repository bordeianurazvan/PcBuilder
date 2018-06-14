using System;

namespace Data.Core.Domain
{
    public interface IProduct
    {
        Guid Id { get; }
        string Title { get; set; }
        double Price { get; set; }
        string ImageUrl { get; set; }
        string Url { get; set; }
    }
}
