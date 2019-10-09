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

                //Danske øl
            {
                new Beer { Navn = "Pollerup Påskebryg", Alkohol = 5.7, Beskrivelse = "Pollerup Påskebryg stammer fra Bryghuset Møn",
                    BeskrivelseLang = "Pollerup Påskebryg er en ordentlig flaske øl på 2 liter, som passer godt på påskebordet, hvis der skal skabes lidt ekstra opmærksomhed. Inden i flasken finder du en solid classic, altså en pilsnertype, med ekstra karamelmalt, der giver fylde og sødme.",
                    Kapacitet = 200, Lager = 100,
                    Nation = Beer.Nationalitet.dansk,
                    Pris = 80, TypeOfBeer = Beer.TypeBeer.lys, Titel = "Pollerup Påskebryg", Image64 = "https://res.cloudinary.com/ddiwfa6cc/image/upload/v1570534937/pollerup-paaskebryg-fit-770x770x75_panyda.jpg"

                }
                
                ,

                new Beer { Navn = "Fanø Three Graces", TypeOfBeer = Beer.TypeBeer.mørk, Alkohol = 8.6, Beskrivelse = "Three Graces stammer fra Fanø Bryghus, som er et af de mere oversete bryggerier i Danmark.",
                    BeskrivelseLang = "Den gode maltbund giver Three Graces en forholdvis sødlig smagsprofil, med noter af karamel, muscovado- og rørsukker. Men der er også frugtig sødme som af moden fersken.",
                    Pris = 150, Nation = Beer.Nationalitet.dansk, Lager = 2, Kapacitet = 50, Titel = "Fanø Three Graces", Image64 = "https://res.cloudinary.com/ddiwfa6cc/image/upload/v1570534895/fanoe-three-graces-fit-770x770x75_njqsau.jpg"
                },
                new Beer { Navn = "Sorte Får", TypeOfBeer = Beer.TypeBeer.mørk, Alkohol = 8.5, Beskrivelse = "Sorte Får fra Refsvindinge, er en mørk sødlig og maltdomineret påskeøl.",
                    BeskrivelseLang = "Den smager ikke så stærk som den er, en rigtig 'nydeøl'.",
                    Pris = 110, Nation = Beer.Nationalitet.dansk, Lager = 17, Kapacitet = 33, Titel = "Sorte Får", Image64 = "https://res.cloudinary.com/ddiwfa6cc/image/upload/v1570533046/sorte-faar-refsvindinge-fit-770x770x75_gwonz4.jpg"
                },

                //Norske øl

                new Beer { Navn = "Lervig/Boxing Cat, Norwegian Mauler", TypeOfBeer = Beer.TypeBeer.mørk, Alkohol = 7.9, Beskrivelse = "Brygget af Larvig Aktiebryggeri i Stavanger",
                    BeskrivelseLang = "Denne øl er meget balanceret med en smulig dominans af sødme. Der findes strejf af mørk chokolade og ristet malm.",
                    Pris = 190, Nation = Beer.Nationalitet.norsk, Lager = 9, Kapacitet = 33, Titel = "Lervig/Boxing Cat, Norwegian Mauler", Image64 = "https://res.cloudinary.com/ddiwfa6cc/image/upload/v1570535243/LERVIGmauler_bzbsjs.jpg"
                },
                new Beer { Navn = "Beer Here, Winter Storm", TypeOfBeer = Beer.TypeBeer.mørk, Alkohol = 10.5, Beskrivelse = "Brygget af Nøgne Ø (Hansa Borg)",
                    BeskrivelseLang = "Smagen er ristet malt samt små hints af chokolade, kaffe, lakrids.",
                    Pris = 210, Nation = Beer.Nationalitet.norsk, Lager = 1, Kapacitet = 33, Titel = "Beer Here, Winter Storm", Image64 = "https://res.cloudinary.com/ddiwfa6cc/image/upload/v1570535188/winterStorm_uwyxhl.jpg"
                },
                new Beer { Navn = "Mallow Mafia", TypeOfBeer = Beer.TypeBeer.mørk, Alkohol = 12, Beskrivelse = "Brygget af BrewDog vs. Amundsen.",
                    BeskrivelseLang = "En øl der vil kunne køle dig ned på en varm juni dag.",
                    Pris = 90, Nation = Beer.Nationalitet.norsk, Lager = 10, Kapacitet = 33, Titel = "Mallow Mafia", Image64 = "https://res.cloudinary.com/ddiwfa6cc/image/upload/v1570535141/mallow_jeuy4f.jpg"
                },

                //Svenske øl

                new Beer { Navn = "Omnipollo", TypeOfBeer = Beer.TypeBeer.mørk, Alkohol = 11, Beskrivelse = "Brygget af Dugges Bryggeri.",
                    BeskrivelseLang = "En øl der bruger mørk chokolade som hovedemnet, som er fantastisk til deserter.",
                    Pris = 80, Nation = Beer.Nationalitet.svensk, Lager = 18, Kapacitet = 33, Titel = "Omnipollo", Image64 = "https://res.cloudinary.com/ddiwfa6cc/image/upload/v1570535090/aon_wumlkb.jpg"
                },
                new Beer { Navn = "Wheat Wine", TypeOfBeer = Beer.TypeBeer.lys, Alkohol = 9.1, Beskrivelse = "Brygget af Beerbliotek i Gøteborg.",
                    BeskrivelseLang = "En stærk ale, der virkelig giver en smag af hvad Sverige står for.",
                    Pris = 119, Nation = Beer.Nationalitet.svensk, Lager = 57, Kapacitet = 33, Titel = "Wheat Wine", Image64 = "https://res.cloudinary.com/ddiwfa6cc/image/upload/v1570535048/WheatWine_get0mt.jpg"
                },
                 new Beer { Navn = "Infix Vanilla", TypeOfBeer = Beer.TypeBeer.mørk, Alkohol = 10.5, Beskrivelse = "Brygget af Nerdbrewing fra Malmø, som kalder sig selv for en sigøjner bryggeri.",
                    BeskrivelseLang = "En flot og smagsfyld øl, som har en mild form for vanillie macchiato smag. Virkelig værd at smage!",
                    Pris = 200, Nation = Beer.Nationalitet.svensk, Lager = 14, Kapacitet = 33, Titel = "Infix Vanilla", Image64 = "https://res.cloudinary.com/ddiwfa6cc/image/upload/v1570535344/NerdBrewing_InfixImerialMilkStoutVanillaMacchiatoEditionEdition_hndlrk.jpg"
                }

            };
            //Image = ImgBin.ImageToBytes(Image.FromFile("C:\\Users\\Wezzy Laptop\\Desktop\\background.png"))
            context.Beers.AddRange(items);
            context.SaveChanges();
        }
    }
}
