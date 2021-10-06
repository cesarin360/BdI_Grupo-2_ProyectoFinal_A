using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bdl_Grupo2_ProyectoFinal_A.Models.Usuarios
{
    public class User
    {
        public String Nombre;
        public String Codigo;
        public String Correo;
        public String Password;

     
        public String getnombre()
        {
            return Nombre;
        }

        public void setNombre(String nombre)
        {
            this.Nombre = nombre;
        }

        public String getcorreo()
        {
            return Correo;
        }

        public void setcorreo(String correo)
        {
            this.Nombre = correo;
        }

        public String getcodigo()
        {
            return Codigo;
        }

        public void setcodigo(String codigo)
        {
            this.Codigo = codigo;
        }

        public String getPassword()
        {
            return Password;
        }

        public void setPassword(String password)
        {
            this.Password = password;
        }

    }
}