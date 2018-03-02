## Sistema de Información Económica
---

El **Sistema de Información Económica** es una plataforma dirigida a mejorar la capacidad de gestión y operativa de las administraciones públicas. Permite remitir de información, analizar y diseñar indicadores para una apoyar en la gestión económica y fomentar la transparencia y comunicación de las entidades públicas. 

El sistema está compuesto por los siguientes módulos:
* **Módulo de Remisión de información**: Automatiza la captura de fuentes de información (como la remisión de información entre entidades territoriales y supra-territoriales), 
* **Módulo de Analítico**: Permite la manipulación de datos y creación de indicadores para crear indicadores económicos y evaluar distintas entidades territoriales, 
* **Módulo de análisis y visualización**: Permite la generación de informes y la agregación de información para la creación de nuevos indicadores más complejos, 

---

Este respositorio contiene el Módulo Analítico, el cual fue concebido para dar soporte a diversos contextos. Se encuentra actualmente en uso en el [servicio de información DropKeys](http://www.dropkeys.com). Este módulo permite: 
 * **Importar** fuentes de datos de varios tipos para crear indicadores en el sistema.
 * **Definir** e incluir indicadores en una librería propia de indicadores, y en el caso de que no existan, poder crear indicadores desde cero, o crealos a partir de la combinación de los existentes.
 * **Analizar y Visualizar** indicadores para generar cuadros de mando con indicadores personalizados.

### Visión

Actualmente los módulos se encuentran desarrollados e implementados en diferentes sistemas:

* **Módulo de Remisión de información**: Implementado en el sistema de remisión de información del Gobierno de Canarias. (Ver resultados en el [Mapa de Información de Canarias]( https://www.gobiernodecanarias.org/hacienda/unifica/Transparencia/Mapa/Index)) *Más información en [esta presentación](https://prezi.com/ojoqxrp2ygdv/unifica-captura/?utm_campaign=share&utm_medium=copy)

* **Módulo de Analítico**: Utilizado en el servicio de información [Dropkeys](http://www.dropkeys.com).

* **Módulo de análisis y visualización**: Implantado en la [Federación Colombiana de Municipios](http://colombia.sielocal.com/), Gobierno de Canarias o en el [Sistema de Información Económica Local](sielocal.com) (con indicadores económicos de **más de 10 pases de LATAM**). *Más información en [este video](https://www.youtube.com/watch?v=k4tg07G3_aI)

Galileo pone a disposición de la comunidad Open Source el módulo analítico como pieza central del Sistema de Información Económica. Esperamos que su utilización y evolución en el contexto de la información pública y de gobierno abierto, con el fin de fomentar la transparencia y la participación ciudadana.

![Mapa de Infraestructuras generado a partir de la Encuesta de Infraestructura y Equipamientos Locales (EIEL)](https://github.com/GalileoIyS/Sistema-de-Informacion-Economica/blob/master/Mapa%20UNIFICA.png "Ejemplo de Automatización de Publicación de Información Económica compleja")

Ejemplo de la Automatización de formularios de remisión de información: 

![Automatización de Remisión de Información](https://github.com/GalileoIyS/Sistema-de-Informacion-Economica/blob/master/Creacion%20indicadores.png "Ejemplo de Automatización de Remisión de Información")

### Guía de usuario
Ver el [manual de usuario](https://github.com/GalileoIyS/Sistema-de-Informacion-Economica/blob/master/Manual%20de%20usuario.pdf) completo en formato PDF.

### Guía de instalación
---

#### Módulo Analítico
    1. Instalar la versión Community del Visual Studio (2015 o superior): https://www.visualstudio.com/es/vs/community/
    
    2. Instalar la extensión de Visual Studio (GitHub Extension for Visual Studio) para acceder a este repositorio GitHub desde el entorno de programación.
    
    3. Especificar la dirección de este repositorio GitHub y descargarse el proyecto a local. Este proceso puede tardar algunos minutos en función de la velocidad de descarga que tenga contratada.
    
    4. Comprobar que los diferentes proyectos de que consta toda la solución compilan correctamente.
    
    5. Restaurar la base de datos que puede encontrar en este repositorio en un servidor de Base de Datos PostgreSQL 8 o superior. En caso de que no disponga de este SGBDR, puede descargarlo gratuítamente desde la dirección https://www.postgresql.org/
    
    6. Modificar los parámetros de conexión a la base de datos establecidos en el fichero de configuración del proyecto localizado en el web.config del proyecto web. Si la base de datos se encuentra en otro servidor, asegúrese de que es visible y tiene los permisos necesarios para acceder.
    
    7. Ejecutar y probar que todo funciona correctamente.

#### Dependencias y requisitos técnicos
*Descripción de los recursos externos que generan una dependencia para la reutilización de la herramienta digital (librerías, frameworks, acceso a bases de datos y licencias de cada recurso). Es una buena práctica describir las últimas versiones en las que ha sido probada la herramienta digital.*

    Puedes usar este estilo de letra diferenciar los comandos de instalación.

**Consulta más información sobre nosotros en: http://www.galileoiys.es/**

### Colaboradores
---
Este software ha sido desarrollado gracias a la colaboración de expertos en Gestión Catastral y Representación de Mapas y Motores Geográficos durante más de 30 años por los técnicos de Galileo y numerosos clientes.

### Licencia 
---
[Apache v2](https://github.com/GalileoIyS/Sistema-de-Informacion-Economica/blob/master/LICENSE)

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
