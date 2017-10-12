
======================================================================
LibreOffice 5.4 LOEMIND
======================================================================


See seletusfail asub värskeimal kujul aadressil http://www.libreoffice.org/welcome/readme.html

See fail sisaldab tähtsat teavet LibreOffice'i tarkvara kohta. On soovituslik see enne paigaldamise alustamist hoolikalt läbi lugeda.

Selle toote arendamise eest vastutav LibreOffice'i kogukond kutsub sindki kogukonnaliikmena osalemist kaaluma. Kui oled uus kasutaja, võid külastada LibreOffice'i saiti, kust leiad palju teavet LibreOffice'i projekti ja selle ümber eksisteerivate kogukondade kohta. Ava http://www.libreoffice.org/.

Kas LibreOffice on tõesti kõigile vaba ja tasuta?
----------------------------------------------------------------------

LibreOffice on vaba ja tasuta kasutamiseks igaühele. Võid selle LibreOffice'i eksemplari paigaldada nii mitmesse arvutisse kui tahad, ja kasutada seda mis tahes otstarbel (sh avaliku halduse, äri-, valitsus- ja haridusasutustes). Üksikasjad leiad litsentsitekstist, mis LibreOffice'i allalaadimisega kaasa tuli.

Miks LibreOffice kõigile vaba ja tasuta on?
----------------------------------------------------------------------

Võid seda LibreOffice'i koopiat tasuta kasutada, sest üksikisikutest kaastöötajad ja firmadest sponsorid on kujundanud, arendanud, testinud, tõlkinud, dokumenteerinud, toetanud, turundanud ja paljudel teistel viisidel kaasa aidanud, et LibreOffice'ist saaks, mis ta täna on - maailmas juhtiv avatud lähtekoodiga loometarkvara koju ja kontorisse.

Kui nende pingutusi hindad ja tahaksid kindlustada, et LibreOffice on jätkuvalt saadaval ka kauges tulevikus, siis kaalu palun projekti aitamist - üksikasjad leiad aadressilt http://www.documentfoundation.org/contribution/. Igaüks saab mingil moel kaasa aidata.

----------------------------------------------------------------------
Märkused paigalduse kohta
----------------------------------------------------------------------

LibreOffice vajab täieliku funktsionaalsuse jaoks Java töökeskkonna (JRE) hiljutist versiooni. JRE ei kuulu LibreOffice'i paigalduspaketti ja tuleks eraldi paigaldada.

Nõuded süsteemile
----------------------------------------------------------------------

* Microsoft Windows XP SP3, Vista, 7, 8 või 10

Märkus: paigaldamiseks on vaja administraatori õigusi.

LibreOffice'i registreerimist Microsoft Office'i vormingus failide vaikimisi avajana saab sundida või keelata järgnevate paigaldusprogrammi käsurea võtmetega:

* REGISTER_ALL_MSO_TYPES=1 sunnib LibreOffice'i registreerimise Microsoft Office'i vormingus failide vaikimisi avajana.
* REGISTER_NO_MSO_TYPES=1 keelab LibreOffice'i registreerimise Microsoft Office'i vormingus failide vaikimisi avajana.

Palun vaata, et süsteemi ajutiste failide kataloogis oleks piisavalt vaba ruumi ja sul oleks piisavad lugemis-, kirjutus- ja käivitusõigused. Enne paigaldamise alustamist sulge kõik teised programmid.

LibreOffice'i paigaldamine Debiani-/Ubuntu-põhistel Linuxi süsteemidel
----------------------------------------------------------------------

Juhised keelepaki paigaldamiseks (pärast LibreOffice'i ingliskeelse versiooni paigaldamist) leiad jaotisest "Keelepaki paigaldamine".

Kui allalaaditud arhiivi lahti pakid, näed, et selle sisu paikneb alamkataloogis. Ava failihaldur ja liigu kataloogi, mille alguses on "LibreOffice_" ja seejärel versiooninumber ning veidi platvormiteavet.

See kataloog sisaldab alamkataloogi "DEBS". Liigu sinna.

Tee kataloogis paremklõps ja vali "Ava terminalis". Avaneb terminaliaken, sisesta seal järgnev käsk (enne selle täitmist palutakse sisestada juurkasutaja parool):

Järgmiste käskudega paigaldatakse LibreOffice'i ja töölaualõimingu paketid (võid need siit terminali kopeerida):

sudo dpkg -i *.deb

Paigaldusprotsess on nüüd lõppenud ja töökeskkonna menüüs (Rakendused/Kontoritöö) peaks leiduma kõik LibreOffice'i rakenduste ikoonid.

LibreOffice'i paigaldamine Fedoral, openSUSE-l, Mandrival ja teistel RPM-pakette kasutavatel Linuxi süsteemidel
----------------------------------------------------------------------

Juhised keelepaki paigaldamiseks (pärast LibreOffice'i ingliskeelse versiooni paigaldamist) leiad jaotisest "Keelepaki paigaldamine".

Kui allalaaditud arhiivi lahti pakid, näed, et selle sisu paikneb alamkataloogis. Ava failihaldur ja liigu kataloogi, mille alguses on "LibreOffice_" ja seejärel versiooninumber ning veidi platvormiteavet.

See kataloog sisaldab alamkataloogi "RPMS". Liigu sinna.

Tee kataloogis paremklõps ja vali "Ava terminalis". Avaneb terminaliaken, sisesta seal järgnev käsk (enne selle täitmist palutakse sisestada juurkasutaja parool):

Fedora-põhistes süsteemides: su -c 'yum install *.rpm'

Mandriva-põhistes süsteemides: sudo urpmi *.rpm

Teistes RPM-põhistes süsteemides (openSUSE jm): rpm -Uvh *.rpm

Paigaldusprotsess on nüüd lõppenud ja töökeskkonna menüüs (Rakendused/Kontoritöö) peaks leiduma kõik LibreOffice'i rakenduste ikoonid.

Teine võimalus on kasutada skripti "install", mis asub selle arhiivi kataloogipuu tipus. Skript paigaldab LibreOffice'i kasutaja õigustes (s.t mitte süsteemselt) ja loob sellele eraldi kasutajaprofiili. Pane tähele, et nii jääd ilma süsteemilõimingust, nt kirjetest töölauamenüüs ja MIME-tüüpide registreerimisest.

Märkused töölaualõimingu kohta eeltoodud paigaldusjuhendis mainimata Linuxi distributsioonides
----------------------------------------------------------------------

LibreOffice'i paigaldamine peaks olema üsna lihtne ka neis Linuxi distributsioonides, mida nendes paigaldusjuhistes eraldi nimetatud pole. Erinevused tulevad sisse töölaualõimingu osas.

Kataloog "RPMS" (või "DEBS") sisaldab ka paketti nimega "libreoffice5.4-freedesktop-menus-5.4.0.1-1.noarch.rpm" (või "libreoffice5.4-debian-menus_5.4.0.1-1_all.deb" vmt). See on pakett kõigile Linuxi distrodele, mis toetavad Freedesktop.org-i spetsifikatsioone/soovitusi (http://en.wikipedia.org/wiki/Freedesktop.org), ja on mõeldud paigaldamiseks distrodel, mida eeltoodud juhendis mainitud pole.

Keelepaki paigaldamine
----------------------------------------------------------------------

Laadi alla soovitud keelepakett vajalikule platvormile. Need on saadaval samast kohast kui põhipaigaldusarhiiv. Paki allalaaditud arhiiv Nautiluse failihalduris lahti (nt töölauale) ja vaata, et oleksid sulgenud kõik LibreOffice'i rakendused (ka kiirkäivitaja, kui see töötab).

Liigu kataloogi, kuhu allalaaditud keelepaki lahti pakkisid.

Nüüd liigu kataloogi, mis lahtipakkimisel loodi. Näiteks eesti keelepaki puhul on 32-bitisele Debiani-/Ubuntu-põhisele süsteemile mõeldud kataloogi nimi "LibreOffice_ + veidi versiooniteavet + Linux_x86_langpack-deb_et".

Nüüd liigu kataloogi, kus on paigaldatavad paketid. Debiani-/Ubuntu-põhistes süsteemides on selleks kataloogiks "DEBS", Fedora-, openSUSE- ja Mandriva-põhistes süsteemides "RPMS".

Tee Nautiluse failihalduris kataloogis paremklõps ja vali käsk "Ava terminalis". Avaneb terminaliaken, sisesta seal käsk keelepaki paigaldamiseks (enne selle täitmist võidakse paluda sisestada juurkasutaja parool):

Debiani-/Ubuntu-põhistes süsteemides: sudo dpkg -i *.deb

Fedora-põhistes süsteemides: su -c 'yum install *.rpm'

Mandriva-põhistes süsteemides: sudo urpmi *.rpm

Teistes RPM-põhistes süsteemides (openSUSE jm): rpm -Uvh *.rpm

Nüüd käivita mõni LibreOffice'i rakendustest - nt Writer. Ava menüü "Tööriistad" ja vali "Sätted". Avanenud aknas klõpsa "Keelesätted" ja siis "Keeled" ning vali "Kasutajaliidese" loendist äsjapaigaldatud keel. Soovi korral võid sama teha "Lokaadi", "Vaikimisi rahaühiku" ja "Dokumentide vaikimisi keelega".

Pärast nende sätete muutmist klõpsa "OK". Dialoog sulgub ja kuvatakse teade, et muutused rakenduvad alles pärast LibreOffice'i taaskäivitamist (pea meeles ka kiirkäivitaja sulgeda, kui see töötab).

Järgmine kord käivitub LibreOffice valitud keeles.

----------------------------------------------------------------------
Probleemid rakenduse käivitamisel
----------------------------------------------------------------------

LibreOffice'i käivitamise ja ka ekraani kuvaga seotud probleemid (näiteks rakenduse hangumine) on sageli põhjustatud graafikakaardi draiverist. Taoliste probleemide ilmnemisel uuenda graafikakaardi draivereid või proovi kasutada operatsioonisüsteemiga kaasasolevaid draivereid. Ruumiliste objektide kuvamisega seotud probleeme on sageli võimalik lahendada eemaldades märgistuse dialoogis "Tööriistad - Sätted - LibreOffice - Vaade - Ruumiline vaade" olevalt sättelt "Kasutatakse OpenGL-i".

----------------------------------------------------------------------
Sülearvutite ALPS/Synapticsi puutepadjad Windowsis
----------------------------------------------------------------------

Vea tõttu Windowsi draiveris ei saa sõrme libistamisel üle ALPS/Synapticsi puutepadja kerida LibreOffice'i dokumente.

Puutepadja abil kerimise võimaldamiseks tuleb häälestusfaili "C:\Program Files\Synaptics\SynTP\SynTPEnh.ini" lisada järgnevad read ning arvuti uuesti käivitada:

[LibreOffice]

FC = "SALFRAME"

SF = 0x10000000

SF |= 0x00004000

Märkus: häälestusfaili asukoht võib erinevates Windowsi versioonides olla erinev.

----------------------------------------------------------------------
Kiirklahvid
----------------------------------------------------------------------

LibreOffice'is on võimalik kasutada vaid neid kiirklahve (klahvikombinatsioone), mis pole operatsioonisüsteemi poolt juba kasutusel. Kui klahvikombinatsioon ei tööta LibreOffice'is nii nagu kirjeldatud LibreOffice'i abis, siis kontrolli, kas see klahvikombinatsioon on juba operatsioonisüsteemis kasutusel. Üheks konflikti lahendamise võimaluseks on muuta operatsioonisüsteemi kiirklahve. Alternatiivse võimalusena on LibreOffice'is võimalik muuta peaaegu kõiki klahvikombinatsioonide omistusi. Täpsema info saamiseks vaata LibreOffice'i abi või oma operatsioonisüsteemi dokumentatsiooni.

----------------------------------------------------------------------
Probleemid dokumentide saatmisel LibreOffice'ist e-kirjana
----------------------------------------------------------------------

Dokumendi saatmisel kasutades menüüvalikuid "Fail - Saada - Dokument e-postiga" või "Dokument PDF-ina kaasa" võib tekkida probleeme (rakendust tabab krahh või see hangub). Selle põhjustajaks on Windowsi süsteemifail "Mapi" (Messaging Application Programming Interface), mille mõned versioonid ei tööta korralikult. Kahjuks pole võimalik probleemi kindlate versiooninumbritega kirjeldada. Täpsema info saamiseks külasta aadressi http://www.microsoft.com ja otsi Microsoft Knowledge Base'ist "mapi dll".

----------------------------------------------------------------------
Tähtis teave hõlbustuse kohta
----------------------------------------------------------------------

Teabe saamiseks LibreOffice'i hõlbustusfunktsioonide kohta vaata http://www.libreoffice.org/accessibility/

----------------------------------------------------------------------
Kasutajatugi
----------------------------------------------------------------------

Üldine tugilehekülg http://www.libreoffice.org/support/ pakub mitmesuguseid võimalusi LibreOffice'i osas abi saada. Sinu küsimusele on ehk juba vastatud - vaata kogukonnafoorumist (http://www.documentfoundation.org/nabble/) või otsi postiloendi 'users@libreoffice.org' arhiividest (http://www.libreoffice.org/lists/users/). Teine võimalus on saata oma küsimused aadressile users@libreoffice.org. Kui tahaksid loendit tellida (et oma kirjadele vastuseid saada), saada tühi kiri aadressile users+subscribe@libreoffice.org.

Vaata ka KKK jaotist aadressil http://www.libreoffice.org/faq/.

----------------------------------------------------------------------
Leitud vigadest ja probleemidest teatamine
----------------------------------------------------------------------

Süsteem, mida kasutame vigadest teatamiseks, nende jälitamiseks ja lahendamiseks, on hetkel BugZilla, mida lahkesti aadressil https://bugs.libreoffice.org/ majutatakse. Kutsume kõiki kasutajaid üles tunnetama oma õigust ja võimalust teatada vigadest, mis nende kontreetsel platvormil esinevad. Aktiivne vigadest teatamine on üks olulisemaid panuseid, mida kasutajaskond LibreOffice'i jätkuva arendamise ja täiustamise heaks teha saab.

----------------------------------------------------------------------
Projektiga ühinemine
----------------------------------------------------------------------

LibreOffice'i kogukond saaks palju kasu sinu aktiivsest osavõtust selle tähtsa vabatarkvaralise projekti arendamisel.

Kasutajana oledki juba arendusprotsessi väärtuslik osa ja me sooviksime sind julgustada projektist veelgi aktiivsemalt osa võtma, väljavaatega olla kogukonnale pikaajaline kaastöötaja. Palun liitu ja vaata üle kaasaaitamise leht http://www.libreoffice.org/contribution/

Kuidas alustada
----------------------------------------------------------------------

Parim viis hakata kaasa aitama on tellida postiloend või ka mitu, mõnda aega neid jälgida ja end postiloendite arhiivide abil tasapisi kurssi viia paljude teemadega, mida seal on käsitletud alates LibreOffice'i lähtekoodi avaldamisest oktoobris 2000. Kui end pädevana tunned, siis saada alustuseks ennast tutvustav kiri postiloendisse ja asu töö kallale. Kui oled avatud lähtekoodiga projektidega tuttav, vaata, kas leiad meie tegemist ootavate asjade loenditest midagi, millega aidata tahaksid: http://www.libreoffice.org/develop/.

Tellimine
----------------------------------------------------------------------

Siin on mõned postiloendid, mida aadressil http://www.libreoffice.org/contribution/ tellida saad

* Uudised: announce@documentfoundation.org *soovitatav kõigile kasutajatele* (vähene liiklus)
* Põhiline kasutajate loend: users@global.libreoffice.org *lihtne viis arutelude jälgimiseks* (tihe liiklus)
* Turundusprojekt: marketing@global.libreoffice.org *arendusest väljaspool olev jutt* (tihenev liiklus)
* Üldine arendajate loend: libreoffice@lists.freedesktop.org (tihe liiklus)

Mõne projektiga ühinemine
----------------------------------------------------------------------

Kaastööd sellele tähtsale projektile on võimalik teha isegi siis, kui sul on vaid piiratud teadmised tarkvara disainist ja programmeerimisest.

Loodame, et naudid uue LibreOffice 5.4 töötamist ja ühined meiega.

LibreOffice'i kogukond

----------------------------------------------------------------------
Kasutatud ja muudetud lähtetekst
----------------------------------------------------------------------

Teatud osade autoriõigus 1998, 1999 James Clark. Teatud osade autoriõigus 1996, 1998 Netscape Communications Corporation.
