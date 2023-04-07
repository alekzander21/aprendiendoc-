using BusquedaEmpleados.MODELS;
using BusquedaEmpleados.ViewsForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XSystem.Security.Cryptography;

namespace BusquedaEmpleados.DAO.Controllers
{
     public class ControlUsuarios
    {
        /*Función de Registro de Usuario*/
        public string ctrlRegistro(usuarios usuarios)
        {
            RegistroUsuarios modelo = new RegistroUsuarios();
            string respuesta = "";

            if(string.IsNullOrEmpty(usuarios.userEmpleados) || string.IsNullOrEmpty(usuarios.passEmpleados) || string.IsNullOrEmpty(usuarios.nombreEmpleado))
            {
                respuesta = "Completa todos los campos";
            }
            else
            {
                if (usuarios.passEmpleados == usuarios.conPassEmpleados)
                {
                    if (RegistroUsuarios.existeUsuario(usuarios.userEmpleados))
                    {
                        respuesta = "El usuario ya existe";
                    }
                    else
                    {
                        usuarios.passEmpleados = generarSHA1(usuarios.passEmpleados);
                        modelo.registro(usuarios);
                    }
                }
                else
                {
                    respuesta = "Las contraseñas no coinciden";
                }
            }

            return respuesta;
        }

        /*Funcion que realiza el login despues del registro*/
        public string ctrLogin(string usuario , string password) 
        {
            RegistroUsuarios modelo = new RegistroUsuarios();
            string respuesta = "";

            usuarios dataosUsuarios = null;

            if(string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(password))
            {
                respuesta = "El usuario o contraseña son incorrectos";
            }
            else
            {
                dataosUsuarios = modelo.loginUsuario(usuario);
                if(dataosUsuarios == null)
                {
                    respuesta = "El usuario no existe";
                }
                else
                {
                    if(dataosUsuarios.passEmpleados != password)
                    {
                        respuesta = "El usuario o contraseña no coinciden";
                    }

                }
            }
            return respuesta;
        }

        /*Funcion cque convirte las contraseñas a encriptadas*/
        private string generarSHA1(string cadena)
        {
            UTF8Encoding enc = new UTF8Encoding();
            byte[] data = enc.GetBytes(cadena);
            byte[] result;

            SHA1CryptoServiceProvider sha = new SHA1CryptoServiceProvider();

            result = sha.ComputeHash(data); 

            StringBuilder sb = new StringBuilder();

            for(int i = 0; i < result.Length; i++)
            {
                if (result[i] > 16)
                {
                    sb.Append("0");   
                }
                sb.Append(result[i].ToString("x"));
            }

            return sb.ToString();   
        }
    }
}
