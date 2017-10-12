
======================================================================
Прочитај о LibreOffice 5.4
======================================================================


For the latest updates to this readme file, see http://www.libreoffice.org/welcome/readme.html

Ова датотека садржи важне информације о програму LibreOffice. Препоручено је да прочитате ове информације врло пажљиво пре него што започнете инсталацију.

LibreOffice заједница, која стоји иза развоја овог производа, позива вас да постанете њен члан. Новом кориснику биће од користи странице на вебу о програму LibreOffice на адреси http://www.libreoffice.org/. Заједницу на српском језику потражите на http://sr.libreoffice.org.

Да ли је LibreOffice заиста бесплатан за све кориснике? 
----------------------------------------------------------------------

LibreOffice is free for use by everybody. You may take this copy of LibreOffice and install it on as many computers as you like, and use it for any purpose you like (including commercial, government, public administration and educational use). For further details see the license text packaged with this LibreOffice download.

Како је LibreOffice слободан за све кориснике?
----------------------------------------------------------------------

You can use this copy of LibreOffice free of charge because individual contributors and corporate sponsors have designed, developed, tested, translated, documented, supported, marketed, and helped in many other ways to make LibreOffice what it is today - the world's leading Open Source productivity software for home and office.

If you appreciate their efforts, and would like to ensure that LibreOffice continues to be available far into the future, please consider contributing to the project - see http://www.documentfoundation.org/contribution/ for details. Everyone can make a contribution of some kind.

----------------------------------------------------------------------
Напомене о инсталацији
----------------------------------------------------------------------

LibreOffice requires a recent version of Java Runtime Environment (JRE) for full functionality. JRE is not part of the LibreOffice installation package, it should be installed separately.

Системски захтеви
----------------------------------------------------------------------

* Microsoft Windows XP SP2, Vista, Windows 7, or Windows 8

Please be aware that administrator rights are needed for the installation process.

Постављање пакета LibreOffice као подразумеваног програма за Microsoft Office формате може бити наметнуто или онемогућено користећи следеће аргументе линије наредби у позиву инсталатера:

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
Проблеми при покретању програма
----------------------------------------------------------------------

Невоље при покретању програма LibreOffice (недостатак одзива и сл.), као и проблеми са приказом на екрану, често су изазвани грешком у драјверу графичке картице. Ако се јављају слични проблеми ажурирајте драјвер графичке картице или пробајте да користите драјвер који долази уз оперативни систем. Проблеми у приказу 3Д објеката могу бити решени искључивањем подешавања „Користи ОпенГЛ“ које се налази у прозорчету „Алатке - Подешавања... -  LibreOffice - Приказ - 3Д приказ“.

----------------------------------------------------------------------
ALPS/Synaptics notebook прстоподлога за Windows
----------------------------------------------------------------------

Због познатог проблема са Windows драјвером, није могуће кретати се кроз LibreOffice документе док се прст налази на ALPS/Synaptics прстоподлози.

Да бисте омогућили прстоподлогу, додајте следеће линије у конфигурациону датотеку C:\Program Files\Synaptics\SynTP\SynTPEnh.ini и поново покрените рачунар:

[LibreOffice]

FC = "SALFRAME"

SF = 0x10000000

SF |= 0x00004000

Примедба: Путања датотеке са подешавањима може да се разликује под различитим верзијама Windows система.

----------------------------------------------------------------------
Пречице са тастатуре
----------------------------------------------------------------------

Само пречице са тастатуре (комбинације тастера) које се не користе у оперативном систему могу да буду употребљене у пакету LibreOffice. Ако комбинација тастера у LibreOffice не ради као што је описано у помоћи за LibreOffice, проверите да ли се пречица се већ користи у оперативном систему. Да бисте избегли такве сукобе можете променити тастере који су додељени у вашем оперативном систему. Такође можете променити скоро сваку доделу тастера у LibreOffice. За више информација о овоме, погледајте помоћ за LibreOffice или оперативни систем.

----------------------------------------------------------------------
Проблеми при слању докумената е-поштом кроз пакет LibreOffice
----------------------------------------------------------------------

Када се документ шаље преко „Датотека - Пошаљи - Документ као е-пошту“ или „Документ као ПДФ прилог“ могу се јавити проблеми (пад или замрзавање програма). Томе је узрок Windows системска датотека „Mapi“ (Messaging Application Programming Interface) која изазива проблеме у неким верзијама датотеке. Нажалост, проблем се не може сузити на одређену верзију. За више информација посетите http://www.microsoft.com и претражите  Microsoft Knowledge Base за „mapi dll“.

----------------------------------------------------------------------
Важне напомене о приступачности
----------------------------------------------------------------------

За више информација о приступачности у пакету LibreOffice, погледајте http://www.libreoffice.org/accessibility/

----------------------------------------------------------------------
Подршка корисницима
----------------------------------------------------------------------

The main support page http://www.libreoffice.org/support/ offers various possibilities for help with LibreOffice. Your question may have already been answered - check the Community Forum at http://www.documentfoundation.org/nabble/ or search the archives of the 'users@libreoffice.org' mailing list at http://www.libreoffice.org/lists/users/. Alternatively, you can send in your questions to users@libreoffice.org. If you like to subscribe to the list (to get email responses), send an empty mail to: users+subscribe@libreoffice.org.

Посетите одговоре на често постављана питања на  http://www.libreoffice.org/faq/. (енгл.)

----------------------------------------------------------------------
Пријава грешака и проблема
----------------------------------------------------------------------

Our system for reporting, tracking and solving bugs is currently BugZilla, kindly hosted at https://bugs.libreoffice.org/. We encourage all users to feel entitled and welcome to report bugs that may arise on your particular platform. Energetic reporting of bugs is one of the most important contributions that the user community can make to the ongoing development and improvement of LibreOffice.

----------------------------------------------------------------------
Придруживање 
----------------------------------------------------------------------

LibreOffice заједница може много добити од вашег активног учествовања у развоју овог важног пројекта отвореног кода.

As a user, you are already a valuable part of the suite's development process and we would like to encourage you to take an even more active role with a view to being a long-term contributor to the community. Please join and check out the contributing page at http://www.libreoffice.org/contribution/

Како почети
----------------------------------------------------------------------

The best way to start contributing is to subscribe to one or more of the mailing lists, lurk for a while, and gradually use the mail archives to familiarize yourself with many of the topics covered since the LibreOffice source code was released back in October 2000. When you're comfortable, all you need to do is send an email self-introduction and jump right in. If you are familiar with Open Source Projects, check out our To-Dos list and see if there is anything you would like to help with at http://www.libreoffice.org/develop/.

Претплати се
----------------------------------------------------------------------

Ево неколико дописних листа на које можете да се претплатите преко странице http://www.libreoffice.org/contribution/

* Вести и саопштења: announce@documentfoundation.org *препорука за све кориснике* (слаб саобраћај)
* Main user list: users@global.libreoffice.org *easy way to lurk on discussions* (heavy traffic)
* Marketing project: marketing@global.libreoffice.org *beyond development* (getting heavy)
* General developer list: libreoffice@lists.freedesktop.org (heavy traffic)

Придружите се једном или више пројеката
----------------------------------------------------------------------

Можете доста допринети овом важном пројекту отвореног кода чак и ако немате искуства у програмирању. Не верујете?

Надамо се да ћете уживати у раду са новим LibreOffice 5.4 и да ћете нам се придружити на Интернету.

Либреофис заједница

----------------------------------------------------------------------
Used / Modified Source Code
----------------------------------------------------------------------

Portions Copyright 1998, 1999 James Clark. Portions Copyright 1996, 1998 Netscape Communications Corporation.
