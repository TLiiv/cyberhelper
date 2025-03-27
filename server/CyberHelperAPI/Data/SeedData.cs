using server.Data.Migrations;
using server.Models;

namespace server.Data
{
    public static class SeedData
    {
        public static void Generate(ApplicationDbContext context)
        {
            if (!context.Emails.Any())
            {
                var emails = new List<Email>
                {
                    // Phishing emails
                new Email
                {
                    Id = Guid.NewGuid(),
                    Sender = "prince.adebayo@nigeria.gov",
                    Subject = "Kiireloomuline: Teie abi on vaja!",
                    Body = "Tere! Olen Nigeeria prints Adebayo ja mul on 10 miljonit eurot...",
                    IsPhishing = true,
                    DisplayLink = "www.nigeria.gov",
                    HiddenLink = "http://fakebank-nigeria.com",
                    Difficulty = 1,
                    Footer = "Palun vastake kiiresti.",
                    ContactNumber = "+234-123-4567",
                    Signature = "Prince Adebayo"
                },
                new Email
                {
                    Id = Guid.NewGuid(),
                    Sender = "info@estonialottery.ee",
                    Subject = "Õnnitleme! Olete võitnud 50 000€",
                    Body = "Palju õnne! Teie e-posti aadress valiti juhuslikult meie loosimises...",
                    IsPhishing = true,
                    DisplayLink = "www.estonialottery.ee",
                    HiddenLink = "http://estonialottery-claim.com",
                    Difficulty = 2,
                    Footer = "Tingimused rakenduvad.",
                    ContactNumber = "+372-555-7890",
                    Signature = "Eesti Loterii"
                },
                new Email
                {
                    Id = Guid.NewGuid(),
                    Sender = "support@swedbank-security.ee",
                    Subject = "Tähelepanu! Teie konto on lukustatud",
                    Body = "Teie konto on ajutiselt peatatud. Palun logige sisse ja kinnitage oma andmed.",
                    IsPhishing = true,
                    DisplayLink = "www.swedbank.ee/login",
                    HiddenLink = "http://secure-swedbank-login.com",
                    Difficulty = 3,
                    Footer = "Swedbank ei küsi kunagi paroole e-posti teel.",
                    ContactNumber = "+372-660-1234",
                    Signature = "Swedbank Turvameeskond"
                },

                //Real Emails
                new Email
                {
                    Id = Guid.NewGuid(),
                    Sender = "hr@techcompany.com",
                    Subject = "Tööpakkumine: Täiendav arendaja roll",
                    Body = "Tere! Otsime meie meeskonda uut arendajat...",
                    IsPhishing = false,
                    DisplayLink = "www.techcompany.com",
                    HiddenLink = null,
                    Difficulty = 1,
                    Footer = "Võtke meiega ühendust töövõimaluste osas.",
                    ContactNumber = "+372-777-8888",
                    Signature = "TechCompany HR"
                },
                new Email
                {
                    Id = Guid.NewGuid(),
                    Sender = "newsletter@estoniannews.ee",
                    Subject = "Uudiskiri: Eesti majanduse arengud",
                    Body = "Tere! Meil on hea meel pakkuda teile meie viimast uudiskirja...",
                    IsPhishing = false,
                    DisplayLink = "www.estoniannews.ee",
                    HiddenLink = null,
                    Difficulty = 2,
                    Footer = "Telli meie uudiskiri.",
                    ContactNumber = "+372-555-4567",
                    Signature = "Eesti Uudised"
                },
                new Email
                {
                    Id = Guid.NewGuid(),
                    Sender = "admin@startupincubator.ee",
                    Subject = "Startup inkubaatori uued võimalused",
                    Body = "Meil on hea meel tutvustada teile uusi arenguvõimalusi...",
                    IsPhishing = false,
                    DisplayLink = "www.startupincubator.ee",
                    HiddenLink = null,
                    Difficulty = 5,
                    Footer = "Tule ja osale innovatsiooniprogrammis.",
                    ContactNumber = "+372-999-1122",
                    Signature = "Startup Incubator"
                }
                };
                context.AddRange(emails);
                context.SaveChanges();
            }
        }
    }
}
