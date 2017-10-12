
======================================================================
Skedar më lexo LibreOffice 5.4
======================================================================


Për përditësime të fundit të skedarit lexomë, shiko http://www.libreoffice.org/welcome/readme.html

Ky skedar përmban informacion të rëndësishëm rreth programit LibreOffice. Ju rekomandojmë që ta lexoni me shumë kujdes këtë informacion përpara se të filloni instalimin.

Komuniteti i LibreOffice është përgjegjës për zhvillimin e këtij produkti, dhe ju fton ju që të konsideroheni si një pjesëtar i komunitetit. Nëse jeni një përdorues i ri, ju mund të vizitoni faqen LibreOffice, ku do të gjeni shumë informacione rreth projekteve LibreOffice dhe komunitetit që ekziston rreth tij. Shkoni te http://www.libreoffice.org/.

A është vertet LibreOffice falas për çdo përdorues?
----------------------------------------------------------------------

LibreOffice është për përdorim falas nga të gjithë. Ju mund ta merrni kopjen e LibreOffice dhe ta instaloni në sa kompjutera të dëshironi, dhe ta përdorni për çfarëdo qëllimi që të dëshironi (duke përfshirë përdorim komercial, qeveritar, administratë publike dhe edukativ). Për më shumë detaje shikoni paketën e liçensave tekst me shkarkimin LibreOffice.

Pse është LibreOffice falas për çdo pëdrorues?
----------------------------------------------------------------------

Mund të përdorësh këtë kopje të LibreOffice pa paguar gjë sepse kontribuues individual dhe korporata sponsor kanë projektuar, zhvilluar, provuar, përkthyer, dokumentuar, mbështetur, reklamuar, dhe ndihmuar në shumë mënyra të tjera për të bërë LibreOffice atë çka është sot: programi i produktivitetit për shtëpi dhe zyrë me burim të hapur i pari në botë.

Nëse vlerëson sforcimet e tyre, dhe dëshiron të sigurohesh që LibreOffice do të vazhdojë të jetë e disponueshëm edhe në të ardhmen, konsidero të kontribuosh në projektin: shiko  http://www.documentfoundation.org/contribution/ për hollësira. Çdokush mund të kontribuojë në ndonjë mënyrë.

----------------------------------------------------------------------
Vërejtje mbi instalimin
----------------------------------------------------------------------

LibreOffice requires a recent version of Java Runtime Environment (JRE) for full functionality. JRE is not part of the LibreOffice installation package, it should be installed separately.

Sistem tingulli
----------------------------------------------------------------------

* Microsoft Windows XP SP3, Vista, 7, 8, or 10

Për instalimin nevojiten të drejtat e administratorit.

Regjistrimi i LibreOffice si programi i parazgjedhur për formatet Microsoft Office mund të detyrohet ose të përjashtohet duke përdorur parametrat për komandë të mëtejshme për instalimin:

* REGISTER_ALL_MSO_TYPES=1 do të detyrojë regjistrimin e LibreOffice si program i parazgjedhur për formatet Microsoft Office.
* REGISTER_NO_MSO_TYPES=1 do të çaktivizojë regjistrimin e LibreOffice si program i parazgjedhur për formatet Microsoft Office.

Sigurohu të kesh memorie të lirë të mjaftueshme në dosjen e përkohshme në sistem tënd, dhe sigurohu të kesh të drejtat për të lexuar, për të shkruar dhe për të ekzekutuar. Mbyll të gjithë programet tjera para se të fillosh instalimin.

Instalimi i LibreOffice mbi sistemet Linux të bazuara mbi Debian/Ubuntu
----------------------------------------------------------------------

Për udhëzime mbi instalimin e një pakete gjuhe (pas instalimit të versionit anglisht US të LibreOffice), lexo pjesën e mëposhtme të titulluar Instalimi i një pakete gjuhe.

Kur të shpaketosh arkivin e shkarkuar, do vësh re që përmbajtja do jetë shpaketuar në një nëndosje. Hap menaxherin e skedarëve që përdor, dhe shko tek dosja që fillon me "LibreOffice_", i ndjekur nga numri i versionit dhe nga informacioni mbi platformën.

Dosja përmban një nëndosje të quajtur "DEBS". Shko tek dosja "DEBS".

Right-click within the directory and choose "Open in Terminal". A terminal window will open. From the command line of the terminal window, enter the following command (you will be prompted to enter your root user's password before the command will execute):

Komandat e mëtejshme do të instalojnë LibreOffice dhe paketat për integrimin me hapësirën e punës (mundesh edhe thjesht t'i kopjosh e pastaj t'i ngjitësh në dritaren e terminalit në vend se t'i shkruani ato):

sudo dpkg -i *.deb

Procesi i instalimit tashmë u plotësua, dhe duhet të kesh ikonat për të gjitha programet e LibreOffice në menynë Programet/Zura të hapësirës së punës tende.

Instalimi i LibreOffice mbi Fedora, openSUSE, Mandriva dhe sisteme të tjera Linux që përdorin paketa RPM
----------------------------------------------------------------------

Për udhëzime për instalimin e një pakete gjuhe (pas instalimit të versionit anglisht US të LibreOffice), lexo pjesën e mëposhtme të titulluar Instalimi i një pakete gjuhe.

Kur të shpaketosh arkivin e shkarkuar, do vësh re që përmbajtja do jetë shpaketuar në një nëndosje. Hap menaxherin e skedarëve që përdor, dhe shko tek dosja që fillon me "LibreOffice_", i ndjekur nga numri i versionit dhe nga informacioni mbi platformën.

Dosja përmban një nëndosje të quajtur "RPMS". Shko tek dosja "RPMS".

Right-click within the directory and choose "Open in Terminal". A terminal window will open. From the command line of the terminal window, enter the following command (you will be prompted to enter your root user's password before the command will execute):

Për sistemet e bazuara mbi Fedora: su -c 'yum install *.rpm'

Për sistemet e bazuara mbi Mandriva: sudo urpmi *.rpm

Për sistemet tjera të bazuara mbi RPM (openSUSE, etj.): rpm -Uvh *.rpm

Procesi i instalimit tashmë u plotësua, dhe duhet të kesh ikonat për të gjitha programet e LibreOffice në menynë Programet/Zura të hapësirës së punës tende.

Alternatively, you can use the 'install' script, located in the toplevel directory of this archive to perform an installation as a user. The script will set up LibreOffice to have its own profile for this installation, separated from your normal LibreOffice profile. Note that this will not install the system integration parts such as desktop menu items and desktop MIME type registrations.

Shënime rreth integrimit të fushës së punës për distribucionet Linux jo të trajtuara në udhëzimet e mëparshme për instalimin
----------------------------------------------------------------------

Duhet të jetë e mundur të instalohet LibreOffice mbi distribucione Linux të tjera jo posaçërisht të specifikuara në këta udhëzime për instalimin. Ndryshimet kryesore që mund të hasen janë në integrimin me hapësirën e punës.

Dosja RPMS (ose DEBS përkatësisht) përmban edhe një paketë të quajtur libreoffice5.4-freedesktop-menus-5.4.0.1-1.noarch.rpm (ose libreoffice5.4-debian-menus_5.4.0.1-1_all.deb, përkatësisht, ose e ngjashme). Kjo është një paketë për të gjitha distribucionet Linux që mbështesin specifikat/rekomandimet e Freedesktop.org (http://en.wikipedia.org/wiki/Freedesktop.org), dhe është furnizuar për instalim mbi distribucionet Linux jo të mbuluara nga udhëzimet e lartpërmendura.

Instalimi i një pakete gjuhe
----------------------------------------------------------------------

Shkarko paketën për gjuhën dhe platformën e dëshiruar. Ato kanë të njëjtën vendndodhje me arkivin e instalimit kryesor. Nga menaxheri i skedarëve Nautilus, nxirr arkivat e shkarkuar në një dosje (në hapësirën e punës tënde, për shembull). Sigurohu të kesh mbyllur të gjitha programet e LibreOffice (përfshirë QuickStarter, nëse është i nisur).

Zhvendosu në dosjen në të cilën ke nxjerr paketën e gjuhës së shkarkuar.

Tani zhvendosu në dosjen e krijuar gjatë procesit të nxjerrjes. Për shembull, për paketën e gjuhës Franceze për një sistem të bazuar mbi Debian/Ubuntu 32-bit, dosja është emërtuar LibreOffice_, plus disa informacione mbi versionin, plus Linux_x86_langpack-deb_fr.

Tani zhvendosu në dosjen që përmban paketat e instalimit. Në sistemet e bazuara mbi Debian/Ubuntu, dosja do jetë DEBS. Në sistemet Fedora, openSUSE ose Mandriva, dosja do jetë RPMS.

Nga menaxheri i skedarëve Nautilus, bëj klik të djathtë në dosjen dhe zgjidh komandën "Hap në terminal". Në dritaren e terminalit që sapo hape, ekzekuto komandën për të instaluar paketën e gjuhës (mund të të kërkohet fjalëkalimi i administratorit për të gjitha komandat e mëposhtme):

Për sistemet e bazuara mbi Debian/Ubuntu: sudo dpkg -i *.deb

Për sistemet e bazuara mbi Fedora: su -c 'yum install *.rpm'

Për sistemet e bazuara mbi Mandriva: sudo urpmi *.rpm

Për sistemet tjera që përdorin RPM (openSUSE, etj.): rpm -Uvh *.rpm

Tani nis një nga programet e LibreOffice - Writer, për shembull. Shko tek menyja Mjetet dhe zgjidh Mundësitë. Në dritaren e dialogut të Mundësive, kliko mbi "Rregullimet e gjuhës" dhe pastaj kliko mbi "Gjuhët". Kliko mbi listën "Ndërfaqja e përdoruesit" dhe zgjidh gjuhën që sapo instalove. Nëse dëshiron, bëj të njëjtën gjë për "Rregullimet e lokalizimit", "Valuta e parazgjedhur", dhe "Gjuhët e parazgjedhura për dokumentet".

Pasi të kesh përshtatur këta rregullime, shtyp OK. Dialogu do të mbyllet, dhe do të shohësh një masazh informativ me ndryshimet që do të zbatohen vetëm pasi të mbyllësh dhe ta rinisësh përsëri LibreOffice (kujtohu gjithashtu të mbyllësh edhe QuickStarter nëse është i nisur).

Herën tjetër që do nisësh LibreOffice, do të niset në gjuhën e sapo instaluar.

----------------------------------------------------------------------
Probleme gjatë nisjes së programit
----------------------------------------------------------------------

Difficulties starting LibreOffice (e.g. applications hang) as well as problems with the screen display are often caused by the graphics card driver. If these problems occur, please update your graphics card driver or try using the graphics driver delivered with your operating system. Difficulties displaying 3D objects can often be solved by deactivating the option "Use OpenGL" under 'Tools - Options - LibreOffice - View - 3D view'.

----------------------------------------------------------------------
ALPS/Synaptics notebook touchpads in Windows
----------------------------------------------------------------------

Due to a Windows driver issue, you cannot scroll through LibreOffice documents when you slide your finger across an ALPS/Synaptics touchpad.

To enable touchpad scrolling, add the following lines to the "C:\Program Files\Synaptics\SynTP\SynTPEnh.ini" configuration file, and restart your computer:

[LibreOffice]

FC = "SALFRAME"

SF = 0x10000000

SF |= 0x00004000

Vendndodhje e skedarit të konfigurimit mund të ndryshojë mbi versione të ndryshme të Windows-it.

----------------------------------------------------------------------
Tastet përshpejtuese
----------------------------------------------------------------------

Only shortcut keys (key combinations) not used by the operating system can be used in LibreOffice. If a key combination in LibreOffice does not work as described in the LibreOffice Help, check if that shortcut is already used by the operating system. To rectify such conflicts, you can change the keys assigned by your operating system. Alternatively, you can change almost any key assignment in LibreOffice. For more information on this topic, refer to the LibreOffice Help or the Help documentation of your operating system.

----------------------------------------------------------------------
Probleme gjatë dërgimit të dokumenteve si e-mail nga LibreOffice
----------------------------------------------------------------------

When sending a document via 'File - Send - Document as E-mail' or 'Document as PDF Attachment' problems might occur (program crashes or hangs). This is due to the Windows system file "Mapi" (Messaging Application Programming Interface) which causes problems in some file versions. Unfortunately, the problem cannot be narrowed down to a certain version number. For more information visit http://www.microsoft.com to search the Microsoft Knowledge Base for "mapi dll".

----------------------------------------------------------------------
Informata të shënimeve të dokumentit
----------------------------------------------------------------------

For more information on the accessibility features in LibreOffice, see http://www.libreoffice.org/accessibility/

----------------------------------------------------------------------
User Support
----------------------------------------------------------------------

Faqja kryesore për mbështetjen http://www.libreoffice.org/support/ ofron shumë mënyra për ndihmë me LibreOffice. Pyetet tuaja mund të jenë tashmë të përgjigjura: kontrollo forumin e komunitetit në http://www.documentfoundation.org/nabble/ ose kërko në arkivat e listave të email-eve 'users@libreoffice.org' në http://www.libreoffice.org/lists/users/. Ose, mund të dërgosh pyetjet tuaja në users@libreoffice.org. Nëse dëshiron të nën-shkruhesh (për të marrë përgjigjet e email-eve), dërgo një email bosh në: users+subscribe@libreoffice.org.

Gjithashtu kontrollo seksionin FAQ në http://www.libreoffice.org/faq/.

----------------------------------------------------------------------
Reporting Bugs & Issues
----------------------------------------------------------------------

Our system for reporting, tracking and solving bugs is currently BugZilla, kindly hosted at https://bugs.libreoffice.org/. We encourage all users to feel entitled and welcome to report bugs that may arise on your particular platform. Energetic reporting of bugs is one of the most important contributions that the user community can make to the ongoing development and improvement of LibreOffice.

----------------------------------------------------------------------
Si të bashkëpunosh
----------------------------------------------------------------------

Komuniteti i LibreOffice do mund të përfitojë shumë nga pjesëmarrja jote aktive në zhvillimin e këtij projekti të rëndësishëm me burim të hapur.

Duke qenë përdorues, ti je tashmë një pjesëtar i vlefshëm në procesin e prodhimit të suitës dhe ne dëshirojmë të inkurajojmë të marrësh një rrol më aktiv me qëllimin që të bëhesh një kontribuues për një kohë të gjatë për komunitetin. Mund të na kontaktosh dhe të bashkohesh me ne në faqen e kontributit http://www.libreoffice.org/contribution/

Kliko këtu për të filluar
----------------------------------------------------------------------

The best way to start contributing is to subscribe to one or more of the mailing lists, lurk for a while, and gradually use the mail archives to familiarize yourself with many of the topics covered since the LibreOffice source code was released back in October 2000. When you're comfortable, all you need to do is send an email self-introduction and jump right in. If you are familiar with Open Source Projects, check out our To-Dos list and see if there is anything you would like to help with at http://www.libreoffice.org/develop/.

Subscribe
----------------------------------------------------------------------

Here are a few of the mailing lists to which you can subscribe at http://www.libreoffice.org/contribution/

* News: announce@documentfoundation.org *recommended to all users* (light traffic)
* Main user list: users@global.libreoffice.org *easy way to lurk on discussions* (heavy traffic)
* Marketing project: marketing@global.libreoffice.org *beyond development* (getting heavy)
* Lista e përgjithshme për zhvilluesit: libreoffice@lists.freedesktop.org (shumë trafik)

Joining one or more Projects
----------------------------------------------------------------------

You can make major contributions to this important open source project even if you have limited software design or coding experience. Yes, you!

Shpresojmë të të pëlqejë të punosh me versionin e ri të LibreOffice 5.4 dhe shpresojmë që do të bashkohesh me ne në linjë.

Komuniteti i LibreOffice

----------------------------------------------------------------------
Burimi i kodit i përdorur / ndryshuar
----------------------------------------------------------------------

Portions Copyright 1998, 1999 James Clark. Portions Copyright 1996, 1998 Netscape Communications Corporation.
