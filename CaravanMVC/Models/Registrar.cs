using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Model;

namespace CaravanMVC.Models
{
    public class Registrar
    {
        private Usuario_VO objUsuario_VO;

        public Registrar()
        {
            objUsuario_VO = new Usuario_VO();
        }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "Informe o nome do usuário", AllowEmptyStrings = false)]
        public string Nome
        {
            get { return objUsuario_VO.Nome; }
            set { objUsuario_VO.Nome = value; }
        }

        [Required(ErrorMessage = "Informe o cpf", AllowEmptyStrings = false)]
        public string Cpf
        {
            get { return objUsuario_VO.Cpf; }
            set { objUsuario_VO.Cpf = value; }
        }

        [Required(ErrorMessage = "Informe o cpf", AllowEmptyStrings = false)]
        public string Email
        {
            get { return objUsuario_VO.Email; }
            set { objUsuario_VO.Email = value; }
        }

        [Required(ErrorMessage = "Informe a senha do usuário", AllowEmptyStrings = false)]
        [DataType(System.ComponentModel.DataAnnotations.DataType.Password)]
        public string Senha
        {
            get { return objUsuario_VO.Senha; }
            set { objUsuario_VO.Senha = value; }
        }

        public Usuario_VO UsuarioModel
        {
            get { return this.objUsuario_VO; }
        }

        public List<Registrar> Registrar_Collection = new List<Registrar>();
    }
}