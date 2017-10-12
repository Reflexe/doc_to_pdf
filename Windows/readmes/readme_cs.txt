
======================================================================
LibreOffice 5.4 ReadMe
======================================================================


Nejnovější verzi tohoto souboru readme (čtimě) najdete na stránce http://www.libreoffice.org/welcome/readme.html

Tento soubor obsahuje důležité informace o programu LibreOffice. Doporučujeme Vám přečíst si je dříve, než program začnete instalovat.

Komunita LibreOffice je zodpovědná za vývoj tohoto produktu a dovoluje si Vás pozvat, abyste se stali jejím členem. Pokud jste nový uživatel, můžete navštívit stránky LibreOffice, kde najdete množství informací o projektu LibreOffice a o komunitách, které okolo něj existují. Více najdete na adrese http://www.libreoffice.org/.

Je LibreOffice skutečně zdarma pro všechny?
----------------------------------------------------------------------

LibreOffice může kdokoli svobodně používat. Můžete tuto kopii LibreOffice vzít a nainstalovat na tolik počítačů, kolik jen chcete, a používat k jakýmkoli účelům (včetně použití ve firmách, státní a veřejné správě a ve školách). Další informace jsou uvedeny v textu licence, která je součástí balíčku LibreOffice.

Proč je LibreOffice zdarma pro všechny?
----------------------------------------------------------------------

Tuto kopii LibreOffice můžete zdarma používat díky tomu, že individuální přispěvatelé a firemní sponzoři navrhovali, vyvíjeli, testovali, překládali, dokumentovali, podporovali, propagovali a v mnoha dalších ohledech pomáhali udělat z LibreOffice to, čím je dnes - světovým lídrem v oblasti open-source kancelářských programů pro domácí i firemní využití.

Pokud si ceníte jejich snahy a chtěli byste zajistit vývoj LibreOffice i v budoucnu, zvažte prosím možnost přispění do tohoto projektu - navštivte http://www.documentfoundation.org/contribution/, kde najdete detaily. Každý může nějak přispět.

----------------------------------------------------------------------
Poznámky k instalaci
----------------------------------------------------------------------

Pro plnou funkcionalitu vyžaduje LibreOffice aktuální verzi běhového prostředí Java (JRE). JRE není součástí instalace LibreOffice a musí tak být nainstalováno samostatně.

Systémové požadavky
----------------------------------------------------------------------

* Microsoft Windows XP SP3, Vista, 7, 8 nebo 10

Pro instalaci je třeba mít oprávnění správce systému.

Registraci LibreOffice jako výchozího programu pro formáty Microsoft Office lze vynutit nebo zakázat pomocí následujících přepínačů instalátoru:

* REGISTER_ALL_MSO_TYPES=1 zaregistruje LibreOffice jako výchozí program pro formáty Microsoft Office.
* REGISTER_NO_MSO_TYPES=1 potlačí registraci LibreOffice jako výchozího programu pro formáty Microsoft Office.

Ujistěte se, že máte dostatek volného místa v dočasném adresáři systému a že také máte právo číst, zapisovat a spouštět programy. Před spuštěním instalace ukončete všechny ostatní programy.

Instalace LibreOffice na linuxových systémech založených na Debian/Ubuntu
----------------------------------------------------------------------

Návod na instalaci jazykového balíčku (po nainstalování anglické verze LibreOffice) naleznete níže v sekci Instalace jazykového balíčku.

Když rozbalíte stažený archiv, všimněte si, že se jeho obsah se rozbalil do podadresáře. Otevřete okno správce souborů a změňte adresář na ten, který začíná řetězcem "LibreOffice_" následovaným číslem verze a informací o platformě.

Tento adresář obsahuje podadresář "DEBS". Přejděte do adresáře "DEBS".

Klikněte pravým tlačítkem uvnitř adresáře a zvolte "Otevřít v terminálu". Otevře se okno terminálu. Na příkazové řádce terminálu zadejte následující příkaz (před vykonáním příkazu budete vyzváni, abyste zadali heslo uživatele s administrátorskými právy):

Následující příkazy nainstalují LibreOffice a balíčky pro integraci s desktopem (místo jejich opisování je můžete jednoduše zkopírovat a vložit do terminálu):

sudo dpkg -i *.deb

Proces instalace je dokončen a nabídka pracovní plochy Aplikace/Kancelář by měla obsahovat ikony pro všechny aplikace LibreOffice.

Instalace LibreOffice na linuxových systémech Fedora, openSuse, Mandriva, nebo jiných používajících balíčky RPM
----------------------------------------------------------------------

Návod na instalaci jazykového balíčku (po nainstalování anglické verze LibreOffice) naleznete níže v sekci Instalace jazykového balíčku.

Když rozbalíte stažený archiv, všimněte si, že se jeho obsah se rozbalil do podadresáře. Otevřete okno správce souborů a změňte adresář na ten, který začíná řetězcem "LibreOffice_" následovaným číslem verze a informací o platformě.

Tento adresář obsahuje podadresář "RPMS". Přejděte do adresáře "RPMS".

Klikněte pravým tlačítkem uvnitř adresáře a zvolte "Otevřít v terminálu". Otevře se okno terminálu. Na příkazové řádce terminálu zadejte následující příkaz (před vykonáním příkazu budete vyzváni, abyste zadali heslo uživatele s administrátorskými právy):

Pro systémy založené na Fedoře: su -c 'yum install *.rpm'

Pro systémy založené na Mandrivě: sudo urpmi *.rpm

Pro ostatní systémy používající RPM (openSuse, atd.): rpm -Uvh *.rpm

Proces instalace je dokončen a nabídka desktopového prostředí Aplikace/Kancelář by měla obsahovat ikony pro všechny aplikace LibreOffice.

Jako alternativu můžete pomocí skriptu 'install' umístěného v kořenovém adresáři tohoto archivu spustit uživatelskou instalaci. Tento skript vytvoří pro tuto instalaci LibreOffice samostatný profil oddělený od běžného profilu LibreOffice. Nebudou nainstalovány součásti systémové integrace jako položky v nabídkách nebo registrace MIME typů.

Poznámky ohledně integrace do desktopového prostředí pro linuxové distribuce, kterých se netýká výše uvedený návod
----------------------------------------------------------------------

Instalace LibreOffice na linuxových distribucích, které nejsou v tomto návodu na instalaci zmíněny, by měla být rovněž snadná. Mezi hlavní odlišnosti bude pravděpodobně patřit integrace do desktopového prostředí.

Adresář RPMS (resp. DEBS) obsahuje také balíček pojmenovaný libreoffice5.4-freedesktop-menus-5.4.0.1-1.noarch.rpm (resp. libreoffice5.4-debian-menus_5.4.0.1-1_all.deb nebo podobně). Tento balíček je určen pro všechny linuxové distribuce splňující standardy Freedesktop.org (http://en.wikipedia.org/wiki/Freedesktop.org) a je poskytován pro ostatní linuxové distribuce, které nejsou ve výše uvedeném návodu na instalaci zmíněny.

Instalace jazykového balíčku
----------------------------------------------------------------------

Stáhněte si jazykový balíček pro požadovaný jazyk a platformu. Ty jsou dostupné na stejném místě jako hlavní instalační archiv. Ze správce souborů rozbalte archiv jazykového balíčku do adresáře (např. na svou pracovní plochu). Přesvědčete se, že všechny aplikace LibreOffice (včetně rychlého spouštěče QuickStarter) jsou uzavřené.

Přejděte do adresáře, do kterého jste rozbalili jazykový balíček.

Nyní přejděte do adresáře, který byl vytvořený v průběhu rozbalování. Například v případě českého jazykového balíčku pro 32-bitový systém Debian/Ubuntu se adresář nazývá LibreOffice_(informace o verzi)_Linux_x86_langpack-deb_cs.

Nyní přejděte do adresáře, který obsahuje balíčky, které chcete nainstalovat. V systémech Debian/Ubuntu je to DEBS, ve Fedoře, SUSE, nebo Mandrivě je to RPMS.

Ve správci souborů Nautilus klikněte pravým tlačítkem uvnitř adresáře a zvolte "Otevřít v terminálu". V okně terminálu, které se tím otevře, zadejte příkaz k nainstalování jazykového balíčku (před vykonáním kteréhokoli z příkazů můžete být vyzváni, abyste zadali heslo uživatele s administrátorskými právy):

Pro systémy založené na Debianu/Ubuntu: sudo dpkg -i *.deb

Pro systémy založené na Fedoře: su -c 'yum install *.rpm'

Pro systémy založené na Mandrivě: sudo urpmi *.rpm

Pro ostatní systémy používající RPM (openSuse, atd.): rpm -Uvh *.rpm

Nyní můžete spustit jednu z aplikací LibreOffice - například Writer. Přejděte do nabídky Nástroje a zvolte Možnosti. V dialogovém okně Možnosti klikněte na "Jazyková nastavení" a pak na "Jazyky". Z nabídky "Uživatelské rozhraní" vyberte jazyk, který jste právě nainstalovali. Stejně tak můžete postupovat pro "Národní prostředí", "Výchozí měna" a "Výchozí jazyk dokumentů".

Po úpravách těchto nastavení klikněte na OK. Okno dialogu bude uzavřeno a bude vám zobrazena zpráva informující vás o provedení změn po ukončení a restartu aplikace LibreOffice (nezapomeňte ukončit i Rychlé spuštění, pokud je spuštěno).

Příště až spustíte LibreOffice, spustí se v právě nainstalovaném jazyku.

----------------------------------------------------------------------
Potíže se spuštěním aplikace
----------------------------------------------------------------------

Potíže při spouštění LibreOffice (např. zaseknutí aplikace) i problémy se zobrazením na obrazovce často způsobuje ovladač grafické karty. Pokud dochází k potížím, aktualizujte ovladač grafické karty nebo vyzkoušejte ovladač dodaný s operačním systémem. Problémy se zobrazením 3D objektů lze často vyřešit vypnutím volby "Použít OpenGL" v nabídce "Nástroje - Možnosti - LibreOffice - Zobrazení - 3D zobrazení".

----------------------------------------------------------------------
Touchpady ALPS/Synaptics přenosných počítačů v systému Windows
----------------------------------------------------------------------

Kvůli problémům s ovladačem systému Windows není možné rolovat dokumenty LibreOffice posunem prstu po ploše touchpadu.

Chcete-li povolit posun pomocí touchpadu, přidejte do konfiguračního souboru "C:\Program Files\Synaptics\SynTP\SynTPEnh.ini" následující řádky a restartujte počítač:

[LibreOffice]

FC = "SALFRAME"

SF = 0x10000000

SF |= 0x00004000

Umístění konfiguračního souboru se může lišit v závislosti na verzi Windows.

----------------------------------------------------------------------
Zkratky
----------------------------------------------------------------------

V LibreOffice lze použít pouze klávesové zkratky, které nepoužívá operační systém. Pokud klávesová zkratka v LibreOffice nefunguje tak, jak je popsáno v nápovědě LibreOffice, zkontrolujte, zda již tuto klávesovou zkratku nepoužívá operační systém. Tyto konflikty můžete vyřešit změnou klávesových zkratek používaných operačním systémem. Je možné také změnit téměř všechny klávesové zkratky LibreOffice. Bližší informace naleznete v nápovědě LibreOffice nebo v dokumentaci operačního systému.

----------------------------------------------------------------------
Potíže při odesílání dokumentů z LibreOffice e-mailem
----------------------------------------------------------------------

Při odesílání dokumentu pomocí 'Soubor - Odeslat - Dokument jako e-mail' nebo 'Dokument jako příloha v PDF' se mohou vyskytnout chyby (program bude ukončen nebo přestane reagovat). Problém způsobuje "MAPI" (Messaging Application Programming Interface) v některých verzích systému Windows. Bližší informace o potřebné verzi knihovny MAPI nejsou bohužel známy. Bližší informace naleznete v Microsoft Knowledge Base dostupné z adresy http://www.microsoft.com vyhledáním "mapi dll".

----------------------------------------------------------------------
Důležité poznámky ke zpřístupnění
----------------------------------------------------------------------

Pro více informací o funkcích zpřístupnění v LibreOffice navštivte http://www.libreoffice.org/accessibility/

----------------------------------------------------------------------
Uživatelská podpora
----------------------------------------------------------------------

Stránka podpory http://www.libreoffice.org/support/ nabízí různé možnosti pomoci s LibreOffice. Jelikož vaše otázka mohla být již zodpovězena, zkontrolujte komunitní fórum na http://www.documentfoundation.org/nabble/ a prohledejte archiv e-mailové konference 'users@libreoffice.org' na adrese http://www.libreoffice.org/lists/users/. Případně můžete zaslat svoji otázku e-mailem na users@libreoffice.org. Pokud se chcete přihlásit do konference (a odebírat e-mailem odpovědi), zašlete prázdný e-mail na adresu users+subscribe@libreoffice.org.

Prohlédněte si též na sekci často kladených dotazů (FAQ) na http://www.libreoffice.org/faq/.

----------------------------------------------------------------------
Oznamování chyb a problémů
----------------------------------------------------------------------

Náš systém pro hlášení, sledování a řešení chyb a požadavků BugZilla je dostupný na adrese https://bugs.libreoffice.org/. Neváhejte využít možnosti hlásit připomínky a chyby, které ve své instalaci objevíte. Aktivní hlášení chyb je jedním z nejdůležitějších způsobů, jak komunita uživatelů přispívá k dalšímu vývoji a zlepšování LibreOffice.

----------------------------------------------------------------------
Zapojujeme se
----------------------------------------------------------------------

Komunita LibreOffice bude mít z vaší aktivní účasti na vývoji prospěch.

Už jako uživatel jste významným účastníkem vývoje tohoto kancelářského balíku. Rádi bychom vás však podpořili v převzetí ještě aktivnější role s perspektivou toho, že se stanete dlouhodobým aktivním členem komunity. Přidejte se prosím a navštivte stránku http://www.libreoffice.org/contribution/

Jak začít
----------------------------------------------------------------------

Nejlepším způsobem, jak začít přispívat, je přihlásit se do jedné nebo více mailových konferencí. Chvíli můžete pozorovat, co se děje, či používat archiv, abyste se seznámili s tématy, která již byla probrána od doby, kdy byl v říjnu 2000 zdrojový kód LibreOffice zveřejněn. Po seznámení se s prostředím můžete poslat e-mail, ve kterém se krátce představíte, a ihned můžete začít. Pokud již máte předchozí zkušenosti s open-source projekty, podívejte se, zda vás nezaujme některý z úkolů na http://www.libreoffice.org/develop/.

Přihlášení
----------------------------------------------------------------------

Tyto a další e-mailové konference lze odebírat ze stránek http://www.libreoffice.org/contribution/

* Novinky: announce@documentfoundation.org *doporučováno všem uživatelům* (mírný provoz)
* Konference uživatelů: users@global.libreoffice.org *jednoduchý způsob jak sledovat diskuse* (velký provoz)
* Marketing: marketing@global.libreoffice.org *nejen vývoj* (narůstající provoz)
* Konference vývojářů: libreoffice@lists.freedesktop.org (hustý provoz)

Připojit se k jednomu nebo více projektů
----------------------------------------------------------------------

Můžete se stát výraznou posilou vývojářského týmu a to i v případě, že máte pouze menší zkušenosti s vývojem softwaru. Ano, i vy!

Doufáme, že se vám bude práce s LibreOffice 5.4 líbit a že se přidáte k našemu týmu.

Komunita LibreOffice

----------------------------------------------------------------------
Použité/upravené zdrojové kódy
----------------------------------------------------------------------

Části Copyright 1998, 1999 James Clark. Části Copyright 1996, 1998 Netscape Communications Corporation.
