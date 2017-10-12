
======================================================================
LibreOffice 5.4 ReadMe
======================================================================


Najnovšiu aktualizáciu tohoto readme (čítajma) súboru nájdete na stránke http://www.libreoffice.org/welcome/readme.html

Tento súbor obsahuje dôležité informácie o programe LibreOffice. Prečítajte si, prosím, tieto informácie skôr, než ho začnete inštalovať.

KomunitaLibreOffice, ktorá zodpovedná za vývoj tohto produktu, si vás dovoľuje pozvať, aby ste sa stali jej členom. Ak ste nový používateľ, môžete sa pozrieť na stránky LibreOffice, kde nájdete množstvo informácií o projekte LibreOffice a o komunitách, ktoré okolo neho existujú. Ďalšie informácie nájdete na adrese  http://www.libreoffice.org/

Je LibreOffice naozaj voľne dostupný pre každého?
----------------------------------------------------------------------

LibreOffice môže voľne používať ktokoľvek.  Túto kópiu  LibreOffice môžete vziať a nainštalovať na ľubovoľný počet počítačov a môžete ju používať na ľubovoľný účel (vrátane použitia vo firmách, v štátnej a verejnej správe a v školách). Ďalšie detaily sú uvedené v texte licenčných podmienok, ktoré sú pripojené k tomuto balíčku LibreOffice.

Prečo je LibreOffice kýmkoľvek voľne použiteľný?
----------------------------------------------------------------------

Túto kópiu LibreOffice môžete zdarma používať preto, lebo individuálni prispievatelia a firemní sponzori navrhovali, vyvíjali, testovali, prekladali, zdokumentovávali, podporovali, propagovali a v mnohých ďalších ohľadoch pomáhali urobiť LibreOffice tým, čím dnes je - svetovým lídrom v oblasti open-source kancelárskeho softvéru.

V prípade, že si ceníte ich snahu a chceli by ste zabezpečiť, aby saLibreOffice vyvíjal aj v budúcnosti, prosím pouvažujte o prispení do tohto projektu - navštívte http://www.documentfoundation.org/contribution/, kde nájdete detaily. Každý môže nejako prispieť.

----------------------------------------------------------------------
Poznámky k inštalácii
----------------------------------------------------------------------

LibreOffice vyžaduje pre plnú funkcieschopnosť najnovšiu verziu Java Runtime Environment (JRE). JRE nie je súčasťou inštalačného balíčka LibreOffice, treba ho inštalovať zvlašť.

Systémové požiadavky
----------------------------------------------------------------------

* Microsoft Windows XP, Vista, Windows 7, 8 alebo Windows 10

Nezabudnite, že na inštaláciu budete potrebovať práva správcu systému.

Registrácia LibreOffice ako predvolenej aplikácie pre formáty Microsoft Office môže byť vynútená alebo potlačená pomocou použitia nasledovných prepínačov z príkazového riadka pri spustení inštalátora.

* REGISTER_ALL_MSO_TYPES=1 vynúti registráciu LibreOffice ako štandardnej aplikácie pre formáty Microsoft Office.
* REGISTER_NO_MSO_TYPES=1 zakáže registráciu LibreOffice ako štandardnej aplikácie pre formáty Microsoft Office.

Overte si, prosím, že máte dostatok voľného pamäťového priestoru v dočasnom priečinku, rovnako ako aj to, že tam máte právo na čítanie, zápis a spúšťanie programov. Pred začatím inštalačného procesu ukončite všetky programy.

Inštalácia LibreOffice na linuxovom systéme založenom na Debian/Ubuntu
----------------------------------------------------------------------

Návod, ako nainštalovať jazykovú podporu v požadovanom jazyku (ak už bola nainštalovaná podpora LibreOffice pre angličtinu), nájdete nižšie v sekcii Inštalácia jazykového balíka.

Keď rozbalíte stiahnutý archív, uvidíte, že jeho obsah sa rozbalil do podpriečinku. Otvorte okno správcu súborov a zmeňte aktuálny priečinok na ten, ktorý začína reťazcom "LibreOffice_" a je nasledovaný číslom verzie a informáciou o platforme.

Tento priečinok obsahuje podpriečinok s názvom "DEBS". Zmeňte aktuálny priečinok na podpriečinok "DEBS".

Na plochu priečinku kliknite pravým tlačidlom myši a vyberte "Otvoriť v termináli". Otvorí sa okno terminálu. V jeho príkazovom riadku zadajte (pred vykonaním príkazu budete vyzvaní na zadanie hesla používateľa s administrátorskými právami):

Nasledujúce príkazy nainštalujú LibreOffice a balíčky pre integráciu s desktopom (namiesto opisovania ich môžete jednoducho skopírovať a vložiť do terminálu):

sudo dpkg -i *.deb

Inštalačný proces je tým ukončený. V menu pracovnej plochy Aplikácie/Kancelária by ste mali mať ikonky všetkých aplikácií  LibreOffice.

Inštalácia LibreOffice na Fedore, Suse, Mandrive a iných linuxových systémoch, ktoré používajú RPM balíky
----------------------------------------------------------------------

Návod, ako nainštalovať jazykovú podporu v požadovanom jazyku (ak už bola nainštalovaná podpora LibreOffice pre angličtinu), nájdete nižšie v sekcii Inštalácia jazykového balíka.

Keď rozbalíte stiahnutý archív, uvidíte, že jeho obsah sa rozbalil do podpriečinku. Otvorte okno správcu súborov a zmeňte aktuálny priečinok na ten, ktorý začína reťazcom "LibreOffice_" a je nasledovaný číslom verzie a informáciou o platforme.

Tento priečinok obsahuje podpriečinok s názvom "RPMS". Zmeňte aktuálny priečinok na podpriečinok "RPMS".

Na plochu priečinku kliknite pravým tlačidlom myši a vyberte "Otvoriť v termináli". Otvorí sa okno terminálu. V jeho príkazovom riadku zadajte (pred vykonaním príkazu budete vyzvaní na zadanie hesla používateľa s administrátorskými právami):

Pre systémy založené na Fedore: su -c 'yum install *.rpm'

Pre systémy založené na Mandrive: sudo urpmi *.rpm

Pre iné systémy založené na RPM (openSuse, atď.): rpm -Uvh *.rpm

Inštalačný proces je tým ukončený. V menu pracovnej plochy Aplikácie/Kancelária by ste mali mať ikonky všetkých aplikácií  LibreOffice.

Ako alternatívu potom môžete pomocou skriptu 'install', umiestneného v koreňovom adresári tohto archívu, spustiť používateľskú inštaláciu. Tento skript pre LibreOffice vytvorí samostatný profil oddelený od bežného profilu LibreOffice. Upozorňujeme, že takto sa nenainštalujú súčasti potrebné pre integráciu, ako napríklad položky menu prostredia alebo registrácia MIME typov

Poznámky týkajúce sa integrovania do pracovného prostredia pre linuxové distribúcie, ktorých sa netýkajú horeuvedené inštrukcie
----------------------------------------------------------------------

Inštalácia LibreOffice by v iných distribúciách Linuxu, ktoré nie sú v tomto návode spomínané, mala byť bezproblémová. Rozdiely možno očakávať najmä v oblasti integrovania do pracovného prostredia.

Priečinok RPMS (prípadne DEBS) tiež obsahuje balík s názvom libreoffice5.4-freedesktop-menus-5.4.0.1-1.noarch.rpm (or libreoffice5.4-debian-menus_5.4.0.1-1_all.deb alebo podobým). Je to balík pre všetky distribúcie Linuxu, ktoré podporujú špecifikáciu/odporúčania Freedesktop.org (http://en.wikipedia.org/wiki/Freedesktop.org) a je určený na inštaláciu pre tie distribúcie Linuxu, ktoré nie sú zahrnuté vo vyššie uvedených inštrukciách.

Inštalácia jazykového balíka
----------------------------------------------------------------------

Stiahnite si jazykový balík pre požadovaný jazyk a platformu. Tie sú dostupné na tom istom mieste ako hlavný inštalačný archív. Zo správcu súborov rozbaľte archív jazykového balíka do priečinku (napr. na pracovnú plochu). Presvedčite sa, že žiadne aplikácie LibreOffice (vrátane rýchleho spúšťača - QuickStarter) nie sú spustené.

Zmeňte priečinok do toho, kam ste rozbalili stiahnutý jazykový balík.

Teraz zmeňte priečinok do toho priečinka, ktorý bol vytvorený počas rozbaľovania. Napríklad,  v prípade slovenského jazykového balíka pre 32-bitový systém Debian/Ubuntu, sa priečinok volá LibreOffice_ plus informácia o verzii plus Linux_x86_langpack-deb_sk.

Teraz vojdite do priečinka, ktorý obsahuje balíky na inštaláciu. Na systémoch založených na Debian/Ubuntu to bude priečinok DEBS. Vo Fedore, openSUSE alebo Mandrive to bude priečinok RPMS.

V správcovi súborov kliknite pravým tlačidlom myši na priečinok a vyberte "Otvoriť v termináli". V okne terminálu, ktoré sa otvorí, spustite príkaz na inštalovanie jazykového balíka (v prípade doluuvedeného príkazu môžete byť vyzvaní na zadanie hesla používateľa s administrátorskými právami):

Pre systémy založené na Debian/Ubuntu: sudo dpkg -i *.deb

Pre systémy založené na Fedore: su -c 'yum install *.rpm'

Pre systémy založené na Mandrive: sudo urpmi *.rpm

Pre ostatné systémy používajúce RPM (openSUSE, atď.): rpm -Uvh *.rpm

Teraz spustite jednu z aplikácií LibreOffice, napríklad Writer. Choďte do menu Nástroje a zvoľte Možnosti. V dialógovom okne Možnosti kliknite na "Nastavenie jazyka" a potom kliknite na "Jazyky". V zozname "Používateľské rozhranie" vyberte jazyk, ktorý ste práve nainštalovali. Ak chcete, spravte to isté aj pre "Národné nastavenie", "Predvolená mena" a "Predvolený jazyk dokumentu".

Po vykonaní týchto nastavení kliknite na OK. Dialógové okno sa zatvorí a zobrazí sa informácia o tom, že tieto zmeny budú aktivované až po ukončení LibreOffice a opätovnom štarte (nezabudnite ukončiť aj Quickstarter, pokiaľ bol spustený).

Po nasledujúcom štarte sa LibreOffice spustí v jazyku, ktorý ste práve nainštalovali.

----------------------------------------------------------------------
Problémy počas štartu programu
----------------------------------------------------------------------

Problémy pri spúšťaní LibreOffice (napr. zmrznutie aplikácie) a taktiež problémy s obrazovkou sú často spôsobované ovládačom grafickej karty. V prípade výskytu týchto problémov aktualizujte váš ovládač grafickej karty alebo použite ovládač, ktorý bolo dodaný spolu s vašim operačným systémom. Ťažkosti so zobrazovaním 3D objektov môžu byť často vyriešené deaktivovaním možnosti "Použiť OpenGL" v  'Nástroje - Možnosti - LibreOffice - Zobraziť - 3D zobrazenie'.

----------------------------------------------------------------------
ALPS/Synaptics notebook touchpady vo Windows
----------------------------------------------------------------------

Kvôli problému s ovládačmi Windows nemôžete posúvať dokumenty v LibreOffice posúvaním prsta po touchpade ALPS/Synaptics.

Posúvania touchpadom zapnete pridaním nasledujúcich riadkov do konfiguračného súboru "C:\Program Files\Synaptics\SynTP\SynTPEnh.ini" a reštartujte váš počítač:

[LibreOffice]

FC = "SALFRAME"

SF = 0x10000000

SF |= 0x00004000

Umiestnenie konfiguračného súboru sa môže líšiť v závislosti od verzie Windows.

----------------------------------------------------------------------
Kombinácia kláves
----------------------------------------------------------------------

V LibreOffice je možné používať iba skratky (kombinácie kláves), ktoré nepoužíva operačný systém. Ak skratka v LibreOffice nefunguje podľa popisu v Pomocníkovi LibreOffice, skontrolujte, či už skratku nepoužíva operačný systém. Takýto konflikt vyriešite zmenou skratky, ktorú používa operačný systém alebo môžete zmeniť takmer ktorúkoľvek skratku v LibreOffice. Viac informácií na túto tému vám poskytne Pomocník LibreOffice alebo dokumentácia k vášmu operačnému systému.

----------------------------------------------------------------------
Problémy pri posielaní dokumentov formou emailu z LibreOffice
----------------------------------------------------------------------

Pri odosielaní dokumentov pomocou „Súbor - Odoslať - Dokument e-mailom“ alebo „Dokument ako prílohu v PDF“ sa môžu vyskytnúť problémy (program spadne alebo prestane reagovať). Príčinou je „Mapi“ (Messaging Application Programming Interface) systému Windows, ktoré v niektorých verziách spôsobuje problémy. Bohužiaľ sa nepodarilo vysledovať problém k určitej verzii súboru. Bližšie informácie zistíte na http://www.microsoft.com a vyhľadaním „mapi dll“ v Microsoft Knowledge Base.

----------------------------------------------------------------------
Dôležité poznámky k prístupnosti.
----------------------------------------------------------------------

Pre ďalšie informácie o funkciách prístupnosti v LibreOffice navštívte http://www.libreoffice.org/accessibility/

----------------------------------------------------------------------
Používateľská podpora
----------------------------------------------------------------------

Hlavná stránka podpory http://www.libreoffice.org/support/ poskytuje rôzne možnosti na pomoc s LibreOffice. Vaša otázka už môže byť zodpovedaná - navštívte komunitné fórum na http://www.documentfoundation.org/nabble/ alebo prehľadajte archívy mailovej diskusie 'users@libreoffice.org' na http://www.libreoffice.org/lists/users/. Prípadne, svoje otázky môžete poslať na adresu users@libreoffice.org. Ak sa chcete prihlásiť do diskusie (aby ste dostávali odpovede), pošlite prázdny mail na: users+subscribe@libreoffice.org.

Pozrite si tiež sekciu častých otázok na http://www.libreoffice.org/faq/.

----------------------------------------------------------------------
Oznamovanie chýb & problémov
----------------------------------------------------------------------

Naším systémom na oznamovanie, sledovanie a riešenie problémov je v súčasnosti BugZilla, ktorá je dostupná na https://bugs.libreoffice.org/.Nabádame všetkých používateľov na posielanie správ o chybách, ktoré by sa na ich systéme mohli objaviť. Energické oznamovanie chýb je jedným z najdôležitejších spôsobov prispievania, ktorým komunita používateľov môže prispieť k prebiehajúcemu vývoju a postupnému vylepšovaniu LibreOffice.

----------------------------------------------------------------------
Ako sa zapojiť
----------------------------------------------------------------------

Komunita LibreOffice bude mať prospech z vašej aktívnej účasti na vývoji tohto významného open source projektu.

Už ako používateľ ste významným účastníkom vývoja tohto kancelárskeho balíka. Radi by sme vás však vyzvali, aby ste prevzali ešte aktívnejšiu rolu s perspektívou toho, že sa stanete dlhodobým aktívnym prispievateľom. Prosíme, pridajte sa ku komunite a navštívte stránku http://www.libreoffice.org/contribution/, kde sa dozviete, ako môžete prispieť.

Ako začať
----------------------------------------------------------------------

Najlepším spôsobom, ako začať s prispievaním, je prihlásenie sa do jednej alebo viacerých mailových konferencií. Tu treba chvíľu pozorovať, čo sa deje a postupne využívať archív konferencie na zoznámenie sa s množstvom tém, ktoré boli prejednávané od roku 2000, keď bol zdrojový kód LibreOffice zverejnený. Po zoznámení sa s prostredím stačí poslať mail, v ktorom sa predstavíte a hneď aj možno začať. Pokiaľ ste sa už skôr s open source projektami zoznámili, tak si pozrite naše zoznamy úloh (zoznamy To-Do) na http://www.libreoffice.org/develop/, či sa tam nenájde niečo, s čím by ste chceli pomôcť.

Prihlásiť sa
----------------------------------------------------------------------

Zoznam niekoľkých mailových diskusií, do ktorých sa môžete prihlásiť na http://www.libreoffice.org/contribution/

* Novinky: announce@documentfoundation.org *odporúčané pre všetkých používateľov* (nízka aktivita)
* Mailová konferencia používateľov: users@global.libreoffice.org *jednoduchý spôsob ako sledovať diskusie* (veľká premávka)
* Marketing: marketing@global.libreoffice.org *nielen vývoj* (rastúca premávka)
* Všeobecná diskusia vývojárov: libreoffice@lists.freedesktop.org (vysoká aktivita)

Pridať sa k jednému alebo viacerým projektom
----------------------------------------------------------------------

Môžete sa stať výraznou posilou vývojárskeho tímu, a to aj v prípade, že máte len menšie skúsenosti s vývojom softvéru. Áno, aj vy!

Dúfame, že sa vám bude práca s novým LibreOffice 5.4 páčiť, a že sa k nám pridáte.

Komunita LibreOffice

----------------------------------------------------------------------
Použité/upravené zdrojové kódy
----------------------------------------------------------------------

Časti Copyright 1998, 1999 James Clark. časti Copyright 1996, 1998 Netscape Communications Corporation.
