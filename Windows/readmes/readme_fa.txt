
======================================================================
LibreOffice 5.4 ReadMe
======================================================================


For the latest updates to this readme file, see http://www.libreoffice.org/welcome/readme.html

این پرونده حاوی اطلاعات مهمی درباره نرم‌افزار LibreOffice است. توصیه می‌شود که قبل از نصب کردن این اطلاعات را با دقت بخوانید.

اجتماع LibreOffice مسؤل تولید این محصول است، و از شما دعوت می‌کند تا به عنوان یک عضو این جامعه، به مشارکت در آن بیاندیشید. اگر شما یک کاربر جدید هستید، می‌توانید سایت LibreOffice را ببینید، آن‌حا اطلاعات زیادی درباره طرح LibreOffice و اجتماعات پیرامون آن خواهید یافت. به این آدرس مراجعه کنید http://www.libreoffice.org/.

آیا LibreOffice واقعاً برای همه کاربران رایگان است؟
----------------------------------------------------------------------

LibreOffice برای استفاده همگان رایگان است. شما می‌توانید یک رو‌نوشت از LibreOffice بردارید و آن را روی هر تعداد رایانه‌ای که دوست دارید نصب کنید، و آن را برای هر هدفی که دوست دارید استفاده کنید (شامل استفاده تجاری، حکومتی، مدیریت همگانی و آموزشی). برای جزئیات بیشتر متن اجازه‌نامه را که همراه بار‌گیری این LibreOffice بسته‌بندی‌ شده است ببینید.

چرا LibreOffice برای همه کاربران رایگان است؟
----------------------------------------------------------------------

شما می‌توانید به‌رایگان از رونوشتی از LibreOffice استفاده کنید؛ زیرا مشارکت‌کنندگان فردی و حامیان مالی متعددی در طراحی، توسعه، آزمایش، مستندسازی و بازاریابی این محصول تلاش کرده و با یاری آن‌ها بهترین بسته نرم‌افزاری تولید محتوای در دنیای نرم‌افزار آزاد، LibreOffice تولید شده است که در خانه و اداره در دسترس شماست.

اگر شما قدر تلاش‌هایشان را بدانید، و مایلید که در دسترس بودن آن LibreOffice را در آینده تضمین کنید، لطفاً مشارکت در طرح را مورد ملاحظه قرار بدهید - صفحه http://www.documentfoundation.org/contribution/ را برای اطلاعات بیشتر ببینید. هر کسی می‌تواند هر چه‌قدر که دوست دارد مشارکت کند.

----------------------------------------------------------------------
Notes on Installation
----------------------------------------------------------------------

LibreOffice requires a recent version of Java Runtime Environment (JRE) for full functionality. JRE is not part of the LibreOffice installation package, it should be installed separately.

System Requirements
----------------------------------------------------------------------

* Microsoft Windows XP SP3, Vista, 7, 8, or 10

Please be aware that administrator rights are needed for the installation process.

Registration of LibreOffice as default application for Microsoft Office formats can be forced or suppressed by using the following command line switches with the installer:

* REGISTER_ALL_MSO_TYPES=1 will force registration of LibreOffice as default application for Microsoft Office formats.
* REGISTER_NO_MSO_TYPES=1 will suppress registration of LibreOffice as default application for Microsoft Office formats.

لطفاً مطمئن شوید که در شاخه موقت رایانه خود به اندازه کافی حافظه‌ی آزاد دارید، و لطفاً مطمئن شوید که دسترسی‌های خواندن، نوشتن و اجرا شدن اعطا شده باشد. قبل از آغاز فرایند نصب تمام برنامه‌های دیگر را ببندید.

Installation of LibreOffice on Debian/Ubuntu-based Linux systems
----------------------------------------------------------------------

For instructions on how to install a language pack (after having installed the US English version of LibreOffice), please read the section below entitled Installing a Language Pack.

When you unpack the downloaded archive, you will see that the contents have been decompressed into a sub-directory. Open a file manager window, and change directory to the one starting with "LibreOffice_", followed by the version number and some platform information.

این شاخه حاوی یک زیر‌شاخه به‌نام "DEBS" است. به شاخه "DEBS" تغییر شاخه بدهید.

داخل شاخه کلیک راست کرده و «باز کردن در پایانه» را برگزینید. پنجره پایانه باز خواهد شد. از خط فرمان پنجره پایانه، دستور زیر را وارد کنید (از شما خواسته خواهد شد که گذر‌واژه کاربر ریشه را قبل از اجرا شدن دستور وارد کنید):

The following commands will install LibreOffice and the desktop integration packages (you may just copy and paste them into the terminal screen rather than trying to type them):

sudo dpkg -i *.deb

The installation process is now completed, and you should have icons for all the LibreOffice applications in your desktop's Applications/Office menu.

Installation of LibreOffice on Fedora, openSUSE, Mandriva and other Linux systems using RPM packages
----------------------------------------------------------------------

For instructions on how to install a language pack (after having installed the US English version of LibreOffice), please read the section below entitled Installing a Language Pack.

When you unpack the downloaded archive, you will see that the contents have been decompressed into a sub-directory. Open a file manager window, and change directory to the one starting with "LibreOffice_", followed by the version number and some platform information.

This directory contains a subdirectory called "RPMS". Change directory to the "RPMS" directory.

Right-click within the directory and choose "Open in Terminal". A terminal window will open. From the command line of the terminal window, enter the following command (you will be prompted to enter your root user's password before the command will execute):

برای سیستم‌های مبتنی بر فدورا: su -c 'yum install *.rpm'

برای سیستم‌های مبتنی بر مندریوا: sudo urpmi *.rpm

برای دیگر سیستم‌هایی که از RPM استفاده می‌کنند (اوپن‌سوسه و غیره): rpm -Uvh *.rpm

The installation process is now completed, and you should have icons for all the LibreOffice applications in your desktop's Applications/Office menu.

Alternatively, you can use the 'install' script, located in the toplevel directory of this archive to perform an installation as a user. The script will set up LibreOffice to have its own profile for this installation, separated from your normal LibreOffice profile. Note that this will not install the system integration parts such as desktop menu items and desktop MIME type registrations.

Notes Concerning Desktop Integration for Linux Distributions Not Covered in the Above Installation Instructions
----------------------------------------------------------------------

It should be easily possible to install LibreOffice on other Linux distributions not specifically covered in these installation instructions. The main aspect for which differences might be encountered is desktop integration.

The RPMS (or DEBS, respectively) directory also contains a package named libreoffice5.4-freedesktop-menus-5.4.0.1-1.noarch.rpm (or libreoffice5.4-debian-menus_5.4.0.1-1_all.deb, respectively, or similar). This is a package for all Linux distributions that support the Freedesktop.org specifications/recommendations (http://en.wikipedia.org/wiki/Freedesktop.org), and is provided for installation on other Linux distributions not covered in the aforementioned instructions.

Installing a Language Pack
----------------------------------------------------------------------

Download the language pack for your desired language and platform. They are available from the same location as the main installation archive. From the Nautilus file manager, extract the downloaded archive into a directory (your desktop, for instance). Ensure that you have exited all LibreOffice applications (including the QuickStarter, if it is started).

به شاخه‌ای که بسته زبان‌تان را در آن استخراج کرده‌اید تغییر شاخه بدهید.

Now change directory to the directory that was created during the extraction process. For instance, for the French language pack for a 32-bit Debian/Ubuntu-based system, the directory is named LibreOffice_, plus some version information, plus Linux_x86_langpack-deb_fr.

Now change directory to the directory that contains the packages to install. On Debian/Ubuntu-based systems, the directory will be DEBS. On Fedora, openSUSE or Mandriva systems, the directory will be RPMS.

از مدیر پرونده ناتیلوس، در شاخه کلیک راست کرده و دستور «باز کردن در پایانه» را برگزینید. در پنجره پایانه‌ای که تنها آن را باز کرده‌اید، دستور را اجرا کنید تا بسته زبان نصب شود (با تمام دستورات زیر، به شما اعلان خواهد شد که گذر‌واژه کاربر ریشه را وارد کنید):

برای سیستم‌های مبتنی بر دبین/اوبونتو: sudo dpkg -i *.deb

برای سیستم‌های مبتنی بر فدورا: su -c 'yum install *.rpm'

برای سیستم‌های مبتنی بر مندریوا: sudo urpmi *.rpm

For other RPM-using systems (openSUSE, etc.): rpm -Uvh *.rpm

Now start one of the LibreOffice applications - Writer, for instance. Go to the Tools menu and choose Options. In the Options dialog box, click on "Language Settings" and then click on "Languages". Dropdown the "User interface" list and select the language you just installed. If you want, do the same thing for the "Locale setting", the "Default currency", and the "Default languages for documents".

After adjusting those settings, click on OK. The dialog box will close, and you will see an information message telling you that your changes will only be activated after you exit LibreOffice and start it again (remember to also exit the QuickStarter if it is started).

بار بعد که LibreOffice را آغاز کنید، در زبانی که نصبش کرده‌اید آغاز خواهد شد.

----------------------------------------------------------------------
Problems During Program Startup
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

The location of the configuration file might vary on different versions of Windows.

----------------------------------------------------------------------
Shortcut Keys
----------------------------------------------------------------------

Only shortcut keys (key combinations) not used by the operating system can be used in LibreOffice. If a key combination in LibreOffice does not work as described in the LibreOffice Help, check if that shortcut is already used by the operating system. To rectify such conflicts, you can change the keys assigned by your operating system. Alternatively, you can change almost any key assignment in LibreOffice. For more information on this topic, refer to the LibreOffice Help or the Help documentation of your operating system.

----------------------------------------------------------------------
Problems When Sending Documents as E-mails From LibreOffice
----------------------------------------------------------------------

When sending a document via 'File - Send - Document as E-mail' or 'Document as PDF Attachment' problems might occur (program crashes or hangs). This is due to the Windows system file "Mapi" (Messaging Application Programming Interface) which causes problems in some file versions. Unfortunately, the problem cannot be narrowed down to a certain version number. For more information visit http://www.microsoft.com to search the Microsoft Knowledge Base for "mapi dll".

----------------------------------------------------------------------
Important Accessibility Notes
----------------------------------------------------------------------

برای اطلاعات بیشتر درباره ویژگی‌های دسترس‌پذیری در LibreOffice، این صفحه را ببینید http://www.libreoffice.org/accessibility/

----------------------------------------------------------------------
User Support
----------------------------------------------------------------------

The main support page http://www.libreoffice.org/support/ offers various possibilities for help with LibreOffice. Your question may have already been answered - check the Community Forum at http://www.documentfoundation.org/nabble/ or search the archives of the 'users@libreoffice.org' mailing list at http://www.libreoffice.org/lists/users/. Alternatively, you can send in your questions to users@libreoffice.org. If you like to subscribe to the list (to get email responses), send an empty mail to: users+subscribe@libreoffice.org.

همچنین قسمت پرسش‌های معمول را بررسی کنید در http://www.libreoffice.org/faq/.

----------------------------------------------------------------------
Reporting Bugs & Issues
----------------------------------------------------------------------

Our system for reporting, tracking and solving bugs is currently BugZilla, kindly hosted at https://bugs.libreoffice.org/. We encourage all users to feel entitled and welcome to report bugs that may arise on your particular platform. Energetic reporting of bugs is one of the most important contributions that the user community can make to the ongoing development and improvement of LibreOffice.

----------------------------------------------------------------------
Getting Involved
----------------------------------------------------------------------

The LibreOffice Community would very much benefit from your active participation in the development of this important open source project.

به‌عنوان یک کاربر، هم‌اکنون شما یک قسمت ارزش‌مند از فرایند تولید مجموعه هستید و مایلیم با نگاهی به مشارکت بلند مدت شما را تشویق کنیم که نقش فعال‌تری را بر‌عهده بگیرید. لطفاً به ما ملحق شوید و صفحه مشارکت را در http://www.libreoffice.org/contribution/ بررسی کنید

How to Start
----------------------------------------------------------------------

The best way to start contributing is to subscribe to one or more of the mailing lists, lurk for a while, and gradually use the mail archives to familiarize yourself with many of the topics covered since the LibreOffice source code was released back in October 2000. When you're comfortable, all you need to do is send an email self-introduction and jump right in. If you are familiar with Open Source Projects, check out our To-Dos list and see if there is anything you would like to help with at http://www.libreoffice.org/develop/.

Subscribe
----------------------------------------------------------------------

Here are a few of the mailing lists to which you can subscribe at http://www.libreoffice.org/contribution/

* News: announce@documentfoundation.org *recommended to all users* (light traffic)
* Main user list: users@global.libreoffice.org *easy way to lurk on discussions* (heavy traffic)
* Marketing project: marketing@global.libreoffice.org *beyond development* (getting heavy)
* General developer list: libreoffice@lists.freedesktop.org (heavy traffic)

ملحق شدن به یک طرح یا بیشتر
----------------------------------------------------------------------

You can make major contributions to this important open source project even if you have limited software design or coding experience. Yes, you!

We hope you enjoy working with the new LibreOffice 5.4 and will join us online.

انجمن لیبره‌آفیس

----------------------------------------------------------------------
Used / Modified Source Code
----------------------------------------------------------------------

Portions Copyright 1998, 1999 James Clark. Portions Copyright 1996, 1998 Netscape Communications Corporation.
