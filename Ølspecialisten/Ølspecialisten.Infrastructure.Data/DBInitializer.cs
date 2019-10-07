using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Ølspecialisten.Core.Entity;

namespace Ølspecialisten.Infrastructure.Data
{
    public class DBInitializer
    {

        // This method will create and seed the database.
        public void Initialize(BeerContext context)
        {
            // Create the database, if it does not already exists. If the database
            // already exists, no action is taken (and no effort is made to ensure it
            // is compatible with the model for this context).
            context.Database.EnsureCreated();

            // Look for any TodoItems
            if (context.Beers.Any())
            {
                // Delete and re-create the database, if it was already been created.
                context.Database.ExecuteSqlCommand("DROP TABLE TodoItems");
                context.Database.EnsureCreated();
            }

            List<Beer> items = new List<Beer>
            {
                new Beer { Navn = "bEdste øl"},
                new Beer { Navn = "Samte fin"}
            };

            context.Beers.AddRange(items);
            context.SaveChanges();
        }
    }
}
