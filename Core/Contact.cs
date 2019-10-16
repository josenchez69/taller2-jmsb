using System;

namespace Core
{
    public class Contact: IContacts
    {
        public Boolean RegistrarContacto(String user, String Password)
        {
            Boolean Iscontact = false;
            if (user == "user" && Password == "1234")
            {
                Iscontact = true;
            }
            return Iscontact;
        }
    }
}
