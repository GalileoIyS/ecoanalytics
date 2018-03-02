## Sistema de Información Económica
---

El **Sistema de Información Económica** es una plataforma dirigida a mejorar la capacidad de gestión y operativa de las administraciones públicas. Permite remitir de información, analizar y diseñar indicadores para una apoyar en la gestión económica y fomentar la transparencia y comunicación de las entidades públicas. 

El sistema está compuesto por los siguientes módulos:
* **Módulo de Remisión de información**: Automatiza la captura de fuentes de información (como la remisión de información entre entidades territoriales y supra-territoriales), 
* **Módulo de Analítico**: Permite la manipulación de datos y creación de indicadores para crear indicadores económicos y evaluar distintas entidades territoriales, 
* **Módulo de análisis y visualización**: Permite la generación de informes y la agregación de información para la creación de nuevos indicadores más complejos, 

---

Este respositorio contiene el Módulo Analítico, el cual fue concebido para dar soporte a diversos contextos; y se encuentra actualmente en uso en el [servicio de información DropKeys](http://www.dropkeys.com). Galileo pone a disposición de la comunidad Open Source el módulo analítico como pieza central de la plataforma. Estamos en proceso de extenderla para que se comunique con módulos más extensos aplicados al contexto de información económica y financiera.

![Mapa de Infraestructuras generado a partir de la Encuesta de Infraestructura y Equipamientos Locales (EIEL) ](https://github.com/GalileoIyS/Sistema-de-Informacion-Economica/blob/master/Dropkeys.png)

### Visión

La plataforma web se podrá configurar para facilitar la remisión de datos e información económica de administraciones públicas de cualquier país. Mediante la utilización de indicadores básicos publicados, o a partir de la creación de otros más complejos, permitirá publicar información de forma fácil y rápida. Finalmente, la herramienta permite publicar y analizar información económica a través de los múltiples modos de visualización (gráficos, mapas interactivos...).

Inicialmente, Galileo pone a disposición de la comunidad Open Source un potente módulo analítico como pieza central de la futura plataforma integrada, para su utilización y evolución en el contexto de la información pública y de gobierno abierto, para fomentar la transparencia y la participación ciudadana de diferentes países. Estamos actualmente trabajando en el desarrollo de la plataforma de visualización de datos como proyecto interno que será liberado bajo licenciamiento open source, en la que se plasme el conocimiento y la experiencia del sistema [Sielocal.com](http://www.sielocal.com/). 

Por tanto, como punto de partida, para trabajar en nuestra idea compartimos la plataforma inicial de anlítica, la fue concebida para dar soporte a diversos contextos y se encuentra actualmente en uso en el [servicio de información DropKeys](http://www.dropkeys.com); y extenderla para dotarla de mecanismos más extensos aplicados al contexto de información económica y financiera en sus dimensiones de importación de datos, módulo analítico, así como en la plataforma web de colaboración y los módulos de visualización. 

El código que se presenta es la plataforma inicial a partir de la cual construir la plataforma final, que contará con los siguientes módulos:

 * Importación de múltiples fuentes de datos
 * Módulo Analítico
 * Plataforma Web de Uso, Publicación, Visualización, Remisión y Administración


Como conclusión se podrá disponer de una plataforma capaz de publicar información compleja cruzando, como por ejemplo, a partir de fuentes de datos económicos e información georefrenciada, para llegar a publicar informes complejos como el [Mapa de Infraestructuras](https://www.gobiernodecanarias.org/hacienda/unifica/Transparencia/Mapa/Index) que contiene la información de la Encuesta de Infraestructura y Equipamientos Locales (EIEL) en España cuya finalidad es, según establece el Real Decreto 835/2003, de 27 de junio por el que se regula la cooperación económica del Estado a las inversiones de las entidades locales, "conocer la situación de las infraestructuras y equipamientos de competencia municipal, formando un inventario de ámbito nacional, de carácter censal, con información precisa y sistematizada de los municipios con población inferior a 50.000 habitantes".

![Mapa de Infraestructuras generado a partir de la Encuesta de Infraestructura y Equipamientos Locales (EIEL)](https://github.com/GalileoIyS/ecoanalytics/blob/master/Mapa-GobCan.orgUNIFICA.png "Ejemplo de Automatización de Publicación de Información Económica compleja")

Por otro lado, se muestra un ejemplo de la Automatización de formularios de remisión de información y del portal de gestión asociado. 

![Automatización de Remisión de Información](https://github.com/GalileoIyS/ecoanalytics/blob/master/SistemaInformacionEconomica-AutomatizacionRemisionInformacionPublica.png "Ejemplo de Automatización de Remisión de Información")

### Guía de usuario

#### Modulo de importación, análisis y visualización de información 
Este módulo permite:
 * Transparencia: Utilice nuestro Portal de Transparencia para publicar de forma rápida y sencilla toda aquella información que desee compartir con sus ciudadanos.
 * Periodismo de Datos: Acceda de forma gratuita a nuestra base de datos de indicadores y compruebe cual es la situación actual de la Administración Pública en solo un click de ratón.
 * Gráficas interactivas: Somos expertos en construir gráficos dinámicos utilizando fuentes de datos complejas que ayuden a comprender y analizar dicha información.

Para una descripción completa de lo que es capaz el sistema puede visitar el [servicio Sielocal.com](http://www.sielocal.com/) en donde está implantado. El siguiente video muestra una descripción general de su funcionamiento.

[![Canal Youtube de Sielocal.com](https://img.youtube.com/vi/k4tg07G3_aI/0.jpg)](https://www.youtube.com/watch?v=k4tg07G3_aI)

También puede visitar el canal de [Youttube de Sielocal.com](https://www.youtube.com/user/SIELOCAL/videos) en donde podrá visualizar más videos descriptivos de la plataforma.


#### Módulo Analítico
El módulo analítico permite inicialmente: 
 * **Importar** fuentes de datos de varios tipos para crear indicadores en el sistema.
 * **Definir** e incluir indicadores en una librería propia de indicadores, y en el caso de que no existan, poder crear indicadores desde cero, o crealos a partir de la combinación de los existentes.
 * **Compartir** los indicadores con la comunidad y encontrar y trabajar  con otras personas interesadas en los mismos campos de actuación, para crear conocimiento juntos.
 * **Analizar y Visualizar** gracias a la capacidad que aporta la plataforma en materia de Business Intelligence, generar facilmente cuadros de mando a partir de los indicadores, utilizando potentes gráficos y fórmulas y permitiendo el análisis en periodos de tiempo según nuestras necesidades.

La herramienta permite a cualquier usuario no registrado, acceder a todo el repositorio de indicadores como si de un portal de Big Data se tratase. No obstante, para poder interactuar con los datos, definir sus propios cuadros de mando y representar correlaciones comparativas es necesario estar registrado. De esta manera, el usuario puede añadir nuevos indicadores a su cuenta, hacerlos públicos para que otros usuarios contribuyan con sus datos o simplemente contribuir sobre algún otro indicador público del repositorio.

Si desea obtener más información puede acceder directamente a la siguiente dirección http://www.dropkeys.com/howitworks.aspx en donde verá una demo de la plataforma.

Tambien se proporciona un [manual de usuario](https://github.com/GalileoIyS/ecoanalytics/blob/master/Manual%20de%20usuario.pdf) completo en formato PDF.

### Guía de instalación
---

#### Módulo Analítico
    1. Descargar e instalar la versión Community del Visual Studio (2015 o superior) desde la siguiente dirección: https://www.visualstudio.com/es/vs/community/
    
    2. Instalar la extensión de Visual Studio (GitHub Extension for Visual Studio) para acceder a este repositorio GitHub desde el entorno de programación.
    
    3. Especificar la dirección de este repositorio GitHub y descargarse el proyecto a local. Este proceso puede tardar algunos minutos en función de la velocidad de descarga que tenga contratada.
    
    4. Comprobar que los diferentes proyectos de que consta toda la solución compilan correctamente.
    
    5. Restaurar la base de datos que puede encontrar en este repositorio en un servidor de Base de Datos PostgreSQL 8 o superior. En caso de que no disponga de este SGBDR, puede descargarlo gratuítamente desde la dirección https://www.postgresql.org/
    
    6. Modificar los parámetros de conexión a la base de datos establecidos en el fichero de configuración del proyecto localizado en el web.config del proyecto web. Si la base de datos se encuentra en otro servidor, asegúrese de que es visible y tiene los permisos necesarios para acceder.
    
    7. Ejecutar y probar que todo funciona correctamente.

#### Dependencias y requisitos técnicos
*Descripción de los recursos externos que generan una dependencia para la reutilización de la herramienta digital (librerías, frameworks, acceso a bases de datos y licencias de cada recurso). Es una buena práctica describir las últimas versiones en las que ha sido probada la herramienta digital.*

    Puedes usar este estilo de letra diferenciar los comandos de instalación.

### Cómo contribuir
---
Si quieres contribuir al desarrollo de nuevas clases, añadir funcionalidades o hacer una aplicación adaptada a las necesidades de tu administración, puedes contactarno a través del email galileo@galileoiys.es.

Este software consta de diferentes sistemas creados para diferentes proyectos. Actualmente está en proceso de ser re-empaquetado y ofrecido completo bajo un mismo repositorio.

**Consulta más información sobre nosotros en: http://www.galileoiys.es/**

### Colaboradores
---
Este software ha sido desarrollado gracias a la colaboración de expertos en Gestión Catastral y Representación de Mapas y Motores Geográficos durante más de 30 años por los técnicos de Galileo y numerosos clientes.

### Licencia 
---
[Apache v2](https://www.apache.org/licenses/LICENSE-2.0)

## Sobre Galileo Ingeniera y Servicios 
---


**Galileo Ingeniería y Servicios S.L.** es una empresa tecnológica perteneciente al grupo Maggioli que tiene 30 años de experiencia en consultoría económica y tecnológica para administraciones públicas, especializándose en el desarrollo y modernización de procesos de gestión.

 > en Galileo trabajamos para acompañar y ayudar en la mejora de las administraciones públicas gracias su tecnologías y servicios

Galileo mantiene su foco en:

 > la **modernización de los Procesos de Gestión** de las Administraciones Públicas

 > el **diseño, desarrollo e implantación de Sistemas de Gestión** para las Administraciones Públicas

 > la **implantación de Procesos de Formación y Capacitación** en las Administraciones Públicas para favorecer la autogestión descentralización

Galileo dispone de **[más de 25 productos  y servicios](http://www.galileoiys.es/productos-3/)** que abarcan todo el espectro de necesidades de administraciones públicas en sistemas de gestión municipal, económica y contable, gestión de población y territorial. Durante estos años, Galileo ha dedicado gran parte de sus beneficios a I+D+i con el fin de lograr una mayor evolución en sus productos que y ampliar la satisfacción de sus clientes, logrando ser nombrada **Pyme Innovadora** según la **Dirección General de Innovación y Competitividad, Ministerio de Economía y Competitividad**

Más información de las [entidades con las que hemos colaborado](https://github.com/GalileoIyS/Sistema-de-Informacion-Economica/blob/master/Referencias.md).

Lista con [Referencias y demos de los proyectos de Galileo](https://github.com/GalileoIyS/Sistema-de-Informacion-Economica/blob/master/ReferenciasDemos.md)

*[Noticia sobre Galileo IyS y código abierto](http://www.galileoiys.es/por-que-la-gestion-del-territorio-y-el-acceso-a-la-informacion-son-importantes-para-galileo/)*
