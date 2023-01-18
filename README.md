### Descripción de la experiencia
Para este proyecto he decidido realizar una experiencia interactiva en la que disponemos de 30 cubos colocados aleatoriamente, cada uno de ellos con un movimiento y velocidad generados de forma aleatoria.
El usuario deberá encontrar los cubos y eliminarlos situando el cursor centrar sobre ellos. Una vez eliminados los cubos aparecerá un mensaje indicando que ha terminado la experiencia.

### Componentes utilizados
Mediante los recursos dispuestos en la moodle he investigado en los diferentes ejemplos y he utilizado los componentes necesarios para desarrollar mi experiencia. A continuación listo los diferentes compenentes:
    - controller-listener -> Componente necesario para utilizar los mandos de la realidad virtual para las diferentes acciones.
    - player-move -> Componente que se encarga del movimiento del jugador usando el controller-listener
    - raycaster-extras -> Componente necesario para realizar el raycast del mando hacia los objetos (Utilizado en la idea original, que era utilizar el mando para destruir los cubos pero por complejidad en la programacion no he podido llevarlo a cabo)

### Ventajas de utilizar WebXR
A continuacion detallare una serie de ventajas con respecto al uso de WebXR para la creacion de experiencias o juegos en realidad virtual:
    - Compatibilidad -> Mediante el uso de WebXR no necesitamos exportar la experiencia para otras plataformas o dispositivos ya que todo se encuentra centralizado asegurandonos asi mayor compatibilidad.
    - Accesibilidad -> Gracias al uso de WebXR nuestra experiencia es accesible desde cualquier dispositivo con navegador web, dependiendo de la experiencia incluso no necesitariamos de dispositivos de realidad virtual, si no que utilizariamos nuestro dispositivo para ejecutarla.
    - Inmediato -> Gracias a que las experiencias WebXR se ejecutan en navegadores compatibles con esta tecnologia tenemos la facilidad de poder probar la experiencia de forma inmediata al desplegarla o incluso mientras la programamos.

### Dispositivos
En mi caso, la experiencia que he creado se puede disfrutar mediante teclado y raton como con dispositivos de realidad virtual.