using CyberHelperAPI.Models;

namespace CyberHelperAPI.Migrations
{
    public static class SeedData
    {
        public static void Generate(ApplicationDbContext context) 
        {
            if (!context.Emails.Any()) 
            {
                var Emails = new List<Email> 
                {
                    new Email
                {
                    Id = Guid.NewGuid(),
                    Sender = "prince.adebayo@nigeria.gov",
                    Subject = "Kiireloomuline: Teie abi on vaja!",
                    Body = "Tere! Olen Nigeeria prints Adebayo ja mul on 10 miljonit eurot, mida tahan teiega jagada. Saatke mulle oma pangaandmed, et saaksin ülekande teha.",
                    IsPhishing = true,
                    HiddenLink = "http://fakebank-nigeria.com",
                    Difficulty = 1
                },
                new Email
                {
                    Id = Guid.NewGuid(),
                    Sender = "info@estonialottery.ee",
                    Subject = "Õnnitleme! Olete võitnud 50 000€",
                    Body = "Palju õnne! Teie e-posti aadress valiti juhuslikult meie igakuises loosimises. Raha saamiseks klõpsake alloleval lingil ja sisestage oma andmed.",
                    IsPhishing = true,
                    HiddenLink = "http://estonialottery-claim.com",
                    Difficulty = 2
                },
                new Email
                {
                    Id = Guid.NewGuid(),
                    Sender = "support@swedbank-security.ee",
                    Subject = "Tähelepanu! Teie konto on ajutiselt lukustatud",
                    Body = "Meie turvasüsteem tuvastas teie kontol kahtlase tegevuse. Teie konto on ajutiselt peatatud. Palun logige sisse ja kinnitage oma isikuandmed.",
                    IsPhishing = true,
                    HiddenLink = "http://secure-swedbank-login.com",
                    Difficulty = 3
                },
                new Email
                {
                    Id = Guid.NewGuid(),
                    Sender = "recruitment@estonianbusiness.net",
                    Subject = "Tööintervjuu kutse – Palun täitke ankeet",
                    Body = "Meil on teie CV põhjal pakkuda suurepärast töövõimalust Eestis. Palun täitke ankeet ja saatke meile oma isikuandmed ning pangakonto number palga maksmiseks.",
                    IsPhishing = true,
                    HiddenLink = "http://estonianbusiness-careers.com",
                    Difficulty = 4
                },
                new Email
                {
                    Id = Guid.NewGuid(),
                    Sender = "juhatus@estoniancompany.ee",
                    Subject = "Kiire makse vajalik – Arve #23456",
                    Body = "Tere! See on ettevõtte tegevjuht. Meil on oluline makse, mis tuleb täna tasuda. Palun kandke 24 500€ allpool olevale kontole ja saatke kinnituskiri.",
                    IsPhishing = true,
                    HiddenLink = "http://securepayment-transfer.com",
                    Difficulty = 5
                }
              
                };
                context.AddRange(Emails);
                context.SaveChanges();
            }
        }
    }
}
