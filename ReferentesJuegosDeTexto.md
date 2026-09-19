Tarea: Referentes de Text Adventure y mecánicas

1. Referentes seleccionados
Juego 1: Las Minas de Socartes
Año: 2019
Autor: Billy Y. Fernández / Textagames
Descripción: Es una aventura de texto basada en la novela Marianela de Benito Pérez Galdós. El jugador controla a Teodoro Golfín y puede interactuar con el mundo mediante acciones como mirar, examinar, ir, hablar, coger, dar, usar e inventario.

Juego 2: El Horror de Chambertown
Año: 2022
Autora: Florencia C. Wagemann
Descripción: Según su descripción web, esta es una narrativa hipertextual interactiva inspirada en H. P. Lovecraft, el horror cósmico y el cine de terror de los años 80. Utiliza decisiones y diferentes recorridos narrativos, y cuenta con múltiples finales.

2. Mecánicas identificadas
En los dos juegos seleccionados identifiqué las siguientes mecánicas:
•	Comandos o acciones
•	Objetos e inventario con condiciones
•	Decisiones y ramificaciones
•	Consecuencias a largo plazo

3. Descripción detallada de las mecánicas
•	Mecánica 1: Comandos o acciones
En Las Minas de Sócrates el jugador tiene la posibilidad de escribir comandos simples para interactuar con el mundo, estas acciones pueden ser mirar, examinar, ir, hablar, coger, dar, usar y inventario. Cada comando nos permite interactuar y obtener respuestas distintas en el juego.
La condición principal es que comando escribe el jugador. Pero el juego revisa el contexto: no es lo mismo escribir examinar cuando estás frente a una puerta que cuando estás frente a un personaje. Algunos comandos solo funcionan si hay un objeto o una situación específica presente.
El juego responde con un texto que describe el resultado. Si el comando es válido, el mundo cambia y permite continuar la aventura (se abre una puerta, aparece un objeto, avanza la historia). Si no es válido, el juego muestra un mensaje de error/acción no valida y el jugador debe intentar otra cosa.
Las mecánicas dependen de una decisión del jugador (qué comando escribe) combinada con una condición previa (qué hay en el entorno o qué objetos tiene). Es una mecánica compuesta.

•	Mecánica 2: Objetos e inventario con condiciones
En Las Minas de Socrates el jugador puede encontrar objetos, recogerlos con el comando coger, guardarlos en su inventario y usarlos después con el comando usar. También puede darlos a otros personajes con el comando dar.
Para que una acción funcione, el juego revisa si el jugador tiene el objeto necesario en el inventario. Por ejemplo: para abrir una puerta se necesita una llave; para dar un objeto a un personaje, primero hay que haberlo recogido y por tanto tenerlo en el inventario.
Si el jugador tiene el objeto y decide usarlo, la acción se ejecuta y el mundo cambia (la puerta se abre, el personaje reacciona, se desbloquea una nueva zona). Si no lo tiene, el juego responde con un mensaje indicando que no puede hacer eso o no tiene el objeto necesario.
Esta mecánica depende de un objeto y de una decisión del jugador, el ejemplo mas básico es el de encontrar una puerta cerrada Examinar el entorno- Encontrar la llaveRecoger la llave Usar la llaveAbrir la puerta

•	Mecánica 3: Decisiones y ramificaciones
En El Horror de Chambertown el jugador llega a puntos donde debe elegir entre dos o más opciones. Al elegir, la historia avanza por un camino distinto.
La condición principal es la decisión del jugador. Pero, algunas decisiones disponibles dependen de lo que el jugador haya hecho antes: si ya visitó cierto lugar, si habló con cierto personaje, o si ya tomó una decisión previa.
Cada decisión lleva a un camino narrativo distinto. Las decisiones se van acumulando y al final determinan cuál de los múltiples finales se desbloquea. Dos jugadores que eligen distinto pueden terminar en finales completamente diferentes.
Esta mecánica depende de una decisión del jugador combinada con condiciones previas (decisiones anteriores)

•	Mecánica 4: Consecuencias a largo plazo
El jugador toma decisiones que parecen pequeñas en el momento, pero que más adelante cambian la situación. Esto pasa tanto en Las Minas de Socrates como en El Horror de Chambertown.
La condición es que decisión tomo antes el jugador, esta queda guardada internamente en el juego. Más adelante, el juego consulta esa información para decidir qué mostrar o qué opciones darnos.
Con esta mecánica aparecen opciones nuevas, se cierran caminos, o se desbloquea un final distinto. En El Horror de Chambertown esto es clave: los múltiples finales dependen del acumulado de decisiones. En Las Minas de Sócrates, haber cogido o no cierto objeto antes puede determinar si puedes avanzar más adelante.
Esta mecánica depende de una combinación de decisiones previas y del estado actual del jugador. Es la mecánica más compleja de programar porque requiere guardar el historial de lo que hizo el jugador.

4. Reflexión final
Estas mecánicas se pueden pensar como variables y condiciones en programación:
Comandos o acciones: se pueden implementar con if/else o switch que evalúan qué escribió el jugador y por tanto que decisiones tomo o que tiene en el inventario.
Objetos e inventario: se pueden implementar con arrays que guardan los objetos, y condiciones, además de if que revisan si el objeto está presente.
Decisiones y ramificaciones: se pueden implementar con if/else o switch que evalúan la opción elegida.
Consecuencias a largo plazo: se pueden implementar con variables bool que recuerdan si una acción ya ocurrió, y que se consultaran más adelante.
