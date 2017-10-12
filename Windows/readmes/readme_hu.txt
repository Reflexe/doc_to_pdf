
======================================================================
LibreOffice 5.4 – Fontos információk
======================================================================


Ennek a fájlnak a legújabb verzióját a http://www.libreoffice.org/welcome/readme.html címen érheti el.

Ez a fájl fontos információkat tartalmaz a LibreOffice programról. A program telepítése előtt alaposan tanulmányozza ezeket az információkat.

A LibreOffice közösség, amely ennek a terméknek a fejlesztéséért felelős, minden új tagnak örül. Ha Ön új felhasználó, a LibreOffice weboldalán rengeteg információt talál a LibreOffice projektről és a köré szerveződött közösségről. Látogasson el a http://www.libreoffice.org/ weboldalra.

A LibreOffice tényleg minden felhasználónak ingyenes?
----------------------------------------------------------------------

A LibreOffice mindenki számára szabadon használható. A LibreOffice jelen példányát annyi számítógépre telepíti, amennyire szeretné, és bármilyen célra felhasználhatja (beleértve a kereskedelmi, kormányzati, nyilvános vagy oktatási felhasználást). Bővebb információért olvassa el a LibreOffice termékhez kapott licencet.

Miért ingyenes a LibreOffice minden felhasználó számára?
----------------------------------------------------------------------

A LibreOffice-t azért használhatja ingyenesen, mert az egyéni hozzájárulók és vállalati szponzorok tervezték, fejlesztették, tesztelték, fordították, dokumentálták, támogatták, marketingelték és más módokon segítették. A LibreOffice ezért válhatott azzá, ami ma – a világ vezető nyílt forráskódú irodai szoftvere.

Amennyiben értékeli az erőfeszítésüket, és szeretne gondoskodni arról, hogy a LibreOffice a jövőben is életképes legyen, kérjük, támogassa a projektet. A részleteket lásd a http://www.documentfoundation.org/contribution/ weboldalon. Mindenki segíthet valahogy.

----------------------------------------------------------------------
Megjegyzések a telepítéshez
----------------------------------------------------------------------

LibreOffice egyes funkcióihoz Java futtatókörnyezet (JRE) szükséges. A JRE nem része a LibreOffice telepítőkészletének. Külön kell telepíteni.

Rendszerkövetelmények
----------------------------------------------------------------------

* Microsoft Windows XP SP3, Vista, 7, 8, vagy 10

A telepítéshez rendszergazdai jogosultságokra van szükség.

A LibreOffice regisztrálása a Microsoft Office formátumok megnyitására használt alapértelmezett alkalmazásként a következő parancssori kapcsolókkal kényszeríthető, illetve tiltható:

* A REGISTER_ALL_MSO_TYPES=1 a LibreOffice szoftvert regisztrálja a Microsoft Office formátumok alapértelmezett alkalmazásaként.
* A REGISTER_NO_MSO_TYPES=1 a LibreOffice szoftvert nem regisztrálja a Microsoft Office formátumok alapértelmezett alkalmazásaként.

Ellenőrizze, hogy van-e elegendő szabad hely az ideiglenes könyvtárban, és ehhez a könyvtárhoz rendelkezik-e olvasási, írási és futtatási jogosultságokkal. A telepítés előtt célszerű kilépni minden egyéb programból.

A LibreOffice telepítése Debian- vagy Ubuntu-alapú Linux-rendszerekre
----------------------------------------------------------------------

A nyelvi csomag telepítésének lépéseit (a LibreOffice angol verziójának telepítése után) az alábbi, Nyelvi csomag telepítése szakaszban találja.

A letöltött archívum kicsomagolása után az archívum tartalma egy alkönyvtárba kerül. Nyissa meg a fájlkezelőben ezt a könyvtárat, amely a „LibreOffice_” karakterekkel kezdődik, és a verziószám és a platforminformációk vannak utána.

Ebben a könyvtárban van egy „DEBS” alkönyvtár. Lépjen be a „DEBS” alkönyvtárba.

Kattintson a jobb egérgombbal, és a helyi menüből válassza a „Megnyitás terminálban” parancsot. Megnyílik egy terminálablak. A terminálablak parancssorába írja be a következő parancsot (a rendszer kérni fogja a rendszergazda jelszavát):

A következő parancsok telepítik a LibreOffice-t és az asztali integrációs csomagokat (másolja és illessze be ezeket a terminálba ahelyett, hogy begépelné):

sudo dpkg -i *.deb

A telepítés ezzel kész, és a LibreOffice-alkalmazások ikonjainak meg kell jelenniük az Alkalmazások/Iroda menüben.

A LibreOffice telepítése Fedora, openSUSE, Mandriva vagy egyéb, RPM-csomagokat használó Linux-rendszerekre
----------------------------------------------------------------------

A nyelvi csomag telepítésének lépéseit (a LibreOffice angol verziójának telepítése után) az alábbi, Nyelvi csomag telepítése szakaszban találja.

A letöltött archívum kicsomagolása után az archívum tartalma egy alkönyvtárba kerül. Nyissa meg a fájlkezelőben ezt a könyvtárat, amely a „LibreOffice_” karakterekkel kezdődik, és a verziószám és a platforminformációk vannak utána.

Ebben a könyvtárban van egy „RPMS” alkönyvtár. Lépjen be az „RPMS” alkönyvtárba.

Kattintson a jobb egérgombbal, és a helyi menüből válassza a „Megnyitás terminálban” parancsot. Megnyílik egy terminálablak. A terminálablak parancssorába írja be a következő parancsot (a rendszer kérni fogja a rendszergazda jelszavát):

Fedora-alapú rendszereken: su -c 'yum install *.rpm'

Mandriva-alapú rendszereken: sudo urpmi *.rpm

Egyéb RPM-alapú rendszereken (openSUSE stb.): rpm -Uvh *.rpm

A telepítés ezzel kész, és a LibreOffice-alkalmazások ikonjainak meg kell jelenniük az Alkalmazások/Iroda menüben.

Ennek alternatívájaként használhatja az „install” parancsfájlt az archívum felső szintjén a felhasználóként való telepítéshez. A parancsfájl úgy állítja be a(z) LibreOffice telepítését, hogy saját, a normál LibreOffice profiltól független profilt használjon. Ne feledje, hogy ez nem telepíti a rendszerintegrációs részeket, például az asztali menü elemeit és az asztali MIME-típus regisztrációkat.

Megjegyzések a munkaasztali integrációval kapcsolatban a fentiekben nem tárgyalt Linux-disztribúciók esetén
----------------------------------------------------------------------

A LibreOffice telepítése az ebben a dokumentumban nem említett Linux-diszribúciókra valószínűleg szintén egyszerűen elvégezhető. Egyedül a munkaasztali integrációban lehet eltérés.

Az RPMS vagy DEBS könyvtár tartalmaz egy libreoffice5.4-freedesktop-menus-5.4.0.1-1.noarch.rpm (vagy libreoffice5.4-debian-menus_5.4.0.1-1_all.deb (vagy hasonló) nevű csomagot. Ez a csomag minden olyan Linux-disztribúcióra telepíthető, amely támogatja a Freedesktop.org specifikációit/javaslatait (http://en.wikipedia.org/wiki/Freedesktop.org), és ez való azokhoz a Linux-disztribúciókhoz, amelyekről nem szól részletesen ez a dokumentum.

Nyelvi csomag telepítése
----------------------------------------------------------------------

Töltse le a kívánt nyelvhez és platformhoz való nyelvi csomagot. Ezek ugyanonnan elérhetők, ahonnan a fő telepítőkészlet. A Nautilus fájlkezelő segítségével bontsa ki a letöltött archívumot egy könyvtárba (például az asztalra). Lépjen ki minden LibreOffice-alkalmazásból (a Gyorsindítóból is, ha el volt indítva).

Lépjen be abba a könyvtárba, amelybe a letöltött nyelvi csomagot kicsomagolta.

Ezután lépjen be abba a könyvtárba, amely a kicsomagolás után jött létre. Például a magyar nyelvi csomag 32 bites Debian- vagy Ubuntu- alapú rendszeren a LibreOffice_(verziószám)_Linux_x86_langpack-deb_hu alakú lesz.

Ezután lépjen be a telepítendő csomagokat tartalmazó könyvtárba. Debian- vagy Ubuntu-alapú rendszeren ez a DEBS könyvtár. Fedora, openSUSE vagy Mandriva rendszereken ez az RPMS könyvtár.

A Nautilus fájlkezelőben kattintson a jobb egérgombbal, és a helyi menüből válassza a „Megnyitás terminálban” parancsot. Megnyílik egy terminálablak. A terminálablak parancssorába írja be a következő parancsot (a rendszer kérni fogja a rendszergazda jelszavát):

Debian- és Ubuntu-alapú rendszereken: sudo dpkg -i *.deb

Fedora-alapú rendszereken: su -c 'yum install *.rpm'

Mandriva-alapú rendszereken: sudo urpmi *.rpm

Egyéb RPM-alapú rendszereken (openSUSE stb.): rpm -Uvh *.rpm

Ezután indítsa el az egyik LibreOffice-alkalmazást, például a Writert. A Tools menüből válassza az Options lehetőséget. Az Options párbeszédablakban kattintson a „Language Settings” lehetőségre, majd kattintson a „Languages” elemre. A „User interface” legördülő listából kiválaszthatja az imént telepített nyelvet. Ha szeretné, beállíthatja ezt a nyelvet a „Locale setting”, a „Default currency” és a „Default languages for documents” lehetőségeknél is.

A beállítások végeztével nyomja meg az OK gombot. A párbeszédablak bezáródik, és egy figyelmeztető üzenet jelenik meg, hogy a változások csak a LibreOffice újraindítása után fognak életbe lépni. Ne felejtsen el a Gyorsindítóból is kilépni, ha az el volt indítva.

A LibreOffice következő indításakor a kiválasztott nyelven fog megjelenni a felhasználói felület.

----------------------------------------------------------------------
Programindítási problémák
----------------------------------------------------------------------

A LibreOffice indításával kapcsolatos hibák (például egyáltalán nem indul el), sokszor a grafikus kártya beállítására vezethetők vissza. Ebben az esetben frissítse a grafikus kártya illesztőprogramját, vagy használja az operációs rendszer grafikus illesztőprogramját. A 3D objektumokkal kapcsolatos problémák az „OpenGL használata” beállítás tiltásával orvosolhatók (Eszközök → Beállítások → LibreOffice → Nézet → 3D nézet).

----------------------------------------------------------------------
ALPS/Synaptics noteszgépek tapipadja Windows rendszerben
----------------------------------------------------------------------

A Windows illesztőprogramjának hibája miatt nem tudja görgetni a LibreOffice-dokumentumok, amikor átcsúsztatja az ujját az APLS/Synaptic tapipadján.

A tapipados görgetés engedélyezéséhez adja a következő sorokat a „C:\Program Files\Synaptics\SynTP\SynTPEnh.ini” konfigurációs fájlhoz, és indítsa újra a számítógépet:

[LibreOffice]

FC = "SALFRAME"

SF = 0x10000000

SF |= 0x00004000

A konfigurációs fájl helye a különböző Windows-verzióban más-más lehet.

----------------------------------------------------------------------
Gyorsbillentyűk
----------------------------------------------------------------------

A LibreOffice programjain belül csak olyan gyorsbillentyű-kombinációkat lehet használni, amelyeket az operációs rendszer még nem foglalt le. Amennyiben egy billentyűkombináció nem úgy működne a LibreOffice programban, mint ahogyan az le van írva a LibreOffice súgójában, ellenőrizze, hogy nem foglalt-e a billentyűkombináció. Az ütközések elkerüléséhez két lehetőség van. Módosíthatja az operációs rendszer (grafikus felület) gyorsbillentyű-kombinációit vagy a LibreOffice kombinációit. A gyorsbillentyűk beállításához tekintse meg a LibreOffice súgóját, vagy használja az operációs rendszer súgórendszerét.

----------------------------------------------------------------------
Lehetséges problémák, amikor a LibreOffice-ból egy dokumentumot e-mailként szeretne elküldeni
----------------------------------------------------------------------

Hibák léphetnek fel (a program elszáll vagy lefagy), amikor e-mailként el szeretne küldeni egy dokumentumot a „Fájl - Küldés - Dokumentum e-mailként” vagy „Dokumentum PDF-mellékletként” menüpontot kiválasztva. Ennek oka a Windows „MAPI” rendszerfájlja (Messaging Application Programming Interface), amelynek bizonyos verziói problémákat okoznak. Sajnos a probléma nincs egyértelműen egy verzióhoz kötve. További információkért látogasson el a http://www.microsoft.com honlapra, és keressen a Microsoft tudásbázisában a „mapi dll” kulcsszavakra.

----------------------------------------------------------------------
Fontos megjegyzések a kisegítő lehetőségekkel kapcsolatosan
----------------------------------------------------------------------

A LibreOffice kisegítő lehetőségeiről bővebben a http://www.libreoffice.org/accessibility/ oldalon olvashat.

----------------------------------------------------------------------
Felhasználói támogatás
----------------------------------------------------------------------

A fő támogató oldal, a http://www.libreoffice.org/support/ különféle segítségeket ajánl fel a LibreOffice használatához. Lehet, hogy a kérdése meg van már válaszolva – keresse a választ az angol közösségi fórumon (http://www.documentfoundation.org/nabble/), a magyar közösségi fórumon (http://user.services.openoffice.org/hu/forum/), illetve az angol nyelvű „users@libreoffice.org” levelezőlista archívumában a http://www.libreoffice.org/lists/users/ címen. Ha itt nem találná a választ, kérdését felteheti angolul a users@libreoffice.org vagy magyarul a forum@openoffice.hu levelezőlistán. Az angol listára feliratkozni a users+subscribe@libreoffice.org címre elküldött üres levéllel lehet. A magyar listáról a http://www.openoffice.hu/cgi-bin/mailman/listinfo/forum oldalon található további információ.

Olvassa el a gyakran ismételt kérdéseket is a http://www.libreoffice.org/faq/ oldalon.

----------------------------------------------------------------------
Hibák és problémák bejelentése
----------------------------------------------------------------------

A programhibák bejelentésére, nyomon követésére és kijavítására jelenleg egy Bugzilla rendszert használunk, amely a https://bugs.libreoffice.org/ címen érhető el. Szeretnénk bátorítani minden felhasználót, hogy jelentse azokat a hibákat, amelyekkel a rendszerében találkozik. A hibajelentések elküldése az egyik legnagyobb hozzájárulás, amelyet a felhasználói közösség tehet a LibreOffice folyamatos fejlesztése érdekében.

----------------------------------------------------------------------
Részvétel a projektben
----------------------------------------------------------------------

A LibreOffice-közösség számára igen hasznos, ha Ön aktívan részt vesz ennek a nyílt forráskódú projektnek a fejlesztésében.

Mint felhasználó, máris értékes résztvevője a szoftvercsomag fejlesztésének. Azonban arra bátorítjuk, hogy vállaljon aktívabb szerepet, járuljon hozzá akár Ön is a közösség erőfeszítéseihez. Kérjük, csatlakozzon hozzánk, és tekintse meg a hozzájárulói oldalunkat a következő címen: http://www.libreoffice.org/contribution/.

Hogyan kezdje?
----------------------------------------------------------------------

Ha tenni szeretne valamit a LibreOffice projektért, annak az a legjobb módja, hogy feliratkozik egy vagy több levelezőlistára. Figyelje a hozzászólásokat, és használja az archívumot, hogy betekintést szerezzen azokba a témákba, amelyekről a listán a LibreOffice forráskódjának megjelenése, 2000 októbere óta szó volt. Ha úgy érzi, hogy képben van, küldjön egy rövid bemutatkozást a listára, és vegyen részt Ön is az aktív levelezésben. Ha már van tapasztalata nyílt forráskódú projektekkel, tekintse meg a tennivalók listáját: http://www.libreoffice.org/develop/.

Feliratkozás
----------------------------------------------------------------------

Íme a projekt néhány levelezőlistája, amelyekre az alábbi címen iratkozhat fel: http://www.libreoffice.org/contribution/.

* Hírek (angolul): announce@documentfoundation.org *minden felhasználó számára ajánlott* (kis forgalom)
* Fő felhasználói fórum (angolul): users@global.libreoffice.org (nagy forgalom)
* Marketing projekt: marketing@global.libreoffice.org *a fejlesztésen túl* (nagy forgalom)
* Általános fejlesztői levelezőlista: libreoffice@lists.freedesktop.org (nagy forgalom)

Csatlakozás valamelyik projekthez
----------------------------------------------------------------------

Ön is sokat hozzátehet ehhez a fontos nyílt forráskódú projekthez, akkor is, ha csak kevéssé ért a szoftverfejlesztéshez vagy a programozáshoz. Igen, pont Ön!

Reméljük, élvezni fogja a munkát az új LibreOffice 5.4 szoftvercsomaggal, és csatlakozik hozzánk az interneten.

A LibreOffice Közösség

----------------------------------------------------------------------
Használt / módosított forráskód
----------------------------------------------------------------------

Egyes részek Copyright 1998, 1999 James Clark. Egyes részek Copyright 1996, 1998 Netscape Communications Corporation.
