using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace Usuario_DAO_DAL
{
    public class Usuario_DAO : DAO_DAO
    {
        MySqlCommand objCommand;
        MySqlDataAdapter objDataAdapter;
        DataTable objTable;

        public override DataTable Consultar(Object objRegistrar_VO)
        {
            try
            {
                Usuario_VO objRegistrarVO = (Usuario_VO)objRegistrar_VO;

                if (objRegistrarVO.Email != null)
                {
                    objCommand = new MySqlCommand("SELECT Nome,Cpf,Email,Senha FROM cadastro WHERE Email = :strEmail", gettObjConnection());
                    objCommand.Parameters.AddWithValue("strEmail", objRegistrarVO.Email);
                }
                else if (string.IsNullOrEmpty(objRegistrarVO.Cpf))
                {
                    objCommand = new MySqlCommand("SELECT Nome,Cpf,Email,Senha FROM cadastro", gettObjConnection());
                }
                else
                {
                    objCommand = new MySqlCommand("SELECT Nome,Cpf,Email,Senha FROM cadastro WHERE Cpf = :strCpf", gettObjConnection());
                    objCommand.Parameters.AddWithValue("strCpf", objRegistrarVO.Cpf);
                }

                objDataAdapter = new MySqlDataAdapter(objCommand);

                objTable = new DataTable();

                objDataAdapter.Fill(objTable);

                return objTable;
            }
            catch (Exception ex)
            {
                throw new Exception("Falha ao Consultar ==> " + ex.Message);
            }
        }

        public override List<Object> Consultar(ref Object objRegistrar_VO)
        {
            try
            {
                Usuario_VO objRegistrarVO = (Usuario_VO)objRegistrar_VO;

                if (objRegistrarVO.Email != null)
                {
                    objCommand = new MySqlCommand("SELECT Nome,Cpf,Email,Senha FROM cadastro WHERE Email = :strEmail", gettObjConnection());
                    objCommand.Parameters.AddWithValue("strEmail", objRegistrarVO.Email);
                }
                else if (string.IsNullOrEmpty(objRegistrarVO.Cpf))
                {
                    objCommand = new MySqlCommand("SELECT Nome,Cpf,Email,Senha FROM cadastro", gettObjConnection());
                }
                else
                {
                    objCommand = new MySqlCommand("SELECT Nome,Cpf,Email,Senha FROM cadastro WHERE Cpf = :strCpf", gettObjConnection());
                    objCommand.Parameters.AddWithValue("strCpf", objRegistrarVO.Cpf);
                }

                objDataAdapter = new MySqlDataAdapter(objCommand);

                objTable = new DataTable();

                objDataAdapter.Fill(objTable);

                List<Object> objListaRetorno = new List<object>();

                foreach (DataRow item in objTable.Rows)
                {
                    objRegistrarVO.Usuario_VO_Collection.Add(new Usuario_VO(item["Nome"].ToString()
                                                                        , item["Cpf"].ToString()
                                                                        , item["Email"].ToString()
                                                                        , item["Senha"].ToString()
                                                                        ));
                }
                objListaRetorno.AddRange(objRegistrarVO.Usuario_VO_Collection.ToArray());
                return objListaRetorno;
            }
            catch (Exception ex)
            {
                throw new Exception("Falha ao Consultar ==> " + ex.Message);
            }
        }

        public override bool Inserir(Object objRegistrar_VO)
        {
            try
            {
                Usuario_VO objRegistrarVO = (Usuario_VO)objRegistrar_VO;

                AbreConn();

                objCommand = new MySqlCommand("INSERT INTO cadastro(Nome,Cpf,Email,Senha) VALUES (?parNome,?parCpf,?parEmail,?parSenha)", gettObjConnection());
                objCommand.Parameters.AddWithValue("parNome", objRegistrarVO.Nome);
                objCommand.Parameters.AddWithValue("parCpf", objRegistrarVO.Cpf);
                objCommand.Parameters.AddWithValue("parEmail", objRegistrarVO.Email);
                objCommand.Parameters.AddWithValue("parSenha", objRegistrarVO.Senha);


                if (objCommand.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Falha ao Inserir ==> " + ex.Message);
            }
            finally
            {
                FechaConn();
            }
        }

        public override bool Excluir(Object objRegistrar_VO)
        {
            try
            {
                Usuario_VO objRegistrarVO = (Usuario_VO)objRegistrar_VO;

                AbreConn();

                objCommand = new MySqlCommand("DELETE FROM cadastro WHERE Email = :strEmail", gettObjConnection());
                objCommand.Parameters.AddWithValue("strEmail", objRegistrarVO.Email);

                if (objCommand.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Falha ao Excluir ==> " + ex.Message);
            }
            finally
            {
                FechaConn();
            }
        }

        public override bool Alterar(Object objRegistrar_VO)
        {
            try
            {
                Usuario_VO objRegistrarVO = (Usuario_VO)objRegistrar_VO;

                AbreConn();

                objCommand = new MySqlCommand(
                    @"UPDATE cadastro SET 
                    Nome = :strNome,
                    Cpf = :strCpf,
                    Senha = :strSenha
                    WHERE Email = :strEmail", gettObjConnection());
                objCommand.Parameters.AddWithValue("parNome", objRegistrarVO.Nome);
                objCommand.Parameters.AddWithValue("parCpf", objRegistrarVO.Cpf);
                objCommand.Parameters.AddWithValue("parEmail", objRegistrarVO.Email);
                objCommand.Parameters.AddWithValue("parSenha", objRegistrarVO.Senha);

                if (objCommand.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Falha ao Alterar ==> " + ex.Message);
            }
            finally
            {
                FechaConn();
            }
        }
    }


}
