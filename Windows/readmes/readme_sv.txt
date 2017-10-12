
======================================================================
LibreOffice Viktigt-fil för 5.4
======================================================================


För de senaste ändringarna av denna fil besök sidan http://www.libreoffice.org/welcome/readme.html

Den här filen innehåller viktig information om programvaran LibreOffice. Du rekommenderas att läsa den här informationen noggrant innan du påbörjar installationen.

LibreOffice-gemenskapen ansvarar för utvecklingen av den här produkten och inbjuder dig att delta som gemenskapsmedlem. Om du är en ny användare kan du besöka hemsidan för LibreOffice, där finner du massor med information om LibreOffice-projektet och gemenskaperna som finns runt det. Gå till http://www.libreoffice.org/.

Är LibreOffice verkligen gratis för alla?
----------------------------------------------------------------------

LibreOffice kan användas fritt av vem som helst. Du kan ta den här kopian av LibreOffice och installera den på så många datorer du vill, och använda den för vilket syfte som helst (inklusive kommersiellt-, myndighets-, statsförvaltnings- och utbildande syfte). För mer information kan du läsa licenstexten som följde med nedladdningen av LibreOffice.

Varför är LibreOffice gratis för alla?
----------------------------------------------------------------------

Du kan använda den här kopian av LibreOffice utan kostnad eftersom individuella bidragsgivare och företagssponsorer har designat, utvecklat, testat, översatt, dokumenterat, supportat, marknadsfört och hjälpt till på många andra sätt för att göra LibreOffice till vad det är idag - världens ledande produktivitetsmjukvara för hem och kontor med öppen källkod.

Om du uppskattar deras arbete och vill försäkra dig om att LibreOffice forsätter att finnas tillgängligt långt in i framtiden, överväg att bidra till projektet - titta på http://www.documentfoundation.org/contribution/ för detaljer. Alla kan bidra på ett eller annat sätt.

----------------------------------------------------------------------
Kommentarer om installationen
----------------------------------------------------------------------

LibreOffice kräver en färsk version av Java Runtime Environment (JRE) för att fungera helt. JRE är inte en del av installationspaketet för LibreOffice, utan ska installeras separat.

Systemkrav
----------------------------------------------------------------------

* Microsoft Windows XP SP3, Vista, 7, 8 eller 10

Observera att du måste ha administratörsrättigheter för kunna att installera programmet.

Du styr om LibreOffice ska vara standardprogram för Microsoft Office- format eller ej med hjälp av följande växlar i kommandoraden tillsammans med installationsprogrammet:

* REGISTER_ALL_MSO_TYPES=1 kommer att registrera LibreOffice som standardprogram för Microsoft Office filformat.
* REGISTER_NO_MSO_TYPES=1 kommer att undvika att LibreOffice registeras som standardprogram för Microsoft Office filformat.

Verifiera att du har tillräckligt med ledigt hårddiskutrymme i den temporära mappen i ditt system, och verifiera att rättigheter att skriva, läsa och köra filer därifrån är satta. Stäng alla andra program innan du startar installationen.

Installation av LibreOffice på Debian- och Ubuntubaserade Linuxsystem.
----------------------------------------------------------------------

För instruktioner om hur du installerar ett språkpaket (efter att ha installerat den engelska versionen av LibreOffice), läs avsnittet nedan med rubriken Installera ett språkpaket.

När du packar upp det nedladdade arkivet kommer du att se att innehållet packats upp till en undermapp. Öppna en filhanterare och välj mappen som börjar med "LibreOffice_", följt av verionsnumret och platformsinformation.

Den här mappen innehåller en undermapp med namnet "DEBS". Öppna mappen "DEBS".

Högerklicka i mappen och välj "Öppna i terminal". En terminalruta öppnas. På kommandoraden i terminalrutan skriver du in följande kommando (du kommer att få skriva in det administrativa root-lösenordet innan kommandot körs):

Följande kommando kommer att installera LibreOffice och skrivbordsintegration (du kan med fördel kopiera och klistra in kommandon i terminalen framför att skriva in dem manuellt):

sudo dpkg -i *.deb

Installationen är nu färdig, och du bör ha ikoner för programmen i LibreOffice under ditt systems Program/Kontor-meny.

Installation av LibreOffice på Fedorea, openSUSE, Mandriva och andra Linuxsystem med RPM-paket.
----------------------------------------------------------------------

För instruktioner om hur du installerar ett språkpaket (efter att ha installerat den engelska versionen av LibreOffice), läs avsnittet nedan med rubriken Installera ett språkpaket.

När du packar upp det nedladdade arkivet kommer du att se att innehållet packats upp till en undermapp. Öppna en filhanterare och välj mappen som börjar med "LibreOffice_", följt av verionsnumret och platformsinformation.

Den här mappen innehåller en undermapp med namnet "RPMS". Öppna mappen "RPMS".

Högerklicka i mappen och välj "Öppna i terminal". En terminalruta öppnas. På kommandoraden i terminalrutan skriver du in följande kommando (du kommer att få skriva in det administrativa root-lösenordet innan kommandot körs):

För Fedora-baserade system: su -c 'yum install *.rpm'

För Mandriva-baserade system: sudo urpmi *.rpm

För andra RPM-baserade system (openSUSE, etc.): rpm -Uvh *.rpm

Installationen är nu färdig, och du bör ha ikoner för programmen i LibreOffice under ditt systems Program/Kontor-meny.

Som ett alternativ kan du använda skriptet 'install' för att installera programmet som en användare. Du hittar skriptet den grundmappen. Skriptet skapar en egen profil för LibreOffice som skiljer sig från din vanliga LibreOffice-profil. Observera att detta inte installerar några filer för systemintegration som exempelvis poster på skrivbordsmenyn eller registrering av MIME-typer.

Punkter angående skrivbordsintegration för Linuxdistributioner som inte täcks av installationsinstruktionerna ovan
----------------------------------------------------------------------

Det ska vara möjligt att installera LibreOffice på andra Linuxdistributioner som inte specifikt inkluderats i dessa installationsinstruktioner. Den del där skillnader troligen finns är skrivbordsintegration.

Mappen RPMS (eller DEBS) innehåller också ett paket som heter libreoffice5.4-freedesktop-menus-5.4.0.1-1.noarch.rpm (eller libreoffice5.4-debian-menus_5.4.0.1-1_all.deb, eller liknande). Detta är ett paket för alla Linuxdistributioner som stödjer specifikationerna/rekommendationerna från Freedesktop.org (http://en.wikipedia.org/wiki/Freedesktop.org), och är till för installation på Linuxdistributioner som inte inkluderats i de tidigare nämna instruktionerna.

Installera ett språkpaket
----------------------------------------------------------------------

Ladda ner språkpaketet för ditt önskade språk och ditt system. De finns tillgängliga från samma sida som installationsfilerna för LibreOffice. Från filhanteraren packar du upp det nedladdade arkivet till en mapp (t.ex. ditt skrivbord). Verifiera att du avslutat alla LibreOffice-program (även QuickStarter, om den är igång).

Öppna mappen där du packade upp ditt nedladdade språkpaket.

I den mappen finns en mapp som skapades under uppackningen. Till exempel för det franska språkpaketet för ett 32-bitars Debian/Ubuntu-system heter mappen LibreOffice_, samt versionsinformation och Linux_x86_langpack-deb_fr.

Öppna nu mappen som innehåller paketen som ska installeras. På Debian/Ubuntu-baserade system öppnar du mappen DEBS. På system som kör Fedora, openSUSE eller Mandriva öppnar du mappen RPMS.

Högerklicka i mappen och välj "Öppna i terminal". En terminalruta öppnas. På kommandoraden i terminalrutan skriver du in följande kommando (du kommer att få skriva in det administrativa root-lösenordet innan kommandot körs):

För Debian/Ubuntu-baserade system: sudo dpkg -i *.deb

För Fedora-baserade system: su -c 'yum install *.rpm'

För Mandriva-baserade system: sudo urpmi *.rpm

För andra RPM-baserade system (openSUSE, etc.): rpm -Uvh *.rpm

Öppna ett av programmen i LibreOffice - Till exempel Writer. Öppna verktygs-menyn och välj Alternativ. I alternativrutan klickar du på "Språkinställningar" och sedan på "Språk". Klicka på rullgardinsmenyn "Användargränssnitt" och välj språket du just installerat. Om du vill kan du göra samma sak för "Regionala inställningar", "Standardvaluta" och "Standardspråk för dokument".

Efter att du ändrat inställningarna klickar du på OK. Dialogrutan stängs och en meddelanderuta visas vilken meddelar att ändringarna kommer att aktiveras först när du avslutat LibreOffice och startat det igen (kom ihåg att också avsluta SnabbStart om det är igång).

Nästa gång du startar LibreOffice, kommer det att start med det språk du just installerade.

----------------------------------------------------------------------
Problem vid programstart
----------------------------------------------------------------------

Svårigheter att starta LibreOffice(t.ex. att program låser sig ) och problem med visningen på skärmen orsakas ofta av drivrutinen för grafikkortet. Om du upplever sådana problem uppdaterar du drivrutinen för grafikkortet eller provar att använda den drivrutin som medföljde operativsystemet. Problem med att visa 3D-objekt kan ofta lösas genom att avmarkera alternativet "Använd OpenGL" som finns under Verktyg - Alternativ - LibreOffice - Vy - 3D-vy.

----------------------------------------------------------------------
ALPS-/Synaptics-pekplattor för bärbara datorer i Windows
----------------------------------------------------------------------

På grund av ett drivrutinsproblem i Windows går det inte bläddra genom LibreOffice-dokument genom att dra fingret över en ALPS-/ Synaptics-pekplatta.

För att kunna bläddra med pekplatta måste du lägga till raderna nedan i konfigurationsfilen "C:\Program\Synaptics\SynTP\SynTPEnh.ini" och sedan starta om datorn.

[LibreOffice]

FC = "SALFRAME"

SF = 0x10000000

SF |= 0x00004000

Konfigurationsfilen kan ligga på olika platser beroende på vilken Windows-version du använder.

----------------------------------------------------------------------
Snabbkommandon
----------------------------------------------------------------------

Endast kortkommandon (tangentkombinationer) som inte används av operativsystemet kan användas i LibreOffice. Om en tangentkombination i LibreOffice inte fungerar enligt beskrivningen i LibreOffice-hjälpen så kan du kontrollera om kortkommandot redan används av operativsystemet. Sådana konflikter löser du genom att ändra de tangenter som är tilldelade av operativsystemet. Du kan också ändra de flesta tangenttilldelningar i LibreOffice. Mer information i det här ämnet finns i LibreOffice-hjälpen och i hjälpen för operativsystemet.

----------------------------------------------------------------------
Problem med att skicka dokument som e-post från LibreOffice
----------------------------------------------------------------------

När du skickar ett dokument via Arkiv - Skicka - Dokument som e-post, eller Dokument som PDF-bilaga, kan det uppstå problem (programmet kraschar eller hänger sig). Detta beror på Windows-systemfilen "Mapi" (Messaging Application Programming Interface), som kan orsaka problem i vissa filversioner. Dessvärre går det inte att avgränsa problemet till en viss version. Du kan få mer information om du går in på http://www.microsoft.com och söker på "mapi dll" i Microsoft Knowledge Base.

----------------------------------------------------------------------
Viktig information om tillgänglighet
----------------------------------------------------------------------

För mer information om tillgänglighetsfunktionerna i LibreOffice, besök sidan http://www.libreoffice.org/accessibility/

----------------------------------------------------------------------
Användarstöd
----------------------------------------------------------------------

Den huvudsakliga supportsidan http://www.libreoffice.org/support/ erbjuder olika möjligheter till hjälp med LibreOffice. Din fråga kan redan vara besvarad - kolla på gemenskapsforumet på http://www.documentfoundation.org/nabble/ eller sök i arkiven för e-postlistan users@libreoffice.org på sidan http://www.libreoffice.org/lists/users/. Du kan också skicka in dina frågor till users@libreoffice.org. Om du vill prenumerera på listan (få svar via e-post), skicka ett tomt e-postmeddelande till users+subscribe@libreoffice.org.

Kolla också svaren på vanliga frågor på sidan http://www.libreoffice.org/faq/.

----------------------------------------------------------------------
Rapportera fel och problem
----------------------------------------------------------------------

Vårt system för att rapportera, spåra och lösa fel är för närvarande BugZilla, tillgänglig på https://bugs.libreoffice.org/. Vi vill att våra användare ska känna sig välkomna att rapportera fel som kan uppstå på deras specifika plattform. Energiska felrapporter är ett av de viktigaste bidragen våra användare kan ge till det pågående utvecklandet och förbättrandet av LibreOffice.

----------------------------------------------------------------------
Engagera dig
----------------------------------------------------------------------

Nätverket LibreOffice skulle dra stor nytta av din aktiva medverkan i utvecklingen av detta viktiga projekt för programvara med öppen källkod.

Som användare är du redan en värdefull del av svitens utvecklingsprocess och vi vill uppmuntra dig att ta en än mer aktiv roll med målet att bli en långsiktig deltagare i gemenskapen. Bli medlem och kolla på sidan http://www.libreoffice.org/contribution/ hur du kan medverka.

Så här börjar du
----------------------------------------------------------------------

Det bästa sättet att börja medverka är att prenumerera på en eller flera av e-postlistorna, läsa under en tid och läsa i arkiven för att bekanta sig med många av de ämnen som behandlats sedan källkoden för LibreOffice släpptes i oktober 2000. När du känner dig bekväm behöver du bara skicka ett e-postmeddelande och introducera dig själv och börja direkt. Om du är bekant med projekt med öppen källkod kan du studera vår att göra lista och se ifall det är något du vill hjälpa till med http://www.libreoffice.org/develop/.

Prenumerera
----------------------------------------------------------------------

Här är några av de e-postlistor du kan prenumerera på http://www.libreoffice.org/contribution/

* Nyheter: announce@documentfoundation.org *rekommenderas till alla användare* (få utskick)
* Internationell användarlista: users@global.libreoffice.org *enkelt att följa diskussioner* (många mejl)
* Marknadsföringsprojekt: marketing@global.libreoffice.org *utöver utveckling* (börjar bli populär)
* Allmän utvecklarlista: libreoffice@lists.freedesktop.org (många utskick)

Gå med i ett eller flera projekt
----------------------------------------------------------------------

Du kan lämna viktiga bidrag till det här betydelsefulla projektet för programvara med öppen källkod även om du har begränsad erfarenhet av programvaruutveckling och programmering.

Vi hoppas att du kommer att uppskatta det nya LibreOffice 5.4 och delta online.

LibreOffice-gemenskapen

----------------------------------------------------------------------
Använd/ändrad källkod
----------------------------------------------------------------------

Delar med upphovsrätt 1998, 1999 James Clark. Delar med upphovsrätt 1996, 1998 Netscape Communications Corporation.
