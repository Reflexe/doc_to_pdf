
======================================================================
LibreOffice 5.4 LeesMij
======================================================================


Voor de laatste bijwerkingen van dit readme-bestand, kijk op http://www.libreoffice.org/welcome/readme.html

Dit bestand bevat belangrijke informatie over de LibreOffice software. U wordt aangeraden deze informatie zorgvuldig door te lezen alvorens met de installatie te beginnen.

De LibreOffice-gemeenschap is verantwoordelijk voor de ontwikkeling van dit product en nodigt u uit te overwegen om deel te nemen als lid van deze gemeenschap. Als u een nieuwe gebruiker bent, dan kunt u de site van LibreOffice bezoeken, waar u heel wat informatie over het LibreOffice-project vindt en de gemeenschappen, die er omheen bestaan. Ga naar http://www.libreoffice.org/.

Is LibreOffice echt door iedereen vrij te gebruiken?
----------------------------------------------------------------------

LibreOffice is door iedereen vrij te gebruiken. U mag deze kopie van LibreOffice aannemen en installeren op zoveel computers als u wilt. U mag het gebruiken voor elk doel (met inbegrip van commercieel gebruik alsook door overheid, publiek bestuur en onderwijs). Voor verdere details zie de tekst van de licentie die meegeleverd is met de download van deze LibreOffice.

Waarom is LibreOffice vrij voor elke gebruiker?
----------------------------------------------------------------------

U kunt deze kopie van LibreOffice geheel gratis gebruiken omdat individuen en bedrijven, als sponsors, LibreOffice hebben ontworpen, getest, vertaald, gedocumenteerd, het ondersteunen, in de markt zetten en op vele andere manieren maken tot wat het vandaag is - de in de wereld meest vooraanstaande open source productiviteitssoftware voor thuis- en kantoorgebruik.

Als u hun inspanningen waardeert en zou zeker willen stellen dat LibreOffice beschikbaar blijft tot ver in de toekomst, neem dan eens in overweging aan het project bij te dragen - zie http://www.documentfoundation.org/contribution/ voor details. Iedereen kan op de een of andere manier bijdragen.

----------------------------------------------------------------------
Opmerkingen bij installatie
----------------------------------------------------------------------

LibreOffice vereist een recente versie van Java Runtime Environment (JRE) voor het volledig gebruik van alle functionaliteiten. JRE is geen onderdeel van het LibreOffice installatie package, het moet afzonderlijk worden geïnstalleerd.

Systeemvereisten
----------------------------------------------------------------------

* Microsoft Windows XP SP3, Vista, 7, 8 of 10

Houdt er alstublieft rekening mee dat u rechten als systeembeheerder nodig heeft voor het installatieproces.

Registratie van LibreOffice als standaardtoepassing voor Microsoft Office-formaten kan worden geforceerd of onderdrukt met behulp van de volgende schakelopties voor de opdrachtregel met het installatieprogramma:

* REGISTER_ALL_MSO_TYPES=1 dwingt registratie van LibreOffice af als standaard toepassing voor Microsoft Office formats.
* REGISTER_NO_MSO_TYPES=1 onderdrukt registratie van LibreOffice als standaard toepassing voor Microsoft Office formats.

Verzeker u ervan dat er genoeg vrij geheugen is in de tijdelijke map op uw systeem en dat u er rechten hebt om hierin te lezen, schrijven en uit te voeren. Sluit alle andere programma's alvorens de installatie te starten.

Installatie van LibreOffice op Debian/Ubuntu gebaseerde Linux systemen
----------------------------------------------------------------------

Voor instructies over hoe u een taalpakket kunt installeren (na de VS Engelse versie van LibreOffice te hebben geïnstalleerd), lees dan het onderstaande gedeelte met de titel 'Een taalpakket installeren'.

Wanneer u het gedownloade archief uitpakt, zult u zien dat de inhoud uitgepakt wordt in een sub-directory. Open een bestandsverkenner en wijzig de mapnaam naar "LibreOffice_", gevolgd door het versienummer en wat platform informatie.

Deze map bevat een submap genaamd "DEBS". Wijzig de map naar de map "DEBS".

Klik rechts in de map en kies "Openen in een terminal". Er opent zich dan een terminalvenster. Op de commandoregel van het terminalvenster voert u het volgende commando in (u zult worden gevraagd om het wachtwoord van root in te voeren voordat het commando zal worden uitgevoerd):

De volgende opdrachten zullen LibreOffice en de desktop-integratie-pakketten installeren (u kunt ze gewoon naar het terminal scherm kopiëren in plaats van proberen ze te typen):

sudo dpkg -i *.deb

Het installatieproces is nu gereed en u zou pictogrammen moeten hebben voor alle LibreOffice-toepassingen in het menu Toepassingen/Kantoor van uw bureaublad.

Installatie van LibreOffice op Fedora, openSUSE, Mandriva en andere Linux systemen gebruiken RPM-pakketten
----------------------------------------------------------------------

Voor instructies over hoe u een taalpakket kunt installeren (na de VS Engelse versie van LibreOffice te hebben geïnstalleerd), lees dan het onderstaande gedeelte met de titel 'Een taalpakket installeren'.

Wanneer u de inhoud van het gedownloade archief uitgepakt, zult u zien dat de  inhoud is uitgepakt in een submap staat. Open een bestandsbeheerder en wijzig de mapnaam in "LibO_", gevolgd door het versienummer en enige informatie over het platform.

Deze map bevat een submap genaamd "RPMS". Wijzig de map naar de map "RPMS".

Klik rechts in de map en kies "Openen in een terminal". Er opent zich dan een terminalvenster. Op de commandoregel van het terminalvenster voert u het volgende commando in (u zult worden gevraagd om het wachtwoord van root in te voeren voordat het commando zal worden uitgevoerd):

Voor op Fedora gebaseerde systemen: su -c 'yum install *.rpm'

Voor op Mandriva gebaseerde systemen: sudo urpmi *.rpm

Voor andere op RPM gebaseerde systemen (Suse, etc.): rpm -Uvh *.rpm

Het installatieproces is nu gereed en u zou pictogrammen moeten hebben voor alle LibreOffice-toepassingen in het menu Toepassingen/Kantoor van uw bureaublad.

Als alternatief kunt u het 'installatie'script, in de hoogste map van dit archief gebruiken om een ​​installatie uit te voeren als gebruiker. Het script zal LibreOffice instellen om een eigen profiel voor deze installatie te hebben, gescheiden van uw normale LibreOffice-profiel. Merk op dat dit niet de systeemintegratie onderdelen, zoals desktop menu-items en desktop MIME-type registraties, zal installeren.

Opmerkingen over Bureaubladintegratie voor Linux distributies die gedekt worden door de bovenstaande installatieinstructies
----------------------------------------------------------------------

Het zou gemakkelijk moeten zijn om LibreOffice te installeren op andere Linux distributies die niet specifiek in deze installatieinstructies zijn opgenomen. Het hoofdaspect waarbij u verschillen tegen kunt komen is bureaubladintegratie.

De RPMS (of DEBS, respectively)-map bevat ook een pakket genaamd libreoffice5.4-freedesktop-menus-5.4.0.1-1.noarch.rpm (of libreoffice5.4-debian-menus_5.4.0.1-1_all.deb, respectively of vergelijkbaar). Dit is een pakket voor alle Linux distributies die de Freedesktop.org specificaties/aanbevelingen ondersteunen (http://en.wikipedia.org/wiki/Freedesktop.org) en wordt geleverd voor installatie op andere Linux distributies die niet zijn opgenomen in de hiervoor genoemde instructies.

Een taalpakket installeren
----------------------------------------------------------------------

Download het taalpakket voor de door u gewenste taal en platform. Ze zijn beschikbaar op dezelfde locatie als het hoofdinstallatiearchief. Met de bestandsbeheerder Nautilus pakt u het gedownloade archief uit in een map (bijvoorbeeld uw bureaublad). Kijk of geen toepassingen van LibreOffice meer actief zijn (inclusief de Snelstarter, als deze is gestart).

Wijzig de map naar de map waarin u het gedownloade taalpakket hebt uitgepakt.

Wijzig nu de map naar de map die is aangemaakt bij het uitpakken. Bijvoorbeeld, voor het Franse taalpakket voor een 32-bit Debian/Ubuntu gebaseerd systeem, is de naam van de map LibO_, plus enige versie-informatie, plus Linux_x86_langpack-deb_fr.

Wijzig nu de map naar de map die het installatiepakket bevat. Op Debian/Ubuntu gebaseerde systemen is de map DEBS. Op Fedora, Suse of Mandriva systemen is de map RPMS.

Vanuit de bestandsbeheerder Nautilus klikt u rechts in de map en kiest u het commando "In terminal openen". In het terminalvenster dat zojuist is geopend, voert u het commando uit om het taalpakket te installeren (met alle onderstaande commando's, u kunt worden gevraagd om het wachtwoord van root in te voeren):

Voor Debian/Ubuntu gebaseerde systemen: sudo dpkg -i *.deb

Voor op Fedora gebaseerde systemen: su -c 'yum install *.rpm'

Voor op Mandriva gebaseerde systemen: sudo urpmi *.rpm

Voor andere systemen, die RPM gebruiken (Suse, etc.): rpm -Uvh *.rpm

Start daarna een van de toepassingen van LibreOffice - , bijvoorbeeld Writer. Ga naar het menu Extra en kies Opties. In de dialoog Opties, klik op "Taalinstellingen" en klik daarna op "Talen". Bekijk de afrollijst "Gebruikersinterface" en selecteer de taal die u zojuist hebt geïnstalleerd. Als u dat wilt, doe dan hetzelfde voor de "Instelling van locale", de "Standaard valuta" en de "Standaardtalen voor documenten".

Na het aanpassen van deze instellingen, klik op OK. Het dialoogvenster zal sluiten en u ziet een informatiebericht die u vertelt dat uw wijzigingen alleen geactiveerd zullen worden nadat u LibreOffice beëindigt en opnieuw opgestart hebt (denk er aan om ook de Snelstarter te beëindigen als deze is gestart).

De volgende keer dat u LibreOffice start, zal deze starten in de zojuist door u geïnstalleerde taal.

----------------------------------------------------------------------
Problemen gedurende starten van programma
----------------------------------------------------------------------

Moeilijkheden bij het opstarten van LibreOffice (bijv. toepassingen die blijven hangen) en ook problemen met de weergave op het scherm worden vaak veroorzaakt door het stuurprogramma van de grafische kaart. Als deze problemen voorkomen, werk dan het stuurprogramma van uw grafische kaart bij of probeer het grafische stuurprogramma dat bij uw besturingssysteem werd geleverd te gebruiken. Moeilijkheden met de weergave van 3D-objecten kunnen vaak worden opgelost door de optie "Gebruik OpenGL" onder 'Extra - Opties - LibreOffice - Weergave - 3D-weergave' uit te schakelen.

----------------------------------------------------------------------
ALPS/Synaptics notebook touchpads in Windows
----------------------------------------------------------------------

Ten gevolge van een probleem met een Windows-stuurprogramma kunt u niet door LibreOffice-documenten scrollen als u met uw vinger over een ALPS/Synaptics-touchpad sleept.

Voeg, om scrollen via het touchpad mogelijk te maken, de volgende regels toe aan het configuratiebestand "C:\Program Files\Synaptics\SynTP\SynTPEnh.ini" en herstart uw computer:

[LibreOffice]

FC = "SALFRAME"

SF = 0x10000000

SF |= 0x00004000

De locatie van het configuratiebestand kan verschillen, afhankelijk van verschillende versies van Windows.

----------------------------------------------------------------------
Sneltoetsen
----------------------------------------------------------------------

Alleen sneltoetsen (toetscombinaties) die niet worden gebruikt door het besturingssysteem kunnen worden gebruikt in LibreOffice. Als een toetscombinatie in LibreOffice niet werkt zoals beschreven in de LibreOffice-help, controleer dan of die sneltoets al wordt gebruikt door het besturingssysteem. U kunt de door uw systeem toegewezen toetsen wijzigen om dergelijke conflicten op te lossen. Als alternatief kunt u nagenoeg elke toewijzing van toetsen in LibreOffice wijzigen. Voor meer informatie over dit onderwerp kijkt u in de LibreOffice-help of de Help-documentatie van uw besturingssysteem.

----------------------------------------------------------------------
Problemen bij het verzenden van documenten als emails vanuit LibreOffice
----------------------------------------------------------------------

Bij het versturen van een document via 'Bestand - Verzenden - Document als e-mail' of 'Als PDF e-mailen' kunnen problemen optreden (programma loopt vast of hangt).  Dit is te wijten aan het Windows systeembestand "Mapi" (Messaging Application Programming Interface) dat in sommige bestandsversies problemen veroorzaakt. Helaas kan het probleem niet worden teruggebracht tot een bepaald versienummer. Voor meer informatie bezoekt u http://www.microsoft.com om de Microsoft Knowledge Base te doorzoeken op "mapi dll".

----------------------------------------------------------------------
Belangrijke opmerkingen over toegankelijkheid
----------------------------------------------------------------------

Voor meer informatie over de toegankelijkheidsmogelijkheden in LibreOffice, zie http://www.libreoffice.org/accessibility/

----------------------------------------------------------------------
Gebruikersondersteuning
----------------------------------------------------------------------

De hoofdpagina voor ondersteuning http://www.libreoffice.org/support/ biedt verschillende mogelijkheden voor hulp van LibreOffice. Uw vraag kan al beantwoord zijn - controleer het forum van de gemeenschap op http://www.documentfoundation.org/nabble/ of zoek in de archieven van de e-maillijst 'users@libreoffice.org' op http://www.libreoffice.org/lists/users/. Als alternatief kunt u uw vragen zenden aan users@libreoffice.org. Als u zich op de e-maillijst abonneren (om antwoorden via e-mail te ontvangen) abonneer u dan door een lege e-mail te zenden aan: users+subscribe@libreoffice.org.

Bekijk ook de FAQ-sectie op http://www.libreoffice.org/faq/.

----------------------------------------------------------------------
Bugs & problemen rapporteren 
----------------------------------------------------------------------

Ons systeem voor meldingen, tracking en het oplossen van bugs is momenteel BugZilla, vriendelijk gehost in https://bugs.libreoffice.org/. We verwelkomen alle gebruikers om bugs, die zich kunnen voordoen op specifieke platformen, te melden. Energetische rapportage van bugs is een van de belangrijkste bijdragen die de gebruikersgemeenschap kan leveren aan de verdere ontwikkeling en verbetering van LibreOffice.

----------------------------------------------------------------------
Bijdragen aan
----------------------------------------------------------------------

De LibreOffice Community zou zeer veel profiteren van uw actieve deelname in de ontwikkeling van dit belangrijke open bron-project.

Als gebruiker bent u al een waardevol onderdeel van het ontwikkelproces van het pakket en wij willen u aanmoedigen om een nog actievere rol te spelen met oog op een lange termijn bijdrage aan de gemeenschap. Doe mee en bekijk de pagina over bijdragen op http://www.libreoffice.org/contribution/

Hoe te beginnen
----------------------------------------------------------------------

De beste manier om te beginnen bijdragen is door uzelf in te schrijven op een of meer e-maillijsten, volg deze een tijdje en begin het e-mailarchief te gebruiken om vertrouwd te raken met de vele onderwerpen die, sinds de broncode van LibreOffice is uitgekomen in oktober 2000, zijn behandeld. Wanneer u zich vertrouwd voelt, zendt dan een e-mail waarin u zich voorstelt en begin er eenvoudig mee om te helpen. Als u vertrouwd bent met Opensource Projecten, kijk dan eens op onze Takenlijst en kijk eens of er iets is dat u zou willen doen om mee te helpen op http://www.libreoffice.org/develop/.

Abonneren 
----------------------------------------------------------------------

Hier zijn een paar e-maillijsten waarop u zich kan abonneren http://www.libreoffice.org/contribution/

* Nieuws: announce@documentfoundation.org *aanbevolen aan alle gebruikers* (weinig verkeer)
* Belangrijkste gebruikerslijst: users@global.libreoffice.org *gemakkelijke manier om de discussies te volgen* (veel verkeer)
* Marketing project: marketing@global.libreoffice.org *voorbij de ontwikkelfase* (in het Engels, wordt drukker)
* Algemene lijst voor ontwikkelaars: libreoffice@lists.freedesktop.org (veel verkeer)

Meedoen met één of meer projecten
----------------------------------------------------------------------

U kunt belangrijke bijdragen aan dit belangrijke open bron-project leveren, zelfs als u beperkte of geen ervaring heeft met software-ontwerp of codering. Ja, u!

We hopen dat het werken met de nieuwe LibreOffice 5.4 u bevalt en u zich online bij ons aansluit.

De LibreOffice gemeenschap

----------------------------------------------------------------------
Gebruikte / Aangepaste broncode
----------------------------------------------------------------------

Gedeeltelijk copyright 1998, 1999 James Clark. Gedeeltelijk copyright 1996, 1998 Netscape Communications Corporation.
