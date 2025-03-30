using Microsoft.Extensions.Hosting;
using server.Data.Migrations;
using server.Models;
using static System.Net.WebRequestMethods;

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
                    Body = @"
                    Tere, kallis sõber,<br /><br />
                    
                    Ma tean, et see sõnum võib teile üllatuseks tulla, kuid palun kuulake ära mu soov, astuda teiega äritegevusse. Mina olen prints Adebayo Olufemi, hiljuti suri mu isa, kes oli kõrge ametnik rahvusvahelises naftasektoris Lääne-Aafrikas. Enne tema traagilist surma jättis ta mulle 4,2 miljonit eurot, mille ta hoiustas turvaliselt Cotonou pangas Benini Vabariigis.<br />
                    
                    Praeguste poliitiliste rahutuste ja korruptsiooni tõttu on mul väga raske seda raha kätte saada. Otsin usaldusväärset partnerit Euroopas, kes aitaks mul need vahendid kiiresti ja turvaliselt üle kanda. Teie abi eest pakun teile 10% kogu summast ehk 420 000 eurot.<br />

                    Palun andke mulle kiiresti teada, kui olete valmis aitama. Olen noor meditsiinitudeng ning soovin pärast selle protsessi lõppu kolida teie riiki, et jätkata oma õpinguid ja alustada uut elu.<br />
                    
                    Kui olete huvitatud, palun vastake viivitamatult sellele e-kirjale või võtke minuga ühendust alternatiivsel aadressil.<br />
                    
                    Alternatiivne e-post: prince.adebayo.olufemi@africantrust.org<br />
                    
                    Teie kiire vastus oleks väga teretulnud.<br /><br />

                    Parimate soovidega,<br />  
                    Prints Adebayo Olufemi
                    ",
                    IsPhishing = true,
                    DisplayLink = null,
                    HiddenLink = null,
                    Difficulty = 10,
                    IconUrl = null,
                    ContactNumber = null,
                    Signature = null,
                    ImgUrl = null,
                     WebsiteLink =null
                },
                new Email
                {
                    Id = Guid.NewGuid(),
                    Sender = "winner79094@lottery.com",
                    Subject = "Õnnitleme! Olete võitnud!",
                    Body = @"
                    <html>
                         <body style='font-family: Arial, sans-serif; line-height: 1.6; font-size: 14px; display: flex; justify-content: center; align-items: center; text-align: center;'>
                            <div style='width: 100%; max-width: 600px; padding: 20px;box-shadow: 1px 1px 10px rgba(0, 0, 0, 0.2);max-height: 65vh;'>
                                <h1 style='background-color: #FF9800; color: white; padding: 20px; font-size: 24px; font-weight: bold; margin: 0;'>Õnnitleme! Olete võitnud!</h1>
                                <p style='padding: 10px; font-size: 22px; font-weight: bold;'>Hea võitja,</p> <br />
                                <p>Meil on hea meel teatada, et teid on valitud meie hiljutises loosimises suure auhinna võitjaks!<br/><br/>Olete võitnud põneva auhinna, mille väärtus on tuhandetes euros.</p>
                                <p>Auhinna kätte saamiseks klõpsake alloleval lingil ja täitke vajalikud sammud:</p><br />
                                <a href='{{hiddenLink}}' style='display: inline-block; padding: 12px 24px; background-color: #FF9800; color: white; text-decoration: none; border-radius: 5px; text-align: center;' onclick='event.preventDefault();'>Saage oma auhind nüüd</a><br /><br />
                                <p style='font-weight: semibold; font-size: 12px; color: gray; padding-top: 10px;'>Oluline: Olge ettevaatlik petuskeemide suhtes. Ärge jagage tundlikku isiklikku teavet ega makske mingeid tasusid oma auhinna saamiseks. Kui te ei osalenud loosimises, siis palun unustage see e-kiri.</p><br />
                                <p>Tänan teid osalemise eest ja õnnitlen veel kord!</p><br />
                                <p style='font-size: 12px; color: #555;'>Kui teil on küsimusi, võtke meiega ühendust. See on süsteemi genereeritud e-kiri, seetõttu palun ärge vastake sellele sõnumile.</p>
                            </div>
                        </body>
                    </html>",
                    IsPhishing = true,
                    DisplayLink = null,
                    HiddenLink = "http://phishing-lottery-claim.com",
                    Difficulty = 9,
                    IconUrl = null,
                    ContactNumber = null,
                    Signature = null,
                    ImgUrl = null,
                     WebsiteLink =null
                },
                new Email
                {
                    Id = Guid.NewGuid(),
                    Sender = "bekos79094@dizigg.com",
                    Subject = "Palun abi – tahan koju naasta",
                    Body = @"<html>
                        <body style='font-family: Arial, sans-serif; line-height: 1.6;'>
                            <h2>Tere, kallis sõber,</h2><br/>
                
                            <p>Vabandan, et teid ootamatult tülitan, kuid olen väga raskes olukorras ja mul pole enam kellelegi teisele pöörduda. 
                            Olen Aleksei Pavlenko, Ukraina sõjapõgenik, ning tulin Eestisse koos oma naise ja kahe väikese lapsega, 
                            et pääseda sõjakoledustest.</p>
                
                            <p>Soovin nüüd naasta oma kodumaale, et oma riigi eest võidelda ja aidata neid, kes ei saa iseennast kaitsta. 
                            Kuid eile varastati mu rahakott, kui olin Tallinnas ametiasutustes dokumente korda ajamas. Kaotasin oma isiklikud asjad, 
                            sularaha ja ajutised reisidokumendid, mis on vajalikud Eestist lahkumiseks.</p>
                
                            <p>Mul on kiiresti vaja 900 eurot, et katta reisikulud ja jätta perele toiduraha. 
                            Palun andke mulle teada, kas saaksite mind abistada – iga panus aitaks mul koju jõudmisele sammu lähemale liikuda.</p>
                
                            <p>Olen väga tänulik teie abi eest ja luban kogu summa tagasi maksta niipea, kui see on võimalik.</p>
                
                            <p>Kui olete valmis aitama, palun kirjutage mulle kiiresti, et saaksin teile saatmisandmed edastada.</p>
                
                            <p>Südamest tänulik igasuguse abi eest!</p><br/>
                
                            <p>Parimate soovidega,<br />Oleksiy Pavlenko</p>
                            
                        </body>
                    </html>",
                    IsPhishing = true,
                    DisplayLink = null,
                    HiddenLink = null,
                    Difficulty = 8,
                    IconUrl = null,
                    ContactNumber = null,
                    Signature = null,
                    ImgUrl = null,
                     WebsiteLink =null
                },
                new Email
                {
                    Id = Guid.NewGuid(),
                    Sender = "Lisette@cvkeskus.ee",
                    Subject = "Osale küsitluses ja võida auhind!",
                    Body = @"
                    <html>
                       <body
                          style='
                            font-family: Arial, sans-serif;
                            line-height: 1.6;
                            text-align: center;
                            margin: 0;
                            padding: 0;
                            overflow: hidden; 
                        '
                        >

                          <div
                            style='
                              width: 100%;
                              max-width: 600px;
                              padding: 20px;
                              margin: 0 auto;
                              max-height: 65vh;
                              box-sizing: border-box;
                            '
                          >
                            <p><b>Kas oled juba Top Tööandja uuringus osalenud? 👀</b></p>

                            <p>
                              Viimane võimalus anda teada, kes on sinu arvates Eesti parimad
                              tööandjad! 🤩
                            </p>
                            <br />

                            <p>Meil on hea meel teatada, et osaledes meie Top Tööandja uuringus. </p><br/>
                        <p>Saad mitte ainult anda oma hinnangu parimatele tööandjatele, vaid ka osaleda
                              suurel loosimisel!
                            </p>
                            <br />

                            <p><b>Auhinnaks läheb osalejate vahel jagamisele 20x iPhone 16! 📱</b></p>
                            <br />

                            <p>Osalemiseks skaneeri QR-kood või vajuta allolevale nupule ja täida uuring!</p>
                            <br />

                            <div style='margin: 20px; display: flex; justify-content: center;'>
                              <img
                                src='{{imgUrl}}'
                                alt='{{QR Code}}'
                                style='width: 150px; height: 150px; border-radius: 8px;'
                              />
                            </div>

                            <div style='margin-top: 20px; display: flex; justify-content: center;'>
                              <a
                                href='{{hiddenLink}}'
                                style='
                                  display: inline-block;
                                  padding: 12px 24px;
                                  background-color: #1538d4;
                                  color: white;
                                  text-decoration: none;
                                  border-radius: 8px;
                                  width: 200px;
                                  text-align: center;
                                '
                                onclick='event.preventDefault();'
                                >
                                Alusta küsitlust
                              </a>
                            </div>

                            <p style='margin-top: 40px;'>
                              Pärast uuringu täitmist oled automaatselt loosimisest osa saanud.
                            </p>
                            <br />

                            <p><b>Võitjad kuulutatakse välja juba järgmise kuu lõpus!</b></p>
                            <br />

                            <p>Suured tänud, et aitate meil mõista, kes on Eesti parimad tööandjad!</p>
                            <br />

                            <p>Kui te ei soovi osaleda, ignoreerige seda e-kirja.</p></br>

                            <p>Kõike parimat soovides, <br /><b>{{signature}}</b></p><br />
                          </div>
                        </body>
                    </html>",
                    IsPhishing = true,
                    DisplayLink = null,
                    HiddenLink= "http://surveydata.com.ru/21398+sa9d89d17a87019d109s8d90as8d",
                    Difficulty = 6,
                    IconUrl = null,
                    ContactNumber = null,
                    Signature = "CVKeskus",
                    WebsiteLink =null,
                    ImgUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/d/d0/QR_code_for_mobile_English_Wikipedia.svg/1200px-QR_code_for_mobile_English_Wikipedia.svg.png",
                },
                new Email
{
                    Id = Guid.NewGuid(),
                    Sender = "noreply@dharma.ee",
                    Subject = "Aita uusi emasid – Kingi 25, 50 või 100 EUR!",
                    Body = @"
                    <html>
                       <body
                          style='
                            font-family: Arial, sans-serif;
                            line-height: 1.6;
                            text-align: center;
                            margin: 0;
                            padding: 0;
                            overflow: hidden;
                          '
                        >
                
                          <div
                            style='
                              width: 100%;
                              max-width: 600px;
                              padding: 20px;
                              margin: 0 auto;
                              max-height: 65vh;
                              box-sizing: border-box;
                            '
                          >
                            <p><img src='{{iconUrl}}'/><b>Heategevusfond Dharma aitab emmesid ja lapsi! 🎁</b></p>
                            <p>Meie fond on aidanud mitmeid peresid, kuid nüüd vajame sinu abi, et teha veel rohkem head. <br />Aita meil muuta rohkem elusid!</p>
                            <br />
                            <p>
                               <b>Aita meil teha kingikomplekte uute emmede jaoks.</b><br/> Viime läbi uuesti eelnevalt edukat projekti, kus kingime uutele emadele vastsündinute kasvatamiseks kinkekomplekti.
                            </p>
                            <br />
                            <p>Kingi 25, 50 või 100 EUR ja teeme koos uute emmede elu lihtsamaks, pakkudes neile vajalikke esemeid ja tuge! 💖</p>
                            <br />         
                
                            <p><b>Kui soovid just selle projekti raames annetuse teha kasutage ühte nendest valikutest:</b></p> <br/><br/>
                
                            <div style='display: flex; justify-content: center; gap: 10px;'>
                              <button
                                style='
                                  background-color: #4CAF50;
                                  color: white;
                                  padding: 10px 24px;
                                  font-size: 16px;
                                  cursor: pointer;
                                  border-radius: 8px;
                                  border: none;
                                '
                                onclick='window.open(""{{hiddenLink}}?amount=25"", ""_blank"")'
                              >
                                25 EUR
                              </button>
                
                              <button
                                style='
                                  background-color: #008CBA;
                                  color: white;
                                   padding: 10px 24px;
                                  font-size: 16px;
                                  cursor: pointer;
                                  border-radius: 8px;
                                  border: none;
                                '
                                onclick='window.open(""{{hiddenLink}}?amount=50"", ""_blank"")'
                              >
                                50 EUR
                              </button>
                
                              <button
                                style='
                                  background-color: #f44336;
                                  color: white;
                                   padding: 10px 24px;
                                  font-size: 16px;
                                  cursor: pointer;
                                  border-radius: 8px;
                                  border: none;
                                '
                                onclick='window.open(""{{hiddenLink}}?amount=100"", ""_blank"")'
                              >
                                100 EUR
                              </button>
                            </div>
                
                            <br />
                            <p style='margin-top: 20px;'>
                              Dharma Heategevusfond, loodud 2001. aastal, on pühendunud heategevusele, et pakkuda igale lapsele just tema vajadustele vastavat abi. Kuid me ei saa seda teha ilma sinuta. Toeta meid täna!
                            </p>
                            <br />
                
                            <p><b>Ole osa muutusest. Aita meil kingitusi jagada!</b></p>
                            <br />
              
                            <p>Külastage meie veebilehte ja tutvu ka meie teiste tegevustega: <br/><a href='{{websiteLink}}' target='_blank'><b>Dharma Heategevusfond</b></a></p><br/>
                           <p>Parimate soovidega, <br /><b>Urmas Sõõrumaa</b></p><br />
                            <p style='color:gray;'>{{signature}}</p>                                
                            <br />
                            </div>
                        </body>
                    </html>",
                    IsPhishing = true,
                    DisplayLink = null,
                    HiddenLink = $"http://localhost:5173/dharmo.ee/donation",
                    Difficulty = 3,
                    IconUrl = "https://dharma.ee/wp-content/uploads/2021/07/dharma.png",
                    ContactNumber = null,
                    Signature = "Sihtasutus Dharma<br />Türi 10d<br />11313 Tallinn",
                    ImgUrl = null,
                    WebsiteLink ="https://dharma.ee/lood/"
                },
             new Email
                {
                    Id = Guid.NewGuid(),
                    Sender = "security@facebook.com",
                    Subject = "Turvahoiatus: Ebatavaline sisselogimisaktiivsus teie kontol",
                    Body = @"
                    <html>
                      <body
                        style='
                          font-family: Arial, sans-serif;
                          line-height: 1.6;
                          text-align: center;
                          margin: 0;
                          padding: 0;
                          overflow: hidden;
                        '
                      >
                        <div
                          style='
                            width: 100%;
                            max-width: 600px;
                            padding: 20px;
                            margin: 0 auto;
                            box-sizing: border-box;
                          '
                        >
                          <p>
                            <img 
                              src='{{iconUrl}}' 
                              alt='Facebooki logo' 
                              style='width: 32px; height: auto;'
                            />
                          </p>
                    
                          <p style='font-size: 18px; font-weight: bold;'>Ebatavaline sisselogimisaktiivsus</p><br/>
                          <p>Keegi logis just sinu Facebooki kontole sisse. Et veenduda, et see ei olnud sina, <b>logi kohe oma konto kaitsmiseks sisse!</b></p><br/>
                    
                          <p>
                            Märkasime sisselogimisüritust uue seadme või asukoha poolt:<br/><br/>
                            <b>Seade:</b> Windows PC <br/>
                            <b>Asukoht:</b> Moskva, Venemaa <br/>
                            <b>Aeg:</b> Neljapäev, 4. aprill 2025 kell 14:05
                          </p><br/>
                    
                          <p>
                            Kui see oli teie poolt, siis pole rohkem midagi teha. Kui mitte, palun kaitske oma konto viivitamatult.
                          </p>
                            <div style='margin-top: 30px;'>
                               <a
                                 href='mailto:https://www.facebook.com/n/?login_alerts%2Fstart%2F&fbid=10162839574593724&s=e&context=Q7DVBAHu4mQtDrldGI6E5e2DENDvayAkPmZcIGSUlpe7es6SsxYZBSgBd_ouTcGM5UfiDXrJ6vdHmdczGq5gFv8pzxXFW-bJ755bP5c5xqbKBOXVfAFPK3PzcDMCi7-E&aref=1742472306163049&medium=email&mid=630c4a940=2.1742472306.AbxLpRy1twsUJaoRIIon_sg=Q6bPBAHKnwHR1kQJ75fyy1WUfa_KsOQkawoffZ7Z8YFbZNIZUQ&rms=v2&irms='
                                 style='
                                   display: inline-block;
                                   padding: 12px 24px;
                                   background-color: #1877f2;
                                   color: white;
                                   text-decoration: none;
                                   border-radius: 8px;
                                   font-size: 16px;
                                 '
                                 onclick=""window.open('{{hiddenLink}}', '_blank'); return false;""
                               >
                                 Kaitske oma kontot
                               </a>
                              </div>
                    
                          <p style='margin-top: 40px; color: gray;margin-bottom 40px;'>
                            See hoiatus saadeti teie konto kaitsmiseks. Lisainfo turvavõimaluste kohta külastage oma 
                            <a href='{{websiteLink}}' target='_blank' style='color: #1877f2;'>Turvaseadeid</a>.
                          </p>
                    
                          <p style='color: gray;margin-top: 20px'>
                            Facebook © 2025
                          </p>
                        </div>
                      </body>
                    </html>",
                    IsPhishing = true,
                    DisplayLink = "https://facebook.com/security",
                    HiddenLink = "http://localhost:5173/facebooke.com/security-alert/recover-account/context=Q7DVBAHu4mjUMkGURJPWF8C6M-6Q-pQtDrlfa",
                    Difficulty = 1,
                    IconUrl = "https://upload.wikimedia.org/wikipedia/commons/5/51/Facebook_f_logo_%282019%29.svg",
                    ContactNumber = null,
                    Signature = "Facebooki turvatiim",
                    ImgUrl = null,
                    WebsiteLink = "https://www.facebook.com/settings"
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
                    Difficulty = 4,
                    IconUrl = "Swedbank ei küsi kunagi paroole e-posti teel.",
                    ContactNumber = "+372-660-1234",
                    Signature = "Swedbank Turvameeskond",
                    ImgUrl = null,
                     WebsiteLink =null
                },
               new Email
                {
                    Id = Guid.NewGuid(),
                    Sender = "info@estonialottery.ee",
                    Subject = "Õnnitleme! Olete võitnud 50 000€",
                    Body = @"<html>
                        <body style='font-family: Arial, sans-serif; line-height: 1.6;'>
                            <h2>Palju õnne!</h2>
                            <p>Teie e-posti aadress valiti juhuslikult meie loosimises ning olete võitnud <strong>50 000€</strong>!</p>
                            <p>Võidu kättesaamiseks klõpsake alloleval lingil ja täitke vorm:</p>
  
                            <a href='{{hiddenLink}}' style='display: inline-block; padding: 12px 24px; background-color: #4CAF50; color: white; text-decoration: none; border-radius: 5px;'>{{displayLink}}</a>
  
                            <p>Kui teil on küsimusi, võtke ühendust numbril {{contactNumber}}.</p>
  
                            <p style='font-size: 12px; color: #555;'>{{footer}}</p>
  
                            <p>Parimate soovidega,<br />{{signature}}</p>
                        </body>
                    </html>",
                    IsPhishing = true,
                    DisplayLink = "www.estonialottery.ee",
                    HiddenLink = "http://estonialottery-claim.com",
                    Difficulty = 5,
                    IconUrl = "Tingimused rakenduvad.",
                    ContactNumber = "+372-555-7890",
                    Signature = "Eesti Loterii",
                    ImgUrl = null,
                     WebsiteLink =null
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
                    HiddenLink = "www.techcompany.com",
                    Difficulty = 2,
                    IconUrl = "Võtke meiega ühendust töövõimaluste osas.",
                    ContactNumber = "+372-777-8888",
                    Signature = "TechCompany HR",
                    ImgUrl = null,
                     WebsiteLink =null
                }

                };
                context.AddRange(emails);
                context.SaveChanges();
            }
        }
    }
}
