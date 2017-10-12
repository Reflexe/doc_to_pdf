
======================================================================
LibreOffice 5.4 ReadMe
======================================================================


Die aktuelle Version dieser Readme-Datei finden Sie unter http://www.libreoffice.org/welcome/readme.html

Diese Datei enthält wichtige Informationen zur Software LibreOffice. Es wird empfohlen, diese Informationen aufmerksam zu lesen, bevor Sie die Installation starten.

Die LibreOffice-Community ist für die Weiterentwicklung dieser Software zuständig und lädt Sie ein, als Mitglied der Community beizutragen. Falls Sie ein neuer Anwender sind, können Sie sich auf der LibreOffice-Seite umfassend über das LibreOffice-Projekt und die Community um das Produkt informieren. Besuchen Sie http://de.libreoffice.org/.

Ist LibreOffice tatsächlich für jeden Anwender frei?
----------------------------------------------------------------------

LibreOffice darf von jedem frei verwendet werden. Sie können diese Kopie von LibreOffice auf beliebig vielen Computern installieren und für beliebige Zwecke verwenden (einschließlich kommerzielle Nutzung, öffentliche Verwaltung und Bildung). Für weitere Informationen lesen Sie bitte den Lizenztext, der im LibreOffice-Download enthalten ist.

Warum ist LibreOffice für jeden Anwender frei?
----------------------------------------------------------------------

Sie können diese Kopie von LibreOffice kostenlos benutzen, weil einzelne Beitragende und Firmensponsoren die Software entwerfen, entwickeln, testen, übersetzen, dokumentieren, unterstützen, vermarkten und auf verschiedene Weise dazu beitragen, LibreOffice zu dem zu machen, was es heute ist - die führende Open Source Office-Software für Heim- und Firmenanwender.

Wenn Sie diese Anstrengungen würdigen und sicherstellen möchten, dass LibreOffice auch in Zukunft verfügbar sein wird, tragen Sie am besten zum Projekt bei - Lesen Sie http://de.libreoffice.org/community/ für weitere Informationen. Jeder kann einen eigenen Beitrag leisten.

----------------------------------------------------------------------
Hinweise zur Installation
----------------------------------------------------------------------

LibreOffice erfordert eine aktuelle Version von Java Runtime Environment (JRE) für die volle Funktionalität. JRE ist nicht Teil des LibreOffice-Installationspakets, es sollte deshalb separat installiert werden.

Systemvoraussetzungen
----------------------------------------------------------------------

* Microsoft Windows XP SP3, Vista, 7, 8 oder 10

Bitte beachten Sie, dass Administratorrechte für die Installation benötigt werden.

Um die Registrierung von LibreOffice als Standard-Anwendung für Microsoft-Office-Dateiformate zu erzwingen oder zu unterdrücken, verwenden Sie die folgenden Parameter beim Aufruf des Installationsprogramms:

* REGISTER_ALL_MSO_TYPES=1 erzwingt die Registrierung von LibreOffice als Standard-Anwendung für Microsoft Office Dateiformate.
* REGISTER_NO_MSO_TYPES=1 verhindert die Registrierung von LibreOffice als Standard-Anwendung für Microsoft Office Dateiformate.

Bitte stellen Sie sicher, dass genügend freier Speicherplatz im temporären Verzeichnis Ihres Systems vorhanden ist und dass Schreib-, Lese- und Ausführungsrechte gesetzt sind. Schließen Sie alle laufenden Programme, bevor Sie mit der Installation beginnen.

Installation von LibreOffice auf Debian/Ubuntu-basierten Linuxsystemen
----------------------------------------------------------------------

Für Anweisungen, wie Sie ein Sprachpaket installieren (nachdem Sie die US-englische Version von LibreOffice installiert haben), lesen Sie bitte den Abschnitt mit dem Titel Installation eines Sprachpaketes unten.

Wenn Sie das heruntergeladene Archiv entpacken, werden Sie feststellen, dass die Inhalte in ein Unterverzeichnis entpackt wurden. Öffnen Sie einen Dateimanager und wechseln Sie in das Verzeichnis, das mit "LibreOffice_" beginnt, gefolgt von der Versionsnummer und einigen plattformspezifischen Informationen.

Dieses Verzeichnis enthält ein Unterverzeichnis "DEBS". Wechseln Sie in das Verzeichnis "DEBS".

Rechtsklicken Sie innerhalb des Verzeichnisses und wählen Sie "Im Terminal öffnen". Ein Kommandozeilenfenster wird geöffnet. Geben Sie folgende Befehlszeile auf der Kommandozeile ein (Sie werden aufgefordert, das Root-Kennwort einzugeben, bevor das Kommando ausgeführt wird):

Die folgenden Befehle installieren LibreOffice inklusive Desktop-Integration (Sie können sie einfach kopieren und in einen Terminal einfügen, anstatt sie abzutippen):

sudo dpkg -i *.deb

Der Installationsprozess ist jetzt vollständig und es sollten sich Icons für alle LibreOffice-Anwendungen im Bereich Programme/Büroanwendungen des Menüs Ihres Desktops befinden.

Installation von LibreOffice auf Fedora, openSUSE, Mandriva und anderen Linuxsystemen, die RPM-Pakete verwenden
----------------------------------------------------------------------

Für Anweisungen, wie Sie ein Sprachpaket installieren (nachdem Sie die US-englische Version von LibreOffice installiert haben), lesen Sie bitte den Abschnitt mit dem Titel Installation eines Sprachpaketes unten.

Wenn Sie das heruntergeladene Archiv entpacken, werden Sie feststellen, dass die Inhalte in ein Unterverzeichnis entpackt wurden. Öffnen Sie einen Dateimanager und wechseln Sie in das Verzeichnis, das mit "LibO_" beginnt. Danach folgt die Versionsnummer und einige plattformspezifischen Informationen.

Dieses Verzeichnis enthält ein Unterverzeichnis "RPMS". Wechseln Sie in das Verzeichnis "RPMS".

Rechtsklicken Sie innerhalb des Verzeichnisses und wählen Sie "Im Terminal öffnen". Ein Kommandozeilenfenster wird geöffnet. Geben Sie folgende Befehlszeile auf der Kommandozeile ein (Sie werden aufgefordert, das Root-Kennwort einzugeben, bevor das Kommando ausgeführt wird):

Für Fedora-basierte Systeme: su -c 'yum install *.rpm'

Für Mandriva-basierte Systeme: sudo urpmi *.rpm

Für andere RPM-basierte Systeme (openSUSE usw.): rpm -Uvh *.rpm

Der Installationsprozess ist jetzt vollständig und es sollten sich Icons für alle LibreOffice-Anwendungen im Bereich Programme/Büroanwendungen des Menüs Ihres Desktops befinden.

Alternativ können Sie das 'install'-Skript benutzen, welches sich im obersten Verzeichnis dieses Archivs befindet, um eine Installation als ein Benutzer durchzuführen. Das Skript wird LibreOffice so einrichten, dass es ein eigenes Profil für diese Installation hat, welches von Ihrem normalen LibreOffice-Profil getrennt ist. Beachten Sie, dass dies nicht die Systemintegration installieren wird, wie die Desktop-Menüeinträge und die Registrierungen der Desktop-MIME-Typen.

Hinweise bezüglich der Desktopintegration für Linuxdistributionen, die in den Installationshinweisen nicht gesondert betrachtet wurden
----------------------------------------------------------------------

Es sollte recht einfach sein, LibreOffice auf hier nicht spezifisch betrachteten Linux-Distributionen zu installieren. Unterschiede könnten sich hauptsächlich bei der Desktopintegration ergeben.

Das Verzeichnis RPMS (beziehungsweise DEBS) enthält auch ein Paket libreoffice5.4-freedesktop-menus-5.4.0.1-1.noarch.rpm (beziehungsweise libreoffice5.4-debian-menus_5.4.0.1-1_all.deb oder ähnlich). Dieses Paket ist für alle Linuxdistributionen geeignet, welche die Freedesktop.org Spezifikationen/Empfehlungen (http://de.wikipedia.org/wiki/Freedesktop.org) umsetzen, und sollte für alle hier nicht näher betrachteten Linux-Systeme genutzt werden können.

Installation eines Sprachpakets
----------------------------------------------------------------------

Laden Sie das Sprachpaket für die gewünschte Sprache und Plattform herunter. Diese sind am gleichen Ort wie das Basis-Installationspaket verfügbar. Entpacken Sie das heruntergeladene Paket über einen Dateimanager in ein beliebiges Verzeichnis (zum Beispiel auf Ihren Arbeitsplatz). Beenden Sie alle LibreOffice-Anwendungen (einschließlich des Schnellstarters, falls gestartet).

Wechseln Sie in das Verzeichnis, in das Sie das Paket entpackt haben.

Wechseln Sie jetzt in das Verzeichnis, welches durch den Entpackvorgang erzeugt wurde. Für ein deutsches Sprachpaket auf einem 32-bit Debian-basiertem System werden folgende Verzeichnisse erstellt: LibO_ plus, Informationen zur Version und Linux_x86_langpack-deb_de.

Wechseln Sie jetzt in das Verzeichnis, das die zu installierenden Pakete enthält. Auf Debian-/Ubuntu-basierten Systemen ist es das Verzeichnis DEBS. Auf Fedora-, openSuse- oder Mandriva-Systemen ist es RPMS.

Rechtsklicken Sie im Dateimanager im Verzeichnis und wählen "Im Terminal öffnen". Führen Sie in der Eingabeaufforderung den Befehl zum Installieren des Sprachpaketes aus (alle unten aufgeführten Kommandos werden wahrscheinlich nach Ihrem Root-Kennwort fragen):

Für Debian/Ubuntu-basierte Systeme: sudo dpkg -i *.deb

Für Fedora-basierte Systeme: su -c 'yum install *.rpm'

Für Mandriva-basierte Systeme: sudo urpmi *.rpm

Für andere Systeme, die RPM benutzen (openSUSE usw.): rpm -Uvh *.rpm

Starten Sie dann eine der LibreOffice-Anwendungen, zum Beispiel Writer. Wählen Sie das Menü Extras, dann Optionen... Klicken Sie im Dialog Optionen auf "Spracheinstellungen" und dann auf "Sprachen". Klappen Sie die Liste "Benutzeroberfläche" auf und wählen Sie die gerade installierte Sprache aus. Falls gewünscht führen Sie die gleiche Änderung für "Gebietsschema", "Standardwährung" und die "Standardsprachen der Dokumente" durch.

Nachdem Sie diese Einstellungen vorgenommen haben, klicken Sie auf OK. Der Dialog wird geschlossen und Sie sehen einen Hinweis, dass die Änderungen erst nach einem Neustart von LibreOffice übernommen werden (denken Sie daran, auch den Schnellstarter zu beenden, sofern dieser gestartet ist).

Beim nächsten Start von LibreOffice wird es in der gerade installierten Sprache starten.

----------------------------------------------------------------------
Probleme beim Programmstart
----------------------------------------------------------------------

Probleme beim Start von LibreOffice (beispielsweise das Hängenbleiben der Anwendung) oder der Darstellung auf dem Bildschirm sind häufig auf den vom System verwendeten Grafikkartentreiber zurückzuführen. Bitte aktualisieren Sie bei Problemen dieser Art den von Ihnen verwendeten Grafikkartentreiber beziehungsweise verwenden Sie testweise den Standardgrafikkartentreiber Ihres Betriebssystems. Darstellungsprobleme bei 3D-Objekten lassen sich oft auch durch das Abschalten der Option "OpenGL benutzen" unter 'Extras - Optionen... - LibreOffice - Ansicht - 3D-Darstellung' beheben.

----------------------------------------------------------------------
ALPS/Synaptics Notebook-Touchpads unter Windows
----------------------------------------------------------------------

Aufgrund eines Problems im Windows-Treiber können Sie nicht in Ihren LibreOffice-Dokumenten scrollen, indem Sie mit dem Finger über den ALPS/Synaptics-Touchpad fahren.

Um das Scrollen per Touchpad zu ermöglichen, fügen Sie die folgenden Zeilen in die Datei "C:\Programme\Synaptics\SynTP\SynTPEnh.ini" ein und starten dann Ihren Computer neu:

[LibreOffice]

FC = "SALFRAME"

SF = 0x10000000

SF |= 0x00004000

Der Speicherort der Konfigurationsdatei kann je nach Windows-Version abweichen.

----------------------------------------------------------------------
Tastatursteuerung
----------------------------------------------------------------------

In LibreOffice können nur Tastenkombinationen benutzt werden, die nicht vom Betriebssystem verwendet werden. Sollte in LibreOffice eine Tastenkombination nicht wie in der LibreOffice-Hilfe beschrieben funktionieren, muss überprüft werden, ob diese Kombination bereits vom Betriebssystem verwendet wird. Um diesen Konflikt aufzuheben, kann die Belegung des Betriebssystems umdefiniert beziehungsweise aufgehoben werden. Alternativ lässt sich auch in LibreOffice fast jede Tastaturbelegung ändern. Weitere Hinweise zu diesem Thema bieten die LibreOffice-Hilfe sowie die Hilfe des Betriebssystems.

----------------------------------------------------------------------
Probleme beim Versenden von Dokumenten als E-Mail aus LibreOffice
----------------------------------------------------------------------

Wenn ein Dokument per 'Datei - Senden - Dokument als E-Mail' oder 'E-Mail als PDF' versendet wird, können Probleme auftreten (das Programm hängt oder stürzt ab). Das liegt an der Windows-Systemdatei "Mapi" (Messaging Application Programming Interface), welche in einigen Dateiversionen Probleme verursacht. Leider können die Probleme nicht auf eine bestimmte Versionsnummer eingegrenzt werden. Für mehr Informationen besuchen Sie bitte http://www.microsoft.com und suchen in der Knowledge Base nach "mapi dll".

----------------------------------------------------------------------
Wichtige Hinweise zur Barrierefreiheit
----------------------------------------------------------------------

Weiterführende Informationen zur Barrierefreiheit in LibreOffice finden Sie unter http://de.libreoffice.org/get-help/accessibility/.

----------------------------------------------------------------------
Anwenderunterstützung
----------------------------------------------------------------------

Die Seite zur Anwenderunterstützung http://de.libreoffice.org/get-help/community-support/ listet verschiedene Möglichkeiten auf, Hilfe zu LibreOffice zu erhalten. Ihre Frage ist vielleicht schon beantwortet, schauen Sie unter http://de.libreoffice.org/get-help/nabble/ nach oder senden Sie Ihre Fragen an users@de.libreoffice.org.

Lesen Sie auch die FAQs unter http://de.libreoffice.org/discover/faq/.

----------------------------------------------------------------------
Fehler & Probleme melden
----------------------------------------------------------------------

BugZilla ist unser System, um Fehler zu melden, zu verfolgen und zu lösen, und wird unter https://bugs.libreoffice.org/ bereitgestellt. Wir möchten jeden ermutigen, selbst Fehler zu melden, die auf der jeweiligen Plattform auftreten könnten. Das aktive Melden von Fehlern ist einer der wichtigsten Beiträge, den die Anwender-Community machen kann, um die Weiterentwicklung von LibreOffice zu unterstützen.

----------------------------------------------------------------------
Mitmachen - aber wie?
----------------------------------------------------------------------

Für die LibreOffice-Community ist es von hohem Wert, wenn Sie sich aktiv in die Entwicklung dieses bedeutenden Open-Source-Projekts einbringen.

Als Anwender sind Sie bereits ein wertvoller Teil im Entwicklungsprozesses der Office-Suite und wir möchten Sie ermutigen, auch langfristig in der Community mitzuwirken. Schauen Sie auf unseren Seiten unter http://de.libreoffice.org/community/ nach und helfen Sie mit.

Wie anfangen?
----------------------------------------------------------------------

Der einfachste Einstieg ist es, sich auf einer oder auf mehreren Mailinglisten einzuschreiben, eine Weile mitzulesen und in den Mailarchiven die Themen zu lesen, die seit dem Bestehen des LibreOffice-Projektes diskutiert wurden. Sobald Sie sich dazu bereit fühlen, senden Sie eine E-Mail mit einer kurzen Selbstvorstellung und packen direkt mit an. Falls Sie bereits mit Open Source-Projekten vertraut sind, schauen Sie unter http://de.libreoffice.org/community/developers/ nach, ob eine Aufgabe für Sie dabei ist.

Abonnieren von Mailinglisten
----------------------------------------------------------------------

Hier sind einige der Mailinglisten, auf denen Sie sich einschreiben können http://de.libreoffice.org/get-help/mailing-lists/

* Neuigkeiten: announce@de.libreoffice.org - *Für alle Anwender empfohlen* (niedriges Mailaufkommen)
* Benutzerhilfe: users@de.libreoffice.org - *Anwenderunterstützung für LibreOffice* (hohes Mailaufkommen)
* Marketing: marketing@global.libreoffice.org - *LibreOffice bekanntmachen* (hohes Mailaufkommen, englisch)
* Generelle Entwicklerliste: libreoffice@lists.freedesktop.org (hohes Mailaufkommen, Englisch)

Einem oder mehreren Projekten beitreten
----------------------------------------------------------------------

Selbst mit geringen Erfahrungen in Programmierung und Softwaredesign können Sie wichtige Beiträge zu diesem bedeutenden Open-Source-Projekt leisten. Ja, genau Sie!

Wir hoffen, dass Sie Spaß bei der Arbeit mit dem neuen LibreOffice 5.4 haben und sich uns online anschließen.

Die LibreOffice-Community

----------------------------------------------------------------------
Benutzter / Modifizierter Quelltext
----------------------------------------------------------------------

Teile des Copyright 1998, 1999 James Clark. Teile des Copyright 1996, 1998 Netscape Communications Corporation.
