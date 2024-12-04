React App News

Una aplicación creada con React que consume una API para mostrar noticias. Permite filtrar noticias por categorías y realizar búsquedas de contenido específico.

Características

    Muestra noticias en tiempo real utilizando NewsData.io API.
    Filtrado de noticias por categorías como Negocios, Entretenimiento, Salud, Ciencia, Deportes y Tecnología.
    Búsqueda personalizada de noticias por palabras clave en los títulos.
    Diseño responsivo y moderno, utilizando TailwindCSS y animaciones con framer-motion.

Tecnologías Utilizadas

    Frontend: React
    Estilo: TailwindCSS, DaisyUI, SASS
    Animaciones: animate.css, framer-motion
    Gestión de estado: Hooks (useState, useEffect)
    Construcción: Vite
    Linter: ESLint
    API: NewsData.io

Instalación y Configuración
Prerrequisitos

    Node.js 16+ instalado en tu sistema.

Pasos de Instalación

    Clona el repositorio:

git clone https://github.com/Kenkyoo/react-app-news.git
cd react-app-news

Instala las dependencias:

npm install

Configura la API Key:

    Obtén una API Key de NewsData.io.
    Reemplaza la clave pub_534696ba6dd08e675da4b35891446954221b0 en el archivo de código con tu propia clave.

Inicia el servidor de desarrollo:

npm run dev

Accede a la aplicación en tu navegador:

    http://localhost:5173

Uso

    Selecciona una categoría en el menú desplegable para filtrar noticias.
    Escribe una palabra clave en la barra de búsqueda para buscar noticias relevantes.
    Visualiza los resultados en forma de tarjetas con información detallada.

Scripts Disponibles

    npm run dev: Inicia el servidor de desarrollo.
    npm run build: Genera la versión de producción.
    npm run preview: Previsualiza la versión de producción.
    npm run lint: Analiza el código en busca de errores o problemas de estilo.

Contribuciones

Las contribuciones son bienvenidas. Si deseas agregar nuevas características, mejorar el código o solucionar problemas, por favor abre un pull request.
Licencia

Este proyecto está bajo la Licencia MIT. Consulta el archivo LICENSE para más detalles.
