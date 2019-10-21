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
        public Boolean RegistrarCont(String Apellido, String Nombre, String Email, String Direccion, String Ciudad, String Movil)
        {
            Boolean Valido = true;

            if (Apellido == "" || Nombre == "" || Email == "" || Direccion == "" || Ciudad == "" || Movil == "0")
            {
                Valido = false;
            }
            return Valido;
        }
    }
}
