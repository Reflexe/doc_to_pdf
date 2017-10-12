
======================================================================
Ficheiro Léame do LibreOffice 5.4
======================================================================


Para ver as actualizacións máis recentes deste ficheiro, vexa http://www.libreoffice.org/welcome/readme.html

Este ficheiro contén información importante sobre o software LibreOffice. Recoméndaselle ler atentamente esta información antes de comezar a instalación.

A comunidade de LibreOffice é responsábel do desenvolvemento deste produto, e invítao a participar nel. Se é un novo usuario pode visitar o sitio de LibreOffice no cal poderá atopar moita información sobre o proxecto LibreOffice e as comunidades que existen ao seu arredor. Vaia a http://www.libreoffice.org/.

LibreOffice é realmente libre para calquera usuario?
----------------------------------------------------------------------

LibreOffice é de uso libre para todos. Pode utilizar esta copia de LibreOffice para instalala en todos os computadores que desexe, e utilizala para calquera propósito que teña (o que inclúe a utilización comercial, gobernamental, na Administración pública e na educación). Para máis detalles, consulte o texto da licenza incluída na descarga de LibreOffice.

Por que LibreOffice é libre para todas as persoas?
----------------------------------------------------------------------

Pode utilizar esta copia de LibreOffice libre de cargas grazas a persoas que colaboran individualmente e a entidades financiadores que deseñaron, traduciron, documentaron, apoiaron, promoveron e axudaron de moitas outras formas para facer de LibreOffice o que ela é hoxe - a mellor suite do mundo de programas de produtividade ofimática de código aberto tanto para uso persoal como profesional.

Se aprecia os esforzos e lle gustaría que a LibreOffice continúe dispoñíbel no futuro, considere facer a súa contribución co proxecto - para máis detalles vexa http://www.documentfoundation.org/contribution/. Todo o mundo pode contribuír dalgunha maneira.

----------------------------------------------------------------------
Notas sobre a instalación
----------------------------------------------------------------------

O LibreOffice require unha versión recente do Java Runtime Environment (JRE) para unha funcionalidade completa. O JRE non é parte do paquete de instalación do LibreOffice, debe instalarse á parte.

Requisitos do sistema
----------------------------------------------------------------------

* Microsoft Windows XP SP3, Vista, 7, 8, or 10

Advírtese de que cómpre ter dereitos de administrador para o proceso de instalación.

O rexistro de LibreOffice como o aplicativo predeterminado para os formatos de Microsoft Office pódese forzar ou eliminar usando os seguintes modificadores co instalador na liña de ordes:

* REGISTER_ALL_MSO_TYPES=1 forzará o rexistro da LibreOffice como aplicativo predeterminado para os formatos Microsoft Office.
* REGISTER_NO_MSO_TYPES=1 suprimirá o rexistro da LibreOffice como aplicativo predeterminado para os formatos da Microsoft Office.

Asegúrese de que hai espazo abondo no cartafol temporal do seu sistema e de que ten permisos de lectura, escritura e execución. Peche calquera outro programa antes de iniciar o proceso de instalación.

Instalación da LibreOffice en sistemas Linux baseados en Debian/Ubuntu
----------------------------------------------------------------------

Para obter instrucións sobre como instalar un paquete de idioma (despois de ter instalada a versión en inglés US de LibreOffice), lea a sección seguinte titulada Instalación dun paquete de idioma.

Cando desempaquete o arquivo descargado verá que o contido se descomprimiu nun subcartafol. Abra unha xanela do xestor de ficheiros e vaia ao cartafol que comeza por «LibreOffice_», seguido polo número de versión e algún tipo de información sobre a plataforma.

Este cartafol contén un subcartafol chamado «DEBS». Entre no cartafol «DEBS».

Prema sobre o botón dereito do rato e seleccione "Abrir un terminal". Abrirase unha xanela do terminal. Na liña de ordes da xanela do terminal, escriba a seguinte orde (preguntaráselle previamente polo seu contrasinal de usuario root antes de que se execute a orde):

As seguintes ordes instalarán LibreOffice e os paquetes para a integración no escritorio (pode simplemente copialas e pegalas na pantalla do terminal antes que tentar escribilas):

sudo dpkg -i *.deb

O proceso de instalación completouse e xa debería ter as iconas para todos os aplicativos da LibreOffice no seu menú Aplicativos/Ofimática.

Instalación de LibreOffice en Fedora, Suse, Mandriva e outros sistemas Linux que usan paquetes RPM
----------------------------------------------------------------------

Para obter instrucións sobre como instalar un paquete de idioma (despois de ter instalada a versión en inglés US de LibreOffice), lea a sección seguinte titulada Instalación dun paquete de idioma.

Cando desempaquete o arquivo descargado, verá que o contido se descomprimiu nun subcartafol. Abra unha xanela do xestor de ficheiros e vaia ao cartafol que comeza por «LibreOffice_», seguido polo número de versión e algún tipo de información sobre a plataforma.

Este cartafol contén un subcartafol chamado "RPMS". Cámbiese ao cartafol "RPMS".

Prema sobre o botón dereito do rato e escolla «Abrir un terminal». Abrirase unha xanela do terminal. Na liña de ordes da xanela do terminal, escriba a seguinte orde (preguntaráselle previamente polo seu contrasinal de usuario root antes de que se execute a orde):

Para sistemas Fedora: su -c 'yum install *.rpm'

Para sistemas Mandriva: sudo urpmi *.rpm

Para os demais sistemas RPM (openSuse, etc.): rpm -Uvh *.rpm

O proceso de instalación completouse e xa debería ter as iconas para todos os aplicativos da LibreOffice no seu menú Aplicativos/Ofimática.

Alternativamente, pode utilizar o script de instalación «install» existente no cartafol superior deste arquivo para instalar como usuário. O script configurará o LibreOffice co seu perfil, sen interferir co perfil normal de LibreOffice. Saiba que así non instalará as partes de integración no sistema tales como menús de escritorio e os rexistros de escritorio de tipos MIME.

Notas sobre a integración do escritorio para distribucións Linux non mencionadas nas instrucións de instalación anteriores
----------------------------------------------------------------------

Debería ser doado instalar LibreOffice noutras distribucións Linux non especificadas nestas instrucións de instalación. O principal aspecto das diferenzas podería estar na integración co escritorio.

O directorio de RPM (ou DEB, segundo corresponda) tamén contén un paquete chamado libreoffice5.4-freedesktop-menus-5.4.0.1-1.noarch.rpm (ou libreoffice5.4-debian-menus_5.4.0.1-1_all.deb (ou libreoffice5.4-debian-menus_5.4.0.1-1_all.deb, respectivamente, ou semellante). Consiste nun paquete para todas as distribucións que admiten as especificacións do Freedesktop.org (http://en.wikipedia.org/wiki/Freedesktop.org), e fornécese para permitir a instalación noutras distribucións de Linux non cubertas nas instrucións denanteriores.

Instalación dun paquete de idioma
----------------------------------------------------------------------

Descargue o paquete de idioma do idioma, país e plataforma desexado. Están dispoñíbeis no mesmo lugar do arquivo de instalación principal. Dentro do xestor de ficheiros Nautilus, extraia o arquivo descargado nun cartafol (no seu escritorio, por exemplo). Asegúrese de ter saído de todos os aplicativos da LibreOffice (incluíndo o Iniciador rápido, caso de se estar executando).

Cámbiese ao cartafol no que extraeu o paquete de idioma descargado.

Cámbiese ao cartafol que se creou durante o proceso de extracción. Por exemplo, para o paquete de idioma galego dun sistema Debian ou Ubuntu de 32 bits, o cartafol chámase LibreOffice_, máis a información sobre a versión, seguido por Linux_x86_langpack-deb_gl.

Agora, cámbiese ao cartafol que contén os paquetes para instalar. Nos sistemas baseados en Debian ou Ubuntu, o cartafol chámase DEBS. Nos sistemas Fedora, openSuse ou Mandriva, o cartafol chámase RPMS.

Desde o xestor de ficheiros Nautilus, prema o botón dereito no cartafol e escolla a orde «Abrir nun terminal». Na xanela do terminal que se acaba de abrir, execute a orde de instalar o paquete de idioma (en todas as ordes seguintes, solicitaráselle escribir o contrasinal do usuario root):

Para sistemas Debian/Ubuntu: sudo dpkg -i *.deb

Para sistemas Fedora: su -c 'yum install *.rpm'

Para sistemas Mandriva: sudo urpmi *.rpm

Para outros sistemas RPM (openSuse, etc.): rpm -Uvh *.rpm

Inicie agora un dos aplicativos da LibreOffice - por exemplo o Writer. Vaia ao menú Ferramentas - Opcións. Na caixa de diálogo de Opcións, prema en «Configuración de idioma» e prema en «Idiomas». Na lista «Interface de usuario» seleccione o idioma que acaba de instalar. Se quere, faga o mesmo coas «Configuración local», a «Moeda predeterminada», e «Idiomas predeterminados para documentos».

Despois de axustar esa configuración, prema en Aceptar. O cadro de diálogo cerrarase, e verá unha mensaxe informativa que avisa de que os cambios se activarán despois de saír da LibreOffice e de volvela iniciar (tamén se deberá cerrar o inicio rápido, se estivese en execución).

A próxima vez que incie LibreOffice, arrincará no idioma que acaba de instalar.

----------------------------------------------------------------------
Problemas ao iniciar o programa
----------------------------------------------------------------------

Os problemas ao iniciar LibreOffice (p.ex. aplicativos colgados) ou os problemas coa presentación en pantalla adoitan ser debidos aos controladores da tarxeta gráfica. Se ocorre este problema, actualice os controladores da súa tarxeta gráfica ou trate de usar os controladores que se lle entregaron co sistema operativo. As dificultades para presentar obxectos 3D adoitan solucionarse desactivando a opción «Usar OpenGL» no menú «Ferramentas - Opcións - LibreOffice - Ver - Visualización 3D».

----------------------------------------------------------------------
Superficies sensíbeis ALPS e Synaptics de notebooks en Windows
----------------------------------------------------------------------

Debido a un problema cos controladores de Windows, non é posíbel desprazar documentos a través de LibreOffice pasando o dedo por unha superficie sensíbel ALPS ou Synaptic.

Para activar a súa superficie sensíbel, engada as liñas que se indican á ruta de configuración "C:\Program Files\Synaptics\SynTP\SynTPEnh.ini" e despois reinicie o seu computador:

[LibreOffice]

FC = "SALFRAME"

SF = 0x10000000

SF |= 0x00004000

Obs.: A localización do ficheiro de configuración pode variar segundo as diferentes versións de Windows.

----------------------------------------------------------------------
Teclas de atallo
----------------------------------------------------------------------

As únicas teclas de atallo (combinacións de teclas) que se poden utilizar en LibreOffice son aquelas non utilizadas polo sistema operativo. Se algunha combinación de teclas non funciona en LibreOffice conforme se describe na Axuda de LibreOffice, comprobe se o sistema operativo xa usa ese atallo. Para corrixir eses conflitos, mude as teclas asignadas polo seu sistema operativo. Alternativamente, modifique as asignacións de teclas de LibreOffice. Para obter máis información sobre este asunto, consulte a Axuda de LibreOffice ou a documentación de axuda do seu sistema operativo.

----------------------------------------------------------------------
Problemas no envío de documentos como correo electrónico desde LibreOffice
----------------------------------------------------------------------

Ao enviar documentos a través de 'Ficheiros – Enviar documento como correo electrónico' ou 'Correo electrónico como PDF' poden xurdir problemas (por exemplo, o bloqueo do programa). Isto débese a que o ficheiro MAPI (Messaging Application Programming Interface) de Windows causa problemas nalgunhas das súas versións. Desgraciadamente, o problema non se pode restrinxir a unha versión determinada. Para máis información, visite http://www.microsoft.com para buscar "mapi dll" en Microsoft Knowledge Base.

----------------------------------------------------------------------
Notas importantes de accesibilidade
----------------------------------------------------------------------

Para obter máis información sobre as características de accesibilidade de LibreOffice consulte http://www.libreoffice.org/accessibility/

----------------------------------------------------------------------
Asistencia do usuario
----------------------------------------------------------------------

A páxina principal de asistencia en http://www.libreoffice.org/support/ ofrece diversas posibilidades de axuda sobre LibreOffice. A súa dúbida poida que xa fose contestada - consulte o foro da comunidade en http://www.documentfoundation.org/nabble/ ou busque no arquivo da lista de correo «users@libreoffice.org» en http://www.libreoffice.org/lists/users/ . Tamén pode enviar unha pregunta a users@libreoffice.org. De querer subscribirse á lista (para obter resposta a unha pregunta) envíe un correo electrónico baleiro a: users+subscribe@libreoffice.org.

Consulte tamén a sección FAQ en http://www.libreoffice.org/faq/.

----------------------------------------------------------------------
Informar de fallos & incidencias
----------------------------------------------------------------------

O noso sistema de informes, seguimento e solución de erros é o BugZilla, xentilmente hospedado en https://bugs.libreoffice.org/. Convidamos a todos os usuarios a informaren de erros que poidan ter aparecido na súa plataforma particular. O decidido informe de erros é unha das máis importantes colaboracións da comunidade de usuarios para o desenvolvemento continuado e mellora do LibreOffice.

----------------------------------------------------------------------
Participación
----------------------------------------------------------------------

A Comunidade LibreOffice sairía moi beneficiada da súa participación activa no desenvolvemento deste importante proxecto de software libre.

Como usuario, xa é parte valiosa do proceso de desenvolvemento da suite e gustaríanos convidalo a ter un papel máis activo co fin de converter a súa participación en colaboración de longo prazo coa comunidade. Únase á nosa comunidade e consulte a páxina de colaboracións en http://www.libreoffice.org/contribution/

Como comezar
----------------------------------------------------------------------

A mellor maneira de colaborar é subscribirse a unha ou máis de nosas listas de correo, observar durante algún tempo e gradualmente utilizar os arquivos de correo para se familiarizar cos varios temas abordados desde que o código fonte da LibreOffice foi liberado en outubro de 2000. Se estiver familiarizado cos proxectos de código aberto, consulte a nosa lista de tarefas por facer e vexa se hai algo no que lle interese axudar http://www.libreoffice.org/develop/.

Subscribirse
----------------------------------------------------------------------

Aquí se detallan algunha das listas de correo ás que se pode subscribir en http://www.libreoffice.org/contribution/

* Novas: announce@documentfoundation.org *recomendada para todos os usuarios* (tráfico leve)
* Lista principal de usuarios: users@global.libreoffice.org *un xeito fácil de seguir as discusión* (tráfico intenso)
* Proxecto de Mercadotecnia: marketing@global.libreoffice.org *alén do desenvolvemento* (tráfico en aumento)
* Lista xeral de desenvolvedores: libreoffice@lists.freedesktop.org (tráfico pesado)

Unirse a un ou máis proxectos
----------------------------------------------------------------------

Pode facer grandes contribucións a este proxecto de software libre mesmo sen ter moita experiencia con manexo do código ou co deseño de software. Si, vostede mesmo!

Esperamos que aprecie traballar co novoLibreOffice 5.4 e que se una a nós en liña.

A comunidade LibreOffice

----------------------------------------------------------------------
Código fonte usado / modificado
----------------------------------------------------------------------

Partes dos dereitos de autor pertencen a James Clark do 1998 ao 1999. Partes dos dereitos de autor pertencen a Netscape Communications Corporation do 1996 a 1998.
