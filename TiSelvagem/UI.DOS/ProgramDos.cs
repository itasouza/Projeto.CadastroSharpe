using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiSelvagem.Dominio;
using TiSelvagem.Aplicacao;

namespace UI.DOS
{
    class ProgramDos
    {
        static void Main(string[] args)
        {
            
    
            var appAluno = new AlunoAplicacao();

            Console.Write("digite o nome do aluno:");
            string nome = Console.ReadLine();

            Console.Write("digite o nome da mãe:");
            string mae = Console.ReadLine();

            Console.Write("digite a data de nascimento:");
            string data = Console.ReadLine();

            var aluno = new Aluno();
            aluno.vNOME = nome;
            aluno.vMAE = mae;
            aluno.vDATA_NASCIMENTO = DateTime.Parse(data);
            //aluno.vIDALUNO = 6;
            appAluno.Salvar(aluno);
            //alunoAplicao.Salvar(aluno);
            //alunoAplicao.Excluir(2);


            //string strQueryDelete = "delete from tb_aluno WHERE IDALUNO = 1";
            //SqlCommand cmdQueryDelete = new SqlCommand(strQueryDelete, minhaConexao);
            //cmdQueryDelete.ExecuteNonQuery();

            //string strQueryUpdate = "update tb_aluno set nome='MARIA DA SILVA' WHERE IDALUNO = 1";
            //SqlCommand cmdQueryUpdate = new SqlCommand(strQueryUpdate, minhaConexao);
            //cmdQueryUpdate.ExecuteNonQuery();

            // string strQuerySelect = "select * from tb_aluno";
            // SqlDataReader dados = contexto.ExecutaComandoComRetorno(strQuerySelect);

            var dados = appAluno.ListarTodos();

            foreach (var alunos in dados)
            {
                Console.WriteLine("id:{0}, nome:{1} Mae:{2}, DataNascimento:{3}", alunos.vIDALUNO, alunos.vNOME,  alunos.vMAE,alunos.vDATA_NASCIMENTO);
            }


        }
    }
}
