using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Usuario_DAO_DAL;
using Model;
using System.Data;

namespace Facade
{
    public class UsuarioFD
    {
        Usuario_DAO objUsuario_DAO;


        public DataTable Consultar(Usuario_VO objUsuario_VO)
        {
            try
            {
                objUsuario_DAO = new Usuario_DAO();
                return objUsuario_DAO.Consultar(objUsuario_VO);
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
                objUsuario_DAO = new Usuario_DAO();
                Object objUsuraioVO = (Object)objUsuario_VO;
                objUsuario_DAO.Consultar(ref objUsuraioVO);
                return objUsuario_VO.Usuario_VO_Collection;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Inserir(Usuario_VO objUsuario_VO)
        {
            try
            {
                objUsuario_DAO = new Usuario_DAO();
                return objUsuario_DAO.Inserir(objUsuario_VO);
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
                objUsuario_DAO = new Usuario_DAO();
                return objUsuario_DAO.Excluir(objUsuario_VO);
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
                objUsuario_DAO = new Usuario_DAO();
                return objUsuario_DAO.Alterar(objUsuario_VO);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
