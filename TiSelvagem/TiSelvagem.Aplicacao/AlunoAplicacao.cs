using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiSelvagem.Repositorio;
using TiSelvagem.Dominio;

namespace TiSelvagem.Aplicacao
{
    public class AlunoAplicacao
    {
        private Contexto contexto;

        private void Inseri(Aluno aluno)
        {
            var strQuery = "";
            strQuery += "INSERT INTO TB_ALUNO (NOME, MAE,DATA_NASCIMENTO)";
            strQuery += string.Format(" VALUES ('{0}','{1}','{2}' )", aluno.vNOME,aluno.vMAE,aluno.vDATA_NASCIMENTO);

            using (contexto = new Contexto())
            {
                contexto.ExecutaComando(strQuery); 
            }

        }

        private void Alterar(Aluno aluno)
        {

            var strQuery = "";
            strQuery += "UPDATE TB_ALUNO SET";
            strQuery += string.Format(" NOME = '{0}', ",aluno.vNOME);
            strQuery += string.Format(" MAE = '{0}', ", aluno.vMAE);
            strQuery += string.Format(" DATA_NASCIMENTO = '{0}' ", aluno.vDATA_NASCIMENTO);
            strQuery += string.Format(" WHERE IDALUNO= '{0}' ", aluno.vIDALUNO);

            using (contexto = new Contexto())
             {
                contexto.ExecutaComando(strQuery);
            }
        }

        public void Salvar(Aluno aluno)
        {
            if (aluno.vIDALUNO > 0)
                Alterar(aluno);
            else
                Inseri(aluno);

        }
    
        public void Excluir(int id)
        {
            var strQuery = string.Format("DELETE FROM TB_ALUNO WHERE IDALUNO= {0}", id);
          
            using (contexto = new Contexto())
            {
                contexto.ExecutaComando(strQuery);
            }
        }



        public List<Aluno> ListarTodos()
        {
            var strQuery = "select * from tb_Aluno";

            using (contexto = new Contexto())
            {
                var retornoDataReader = contexto.ExecutaComandoComRetorno(strQuery);
                return TransformaReaderEmListaObjetos(retornoDataReader);
            }

        }

        public Aluno ListarPoId(int id)
        {
            var strQuery = string.Format( "select * from tb_Aluno where idaluno = {0}",id) ;

            using (contexto = new Contexto())
            {
                var retornoDataReader = contexto.ExecutaComandoComRetorno(strQuery);
                return TransformaReaderEmListaObjetos(retornoDataReader).FirstOrDefault();
            }
        }


        private List<Aluno> TransformaReaderEmListaObjetos(SqlDataReader reader)
        {
            var alunos = new List<Aluno>();
            while (reader.Read())
            {
                var TempObjeto = new Aluno()
                                  {
                                    vIDALUNO = int.Parse(reader["IDALUNO"].ToString()),
                                    vNOME    = reader["NOME"].ToString(),
                                    vMAE     = reader["MAE"].ToString(),
                                    vDATA_NASCIMENTO = DateTime.Parse(reader["DATA_NASCIMENTO"].ToString()) 
                                  };
                alunos.Add(TempObjeto);           
            }
            reader.Close();
            return alunos;
        }


    }
}
