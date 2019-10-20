using System;
namespace Core
{
    public class Registrar
    {
        private String LastName;
        private String Name;
        private String Email;
        private String Address;
        private String City;
        private String phone;

        public Registrar()
        {
            LastName = "";
            Name = "";
            Email = "";
            Address = "";
            City = "";
            phone = "0";
        }
        public void RegistrarCont(String Apellido, String Nombre, String Email, String Direccion, String Ciudad, String Movil)
        {
            LastName = Apellido;
            Name = Nombre;
            this.Email = Email;
            Address = Direccion;
            City = Ciudad;
            phone = Movil;

        }
    }
}
