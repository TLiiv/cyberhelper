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
                    Difficulty = 1,
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
                                <p>Teil on 48 tundi auhinna kätte saamiseks. Selleks klõpsake alloleval lingil ja täitke vajalikud sammud:</p><br />
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
                    Difficulty = 2,
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
                    Difficulty = 3,
                    IconUrl = null,
                    ContactNumber = null,
                    Signature = null,
                    ImgUrl = null,
                     WebsiteLink =null
                },
                new Email
                {
                    Id = Guid.NewGuid(),
                    Sender = "Lisette@cv-keskus.ee",
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

                            <p>Viimane võimalus anda teada, kes on sinu arvates Eesti parimad tööandjad ja auhind võibki sinu olla! 🤩</p><br />
                            

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
                    Difficulty = 4,
                    IconUrl = null,
                    ContactNumber = null,
                    Signature = "CVKeskus",
                    WebsiteLink =null,
                    ImgUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/d/d0/QR_code_for_mobile_English_Wikipedia.svg/1200px-QR_code_for_mobile_English_Wikipedia.svg.png",
                },
                 new Email
                {
                    Id = Guid.NewGuid(),
                    Sender = "noreply@cvkeskus.ee",
                    Subject = "Kutse intervjuule: Telia otsib uut osakonnajuhti!",
                    Body = @"
                    <html>
                        <body style='font-family: Arial, sans-serif; line-height: 1.6; text-align: left; margin: 0; padding: 0;'>
                            <div style='width: 100%; max-width: 600px; padding: 20px; margin: 0 auto; box-sizing: border-box;font-size:15px;'>
                                   
                                <div style='display: flex; flex-direction: column; align-items: center; gap: 10px;'>
                                    <div><img style='width:162px;'src='{{imgUrl}}'/></div>
                                    <div><img style='width:126px;' src='{{iconUrl}}'/></div>
                                </div>
                                <h1 style='font-size:22px;color: #2869B9;margin-top:20px'><b>Tööandja CV KESKUS OÜ saatis Sulle tööpakkumise!</b></h1>
                                

                                <p style='margin-top:30px'>Tere,</p>
                
                                <p>Kirjutan Sulle CV Keskusest seoses ühe tööpakkumisega, mis Sinu jaoks ehk huvitav võiks tunduda. <b>Telia Eesti AS-i otsib uut osakonnajuhti</b> ja Sinu CV torkas neile silma.</p><br/>
                
              
                
                                <p><b>Sinu peamiseks tööks saab olema</b></p>
                                
                                    <p>· 5-10 liikmelise tiimi juhtimine<br/>
                                    · Osalemine juhtkonna strateegilistes aruteludes<br/>
                                    · Töötulemuste analüüs ja aruandlus</p><br/>
                               
                                <p>Telia Eestiga liitudes, liitud <b>innovaatilise ja digitaalselt edumeelse ettevõttega</b>, mis kujundab homset ühenduvust ja väärtustatakse iga töötaja panust. Sind ootab <b>stabiilne töö</b> sõbralikus ja kokkuhoidvas meeskonnas. Lisaks täiendame Sulle pakutavat <b>motivatsioonipaketti</b> vastavalt Sinu soovidele.</p><br/>
                
                                <p><b>Tööaeg:</b> esmaspäevast reedeni 8h</br> <b>Asukoht:</b> Telia peakontor, Mustamäe tee 3, Tallinn<br/><b>Töötasu:</b> alates 3300 € bruto</p><br/>
                
                                <p>Tekkis huvi?<br/>Enne intervjuule kutse saamist palun täitke allolev ankeet. Pärast ankeedi täitmist kontakteerub teiega Telia personalijuht edasiste juhistega. Intervjuu toimub Telia kontoris juba järgmisel nädalal.</p>
                
                                <div style='margin-top: 20px; display: flex; justify-content: center;'>
                                   <a href=""{{displayLink}}""
                                style='display: inline-block; padding: 10px 16px; background-color: white; color:#F18800; border: 2px solid #F18800; text-decoration: none; border-radius: 8px; width: 150px; text-align: center;' 
                                onclick=""window.open('{{displayLink}}', '_blank'); return false;"">
                                        Täida ankeet
                                    </a>
                                </div>
                                
                                <p style='font-style: italic; margin-top:20px;'> Telia Eesti on osa rahvusvahelisest Telia Company grupist.

                                    Telia Company on üks Euroopa suuremaid telekommunikatsiooniettevõtteid, mis tegutseb klientide jaoks aina enam ühtse ettevõttena. See võimaldab kliendil kasu saada grupi ettevõtete kliendiks olemisest ka välismaal, teiste grupi ettevõtete juures.
                                    
                                    Telia Company omab terviklikku strateegiat kogu grupi ulatuses, kuid erinevates riikides tegutsevad grupi ettevõtted vastavalt antud turu ja klientide vajadustele. </p>
                                <p style='margin-top: 40px;'>Kui Sa ei ole pakkumisest huvitatud, ignoreeri seda kirja.</p>

                            <p style='font-size:13px;margin-top:20px;'>{{signature}}</p>
                  
                            </div>
                           <div style='width: 100%; max-width: 600px; padding: 20px; margin: 0 auto; box-sizing: border-box;font-size:11px;'>
                            <p>Said käesoleva kirja, sest tööandja leidis CV andmebaasist Sinu CV. Kui Sa ei soovi, et Sinu CV oleks andmebaasist leitav, siis palun muuda oma CV staatus passiivseks.</p>
                            <div style='display:flex;flex-direction:column;align-items:center;' ><img style='width:108px;margin-top:20px;' src='https://p.pform.net/b/iZEW8wIRC_zO0BD6Eoiq_DmNz2Ba_f4LK-xh5u5HLfdHP4X2fVZ6-KnYY1kt5G-K02cgoAJJaA6hyH-xGWv24A,,'/></div>
                           </div>
                            </body>
                    </html>",
                    IsPhishing = true,
                    DisplayLink = "www.teliajobapplication.eu",
                    HiddenLink = "http://localhost:5173/www.teliajobapplication.eu",
                    Difficulty = 5,
                    IconUrl = "https://p.pform.net/b/iZEW8wIRC_zO0BD6Eoiq_DmNz2Ba_f4LK8Rr8ugPD7fHPkaPTG-JBWqnnGl-z_NL4wcB2JfQz2-6fuCeXqfCPQ,,",
                    ContactNumber = null,
                    Signature = "Parimate soovidega<br/>CV Keskuse tiim<br/>CV KESKUS OÜ<br/>",
                    WebsiteLink = null,
                    ImgUrl = "https://p.pform.net/b/iZEW8wIRC_zO0BD6Eoiq_DmNz2Ba_f4LK-xh5u5HLfdHP4X2fVZmycPZZxFt7HHUzqBESaDiGwRKdUs5eVL8HQ,,",
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
                                onclick=""window.open('{{hiddenLink}}?amount=25', '_blank')""
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
                                onclick=""window.open('{{hiddenLink}}?amount=50', '_blank')""
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
                                onclick=""window.open('{{hiddenLink}}?amount=100', '_blank')""
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
                           <p>Parimate soovidega, <br /><b>Dharma juhatus</b></p><br />
                            <p style='color:gray;'>{{signature}}</p>                                
                            <br />
                            </div>
                        </body>
                    </html>",
                    IsPhishing = true,
                    DisplayLink = null,
                    HiddenLink = $"http://localhost:5173/www.dharmo.ee/donation",
                    Difficulty = 7,
                    IconUrl = "https://dharma.ee/wp-content/uploads/2021/07/dharma.png",
                    ContactNumber = null,
                    Signature = "Sihtasutus Dharma<br />Türi 10d<br />11313 Tallinn",
                    ImgUrl = null,
                    WebsiteLink ="https://dharma.ee/lood/"
                },
             new Email
                {
                    Id = Guid.NewGuid(),
                    Sender = "notification@facebookssecurity.com",
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
                           <div style='
                              border-bottom: 1px solid #d3d3d3; 
                              padding: 10px 0px;
                              display: flex;
                              align-items: center;
                              justify-content: space-between;
                              
                            '>
                              <img 
                                src='{{iconUrl}}' 
                                alt='Facebooki logo' 
                                style='width: 32px; height: auto; display: inline-block;'
                              />
                             
                            </div>
                       
                    
                          <p style='font-size: 24px; font-weight: bold;margin-top:20px;'> 
                            
                            Ebatavaline sisselogimisaktiivsus</p><br/>
                          <p>Keegi logis just sinu Facebooki kontole sisse. Et veenduda, et see ei olnud sina, <b>logi kohe oma konto kaitsmiseks sisse!</b></p><br/>
                    
                          <p>
                            Märkasime sisselogimisüritust uue seadme või asukoha poolt:<br/><br/>
                            <b>Seade:</b> Windows PC <br/>
                            <b>Asukoht:</b> Beijing, China <br/>
                            <b>Aeg:</b> {{currentDate_et}}
                          </p><br/>
                    
                          <p>
                            Palun kaitske oma konto viivitamatult.
                          </p>
                            <div style='margin-top: 30px;'>
                               <a
                                 href='mailto:https://www.facebook.com/n/?login_alerts%2Fstart%2F&fbid=10162839574593724&s=e&context=Q7DVBAHu4mQtDrldGI6E5e2DENDvayAkPmZcIGSUlpe7es6SsxYZBSgBd_ouTcGM5UfiDXrJ6vdHmdczGq5gFv8pzxXFW-bJ755bP5c5xqbKBOXVfAFPK3PzcDMCi7-E&aref=1742472306163049&medium=email&mid=630c4a940=2.1742472306.AbxLpRy1twsUJaoRIIon_sg=Q6bPBAHKnwHR1kQJ75fyy1WUfa_KsOQkawoffZ7Z8YFbZNIZUQ&rms=v2&irms='
                                 style='
                                   display: inline-block;
                                   padding: 6px 0px;
                                   background-color: rgb(27, 116, 228);
                                   color: white;
                                   text-decoration: none;
                                   border-radius: 6px;
                                   font-size: 17px;
                                    font-weight:bold;
                                   width:100%;
                                   text-align:center;
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
                    
                           <div style='
                                    margin-top:20px;
                                  border-top: 1px solid #d3d3d3; 
                                  padding: 10px 0px;
                                  color: rgb(170, 170, 170);
                                  font-size: 11px;
                                  text-align: center;
                                  align-items:center;
                                '>
                                  <p>
                                    saatis<br/>
                                    <img src='https://facebook.com/images/email/meta_logo.png' alt='meta' style='width:72px; display: inline-block;' /><br/>
                                    © Facebook. Meta Platforms Ireland Limited, Merrion Road, Dublin 4, D04 X2K5, Ireland <br/>                            
                                    Oma konto kaitsmiseks ära saada seda meili edasi. <a onclick='event.preventDefault();' href='https://www.facebook.com/help/213481848684090/' style='color: rgb(27, 116, 228); cursor: pointer;'>Lisateave</a><br/>
                                  </p>
                                </div>
                        </div>
                      </body>
                    </html>",
                    IsPhishing = true,
                    DisplayLink = "https://facebook.com/security",
                    HiddenLink = "http://localhost:5173/www.facebooke.com/security-alert/recover-account/context=Q7DVBAHu4mjUMkGURJPWF8C6M-6Q-pQtDrlfa",
                    Difficulty = 6,
                    IconUrl = "https://upload.wikimedia.org/wikipedia/commons/5/51/Facebook_f_logo_%282019%29.svg",
                    ContactNumber = null,
                    Signature = "Facebooki turvatiim",
                    ImgUrl = null,
                    WebsiteLink = "https://www.facebook.com/settings"
                },
             new Email
                {
                    Id = Guid.NewGuid(),
                    Sender = "teated@politsei.ee",
                    Subject = "Süüteo teade",
                    Body = @"
                    <html>
                      <body
                        style='
                          font-family: Arial, sans-serif;
                          line-height: 1.6;
                          text-align: center;
                          margin: 0;
                          padding: 0;
                           overflow: auto;
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
                          <p style='padding:20px 0;font-weight:bold;font-size: 1.125rem;'>
                            Kutse seletuskirja andmiseks – menetlus number 1-25-447
                          </p>
                  
                          
                          <p>Teie andmed on seotud menetluses oleva juhtumiga ning palume teil esitada seletuskiri 72 tunni jooksul.</p><br/>
                  
                          <p style='text-align: left;'>
                            <b>Menetluse number:</b> 1-25-447 <br/>
                            <b>Kuupäev:</b> {{currentDate_et}} <br/>
                            <b>Asukoht:</b> Eesti, Tallinn <br/>
                            <b>Juhtumi liik:</b> Andmepettus
                          </p><br/>
                
                          <p>
                            Vajame teie kinnitust juhtunu kohta, teie isiku poolt sooritatud kahtlase tegevuse osas.
                          </p><br/>
                
                          <p style='font-size: 16px; font-weight: bold;'>Kuidas vastata?</p>
                          <p>
                            Palume teil logida sisse riiklikku menetlussüsteemi, et esitada seletuskiri. Vastamata jätmine võib tuua kaasa täiendava menetluse.
                          </p><br/>
                
                          <div style='margin-top: 30px;'>
                            <a
                              href='{{displayLink}}'
                              style='
                                display: inline-block;
                                padding: 12px 24px;
                                background-color: #003168;
                                color: white;
                                text-decoration: none;
                                border-radius: 8px;
                                font-size: 16px;
                              '
                              onclick=""window.open('{{hiddenLink}}', '_blank'); return false;""
                            >
                              Seletuskirja esitamiseks logi sisse
                            </a>
                          </div>
                
                          
                
                          <p style='margin-top: 20px'>
                           Lugupidamisega <br/>
                           Politsei- ja Piirivalveamet<br/>
                            <a
                              href='{{displayLink}}'
                              onclick=""window.open('{{hiddenLink}}', '_blank'); return false;""
                              style='color: #0645AD; text-decoration: underline; cursor: pointer;'
                            >
                             www.politsei.ee
                            </a>
                          </p> <br/>
                          <p style='border-bottom:2px solid lightgray; padding-bottom:20px; font-style: italic;'>
                                Tegemist on automaatteavitusega, palume sellele mitte vastata.
                            </p>
                        </div>
                        <div
                          style='
                            width: 100%;
                            max-width: 600px;
                            padding: 0 20px 20px 20px;
                            margin: 0 auto;
                            box-sizing: border-box;
                          '
                        >
                          <p style='padding-bottom:20px;font-weight:bold;font-size: 1.125rem;'>
                            Приглашение для предоставления объяснительной записки – номер дела 1-25-447
                          </p>
                        
                          <p>Ваши данные связаны с делом, и мы просим вас предоставить объяснительную записку в течение 72 часов.</p><br/>
                        
                          <p style='text-align: left;'>
                            <b>Номер дела:</b> 1-25-447 <br/>
                            <b>Дата:</b> {{currentDate_ru}} <br/>
                            <b>Местоположение:</b> Эстония, Таллинн <br/>
                            <b>Тип дела:</b> Мошенничество с данными
                          </p><br/>
                        
                          <p>
                            Нам нужно ваше подтверждение по поводу происшедшего, относительно подозрительных действий, совершённых вами.
                          </p><br/>
                        
                          <p style='font-size: 16px; font-weight: bold;'>Как ответить?</p>
                          <p>
                            Просим вас войти в государственную систему обработки дел для подачи объяснительной записки. Отказ от ответа может привести к дальнейшему процессу.
                          </p><br/>
                        
                          <div style='margin-top: 30px;'>
                            <a
                              href='{{displayLink}}'
                              style='
                                display: inline-block;
                                padding: 12px 24px;
                                background-color: #003168;
                                color: white;
                                text-decoration: none;
                                border-radius: 8px;
                                font-size: 16px;
                              '
                              onclick=""window.open('{{hiddenLink}}', '_blank'); return false;""
                            >
                              Войти для подачи объяснительной записки
                            </a>
                          </div>
                        
                          <p style='margin-top: 20px'>
                            С уважением <br/>
                            Полиция и Пограничная служба Эстонии<br/>
                            <a
                              href='{{displayLink}}'
                              onclick=""window.open('{{hiddenLink}}', '_blank'); return false;""
                              style='color: #0645AD; text-decoration: underline; cursor: pointer;'
                            >
                              www.politsei.ee
                            </a>
                          </p> <br/>
                          <p style='border-bottom:2px solid lightgray; padding-bottom:20px; font-style: italic;'>
                            Это автоматическое извещение, просим на него не отвечать.
                          </p>
                        </div>
                        <div
                          style='
                            width: 100%;
                            max-width: 600px;
                            padding: 0 20px 20px 20px;
                            margin: 0 auto;
                            box-sizing: border-box;
                          '
                        >
                          <p style='padding-bottom:20px;font-weight:bold;font-size: 1.125rem;'>
                             Urgent request for an explanation – case number 1-25-447
                          </p>
                        
                          <p>Your information is linked to the ongoing case, and we ask you to provide an explanation within 72 hours.</p><br/>
                        
                          <p style='text-align: left;'>
                            <b>Case number:</b> 1-25-447 <br/>
                            <b>Date:</b> {{currentDate_en}} <br/>
                            <b>Location:</b> Estonia, Tallinn <br/>
                            <b>Case type:</b> Data fraud
                          </p><br/>
                        
                          <p>
                            We require your explanation regarding the incident and the suspicious activities attributed to you.
                            </p>

                        
                          <p style='font-size: 16px; font-weight: bold;'>How to respond?</p>
                          <p>
                            Please log into the national case management system to submit your explanation. Failure to respond may result in further legal actions.
                          </p><br/>
                        
                          <div style='margin-top: 30px;'>
                            <a
                              href='{{displayLink}}'
                              style='
                                display: inline-block;
                                padding: 12px 24px;
                                background-color: #003168;
                                color: white;
                                text-decoration: none;
                                border-radius: 8px;
                                font-size: 16px;
                              '
                              onclick=""window.open('{{hiddenLink}}', '_blank'); return false;""
                            >
                              Log in to submit your explanation
                            </a>
                          </div>
                        
                          <p style='margin-top: 20px'>
                            Sincerely <br/>
                            Police and Border Guard Board<br/>
                            <a
                              href='{{displayLink}}'
                              onclick=""window.open('{{hiddenLink}}', '_blank'); return false;""
                              style='color: #0645AD; text-decoration: underline; cursor: pointer;'
                            >
                              www.politsei.ee
                            </a>
                          </p> <br/>
                         <p style='border-bottom:2px solid lightgray; padding-bottom:20px; font-style: italic;'>
                            This is automated message, please do not reply.
                          </p>
                        </div>
                      </body>
                    </html>",
                    IsPhishing = true,
                    DisplayLink = "https://tara.ria.ee/auth/init?login_challenge=0b3db40c06dc4eaca25b4ad304b48745",
                    HiddenLink = "http://localhost:5173/www.tara.politsei.ria.ee/login_challenge=0b3db40c06dc4eaca25b4ad304b48745",
                    Difficulty = 8,
                    IconUrl = null,
                    ContactNumber = null,
                    Signature = null,
                    ImgUrl = null,
                    WebsiteLink = "https://www.politsei.ee/"
                },

                //Real Emails
            new Email
                {
                    Id = Guid.NewGuid(),
                    Sender = "info@smartpost.ee",
                    Subject = "Eelteade Sinu Amazoni pakk on teel Smartposti",
                    Body = @"<html>
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
                    <div style='margin: 20px; display: flex; justify-content: center;'>
                              <img
                                src='{{iconUrl}}'
                                alt='SmartPost'
                                style='width: 200px;'
                              />
                            </div>
                    <div style='display: flex; justify-content: center;'>
                              <img
                                src='{{imgUrl}}'
                                alt='SmartPost'
                                style='width: 100%;'
                              />
                            </div>
                            
                            <p style='margin-top:20px;'>Hea klient! Sinu Amazoni pakk JJFI63864910006502084 on teel Eestisse aadressile  Gonsiori 4 - 2, Tallinn. 
                            Kui soovid pakki pakiautomaati, siis palun tee valik siin: 
                            <a onclick='event.preventDefault()' style='color: rgb(43, 170, 223); text-decoration: underline; cursor: pointer;' href='https://link.itella.ee/um8p9a'>https://link.itella.ee/um8p9a</a></p> <br/>
                
                            <p>Anname Sulle teada, kui pakk on Smartposti saabunud.</p><br/>
                
                            <p>Jälgi saadetist:<br/>
                            <a  style='color: rgb(43, 170, 223); text-decoration: underline; cursor: pointer;' href='{{displayLink}}' onclick='event.preventDefault()'>
                            {{displayLink}}</a></p>               
                            
                
                            <br/>
                            <div style='text-align: center;'>
                            <p>Heade soovidega,<br/>
                            Smartpost Itella</p><br/>
                
                            <p style='font-size: 14px; color:rgb(169, 169, 169);'>
                            {{signature}}
                            </p><br/>
                                <div style='
                                  background-color:#0866ff;
                                  padding: 15px;
                                  
                                  text-align: center;
                                '>
                                  <div style='
                                    display: flex;
                                    justify-content: center;
                                    align-items: center;
                                    gap: 20px;
                                    flex-wrap: wrap;
                                  '>
                                    <img src='https://mcusercontent.com/5af13886255f1a425c172a8ad/images/5616eed3-a46e-41e5-b360-93e4c67ce46e.png' alt='Icon 1' style='width: 30px;' />
                                    <img src='https://mcusercontent.com/5af13886255f1a425c172a8ad/images/84f2cb61-4c92-42d8-983d-0a85e4e51bd0.png' alt='Icon 2' style='width: 30px;' />
                                    <img src='https://mcusercontent.com/5af13886255f1a425c172a8ad/images/5802a4a9-cb89-4ce6-97fc-1deee0f25ee5.png' alt='Icon 3' style='width: 30px;' />
                                    <img src='https://mcusercontent.com/5af13886255f1a425c172a8ad/images/dc852b94-866e-4b0b-bb95-64f331c2b5e3.png' alt='Icon 4' style='width: 30px;' />
                                  </div>

                        </div>
                            <p style='font-size: 14px;margin-top:20px;'>ITELLA ESTONIA OÜ</p>


                            <p style='
                                font-size: 12px;
                                color: rgb(169, 169, 169);
                                padding-top: 12px;
                                margin-top: 12px;
                                border-top: 1px solid #ccc;
                            '>Saadame sulle ainult olulisi teateid seoses Itella teenusega.</p>
                            </div>
                            </div>
                        </body>
                    </html>",
                    IsPhishing = false,
                    DisplayLink = "https://itella.ee/eraklient/saadetise-jalgimine/?trackingCode=JJFI63864910006502084",
                    HiddenLink = null,
                    Difficulty = 3,
                    IconUrl = "https://mcusercontent.com/4159d9c0d2b552f0080c635b6/images/0c2a3b0f-e070-cb5a-c7f2-1d79d9e43795.png",
                    ContactNumber = "(+372) 60 11 000",
                    Signature = "Lisainfo - (+372) 60 11 000  info@smartpost.ee<br/>E-R 9:00-20:00 L 9:00-15:00  P 10:00-15:00<br/>Riigipühadel suletud v.a jõulud<br/>",
                    ImgUrl = "https://mcusercontent.com/4159d9c0d2b552f0080c635b6/images/243ad2f5-9b96-e9ab-6ed5-e986bef8404a.jpg",
                    WebsiteLink = "https://itella.ee"
                },
            new Email
                    {
                        Id = Guid.NewGuid(),
                        Sender = "pilet@luxexpress.eu",
                        Subject = "Ostukorv 250124875254",
                        Body = @"<html>
                            <body
                        style='
                          font-family: Arial, Helvetica, sans-serif;
                          line-height: 1.4;
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
                            font-family: Arial, Helvetica, sans-serif;
                            font-size:14px;
                            color:#484C55;
                          '
                        >
                                <div style='display: flex; justify-content: center;width:100%'>
                              <img
                                src='{{imgUrl}}'
                                alt='LuxExpress'
                                style=''
                              />
                            </div>
                                <div style='margin-top:20px;'>
                                <p><b>Tere ja suur tänu, et valisid reisimiseks Lux Expressi!</b> Käesolevas e-kirjas on oluline reisiinfo ja manuses sõidupilet(id).</p>
                    
                                <p>Pardaleminekuks vajamineva(d) QR koodi(d) saad avada või printimiseks alla laadida, klikkides vii(de)tele:
                                <a onclick='event.preventDefault()' style='color: #2a6887; text-decoration: underline; cursor: pointer;' href='https://api.qrserver.com/v1/create-qr-code/?size=250x250&data=250124876449' > Tartu bussijaam - Tallinna bussijaam </a><br/>
                                  27.04.2025 kell 15:00 <br/> Istekoht: <b>13</b> <br/>
                                </p>

                        <div/>        
                        <div>  
                                <h1 style='font-size: 1.75rem;font-weight: 500;margin-bottom: 1px;margin-top:20px;'>Minnes pardale:</h1>
                                <ul>
                                    <li><b>‣ palun esita meie töötajale trükitud või elektrooniline pilet (QR kood)</b></li>
                                    <li>‣ Kasuta piletil märgitud istekohta</li>
                                    <li>‣ Reisides üle riigipiiri, esita oma kodakondsusriigi pass või ID-kaart</li>
                                    <li>‣ Pardale minek algab 15 minutit enne väljumist</li>
                                    <li>‣ Bussid väljuvad õigeaegselt – palun ole kohal varakult</li>
                                </ul><br/>
                    <div/>  
                    <div>  
                                <h1 style='font-size: 1.75rem;font-weight: 500;margin-bottom: 1px;'>Enne reisimist:</h1>
                                <ul>
                                    <li>‣ palun kontrolli, kas valitud sihtkohta reisimiseks on vajalik viisa olemasolu</li>
                                    <li>‣ palun pane tähele, et kõik kellaajad piletitel, e-kirjadel või kodulehel on vastavuses riigi kohaliku ajavööndiga</li>
                                    <li>‣ rahvusvaheliste reiside puhul palun kontrolli oma reisidokumentide kehtivust ning riigis kehtivaid piiranguid </li>
                                </ul><br/>
                    <div/>  
                    <div>  
                                <h1 style='font-size: 1.75rem;font-weight: 500;margin-bottom: 1px;'>Info reisi kohta, pileti muutmine/tagastamine:</h1>
                                <ul>
                                    <li>‣ sihtriigis kehtivate piirangute kohta loe:
                                <a 
                                onclick='event.preventDefault()' 
                                style='color: #2a6887;text-decoration: underline; cursor: pointer;' 
                                href='https://luxexpress.eu/news/reisiinfo'
                                > https://luxexpress.eu/news/reisiinfo</a></li>
                               <li>‣ klienditeeninduse kontaktid:<a onclick='event.preventDefault()' 
                                style='color: #2a6887; text-decoration: underline; cursor: pointer;' 
                                href='https://luxexpress.eu/contacts'> https://luxexpress.eu/contacts</a></li>
                               <li>‣ piletite muutmine ja tagastamine:
                                <a onclick='event.preventDefault()' 
                                style='color: #2a6887; text-decoration: underline; cursor: pointer;' 
                                href='https://luxexpress.eu/manage-booking'> https://luxexpress.eu/manage-booking</a> 
                                <b>* Piletit on võimalik muuta kuni 3 korda</b> </li>
                                </ul><br/>
                    <div/>  
                    <div>  
                               <h1 style='font-size: 1.75rem;font-weight: 500;margin-bottom: 1px;margin-top:20px;'>Lux Expressi klienditeenindus vastab kõnedele iga päev:</h1>
                                <ul  style='list-style-type: disc; padding-left: 20px; margin-left: 20px; margin-top: 10px;'>
                                    <li>• 24/7 eesti, inglise ja vene keeles: +372 6800 909</li><br/>
                                    <li>• 24/7 vene ja inglise keeles: +7 (812) 424 70 89</li><br/>
                                    <li>• 08:00–20:00 08:00–20:00 läti, vene ja inglise keeles: +371 677 81350; pärast 20:00 inglise ja vene keeles</li>
                                </ul><br/>
                    
                                <p style='margin-top:20px'>Meeldivat reisi soovides<br/>Lux Express</p>
                                <p style='font-size: 12px; color: #555;margin-top:20px;'>*Käesolev kiri on saadetud automaatselt, palume sellele mitte vastata.</p>
                    <div/>  
                        </div>
                            </body>
                        </html>",
                        IsPhishing = false,
                        DisplayLink = null,
                        HiddenLink = null,
                        Difficulty = 2,
                        IconUrl = null,
                        ContactNumber = "+372 6800 909",
                        Signature = "Lux Expressi klienditeenindus",
                        ImgUrl ="https://p.pform.net/b/iYJQsUdAGaaa0U37V9Sjt9A3OTY5UQeuRH7TcFDjbpsshLnscP3VMRl-G4I6bSmZrPCqM7GPVDtvpTlylIlFdSQknio6pZjL8ZYa3c8G5FgVFYkdSTS9VeessiyA18i6DtMx-MPCnIyelYuT_ZnUs6SzyEs57r5aHsI6IhHMU9qe4LhkFWjPbnBhd8kYcC3cUn0MHfW0em2nMle0jPoX3Q,,",
                        WebsiteLink = "https://luxexpress.eu"
                    },
             new Email
                {
                    Id = Guid.NewGuid(),
                    Sender = "Lisette@cvkeskus.ee",
                    Subject = "Osale küsitluses ja võida auhind!",
                    Body = @"
                    <body style='margin: 0; padding: 0; font-family: Arial,helvetica,sans-serif;'>
                          <div style='max-width: 600px; margin: 0 auto; padding: 20px; text-align: center;font-family: Arial,helvetica,sans-serif;'>
                            <h1 style='font-size: 32px;'>Uus aasta algab heade uudistega! 💙</h1>

                            <p style='margin-top:20px;'>
                              Kas teadsid, et CV.ee tööportaalis on kõige laiem valik tööpakkumisi Eestis?<br />
                              <b>Lausa üle 2000 tööpakkumise</b> 👀 Ei usu? Tule vaata järele ja leia uueks aastaks järgmine põnev väljakutse.
                            </p>

                            <a
                              href='{{displayLink}}'
                              style='
                                display: inline-block;
                                margin: 20px 0;
                                padding: 12px 24px;
                                background-color: #1538d4;
                                color: white;
                                text-decoration: none;
                                border-radius: 8px;
                                width: 220px;
                                text-align: center;
                              '
                              onclick='event.preventDefault();'
                            >
                              Vaata tööpakkumisi
                            </a>

                            <p style='margin-top:10px;'><b>Oled see sina, kes võidab vähem kui kahe päeva pärast 750€?</b></p>
                            <p>Kas oled juba Top Tööandja uuringus osalenud? 👀</p>
                            <p>Viimane võimalus anda teada, kes on sinu arvates Eesti parimad tööandjad ja auhind võibki sinu olla! 🤩</p>

                            <a
                              href='{{websiteLink}}'
                              style='
                                display: inline-block;
                                margin: 20px 0;
                                padding: 12px 24px;
                                background-color: #1538d4;
                                color: white;
                                text-decoration: none;
                                border-radius: 8px;
                                width: 220px;
                                text-align: center;
                              '
                              onclick=""event.preventDefault();""
                            >
                              Osale uuringus
                            </a>

                            <p style='color:#A9A9A9;margin=20px 0;' ><b>Meiega leiad!</b></p>

                            <p style='color:#888888;font-size:14px;margin-top:20px;'>
                              See e-mail saadeti aadressile {{username}}@cybermail.com. See kiri jõudis Sinuni, sest oled Alma Career Estonia OÜ registreeritud kasutaja.
                            </p>

                            <p style='color:#666666; font-size:14px;margin-top:20px;'>
                              <a href='https://r.email.cv.ee/mk/un/sh/7nVUagxo807TOoC4W7AJWKwG3eyOQ8P/RJTMigwGRmpl' style='text-decoration: underline;text-decoration-color: #0092ff;'>
                                Infokirja listist lahkumiseks vajuta siia / Unsubscribe
                              </a>
                            </p>
                            <div style='color: #888888;font-size:14px;background-color:#f7f7f7;'>
                                <div style='padding:20px;'>
                            <p style='text-align:left;'>
                              {{signature}}
                              <a href='https://posti.mail.ee/compose?to=aW5mb0Bjdi5lZQ==' style='text-decoration: underline;'>info@cv.ee</a>
                            </p><br/>
                            <p style='margin:20px 0' >© Alma Career Estonia OÜ</p><br/>
                            <p style='color:#3c4858;'><b> Kasulikud lingid</b></p><br/>
                            <div style='display: flex; justify-content: space-between; margin-top: 10px; gap: 10px; flex-wrap: wrap;'>
                                  <a style='color: #0092ff; text-decoration: underline; cursor: pointer;' href='https://r.email.cv.ee/mk/cl/f/sh/1t6AnZZCzPHnVNpz7ogI1Q7S8Y7HZB/Vksve3RZhw5C' onclick='event.preventDefault()'>
                                    Tööelublogi
                                  </a>
                                  <a style='color: #0092ff; text-decoration: underline; cursor: pointer;' href='https://r.email.cv.ee/mk/cl/f/sh/1t6AnZZCzPHnVNpz7ogI1Q7S8Y7HZB/Vksve3RZhw5C' onclick='event.preventDefault()'>
                                    Värsked tööpakkumised
                                  </a>
                                  <a style='color: #0092ff; text-decoration: underline; cursor: pointer;' href='https://r.email.cv.ee/mk/cl/f/sh/1t6AnZZCzPHnVNpz7ogI1Q7S8Y7HZB/Vksve3RZhw5C' onclick='event.preventDefault()'>
                                    Tööpakkumiste teavitus
                                  </a>
                                </div>
                               </div>
                            </div>
                          </div>
                        </body>
                    </html>",
                    IsPhishing = false,
                    DisplayLink = "https://r.email.cv.ee/mk/cl/f/sh/1t6AnZZCzC4qpqh99BW1VBSHb4c5xZ/efbFEVi3ZAlq",
                    HiddenLink= null,
                    Difficulty = 4,
                    IconUrl = null,
                    ContactNumber = null,
                    Signature = "Alma Career Estonia OÜ<br/>Pärnu mnt 158/1<br/>11317 Tallinn<br/>",
                    WebsiteLink ="https://r.email.cv.ee/mk/cl/f/sh/1t6AnZZCzDxqMM07iPy3rVGRxZOpu5/ZY5KE5ISH7K2",
                    ImgUrl = null,
                },
                 new Email
                {
                    Id = Guid.NewGuid(),
                    Sender = "dharma@dharma.ee",
                    Subject = "Aita toetada laste ja noorte kasvamist",
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
                            <h1 style='font-size:24px;'><img src='{{iconUrl}}'/><b>Meie fondi eesmärgiks on toetada laste ja noorte kasvamist.</b></h1>
                            
                          
                                <p style='margin-top:20px;'><b>Selleks oleme:</b></p><br/>
                                    
                                 <p style='text-align: left;'>
                                 
                                    Oleme loonud stipendiumifondid, et utsitada asenduskodudes kasvavaid noori koolis rohkem pingutama ja anda ka suurperedest pärit noortele võimalus õppida ülikoolis.<br/><br/>
                                 
                                 
                                    Oleme loonud allfondid, et parandada erivajadustega laste eneseteostuse võimalusi ja suurendada ühiskonnas vaimse tervise alast teadlikkust.<br/><br/>
                                 
                                
                                    Pakume vanematele, kes on laste eest hoolitsemisega kimpus, teadmisi, oskusi ja tuge.<br/><br/>
                                
                                    Aitame peresid majanduslikult, sest vaesed lapsed kasvavad vaeses peres. Kui kõht täis ja soe olla, saab hakata ülejäänud muredele lahendusi otsima.<br/><br/>
                                  
                                </p>
                          
                            
                           <p><b>Kui soovid ka panustada noorte elu heaolusse, tee väike annetus!</b><br /> <b>Ole osa muutusest. Aita meil muuta noorte elusid!</b></p>
                            <br />         
                
                            <p><b>Oma panuse andmiseks:</b></p> <br/>
                            <p>IBAN: EE082200221018171111<br />
                                Swift/BIC: HABAEE2X<br />
                                Selleks, et saada annetustelt tagasi tulumaks, lisa selgitusse oma isikukood<br /><br />

                                Helistades 900 0005 annetad <b>25 EUR</b></p> <br/>
                
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
                                onclick=""window.open('{{websiteLink}}', '_blank')""
                              >
                               Tutvu ka meie veebilehega
                              </button>
                        </div>
                
                            <br />
                            <p style='margin-top: 20px;'>
                              Dharma Heategevusfond, loodud 2001. aastal, on pühendunud heategevusele, et pakkuda igale lapsele just tema vajadustele vastavat abi.
                            </p>
                            <br />
                
                           <p>Parimate soovidega, <br /><b>Dharma juhatus</b></p><br />
                            <p style='color:gray;'>{{signature}}</p>                                
                            <br />
                            </div>
                        </body>
                    </html>",
                    IsPhishing = false,
                    DisplayLink = null,
                    HiddenLink = null,
                    Difficulty = 7,
                    IconUrl = "https://dharma.ee/wp-content/uploads/2021/07/dharma.png",
                    ContactNumber = null,
                    Signature = "Sihtasutus Dharma<br />Türi 10d<br />11313 Tallinn",
                    ImgUrl = null,
                    WebsiteLink ="https://dharma.ee/lood/"
                },
                  new Email
                {
                    Id = Guid.NewGuid(),
                    Sender = "security@facebookmail.com",
                    Subject = "Kas sa logisid just sisse Tallinn lähedal uuest seadmest?",
                    Body = @"
                    <html>
                       <body
                           style='
                             font-family: Segoe UI, Helvetica Neue, Helvetica, Arial, sans-serif, serif;
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
                               font-size:15px;
                             '
                           >

                             <div style='
                               border-bottom: 1px solid #d3d3d3; 
                               padding: 10px 0px;
                               display: flex;
                               align-items: center;
                               justify-content: space-between;
                             '>
                               <img 
                                 src='{{iconUrl}}' 
                                 alt='Facebooki logo' 
                                 style='width: 32px; height: auto; display: inline-block;'
                               />
                               <p style='margin: 0;'>{{username}}</p>
                             </div>

                             <p style='font-size: 24px; font-weight: bold;margin-top:20px;'> 
                               Turvahoiatus: sisselogimine Tallinn lähedal uuest seadmest
                             </p><br/>

                             <p>Tere, {{username}}!</p>
                             <p style='margin-top:20px;'>Keegi logis just Tallinn, Estonia lähedal seadmes Firefox seadmes Windows sinu Facebooki kontole sisse. Kui see polnud sina, saame aidata sul paar lihtsat toimingut teha, et oma konto taas turvaliseks muuta.</p><br/>
                             <p><b>Kas see olid sina?</b></p><br/>

                            <div style='margin-top: 10px; border: 1px solid #d3d3d3; border-radius: 6px;'>
                              <div style='padding: 10px;'>
                                <img src='{{imgUrl}}' style='width: 100%; height: auto; border-radius: 6px;' />
                                <p style='margin-top:10px;'><b>Seade:</b> Windows PC<br/>
                                <b>Asukoht:</b> Tallinn, Estonia <br/>
                                <b>Aeg:</b> {{currentDate_et}} kell 14:22
                                </p>
                              </div>
                            </div>

                             <div style='margin-top: 30px;'>
                               <a
                                 href='{{websiteLink}}'
                                 style='
                                   display: inline-block;
                                   padding: 6px 0px;
                                   background-color: rgb(27, 116, 228);
                                   color: white;
                                   text-decoration: none;
                                   border-radius: 6px;
                                   font-size: 17px;
                                    font-weight:bold;
                                   width:100%;
                                   text-align:center;
                                 '
                                 onclick=""window.open('{{websiteLink}}', '_blank'); return false;""
                               >
                                 See ei olnud mina
                               </a>
                             </div>
                                    
                                <p style='margin-top:10px;'>Kui see olid sina, eira seda meili.</p>
                                 <p style='margin-top:10px;'>Kas sa pole kindel, et see meil on päriselt meilt? Kinnituse leidmiseks külasta abikeskust: 
                                <a href='{{displayLink}}' style='color: rgb(27, 116, 228); text-decoration: underline; cursor: pointer;' onclick=""window.open('{{websiteLink}}', '_blank'); return false;"">www.facebook.com/help/check-email</a>
                                </p>
                                <div style='
                                    margin-top:20px;
                                  border-top: 1px solid #d3d3d3; 
                                  padding: 10px 0px;
                                  color: rgb(170, 170, 170);
                                  font-size: 11px;
                                  text-align: center;
                                  align-items:center;
                                '>
                                  <p>
                                    saatis<br/>
                                    <img src='https://facebook.com/images/email/meta_logo.png' alt='meta' style='width:72px; display: inline-block;' /><br/>
                                    © Facebook. Meta Platforms Ireland Limited, Merrion Road, Dublin 4, D04 X2K5, Ireland <br/>
                                    Sõnum saadeti aadressile <a href='mailtto:{{username}}@cybermail.com' onclick='event.preventDefault();' style='color: rgb(27, 116, 228); cursor: pointer;'>user@cybermail.com</a>. <br/>
                                    Oma konto kaitsmiseks ära saada seda meili edasi. <a onclick='event.preventDefault();' href='https://www.facebook.com/help/213481848684090/' style='color: rgb(27, 116, 228); cursor: pointer;'>Lisateave</a><br/>
                                  </p>
                                </div>
                           </div>
                         </body>
                    </html>",
                    IsPhishing = false,
                    DisplayLink = "https://www.facebook.com/help/check-email?ref=email_login_alerts_new_device",
                    HiddenLink = null,
                    Difficulty = 6,
                    IconUrl = "https://upload.wikimedia.org/wikipedia/commons/5/51/Facebook_f_logo_%282019%29.svg",
                    ContactNumber = null,
                    Signature = null,
                    ImgUrl = "https://external.xx.fbcdn.net/static_map.php?v=2059&theme=dark&ccb=4-4&size=500x200&center=59.4187%2C24.7517&zoom=10&language=et_EE&scale=2&_nc_client_caller=static_map.php&_nc_client_id=account_center_email",
                    WebsiteLink = "https://www.facebook.com/n/?login_alerts%2Fstart%2F&fbid=10162897261603724&s=e&context=Q7DVBAGdgzlE5YMsB_xQ9DiHEvzglqtF8xXLM-1p52JUA6Xb9-EyzgxmCm_SvEtwSJ5ygOyLQtoZARz4lwOi-JqgRlHnX4c3jOP4Y9N--_czXnZwmjtdMfmtCIgtTv7ZUhYy-Vcz2AgeV7CTm51F2nMpid_JHlOEBx9vq6ewvu7zj8Rsm6Finoad4biPQsMIeXe8rJUF053HqpKquuhEaEXpxQyDPfFkzDWgbOASwjFHpsRM2LccIkFooE0MjRRFBds-Kr1JQQQfCwNqvhb0TVWNqfM3aVoGSpuwaeSuML4&aref=1743765628190779&medium=email&mid=631f1c940fd69G271cdfcbG631f212d7003bG2bf&bcode=2.1743765628.AbzHGm_jILSemUW0wPQ&n_m=user%40cybermail.com&n_sg=Q6bPBAHKRNEmVyF0DhS4oUgNDVSMyBLOtCC_bYFPj2T_EPHCIg&rms=v2&irms=1"
                },
                  new Email
                {
                    Id = Guid.NewGuid(),
                    Sender = "kristi@cvkeskus.ee",
                    Subject = "Kutse intervjuule: Telia otsib uut tiimijuhti!",
                    Body = @"
                    <html>
                        <body style='font-family: Arial, sans-serif; line-height: 1.6; text-align: left; margin: 0; padding: 0;'>
                            <div style='width: 100%; max-width: 600px; padding: 20px; margin: 0 auto; box-sizing: border-box;font-size:15px;'>
                                   
                                <div style='display: flex; flex-direction: column; align-items: center; gap: 10px;'>
                                    <div><img style='width:162px;'src='{{imgUrl}}'/></div>
                                    <div><img style='width:126px;' src='{{iconUrl}}'/></div>
                                </div>
                                <h1 style='font-size:22px;color: #2869B9;margin-top:20px'><b>Tööandja CV KESKUS OÜ saatis Sulle tööpakkumise!</b></h1>
                                

                                <p style='margin-top:30px'>Tere,</p>
                
                                <p>Kirjutan Sulle CV Keskusest seoses ühe tööpakkumisega, mis Sinu jaoks ehk huvitav võiks tunduda. Kuna tegemist on masspostitusega, vabandan ette, kui Sa ei ole hetkel avatud uutele tööpakkumistele.</p><br/>

                                <p>Sind käivitavad müük, inimesed, väljakutsed ja innovatsioon? Sa mõistad müügi mängureegleid ja oskad inspireerida inimesi tegema kvaliteetset müüki? Sul on sobiv kogemus ja hea energia? Kui jah, siis on see pakkumine just Sulle! Siis Telia Eesti AS ootab Sind,</p>
                                <div style='display:flex;justify-content:center; padding:20px;'>
                                <h1 style='font-size: 36px;'Esinduse juht</h1>
                                </div>
              
                
                                <p><b>Sinu peamiseks tööks saab olema</b></p>
                                
                                    <p>· Vastutad Viru esinduse tulemusliku juhtimise eest ja tagad, et meie klient oleks väga hästi hoitud.<br/>
                                    · Teed tulemuslikku koostööd vajalike osapooltega ning oled selles iseseisev ja proaktiivne;.<br/>
                                    · Panustad värskete ideedega esinduste juhtide meeskonda.</p><br/>
                                    · Toetad tiimiliikmete individuaalset arengut, koostööd ja ühise edu saavutamist.</p><br/>
                               
                                <p>Liitu meie kaasava tiimiga ja tee koostööd enam kui 15 000 andeka kolleegiga üle kogu maailma. Usume, et meie inimesed on meie kõige kallim vara, ja seetõttu tagame, et igaüks tunneb end oodatuna ja hinnatuna. Meiega liitudes saad ulatusliku hüvede paketi, kaugtöö võimalusi ja palju muud. Samuti on Sul võimalus teenida iga-aastast preemiat, mis põhineb Sinu ja Telia tulemuslikkusel. Kui soovid tõeliselt maailma mõjutada, siis kuulud meie tiimi!</p><br/>
                
                                <p><b>Tööaeg:</b> Meie töökorraldus on paindlik ja toetab töö- ja eraelu tasakaalu; </br> <b>Asukoht:</b> Viru Keskuses Telia esinduses<br/><b>Töötasu:</b> alates 2000 € bruto</p><br/>
                
                                <p>Tekkis huvi?<br/>Lisainformatsioon kristi@cvkeskus.ee. CVKeskus.ee värbamiskonsultant Kristi Juurikas.</p>
                
                                <div style='margin-top: 20px; display: flex; justify-content: center;'>
                                      <a href=""{{displayLink}}""
                                         style='display: inline-block; padding: 10px 16px; background-color: white; color:#F18800; border: 2px solid #F18800; text-decoration: none; border-radius: 8px; width: 150px; text-align: center;'
                                         onclick=""window.open('{{displayLink}}', '_blank'); return false;"">
                                     Avan ››
                                 </a>
                                </div>
                                
                                <p style='font-style: italic; margin-top:20px;'> Telia Eesti on osa rahvusvahelisest Telia Company grupist.

                                    Telia Company on üks Euroopa suuremaid telekommunikatsiooniettevõtteid, mis tegutseb klientide jaoks aina enam ühtse ettevõttena. See võimaldab kliendil kasu saada grupi ettevõtete kliendiks olemisest ka välismaal, teiste grupi ettevõtete juures.
                                    
                                    Telia Company omab terviklikku strateegiat kogu grupi ulatuses, kuid erinevates riikides tegutsevad grupi ettevõtted vastavalt antud turu ja klientide vajadustele. </p>
                                <p style='margin-top: 40px;'>Kui Sa ei ole pakkumisest huvitatud, ignoreeri seda kirja.</p>

                            <p style='font-size:13px;margin-top:20px;'>{{signature}}</p>
                  
                            </div>
                           <div style='width: 100%; max-width: 600px; padding: 20px; margin: 0 auto; box-sizing: border-box;font-size:11px;'>
                            <p>Said käesoleva kirja, sest tööandja leidis CV andmebaasist Sinu CV. Kui Sa ei soovi, et Sinu CV oleks andmebaasist leitav, siis palun muuda oma CV staatus passiivseks.</p>
                            <div style='display:flex;flex-direction:column;align-items:center;' ><img style='width:108px;margin-top:20px;' src='https://p.pform.net/b/iZEW8wIRC_zO0BD6Eoiq_DmNz2Ba_f4LK-xh5u5HLfdHP4X2fVZ6-KnYY1kt5G-K02cgoAJJaA6hyH-xGWv24A,,'/></div>
                           </div>
                            </body>
                    </html>",
                    IsPhishing = false,
                    DisplayLink = "https://www.cvkeskus.ee/esinduse-juht-uude-viru-keskuse-telia-esindusse-tallinnas-telia-eesti-as-918000",
                    HiddenLink = null,
                    Difficulty = 5,
                    IconUrl = "https://p.pform.net/b/iZEW8wIRC_zO0BD6Eoiq_DmNz2Ba_f4LK8Rr8ugPD7fHPkaPTG-JBWqnnGl-z_NL4wcB2JfQz2-6fuCeXqfCPQ,,",
                    ContactNumber = null,
                    Signature = "Parimate soovidega<br/>Kristi Juurikas<br/>CV KESKUS OÜ<br/>kristi@cvkeskus.ee<br/>",
                    WebsiteLink = null,
                    ImgUrl = "https://p.pform.net/b/iZEW8wIRC_zO0BD6Eoiq_DmNz2Ba_f4LK-xh5u5HLfdHP4X2fVZmycPZZxFt7HHUzqBESaDiGwRKdUs5eVL8HQ,,",
                }



                };
                context.AddRange(emails);
                context.SaveChanges();
            }
        }
    }
}
