
======================================================================
Plik ReadMe programu LibreOffice 5.4
======================================================================


Najnowsza wersja pliku readme dostępna jest pod adresem http://www.libreoffice.org/welcome/readme.html

Ten plik zawiera istotne informacje dotyczące oprogramowania LibreOffice. Przeczytaj go uważnie przed rozpoczęciem instalacji.

Społeczność LibreOffice jest odpowiedzialna za rozwój tego programu i chce byś stał się jednym z jej członków. Jeśli jesteś nowym użytkownikiem, odwiedź stronę LibreOffice na której znajdziesz informacje o projekcie LibreOffice oraz jego społeczności. Odwiedź http://www.libreoffice.org/.

Czy LibreOffice naprawdę jest bezpłatny dla wszystkich?
----------------------------------------------------------------------

Program LibreOffice jest bezpłatny dla wszystkich. Możesz używać tej kopii LibreOffice i instalować ją na tylu komputerach ilu tylko chcesz oraz używać jej w każdym celu (komercyjnym, rządowym, edukacyjnym i w instytucjach administracji publicznej). Więcej szczegółów można znaleźć w licencji dołączonej do pobranego LibreOffice.

Dlaczego program LibreOffice jest bezpłatny dla każdego?
----------------------------------------------------------------------

Możesz używać tej kopii LibreOffice bez ponoszenia żadnych opłat ponieważ wielu współpracowników i sponsorów go projektowało, tworzyło, testowało, opisywało, wspierało, reklamowało i pomagało na wiele innych sposobów. Dzięki temu LibreOffice jest tym czym jest dzisiaj - liderem wśród pakietów biurowych typu Open Source na świecie, do użytku w domu i w firmie.

Jeśli doceniasz ich trud i chcesz mieć pewność, że w przyszłości LibreOffice nadal będzie dostępny bezpłatnie, zastanów się nad dołączeniem do projektu – zobacz http://www.documentfoundation.org/contribution/ aby dowiedzieć się więcej. Każdy może w jakiś sposób pomóc.

----------------------------------------------------------------------
Uwagi dotyczące instalacji
----------------------------------------------------------------------

LibreOffice wymaga najnowszej wersji środowiska Java Runtime Environment (JRE) dla pełnej funkcjonalności. JRE nie jest częścią pakietu instalacyjnego LibreOffice i powinien być zainstalowana oddzielnie.

Wymagania systemowe
----------------------------------------------------------------------

* Microsoft Windows XP SP3, Vista, 7, 8, lub 10

Do przeprowadzenia instalacji potrzebne są uprawnienia administratora.

Rejestrację systemu LibreOffice jako domyślnej aplikacji do obsługi formatów Microsoft Office można wymusić lub wyłączyć, używając instalatora z następującymi przełącznikami wiersza poleceń:

* REGISTER_ALL_MSO_TYPES=1 zmusi rejestrację LibreOffice jako domyślną aplikację dla formatów Microsoft Office.
* REGISTER_NO_MSO_TYPES=1 wstrzyma rejestrację LibreOffice jako domyślną aplikację dla formatów Microsoft Office.

Należy upewnić się, że jest wystarczająca ilość wolnego miejsca w katalogu tymczasowym oraz, że zostały przyznane uprawnienia odczytu, zapisu i uruchomienia. Przed rozpoczęciem procesu instalacji należy zamknąć inne programy.

Instalacja LibreOffice w systemie Linux opartym o dystrybucję Debian/Ubuntu
----------------------------------------------------------------------

Aby uzyskać instrukcje jak zainstalować pakiet językowy (po instalacji anglojęzycznej wersji LibreOffice), proszę zapoznać się z poniższą sekcją zatytułowaną Instalacja pakietu językowego.

Po rozpakowaniu pobranego archiwum jego zawartość pojawi się w nowym podkatalogu. Należy otworzyć menedżer plików i przejść do katalogu, którego nazwa rozpoczyna się od "LibreOffice_" i w dalszej części zawiera numer wersji i informację o dedykowanej platformie.

Ten katalog zawiera podkatalog o nazwie "DEBS". Zmień katalog na "DEBS".

Kliknij prawym przyciskiem myszy na katalogu i wybierz z menu "Otwórz w Terminalu". Okno terminala otworzy się. W wierszu poleceń należy wpisać następujące polecenie (zostaniesz zapytany o hasło użytkownika root zanim polecenie zostanie wykonane):

Następujące polecenie zainstaluje LibreOffice oraz pakiet integrujący go z pulpitem (zamiast wpisywać je ręcznie, możesz przekopiować polecenie do terminala):

sudo dpkg -i *.deb

Proces instalacji jest teraz ukończony a ikony wszystkich aplikacji LibreOffice powinny być widoczne w menu Programy/Biuro.

Instalacja LibreOffice dla Fedory, openSUSE, Mandrivy i innych dystrybucji Linuksa używających pakietów RPM
----------------------------------------------------------------------

Aby uzyskać instrukcje jak zainstalować pakiet językowy (po instalacji anglojęzycznej wersji LibreOffice), proszę zapoznać się z poniższą sekcją zatytułowaną Instalacja pakietu językowego.

Po rozpakowaniu pobranego archiwum jego zawartość pojawi się w nowym podkatalogu. Należy otworzyć menedżer plików i przejść do katalogu, którego nazwa rozpoczyna się od "LibreOffice_" i w dalszej części zawiera numer wersji i informację o dedykowanej platformie.

Ten katalog zawiera podkatalog nazwany "RPMS". Zmień katalog na "RPMS".

Kliknij prawym przyciskiem myszy na katalogu i wybierz z menu "Otwórz w Terminalu". Okno terminala otworzy się. W wierszu poleceń należy wpisać następujące polecenie (zostaniesz zapytany o hasło użytkownika root zanim polecenie zostanie wykonane):

Dla systemów opartych na dystrybucji Fedora: su -c 'yum install *.rpm'

Dla systemów opartych na dystrybucji Mandriva: sudo urpmi *.rpm

Dla innych systemów opartych na pakietach RPM (openSUSE, itp.): rpm -Uvh *.rpm

Proces instalacji jest teraz ukończony a ikony wszystkich aplikacji LibreOffice powinny być widoczne w menu Programy/Biuro.

Możesz również użyć skryptu 'install' umiejscowionego w najwyższym poziomie folderu archiwum, aby uruchomić instalację jako użytkownik. Skrypt skonfiguruje LibreOffice z własnym profilem, oddzielonym od twojego normalnego profilu LibreOffice. Zauważ, że to nie będzie instalacja elementów integrujących system, takich jak pozycje w menu pulpitu i wpisy w rejestrze MIME.

Uwagi odnośnie integracji z pulpitem dla dystrybucji Linuksa nie uwzględnionych w powyższej instrukcji instalacji
----------------------------------------------------------------------

Instalacja LibreOffice powinna być całkiem łatwa w dystrybucjach Linuksa, które pominięto w tej instrukcji instalacji. Jedyna widoczna różnica może mieć miejsce w integracji z pulpitem.

Katalog RPM (lub odpowiednio DEB) zawiera również pakiet o nazwie libreoffice5.4-freedesktop-menus-5.4.0.1-1.noarch.rpm (lub libreoffice5.4-debian-menus_5.4.0.1-1_all.deb). Jest on przeznaczony dla wszystkich dystrybucji Linuksa które wspierają specyfikacje/rekomendacje Freedesktop.org (http://en.wikipedia.org/wiki/Freedesktop.org) i nie zostały ujęte w niniejszej instrukcji.

Instalacja pakietu językowego
----------------------------------------------------------------------

Należy pobrać pakiet językowy dla odpowiedniego języka i platformy. Pakiety dostępne są w tym samym miejscu co główne archiwum instalacyjne. Za pomocą menedżera plików należy rozpakować pobrane archiwum do katalogu (np. na pulpit). Należy również upewnić się, że żaden z programów pakietu LibreOffice nie jest uruchomiony (łącznie z modułem szybkiego uruchamiania QuickStarter).

Należy przejść do katalogu, gdzie pobrany pakiet językowy został rozpakowany.

Po rozpakowaniu pakietu językowego należy przejść do katalogu który został utworzony. Na przykład, dla francuskiego pakietu językowego dla systemu Debian/Ubuntu 32-bit, nazwa katalogu rozpoczyna się od LibreOffice_ i w dalszej części zawiera numer wersji oraz Linux_x86_langpack-deb_fr.

Następnie udajemy się do katalogu zawierającego pakiety instalacyjne. Dla systemów opartych o dystrybucję Debian/Ubuntu, katalog ten nazywa się DEBS. Dla systemów Fedora, openSUSE i Mandriva katalog ten nazywa się RPMS.

Kliknij prawym przyciskiem myszy na katalogu i wybierz z menu "Otwórz w Terminalu". Okno terminala otworzy się. Aby zainstalować pakiet językowy, w wierszu poleceń należy wpisać następujące polecenie (zostaniesz zapytany o hasło użytkownika root zanim polecenie zostanie wykonane):

Dla systemów bazujących na Debianie/Ubuntu: sudo dpkg -i *.deb

Dla systemów opartych na dystrybucji Fedora: su -c 'yum install *.rpm'

Dla systemów opartych na dystrybucji Mandriva: sudo urpmi *.rpm

Dla innych systemów używających RPM (openSUSE, etc.): rpm -Uvh *.rpm

Uruchom jeden z programów wchodzących w skład LibreOffice - na przykład Writer. Z menu Narzędzia wybierz Opcje. W oknie dialogowym Opcje aktywuj "Ustawienie językowe" i wybierz "Języki". Z listy dla "Interfejs użytkownika" wybierz nowo zainstalowany język. Można zrobić to samo dla "Ustawienia lokalne", "Waluta domyślna" i "Domyślny język dokumentów".

Po zmianie tych ustawień należy nacisnąć przycisk OK. Okno dialogowe zamknie się i zostanie wyświetlona informacja o tym, że dokonane zmiany odniosą skutek dopiero po ponownym uruchomieniu LibreOffice (pamiętaj o zakończeniu działania modułu szybkiego uruchamiania QuickStarter).

Zainstalowany i wybrany język będzie aktywny przy następnym uruchomieniu LibreOffice.

----------------------------------------------------------------------
Problemy podczas uruchamiania programu
----------------------------------------------------------------------

Trudności z uruchomieniem pakietu LibreOffice (np. zawieszanie się aplikacji) oraz problemy z ekranem są często spowodowane przez sterownik karty graficznej. W przypadku wystąpienia tego typu problemów zaktualizuj sterownik karty graficznej lub spróbuj zastosować sterownik karty graficznej dostarczony wraz z systemem operacyjnym. Trudności z wyświetlaniem obiektów 3D często można rozwiązać poprzez dezaktywację opcji "Użyj OpenGL" znajdującej się w katalogu: 'Narzędzia - Opcje - LibreOffice - Widok - Widok 3D'.

----------------------------------------------------------------------
Tabliczki dotykowe w komputerach przenośnych ALPS/Synaptics w Windows
----------------------------------------------------------------------

Z powodu sterownika systemu Windows nie można przewijać dokumentów LibreOffice przesuwając palec po tabliczkach dotykowych komputerów przenoścnych ALPS/Synaptics.

Aby włączyć przewijanie, dodaj następujące linie do pliku konfiguracyjnego "C:\Program Files\Synaptics\SynTP\SynTPEnh.ini" i uruchom ponownie komputer:

[LibreOffice]

FC = "SALFRAME"

SF = 0x10000000

SF |= 0x00004000

Położenie pliku może się różnić w zależności od wersji systemu Windows.

----------------------------------------------------------------------
Skróty klawiaturowe
----------------------------------------------------------------------

W programie LibreOffice mogą być używane tylko te skróty klawiaturowe (kombinacje klawiszy), które nie są używane przez system operacyjny. Jeżeli skrót w programie LibreOffice nie działa w sposób opisany w pomocy LibreOffice, należy sprawdzić, czy nie jest on używany przez system operacyjny. Jeśli tak jest, możesz usunąć ten konflikt, zmieniając skróty używane przez system. Możesz również zmienić niemal każdy skrót używany w produkcie LibreOffice. Więcej informacji na ten temat znajduje się w pomocy do produktu LibreOffice oraz w dokumentacji używanego systemu operacyjnego.

----------------------------------------------------------------------
Problemy podczas wysyłania dokumentów LibreOffice pocztą elektroniczną
----------------------------------------------------------------------

Podczas wysyłania dokumentu poprzez wybranie opcji 'Plik – Wyślij – Dokument jako E-mail' lub 'Dokument jako załącznik PDF' mogą wystąpić problemy (program się zawiesza lub wyłącza). Jest to powodowane przez niektóre wersje pliku systemowego "Mapi" (Messaging Application Programming Interface). Nie jest niestety możliwe sprecyzowanie wersji pliku powodujących problemy. Więcej informacji można znaleźć na stronie http://www.microsoft.com, przeszukując bazę wiedzy Microsoft Knowledge Base pod kątem wiadomości o "mapi dll".

----------------------------------------------------------------------
Ważne uwagi dotyczące dostępności
----------------------------------------------------------------------

Więcej informacji na temat dostępności w LibreOffice można znaleźć pod adresem http://www.libreoffice.org/accessibility/

----------------------------------------------------------------------
Wsparcie użytkownika
----------------------------------------------------------------------

Główna strona wsparcia http://www.libreoffice.org/support/ oferuje różne możliwości pomocy z LibreOffice. Możliwe, że odpowiedź na Twoje pytanie została już napisana - sprawdź Forum Społeczności pod adresem http://www.documentfoundation.org/nabble/ lub przeszukaj archiwum listy mailingowej 'users@libreoffice.org' pod adresem http://www.libreoffice.org/lists/users/. Możesz również wysłać swoje zapytanie na adres users@libreoffice.org. Jeśli chcesz subskrybować listę, wyślij pusty email na adres users+subscribe@libreoffice.org.

Odpowiedzi na Najczęściej Zadawane Pytania (FAQ) dostępne są pod adresem http://www.libreoffice.org/faq/.

----------------------------------------------------------------------
Raport błędów & problemów
----------------------------------------------------------------------

BugZilla jest naszym systemem do raportowania, śledzenia i rozwiązywania błędów, dostępna pod adresem https://bugs.libreoffice.org/. Zachęcamy wszystkich użytkowników do raportowania błędów, jakie mogę pojawić się na poszczególnych platformach. Energiczne raportowanie błędów jest jednym z najważniejszych działań, jakie społeczność użytkowników może wnieść do dalszego rozwoju i poprawyLibreOffice.

----------------------------------------------------------------------
Przyłącz się
----------------------------------------------------------------------

Społeczność LibreOffice odniosłaby wielką korzyść z Twojego aktywnego udziału w rozwoju tego ważnego projektu open source.

Jako użytkownik, jesteś już wartościową częścią procesu rozwojowego i chcielibyśmy zachęcić Cię do podjęcia bardziej aktywnej roli w długoterminowej współpracy ze społecznością. Odwiedź i sprawdź stronę z informacjami o możliwych sposobach współpracy pod adresem http://www.libreoffice.org/contribution/

Jak rozpocząć współpracę?
----------------------------------------------------------------------

Najlepszym sposobem na rozpoczęcie współpracy jest zapisanie się na jedną lub więcej list mailingowych, przeglądanie archiwum i stopniowe zapoznawanie się z tematami tam poruszonymi. Z racji, że kod źródłowy LibreOffice został wydany w Październiku 2000, zakres tematyczny list jest dość obszerny. Gdy będziesz już zdecydowany, jedyne co powinieneś zrobić to wysłać email w którym krótko przedstawisz by następnie wskoczyć na głęboką wodę. Jeśli projekty Open Source nie są Ci obce, sprawdź naszą listę TODO i zobacz czy jest tam coś przy czym chciałbyś pomóc. Więcej informacji pod adresem http://www.libreoffice.org/develop/.

Zapisz się
----------------------------------------------------------------------

Poniżej znajduje się kilka list mailingowych na które możesz się zapisać pod adresem http://www.libreoffice.org/contribution/

* Nowości: announce@documentfoundation.org *zalecana dla wszystkich* (mały ruch)
* Główna lista użytkowników: users@global.libreoffice.org *w łatwy sposób podpatrzysz dyskusję* (duży ruch)
* Marketing: marketing@global.libreoffice.org *beyond development* (coraz cięższy)
* Ogólna lista programistów: libreoffice@lists.freedesktop.org (duży ruch)

Dołączanie do jednego lub więcej projektów
----------------------------------------------------------------------

Możesz mieć znaczący wkład w ten ważny projekt open source, nawet jeśli masz niewielkie doświadczenie w projektowaniu i tworzeniu oprogramowania. Tak, właśnie Ty!

Mamy nadzieję, że jesteś zadowolonym użytkownikiem nowego LibreOffice 5.4 i przyłączysz się do nas w internecie.

Społeczność LibreOffice

----------------------------------------------------------------------
Użyty / Zmodyfikowany kod źródłowy
----------------------------------------------------------------------

Portions Copyright 1998, 1999 James Clark. Portions Copyright 1996, 1998 Netscape Communications Corporation.
