# Proyecto de Programacion
>Breve Recuento de la Creacion del Trabajo

Con el objetivo de completar nuestro proyecto de domino nos propusimos como paso inical,la creacion de un programa funcional y simple que simulara un partido de domino, una vez creado
 el programa se utilizo como estructura principal  para nuestro proyecto. Durante el proceso de creacion fuimos notando que existian partes del programa que representaban simillitudes
  en sus objetivos por lo que podian se agrupadas en un mismo cojunto que representara estas similitud diferenciandolos nada mas por sus peculiaridades. Uno de nuestro primero cambios
   al primer programa fue la creacion de una de nuestra clases principales del proyecto principal "Game Rules" con esta case tuvimos el objetivos de lograr un punto de control de todo
    el desarrollo de las futuras interfaces que implementarios al tener todo este proceso de implementacion por solo una entidad excluyendo asi futuros problemas a la hora de 
	modificacion y adaptacion del proyecto. Dentro de esta clase se fue implementando paulativamnete diversas interfaces que describian un comportamiento en particular de nuestro simulador de domino el cual podia ser variado , modificado o alterado en fechas posteriores. Entre ellos podemos mencionar "IValidateMove"  como su nombre lo indica se encarga de definir cuando se puede considerar validada una jugada, al inicio pensabamos en mantener variable esta informacion pero despues de dialogar entre nosotros y consultar la opnion de otros companeros pensamos que no siempre podemos tener nuestra perspectiva en lo que es comunmente conocido a cambiar pues al igual que nuestro actual condicion de vida que nos da sorpresas en cada  momento debemos poder adaptarnos y reaccionar estos cambios constantes por ellos decimos incluir esta variacion ademas de otras mas peculiares como la posiblidad de definir la caras de las ficas con las que se jugara pues aunque se concoe que el domino se juega con numeros quien dice que alguien no desea probar jugar uno con los nombres de su familia como caras jejejje.
Aunque debo de aclarar que el  proyecto final aun si acepta la ediccion de la cara de las fichas este seguira trabajando bajo un sistema de numero por lo que se le asignaria valor 0, esto como muchos se darian cuenta provocaria problemas pero solo, dando un informe de aviso al informa de la situaccion, claro esta que aunque actualmente no acepta un sistema para definir un valor particular a palabras puede ser incluido en caso que fuera deseado. Continuando con la historia de nuestro proyecto se incluyeron ademas interfaces que permiten variar detalles como el resultado fial de la simulacion al defnir  diversas maneras en el que este puede ser declarado , dando como ejemplo el modo normal de suma de puntos de cada equipo.  Tambien esta el metodo para declarar la finalizacion del  partido , el metodo que define el orden en que juegan los participantes y el que declara el valor de cada ficha. Estos fueron los diversos comportamiento que definimos  como posibles informacion mutable. Tambien esta la creacion de nuestros jugadores estos lo hicimos de tal modo  que funcionen si la necesidad de saber nada sobre el funcionamiento de las reglas del juego. Siendo la unica informacion que los reaciona con la mismas la cantidad de jugadores que existen. Entre otras de las clases  importantes esta "EstadoBase" que rige el desarrollo de la simulacion al cambiar las diferentes acciones de cada jugar o ficha en dependencia de la circunstancias, actualiza el tablero y cambia las fichas que tiene cada jugador. regulando constantemente el juego y guardando cada jugada o suceso en un registro el cual puede ser usado poteriormente en cualquier necesidad. Tenemos nuestra clase encargada de regular todo el comportamiento de  las fichas esta en un principio se creo como una interface de la cual heredaban tres clases que definian una jugada , un pase o la jugada incial. pero despues de ver que existian incogruencia en este metodo, pues su implementacion era ineficiente . se decidio la creacion de una clase con tres constructores que regulan los cambios antes mencionados. Ademas del desarrollo de la parte logica o backend, tambien estuvo el desarrolo del frontEnd o interfaz grafica, aqui se debe hacer enfasis que se paso mucho rabajo en un principio para lograr el solo hecho de seleccionar una plataforma visual que permitiera desarrollar lo deseado pues  en un pricipio solo teniamos conocimiento de windowForm pero al trabajar en un sistema operativo incompatible con la app tuvimos que indagar en diferen soluciones. se nos recomendo platafomas de paginas web pero para poder aprender de las misma solo podiamos descargar videos instructivos de internet detalle el cual no imposibilito usar dicha via. Al final se uso una plataforma llamada Raylib.Csl. la cual aunque no es de las mejores era relativamente mas facil de aprender u obtener que otras opciones. Para la parte visual al tener pocas herramientas en nuestra manos en este nuevo campo de desarrolllo inexplorado, creamos una simple app para visualizar el proyecto. Aqui usamos una maquina de stack el cual en el apoyo de una clase abstracta que definia al accion que puede realizarse en pantallla se creo varias clases interconectadas las cuales cada una agrupaba un tipo de accion con la que se podia interactuar, ejemplo de esto es "Setting" en el cual esta definidos los diversos aspectos generales que se podian cambiar, en este caso los players y las GameRules. estos dos antes mencionados tambien definian clases  que permitian definir las especificaciones de cada jugador o regla del juego. se uso cuadros interactivos donde se podia escribir informacion especificada o botones predefinidos para interacturar con algunas opciones. se creo una clase encargada de controlar las opciones elegidas  y  permitir la inicializacion de la simulacion y visua al enviar todos los datos a un metodo que comprobaba que se pudiera iniciar el juego con las opciones elegidas despues de todo es imposoble declarar un total de 50 fichas y 6 jugadores  e iniciar cada jugador con 10 fichas cada uno. Por ultimo esta la clase "Game" esta es la que recibe el registro de la simulacion y la visualiza en pantalla , se debe especificar  nuavamente que la parte visual fue el aspecto mas desafiante por la falta de herramientas de aprendizaje y la dificulta de comprension de la usada para aprender. al tener datos predefinidos para el uso online , obligando a dedicar buen tiempo a redefinirlos en offline para su comprension.
Finalmente luego de nuestra primera exposicion fueron señalados algunas deficiencias y se hicieron varias sugerencias, estas fueron en gran parte acatadas hacendo cambios como permitir
al al programa adaptarse a nuevas implentaciones de las interfaces sin tener que cambiar ningun aspecto de la interfaz grafica, aumentar la cantidad de informacion que la interfaz grafica
ofrece a los usuarios, crear clasesde tipo estrategia separando esto de los jugadores, entre otros.
> Jerarquia de clase

GameRules: Clase que contiene todas las propiedades necesarias para hacer funcionar el programas cuyo valor se asigna en su constructor dichas propiedades son de los tipos siguientes:

* IvalitateMove: Interface que contiene un metodo denominado Valitate el cual recibe una jugada y el estado actual del juego y regresa un bool si la jugada realizada es valida o no.
* BaseState: Clase que cotiene las caras activas en la mesa , un registro de jugada y un metodo actualizar que recibe una jugada y al jugador que la realizo y actualiza las dos propiedades anteriores
* List(Token): Una lista de fichas 
* IOrder: Interface que contiene un metodo Next que recibe una lista de jugadores y devuelve un int indicando el indice del proximo jugador.\
* controladorDeDesarrollo: Clase que controla los jugadores que se pasan y las caras que no poseen.El metodo no lleva detectado, es el unico usado activamente en el programa , tiene otro metodo que actuan sobre sus propiedades de quien no lleva y que es lo que no llevan que podrian ser utiles en el futuro.
* IvalorateToken: Interface que  contiene un metodo que recibe una ficha y regresa su valor.
* IgameFinisher: Interface cuyo metodo recibe informacion del estado actual del juego y regresa un bool indicando si este ya termino o no.
* Iresult: Interface cuyo metodo indica el ganador del juego.

IDescribable: En general todas las interfaces la usan. Permite obtener informacion de las implentaciones para proporcionarsela al usuario

IStrategy: interface que modifica un array de enteros en depoendencia de otro array de moves del mismo tamaño 

Player: Clase abstracta que contiene dos propiedades un entero que actua como nombre del jugador y una lista de fichas. Ademas posee un metodo asignar que le da valor a la lista de fichas y otro metodo abstracto MoveActual en el que se regresan una jugada de entre una lista de jugada validas. Este metodo MoveActual funciona con una lista de IStategy que actua sobre un array numerico quien indica cual es la jugada a regresar. Por tanto la unica diferencia entre un jugador y otro es que elemntos contiene la lista de IStrategy.

Token: Clase que contiene un array generico que indica las caras, si bien no fue posible crear un juego con mas de dos caras mantiene esa posibilidad futura.

GetGameRules: Clase que contiene dos metodos que regresan objetos GameRules y ProgramedRules respectivamente. Ademas posee otros metodos cuya funcion es proporcionar listas de las implentencaciones de cada una de las interfaces, por tal motivo al crear una nueva clase que implemente estas interfacies se debe agregar a su metodo correspondiente en GetGameRules.

ProgramedRules: Contiene las listas de las implementaciones de las interfaces asi como cual de ellas se va a usar.

ProgramedPlayers: Contiene una lista de los jugasores que se han implementado. 

TokenCreator: Clase que usa Un metodo recursivo para generar una listas de fichas en dependencia de las posibles caras introducidas previamente en la interface grafica, se usa dentro de getgamerule,

Playercreator: Clase que devuelve una lista de jugadores en dependencia de la lista que indica las ia usada y el equipo seleccionado. Tambien permite la creacion de jugadore de IA Random.

Auxiliares: Clase que se dividio en dos devido a su funciones tan diferentes
* la primera parte como su nommbre indica contiene metodos auxiliares que se usan en diferentes partes del programa, el mas importante de estos es el metodo mezclar que permiten alterar el orden de una ista de fichas de forma random el resto son en su mayoria metodos para imprimir en consola que si bien no son utiles para el funcionamiento del progrma si lo son para el mantenimiento y deteccion de errores. 
* la segunda parte contiene el metodo validate setting que indica si la configuracion introducida en la interface grafica es valida de serlo llama a los metodos de las clases getgamerules y players creators. esto se realizo para evitar ejecutar el metodo recursivo dos veces y es posible trasladarla a una clase particular en el futuro.

Game: Clase que contiene un metodo single con un bucle white donde todo el proceso del juego se corre siguiendo las regulaciones establecida por un objeto Gamerules y siguiendo las indicaciones de un arreglos de jugadores.

> Los 5 Puntos variables

* #1 Caras de las fichas: El programa completo se establece de tipo generico, si bien actualmente solo trabaja con string ofrece todo tipo de posibilidaddes futuras
* #2 Condicion para que una jugada sea valida: Se pueden establecer la condicion normal , la condicion de ser mayor en uno , mas otras variaciones
* #3 Orden variable: El jugador en turno se indica por un metodo que para nada esta obligado a seguir un orden predefinido.
* #4 Valor de las fichas : El valor de cada ficha inprenscindible en la actuacion de los jugadores y en la determinacion del ganador tambien se puede cambiar segun se desee
* #5 Condicion de finalizacion: Cada vez que un jugador termina su jugada se  analiza el estado dell juego para comprobar si ya termino, y su condicion para hacerlo es variable.
* #6 Forma de determinar el ganador: por ejemplo la puntuacion  se saca individualmente y la victoria de un jugador indica la victoria de su equipo o cada equipo tiene una puntuacion general.

> Descripcion de la interfaz grafica

* Pantalla principal: 

* Boton Siguente: Permite aagregar el contenido del TextBox a su izquierda a una lista de caras validas de las fichas.
* Botones D/9 y D/6: Permiten establecer el conjunto de caras validas de 0 a 9 y de 0 a 6 respectivamente. Estos no son necesarios para el programa ya que lo mismo puede hacerse con el boton siguiente, solo se crearon para agilizar el proceso de probar el programa.
* Botones + y -: Permiten aumentar o disminuir la cantidad de fichas que se le asignan a cada jugador
* Botones de las Interfaces: Estos 5 botones dispuestos en columna permiten cambiar el aspecto del juego que se indica a la izquierda de cadauno entre las diferentes implementaciones proporcionadas por el programa.
* Botones ?: Abren un MessageBox que brinda al usuario informacion sobre la funcionalidad alaizquierda del boton.
* Botones + (lado derecho): Permiten cambiar la IA (tipo de jugador) y el equipo al que este pertenece. Ambas cosas se indican en el TextBox de la izquierda de cada boton.
* Botones Inclueir y Eliminar: Permiten incluir al un nuevo jugador y eliminar al ultimo introducido respectivamente. La cantidad actual de jugadores se muestra debajo.
* Boton Aceptar: Permite, si las opciones seleccionadas son validas, abrir una nueva ventana donde se ejecutara el partido, si las opciones son incompatibles muestra un mensaje de advertencia.

* Pantalla de ejecucion del partido:
En la parte superior se muestran mensajes de los sucesos del juego.
En esta pantalla hay botones que no funcionan como tal sino que se usan para representar caras de una ficha. Estos son:
* Estaticos: Dos botones en el centro de la pantalla que indican las caras disponibles en la mesa, es decir los extremos.
* Moviles: Dos botnoes que se van moviendo por la pantalla y representan una nueva ficha siendo colocada por un jugador.
El movimiento de los botones anteriores se logra mediante un timer que va modificando la posicion de estos segun valla transcurriendo el juego. Es este tambien quien controla a los mensajes que se van mostrando.

* Botones Comenzar y Regresar: Ubicados en la parte inferior de la pantalla, permiten comenzar el partido y cerrar la pantalla respectivamente.

> Descripcion de las opciones de cada Interface

Ivalitator:

* Opcion #1: La usual en el domino
* Opcion #2(Solo funciona correctamente para data numericas):Una ficha se puede jugar por una cara si es mayor en uno que dicha cara, la cara 0 se juega sobre la ficha de mayor valor en la mesa.

Ivalorator:

* Opcion #1: EL valor de una ficha es la suma del valor de sus caras.
* Opcion #2: El Valor de una Ficha es el MCD de sus caras.

IOrder:
* Opcion #1: Los jugadores juegan en orden ascendente.
* Opcion #2: Cuando un jugador se pasa se invierte el orden, permanece asi un ciclo completo y cuando otro jugador se pasa se vuelve a invertir.

IFinisher:

* Opcion #1: El juego finaliza cuando un jugador se pegue o cuando ninguno lleve.
* Opcion #2: El juego finaliza cuando cada jugador se ha pasado al menos una vez o se cumpla la opcion #1.

IResult:

* Opcion #1: La puntuacion es individual.y la victoria de un jugador indica la victoria de su equipo.
* Opcion #2: La puntuacion es por equipo.(En caso de no haber equipo ambas opciones son equivalentes)
