Pasos a seguir para desplegar la aplicacion:

1- descargar Solucion



2-Ejecuta .sln




3-Existen 3 proyectos dentro de la solucion  	ApiCajaAhorro, MyIdentityServer y WebClient..Click derecho en ApiCajaAhorro y click en Publicar, lo mismo para MyIdentityServer..



4-se habran creado los ficheros necesarios para la publicacion en C:\inetpub\wwwroot




5-en el iis crear una aplicacion nueva con Alias ApiCajaAhorro de tal forma que al dar examinar quede http://localhost/ApiCajaAhorro



6-en el iis crear una aplicacion nueva con Alias IdentityServer de tal forma que al dar examinar quede http://localhost/IdentityServer


7-click derecho en el proyecto WebClient y dar click en administrar secretos de usuario


8- sustituir { } por {
  "Authentication:Google:ClientId": "611168692304-22jf7e78167t6vhgm6ru7hq1adtacgt9.apps.googleusercontent.com",
  "Authentication:Google:ClientSecret": "DUw1w5lo05svcS8QrXWhkeX0",
  "Authentication:Facebook:ClientfaceId": "294356061224007",
  "Authentication:Facebook:ClientfaceSecret": "c25b8c7a15bc2d139fc52e17ee62cd52"

}










9-establecer Webcliet como proyecto de inicio







10-Ejecutar.. Listo!!!!

