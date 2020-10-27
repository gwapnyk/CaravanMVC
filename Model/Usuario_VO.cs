using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{

    public class Usuario_VO
    {
        private string nome;
        private string cpf;
        private string email;
        private string senha;

        public Usuario_VO() 
        {
        }

        public Usuario_VO(string strNome, string strCpf, string strEmail, string strSenha) 
        {
            Nome = strNome;
            Cpf = strCpf;
            Email = strEmail;
            Senha = strSenha;
        }

        public string Nome 
        { 
          get { return nome; }
          set { this.nome = value; } 
        }
        public string Cpf
        {
            get { return cpf; }
            set { this.cpf = value; }
        }
        public string Email
        {
            get { return email; }
            set { this.email = value; }
        }
        public string Senha
        {
            get { return senha; }
            set { this.senha = value; }
        }

        public List<Usuario_VO> Usuario_VO_Collection = new List<Usuario_VO>();
    }
}
