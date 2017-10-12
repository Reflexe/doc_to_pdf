
======================================================================
LibreOffice 5.4 Citește-mă
======================================================================


Pentru cele mai recente actualizări ale acestui fișier readme, consultați  http://www.libreoffice.org/welcome/readme.html

Acest fișier conține informații importante despre aplicația LibreOffice. Se recomandă să citiți cu atenție aceste informații înainte de a începe instalarea.

Comunitatea LibreOffice este responsabil pentru dezvoltarea acestui produs, și vă invită să participați în calitate de membru al comunității. Dacă sunteți un utilizator nou, puteți vizita site-ul LibreOffice, unde veți găsi și alte informații despre proiectul LibreOffice și comunitățile care au aderat la acesta. Link direct: http://www.libreoffice.org/.

Aplicația LibreOffice este într-adevăr gratuită pentru orice utilizator?
----------------------------------------------------------------------

Utilizarea LibreOffice este gratuită pentru toată lumea. Puteți lua și instala această copie a LibreOffice pe oricâte computere doriți și o puteți utiliza în orice scop doriti (inclusiv comercial, guvern, administrație publică și învățământ). Pentru mai multe detalii, după descărcare vedeți fișierul text care conține licența aplicației LibreOffice.

De ce aplicația LibreOffice este gratuită pentru orice utilizator?
----------------------------------------------------------------------

Puteți folosi gratuit această copie a LibreOffice, deoarece contribuitorii individuali și sponsorii corporativi au proiectat, dezvoltat, testat, tradus, sprijinit, comercializat și au ajutat în multe alte feluri pentru ca aplicația LibreOffice să fie ceea ce este astăzi - lider mondial în software-ul Open Source pentru casă și birou.

În cazul în care apreciați eforturile acestora și doriți să vă asigurați că LibreOffice va continua să fie disponibil și în viitor, vă rugăm să contribuiți la proiect. Pentru detalii vizitați http://www.documentfoundation.org/contribution/. Oricine poate contribui într-un fel.

----------------------------------------------------------------------
Note despre instalare
----------------------------------------------------------------------

LibreOffice necesită o versiune recentă a Mediului de Rulare Java (JRE) pentru a funcționa la capacitate maximă.JRE nu face parte din pachetul de instalare al LibreOffice, el ar trebui instalat separat.

Descărcare
----------------------------------------------------------------------

* Microsoft Windows XP SP3, Vista, 7, 8 sau 10

Pentru instalare aveți nevoie de drepturi de administrator.

Înregistrarea LibreOffice drept aplicație implictp pentru formatele Microsoft Office poate fi forțată sau suprimată folosind următoarele opțiuni în linia de comandă la lansarea asistentului de instalare:

* REGISTER_ALL_MSO_TYPES=1 va seta pentru formatele Microsoft Office ca program implicit, programul LibreOffice.
* REGISTER_NO_MSO_TYPES=1 nu va seta pentru formatele Microsoft Office ca program implicit, programul LibreOffice.

Asigurați-vă că aveți suficient spațiu liber în directorul temporar al sistemului dvs., și că ați citit drepturile de acces. Închideți toate celelalte programe înainte de a începe procesul de instalare.

Instalarea LibreOffice pe sistemele de operarea bazate pe Linux: Debian/Ubuntu
----------------------------------------------------------------------

Pentru instrucțiuni privind instalarea pachetelor de limbă (după ce aveți deja instalată LibreOffice în limba US English), citiți secțiunea de mai jos cu titlul Instalarea pachetelor de limbă.

La despachetarea arhivei descărcate veți observa conținutul decomprimat într-un sub-director. Deschideți o fereastră a managerului de fișiere și intrați în directorul care începe cu „LibreOffice_”, urmat de numărul versiunii și niște informații despre platformă.

Acest director conține un subdirector numit "Debs". Comută la directorul "Debs".

Faceți clic dreapta in director și alegeți opțiunea "Open in Terminal". Se va deschide o fereastră terminal. Din linia de comandă a ferestrei terminal, introduceți următoarea comandă (vi se va cere să introduceți parola dvs. de utilizator root înainte de a se executa comanda):

Comenzile următoare instalează LibreOffice și pachetele de integrare în mediul desktop (copiați și inserați această comandă într-un terminal, în loc să introduceți comanda manual):

sudo dpkg -i *.deb

Procesul de instalare este acum încheiat și ar trebui să aveți iconițe pentru a vizualiza toate aplicațiile LibreOffice în meniul Aplicațiile desktop-ului / Office.

Instalarea LibreOffice pe Fedora, openSUSE, Mandriva și alte sisteme Linux folosind pachete RPM
----------------------------------------------------------------------

Pentru instrucțiuni privind instalarea pachetelor de limbă (după ce aveți deja instalată LibreOffice în limba US English), citiți secțiunea de mai jos cu titlul Instalarea pachetelor de limbă.

La despachetarea arhivei descărcate veți observa conținutul decomprimat într-un sub-director. Deschideți o fereastră a managerului de fișiere și intrați în directorul care începe cu "LibreOffice_", urmat de numărul versiunii și niște informații despre platformă.

Acest director conține un subdirector numit "RPMS". Schimbă la directorul "RPMS".

Faceți clic dreapta in director și alegeți opțiunea "Open in Terminal". Se va deschide o fereastră terminal. Din linia de comandă a ferestrei terminal, introduceți următoarea comandă (vi se va cere să introduceți parola dvs. de utilizator root înainte de a se executa comanda):

Pentru sistemele de operare bazate pe Fedora: su -c 'yum install *.rpm'

Pentru sistemele bazate pe Mandriva:  sudo urpmi *.rpm

Pentru alte sisteme bazate pe RPM (openSUSE, etc.): rpm -Uvh *.rpm

Procesul de instalare este acum încheiat și ar trebui să aveți iconițe pentru a vizualiza toate aplicațiile LibreOffice în meniul Aplicațiile desktop-ului / Office.

Ca alternativă folosiți scriptul „install”, găsit la nivelul superior al arhivei pentru instalare ca utilizator. Scriptul setează în așa fel instalarea lui LibreOffice ca să creeze profil distinct față de instalarea normală. Nu uitați că această instalare nu va instala integrarea în sistemul de operare, ca iconițele desktop, sau nu setează tipurile de fișiere MIME.

Note privind integrarea Desktop pentru distribuții Linux nu sunt cuprinse în instrucțiunile de instalare de mai sus
----------------------------------------------------------------------

Instalarea LibreOffice pe alte distribuții de Linux nespecificate în aceste instrucțiuni de instalare ar trebui să fie simplă. Ar putea să apară diferențe la integrarea desktop.

Directorul RPMS sau DEBS conține un pachet numit libreoffice5.4-freedesktop-menus-5.4.0.1-1.noarch.rpm (sau libreoffice5.4-debian-menus_5.4.0.1-1_all.deb, sau similar). Acest pachet este dedicat distribuțiilor Linux care suportă specificațiile/recomandările ale lui Freedesktop.org (http://en.wikipedia.org/wiki/Freedesktop.org), și este prevăzută pentru instalarea pe alte distribuții de Linux care nu sunt menționate în instrucțiunile de mai sus.

Instalarea unui Pachet Lingvistic
----------------------------------------------------------------------

Descărcați pachetul lingvistic pentru limba și platforma dorită. Acestea sunt disponibile în aceeași locație unde se găsește și arhiva pentru instalarea aplicației. Din managerul de fișiere Nautilus, extrageți arhiva descărcată într-un director (în desktop, de exemplu). Asigurați-vă că ați ieșit din toate aplicațiile LibreOffice (inclusiv Quickstarter, în cazul în care este pornit).

Schimbați directorul la directorul în care ați extras pachetul lingvistic descărcat.

Acum intrați în directorul care a fost creat în timpul procesului de extracție. De exemplu, pentru pachetul de limbă română pentru un sistem 32-bit bazat pe Debian/Ubuntu, directorul se numește LibreOffice_(versiune)_Linux_x86_langpack-deb_ro.

Acum intrați în directorul care conține pachetele pentru instalare. Pe sistemele bazate pe Debian/Ubuntu, directorul se numește DEBS. Pentru sistemele Fedora, openSUSE sau Mandriva, acesta se va numi RPMS.

Din managerul de fișiere Nautilus, faceți clic dreapta în director și alegeți comanda "Open in terminal". În fereastra de terminal pe care tocmai ați deschis-o, executați comanda pentru instalarea pachetul lingvistic (cu toate comenzile de mai jos - e posibil să vi se solicite introducerea parolei dvs. de utilizator root):

Pentru Debian / sisteme de operare bazate pe Ubuntu: sudo dpkg -i *.deb

Pentru sistemele de operare bazate pe Fedora: su -c 'yum install *.rpm'

Pentru sistemele bazate pe Mandriva:  sudo urpmi *.rpm

Pentru celelalte sisteme care utilizează RPM (openSUSE, etc.): rpm -Uvh *.rpm

Acum rulați una dintre aplicatiile LibreOffice - Writer, de exemplu. Din meniul Tools/Instrumente alegeti Options/Opțiuni. În caseta de dialog Opțiuni, faceți clic pe "Language Settings/Setări lingvistice" și apoi faceți clic pe "Limbi". Din lista derulantă "interfață utilizator" selectați limba pe care tocmai ați instalat-o. Dacă doriți, puteți face acelasi lucru pentru "Setări Locale", "Moneda implicită", și "Limbi implicite pentru documente".

După ajustarea acestor setări, faceți clic pe OK. Caseta de dialog se va închide și veți vedea un mesaj de informare care vă anunță că modificările vor fi activate doar după ce închideți LibreOffice și îl porniți din nou (trebuie închis și Quickstarter în cazul în care acesta este pornit).

Data viitoare când LibreOffice va fi pornit, acesta va afișa în limba pe care tocmai ați instalat-o.

----------------------------------------------------------------------
Probleme în timpul pornirii programului
----------------------------------------------------------------------

Deseori, driverul cartelei grafice este cauza unor dificultăți la pornirea LibreOffice (de ex. se agață aplicații) ca și a unor probleme cu afișarea pe ecran. Dacă apar astfel de probleme, actualizați driverul cartelei grafice sau încercați să folosiți driverul ce vine cu sistemul de operare. Probleme la afișarea obiectelor 3D pot fi deseori rezolvate prin dezactivarea opțiunii "Folosește OpenGL" de sub 'Unelte - Opțiuni - LibreOffice - Vizualizare - Vizualizare 3D'.

----------------------------------------------------------------------
Touchpad-uri ALPS/Synaptics notebook în Windows
----------------------------------------------------------------------

Datorită unei probleme cu driverul Windows, nu puteți derula documente LibreOffice alunecînd cu degetul peste un touchpad ALPS/Synaptics.

Pentru a permite derularea touchpad, adaugați următoarele linii "C:\Program Files\Synaptics\SynTP\SynTPEnh.ini" la fișierul de configurare, și reporniți computerul:

[LibreOffice]

FC = "SALFRAME"

SF = 0x10000000

SF |= 0x00004000

Locația fișierului de configurare ar putea varia pe diferite versiuni de Windows.

----------------------------------------------------------------------
Taste rapide
----------------------------------------------------------------------

Doar comenzile rapide (combinațiile de taste) care nu sunt folosite de către sistemul de operare pot fi utilizate în LibreOffice. Dacă o combinație de taste în LibreOffice nu funcționează așa cum este descris în ajutorul LibreOffice, verificați dacă această comandă rapidă este deja utilizată de către sistemul de operare. Pentru a remedia astfel de conflicte, puteți schimba tastele atribuite de sistemul de operare. Alternativ, aveți posibilitatea să modificați aproape orice atribuire a tastei în LibreOffice. Pentru mai multe informații despre acest subiect, consultați ajutorul LibreOffice sau documentația ajutor al sistemului de operare.

----------------------------------------------------------------------
Probleme în trimiterea documentelor ca mesaje electronice din LibreOffice
----------------------------------------------------------------------

Când trimiteți un document prin intermediul 'Fișier - Trimite - Document ca E-mail' sau ' Document în format PDF atașament' s-ar putea să apară probleme (programe crapă sau se blochează). Acest lucru se datorează sistemul de fișiere Windows "Mapi"  (Messaging Application Programming Interface), care cauzează probleme în unele versiuni fișier. Din păcate, problema nu poate fi restrânsă la un anumit număr de versiune. Pentru mai multe informații vizitați  http://www.microsoft.com pentru a căuta în Baza de cunostințe Microsoft pentru  "mapi dll".

----------------------------------------------------------------------
Note importante de acces
----------------------------------------------------------------------

Pentru mai multe informații cu privire la caracteristicile de accesibilitate a LibreOffice, consultați http://www.libreoffice.org/accessibility/

----------------------------------------------------------------------
Asistență utilizator
----------------------------------------------------------------------

Prima pagina de suport http://www.libreoffice.org/support/ oferă posibilități diverse pentru a vă ajuta cu LibreOffice. E posibil ca să aveți deja un răspuns la întrebarea dvs. - verificați Forumul Comunității la http://www.documentfoundation.org/nabble/ sau căutați în arhivele listei de discuții "users@libreoffice.org" la  http://www.libreoffice.org/lists/users/. Alternativ, puteți trimite întrebările dumneavoastră la users@ro.libreoffice.org. Dacă doriți să vă abonați la lista de discuții (pentru a obține răspunsuri de e-mail), trimiteți un e-mail gol la: users+subscribe@ro.libreoffice.org.

De asemenea, verificați secțiunea de întrebări frecvente la http://www.libreoffice.org/faq/.

----------------------------------------------------------------------
Raportarea unor bug-uri și probleme
----------------------------------------------------------------------

Pentru a reporta problemelor legate de LibreOffice puteți folosi BugZilla, care se poate găsi la adresa https://bugs.libreoffice.org/. Vrem să încurajăm toți utilizatorii să raporteze problemele găsite în propriul sistem. Trimiterea problemelor este cea mai mare contribuție, care poate fi făcut de un utilizator pentru a îmbunătăți calitatea produsului LibreOffice.

----------------------------------------------------------------------
Cum vă puteți implica
----------------------------------------------------------------------

Comunitatea LibreOffice ar avea foarte mult de cîștigat din participarea dumneavoastră activă la dezvoltarea acestui important proiect open source.

Ca utilizator, sunteți deja o parte valoroasă a suitei procesului de dezvoltare și am dori să vă încurajăm pentru ca să fiți mai activ, cu scopul de a contribui pe termen lung în comunitate. Vă rugăm să vă alăturați și să verificați pagina cu contribuții la http://www.libreoffice.org/contribution/.

Cum să începeți
----------------------------------------------------------------------

Cel mai bun mod de a începe să contribuiți este de a vă abona la unul sau mai multe liste pe care să le citiți, și, treptat, să folosiți arhivele de mail pentru a vă familiariza cu multe dintre subiectele abordate la codul sursă LibreOffice care a fost lansat din nou în Octombrie 2000. După acomodare, tot ce trebuie să faceți este să trimiteți un e-mail de auto-prezentare. Dacă sunteți familiarizat cu Proiectele Open Source, consultați lista noastră To-Dos pentru a vedea dacă este ceva ce v-ar putea ajuta la http://www.libreoffice.org/develop/.

Subscrie
----------------------------------------------------------------------

Aici sunt câteva din listele de discuții la care puteți să vă abonați: http://www.libreoffice.org/contribution/

* Noutăți: announce@documentfoundation.org *recomandat tuturor utilizatorilor* (trafic ușor)
* Lista de discuții principală (în engleză): users@global.libreoffice.org (trafic intenes)
* Proiect marketing: marketing@global.libreoffice.org
* Lista generală a dezvoltatorilor: libreoffice@lists.freedesktop.org (trafic intens)

Colaborarea la unul sau la mai multe Proiecte
----------------------------------------------------------------------

Puteți aduce contribuții importante la acest proiect open source chiar și dacă aveți experiență limitată în proiectarea software sau în scrierea de cod. Da, dumneavoastră!

Sperăm că vă face plăcere să lucrați cu noul LibreOffice 5.4 și că ni vă veți alătura online.

Comunitatea LibreOffice

----------------------------------------------------------------------
Cod sursă folosit / modificat
----------------------------------------------------------------------

Unele porțiuni Copyright 1998, 1999 James Clark. Unele porțiuni Copyright 1996, 1998 Netscape Communications Corporation.
