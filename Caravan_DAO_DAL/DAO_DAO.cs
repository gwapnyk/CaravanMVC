using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace Usuario_DAO_DAL
{
    public abstract class DAO_DAO : DB_DAO
    {
        

        public abstract DataTable Consultar(Object obj_VO);
        public abstract List<Object> Consultar(ref Object obj_VO);
        public abstract bool Inserir(Object obj_VO);
        public abstract bool Excluir(Object obj_VO);
        public abstract bool Alterar(Object obj_VO);
    }
}
