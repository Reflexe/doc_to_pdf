
======================================================================
Tài liệu Đọc Đi LibreOffice 5.4
======================================================================


For the latest updates to this readme file, see http://www.libreoffice.org/welcome/readme.html

Tập tin này chứa thông tin về phần mềm LibreOffice. Bạn nên đọc kĩ trước khi cài đặt.

Cộng đồng LibreOffice chịu trách nhiệm phát triển sản phẩm này. Bạn hãy tham gia với tư cách thành viên cộng đồng. Nếu bạn mới, bạn có thể ghé thăm website của LibreOffice để có thêm thông tin chi tiết về LibreOffice và tìm hiểu xem đã có cộng đồng nào tồn tại hay chưa. Ghé thăm: http://vi.libreoffice.org/.

Is LibreOffice Thực sự miễn phí?
----------------------------------------------------------------------

LibreOffice miễn phí cho mọi người. Có thể copy sản phẩm LibreOffice bao nhiêu bản tùy úy, dùng với bât kỳ mục đích nào (thương mại, danh mục công, giáo dục). Thông tin thêm xin xem trong giấy phép kèm theo LibreOffice.

Vì sao LibreOffice miễn phí cho mọi người?
----------------------------------------------------------------------

Bạn có quyền sao chép LibreOffice tự do không hạn chế vì rất nhiều cá nhân cũng như tổ chức đã thiết kế, phát triển, dịch, viết tài liệu, hỗ trợ, tiếp thị bằng nhiều cách khác nhau để LibreOffice thành công như ngày hôm nay - phần mềm văn phòng số một thế giới cho người dùng cá nhân cũng như doanh nghiệp.

Nếu bạn đánh giá cao sự đóng góp của họ, và muốn đóng góp chút ít để LibreOffice tiếp tục được phát triển, xem http://www.documentfoundation.org/contribution/. Bất kỳ ai cũng có thể đóng góp bằng một cách nào đó.

----------------------------------------------------------------------
Lưu ý khi cài đặt
----------------------------------------------------------------------

LibreOffice cần Java Runtime Environment (JRE) để có thể chạy đủ các chức năng. JRE không phài là một phần của gói cài đặt LibreOffice, do đó cần cài riêng.

Yêu cầu hệ thống
----------------------------------------------------------------------

* Microsoft Windows XP SP3, Vista, 7, 8, or 10

Lưu ý rằng cần phải có quyền quản trị để chạy tiến trình cài đặt.

Chức năng đăng ký LibreOffice như là ứng dụng mặc định cho các định dạng MS Office cũng có thể được ép buộc hoặc thu hồi dùng những cái chuyển dòng lệnh theo đây với trình cài đặt:

* REGISTER_ALL_MSO_TYPES=1 will force registration of LibreOffice as default application for Microsoft Office formats.
* REGISTER_NO_MSO_TYPES=1 will suppress registration of LibreOffice as default application for Microsoft Office formats.

Bạn cần chuẩn bị đủ bộ nhớ và chỗ trống cho thư mục tạm cũng như quyền đọc/ghi. Hãy đóng các chương trình khác trước khi chạy trình cài đặt.

Cài đặt  LibreOffice vào Debian/Ubuntu
----------------------------------------------------------------------

For instructions on how to install a language pack (after having installed the US English version of LibreOffice), please read the section below entitled Installing a Language Pack.

When you unpack the downloaded archive, you will see that the contents have been decompressed into a sub-directory. Open a file manager window, and change directory to the one starting with "LibreOffice_", followed by the version number and some platform information.

Thư mục này chứa thư mục con "DEBS". Hãy chuyển đến thư mục "DEBS".

Nhấn chuột phải bên trong thư mục và chọn "Mở cửa sổ dòng lệnh". Cửa sổ dòng lệnh sẽ hiện ra. Nhập câu lệnh sau (bạn sẽ được yêu cầu nhập mật khẩu người dùng trước khi câu lệnh được thực thi):

The following commands will install LibreOffice and the desktop integration packages (you may just copy and paste them into the terminal screen rather than trying to type them):

sudo dpkg -i *.deb

Cài đặt hoàn tất, các biểu tượng của LibreOffice sẽ ở trong thực đơn Chương trình/Office.

Installation of LibreOffice on Fedora, openSUSE, Mandriva and other Linux systems using RPM packages
----------------------------------------------------------------------

For instructions on how to install a language pack (after having installed the US English version of LibreOffice), please read the section below entitled Installing a Language Pack.

When you unpack the downloaded archive, you will see that the contents have been decompressed into a sub-directory. Open a file manager window, and change directory to the one starting with "LibreOffice_", followed by the version number and some platform information.

Thư mục này chứa thư mục con "RPMS". Hãy chuyển đến thư mục "RPMS".

Nhấn chuột phải bên trong thư mục và chọn "Mở cửa sổ dòng lệnh". Cửa sổ dòng lệnh sẽ hiện ra. Nhập câu lệnh sau (bạn sẽ được yêu cầu nhập mật khẩu người dùng trước khi câu lệnh được thực thi):

Với Fedora: su -c 'yum install *.rpm'

Với phiên bản Mandiva, dùng: sudo urpmi *.rpm

For other RPM-based systems (openSUSE, etc.): rpm -Uvh *.rpm

Cài đặt hoàn tất, các biểu tượng của LibreOffice sẽ ở trong thực đơn Chương trình/Office.

Alternatively, you can use the 'install' script, located in the toplevel directory of this archive to perform an installation as a user. The script will set up LibreOffice to have its own profile for this installation, separated from your normal LibreOffice profile. Note that this will not install the system integration parts such as desktop menu items and desktop MIME type registrations.

Chú ý về tích hợp với các phiên bản Linux không được đề cập tới trong hướng dẫn cài đặt ở trên
----------------------------------------------------------------------

LibreOffice có thể dễ dàng cài đặt trên các bản phân phối khác không liệt ở hướng dẫn cài đặt. Khó khăn có thể gặp phải chỉ là tích hợp với desktop.

The RPMS (or DEBS, respectively) directory also contains a package named libreoffice5.4-freedesktop-menus-5.4.0.1-1.noarch.rpm (or libreoffice5.4-debian-menus_5.4.0.1-1_all.deb, respectively, or similar). This is a package for all Linux distributions that support the Freedesktop.org specifications/recommendations (http://en.wikipedia.org/wiki/Freedesktop.org), and is provided for installation on other Linux distributions not covered in the aforementioned instructions.

Cài đặt gói ngôn ngữ
----------------------------------------------------------------------

Tải về gói ngôn ngữ cần thiết. Có thể tải về từ kho cài đặt chính. Với trình quản lý tệp Nautilus, giải nén kho đã tải về vào một thư mục nào đó (ví dụ, desktop). Trước khi cài đặt, đảm bảo rằng đã thoát khỏi  LibreOffice  (bao gồm cả quickstart).

Di chuyển tới thư mục đã giải nén gói ngôn ngữ.

Now change directory to the directory that was created during the extraction process. For instance, for the French language pack for a 32-bit Debian/Ubuntu-based system, the directory is named LibreOffice_, plus some version information, plus Linux_x86_langpack-deb_fr.

Now change directory to the directory that contains the packages to install. On Debian/Ubuntu-based systems, the directory will be DEBS. On Fedora, openSUSE or Mandriva systems, the directory will be RPMS.

Từ trình quản lý tệp Nautilus, nhấp chuột phải vào thư mục và chọn "Mở bằng thiết bị đầu cuối". Trong cửa sổ thiết bị đầu cuối vừa được mở, thực hiện lệnh cài đặt gói ngôn ngữ (bằng dòng lệnh, và sẽ cần nhập mật khẩu của root):

Với Debian/Ubutun, dùng lệnh: sudo dpkg -i *.deb

Với Fedora: su -c 'yum install *.rpm'

Với phiên bản Mandiva, dùng: sudo urpmi *.rpm

For other RPM-using systems (openSUSE, etc.): rpm -Uvh *.rpm

Khởi động chương trình LibreOffice - ví dụ như Writer. Từ thực đơn Công cụ, chọn Tùy chọn. Từ hộp thoại Tùy chọn, nhấp "Cài đặt ngôn ngữ" và sau đó nhấn vào "Ngôn ngữ". Dưới "Giao diện người dùng", chọn gói ngôn ngữ vừa mới cài đặt. Tương tự, bạn có thể thay đổi "Cài đặt locale", "Tiền tệ mặc định" và "Ngôn ngữ mặc định cho tài liệu".

Sau khi chỉnh các thiếp lập này, nhấn OK. Tắt hộp thoại, LibreOffice  sẽ thông báo rằng thay đổi chỉ có hiệu lực khi đã khởi động lại LibreOffice (Lưu ý rằng cần tắt Khởi động nhanh).

Ngôn ngữ đã cài đặt sẽ được dùng trong lần khởi động  LibreOffice  tiếp theo.

----------------------------------------------------------------------
Vấn đề trong khi khởi chạy chương trình
----------------------------------------------------------------------

Khó khăn trong tiến trình khởi chạy LibreOffice (v.d. ứng dụng bị treo), cũng như vấn đề đối với cách hiển thị trên màn hình, thường do trình điều khiển bo mạch đồ họa gây ra. Gặp khó khăn kiểu này thì bạn hãy cập nhật trình điều khiển bo mạch đồ họa, hoặc thử dùng trình điều khiển đồ họa có sẵn trong hệ điều hành. Khó khăn trong tiến trình hiển thị đối tượng ba chiều (3D) thường có thể được giải quyết bằng cách tắt tùy chọn « Dùng OpenGL » trong Tùy thích « Công cụ > Tùy chọn > LibreOffice > Xem > Xem 3D ».

----------------------------------------------------------------------
Chuột lăn của máy tính xách tay ALPS/Synaptics cho Windows
----------------------------------------------------------------------

Do một vấn đề trình điều khiển Windows, bạn không thể cuộn qua tài liệu LibreOffice khi bạn trượt ngón tay qua một vùng sờ kiểu ALPS/Synaptics.

Để bật khả năng cuộn bằng chuột lăn, hãy thêm các dòng sau vào tập tin cấu hình "C:\Program Files\Synaptics\SynTP\SynTPEnh.ini", sau đó khởi động lại máy tính:

[LibreOffice]

FC = "SALFRAME"

SF = 0x10000000

SF |= 0x00004000

Lưu ý: vaị trí của tập tin cấu hình có thể thay đổi tùy theo phiên bản của Windows.

----------------------------------------------------------------------
Phím tắt
----------------------------------------------------------------------

Only shortcut keys (key combinations) not used by the operating system can be used in LibreOffice. If a key combination in LibreOffice does not work as described in the LibreOffice Help, check if that shortcut is already used by the operating system. To rectify such conflicts, you can change the keys assigned by your operating system. Alternatively, you can change almost any key assignment in LibreOffice. For more information on this topic, refer to the LibreOffice Help or the Help documentation of your operating system.

----------------------------------------------------------------------
Vấn đề khi gửi tài liệu dạng thư từ LibreOffice
----------------------------------------------------------------------

Khi gửi tài tài liệu bằng 'Tập tin > Gửi > Tài liệu dạng thư điện tử' hoặc 'Tài liệu dạng đính kèm PDF', có thể xảy ra lỗi (chương trình đổ vỡ hay treo). Lý do là tập tin hệ thống Windows 'Mapi' (Messaging Application Programming Interface) trong một số phiên bản có vấn đề. Rất tiếc rằng lỗi này không chỉ giới hạn trong một phiên bản cụ thể. Để có thêm thông tin, hãy ghé thăm địa chỉ  http://www.microsoft.com để tìm kiếm Microsoft Knowledge Base với từ khóa "mapi dll".

----------------------------------------------------------------------
Ghi chú Khả năng Truy cập Quan trọng
----------------------------------------------------------------------

For more information on the accessibility features in LibreOffice, see http://www.libreoffice.org/accessibility/

----------------------------------------------------------------------
Hỗ trợ người dùng
----------------------------------------------------------------------

The main support page http://www.libreoffice.org/support/ offers various possibilities for help with LibreOffice. Your question may have already been answered - check the Community Forum at http://www.documentfoundation.org/nabble/ or search the archives of the 'users@libreoffice.org' mailing list at http://www.libreoffice.org/lists/users/. Alternatively, you can send in your questions to users@libreoffice.org. If you like to subscribe to the list (to get email responses), send an empty mail to: users+subscribe@libreoffice.org.

Xem Các câu hỏi thường gặp tại: http://www.libreoffice.org/faq/.

----------------------------------------------------------------------
Reporting Bugs & Issues
----------------------------------------------------------------------

Our system for reporting, tracking and solving bugs is currently BugZilla, kindly hosted at https://bugs.libreoffice.org/. We encourage all users to feel entitled and welcome to report bugs that may arise on your particular platform. Energetic reporting of bugs is one of the most important contributions that the user community can make to the ongoing development and improvement of LibreOffice.

----------------------------------------------------------------------
Tham gia 
----------------------------------------------------------------------

Cộng đồng LibreOffice sẽ rất biết ơn sự chủ động tham gia của bạn để việc phát triển dự án mã nguồn mở quan trọng này.

Bạn, là nguời dùng, có vai trò quan trọng trong công đoạn phát triển phần mềm này. Hãy tham gia đóng góp dự án, xem trang http://www.libreoffice.org/contribution/

How to Start
----------------------------------------------------------------------

Cách đóng góp tốt nhất là tham gia một hay nhiều hộp thư chung, đọc thư một thời gian và kho thư để làm quen với các chủ đề của dự án LibreOffice được đề cập từ năm 2000. Nếu cảm thấy hợp, chỉ cần gửi một email giới thiệu bản thân. Nếu đã quen với các dự án mã mở, hãy xem danh sách công việc (TODO) và đóng góp, hỗ trợ dự án, xem:  http://www.libreoffice.org/develop/.

Chỉ số dưới
----------------------------------------------------------------------

Bạn có thể theo dõi một số mailing list tại http://www.libreoffice.org/contribution/

* Tin tức: announce@documentfoundation.org *khuyến nghị cho tất cả người dùng* (ít email)
* Main user list: users@global.libreoffice.org *easy way to lurk on discussions* (heavy traffic)
* Marketing project: marketing@global.libreoffice.org *beyond development* (getting heavy)
* Hộp thư phát triển nói chung libreoffice@lists.freedesktop.org (nhiều email)

Tham gia một hay nhiều dự án
----------------------------------------------------------------------

You can make major contributions to this important open source project even if you have limited software design or coding experience. Yes, you!

We hope you enjoy working with the new LibreOffice 5.4 and will join us online.

Cộng đồng LibreOffice

----------------------------------------------------------------------
Used / Modified Source Code
----------------------------------------------------------------------

Portions Copyright 1998, 1999 James Clark. Portions Copyright 1996, 1998 Netscape Communications Corporation.
