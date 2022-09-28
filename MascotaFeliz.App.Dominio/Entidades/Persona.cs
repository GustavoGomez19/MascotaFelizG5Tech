using System; //Importar una librería
namespace MascotaFeliz.App.Dominio // Creación de un paquete, todo lo que está en medio de las llaves
{
    public class Persona
    {
        public int Id {get;set;}
        public string Nombres {get;set;}
        public string Apellidos {get;set;}
        public string Direccion {get;set;}
        public string Telefono {get;set;}
    }
}