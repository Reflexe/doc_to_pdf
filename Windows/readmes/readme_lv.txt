
======================================================================
LibreOffice 5.4 LasiMani
======================================================================


Jaunāko šīs datnes atjauninājumu meklējiet http://www.libreoffice.org/welcome/readme.html

Šī datne satur svarīgu informāciju par LibreOffice programmatūru. Iesakām šo datni rūpīgi izlasīt, pirms sākt instalēšanu.

LibreOffice kopiena ir atbildīga par šī produkta izstrādāšanu un aicina jūs apsvērt piedalīties kā kopienas dalībniekam. Ja esat jauns lietotājs, varat apmeklēt LibreOffice vietni, kur atradīsiet daudz informācijas par LibreOffice projektu un ap tā esošajām kopienām. Ejiet uz http://www.libreoffice.org/.

Vai LibreOffice tiešām ir brīvs katram lietotājam?
----------------------------------------------------------------------

LibreOffice var brīvi lietot katrs. Jūs varat instalēt LibreOffice uz tik datoriem, cik vēlaties, un izmantot jebkuriem mērķiem (tai skaitā komerciāliem, valsts iestādēs un izglītībai). Sīkākai informācijai skatiet licences tekstu, kas nāk kopā ar LibreOffice.

Kāpēc LibreOffice ir brīvs katram lietotājam?
----------------------------------------------------------------------

Jūs varat kopēt LibreOffice bez maksas, jo individuāli veidotāji un kooperatīvie sponsori ir projektējuši, izstrādājuši, testējuši, tulkojuši, dokumentējuši, atbalstījuši, reklamējuši un palīdzējuši daudzos citos veidos padarīt LibreOffice par to, kas tas ir šodien – pasaules vadošā atvērtā pirmkoda biroja programmatūru.

Ja novērtējat mūsu pūles un vēlaties nodrošināt, ka LibreOffice turpina būt pieejams arī nākotnē, lūdzu, apsveriet iespēju atbalstīt projektu - vairāk informācijas pieejams  http://www.documentfoundation.org/contribution/. Ikviens var kaut kā palīdzēt.

----------------------------------------------------------------------
Instalēšanas piezīmes
----------------------------------------------------------------------

LibreOffice vajag nesenu Java Runtime Environment (JRE) versiju pilnai funkcionalitātei. JRE nav daļa no LibreOffice instalācijas pakotnes, to vajadzētu instalēt atsevišķi.

Sistēmas prasības
----------------------------------------------------------------------

* Microsoft Windows XP SP3, Vista, 7, 8 vai 10

Lūdzu, ņemiet vērā, ka instalēšanas turpināšanai ir nepieciešama administratora tiesības.

LibreOffice reģistrēšanu par noklusējuma programmu Microsoft Office formātu atvēršanai var uzspiest vai aizliegt, izmantojot šādus instalātora komandrindas parametrus:

* REGISTER_ALL_MSO_TYPES=1 liks reģistrēt LibreOffice kā noklusējuma lietotni Microsoft Office formātiem.
* REGISTER_ALL_MSO_TYPES=1 neļaus reģistrēt LibreOffice kā noklusējuma lietotni Microsoft Office formātiem.

Lūdzu, pārliecinieties, ka sistēmas pagaidu mapē ir pietiekami daudz brīvas vietas, un pārliecinieties, ka jums ir piešķirtas gan rakstīšanas, gan lasīšanas, gan izpildes tiesības. Pirms instalēšanas sākšanas, aizveriet visas citas programmas.

LibreOffice instalēšana uz Debian/Ubuntu bāzētām Linux sistēmām
----------------------------------------------------------------------

Lai saņemtu norādes, kā instalēt valodas paku (pēc tam, kad ir uzinstalēta LibreOffice US English versija), lūdzu, izlasiet nodaļu "Valodas pakas instalēšana" zemāk.

Atspiediet lejupielādēto arhīvu un atveriet jaunizveidoto mapi. Tās nosaukums sākas ar tekstu “LibreOffice_”, versijas numuru un platformas tipu.

Tajā atrodas mape "DEBS". Atveriet to.

Veiciet labo klikšķi mapē un izvēlieties "Atvērt terminālī". Parādīsies termināļa logs. No komandrindas termināļa logā ievadiet sekojošo komandu (pirms komandas izpildes jums prasīs jūsu root lietotāja paroli):

Sekojošās komandas instalēs LibreOffice un darbvirsmas integrēšanas pakotnes (jūs varat tās vienkārši kopēt un ielīmēt termināļa ekrānā, nevis tās rakstīt):

sudo dpkg -i *.deb

Instalēšanas process nu ir pabeigts, visām LibreOffice lietotņu ikonām vajadzētu būt Lietotnes/Birojs izvēlnē.

LibreOffice instalēšana uz Fedora, openSuse, Mandriva un citām Linux sistēmām, kas izmanto RPM pakotnes
----------------------------------------------------------------------

Lai saņemtu norādes, kā instalēt valodas paku (pēc tam, kad ir uzinstalēta LibreOffice US English versija), lūdzu, izlasiet nodaļu “Valodas pakas instalēšana” zemāk.

Atspiediet lejupielādēto arhīvu un atveriet jaunizveidoto mapi. Tās nosaukums sākas ar tekstu “LibreOffice_”, versijas numuru un platformas tipu.

Šī mape satur apakšmapi "RPMS". Mainiet mapi uz "RPMS" mapi.

Veiciet labo klikšķi mapē un izvēlieties "Atvērt terminālī". Parādīsies termināļa logs. No komandrindas termināļa logā ievadiet sekojošo komandu (pirms komandas izpildes jums prasīs jūsu root lietotāja paroli):

Uz Fedora bāzētām sistēmām: su -c 'yum install *.rpm'

Uz Mandriva bāzētām sistēmām: sudo urpmi *.rpm

Uz citām RPM bāzētām sistēmām (openSUSE, u.c.): rpm -Uvh *.rpm

Instalēšanas process nu ir pabeigts, visām LibreOffice lietotņu ikonām vajadzētu būt Lietotnes/Birojs izvēlnē.

Vai arī varat izmantot skriptu “install”, kas atrodas šī arhīva augšējā direktorijā, lai instalēšanu veiktu kā lietotājs. Skripts instalēs LibreOffice ar atsevišķu profilu, kas ir atdalīts no parastā LibreOffice profila. Ņemiet vērā, ka netiks instalētas sistēmas integrācijas daļas, piemēram, darbvirsmas izvēlnes vienumi un darbvirsmas MIME tipu reģistrēšana.

Piezīmes par integrēšanu darbvirsmā Linux distribūcijām, kas nav aprakstītas instalēšanas instrukcijās augstāk
----------------------------------------------------------------------

LibreOffice vajadzētu varēt viegli uzinstalēt uz citām Linux distribūcijām, kas nav aprakstītas šajās instrukcijās. Galvenās atšķirības varētu būt integrēšana darbvirsmā.

RPMS (vai attiecīgi DEBS) mape satur arī pakotni ar nosaukumu libreoffice-freedesktop5.4-menus-5.4.0.1-1.noarch.rpm (vai attiecīgi libreoffice5.4-debian-menus_5.4.0.1-1_all.deb). Šī ir pakotne visām Linux distribūcijām, kas atbalsta Freedesktop.org specifikācijas/rekomendācijas (http://en.wikipedia.org/wiki/Freedesktop.org), un ir tā tiek nodrošināta Linux distribūcijām, kas nav apskatītas iepriekš minētajās instrukcijās.

Valodas pakas instalēšana
----------------------------------------------------------------------

Lejupielādējiet valodas paku sev vēlamajai valodai un platformai. Tās ir pieejamas no tās pašas vietas, kur atradās galvenais instalācijas arhīvs. No Nautilus datņu pārvaldnieka, atspiediet lejupielādēto arhīvu mapē (piemēram, uz darbvirsmas). Pārliecinieties, ka esat izgājis no visām LibreOffice lietotnēm (tai skaitā no ātrā palaidēja, ja tas ir startēts).

Atveriet mapi, kurā lejupielādējāt valodas paku.

Tagad atveriet mapi, kas tika izveidota atspiešanas procesā. Piemēram, franču valodas paka 32-bitu Debian/Ubuntu bāzētām sistēmām mapes nosaukums ir LibreOffice_ un klāt vēl versijas informācija un Linux_x86_langpack-deb_fr.

Tagad atveriet mapi, kura satur pakotnes, kuras jāinstalē. Uz Debian/Ubuntu bāzētām sistēmām mapes nosaukums ir DEBS. Uz Fedora, openSUSE vai Mandriva sistēmām mape ir RPMS.

No Nautilus datņu pārvaldnieka, veiciet labo klikšķi uz mapes un izvēlieties "Atvērt terminālī". Tikko atvērtajā termināļa logā izpildiet komandu, lai instalētu valodas paku (visām komandām zemāk varētu prasīt root lietotāja paroli):

Uz Debian/Ubuntu bāzētām sistēmām: sudo dpkg -i *.deb

Uz Fedora bāzētām sistēmām: su -c 'yum install *.rpm'

Uz Mandriva bāzētām sistēmām: sudo urpmi *.rpm

Uz citām sistēmām, kas lieto RPM (openSUSE, u.c.): rpm -Uvh *.rpm

Tagad palaidiet kādu no LibreOffice lietotnēm, piemēram, Writer. Ejiet uz izvēlni "Rīki" (Tools) un izvēlieties "Opcijas" (Options). Opciju dialoglodziņā klikšķiniet uz "Valodas iestatījumi" (Language Settings) un izvēlieties "Valodas" (Languages). Sarakstā "Lietotāja saskarne" (User interface) norādiet valodu, kuru tikko uzinstalējāt. Ja vēlaties, dariet to pašu ar "Lokāles iestatījumi" (Locale setting), "Noklusējuma valūta" (Default currency), un "Noklusējuma valodas dokumentiem" (Default languages for documents).

Pēc iestatījumu pieregulēšanas, spiediet 'Labi' (OK). Dialoglodziņš aizvērsies un jūs redzēsiet paziņojumu, ka izmaiņas stāsies spēkā pēc iziešanas no LibreOffice un tā atkārtotas palaišanas (atcerieties, ka jāiziet arī no ātrā palaidēja, ja tas ir palaists).

Nākamo reizi palaižot LibreOffice, tiks startēta valoda, kuru jūs tikko uzinstalējāt.

----------------------------------------------------------------------
Problēmas ar programmas palaišanu
----------------------------------------------------------------------

Dažādus sarežģījumus LibreOffice palaišanā (piem. programmas uzkāršanos) kā arī problēmas ar datora displeju mēdz radīt video kartes draiveri. Ja rodas šādas problēmas, atjauniniet videokartes draiveri vai arī mēģiniet lietot draiveri, kas tiek piedāvāts kopā ar jūsu operētājsistēmu. Ja rodas problēmas ar 3D objektiem, tās var atrisināt deaktivizējot OpenGL lietošanu, to var izdarīt pie 'Rīki - Opcijas - LibreOffice - Skats - 3D skats'.

----------------------------------------------------------------------
ALPS/Synaptics piezīmjdatoru skārienjūtīgie paneļi Windows vidē
----------------------------------------------------------------------

Dažādu Windows draiveru problēmu dēļ jūs nevarat ritināt LibreOffice dokumentus, slidinot pirkstu pār piezīmjdatoru ALPS/Synaptics skārienpalikņiem.

Lai ieslēgtu ritināšanu ar ALPS/Synaptics skārienpalikņiem, pievienojiet sekojošas rindiņas "C:\Program Files\Synaptics\SynTP\SynTPEnh.ini" konfigurācijas datnei un pārstartējiet datoru:

[LibreOffice]

FC = "SALFRAME"

SF = 0x10000000

SF |= 0x00004000

Dažādās Windows versijās šī konfigurācijas datnes atrašanās vieta var atšķirties.

----------------------------------------------------------------------
Īsinājumtaustiņi
----------------------------------------------------------------------

LibreOffice kā īsinājumtaustiņus var lietot tikai tās taustiņu kombinācijas, kas netiek lietotas operētājsistēmā. Ja kāda LibreOffice taustiņu kombinācija nedarbojas kā aprakstīts LibreOffice palīdzībā, pārbaudiet, vai to nav aizņēmusi operētājsistēma. Lai atrisinātu iespējamo konfliktu, varat izmainīt operētājsistēmas taustiņu kombinācijas. Vai arī varat izmainīt gandrīz jebkuru LibreOffice taustiņu kombināciju. Sīkāku informāciju lasiet LibreOffice palīdzībā vai savas operētājsistēmas palīdzības dokumentācijā.

----------------------------------------------------------------------
Problēmas ar dokumentu sūtīšanu pa e-pastu no LibreOffice
----------------------------------------------------------------------

Problēmas, kas rodas sūtot dažu versiju dokumentus pa e-pastu, izmantojot 'Datne - Sūtīt - Dokumentu kā e-pastu' vai 'Dokumentu kā PDF pielikumu' rodas dēļ Windows sistēmas datnes "Mapi" (Messaging Application Programming Interface), kas rada problēmas ar dažām datņu versijām. Diemžēl šo problēmu nevar sašaurināt līdz ierobežotam versiju lokam. Sīkāku informāciju meklējiet http://www.microsoft.com zināšanu datubāzē saistībā ar "mapi dll"

----------------------------------------------------------------------
Svarīgas pieejamības piezīmes
----------------------------------------------------------------------

Lai iegūtu informāciju par LibreOffice pieejamības iespējam, skatiet http://www.libreoffice.org/accessibility/

----------------------------------------------------------------------
Lietotāju atbalsts
----------------------------------------------------------------------

Galvenā atbalsta lapa http://www.libreoffice.org/support/ piedāvā dažādas palīdzības iespējas darbā ar LibreOffice. Jūsu jautājumam varbūt jau ir atbilde - pārbaudiet kopienas forumu http://www.documentfoundation.org/nabble/ vai meklējiet 'users@libreoffice.org' e-pasta sarakstes arhīvos http://www.libreoffice.org/lists/users/. Varat sūtīt jautājumus uz users@libreoffice.org. Kā pierakstīties šim sarakstam (lai saņemtu atbildes) ir aprakstīts šajā lapā: users+subscribe@libreoffice.org.

Tāpat ieskatieties mūsu biezāk uzdoto jautājumu sadaļā http://www.libreoffice.org/faq/.

----------------------------------------------------------------------
Kļūdu un problēmu ziņošana
----------------------------------------------------------------------

Pašlaik mūsu sistēma kļūdu ziņošanai, izsekošana un labošanai ir BugZilla, kas tiek izmitināta vietnē https://bugs.libreoffice.org/. Mēs aicinām katru lietotāju ziņot par kļūdām un problēmām, kas gadās, lietojot šo programmatūru to izmantotajā platformā. Cītīga ziņošana par kļūdām ir viena no svarīgākajiem pienesumiem, ko lietotāju kopiena var sniegt, lai LibreOffice turpinātu attīstīties un uzlaboties.

----------------------------------------------------------------------
Kā iesaistīties 
----------------------------------------------------------------------

LibreOffice kopiena iegūtu ļoti daudz no jūsu aktīvas līdzdalības šajā svarīgajā atvērtā pirmkoda projektā.

Jau kā lietotājam jums ir svarīga loma šīs biroja programmatūras izstrādes procesā, tāpēc mēs gribētu mudināt jūs piedalīties vēl aktīvāk, kļūstot par pastāvīgu mūsu kopienas atbalstītāju. Lūdzu, pievienojieties un apskatiet mūsu lietotāju lapu http://www.libreoffice.org/contribution/

Kā sākt
----------------------------------------------------------------------

Labākais veids, kā sākt atbalstīt, ir pierakstīties kādā no adresātu sarakstiem un kādu brīdi sekojot līdzi visam tajā notiekošajam. Tas jums ļaus iepazīties ar dažādiem aktuāliem jautājumiem, kas ir risināti kopš LibreOffice pirmkods tika pirmoreiz publicēts 2000. gada oktobrī. Kad esat iepazinies ar notiekošo, viss, kas jums jāizdara ir jānosūta iepazīšanās e-pasts un jāsāk piedalīties. Ja atklātā pirmkoda vide jums nav sveša, varat ieskatīties mūsu darāmo darbu sarakstā, iespējams, tur ir kas tāds, kur jūs vēlētos palīdzēt http://www.libreoffice.org/develop/.

Abonēt
----------------------------------------------------------------------

Šīs ir daži no adresātu sarakstiem, kurus jūs varat abonēt: http://www.libreoffice.org/contribution/

* Ziņas: announce@documentfoundation.org *ieteicams visiem lietotājiem* (maza informācijas plūsma) 
* Galvenā lietotāju sarakste: users@global.libreoffice.org *vienkāršs veids, kā novērot sarunas* (liela plūsama)
* Mārketinga projekts: marketing@global.libreoffice.org *vairāk nekā izstrāde* (plūsma kļūst liela)
* Galvenā izstrādātāju sarakste: libreoffice@lists.freedesktop.org (liela plūsma)

Pievienojieties vienam vai vairākiem projektiem
----------------------------------------------------------------------

Jūs varat sniegt nopietnu ieguldījumu šī svarīgā projekta izstrādē un attīstībā, pat ja jums ir ierobežotas programmēšanas zināšanas. Jā, tieši jūs!

Mēs ceram, ka jums patiks strādāt ar jauno LibreOffice 5.4 un jūs mums pievienosieties tiešsaistē.

LibreOffice kopiena

----------------------------------------------------------------------
Izmantotais / modificētais pirmkods
----------------------------------------------------------------------

Daļa no autortiesībām 1998, 1999 James Clark. Daļa no autortiesībām 1996, 1998 Netscape Communications Corporation.
