
======================================================================
LibreOffice 5.4 PročitajMe
======================================================================


Za najnovije inačice ove "readme" datoteke, pogledajte http://www.libreoffice.org/welcome/readme.html

Ova datoteka sadrži bitne informacije o programskom paketu LibreOffice. Preporučujemo vam da pažljivo pročitate ove informacije prije pokretanja instalacije.

Zajednica LibreOffice je odgovorna za razvoj ovog proizvoda te vas poziva da razmislite o sudjelovanju kao član zajednice. Ukoliko ste novi korisnik, možete posjetiti internetske stranice LibreOffice gdje ćete pronaći mnoštvo informacija o projektu LibreOffice i zajednicama koje se okupljaju oko njega. Pogledajte http://www.libreoffice.org/.

Je li LibreOffice stvarno besplatan za bilo kojeg korisnika?
----------------------------------------------------------------------

LibreOffice mogu slobodno koristiti svi. Ovu kopiju LibreOfficea možete instalirati na koliko god računala želite i koristiti u koju god svrhu želite (komercijalne, državne, administrativne i edukacijske). Za više informacija pogledajte tekst licence uklopljen u preuzetu inačicu LibreOfficea.

Zašto je LibreOffice besplatan za bilo kojeg korisnika?
----------------------------------------------------------------------

Ovu kopiju LibreOffice možete koristiti bez naplate jer su se pojedinci i korporativni sponzori udružili i dizajnirali, razvili, testirali, preveli, dokumentirali, podržali, reklamirali, ili pomogli na druge načine u stvaranju današnje inačice LibreOffice paketa - vodećeg uredskog paketa otvorenog koda.

Cijenite li njihove napore i želite li osigurati budućnost LibreOffice, razmislite o doprinošenju projektu - za detalje pogledajte http://www.documentfoundation.org/contribution/. Svatko može sudjelovati na neki način.

----------------------------------------------------------------------
Zabilješke o instalaciji
----------------------------------------------------------------------

LibreOffice zahtjeva noviju inačicu Java Runtime Environment (JRE) za potpunu funkcionalnost. JRE nije dio LibreOffice instalacijskog paketa i treba se instalirati odvojeno.

Zahtjevi prema sustavu
----------------------------------------------------------------------

* Microsoft Windows XP SP3, Vista, 7, 8, ili 10

Potrebna su vam administratorska prava za proces instalacije.

Registracija LibreOffice kao zadanog programa za upravljanje Microsoft Office formatima može se prsiliti ili onemogućiti korištenjem sljedećih naredbi u instalaciji:

* REGISTER_ALL_MSO_TYPES=1 će registrirati LibreOffice kao zadani program za Microsoft Office datoteke.
* REGISTER_NO_MSO_TYPES=1 će ukloniti registraciju LibreOffice kao zadanog programa za Microsoft Office datoteke.

Provjerite imate li dovoljno slobodne memorije u privremenoj mapi na vašem sustavu, te se uvjerite da su vam odobrena prava čitanja, pisanja i izvršavanja. Zatvorite sve druge programe prije pokretanja instalacije.

Instalacija LibreOffice na sustave bazirane na Debian/Ubuntu
----------------------------------------------------------------------

Za upute kako instalirati jezični paket (nakon instalacije engleske SAD LibreOffice inačice), pročitajte niže navedeni odjeljak naslovljen Instalacija jezičnog paketa.

Kada otpakirate preuzetu arhivu, vidjet ćete da je sadržaj raspoređen u podmapu. Preglednikom datoteka otvorite mapu čije ime počinje s "LibreOffice_" iza kojega slijedi broj inačice i neke informacije o platformi.

Ova mapa sadrži podmapu naziva "DEBS". Promjenite mapu u "DEBS".

Kliknite desnom tipkom miša u mapu i odaberite naredbu "Otvori u terminalu". Otvorit će se prozor terminala. U naredbenom retku izvršite sljedeću naredbu (od Vas će biti zatražena root lozinka prije izvršenja naredbe):

Sljedeće će naredbe instalirati LibreOffice i pakete za integraciju s radnom površinom (možete ih samo kopirati i zalijepiti u terminal umjesto da ih pokušavate upisati):

sudo dpkg -i *.deb

Instalacijski proces je završen te biste trebali imati ikone svih LibreOffice modula u izborniku Programi/Ured.

Instalacija LibreOffice na Fodoru, openSUSE, Mandrivu i druge Linux sustave koristeći RPM pakete
----------------------------------------------------------------------

Za upute kako instalirati jezični paket (nakon instalacije engleske SAD LibreOffice inačice), pročitajte niže navedeni odjeljak naslovljen Instalacija jezičnog paketa.

Kada otpakirate preuzetu arhivu, vidjet ćete da je sadržaj raspoređen u podmapu. Preglednikom datoteka otvorite mapu čije ime počinje s "LibreOffice_" iza kojega slijedi broj inačice i neke informacije o platformi.

Ova mapa sadrži podmapu naziva "RPMS". Promjenite mapu u "RPMS".

Kliknite desnom tipkom miša u mapu i odaberite naredbu "Otvori u terminalu". Otvorit će se prozor terminala. U naredbenom retku izvršite sljedeću naredbu (od Vas će biti zatražena root lozinka prije izvršenja naredbe):

Za sustave bazirane na Fedori: su -c 'yum install *.rpm'

Sustavi temeljeni na Mandriva: sudo urpmi *.rpm

Za ostale sustave bazirane na RPM (openSUSE, etc.): rpm -Uvh *.rpm

Instalacijski proces je završen te biste trebali imati ikone svih LibreOffice modula u izborniku Programi/Ured.

Alternativno, možete koristiti 'install' skriptu, koja se nalazi u vršnom direktoriju ove arhive kako biste napravili instalaciju kao korisnik. Skripta će postaviti vlastiti LibreOffice profil za ovu instalaciju, odvojeno od standardnog LibreOffice profila. Ovo neće instalirati dijelove sistemske integracije kao što su stavke izbornika radne površine i registracije MIME tipa radne površine.

Bilješke u vezi integracije u radnu površinu za Linux distribucije koje nisu naznačene u prethodnim uputstvima za instalaciju
----------------------------------------------------------------------

Trebalo bi biti moguće lako instalirati LibreOffice na druge Linux distribucije koje nisu pokrivene ovim uputstvima. Glavni dio u kojem se može naići na razlike je integracija sa radnom površinom.

RPMS (ili DEBS) direktorij također sadrži paket s imenom libreoffice5.4-freedesktop-menus-5.4.0.1-1.noarch.rpm (ili libreoffice5.4-debian-menus_5.4.0.1-1_all.deb, ili sličnim). Ovo je paket za sve Linux distribucije koje podržavaju Freedesktop.org specifikacije/preporuke (http://en.wikipedia.org/wiki/Freedesktop.org) i dan je za instalaciju na ostale Linux distribucije koje nisu pokrivene u navedenim uputama.

Instalacija jezičnog paketa
----------------------------------------------------------------------

Preuzmite jezični paket vašeg željenog jezika i platforme. Paketi su dostupni na istom mjestu kao i glavna instalacijska arhiva. Iz upravitelja datotekama Nautilus, otpakirajte preuzetu arhivu u mapu (na primjer, radna površina). Provjerite jeste i isključili sve programe paketa LibreOffice (uključujući i Brzo pokretanje, ukoliko je pokrenut).

Otvorite mapu u kojoj je otpakiran preuzeti jezični paket.

Otvorite mapu koju ste stvorili tijekom raspakiravanja. Naprimjer, za francuski jezični paket za platformu baziranu na 32-bitnom Debian/Ubuntu sustavu, mapa će se zvati LibreOffice_, plus informacije o inačici, plus Linux_x86_langpack-deb_fr.

Sada otvorite mapu koja sadrži instalacijske pakete. Na Debian/Ubuntu baziranim sustavima, postojat će mapa DEBS. Na Fedori, openSUSE-u ili Mandrivi, postojat će mapa RPMS.

Iz upravitelja datotekama Nautilus izvršite desni klik na mapu i izaberite naredbu "Open in terminal/Otvori u terminalu". U prozoru terminala, koji se upravo otvorio, izvršite naredbu za instaliranje jezičnog paketa (sa svim dolje napisanim naredbama, biti ćete upitani za upis lozinke korisnika root):

Za sustave bazirane na Debian/Ubuntu: sudo dpkg -i *.deb

Za sustave bazirane na Fedori: su -c 'yum install *.rpm'

Sustavi temeljeni na Mandriva: sudo urpmi *.rpm

Za ostale sustave koji koriste RPM (openSUSE, etc.): rpm -Uvh *.rpm

Sada pokrenite jedan od LibreOffice programa - na primjer Writer. Odaberite izbornik Alati i odaberite Mogućnosti. U prozoru Mogućnosti kliknite na Jezične postavke te nakon toga na Jezici. Kliknite na padajući izbornik Korisničko sučelje te odaberite jezik koji ste instalirali. Ukoliko želite, izmijenite postavke u Lokalne postavke, Zadana valuta i Zadani jezici za dokumente.

Nakon prilagodbe ovih postavki, kliknite na 'U redu'. Zatvoriti će se dijaloški prozor i vidjeti ćete poruku da će vaše izmjene biti primijenjene tek nakon što izađete iz LibreOffice i ponovno ga pokrenete (nemojte zaboraviti isključiti Brzo pokretanje ukoliko je uključen).

Sljedeći put kad pokrenete LibreOffice, pokrenuti će se jezik koj iste upravo instalirali.

----------------------------------------------------------------------
Problemi prilikom pokretanja programa
----------------------------------------------------------------------

Greške prilikom LibreOffice pokretanja (npr. zaglavljivanje programa) kao i probleme sa prikazom zaslona često uzrokuje grafička kartica. Ako dođe do ovih problema, nadogradite upravljačke programe za vašu grafičku karticu korištenjem upravljačkih programa koji su došli s vašim operacijskim sustavom. Teškoće prilikom prikazivanja 3D objekata često se mogu razriješiti isključivanjem opcije "Koristi OpenGL" pod 'Alati - Mogućnosti - LibreOffice - Pogled - 3D prikaz'.

----------------------------------------------------------------------
ALPS/Synaptics dodirna ploča za prijenosna računala pod MS Windows
----------------------------------------------------------------------

Zbog problema s Windows upravljačkim programom, ne možete pomicati dokumente kroz LibreOffice kad pomišete prst preko taktilne ploče proizvođača ALPS/Synaptics.

Za uključivanje pomicanja pomoću dodirne ploče, dodajte sljedeće retke u konfiguracijsku datoteku "C:\Program Files\Synaptics\SynTP\SynTPEnh.ini", te ponovno pokrenite računalo:

[LibreOffice]

FC = "SALFRAME"

SF = 0x10000000

SF |= 0x00004000

Smještaj konfiguracijske datoteke može se razlikovati kod različitih inačica Windowsa.

----------------------------------------------------------------------
Prečice
----------------------------------------------------------------------

U LibreOfficeu se mogu koristiti samo tipkovničke kratice (kombinacije tipaka) koje ne koristi operativni sustav. Ako u LibreOfficeu kombinacija tipki ne radi kao što je opisano u LibreOffice Pomoći, provjerite ne koristi li već te kratice operativni sustav. Možete promjeniti kratice vašeg operativnog sustava kako biste ispravili ove konflikte. Uostalom, LibreOffice omogućuje promjenu gotovo svih tipkovničkih kratica. Radi više informacija pogledajte LibreOffice Pomoć ili Pomoć vašeg operativnog sustava.

----------------------------------------------------------------------
Problemi kod slanja dokumenata kao e-poruka iz LibreOffice
----------------------------------------------------------------------

Slanjem dokumenta kroz 'Datoteka - Pošalji - Dokument kao E-pošta', ili 'Dokument kao PDF privitak', može doći do problema (rušenja ili nereagiranje programa). Problem se događa zbog Windows sistemske datoteke "Mapi" (Messaging Application Programming Interface). Nažalost problem nije vezan uz konkretnu inačicu. Za više informacija posjetite http://www.microsoft.com i u Microsoftovoj bazi znanja potražite "mapi dll".

----------------------------------------------------------------------
Važne napomene o pristupačnosti
----------------------------------------------------------------------

Za više informacija o mogućnostima pristupačnosti u LibreOffice, pogledajte http://www.libreoffice.org/accessibility/

----------------------------------------------------------------------
Podrška korisnicima
----------------------------------------------------------------------

Glavna stranica za podršku http://www.libreoffice.org/support/ nudi razne mogućnosti pomoći za LibreOffice. Na vaše je pitanje možda već odgovoreno - provjerite forum zajednice na http://www.documentfoundation.org/nabble/ ili pretražite arhivu interesnih lista 'users@libreoffice.org' na http://www.libreoffice.org/lists/users/. Pitanja možete slati na users@libreoffice.org. Želite li se prijaviti na interesnu listu (kako biste dobili odgovore na e-poštu) pošaljite praznu poruku na users+subscribe@libreoffice.org.

Također pogledajte poglavlje o često postavljenim pitanjima na http://www.libreoffice.org/faq/.

----------------------------------------------------------------------
Prijavljivanje nedostataka i problema
----------------------------------------------------------------------

BugZilla je naš trenutni sustav za prijavljivanje, praćenje i rješavanje grešaka, ljubazno ugošćen kod https://bugs.libreoffice.org/. Pozivamo i potičemo sve korisnike da prijavljuju greške koje se mogu pojaviti na vašim platformama. Često prijavljivanje grešaka je jedan od najvažnijih doprinosa koji zajednica korisnika može napraviti za kontinuirani LibreOffice razvoj i napredak.

----------------------------------------------------------------------
Uključivanje u projekt
----------------------------------------------------------------------

LibreOffice zajednica može uvelike prosperirati vašim aktivnim doprinosom u razvoju ovog važnog open source projekta.

Kao korisnik, Vi ste već vrijedan član procesa razvijanja paketa i voljeli bismo vas potaknuti da se još aktivnije uključite i eventualno postanete dugoročni suradnik zajednice. Pridružite se i pogledajte stranicu doprinosa na http://www.libreoffice.org/contribution/

Kako početi
----------------------------------------------------------------------

Želite li započeti pridonositi, najbolji je način pretplatiti se na jednu ili više interesnih lista, neko vrijeme promatrati i kroz arhive se postupno upoznavati s temama aktualiziranima još otkako je objavljen izvoni kod LibreOffice u listopadu 2000. Kada se opustite, sve što trebate jest predstaviti se u poruci i - uključiti se. Ako ste upoznati s drugim projektima otvorenog koda, provjerite listu zadataka na http://www.libreoffice.org/develop/ i pogledajte postoji li nešto oko čega biste voljeli pomoći.

Pretplata
----------------------------------------------------------------------

Ovdje je nekoliko popisa skupnih e-poruka projekta na koje se možete prijaviti http://www.libreoffice.org/contribution/

* Novosti: announce@documentfoundation.org *preporučeno svim korisnicima* (mali promet)
* Glavni korisnički popis primatelja: users@global.libreoffice.org *lagani način vrebanja rasprava* (veliki promet)
* Marketing projekt: marketing@global.libreoffice.org *iznad razvoja* (počinje imati veliki promet)
* Opći popis skupne e-pošte za razvijatelje: libreoffice@lists.freedesktop.org (velik promet)

Pridruživanje jednom ili više projekata
----------------------------------------------------------------------

I vi možete dati velik doprinos ovom važnom projektu otvorenog koda čak i ako imate malo iskustva u oblikovanju ili programiranju softvera. Da, vi!

Nadamo se da ste uživali u radu s novom LibreOffice 5.4 inačicom i da ćete nam se pridružiti na webu.

Zajednica LibreOffice

----------------------------------------------------------------------
Korišteni / promijenjeni izvorni kod
----------------------------------------------------------------------

Djelomično autorsko pravo 1998, 1999 James Clark. Djelomično autorsko pravo 1996, 1998 Netscape Communications Corporation.
