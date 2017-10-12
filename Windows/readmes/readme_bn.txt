
======================================================================
LibreOffice 5.4 ReadMe
======================================================================


For the latest updates to this readme file, see http://www.libreoffice.org/welcome/readme.html

এ ফাইলে LibreOffice সফ্টওয়্যার সম্পর্কে গুরুত্বপূর্ণ তথ্য রয়েছে। ইনস্টলেশন শুরু করার পূর্বে এ তথ্য মনযোগ দিয়ে পড়ে নেয়ার জন্য আপনাকে সুপারিশ করা হচ্ছে।

এ প্রোডাক্ট এর উন্নয়নের সব দায়দায়িত্ব LibreOffice কমিউনিটির, এবং আপনাকে কমিউনিটির সদস্য হওয়ার জন্য আহ্বান জানায়। আপনি যদি নতুন ব্যবহারকারী হোন তবে LibreOffice সাইটটি দেখুন, যেখানে আপনি LibreOffice প্রকল্প এবং এর চারপাশে বিদ্যমান কমিউনিটির সম্পর্কে অনেক তথ্য পেয়ে যাবেন। http://www.libreoffice.org/ দেখুন।

LibreOffice কি আসলেই যেকোন ব্যবহারকারীর জন্য মুক্ত?
----------------------------------------------------------------------

LibreOffice সবার বিনামূল্যে ব্যবহারের জন্য। আপনি LibreOffice এর একটি অনুলিপি নিয়ে যতসংখ্যাক খুশি ততসংখ্যক কম্পিউটারে ইনস্টল করতে পারেন এবং আপনার পছন্দনানুসারে যেকোনো ক্ষেত্রে (বাণিজ্যিক, সরকারী, লোকপ্রশাসন বা শিক্ষাক্ষেত্রে)ব্যবহার করতে পারেন। আরও বিস্তারিত তথ্যের জন্য LibreOffice ডাউনলোডের সাথে দেয়া লাইসেন্স টেক্সট প্যাকেজ দেখুন।

কেন LibreOffice যেকোন ব্যবহারকারীর জন্য মুক্ত?
----------------------------------------------------------------------

LibreOffice এর অনুলিপি আপনার বিনামূল্যে ব্যবহারের জন্য কারণ প্রত্যেক অবদানকারী এবং কর্পোরেট স্পনসর যারা নকশা,উন্নয়ন, পরীক্ষা, অনুবাদ, নথিবদ্ধকরণ, সমর্থন, প্রচার এরকম আরও অনেক কিছু করেছে জন্যই LibreOffice আজকের এই অবস্থায় এসেছে - ঘর এবং অফিসের জন্য বিশ্বের নেতৃত্বদানকারী ওপেন সোর্স সফ্টওয়্য়ার প্রোডাক্টিভিটি।

আপনি যদি তাদের এই প্রচেষ্টাকে মূল্যায়ন করেন এবং ভবিষ্যতেও যাতে LibreOffice পাওয়া যায় তা নিশ্চিত করেন, তবে অনুগ্রহ করে এ প্রকল্পে অবদান রাখার ব্যাপারে বিবেচনা করুন - বিস্তারিত তথ্যের জন্য http://www.documentfoundation.org/contribution/ দেখুন। প্রত্যেকেই যেকোনো ধরণের অবদান রাখতে পারে।

----------------------------------------------------------------------
ইনস্টলেশনের ব্যাপারে নোট
----------------------------------------------------------------------

LibreOffice requires a recent version of Java Runtime Environment (JRE) for full functionality. JRE is not part of the LibreOffice installation package, it should be installed separately.

সিস্টেমের আবশ্যকীয় বৈশিষ্ট্য
----------------------------------------------------------------------

* Microsoft Windows XP SP3, Vista, 7, 8, or 10

Please be aware that administrator rights are needed for the installation process.

ইনস্টলারের নিম্নবর্ণিত কমান্ড লাইন সুইচগুলো ব্যবহার করে Microsoft Office ফরম্যাটের জন্য ডিফল্ট অ্যাপ্লিকেশন হিসেবে LibreOffice কে রেজিস্ট্রেশন করানো যায় বা বাদ দেয়া যায়।

* REGISTER_ALL_MSO_TYPES=1 will force registration of LibreOffice as default application for Microsoft Office formats.
* REGISTER_NO_MSO_TYPES=1 will suppress registration of LibreOffice as default application for Microsoft Office formats.

আপনার অস্থায়ী ডিরেক্টরি সিস্টেমে যথেষ্ট পরিমান মেমরি খালি আছে কিনা অনুগ্রহ করে তা নিশ্চিত করুন,এবং পড়া, লিখা ও চালানোর জন্য প্রবেশের অধিকার গ্রহণযোগ্য হবে তা নিশ্চিত করুন।  ইন্সটলেশন প্রক্রিয়া শুরু হওয়ার পূর্বেই বাকী সব প্রোগ্রাম বন্ধ করুন।

ডেবিয়ান/উবুন্টু ভিত্তিক লিনাক্স সিস্টেমের জন্য LibreOffice ইনস্টল প্রক্রিয়া
----------------------------------------------------------------------

For instructions on how to install a language pack (after having installed the US English version of LibreOffice), please read the section below entitled Installing a Language Pack.

When you unpack the downloaded archive, you will see that the contents have been decompressed into a sub-directory. Open a file manager window, and change directory to the one starting with "LibreOffice_", followed by the version number and some platform information.

এই ডিরেক্টরিতে সাবডিরেক্টরি আছে যা "DEBS" নামে পরিচিত। ডিরেক্টরি "DEBS" এ পরিবর্তন করুন।

Right-click within the directory and choose "Open in Terminal". A terminal window will open. From the command line of the terminal window, enter the following command (you will be prompted to enter your root user's password before the command will execute):

The following commands will install LibreOffice and the desktop integration packages (you may just copy and paste them into the terminal screen rather than trying to type them):

sudo dpkg -i *.deb

The installation process is now completed, and you should have icons for all the LibreOffice applications in your desktop's Applications/Office menu.

Installation of LibreOffice on Fedora, openSUSE, Mandriva and other Linux systems using RPM packages
----------------------------------------------------------------------

For instructions on how to install a language pack (after having installed the US English version of LibreOffice), please read the section below entitled Installing a Language Pack.

When you unpack the downloaded archive, you will see that the contents have been decompressed into a sub-directory. Open a file manager window, and change directory to the one starting with "LibreOffice_", followed by the version number and some platform information.

এই ডিরেক্টরিতে সাবডিরেক্টরি আছে যা "RPMS" নামে পরিচিত। ডিরেক্টরি "RPMS" এ পরিবর্তন করুন।

Right-click within the directory and choose "Open in Terminal". A terminal window will open. From the command line of the terminal window, enter the following command (you will be prompted to enter your root user's password before the command will execute):

For Fedora-based systems: su -c 'yum install *.rpm'

For Mandriva-based systems: sudo urpmi *.rpm

For other RPM-based systems (openSUSE, etc.): rpm -Uvh *.rpm

The installation process is now completed, and you should have icons for all the LibreOffice applications in your desktop's Applications/Office menu.

Alternatively, you can use the 'install' script, located in the toplevel directory of this archive to perform an installation as a user. The script will set up LibreOffice to have its own profile for this installation, separated from your normal LibreOffice profile. Note that this will not install the system integration parts such as desktop menu items and desktop MIME type registrations.

লিনাক্স ডিস্ট্রিবিউশনের জন্য ডেস্কটপ ইন্টিগ্রেশন উপরোক্ত ইনস্টলেশন অনুসরণ করে না
----------------------------------------------------------------------

LibreOffice কে অন্যান্য লিনাক্স ডিস্ট্রিবিউশনে ইনস্টল করা সহজ হবে। ডেস্কটপ ইন্টিগ্রেশনে এসব পরিবর্তনগুলো প্রয়োগ হবে।

The RPMS (or DEBS, respectively) directory also contains a package named libreoffice5.4-freedesktop-menus-5.4.0.1-1.noarch.rpm (or libreoffice5.4-debian-menus_5.4.0.1-1_all.deb, respectively, or similar). This is a package for all Linux distributions that support the Freedesktop.org specifications/recommendations (http://en.wikipedia.org/wiki/Freedesktop.org), and is provided for installation on other Linux distributions not covered in the aforementioned instructions.

ভাষা প্যাক ইনস্টল করা হচ্ছে
----------------------------------------------------------------------

আপনার পছন্দনীয় ভাষা এবং প্লাটফরমের জন্য ভাষা প্যাকটি ডাউনলোড করুন। এটি মূল ইন্সটলেশন আর্কাইভের একই অবস্থানে বিদ্যমান। নটিলাস ফাইল ব্যবস্থাপক হতে, ডাউনলোডকৃত আর্কাইভকে ডিরেক্টরিতে (উদাহরণস্বরূপ-আপনার ডেস্কটপ) সম্প্রসারণ করুন। আপনি সব LibreOffice এপ্লিকেশন (যদি QuickStarter শুরু হয়, তবে এটি অন্তর্ভুক্ত হবে ) হতে প্রস্থান নিশ্চিত করুন।

ডাউনলোডকৃত ডিরেক্টরিটি যেখানে আনপ্যাক করেছেন সে ডিরেক্টরিতে ডিরেক্টরি পরিবর্তন করুন।

Now change directory to the directory that was created during the extraction process. For instance, for the French language pack for a 32-bit Debian/Ubuntu-based system, the directory is named LibreOffice_, plus some version information, plus Linux_x86_langpack-deb_fr.

Now change directory to the directory that contains the packages to install. On Debian/Ubuntu-based systems, the directory will be DEBS. On Fedora, openSUSE or Mandriva systems, the directory will be RPMS.

নটিলাস ফাইল ব্যবস্থাপক হতে, ডিরেক্টরিতে ডান-ক্লিক করুন এবং "টার্মিনালে খোলা" কমান্ডটি নির্বাচন করুন। এইমাত্র উন্মুক্তকৃত টার্মিনাল উইন্ডোতে, ভাষা প্যাকটি ইনস্টল করতে কমান্ডটি কার্যকর করুন(নিম্নে বর্ণিত সব কমান্ডসহ, আপনাকে মূল ব্যবহারকারী পাসওয়ার্ডটি প্রবেশ করাতে হতে পারে)।

ডেবিয়ান/উবুন্টু ভিত্তিক সিস্টেমের জন্য: sudo dpkg -i *.deb

For Fedora-based systems: su -c 'yum install *.rpm'

For Mandriva-based systems: sudo urpmi *.rpm

For other RPM-using systems (openSUSE, etc.): rpm -Uvh *.rpm

LibreOffice এপ্লিকেশনটি শুরু করা হলো- উদাহরণস্বরূপ- রাইটার। টুলস্ মেনুতে গিয়ে অপশন নির্বাচন করুন। অপশনের সংলাপ বাক্সে, "ভাষা সেটিং" এ ক্লিক করুন তারপর ভাষায় ক্লিক করুন। "ব্যবহারকারী ইন্টারফেস" তালিকাটি ড্রপডাউন করুন এবং আপনার ইনস্টলকৃত ভাষাটি নির্বাচন করুন। "স্থানীয় সেটিং", "পূর্বনির্ধারিত মূদ্রা" এবং "ডকুমেন্টের জন্য পূর্বনির্ধারিত ভাষা" এও একই কাজ করতে পারেন।

এই সেটিংগুলো সমন্বিত করার পর, ঠিক আছে তে ক্লিক করুন। সংলাপ বাক্সটি বন্ধ হয়ে যাবে এবং একটি তথ্য বার্তা দেখতে পাবেন তাতে লিখা থাকবে LibreOffice প্রস্থান করে আবার  শুরু করলে ( মনে রাখবেন, যদি QuickStarter শুরু থাকে তবে তাও প্রস্থান করতে হবে) পরিবর্তনগুলো সক্রিয় হবে।

পরবর্তীতে LibreOffice চালালে, এটি আপনার ইনস্টলকৃত ভাষায় চালু হবে।

----------------------------------------------------------------------
প্রোগ্রাম শুরুর সময় ত্রুটি
----------------------------------------------------------------------

LibreOffice আরম্ভ করতে কিছু ঝামেলা (যেমন: অ্যাপ্লিকেশন আটকে যাওয়া) ছাড়াও গ্রাফিক্স কার্ড ড্রাইভারে পর্দা প্রদর্শনে সমস্যা দেখা দেয়। যদি এই ধরণের সমস্যা হয় তবে অনুগ্রহ করে গ্রাফিক্স কার্ড ড্রাইভারটি হালনাগাদ করে নিন অথবা আপনার অপারেটিং সিস্টেমে যে গ্রাফিক্স ড্রাইভারটি দেয়া আছে সেটিই ব্যবহার করুন। ত্রিমাত্রিক অবজেক্ট দেখতে কোনো ধরণের সমস্যা হলে "Use OpenGL" এর 'টুল - অপশন - LibreOffice - ভিউ - 3D ভিউ' অপশনটি নিস্ক্রিয় করে দিন।

----------------------------------------------------------------------
Windows ALPS/Synaptics নোটবই টাচপ্যাড
----------------------------------------------------------------------

একটি Windows ড্রাইভার বিষয়ের কারনে, ALPS/Synaptics টাচপ্যাডে আঙুল চালানোর সময় আপনি LibreOffice নথির মধ্যে স্ক্রল করতে পারবেন না।

টাচপ্যাড স্ক্রলিং সক্রিয় করতে, কনফিগারেশন ফাইলে নিচের লাইনটি যুক্ত করুন "C:\Program Files\Synaptics\SynTP\SynTPEnh.ini" , এবং কম্পিউটার রিটার্ট করুন:

[LibreOffice]

FC = "SALFRAME"

SF = 0x10000000

SF |= 0x00004000

কনফিগারেশন ফাইলের অবস্থান উইন্ডোজের সংস্করণ ভেদে ভিন্ন হয়।

----------------------------------------------------------------------
শর্টকাট কী
----------------------------------------------------------------------

Only shortcut keys (key combinations) not used by the operating system can be used in LibreOffice. If a key combination in LibreOffice does not work as described in the LibreOffice Help, check if that shortcut is already used by the operating system. To rectify such conflicts, you can change the keys assigned by your operating system. Alternatively, you can change almost any key assignment in LibreOffice. For more information on this topic, refer to the LibreOffice Help or the Help documentation of your operating system.

----------------------------------------------------------------------
LibreOffice থেকে ইমেইল হিসেবে নথি পাঠানোর সময় ত্রুটি
----------------------------------------------------------------------

'ফাইল - প্রেরণ - ইমেইল হিসাবে ডকুমেন্ট' বা 'PDF হিসাবে সংযুক্ত ডকুমেন্ট' হিসাবে ডকুমেন্ট পাঠানোর সময় সমস্যা দেখা দিতে পারে (প্রোগ্রাম ক্রাশ বা আটকে যেতে পারে)। সমস্যাটি উইন্ডোজ সিস্টেম ফাইল "Mapi" (Messaging Application Programming Interface) জন্যই হয়েছে, যা কিনা কিছু সংস্করণে সমস্যা তৈরী করে। দুর্ভাগ্যবশত, কিছু কিছু সংস্করণে এই সমস্যাটি কমানো যায় না। "mapi dll" এর মাইক্রোসফট্ ভিত্তিক জ্ঞানের জন্য http://www.microsoft.com দেখুন। 

----------------------------------------------------------------------
জরুরি অ্যাক্সেসিবিলিটি নোট
----------------------------------------------------------------------

LibreOffice এ প্রবেশাধিকার সম্প্রকে আরও জানতে, http://www.libreoffice.org/accessibility/ দেখুন

----------------------------------------------------------------------
ব্যবহারকারী সহায়তা
----------------------------------------------------------------------

প্রধান সমর্থন পাতা http://www.libreoffice.org/support/ নানা রকম সহায়তা প্রদান করে LibreOffice। আপনি হয়তো ইতিমধ্যে আপনার প্রশ্নের সমাধান পেয়ে থাকবেন- কমিউনিটি ফোরাম পরীক্ষা করুন http://www.documentfoundation.org/nabble/ বা আর্কইভ অনুসন্ধান করুন 'users@libreoffice.org' mailing list at http://www.libreoffice.org/lists/users/. Alternatively, you can send in your questions to users@libreoffice.org. If you like to subscribe to the list (to get email responses), send an empty mail to: users+subscribe@libreoffice.org.

http://www.libreoffice.org/faq/ এর FAQ সেকশনটিও পরীক্ষা করুন।

----------------------------------------------------------------------
বাগ এবং ইস্যু রিপোর্টিং
----------------------------------------------------------------------

Our system for reporting, tracking and solving bugs is currently BugZilla, kindly hosted at https://bugs.libreoffice.org/. We encourage all users to feel entitled and welcome to report bugs that may arise on your particular platform. Energetic reporting of bugs is one of the most important contributions that the user community can make to the ongoing development and improvement of LibreOffice.

----------------------------------------------------------------------
সংযুক্ত হোন
----------------------------------------------------------------------

LibreOffice কমিউনিটি এই জরুরী ওপেন সোর্স প্রোজেক্ট উন্নয়নে আপনার কার্যকর অংশগ্রহনে অত্যন্ত উপকৃত হবে।

ব্যবহারকারী হিসাবে, স্যুটি এর উন্নয়ন প্রক্রিয়ার আপনিও একজন গুরুত্বপূর্ণ অংশ এবং আমরা চাই যে এ কমিউনিটিতে আপনি দীর্ঘকালীন সদস্য হিসাবে আরও বেশি সক্রিয় ভূমিকা রাখবেন, অনুগ্রহ করে http://www.libreoffice.org/contribution/ এ গিয়ে যোগ দিয়ে পরীক্ষা করে দেখুন।

কিভাবে শুরু করতে হবে
----------------------------------------------------------------------

অবদান রাখার সর্বোৎকৃষ্ট উপায় হল এক বা একাধিক মেইলিং তালিকায় সাবস্ক্রাইব করা এবং কিছু সময় নিয়ে ধীরে ধীরে মেইল আর্কাইভের বিভিন্ন বিষয় নিজে বুঝে নেয়া কেননা LibreOffice এর সোর্স কোড গত অক্টোবর ২০০০ এ মুক্তিপ্রাপ্ত। যখন আপনি ভালভাবে ব্যবহার করা জেনে যাবেন তখন আপনাকে যা করতে হবে তা হল নিজের পরিচিতিমূলক একটি মেইল প্রেরণ করতে হবে এবং এভাবে ব্যবহার করে যেতে হবে। আপনি যদি ওপেন সোর্স প্রকল্পের সাথে পূর্বপরিচিত হয়ে থাকেন তবে, কি কি করণীয় এর যে তালিকা আছে তা পরীক্ষা করে দেখে নিতে পারেন যে http://www.libreoffice.org/develop/ এ কোনো তথ্য দিয়ে আপনি কোনোভাবে সাহায্য করতে পারেন কিনা।

সাবস্ক্রাইব
----------------------------------------------------------------------

এখানে কিছু মেইলিং লিস্ট আছে, এখানে আপনি সাবস্ক্রাইব করতে পারেন http://www.libreoffice.org/contribution/

* খবর: announce@documentfoundation.org *recommended to all users* (light traffic)
* Main user list: users@global.libreoffice.org *easy way to lurk on discussions* (heavy traffic)
* Marketing project: marketing@global.libreoffice.org *beyond development* (getting heavy)
* সাধারণ ডেভেলপার তালিকা: libreoffice@তালিকাs.freedesktop.org (heavy traffic)

এক বা একাধিক প্রোজেক্টে অংশগ্রহন করুন
----------------------------------------------------------------------

যদি আপনার খুব কম সফটওয়্যার ডিজাইন বা কোডিং অভিজ্ঞতা থাকে তাহলেও আপনি এই জরুরী মুক্ত সোর্স প্রোজেক্টে বড় অবদান রাখতে পারেন। হ্যাঁ, আপনি!

আশা করি আপনি নতুন LibreOffice 5.4 এর সাথে কাজ করে আনন্দ পাচ্ছেন এবং অনলাইনে আমাদের সাথে যুক্ত হবেন।

লিবার অফিস কমিউনিটি

----------------------------------------------------------------------
Used / Modified Source Code
----------------------------------------------------------------------

Portions Copyright 1998, 1999 James Clark. Portions Copyright 1996, 1998 Netscape Communications Corporation.
