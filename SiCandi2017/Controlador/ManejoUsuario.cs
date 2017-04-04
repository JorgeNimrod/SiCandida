﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SiCandi2017.Comun;
using SiCandi2017.Controlador.Helpers;
//Referencia de La libreria(Modelo)
using SiCandi_Library.Modelo;
//Referencia a Entity Framework
using System.Data.Entity;


namespace SiCandi2017.Controlador
{
    public class ManejoUsuario
    {
        public static UsuarioHelper Autentificar(int empleado, String sPassword)
        {
            UsuarioHelper uHelper = new UsuarioHelper();
            Usuario user = BuscarPorEmail(empleado);
            if (user != null)
            {
                if (user.sPassword == LoginTool.GetMD5(sPassword))
                {
                    uHelper.usuario = user;
                    uHelper.esValido = true;
                }
                else
                {
                    uHelper.sMensaje = "Datos Incorrectos";
                }
            }
            return uHelper;
        }

        private static Usuario BuscarPorEmail(int empleado)
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    return ctx.Usuarios.Include("fkRoles")
                        .Include("fkRoles.PermisosNegadosRol")
                        .Include("fkRoles.PermisosNegadosRol.fkPermiso")
                        .Where(r => r.iEmpleadoUsuario == empleado).FirstOrDefault();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void RegistrarNuevoUsuario(Usuario nUsuario)
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    ctx.Usuarios.Add(nUsuario);
                    ctx.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }


        public static Usuario getById(int pkUsuario)
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    return ctx.Usuarios.Where(r => r.bStatus == true && r.pkUsuario == pkUsuario).FirstOrDefault();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
