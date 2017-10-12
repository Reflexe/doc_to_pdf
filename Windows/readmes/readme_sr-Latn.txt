
======================================================================
Pročitaj o LibreOffice 5.4
======================================================================


For the latest updates to this readme file, see http://www.libreoffice.org/welcome/readme.html

Ova datoteka sadrži važne informacije o programu LibreOffice. Preporučeno je da pročitate ove informacije vrlo pažljivo pre nego što započnete instalaciju.

LibreOffice zajednica, koja stoji iza razvoja ovog proizvoda, poziva vas da postanete njen član. Novom korisniku biće od koristi stranice na vebu o programu LibreOffice na adresi http://www.libreoffice.org/. Zajednicu na srpskom jeziku potražite na http://sr.libreoffice.org.

Da li je LibreOffice zaista besplatan za sve korisnike? 
----------------------------------------------------------------------

LibreOffice is free for use by everybody. You may take this copy of LibreOffice and install it on as many computers as you like, and use it for any purpose you like (including commercial, government, public administration and educational use). For further details see the license text packaged with this LibreOffice download.

Kako je LibreOffice slobodan za sve korisnike?
----------------------------------------------------------------------

You can use this copy of LibreOffice free of charge because individual contributors and corporate sponsors have designed, developed, tested, translated, documented, supported, marketed, and helped in many other ways to make LibreOffice what it is today - the world's leading Open Source productivity software for home and office.

If you appreciate their efforts, and would like to ensure that LibreOffice continues to be available far into the future, please consider contributing to the project - see http://www.documentfoundation.org/contribution/ for details. Everyone can make a contribution of some kind.

----------------------------------------------------------------------
Napomene o instalaciji
----------------------------------------------------------------------

LibreOffice requires a recent version of Java Runtime Environment (JRE) for full functionality. JRE is not part of the LibreOffice installation package, it should be installed separately.

Sistemski zahtevi
----------------------------------------------------------------------

* Microsoft Windows XP SP2, Vista, Windows 7, or Windows 8

Please be aware that administrator rights are needed for the installation process.

Postavljanje paketa LibreOffice kao podrazumevanog programa za Microsoft Office formate može biti nametnuto ili onemogućeno koristeći sledeće argumente linije naredbi u pozivu instalatera:

* REGISTER_ALL_MSO_TYPES=1 will force registration of LibreOffice as default application for Microsoft Office formats.
* REGISTER_NO_MSO_TYPES=1 will suppress registration of LibreOffice as default application for Microsoft Office formats.

Please make sure you have enough free memory in the temporary directory on your system, and please ensure that read, write and run access rights have been granted. Close all other programs before starting the installation process.

Installation of LibreOffice on Debian/Ubuntu-based Linux systems
----------------------------------------------------------------------

For instructions on how to install a language pack (after having installed the US English version of LibreOffice), please read the section below entitled Installing a Language Pack.

When you unpack the downloaded archive, you will see that the contents have been decompressed into a sub-directory. Open a file manager window, and change directory to the one starting with "LibreOffice_", followed by the version number and some platform information.

This directory contains a subdirectory called "DEBS". Change directory to the "DEBS" directory.

Right-click within the directory and choose "Open in Terminal". A terminal window will open. From the command line of the terminal window, enter the following command (you will be prompted to enter your root user's password before the command will execute):

The following commands will install LibreOffice and the desktop integration packages (you may just copy and paste them into the terminal screen rather than trying to type them):

sudo dpkg -i *.deb

The installation process is now completed, and you should have icons for all the LibreOffice applications in your desktop's Applications/Office menu.

Installation of LibreOffice on Fedora, openSUSE, Mandriva and other Linux systems using RPM packages
----------------------------------------------------------------------

For instructions on how to install a language pack (after having installed the US English version of LibreOffice), please read the section below entitled Installing a Language Pack.

When you unpack the downloaded archive, you will see that the contents have been decompressed into a sub-directory. Open a file manager window, and change directory to the one starting with "LibreOffice_", followed by the version number and some platform information.

This directory contains a subdirectory called "RPMS". Change directory to the "RPMS" directory.

Right-click within the directory and choose "Open in Terminal". A terminal window will open. From the command line of the terminal window, enter the following command (you will be prompted to enter your root user's password before the command will execute):

For Fedora-based systems: su -c 'yum install *.rpm'

For Mandriva-based systems: sudo urpmi *.rpm

For other RPM-based systems (openSUSE, etc.): rpm -Uvh *.rpm

The installation process is now completed, and you should have icons for all the LibreOffice applications in your desktop's Applications/Office menu.

Alternatively, you can use the 'install' script, located in the toplevel directory of this archive to perform an installation as a user. The script will set up LibreOffice to have its own profile for this installation, separated from your normal LibreOffice profile. Note that this will not install the system integration parts such as desktop menu items and desktop MIME type registrations.

Notes Concerning Desktop Integration for Linux Distributions Not Covered in the Above Installation Instructions
----------------------------------------------------------------------

It should be easily possible to install LibreOffice on other Linux distributions not specifically covered in these installation instructions. The main aspect for which differences might be encountered is desktop integration.

The RPMS (or DEBS, respectively) directory also contains a package named libreoffice5.4-freedesktop-menus-5.4.0.1-1.noarch.rpm (or libreoffice5.4-debian-menus_5.4.0.1-1_all.deb, respectively, or similar). This is a package for all Linux distributions that support the Freedesktop.org specifications/recommendations (http://en.wikipedia.org/wiki/Freedesktop.org), and is provided for installation on other Linux distributions not covered in the aforementioned instructions.

Installing a Language Pack
----------------------------------------------------------------------

Download the language pack for your desired language and platform. They are available from the same location as the main installation archive. From the Nautilus file manager, extract the downloaded archive into a directory (your desktop, for instance). Ensure that you have exited all LibreOffice applications (including the QuickStarter, if it is started).

Change directory to the directory in which you extracted your downloaded language pack.

Now change directory to the directory that was created during the extraction process. For instance, for the French language pack for a 32-bit Debian/Ubuntu-based system, the directory is named LibreOffice_, plus some version information, plus Linux_x86_langpack-deb_fr.

Now change directory to the directory that contains the packages to install. On Debian/Ubuntu-based systems, the directory will be DEBS. On Fedora, openSUSE or Mandriva systems, the directory will be RPMS.

From the Nautilus file manager, right-click in the directory and choose the command "Open in terminal". In the terminal window you just opened, execute the command to install the language pack (with all of the commands below, you may be prompted to enter your root user's password):

For Debian/Ubuntu-based systems: sudo dpkg -i *.deb

For Fedora-based systems: su -c 'yum install *.rpm'

For Mandriva-based systems: sudo urpmi *.rpm

For other RPM-using systems (openSUSE, etc.): rpm -Uvh *.rpm

Now start one of the LibreOffice applications - Writer, for instance. Go to the Tools menu and choose Options. In the Options dialog box, click on "Language Settings" and then click on "Languages". Dropdown the "User interface" list and select the language you just installed. If you want, do the same thing for the "Locale setting", the "Default currency", and the "Default languages for documents".

After adjusting those settings, click on OK. The dialog box will close, and you will see an information message telling you that your changes will only be activated after you exit LibreOffice and start it again (remember to also exit the QuickStarter if it is started).

The next time you start LibreOffice, it will start in the language you just installed.

----------------------------------------------------------------------
Problemi pri pokretanju programa
----------------------------------------------------------------------

Nevolje pri pokretanju programa LibreOffice (nedostatak odziva i sl.), kao i problemi sa prikazom na ekranu, često su izazvani greškom u drajveru grafičke kartice. Ako se javljaju slični problemi ažurirajte drajver grafičke kartice ili probajte da koristite drajver koji dolazi uz operativni sistem. Problemi u prikazu 3D objekata mogu biti rešeni isključivanjem podešavanja „Koristi OpenGL“ koje se nalazi u prozorčetu „Alatke - Podešavanja... -  LibreOffice - Prikaz - 3D prikaz“.

----------------------------------------------------------------------
ALPS/Synaptics notebook prstopodloga za Windows
----------------------------------------------------------------------

Zbog poznatog problema sa Windows drajverom, nije moguće kretati se kroz LibreOffice dokumente dok se prst nalazi na ALPS/Synaptics prstopodlozi.

Da biste omogućili prstopodlogu, dodajte sledeće linije u konfiguracionu datoteku C:\Program Files\Synaptics\SynTP\SynTPEnh.ini i ponovo pokrenite računar:

[LibreOffice]

FC = "SALFRAME"

SF = 0x10000000

SF |= 0x00004000

Primedba: Putanja datoteke sa podešavanjima može da se razlikuje pod različitim verzijama Windows sistema.

----------------------------------------------------------------------
Prečice sa tastature
----------------------------------------------------------------------

Samo prečice sa tastature (kombinacije tastera) koje se ne koriste u operativnom sistemu mogu da budu upotrebljene u paketu LibreOffice. Ako kombinacija tastera u LibreOffice ne radi kao što je opisano u pomoći za LibreOffice, proverite da li se prečica se već koristi u operativnom sistemu. Da biste izbegli takve sukobe možete promeniti tastere koji su dodeljeni u vašem operativnom sistemu. Takođe možete promeniti skoro svaku dodelu tastera u LibreOffice. Za više informacija o ovome, pogledajte pomoć za LibreOffice ili operativni sistem.

----------------------------------------------------------------------
Problemi pri slanju dokumenata e-poštom kroz paket LibreOffice
----------------------------------------------------------------------

Kada se dokument šalje preko „Datoteka - Pošalji - Dokument kao e-poštu“ ili „Dokument kao PDF prilog“ mogu se javiti problemi (pad ili zamrzavanje programa). Tome je uzrok Windows sistemska datoteka „Mapi“ (Messaging Application Programming Interface) koja izaziva probleme u nekim verzijama datoteke. Nažalost, problem se ne može suziti na određenu verziju. Za više informacija posetite http://www.microsoft.com i pretražite  Microsoft Knowledge Base za „mapi dll“.

----------------------------------------------------------------------
Važne napomene o pristupačnosti
----------------------------------------------------------------------

Za više informacija o pristupačnosti u paketu LibreOffice, pogledajte http://www.libreoffice.org/accessibility/

----------------------------------------------------------------------
Podrška korisnicima
----------------------------------------------------------------------

The main support page http://www.libreoffice.org/support/ offers various possibilities for help with LibreOffice. Your question may have already been answered - check the Community Forum at http://www.documentfoundation.org/nabble/ or search the archives of the 'users@libreoffice.org' mailing list at http://www.libreoffice.org/lists/users/. Alternatively, you can send in your questions to users@libreoffice.org. If you like to subscribe to the list (to get email responses), send an empty mail to: users+subscribe@libreoffice.org.

Posetite odgovore na često postavljana pitanja na  http://www.libreoffice.org/faq/. (engl.)

----------------------------------------------------------------------
Prijava grešaka i problema
----------------------------------------------------------------------

Our system for reporting, tracking and solving bugs is currently BugZilla, kindly hosted at https://bugs.libreoffice.org/. We encourage all users to feel entitled and welcome to report bugs that may arise on your particular platform. Energetic reporting of bugs is one of the most important contributions that the user community can make to the ongoing development and improvement of LibreOffice.

----------------------------------------------------------------------
Pridruživanje 
----------------------------------------------------------------------

LibreOffice zajednica može mnogo dobiti od vašeg aktivnog učestvovanja u razvoju ovog važnog projekta otvorenog koda.

As a user, you are already a valuable part of the suite's development process and we would like to encourage you to take an even more active role with a view to being a long-term contributor to the community. Please join and check out the contributing page at http://www.libreoffice.org/contribution/

Kako početi
----------------------------------------------------------------------

The best way to start contributing is to subscribe to one or more of the mailing lists, lurk for a while, and gradually use the mail archives to familiarize yourself with many of the topics covered since the LibreOffice source code was released back in October 2000. When you're comfortable, all you need to do is send an email self-introduction and jump right in. If you are familiar with Open Source Projects, check out our To-Dos list and see if there is anything you would like to help with at http://www.libreoffice.org/develop/.

Pretplati se
----------------------------------------------------------------------

Evo nekoliko dopisnih lista na koje možete da se pretplatite preko stranice http://www.libreoffice.org/contribution/

* Vesti i saopštenja: announce@documentfoundation.org *preporuka za sve korisnike* (slab saobraćaj)
* Main user list: users@global.libreoffice.org *easy way to lurk on discussions* (heavy traffic)
* Marketing project: marketing@global.libreoffice.org *beyond development* (getting heavy)
* General developer list: libreoffice@lists.freedesktop.org (heavy traffic)

Pridružite se jednom ili više projekata
----------------------------------------------------------------------

Možete dosta doprineti ovom važnom projektu otvorenog koda čak i ako nemate iskustva u programiranju. Ne verujete?

Nadamo se da ćete uživati u radu sa novim LibreOffice 5.4 i da ćete nam se pridružiti na Internetu.

Libreofis zajednica

----------------------------------------------------------------------
Used / Modified Source Code
----------------------------------------------------------------------

Portions Copyright 1998, 1999 James Clark. Portions Copyright 1996, 1998 Netscape Communications Corporation.
