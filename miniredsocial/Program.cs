using miniredsocial;

GrafoNPND g = new GrafoNPND(5);

g.AgregarPersona(new Persona { Nombre = "Anali" });
g.AgregarPersona(new Persona { Nombre = "Jorge" });
g.AgregarPersona(new Persona { Nombre = "Carlos" });
g.AgregarPersona(new Persona { Nombre = "Valeri" });

g.Conectar("Anali", "Jorge");
g.Conectar("Jorge", "Carlos");
g.Conectar("Carlos", "Valeri");

g.Mostrar();

g.SonAmigos("Anali", "Carlos"); 
g.SonAmigos("Anali", "Valeri");   
g.SonAmigos("Anali", "Jorge");    