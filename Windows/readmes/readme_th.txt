
======================================================================
LibreOffice 5.4 โปรดอ่าน (ReadMe)
======================================================================


For the latest updates to this readme file, see http://www.libreoffice.org/welcome/readme.html

แฟ้มนี้ประกอบด้วยข้อมูลสำคัญเกี่ยวกับโปรแกรม LibreOffice  กรุณาอ่านข้อมูลนี้อย่างละเอียดก่อนเริ่มติดตั้ง

ชุมชน LibreOffice รับผิดชอบการพัฒนาผลิตภัณฑ์นี้ และขอเชิญให้คุณพิจารณาเข้าร่วมเป็นส่วนหนึ่งของชุมชน ถ้าคุณเป็นผู้ใช้ใหม่ คุณอาจไปดูที่ไซต์ของ LibreOffice ซึ่งมีข้อมูลอันเป็นประโยชน์เกี่ยวกับโครงการ LibreOffice กับชุมชนที่มีอยู่ ไปที่ http://www.libreoffice.org/

LibreOffice ฟรีสำหรับผู้ใช้ใดๆ จริงหรือ?
----------------------------------------------------------------------

ผู้ใช้ทุกคนสามารถใช้ LibreOffice ได้ฟรี คุณสามารถนำเอาสำเนานี้ของ LibreOffice และติดตั้งลงในคอมพิวเตอร์กี่เครื่องก็ได้และใช้ตามวัตถุประสงค์ใดๆ (รวมถึงเพื่อการค้า งานราชการ การบริหารสาธารณะ และการศึกษา) สำหรับรายละเอียดเพิ่มเติมโปรดอ่านข้อความใบอนุญาตที่มาพร้อมกับ LibreOffice

ทำไม LibreOffice จึงฟรีสำหรับผู้ใช้ใดๆ ?
----------------------------------------------------------------------

คุณสามารถใช้สำเนานี้ของ LibreOffice วันนี้ได้ฟรีเพราะคนที่เป็นผู้ให้และหน่วยงานผู้สนับสนุนได้ออกแบบ พัฒนา ทดสอบ แปล ทำเอกสาร ให้สนับสนุน ทำการตลาดและช่วยเหลือในทางอื่นๆ อีกมากมายเพื่อทำให้ LibreOffice เป็นอย่างที่เป็นในวันนี้ คือเป็นผู้นำซอฟต์แวร์สผลิตภาพสำหรับบ้านและสำนักงานแบบโอเพ่นซอร์สของโลก

ถ้าคุณมีความซาบซึ้งในความพยายามของบุคคลเหล่านั้น และต้องการที่จะทำให้ LibreOffice ยังคงมีต่อไปอีกนานในอนาคต โปรดพิจารณาการสละบางอย่างให้แก่โครงการ โปรดดู http://www.documentfoundation.org/contribution/ สำหรับรายละเอียด ทุกคนสามารถมีส่วนในการให้ได้ไม่ทางใดก็ทางหนึ่ง

----------------------------------------------------------------------
คำแนะนำการติดตั้ง
----------------------------------------------------------------------

LibreOffice ต้องใช้ Java Runtime Environment (JRE) เวอร์ชันใหม่ๆ เพื่อให้ทำงานได้อย่างเต็มที่ JRE ไม่ได้เป็นส่วนหนึ่งของแพ็คเกจการติดตั้ง LibreOffice  จึงต้องติดตั้งแยกกัน

ระบบที่ต้องการ
----------------------------------------------------------------------

* Microsoft Windows XP SP3, Vista, 7, 8, or 10

หมายเหตุ : โปรดทราบว่าสิทธิผู้ดูแลระบบจำเป็นสำหรับกระบวนการติดตั้ง

การลงทะเบียนให้ LibreOffice เป็นโปรแกรมโดยปริยายในการเปิดเอกสารรูปแบบของ Microsoft Office สามารถบังคับหรือห้ามได้โดยใช้คอมมานด์ไลน์สวิตช์ (command line switches) ต่อไปนี้กับโปรแกรมติดตั้ง:

* REGISTER_ALL_MSO_TYPES=1 จะบังคับให้ลงทะเบียน LibreOffice เป็นโปรแกรมโดยปริยายในการเปิดเอกสารรูปแบบของ Microsoft Office
* REGISTER_NO_MSO_TYPES=1 จะห้ามการลงทะเบียน LibreOffice เป็นโปรแกรมโดยปริยายในการเปิดเอกสารรูปแบบของ Microsoft Office

Please make sure you have enough free memory in the temporary directory on your system, and please ensure that read, write and run access rights have been granted. Close all other programs before starting the installation process.

Installation of LibreOffice on Debian/Ubuntu-based Linux systems
----------------------------------------------------------------------

For instructions on how to install a language pack (after having installed the US English version of LibreOffice), please read the section below entitled Installing a Language Pack.

When you unpack the downloaded archive, you will see that the contents have been decompressed into a sub-directory. Open a file manager window, and change directory to the one starting with "LibreOffice_", followed by the version number and some platform information.

This directory contains a subdirectory called "DEBS". Change directory to the "DEBS" directory.

คลิกขวาภายในไดเร็คทอรีและเลือก "เปิดในเครื่องปลายทางหรือเทอร์มินัล" หน้าต่างเครื่องปลายทางจะเปิดขึ้น จากบรรทัดคำสั่งของหน้าต่างเครื่องปลายทาง ให้ป้อนคำสั่งต่อไปนี้ (คุณจะถูกบอกให้ป้อนรหัสผ่านของผู้ใช้รูทก่อนที่คำสั่งจะดำเนินการ):

The following commands will install LibreOffice and the desktop integration packages (you may just copy and paste them into the terminal screen rather than trying to type them):

sudo dpkg -i *.deb

The installation process is now completed, and you should have icons for all the LibreOffice applications in your desktop's Applications/Office menu.

Installation of LibreOffice on Fedora, openSUSE, Mandriva and other Linux systems using RPM packages
----------------------------------------------------------------------

For instructions on how to install a language pack (after having installed the US English version of LibreOffice), please read the section below entitled Installing a Language Pack.

When you unpack the downloaded archive, you will see that the contents have been decompressed into a sub-directory. Open a file manager window, and change directory to the one starting with "LibreOffice_", followed by the version number and some platform information.

This directory contains a subdirectory called "RPMS". Change directory to the "RPMS" directory.

คลิกขวาภายในไดเร็คทอรีและเลือก "เปิดในเครื่องปลายทางหรือเทอร์มินัล" หน้าต่างเครื่องปลายทางจะเปิดขึ้น จากบรรทัดคำสั่งของหน้าต่างเครื่องปลายทาง ให้ป้อนคำสั่งต่อไปนี้ (คุณจะถูกบอกให้ป้อนรหัสผ่านของผู้ใช้รูทก่อนที่คำสั่งจะดำเนินการ):

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

หลังจากที่ปรับการตั้งค่าแล้ว คลิกตกลง กล่องโต้ตอบจะปิดลงและคุณจะเห็นข้อความที่บอกว่าการเปลี่ยนแปลงของคุณจะมีผลหลังจากที่ออกจาก LibreOffice และเริ่มต้นใหม่อีกครั้ง (อย่าลืมออกจาก QuickStarter ด้วยถ้ามันทำงานอยู่)

The next time you start LibreOffice, it will start in the language you just installed.

----------------------------------------------------------------------
ปัญหาเกิดขึ้นระหว่างโปรแกรมเริ่มการทำงาน
----------------------------------------------------------------------

ความยุ่งยากในการเริ่ม LibreOffice (เช่น แอพพลิเคชันหยุดการทำงานกระทันหัน) รวมถึงปัญหาการแสดงผลบนหน้าจอบ่อยครั้งมีสาเหตุมาจากกราฟิกส์ไดรเวอร์ ถ้าเกิดปัญหาเหล่านี้ขึ้น, กรุณาปรับปรุงกราฟิกส์ไดรเวอร์หรือลองใช้ไดรเวอร์กราฟิกส์ที่มากับระบบปฏิบัติการ ความยุ่งยากในการแสดงวัตถุ 3 มิตินั้น บ่อยครั้งก็แก้ปัญหาได้โดยปิดการใช้งานตัวเลือก "ใช้ OpenGL" ภายใต้ 'เครื่องมือ - ตัวเลือก - LibreOffice - มุมมอง - มุมมอง 3 มิติ' 

----------------------------------------------------------------------
แผ่นสำผัส ALPS/Synaptics touchpads ที่ใช้กับเครื่องโน้ตบุ๊คในระบบวินโดวส์
----------------------------------------------------------------------

เนื่องจากปัญหาไดรเวอร์ของวินโดวส์ คุณไม่สามารถเลื่อนหน้าจอของเอกสาร LibreOffice เมื่อคุณสไลด์นิ้วผ่านแป้นสัมผัส ALPS/Synaptics

ในการเปิดการทำงานของการเลื่อนหน้าจอด้วยทัชแพด ให้เพิ่มบรรทัดต่อไปนี้เข้าไปยังไฟล์โครงแบบ "C:\Program Files\Synaptics\SynTP\SynTPEnh.ini" และรีสตาร์ทคอมพิวเตอร์ใหม่:

[LibreOffice]

FC = "SALFRAME"

SF = 0x10000000

SF |= 0x00004000

ตำแหน่งของแฟ้มตั้งค่าอาจจะแตกต่างกันตามรุ่นของวินโดวส์

----------------------------------------------------------------------
คีย์ลัด 
----------------------------------------------------------------------

Only shortcut keys (key combinations) not used by the operating system can be used in LibreOffice. If a key combination in LibreOffice does not work as described in the LibreOffice Help, check if that shortcut is already used by the operating system. To rectify such conflicts, you can change the keys assigned by your operating system. Alternatively, you can change almost any key assignment in LibreOffice. For more information on this topic, refer to the LibreOffice Help or the Help documentation of your operating system.

----------------------------------------------------------------------
เกิดปัญหาเมื่อส่งเอกสารเป็นอีเมลจาก LibreOffice
----------------------------------------------------------------------

เมื่อส่งเอกสารผ่านทาง 'แฟ้ม - ส่ง - เอกสารเป็นอีเมล' หรือ 'การแนบเอกสาร PDF' ปัญหาจะเกิดขึ้น (โปรแกรมจะล้มเหลวหรือหยุดทำงานกระทันหัน) ปัญหานี้เกิดขึ้นจากแฟ้มระบบวินโดสว์ "Mapi" (ข้อความแอพพลิเคชันโปรแกรมอินเทอร์เฟซ) ซึ่งเกิดปัญหาเพราะแฟ้มบางเวอร์ชัน โชคไม่ดีที่, ปัญหาไม่สามารถจำกัดให้แคบลงว่าเป็นหมายเลขเวอร์ชันใด สำหรับข้อมูลเพิ่มเติมโปรดเข้าไปที่ http://www.microsoft.com ในการค้นหาข้อมูลความรู้พื้นฐานไมโครซอฟท์สำหรับ "mapi.dll" 

----------------------------------------------------------------------
หมายเหตุสำคัญเกี่ยวกับการเข้าถึง
----------------------------------------------------------------------

สำหรับข้อมูลเพิ่มเติมเกี่ยวกับความสามารถในการเข้าถึงใน LibreOffice โปรดดูที่ http://www.libreoffice.org/accessibility/

----------------------------------------------------------------------
ช่วยเหลือผู้ใช้
----------------------------------------------------------------------

หน้าสนับสนุนหลัก http://www.libreoffice.org/support/ เสนอความเป็นไปได้หลายประการสำหรับความช่วยเหลือกับ LibreOffice คำถามของคุณอาจมีคำตอบอยู่แล้ว ตรวจสอบกับเวทีอภิปรายของชุมชน (Community Forum) ที่ http://www.documentfoundation.org/nabble/ หรือค้นหาในหน่วยเก็บถาวร (archives) ของบัญชีจ่าหน้ากลุ่ม 'users@libreoffice.org' ที่ http://www.libreoffice.org/lists/users/ นอกจากนี้คุณยังสามารถส่งคำถามไปยัง users@libreoffice.org ถ้าคุณต้องการสมัครบอกรับบัญชีจ่าหน้า ให้ส่งอีเมลเปล่าไปยัง: users+subscribe@libreoffice.org

และโปรดตรวจสอบคำถามที่ถามบ่อย (FAQ) ที่ http://www.libreoffice.org/faq/.

----------------------------------------------------------------------
การรายงานบั๊ก & ประเด็นปัญหา
----------------------------------------------------------------------

Our system for reporting, tracking and solving bugs is currently BugZilla, kindly hosted at https://bugs.libreoffice.org/. We encourage all users to feel entitled and welcome to report bugs that may arise on your particular platform. Energetic reporting of bugs is one of the most important contributions that the user community can make to the ongoing development and improvement of LibreOffice.

----------------------------------------------------------------------
ได้มีส่วนร่วม
----------------------------------------------------------------------

ชุมชน LibreOffice จะได้รับประโยชน์มากมายมายจากการมีส่วนร่วมของคุณในการพัฒนาของโครงงานโอเพ่นซอร์สที่สำคัญนี้

ในฐานะผู้ใช้, คุณได้เป็นส่วนที่มีค่าอยู่แล้วในกระบวนการพัฒนา และเราขอสนับสนุนให้คุณมีบทบาทมากขึ้นโดยเป็นผู้ให้ในระยะยาวต่อชุมชน กรุณาเข้าร่วมกับเราและลองดูที่หน้าของการให้ที่ http://www.libreoffice.org/contribution/

เริ่มต้นอย่างไร
----------------------------------------------------------------------

วิธีที่ดีที่สุดที่จะเริ่มในการให้คือการบอกรับไปยังบัญชีจ่าหน้า (mailing lists) หนึ่งบัญชีหรือมากกว่า ด้อมๆ มองๆ ดูสักพัก และค่อยๆ เข้าไปดูในหน่วยเก็บถาวรของอีเมล (mail archives) เพื่อทำความคุ้นเคยกับหัวข้อต่างๆ ที่เคยกล่าวถึงตั้งแต่ที่เริ่มปล่อยซอร์ซโค้ดของ LibreOffice ออกมาตั้งแต่ตุลาคม ค.ศ.2000 เมื่อคุณรู้สึกสบายใจที่จะเริ่ม ทั้งหมดที่ต้องทำก็คือส่งอีเมลแนะนำตัวเองและกระโดดเข้ามา ถ้าคุณคุ้นเคยกับโครงการโอเพ่นซอร์ซอยู่แล้ว ลองดูรายการสิ่งที่ต้องทำ (To-Dos list) ของเราเพื่อดูว่ามีอะไรที่คุณอยากช่วยได้ที่ http://www.libreoffice.org/develop/

ลงนาม
----------------------------------------------------------------------

นี่คือบางส่วนของบัญชีจ่าหน้าซึ่งคุณสามารถบอกรับได้ที่ http://www.libreoffice.org/contribution/

* ข่าว: announce@documentfoundation.org *แนะนำสำหรับผู้ใช้ทั้งหมด* (การจราจรเบาบาง)
* เวทีอภิปรายหลักของผู้ใช้: users@global.libreoffice.org *วิธีง่ายๆ ในการดูว่าเขาหารืออะไรกัน* (จราจรหนาแน่น) 
* โครงการด้านการตลาด: marketing@global.libreoffice.org *ถัดไปจากการพัฒนา* (การจราจรเริ่มหนาแน่น)
* บัญชีจ่าหน้าทั่วไปของผู้พัฒนา: libreoffice@lists.freedesktop.org (จราจรหนาแน่น)

การเข้าร่วมโครงการหนึ่งหรือมากกว่า
----------------------------------------------------------------------

คุณสามารถเป็นผู้ช่วยสนับสนุนหลักในโครงงานโอเพนซอร์สที่สำคัญนี้แม้ว่าคุณจะมีประสบการณ์ในการออกแบบซอฟต์แวร์หรือเขียนโปรแกรมอย่างจำกัด 

เราหวังว่าคุณคงจะทำงานสนุกกับ LibreOffice 5.4 ใหม่และจะเข้าร่วมกับเราทางออนไลน์

ชุมชนลิเบอร์ออฟฟิศ

----------------------------------------------------------------------
ใช้/แก้ไข  ซอร์สโค้ด
----------------------------------------------------------------------

Portions Copyright 1998, 1999 James Clark. Portions Copyright 1996, 1998 Netscape Communications Corporation.
