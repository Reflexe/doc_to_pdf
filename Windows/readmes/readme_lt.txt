
======================================================================
„LibreOffice 5.4“ informacija naudotojui
======================================================================


Naujausią informaciją naudotojui skaitykite tinklalapyje http://www.libreoffice.org/welcome/readme.html

Šiame faile pateikiama svarbi informacija apie LibreOffice programą. Rekomenduojame atidžiai perskaityti šią informaciją prieš pradedant diegimą.

Šį produktą vysto „LibreOffice“ bendruomenė, į kurią esate kviečiami įsijungti ir Jūs. Jeigu esate naujas „LibreOffice“ naudotojas, galite aplankyti „LibreOffice“ svetainę, kurioje rasite informacijos apie šį programų paketą ir prie jo vystymo prisidedančias bendruomenes. Svetainės adresas – http://www.libreoffice.org/.

Ar tikrai „LibreOffice“ visiems nemokamas?
----------------------------------------------------------------------

„LibreOffice“ gali nemokamai ir laisvai naudoti visi. „LibreOffice“ galima įdiegti daugelyje kompiuterių ir naudoti įvairiausiais tikslais (įskaitant komercinį, vyriausybinį, viešąjį ir edukacinį naudojimą). Išsamiau galima paskaityti licencijoje, pateikiamoje šiame „LibreOffice“ diegimo pakete.

Kodėl „LibreOffice“ visiems nemokamas?
----------------------------------------------------------------------

„LibreOffice“ nemokamai galima naudoti todėl, kad jį kūrė, programavo, testavo, vertė, aprašė, reklamavo pavieniai asmenys ir įmonės bei taip padarė „LibreOffice“ tuo, kuo ši programa dabar yra – pasaulyje pirmaujančiu atviruoju raštinės programų paketu, skirtu ir namams, ir biurui.

Jei vertinate jų pastangas ir norite, kad „LibreOffice“ ir toliau gyvuotų, kviečiame prisidėti prie projekto – žr. http://www.documentfoundation.org/contribution/. Prisidėti gali kiekvienas ir įvairiais būdais.

----------------------------------------------------------------------
Pastabos apie diegimą
----------------------------------------------------------------------

Kad veiktų visos „LibreOffice“ funkcijos, reikalinga „Java“ programų vykdymo terpė (JRE). JRE nėra įtraukta į „LibreOffice“ diegimo paketą, ją reikia įdiegti atskirai.

Reikalavimai sistemai
----------------------------------------------------------------------

* Microsoft Windows XP SP3, Vista, 7, 8 arba 10

Svarbu: diegiant programą reikalingos administratoriaus teisės.

„LibreOffice“ nustatymas numatytąja programa „Microsoft Office“ formato dokumentams atverti gali būti priverstinai iškviečiamas arba neleidžiamas naudojant šiuos komandų eilutės jungiklius diegimo programai:

* REGISTER_ALL_MSO_TYPES=1 – „LibreOffice“ nustatoma numatytąja programa „Microsoft Office“ formato dokumentams atverti.
* REGISTER_NO_MSO_TYPES=1 – neleidžiama „LibreOffice“ nustatyti numatytąja programa „Microsoft Office“ formato dokumentams atverti.

Įsitikinkite, kad turite pakankamai laisvos vietos laikinajame aplanke. Taip pat įsitikinkite, kad turite skaitymo, rašymo ir paleidimo teises. Išjunkite visas programas prieš pradėdami diegimo procesą.

„LibreOffice“ diegimas į „Debian“ („Ubuntu“) šeimos „Linux“ sistemas
----------------------------------------------------------------------

Instrukcijos, kaip įdiegti kalbos paketą (prieš tai įdiegus anglišką „LibreOffice“ versiją), pateikiamos skyriuje „Kalbos paketo diegimas“.

Atsisiųsto pako turinys bus išpakuotas į naują poaplankį. Failų tvarkytuvės lange atverkite aplanką, kurio pavadinimas prasideda „LibreOffice_“, o toliau nurodomas versijos numeris ir platforma.

Šiame aplanke yra poaplankis „DEBS“. Pereikite į poaplankį „DEBS“.

Atverkite veikiamąjį aplanką terminale. Tai galima padaryti aplanke spustelėjus dešiniuoju pelės klavišu ir pasirinkus „Atverti terminale“. Atsivėrusiame lange komandos eilutėje įveskite šią komandą (kad ji būtų įvykdyta, reikės įvesti pagrindinio naudotojo slaptažodį):

Toliau pateiktomis komandomis bus įdiegti „LibreOffice“ programos ir darbalaukio integracijos paketai (bus patikimiau, jei komandas tiesiog nukopijuosite, o ne bandysite surinkti terminalo lange):

sudo dpkg -i *.deb

Diegimo procesas baigtas. Dabar visų „LibreOffice“ programų piktogramas turėtumėte matyti programų meniu dalyje „Biuro programos“.

„LibreOffice“ diegimas „Fedora“, „openSUSE“, „Mandriva“ ir kitose „Linux“ sistemose, naudojančiose RPM paketus
----------------------------------------------------------------------

Instrukcijos, kaip įdiegti kalbos paketą (prieš tai įdiegus anglišką „LibreOffice“ versiją), pateikiamos skyriuje „Kalbos paketo diegimas“.

Atsisiųsto pako turinys bus išpakuotas į naują poaplankį. Failų tvarkytuvės lange atverkite aplanką, kurio pavadinimas prasideda „LibreOffice_“, o toliau nurodomas versijos numeris ir platforma.

Šiame aplanke yra poaplankis „RPMS“. Pereikite į poaplankį „RPMS“.

Atverkite veikiamąjį aplanką terminale. Tai galima padaryti aplanke spustelėjus dešiniuoju pelės klavišu ir pasirinkus „Atverti terminale“. Atsivėrusiame lange komandos eilutėje įveskite šią komandą (kad ji būtų įvykdyta, reikės įvesti pagrindinio naudotojo slaptažodį):

„Fedora“ pagrindu sukurtoms sistemoms: su -c 'yum install *.rpm'

„Mandriva“ pagrindu sukurtoms sistemoms: sudo urpmi *.rpm

Kitoms RPM pagrindo sistemoms („openSUSE“ ir kt.): rpm -Uvh *.rpm

Diegimo procesas baigtas. Dabar visų „LibreOffice“ programų piktogramas turėtumėte matyti programų meniu dalyje „Biuro programos“.

Programą taip pat galima įdiegti naudotojo teisėmis paleidus diegimo scenarijų „install“, esantį pagrindiniame šio pako aplanke. Scenarijumi bus sukurtas atskiras „LibreOffice“ egzemplioriaus profilis, nesusijęs su įprastu „LibreOffice“ profiliu. Atminkite, kad šitaip nebus įdiegta darbalaukio integracija – nebus sukurti darbalaukio meniu elementai ir neužregistruoti MIME tipai.

Pastaba dėl darbalaukio integracijos paketų diegimo kitose, šiose instrukcijose nepaminėtose „Linux“ atmainose
----------------------------------------------------------------------

Turėtų būti įmanoma įdiegti „LibreOffice“ ir kitose, čia nepaminėtose „Linux“ atmainose. Skirtumų gali atsirasti tik diegiant darbalaukio integracijos paketus.

Aplanke RPMS (arba DEBS) taip pat yra paketas „libreoffice5.4-freedesktop-menus-5.4.0.1-1.noarch.rpm“ (arba panašus). Jis skirtas visoms su „Freedesktop.org“ specifikacijomis ir (arba) rekomendacijomis (http://en.wikipedia.org/wiki/Freedesktop.org) suderinamoms  „Linux“ atmainoms. Šį paketą ir reikėtų diegti visose anksčiau nepaminėtose „Linux“ atmainose.

Kalbos paketo diegimas
----------------------------------------------------------------------

Parsisiųskite norimos kalbos paketą, skirtą jūsų operacinei sistemai. Juos galima siųstis iš ten pat, kaip ir pagrindinį programos diegimo paką. Naudodamiesi „Nautilus“ failų tvarkytuve išpakuokite parsisiųstą paką į aplanką (pavyzdžiui, darbalaukyje). Įsitikinkite, kad visos „LibreOffice“ programos išjungtos (taip pat ir sparčioji paleistis, jei ji naudojama).

Atverkite aplanką, į kurį išpakavote parsisiųstą kalbos paketą.

Atverkite poaplankį, sukurtą išpakuojant paketą. Pavyzdžiui, lietuvių kalbos pakete 32 bitų „Debian“ („Ubuntu“) šeimos sistemai tokio poaplankio vardas bus sudarytas iš šių dalių: „LibreOffice_“, versijos numerio ir „Linux_x86_langpack-deb_lt“.

Atverkite poaplankį, kuriame yra diegtini paketai. „Debian“ („Ubuntu“) šeimos sistemose toks poaplankis vadinsis DEBS. „Fedora“, „openSUSE“ ar „Mandriva“ sistemose – RPMS.

Atverkite veikiamąjį aplanką terminale. Tai galima padaryti aplanke spustelėjus dešiniuoju pelės klavišu ir pasirinkus „Atverti terminale“. Atsivėrusiame lange komandos eilutėje įveskite komandą kalbos paketui įdiegti (kad ji būtų įvykdyta, reikės įvesti pagrindinio naudotojo slaptažodį):

„Debian“ („Ubuntu“) šeimos sistemoms: sudo dpkg -i *.deb

„Fedora“ pagrindu sukurtoms sistemoms: su -c 'yum install *.rpm'

„Mandriva“ pagrindu sukurtoms sistemoms: sudo urpmi *.rpm

Kitoms RPM pagrindo sistemoms („openSUSE“ ir kt.): rpm -Uvh *.rpm

Atverkite vieną iš „LibreOffice“ programų, pavyzdžiui tekstų rengyklę. Pasirinkite meniu „Priemonės → Parinktys“. Parinkčių lange išskleiskite grupę „Kalbos nuostatos“ ir pasirinkite „Kalba“. Tada dešinėje lango pusėje, parinkčių grupėje „Lokalės kalba ir valiuta“ išskleiskite sąrašą „Kalba“ ir pasirinkite įdiegtąją kalbą. Jei norite, tą pačią kalbą pasirinkite ir „Lokalės“, „Valiutos“, „Rašybos tikrinimo kalbos“ sąrašuose.

Nustatę reikiamas parinktis spustelėkite „Gerai“. Dialogo langas bus užvertas, o programa jus informuos, kad pakeitimai įsigalios tik iš naujo paleidus „LibreOffice“ (nepamirškite išjungti ir sparčiosios paleisties, jei ją naudojate).

Kai kitą kartą paleisite „LibreOffice“, programoje bus nustatyta kalba, kurią ką tik įdiegėte.

----------------------------------------------------------------------
Nesklandumai paleidžiant programą
----------------------------------------------------------------------

„LibreOffice“ paleidimo bei ekrano vaizdo problemos dažniausiai būna susiję su grafinės plokštės tvarkykle. Jei pasitaikytų tokių sunkumų, rekomenduojame atnaujinti grafinės plokštės tvarkyklę arba bandyti pasinaudoti tvarkykle, pateikta kartu su kompiuteryje įdiegta operacine sistema. Trimačių vaizdų rodymo sunkumus galima įveikti „Priemonės → Parinktys → „LibreOffice“ → Rodymas“ kortelės dalyje „Trimatis rodymas“ išjungus parinktį „Naudoti „OpenGL“.

----------------------------------------------------------------------
Nešiojamųjų kompiuterių su „ALPS/Synaptics“ jutikliniais kilimėliais ir „Windows“ OS naudotojams
----------------------------------------------------------------------

Dėl klaidos „Windows“ OS skirtoje tvarkyklėje „LibreOffice“ dokumento negalima slinkti braukiant pirštu per „ALPS/Synaptics“ jutiklinį kilimėlį.

Jei norite naudotis jutikliniu kilimėliu dokumentui slinkti, įrašykite šias eilutes į „C:\Program Files\Synaptics\SynTP\SynTPEnh.ini“ sąrankos failą ir iš naujo paleiskite kompiuterį:

[LibreOffice]

FC = "SALFRAME"

SF = 0x10000000

SF |= 0x00004000

Sąrankos failo vieta gali skirtis priklausomai nuo naudojamos „Windows“ OS versijos.

----------------------------------------------------------------------
Spartieji klavišai
----------------------------------------------------------------------

Programoje „LibreOffice“ galima naudotis tik tais sparčiaisiais klavišais (klavišų kombinacijomis), kurių nenaudoja operacinė sistema. Jei kuri nors klavišų kombinacija programoje „LibreOffice“ neveikia, nors pagal informaciją žinyne ji turėtų veikti, reikėtų patikrinti, ar šios klavišų kombinacijos nenaudoja operacinė sistema. Norint pašalinti šiuos nesklandumus, operacinės sistemos sparčiuosius klavišus galima pakeisti. Kita vertus, galima pakeisti ir beveik visus „LibreOffice“ programos sparčiuosius klavišus. Daugiau informacijos apie tai galima ieškoti „LibreOffice“ programos arba kompiuteryje naudojamos operacinės sistemos žinynuose.

----------------------------------------------------------------------
Nesklandumai, galintys kilti siunčiant „LibreOffice“ dokumentus el. paštu
----------------------------------------------------------------------

Norint išsiųsti dokumentą naudojantis komandomis „Failas → Siųsti → Siųsti elektroniniu paštu…“ arba „Siųsti el. paštu – PDF dokumentą…“ gali kilti nesklandumų. Pastarieji gali būti susiję su kai kuriomis „Windows“ sisteminio failo „Mapi“ (Messaging Application Programming Interface) versijomis. Deja, kol kas negalima tiksliai nustatyti probleminės failo versijos. Smulkesnės informacijos ieškokite http://www.microsoft.com, paieškos lauke įvedę „mapi dll“.

----------------------------------------------------------------------
Pastabos apie pritaikymą neįgaliesiems
----------------------------------------------------------------------

Daugiau informacijos apie „LibreOffice“ pritaikymą neįgaliesiems rasite tinklalapyje http://www.libreoffice.org/accessibility/

----------------------------------------------------------------------
Pagalba naudotojui
----------------------------------------------------------------------

Tinklalapyje http://www.libreoffice.org/support/ siūlomi įvairūs būdai „LibreOffice“ naudotojams gauti pagalbos. Jums rūpimas klausimas jau gali būti atsakytas – paieškokite bendruomenės diskusijų tinklalapyje http://www.documentfoundation.org/nabble/ arba naudotojų el. pašto grupės „users@libreoffice.org“ archyvuose http://www.libreoffice.org/lists/users/. Taip pat galima siųsti klausimus el. pašto adresu users@libreoffice.org. Jei norėsite užsiregistruoti į el. pašto grupę (tik tada atsakymus gausite el. paštu), išsiųskite tuščią laišką adresu users+subscribe@libreoffice.org.

Taipogi paskaitykite atsakymus į dažnai užduodamus klausimus: http://www.libreoffice.org/faq/.

----------------------------------------------------------------------
Pranešimai apie kilusius nesklandumus bei defektus
----------------------------------------------------------------------

Klaidoms registruoti, sekti ir taisyti naudojama „BugZilla“ sistema, esanti svetainėje https://bugs.libreoffice.org/. Kviečiame visus naudotojus pranešti apie iškilusias problemas. Aktyvus klaidų registravimas – vienas iš svarbiausių darbų, kuriuos gali atlikti naudotojų bendruomenė kuriant ir tobulinant „LibreOffice“.

----------------------------------------------------------------------
Bendradarbiavimas
----------------------------------------------------------------------

„LibreOffice“ bendruomenei būtų malonu, jei Jūs aktyviai bendradarbiautumėte kuriant šį atvirąjį projektą.

Naudodami šią programą Jūs jau svariai prisidedate prie jos vystymo. Visgi norėtume pakviesti Jus prisidėti dar labiau ir tapti nuolatiniu bendradarbiu. Kviestume paskaityti apie tai daugiau tinklalapyje http://www.libreoffice.org/contribution/

Kaip pradėti
----------------------------------------------------------------------

Patogiausias būdas pradėti bendradarbiauti – užsiregistruoti į vieną ar kelias el. pašto grupes, kurį laiką stebėti diskusijas, palaipsniui peržvelgti archyvuose laikomą medžiagą apie pagrindines, nuo 2000 m. spalio (kada pasirodė programos „LibreOffice“ pirminis tekstas) gvildentas temas. Tada telieka parašyti elektroninį laišką apie save ir prisijungti prie mūsų. Jei gaudotės atvirosiose programose, žvilgtelėkite į mūsų pateiktą reikalingų darbų sąrašą: galbūt čia rasite tai, kuo galėtumėte padėti (žr. http://www.libreoffice.org/develop/).

Užsiregistravimas į el. pašto grupes
----------------------------------------------------------------------

Toliau išvardinta keletas el. pašto grupių, į kurias galima užsiregistruoti iš tinklalapio http://www.libreoffice.org/contribution/

* Naujienos: announce@documentfoundation.org (rekomenduojama visiems naudotojams, mažas laiškų srautas)
* Pagrindinė naudotojų el. pašto grupė: users@global.libreoffice.org (paprasta sekti diskusijas, didelis laiškų srautas)
* Rinkodaros projektai: marketing@global.libreoffice.org (su programavimu nesusijusios diskusijos, laiškų srautas tampa didelis)
* Pagrindinė programuotojų el. pašto grupė: libreoffice@lists.freedesktop.org (didelis laiškų srautas)

Prisijunkite prie vieno ar kelių projektų
----------------------------------------------------------------------

Rimtai prisidėti prie šio svarbaus atvirojo projekto galima net ir neturint didelės programinės įrangos kūrimo bei programavimo patirties. Neabejokite tuo!

Tikimės, kad patiks dirbti naujuoju „LibreOffice 5.4“ paketu ir prisijungsite prie mūsų bendruomenės internete.

„LibreOffice“ bendruomenė

----------------------------------------------------------------------
Naudotas arba perdarytas pirminis tekstas
----------------------------------------------------------------------

© Dalinės autoriaus teisės: 1998, 1999 James Clark. © Dalinės autoriaus teisės: 1996, 1998 Netscape Communications Corporation.
