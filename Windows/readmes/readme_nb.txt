
======================================================================
LibreOffice 5.4 ReadMe
======================================================================


For de siste oppdateringene av denne fila, se http://www.libreoffice.org/welcome/readme.html

Denne fila inneholder viktig informasjon om LibreOffice. Det anbefales at man leser denne informasjonen nøye før installasjon.

Miljøet rundt LibreOffice er ansvarlig for utviklingen av dette produktet og inviterer deg til å bli en del av samarbeidet som bidragsyter. Hvis du er en ny bruker, kan du besøke nettstedet til LibreOffice. Der vil du finne masse informasjon om prosjektet LibreOffice og miljøet som eksisterer rundt det. Besøk http://www.libreoffice.org/.

Er LibreOffice virkelig gratis for alle?
----------------------------------------------------------------------

LibreOffice er gratis å bruke for alle. Du kan installere dette eksemplaret av LibreOffice på så mange datamaskiner du vil, og bruke det til hva du vil (gjelder også bruk i det offentlige, i næringslivet og innen utdanning). Du kan lese mer om vilkårene i lisensteksten som følger med denne nedlastingen av LibreOffice.

Hvorfor er LibreOffice gratis for alle?
----------------------------------------------------------------------

Denne kopien av LibreOffice kan brukes gratis fordi individuelle bidragsytere og korporative sponsorer har laget, utviklet, testa, oversatt, dokumentert, støtta, markedsført og hjulpet til på mange andre måter for å gjøre LibreOffice til det er i dag – verdens ledende Åpen kildekode-produktivitetgruppevare for hjem og kontor.

Hvis du verdsetter innsatsen deres og vil sørge for at LibreOffice fortsetter å være tilgjengelig langt inn i fremtiden, kan du vurdere å bidra til prosjektet. For nærmere informasjon: http://www.documentfoundation.org/contribution/. Alle kan bidra med noe.

----------------------------------------------------------------------
Merknader om installasjon
----------------------------------------------------------------------

LibreOffice krever en nyere versjon av Java (JRE) for å kunne ta i bruk alle funksjoner. JRE er ikke en del av installasjonspakka for LibreOffice og må derfor installeres separat.

Systemkrav
----------------------------------------------------------------------

* Microsoft Windows XP SP3, Vista, 7, 8, eller 10

Administratorrettigheter kreves for å installere programmet.

Du kan angi at LibreOffice skal brukes som standardprogram når du åpner filer fra Microsoft Office-programmer. Under installasjonen kan du gjøre dette ved å bruke følgende kommandolinjevalg:

* REGISTER_ALL_MSO_TYPES=1 gjør LibreOffice til standardprogrammet for Microsoft Office-formater.
* REGISTER_NO_MSO_TYPES=1 forhindrer LibreOffice i å bli standardprogrammet for Microsoft Office-formater.

Kontroller at det er nok tilgjengelig plass i mappa for midlertidige filer i operativsystemet og at du har lese-, skrive- og kjørerettigheter i denne mappa. Lukk alle andre program før du starter installasjonen.

Installasjon av LibreOffice på Debian/Ubuntu-baserte Linux-systemer
----------------------------------------------------------------------

Les avsnittet med navnet «Installasjon av en språkpakke» nedenfor for å se hvordan du kan installere en lokal språkpakke (etter å ha installert US-engelsk-versjonen av LibreOffice).

Når du pakker ut nedlastinga vil du se at innholdet er fordelt på undermapper. Åpne filbehandleren og bytt til undermappa kalt «LibreOffice_» etterfulgt av versjonsnummeret og informasjon om hvilken plattform installasjonen er laget for.

Denne mappa inneholder en undermappe kalt «DEBS». Bytt til denne mappa.

Høyreklikk i mappa og velg «Åpne i terminal». Et terminalvindu vises. Fra kommandolinja i terminalvinduet, skriv den følgende kommandoen (du vil bli spurt om å oppgi passordet til superbruker/administrator før kjøring av kommandoen):

Denne kommandoen vil installere LibreOffice og skrivebordsintegrasjonen. (Det enkleste er å  kopiere og lime inn kommandoen i vinduet i stedet for å skrive den inn manuelt):

sudo dpkg -i *.deb

Installasjonprosessen er nå fullført, og ikoner for alle programmer i LibreOffice skal være tilgjengelige i skrivebordets program-/kontormeny.

Installasjon av LibreOffice på Fedora, openSUSE, Mandriva og andre Linux-system ved hjelp av RPM-pakker.
----------------------------------------------------------------------

Les avsnittet med navnet «Installasjon av en språkpakke» nedenfor for å se hvordan du kan installere en lokal språkpakke (etter å ha installert US-engelsk-versjonen av LibreOffice).

Når du pakker ut nedlastinga vil du se at innholdet er fordelt på undermapper. Åpne filbehandleren og bytt til undermappa kalt «LibreOffice_» etterfulgt av versjonsnummeret og informasjon om hvilken plattform installasjonen er laget for.

Denne mappa inneholder en undermappe kalt «RPMS». Bytt til denne mappa.

Høyreklikk i mappa og velg «Åpne i terminal». Et terminalvindu vises. Fra kommandolinja i terminalvinduet, skriv den følgende kommandoen (du vil bli spurt om å oppgi passordet til superbruker/administrator før kjøring av kommandoen):

For Fedora-baserte systemer: su -c 'yum install *.rpm'

For Mandriva-baserte systemer: su -c urpmi *.rpm

For andre RPM-baserte system (openSUSE osv.): rpm -Uvh *.rpm

Installasjonprosessen er nå fullført, og ikoner for alle programmer i LibreOffice skal være tilgjengelige i skrivebordets program-/kontormeny.

Alternativt kan du bruke skriptet «install» fra den øverste mappa i dette arkivet for å installere programmet som en bruker. Skriptet vil sette opp en egen profil for denne installasjonen av LibreOffice, adskilt fra den normale LibreOffice-profilen. Vær klar over at dette ikke vil installere komponentene for systemintegrasjon, slik menyoppføringer og MIME-typer.

Merknader for skrivebordintegrasjon i Linux-distribusjoner som ikke ble dekket i installasjonveiledningen over
----------------------------------------------------------------------

Det er forholdsvis enkelt å installere LibreOffice på andre Linux-distribusjoner som ikke dekkes i installasjonveiledningen. Integrasjonen av programvaren på skrivebordet kan variere.

Mappen RPMS (eller eventuelt DEBS) inneholder også en pakke kalt libreoffice5.4-freedesktop-menus-5.4.noarch.rpm(or libreoffice5.4-debian-menus_5.4.0.1-1_all.deb, respectively eller liknande). Dette er en pakke for alle Linux-distribusjoner som støtter spesifikasjonene/anbefalingene til Freedesktop.org (http://en.wikipedia.org/wiki/Freedesktop.org) og er gjort tilgjengelig for installasjon på Linux-distribusjoner som ikke er dekket av de foregående instruksjonene.

Installasjon av en språkpakke
----------------------------------------------------------------------

Last ned språkpakka for det ønskede språket og plattform. De er tilgjengelige fra det samme stedet som standardinstallasjonen. Fra filbehandleren, pakk ut den nedlastede arkivet i en mappe (for eksempel skrivebordet). Sørg for at du har avsluttet alle programmer i LibreOffice (inkludert hurtigstarteren, hvis påslått.)

Bytt til mappa der den nedlastede språkpakka ble pakket ut.

Åpne mappa som ble opprettet under utpakkinga. For eksempel vil mappa med norsk språkpakke for et 32 bit Debian/Ubuntu-basert system ha navnet LibreOffice_ med versjonsnummer og Linux_x86_langpack-deb_nb. 

Bytt til mappa som inneholder pakkene som skal installeres. På Debian/Ubuntu-baserte systemer vil mappa hete DEBS. På Fedora-, openSUSE- og Mandriva-baserte systemer vil mappa heite RPMS.

Fra filebehandleren, høyreklikk i mappa og velg kommandoen «Åpne i terminal». I terminalvinduet, kjør kommandoen for å installere språkpakkene (kommandoene under vil kanskje kreve passordet til superbruker):

For Debian/Ubuntu-baserte systemer: sudo dpkg -i *.deb

For Fedora-baserte systemer: su -c 'yum install *.rpm'

For Mandriva-baserte systemer: su -c urpmi *.rpm

For andre RPM-baserte systemer (openSUSE, osv.): rpm -Uvh *.rpm

Start opp et av programmene i LibreOffice, for eksempel Writer. Gå til menyen «Verktøy» og velg «Innstillinger». I dialogvinduet «Innstillinger», trykk på «Språkinnstillinger» og velg «Språk». Velg lista i rullegardinmenyen «Brukergrensesnittet» og språket som ble installert. Hvis ønskelig, gjør det samme med «Lokale innstillinger», «Standard valuta» og «Standardspråk for dokumenter».

Etter å ha justert innstillingene, trykk på OK. Dialogvinduet vil lukkes og en melding om at innstillingene vil tre i bruk ved neste oppstart av LibreOffice vises. Start programmet på nytt (husk også å lukke hurtigstart.)

Neste gang LibreOffice starter, vil det starte i språket du nettopp installerte.

----------------------------------------------------------------------
Problem ved programoppstart
----------------------------------------------------------------------

Problemer med å starte LibreOffice (f.eks. program som henger), så vel som problemer med skjermvisninga, skyldes ofte problemer med skjermkortet. Hvis disse problemene oppstår, kan du prøve å oppdatere skjermkort-driveren, eller prøv å bruke skjermkort-driveren som ble levert med operativsystemet. Problemer med å vise 3D-objekter kan ofte løses ved å fjerne avkryssinga for «Bruk maskinvareakselerasjon» under «Verktøy → Innstillinger → LibreOffice → Vis → Bildevisning».

----------------------------------------------------------------------
ALPS/Synaptics-styreplater i Windows
----------------------------------------------------------------------

På grunn av en driverfeil kan du ikke rulle i et LibreOffice-dokument når du bruker en styreplate fra ALPS/Synaptics.

For å kunne rulle med en styreplate, legg inn følgende linjer i oppsettfila C:\Program Files\Synaptics\SynTP\SynTPEnh.ini og start datamaskinen på nytt:

[LibreOffice]

FC = "SALFRAME"

SF = 0x10000000

SF |= 0x00004000

Merknad: Plasseringa av oppsettfila kan variere på ulike versjoner av Windows.

----------------------------------------------------------------------
Hurtigtaster
----------------------------------------------------------------------

Bare hurtigtaster (tastekombinasjoner) som ikke blir brukt i operativsystemet kan brukes i LibreOffice. Dersom en tastekombinasjon i LibreOffice ikke virker som det står i hjelpetekstene til LibreOffice, se om hurtigtasten allerede er i bruk av operativsystemet. For å løse slike konflikter kan du endre tastetilordningene i operativsystemet ditt. Du kan også endre nesten alle tastekombinasjonene i LibreOffice. For mer informasjon om dette emnet, se hjelpen i LibreOffice eller dokumentasjonen for operativsystemet ditt.

----------------------------------------------------------------------
Problemer med å sende dokumenter som epost fra LibreOffice
----------------------------------------------------------------------

Når du sender et dokument via «Fil → Send → Dette dokumentet som e-post-vedlegg» eller «Som PDF-fil i e-post», kan du få problemer (programkrasj eller heng). Dette kommer av systemfila «MAPI» (Messaging Application Programming Interface) som gir problemer i noen filutgaver. Dessverre kan ikke problemet begrenses til et bestemt versjonsnummer. For mer informasjon, gå til http://www.microsoft.com for å lete i Microsoft Knowledge Base etter «mapi.dll».

----------------------------------------------------------------------
Viktig informasjon om tilgjengelighet
----------------------------------------------------------------------

For mer informasjon om tilgjengelighetstøtten i LibreOffice, se http://www.libreoffice.org/accessibility/

----------------------------------------------------------------------
Brukerstøtte
----------------------------------------------------------------------

Hovedsiden for brukerstøtte http://www.libreoffice.org/support/, tilbyr en rekke muligheter med tanke på brukerstøtte for LibreOffice. Ditt spørsmål har kanskje allerede blitt besvart - kontroller forumet på http://www.documentfoundation.org/nabble/ eller søk i arkivet til e-postlista «users@libreoffice.org» på http://www.libreoffice.org/lists/users/. Alternativt, kan du sende dine spørsmål til users@libreoffice.org. Hvis du vil abonnere på lista (for å få tilbakemeldinger på e-post), send en tom e-post til: users+subscribe@libreoffice.org.

Les også vår OSS på http://www.libreoffice.org/faq/.

----------------------------------------------------------------------
Rapporter inn feil & problemer
----------------------------------------------------------------------

Vårt system for rapportering, sporing og retting av feil er for tiden Bugzillapå https://bugs.libreoffice.org/. Vi oppfordrer alle brukere som føler seg forpliktet, til å rapportere feil som måtte dukke opp på deres spesifikke plattform. Energisk feilrapportering er et av de mest verdifulle bidragene brukermiljøet kommer med i forhold til den pågående utviklingen og forbedringen av LibreOffice.

----------------------------------------------------------------------
Bli involvert
----------------------------------------------------------------------

LibreOffice-miljøet vil ha stor hjelp av at du deltar aktivt i utviklinga av dette viktige fri programvare-prosjektet.

Som bruker, er du allerede en verdifull del av gruppevarens utviklingsprosess og vi vil oppmuntre deg til å ta en mer aktiv rolle som bidragsyter i miljøet. Bli med og les mer på siden for bidragsytere http://www.libreoffi ce.org/contribution/

Hvordan komme i gang
----------------------------------------------------------------------

Hvis du ønsker å bidra, anbefaler vi å starte med ett abonnement på en eller flere av e-postlistene. Følg med en stund og ta gradvis i bruk e-postarkivene for å gjøre deg kjent med mange av temaene dekket siden kildekoden til LibreOffice ble gjort tilgjengelig i oktober 2000. Når du føler deg klar, trenger du kun å sende en e-post der du introduserer deg selv og hoppe i det. Hvis du allerede er kjent med Åpen kildekode-prosjekter, kan du ta en titt på lista med oppgaver http://www.libreoffice.org/develop/ og se om det er noe du kan hjelpe til med.

Abonner
----------------------------------------------------------------------

Her er noen av epostlistene man kan abonnere på http://www.libreoffice.org/contribution/

* Nyheter: announce@documentfoundation.org *anbefales for alle brukere* (liten trafikk)
* Hovedliste for brukere: users@libreoffice.org *enkelt å følge med på diskusjoner* (mye trafikk)
* Markedsføringprosjekt: marketing@libreoffice.org *utover utvikling* (begynner å bli belastet)
* Generell utviklerliste: libreoffice@lists.freedesktop.org (høy trafikk)

Bli medlem av et eller flere prosjekter
----------------------------------------------------------------------

Du kan gjøre mye for prosjektet selv om du ikke har noe erfaring med programvareutvikling og programmering. Ja, du ja!

Vi håper du har glede av å arbeide med LibreOffice 5.4 og at vi snart møter deg på nettet.

LibreOffice-miljøet

----------------------------------------------------------------------
Brukt/endret kildekode
----------------------------------------------------------------------

Deler med opphavsrett 1998, 1999 tilhørende Jack Clark. Deler med opphavsrett 1996, 1996 Netscape Communications Corporation.
