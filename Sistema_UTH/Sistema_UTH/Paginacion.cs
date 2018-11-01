using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Sistema_UTH
{
    public class Paginacion<T> : List<T>
    {
        public int PageIndex
        {
            get;
            private set;
        }

        public int TotalPages
        {
            get;
            private set;
        }

        public int TotalResults
        {
            get;
            private set;
        }

        public Paginacion (List<T> items, int pageIndex, int count, int pageSize)
        {
            PageIndex = pageIndex;
            TotalPages = (int)Math.Ceiling(Count / (double)pageSize);
            TotalResults = count;
            this.AddRange(items);
        }

        public bool HasPreviousPage
        {
            get
            {
                return (PageIndex > 1);
            }
        }

        public bool HasNextPage
        {
            get
            {
                return (PageIndex < TotalPages);
            }
        }

        public static async Task<Paginacion<T>> CreateAsync(IQueryable<T> source, int pageIndex, int pageSize)
        {
            var count = await source.CountAsync();
            var items = await source.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToListAsync();
            return new Paginacion<T>(items, pageSize, count, pageSize);
        }
    }
}