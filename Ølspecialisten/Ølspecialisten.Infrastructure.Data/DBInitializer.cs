using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Ølspecialisten.Core.Entity;

namespace Ølspecialisten.Infrastructure.Data
{
    public class DBInitializer : IDBInitializer
    {

        // This method will create and seed the database.
        public void Initialize(BeerContext context)
        {
            //context.Database.ExecuteSqlCommand("DROP TABLE Beers");
            // Create the database, if it does not already exists. If the database
            // already exists, no action is taken (and no effort is made to ensure it
            // is compatible with the model for this context).
            context.Database.EnsureCreated();

            // Look for any TodoItems
            if (context.Beers.Any())
            {
                // Delete and re-create the database, if it was already been created.
                context.Database.ExecuteSqlCommand("DROP TABLE Beers");
                context.Database.EnsureCreated();
            }

            List<Beer> items = new List<Beer>
            {
                new Beer { Navn = "bEdste øl", Alkohol = 12, Beskrivelse = "Lys øl brygget på malt fra Amager strand",
                    BeskrivelseLang = "Denne fine danske øl er brygget under den varme sommerhimmel, hvorefter den har hygget sig i et skur med de fineste humlebier",
                    Kapacitet = 500, Lager = 100,
                    Nation = Beer.Nationalitet.Dansk,
                    Pris = 80, TypeOfBeer = Beer.TypeBeer.Lys, Titel = "Fin titel", Image64 = ImgBin.ImageToBase64((@"background.png"))
                },
                new Beer { Navn = "Samte fin", TypeOfBeer = Beer.TypeBeer.Mørk, Alkohol = 1, Beskrivelse = "mørk øl brygget på malt fra Esbjerg strand",
                    BeskrivelseLang = "Denne fine danske øl er brygget under den lunke skude, hvorefter den har hygget sig i et skur med de fineste fisk",
                    Pris = 450, Nation = Beer.Nationalitet.Dansk, Lager = 2, Kapacitet = 1000, Titel = "Det er sgu da fint"
                }
                //new Beer(){Navn = "Tester"}
            };
            //Image = ImgBin.ImageToBytes(Image.FromFile("C:\\Users\\Wezzy Laptop\\Desktop\\background.png"))
            context.Beers.AddRange(items);
            context.SaveChanges();
        }
    }
}
