using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facade;
using Model;

namespace CaravanBLL
{
    public class Usuario
    {
        UsuarioFD objUsuarioFD;

        public  DataTable Consultar(Usuario_VO objUsuario_VO)
        {
            try
            {
                objUsuarioFD = new UsuarioFD();
                return objUsuarioFD.Consultar(objUsuario_VO);
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Usuario_VO> Consultar(ref Usuario_VO objUsuario_VO)
        {
            try
            {
                objUsuarioFD = new UsuarioFD();
                return objUsuarioFD.Consultar(ref objUsuario_VO);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Registrar (Usuario_VO objUsuario_VO)
        {
            try
            {
                objUsuarioFD = new UsuarioFD();
                return objUsuarioFD.Inserir(objUsuario_VO);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Excluir(Usuario_VO objUsuario_VO)
        {
            try
            {
                objUsuarioFD = new UsuarioFD();
                return objUsuarioFD.Excluir(objUsuario_VO);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Alterar(Usuario_VO objUsuario_VO)
        {
            try
            {
                objUsuarioFD = new UsuarioFD();
                return objUsuarioFD.Alterar(objUsuario_VO);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
