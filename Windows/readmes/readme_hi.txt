
======================================================================
LibreOffice 5.4 ReadMe
======================================================================


For the latest updates to this readme file, see http://www.libreoffice.org/welcome/readme.html

यह फ़ाइल LibreOffice सॉफ्टवेयर के बारे में महत्वपूर्ण सूचना समाहित किए है. आपको इस सूचना को बहुत ध्यान से संस्थापन आरंभ करने के पहले पढ़ने की जरूरत है.

LibreOffice समुदाय इस उत्पाद के विकास के लिए जिम्मेदार है और यह आपको बतौर समुदाय सदस्य भाग लेने के लिए आमंत्रित करती है. यदि आप एक नए उपयोक्ता हैं, आप LibreOffice साइट को देख सकते हैं जहाँ आप LibreOffice परियोजना और समुदाय के बारे में काफी कुछ जानकारी पाएँगे जो इसके गिर्द मौजूद रहती है. http://www.libreoffice.org/ पर जाएँ.

क्या LibreOffice वाकई किसी उपयोक्ता के लिए निःशुल्क है?
----------------------------------------------------------------------

LibreOffice हर किसी के लिए उपयोग के लिए निःशुल्क है. आप LibreOffice के इस नक़ल को ले सकते हैं और मनचाहे संख्या में कंप्यूटरों पर संस्थापित कर सकते हैं, और अपने किसी उद्देश्यों के लिए इसे उपयोग कर सकते हैं (वाणिज्यिक, सरकारी, सार्वजनिक प्रशासन और शैक्षणिक उपयोग). आगे और विवरण के लिए संकुलित लाइसेंस इस LibreOffice डाउनलोड के साथ पाठ देखें.

क्यों LibreOffice किसी उपयोक्ता के लिए निःशुल्क है?
----------------------------------------------------------------------

आप इस LibreOffice की कॉपी को बिना किसी शुल्क के उपयोग कर सकते हैं क्योंकि अलग-अलग योगदानकर्ताओं और कॉरपोरेट प्रायोजकों ने इसे डिजायन, विकसित, जाँच, अनुवाद, दस्तावेज़ित, मार्केटिंग और मदद कई रूपों में किया है जिससे LibreOffice बन पाया है जो यह आज है - घर और कार्यालयों के लिए दुनिया का अग्रणी मुक्त स्रोत उत्पादकता सॉफ्टवेयर.

यदि आप इस प्रयास की सराहना करते हैं, यह पक्का करना चाहते हैं कि यह LibreOffice भविष्य में लंबे समय तक उपलब्ध होता रहे, कृपया इस परियोजना में योगदान की सोचें - अधिक विवरण के लिए देखें http://www.documentfoundation.org/contribution/. हर कोई किसी तरह का योगदान कर सकता है.

----------------------------------------------------------------------
संस्थापन पर टिप्पणी
----------------------------------------------------------------------

LibreOffice के लिए जावा रनटाइम वातावरण (JRE) का हालिया संस्करण पूर्ण कार्यशीलता के लिए चाहिए. JRE LibreOffice संस्थापन संकुल का हिस्सा नहीं है, इसे अलग से संस्थापित किया जाना चाहिए.

तंत्र जरूरत
----------------------------------------------------------------------

* Microsoft Windows XP SP3, Vista, 7, 8, or 10

नोट: जानें कि प्रशासक अधिकार संस्थापन प्रक्रिया के लिए जरूरी है.

माइक्रोसॉफ़्ट ऑफ़िस प्रारूप के लिए बतौर तयशुदा अनुप्रयोग LibreOffice का पंजीयन संस्थापक के साथ निम्नलिखित कमांड लाइन स्विच के साथ बाध्य किया या रोका जा सकता है:

* REGISTER_ALL_MSO_TYPES=1 LibreOffice को माइक्रोसॉफ्ट ऑफिस प्रारूप के लिए बतौर तयशुदा अनुप्रयोग पंजीयन के लिए बाध्य करेगा.
* REGISTER_NO_MSO_TYPES=1 की पंजीयन को माइक्रोसॉफ़्ट ऑफिस प्रारूप के लिए तयशुदा अनुप्रयोग के रूप में दबाएगा.

कृपया सुनिश्चित करें कि आपके पास आपके तंत्र में अस्थायी निर्देशिका में निःशुल्क स्मृति है, और कृपया सुनिश्चित करें कि पढ़ें, लिखें और चलाएँ पहुँच अधिकार दिए जा चुके हैं. संस्थापन प्रक्रिया को आरंभ करने के पहले सभी अन्य प्रोग्राम बंद करें.

LibreOffice का डेबियन/उबन्टू आधारित लिनक्स तंत्र पर संस्थापन
----------------------------------------------------------------------

For instructions on how to install a language pack (after having installed the US English version of LibreOffice), please read the section below entitled Installing a Language Pack.

When you unpack the downloaded archive, you will see that the contents have been decompressed into a sub-directory. Open a file manager window, and change directory to the one starting with "LibreOffice_", followed by the version number and some platform information.

यह निर्दशिका "DEBS" नामक उपनिर्देशिका समाहित करती है. निर्देशिका को "DEBS" निर्देशिका में बदलें.

निर्देशिका के अंदर दाहिना क्लिक करें और "टर्मिनल में खोलें" चुनें. एक टर्मिनल विंडो खुलेगा. टर्मिनल विंडो की कमांड लाइन से, निम्नलिखित कमांड दर्ज करें (आपको अपना रूट उपयोक्ता का कूटशब्द दर्ज करना होगा इससे पहले कि कमांड चलेगा):

The following commands will install LibreOffice and the desktop integration packages (you may just copy and paste them into the terminal screen rather than trying to type them):

sudo dpkg -i *.deb

संस्थापन प्रक्रिया अब पूरी हो गई है, और आपके पास सभी LibreOffice अनुप्रयोग हैं आपके डेस्कटॉप के अनुप्रयोग/ऑफिस मेन्यू में.

Installation of LibreOffice on Fedora, openSUSE, Mandriva and other Linux systems using RPM packages
----------------------------------------------------------------------

For instructions on how to install a language pack (after having installed the US English version of LibreOffice), please read the section below entitled Installing a Language Pack.

When you unpack the downloaded archive, you will see that the contents have been decompressed into a sub-directory. Open a file manager window, and change directory to the one starting with "LibreOffice_", followed by the version number and some platform information.

यह निर्दशिका "RPMS" नामक उपनिर्देशिका समाहित करती है. निर्देशिका को "RPMS" निर्देशिका में बदलें.

निर्देशिका के अंदर दाहिना क्लिक करें और "टर्मिनल में खोलें" चुनें. एक टर्मिनल विंडो खुलेगा. टर्मिनल विंडो की कमांड लाइन से, निम्नलिखित कमांड दर्ज करें (आपको अपना रूट उपयोक्ता का कूटशब्द दर्ज करना होगा इससे पहले कि कमांड चलेगा):

फेडोरा आधारित तंत्र के लिए: su -c 'yum install *.rpm'

मंद्रिवा आधारित तंत्र के लिए: sudo urpmi *.rpm

For other RPM-based systems (openSUSE, etc.): rpm -Uvh *.rpm

संस्थापन प्रक्रिया अब पूरी हो गई है, और आपके पास सभी LibreOffice अनुप्रयोग हैं आपके डेस्कटॉप के अनुप्रयोग/ऑफिस मेन्यू में.

Alternatively, you can use the 'install' script, located in the toplevel directory of this archive to perform an installation as a user. The script will set up LibreOffice to have its own profile for this installation, separated from your normal LibreOffice profile. Note that this will not install the system integration parts such as desktop menu items and desktop MIME type registrations.

ऊपर के संस्थापन निर्देश में कवर नहीं हुए लिनक्स वितरण के डेस्कटॉप एकीकरण के संबंध में नोट्स
----------------------------------------------------------------------

LibreOffice को अन्य लिनक्स वितरण पर संस्थापित करना आसानी से संभव था जो कि इन संस्थापन निर्देश में विशेष रूप से कवर नहीं किया गया था. मुख्य पहलू जिनके लिए अंतर हो सकता है वह है डेस्कटॉप एकीकरण.

The RPMS (or DEBS, respectively) directory also contains a package named libreoffice5.4-freedesktop-menus-5.4.0.1-1.noarch.rpm (or libreoffice5.4-debian-menus_5.4.0.1-1_all.deb, respectively, or similar). This is a package for all Linux distributions that support the Freedesktop.org specifications/recommendations (http://en.wikipedia.org/wiki/Freedesktop.org), and is provided for installation on other Linux distributions not covered in the aforementioned instructions.

भाषा पैक का संस्थापन
----------------------------------------------------------------------

अपने वांछित भाषा और प्लेटफॉर्म के लिए भाषा पैक डाउनलोड करें. मुख्य संस्थापन अभिलेख की तरह उसी स्थान से वे उपलब्ध हैं. नॉटिलस फ़ाइल प्रबंधक से, डाउनलोड किए अभिलेख को निर्देशिका (उदाहरण के लिए आपका डेस्कटॉप) निकालें. सुनिश्चित करें कि आप सभी LibreOffice अनुप्रयोगों से निकल (QuickStarter के साथ, यदि यह आरंभ हो चुका है) चुके हैं.

निर्देशिका को उन निर्देशिका में बदलें जिसमें आफने अपने डाउनलोड किए गए भाषा पैक को निकाला है.

Now change directory to the directory that was created during the extraction process. For instance, for the French language pack for a 32-bit Debian/Ubuntu-based system, the directory is named LibreOffice_, plus some version information, plus Linux_x86_langpack-deb_fr.

Now change directory to the directory that contains the packages to install. On Debian/Ubuntu-based systems, the directory will be DEBS. On Fedora, openSUSE or Mandriva systems, the directory will be RPMS.

नॉटिलस फ़ाइल प्रबंधक से, निर्देशिका पर दाहिना क्लिक करें और "टर्मिनल में खोलें" कमांड चुनें. टर्मिनल विंडो में जिसे आपने हाल में खोला है, भाषा पैक को संस्थापित करने के लिए कमांड चलाएँ (नीचे के सभी कमांड के साथ, आपको अपना रूट कूटशब्द दर्ज करने के लिए प्रांप्ट किया जाएगा):

डेबियन/उबन्टू आधारित तंत्र के लिए: sudo dpkg -i *.deb

फेडोरा आधारित तंत्र के लिए: su -c 'yum install *.rpm'

मंद्रिवा आधारित तंत्र के लिए: sudo urpmi *.rpm

For other RPM-using systems (openSUSE, etc.): rpm -Uvh *.rpm

अब LibreOffice अनुप्रयोग में से एक को आरंभ करें - जैसे कि राइटर. औज़ार मेन्यू में जाएँ और विकल्प चुनें. विकल्प संवाद पेटी में, "भाषा सेटिंग्स" पर जाएँ और "भाषाएँ" पर क्लिक करें. "उपयोक्ता अंतरफलक" सूची को ड्रॉपडाउन करें और अपने द्वारा संस्थापित भाषा को चुनें. यदि आप जानते हैं, "लोकेल सेटिंग", "तयशुदा मुद्रा", और "दस्तावेज़ के लिए तयशुदा भाषाएँ" के लिए वही काम करें.

उन सेटिंग को समायोजित करके, ठीक पर क्लिक करें. संवाद पेटी बंद हो जाएगी, और आप एक सूचना संदेश देखें आपको बताते हुए कि आपके परिवर्तन तभी सक्रिय किए जाएँगे जब LibreOffice से छोड़ते हैं और इसे फिर आरंभ करते हैं (क्विकस्टार्टर से निकलना याद रखें यदि यह आरंभ होता है).

अगली बार जब आप LibreOffice शुरू करते हैं, तो यह आपके द्वारा संस्थापित भाषा में आरंभ होगा.

----------------------------------------------------------------------
गनोम पर प्रोग्राम आरंभ होने के दौरान समस्या
----------------------------------------------------------------------

LibreOffice (उदा. अनुप्रयोग अटकना) के आरंभ के साथ स्क्रीन प्रदर्शन में समस्या बहुत समय आलेखी कार्ड ड्राइवर के कारण हो जाता है. यदि यह समस्या जन्म लेता है, आप अपने आलेखी कार्ड ड्राइवर को अद्यतन करें अथवा उस आलेखी ड्राइव का प्रयोग करें जो आपके ऑपरेटिंग तंत्र को संग दिया गया है. 3D वस्तु को दिखाने की परेशानी को हल करने के लिए "OpenGL का प्रयोग करें" 'औज़ार - विकल्प - - LibreOffice - देखें - 3D दृश्य' के अंतर्गत.

----------------------------------------------------------------------
विंडोज में ALPS/Synaptics नोटबुक टचपैड
----------------------------------------------------------------------

एक Windows ड्राइवर मुद्दा के कारण, आप LibreOffice दस्तावेज़ से हो कर स्क्रॉल नहीं कर सकते हैं जब कि अपनी अंगुली को एक ALPS/Synaptics टचपैड के आर-पार ले जाते हैं.

टचपैड स्क्रॉलिंग सक्रिय करने के लिए "C:\Program Files\Synaptics\SynTP\SynTPEnh.ini" विन्यास फ़ाइल में ये पंक्ति जोड़ें और अपना कंप्यूटर फिर शुरू करें:

[LibreOffice]

FC = "SALFRAME"

SF = 0x10000000

SF |= 0x00004000

नोट: विन्यास फ़ाइल की अवस्थिति Windows के भिन्न संस्करण के साथ भिन्न रहता है.

----------------------------------------------------------------------
शार्टकट कुंजी
----------------------------------------------------------------------

Only shortcut keys (key combinations) not used by the operating system can be used in LibreOffice. If a key combination in LibreOffice does not work as described in the LibreOffice Help, check if that shortcut is already used by the operating system. To rectify such conflicts, you can change the keys assigned by your operating system. Alternatively, you can change almost any key assignment in LibreOffice. For more information on this topic, refer to the LibreOffice Help or the Help documentation of your operating system.

----------------------------------------------------------------------
LibreOffice से ई-मेल के रूप में दस्तावेज़ भेजने में समस्या
----------------------------------------------------------------------

एक दस्तावेज़ 'फ़ाइल - भेजें - ई-मेल रूप में दस्तावेज़' अथवा 'PDF संलग्न के रूप में दस्तावेज़' से हो कर भेजने के समय समस्या उत्पन्न हो सकती है (प्रोग्राम क्रैश करता है अथवा अटक सकता है). यह विंडो तंत्र फ़ाइल के कारण है "Mapi" (मेसेजिंग एप्लीकेशन प्रोग्रामिंग इंटरफेस) जो कुछ फ़ाइल परिवर्तन में समस्या लाता है. दुर्भाग्य से, समस्या को कुछ खास संस्करण संख्या तक सीमित नहीं किया जा सकता है. अधिक सूचना ले http://www.microsoft.com के भ्रमण करें माइक्रोसॉफ़्ट नॉलेजबेस को "mapi dll" के लिए खोज करने के लिए.

----------------------------------------------------------------------
महत्वपूर्ण पहुंचयोग्य नोट्स
----------------------------------------------------------------------

LibreOffice की पहुँच फीचर पर अधिक जानकारी के लिए, देखें http://www.libreoffice.org/accessibility/

----------------------------------------------------------------------
उपयोक्ता समर्थन
----------------------------------------------------------------------

मुख्य समर्थन पृष्ठ http://www.libreoffice.org/support/ मदद के लिए LibreOffice में विविध संभावनाएँ ऑफर करता है. आपका प्रश्न हो सकता है पहले ही उत्तर दिया जा चुका हो - समुदाय फोरम को http://www.documentfoundation.org/nabble/ पर जाँचें या 'users@libreoffice.org' डाक-सूची को http://www.libreoffice.org/lists/users/ पर खोजें. वैकल्पिक रूप से, आप अपने प्रश्नों को users@libreoffice.org यहाँ भेज सकते हैं. यदि आप सूची (ईमेल प्रतिक्रिया पाने के लिए), तो एक रिक्त ईमेल यहाँ भेजें: users+subscribe@libreoffice.org.

साथ ही FAQ खंड को यहाँ जाँचें http://www.libreoffice.org/faq/.

----------------------------------------------------------------------
बग रिपोर्टिंग व मुद्दे
----------------------------------------------------------------------

Our system for reporting, tracking and solving bugs is currently BugZilla, kindly hosted at https://bugs.libreoffice.org/. We encourage all users to feel entitled and welcome to report bugs that may arise on your particular platform. Energetic reporting of bugs is one of the most important contributions that the user community can make to the ongoing development and improvement of LibreOffice.

----------------------------------------------------------------------
शामिल हो रहा है
----------------------------------------------------------------------

LibreOffice समुदाय को आपके सक्रिय सहभागिता से बहुत लाभ मिलेगा इस मुक्त स्रोत प्रोजेक्ट के विकास में.

बतौर उपयोक्ता, आप सूइट विकास प्रक्रिया के मूल्यवान हिस्से हैं और हम आपको और सक्रिय भूमिका लेने के लिए प्रोत्साहित करना चाहते हैं ताकि आप हमारे लंबे समय के सामुदायिक योगदानकर्ता बनें. कृपया शामिल हों और योगदानकर्ता http://www.libreoffice.org/contribution/ पृष्ठ को जाँचें

आरंभ करने का तरीका
----------------------------------------------------------------------

योगदान करने का सबसे अच्छा तरीका है कि आप डाक-सूची में शामिल हों, कुछ देर ध्यान रखें और धीरे-धीरे डाक अभिलेख का उपयोग करें ताकि कवर किए गए विभिन्न विषयों को LibreOffice स्रोत कोड के अक्टूबर 2000 में जारी किए जाने के बाद से परिचय ले. जब आप आरामदायक स्थिति में हो, आपको बस अपना परिचय देते हुए एक ईमेल भेजना है और बीच में कूद पड़ना है. यदि आप मुक्त स्रोत प्रोजेक्ट से परिचित हैं, हमारे किए जाने वाले कामों की सूची देखें और http://www.libreoffice.org/develop/ पर देखें यदि कुछ ऐसा है जिसमें आप मदद कर सकते हैं.

सदस्यता
----------------------------------------------------------------------

यहाँ कुछ डाक-सूची है जिसकी आप सदस्यता ले सकते हैं http://www.libreoffice.org/contribution/

* समाचार: announce@documentfoundation.org *सभी उपयोक्ता के लिए अनुशंसित* (हल्की ट्रैफिक)
* प्रधान उपयोक्ता सूची: users@global.libreoffice.org *परिचर्चा से जुड़ने का आसान तरीका* (बहुत अधिक आवाजाही)
* विपणन परियोजना: marketing@global.libreoffice.org *beyond development* (ट्रैफिक बढ़ रहा है)
* सामान्य विकासकर्ता सूची: libreoffice@lists.freedesktop.org (बहुत ट्रैफिक)

एक या अधिक परियोजनाओं में शामिल हों
----------------------------------------------------------------------

आप इस महत्वपूर्ण मुक्त स्रोत प्रोजेक्ट में तभी अच्छा योगदान दे सकते हैं जब आपको कम सॉफ्टवेयर डिजायन अथवा कोडिंग अनुभव है. हां, आप!

हम आशा करते हैं कि आप नए LibreOffice 5.4 के साथ कार्य करने का आनंद लें और हमें ऑनलाइन शामिल करें.

LibreOffice समुदाय

----------------------------------------------------------------------
Used / Modified Source Code
----------------------------------------------------------------------

Portions Copyright 1998, 1999 James Clark. Portions Copyright 1996, 1998 Netscape Communications Corporation.
