
======================================================================
LibreOffice 5.4 – PreberiMe
======================================================================


Zadnjo različico te datoteke najdete na naslovu http://sl.libreoffice.org/dobrodoslica/preberi-me/. Zadnjo angleško različico te datoteke najdete na naslovu http://www.libreoffice.org/welcome/readme.html.

Ta sestavek vsebuje pomembne informacije o programu LibreOffice. Prosimo, da si ga pred začetkom namestitve programa skrbno preberete.

Skupnost LibreOffice, odgovorna za razvoj tega izdelka, vas vabi k sodelovanju kot člana oz. članico skupnosti. Kot nov uporabnik lahko preverite spletno mesto LibreOffice s priročnimi uporabniškimi informacijami na naslovu http://sl.libreoffice.org/.

Je LibreOffice res zastonj za vse uporabnike?
----------------------------------------------------------------------

Paket LibreOffice je brezplačen za vse. Ta izvod LibreOffice lahko vzamete in namestite na neomejenem številu računalnikov in ga uporabljate za poljubne namene (vključno z rabo v tržne, vladne, javno-upravne in izobraževalne namene). Če želite več informacij, si preberite licenčno pogodbo, ki je priložena LibreOffice.

Zakaj je paket LibreOffice brezplačen za vse uporabnike?
----------------------------------------------------------------------

Ta izvod LibreOffice lahko danes uporabljate brezplačno, ker so posamezni avtorji prispevkov in korporativni sponzorji zasnovali, razvili, preizkusili, prevedli, dokumentirali, podprli, tržili in na mnoge druge načine pomagali narediti LibreOffice to, kar danes je – vodilni svetovni odprto-kodni pisarniški paket za domačo in poslovno rabo.

Če cenite njihove napore in bi radi zagotovili prihodnji razvoj LibreOffice, razmislite o svojem prispevku projektu – oglejte si http://sl.libreoffice.org/sodelujte/, kjer najdete podrobnosti. Vsakdo lahko prispeva na svoj način.

----------------------------------------------------------------------
Opombe o namestitvi
----------------------------------------------------------------------

LibreOffice zahteva za polno delovanje nedavno različico izvajalnega okolja Java (JRE – Java Runtime Environment). Slednja ni del namestitvenega paketa LibreOffice, namestiti jo morate ločeno.

Sistemske zahteve
----------------------------------------------------------------------

* Microsoft Windows XP SP3, Vista, 7, 8 ali 10

Upoštevajte, da za izvedbo namestitve potrebujete skrbniške pravice.

Registracijo LibreOffice kot privzetega programa za datoteke Microsoft Office lahko vsilite ali preprečite z uporabo naslednjih parametrov namestitvenega programa v ukazni vrstici:

* REGISTER_ALL_MSO_TYPES=1 vsili registracijo LibreOffice kot privzetega programa za datoteke vrste Microsoft Office.
* REGISTER_NO_MSO_TYPES=1 prepreči registracijo LibreOffice kot privzetega programa za datoteke vrste Microsoft Office.

Preverite, da je v začasni sistemski mapi dovolj prostega pomnilnika in da imate pravice do branja, pisanja in zagona v tej mapi. Pred začetkom namestitve zaprite vse ostale programe.

Nameščanje LibreOffice na sistemih Linux, ki temeljijo na Debianu/Ubuntuju
----------------------------------------------------------------------

Navodila za namestitev jezikovnega paketa (po namestitvi angleške različice LibreOffice) si preberite v spodnjem odseku Namestitev jezikovnega paketa.

Ko razpakirate preneseni paket, bo vsebina razširjena v podmapo. Odprite okno upravitelja datotek in se postavite v mapo, ki se začenja z »LibreOffice_«, čemur sledi številka različice in podatek o platformi.

Ta mapa vsebuje podmapo »DEBS«. Postavite se v mapo »DEBS«.

Desno kliknite v mapo in izberite »Odpri v terminalu«. Okno terminala se odpre. Iz ukazne vrstice okna terminala vnesite naslednji ukaz (preden se bo ukaz dejansko izvedel, boste povprašani po geslu korenskega uporabnika):

Naslednji ukazi namestijo LibreOffice in pakete za integracijo v namizje (lahko jih kar kopirate in prilepite v okno terminala, ne da bi jih natipkali):

sudo dpkg -i *.deb

Postopek namestitve je tako končan in v meniju Programi/Pisarna (angl. Applications/Office) bi zdaj morali videti ikone vseh programov LibreOffice.

Nameščanje LibreOffice na sistemih Fedora, openSUSE, Mandriva in drugih sistemih Linux, ki uporabljajo pakete RPM
----------------------------------------------------------------------

Navodila za namestitev jezikovnega paketa (po namestitvi angleške različice LibreOffice) si preberite v spodnjem odseku Namestitev jezikovnega paketa.

Ko razpakirate preneseni paket, bo vsebina razširjena v podmapo. Odprite okno upravitelja datotek in se postavite v mapo, ki se začenja z »LibreOffice_«, čemur sledi številka različice in podatek o platformi.

Ta mapa vsebuje podmapo »RPMS«. Postavite se v mapo »RPMS«.

Desno kliknite v mapo in izberite »Odpri v terminalu«. Okno terminala se odpre. Iz ukazne vrstice okna terminala vnesite naslednji ukaz (preden se bo ukaz dejansko izvedel, boste povprašani po geslu korenskega uporabnika):

Sistemi, ki temeljijo na Fedori: su -c 'yum install *.rpm'

Sistemi, ki temeljijo na Mandrivi: sudo urpmi *.rpm

Drugi sistemi, ki uporabljajo RPM (openSUSE itn.): rpm -Uvh *.rpm

Postopek namestitve je tako končan in v meniju Programi/Pisarna (angl. Applications/Office) bi zdaj morali videti ikone vseh programov LibreOffice.

Sicer lahko za uporabniško namestitev uporabite tudi skript »install«, ki se nahaja v vrhnji mapi tega arhiva. Skript bo nastavil LibreOffice tako, da bo imel lasten profil za to namestitev, ki bo ločen od vašega navadnega profila LibreOffice. Upoštevajte, da s tem ne boste namestili integracije v sistem, kot so menijske izbire na namizju in namizna registracija vrst MIME.

Opombe glede namizne integracije v distribucijah Linuxa, ki niso del zgornjih napotkov za nameščanje
----------------------------------------------------------------------

V drugih distribucijah Linuxa, ki niso omenjene v teh namestitvenih navodilih, bi tudi moralo biti mogoče namestiti LibreOffice. Tisto, pri čemur lahko naletite na razlike, je integracija v namizje.

Mapa RPMS (oz. DEBS) vsebuje tudi paket libreoffice5.4-freedesktop-menus-5.4.0.1.1.noarch.rpm (ali libreoffice5.4-debian-menus_5.4.0.1.1_all.deb ali podobnega). To je paket za vse distribucije Linuxa, ki podpirajo specifikacije/priporočila Freedesktop.org (http://en.wikipedia.org/wiki/Freedesktop.org, v angl.), in je na voljo za nameščanje na distribucijah Linuxa, ki niso vsebovane v prej omenjenih navodilih.

Namestitev jezikovnega paketa
----------------------------------------------------------------------

Prenesite jezikovni paket za želeni jezik in platformo. Na voljo so na istem mestu kot osnovni namestitveni paket. Z upraviteljem datotek Nautilus razpakirajte preneseni arhiv v mapo (npr. na namizje). Zagotovite, da ste zaprli vse programe LibreOffice (vključno s Hitrim zaganjalnikom, če je pognan).

Postavite se v mapo, v katero ste razširili preneseni jezikovni paket.

Postavite se v mapo, ki je nastala v postopku razširjanja. Slovenski jezikovni paket za 32-bitni sistem Linux na osnovi Debiana/Ubuntuja je npr. v mapi, ki se začenja z LibreOffice_, čemur sledi informacija o različici in še Linux_x86_langpack-deb_sl.

Postavite se v mapo, ki vsebuje namestitvene pakete. Na sistemih, ki temeljijo na Debianu/Ubuntuju, je to mapa DEBS. Na sistemih Fedora, openSUSE ali Mandriva je to mapa RPMS.

V upravitelju datotek Nautilus desno kliknite v mapo in izberite ukaz »Odpri v terminalu« (»Open in terminal«). V terminalskem oknu, ki ste ga ravno odprli, vnesite ukaz namestitve jezikovnega paketa (pri vseh spodnjih ukazih boste morda morali vnesti geslo korenskega uporabnika):

Sistemi, ki temeljijo na Debianu/Ubuntuju: sudo dpkg -i *.deb

Sistemi, ki temeljijo na Fedori: su -c 'yum install *.rpm'

Sistemi, ki temeljijo na Mandrivi: sudo urpmi *.rpm

Drugi sistemi, ki uporabljajo RPM (openSUSE itn.): rpm -Uvh *.rpm

Zdaj odprite enega od programov LibreOffice – npr. Writer. Pojdite v meni Orodja in izberite Možnosti. V pogovornem oknu Možnosti kliknite »Nastavitve jezika« in nato kliknite »Jeziki«. Odprite spustni seznam »Uporabniški vmesnik« in na njem izberite jezik paketa, ki ste ga ravnokar namestili. Če želite, storite isto v »Področna nastavitev«, »Privzeta valuta«, in »Privzeti jeziki za dokumente«.

Po opravljenih spremembah kliknite V redu. Pogovorno okno se zapre in odpre se opozorilo, da bodo spremembe veljale po izhodu iz programa LibreOffice in njegovem ponovnem zagonu (ne pozabite zapreti tudi Hitrega zaganjalnika, če je zagnan).

Ko naslednjič zaženete LibreOffice, se bo ta zagnal v jeziku, ki ste ga ravnokar namestili in nastavili.

----------------------------------------------------------------------
Težave med zagonom programa
----------------------------------------------------------------------

Težave z zagonom LibreOffice (npr. zastoj programa) kot tudi problemi s prikazom na zaslonu so ponavadi povezane z gonilnikom za grafični vmesnik. Če se pojavijo tovrstne težave, posodobite gonilnik grafičnega vmesnika ali poskusite uporabiti gonilnik, ki je priložen vašemu operacijskem sistemu. Težave s prikazom predmetov 3D lahko pogosto rešite tako, da izključite možnost »Uporabi OpenGL« v »Orodja – Možnosti – LibreOffice – Pogled – 3D-pogled«.

----------------------------------------------------------------------
Sledilne ploščice za notesnike ALPS/Synaptics v okolju Windows
----------------------------------------------------------------------

Zaradi problemov z gonilnikom za okolje Windows drsenje po dokumentih LibreOffice med drsanjem s prsti po sledilni ploščici ALPS/Synaptics ni mogoče.

Če želite vklopiti brskanje po straneh prek sledilne ploščice, dodajte naslednje vrstice v datoteko z nastavitvami »C:\Program Files\Synaptics\SynTP\SynTPEnh.ini« in nato ponovno zaženite računalnik:

[LibreOffice]

FC = "SALFRAME"

SF = 0x10000000

SF |= 0x00004000

Mesto datoteke z nastavitvami se lahko razlikuje v drugih različicah sistema Windows.

----------------------------------------------------------------------
Tipke za bližnjico
----------------------------------------------------------------------

V LibreOffice lahko uporabite samo tipke za bližnjico (kombinacije tipk), ki niso v rabi v vašem operacijskem sistemu. Če kombinacija tipk v LibreOffice ne deluje, kot je opisano v pomoči LibreOffice, preverite, če ta bližnjica ni morda že uporabljena v operacijskem sistemu. Če želite odpraviti takšne spore, lahko spremenite kombinacije tipk, dodeljene operacijskemu sistemu. Lahko pa skoraj vsako dodeljeno kombinacijo tipk spremenite v LibreOffice. Več informacij o tem si najdete v pomoči za LibreOffice ali uporabniški dokumentaciji svojega operacijskega sistema.

----------------------------------------------------------------------
Težave pri pošiljanju dokumentov kot e-pisem iz LibreOffice
----------------------------------------------------------------------

Pri pošiljanju dokumentov z ukazom »Datoteka – Pošlji – Dokument kot e-poštno sporočilo« ali »Dokument kot priponko PDF« lahko pride do težav (program se obesi ali zapre). Razlog za to je v sistemski datoteki okolja Windows »Mapi« (Messaging Application Programming Interface), ki ne deluje z nekaterimi različicami datotek. Žal težave ni mogoče omejiti na določeno različico. Za dodatne informacije obiščite http://www.microsoft.com in v Microsoft Knowledge Base poiščite »mapi dll«.

----------------------------------------------------------------------
Pomembne opombe glede dostopnosti
----------------------------------------------------------------------

Informacije o funkcijah dostopnosti v LibreOffice najdete na naslovu http://sl.libreoffice.org/po-pomoc/dostopnost/.

----------------------------------------------------------------------
Podpora uporabnikom
----------------------------------------------------------------------

Glavna stran za podporo http://sl.libreoffice.org/po-pomoc/ ponuja različne možnosti pomoči pri delu z LibreOffice. Odgovor na vaše vprašanje je morda že zapisan – preverite na forumu skupnosti http://www.documentfoundation.org/nabble/ ali preiščite arhiv dopisnih seznamov »users@sl.libreoffice.org« in »users@libreoffice.org« na naslovih http://www.libreoffice.org/lists/users/ in http://listarchives.libreoffice.org/sl/users/. Lahko pa tudi pošljete svoja vprašanja na naslov users@sl.libreoffice.org (poštni seznam slovenskih uporabnikov LibreOffice.org) ali users@libreoffice.org. Na dopisni seznam slovenskih uporabnikov (da boste prejeli odgovor po e-pošti) se prijavite s praznim e-sporočilom na naslov: users+subscribe@sl.libreoffice.org.

Prav tako preverite razdelek pogosto zastavljenih vprašanj (FAQ) na naslovu http://sl.libreoffice.org/po-pomoc/pogosto-zastavljena-vprasanja/.

----------------------------------------------------------------------
Poročajte o napakah in izboljšavah
----------------------------------------------------------------------

Naš sistem za poročanje, sledenje in odpravljanje napak in vpeljavo izboljšav v program je trenutno BugZilla, ki gostuje na prijaznem naslovu https://bugs.libreoffice.org/. Vse uporabnike spodbujamo, da poročajo o napakah v programu, ki se nanašajo na njihov operacijski sistem. Aktivno poročanje o napakah je eden najpomembnejših prispevkov skupnosti uporabnikov k razvoju in izboljšavi pisarniškega paketa LibreOffice.

----------------------------------------------------------------------
Kako sodelovati
----------------------------------------------------------------------

Skupnosti LibreOffice lahko pomagate, če tudi sami aktivno sodelujete pri razvoju tega pomembnega odprtokodnega projekta.

Kot uporabnik ste že sedaj neprecenljiv del razvojnega procesa pisarniškega paketa, kljub temu pa bi vas radi spodbudili k še bolj aktivnemu sodelovanju, kar lahko vodi do dolgoročnega prispevanja skupnosti. Prosimo vas, da se prijavite in si ogledate uporabniške spletne strani na naslovu http://sl.libreoffice.org/sodelujte/.

Kako začeti
----------------------------------------------------------------------

Najboljši način, da pričnete prispevati skupnosti, je, da se včlanite na enega ali več dopisnih seznamov, nekaj časa opazujete dopisovanje in sčasoma tudi prebrskate arhive, da se seznanite s številnimi temami, ki so bile obdelane od dne, ko je bila izvorna koda LibreOffice javno objavljena (oktober 2000). Ko se počutite dovolj domače, lahko pošljete e-sporočilo s svojo predstavitvijo in pričnete z delom. Če ste že seznanjeni z odprto-kodnimi projekti, preverite, če obstaja kaj, kjer bi lahko pomagali, na seznamu nalog http://sl.libreoffice.org/sodelujte/razvijalci/.

Prijavite se
----------------------------------------------------------------------

Tukaj je nekaj dopisnih seznamov, na katere se lahko prijavite na naslovu http://sl.libreoffice.org/sodelujte/:

* Novice: announce@documentfoundation.org *priporočamo vsem uporabnikom* (malo prometa)
* Forum slovenskih uporabnikov: users@sl.libreoffice.org *poiščite pomoč v slovenskem jeziku* (priporočamo)
* Projekt trženja: marketing@global.libreoffice.org *kjer se razvoj konča* (vedno več prometa)
* Splošni seznam za razvijalce: libreoffice@lists.freedesktop.org (veliko prometa)

Sodelovanje pri projektih
----------------------------------------------------------------------

Tudi z omejenimi sredstvi, programsko opremo in poznavanjem izvorne kode lahko veliko prispevate k razvoju tega pomembnega odprtokodnega projekta. Da, tudi vi!

Upamo, da vam je delo z novim paketom LibreOffice 5.4 v užitek in da se nam boste pridružili na spletu.

Skupnost LibreOffice

----------------------------------------------------------------------
Uporabljena / spremenjena izvorna koda
----------------------------------------------------------------------

Deli: Copyright 1998, 1999 James Clark. Deli: Copyright 1996, 1998 Netscape Communications Corporation.
