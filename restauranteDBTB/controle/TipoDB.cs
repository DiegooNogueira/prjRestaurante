using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace restauranteDBTB.controle
{
    class TipoDB
    {
        string con = Conexao.Open(
                 controle.Registro.ler("restaurante", "servidor"),
                 "restaurantedb",
                controle.Registro.ler("restaurante", "user"),
                controle.Cripto.decodificar(controle.Registro.ler("restaurante", "senha"))
                );

        public object listar()
        {    
            
            using (var banco = new modelo.restaurantedbEntidades())
            {
     
                banco.Database.Connection.ConnectionString = con;

                var query = from linhas in banco.tipo
                            orderby linhas.idtipo
                            select linhas;
                return query.ToList();
            }
        }

        public void inserir(modelo.tipo Registro)
        {
            using (var banco = new modelo.restaurantedbEntidades())
            {
                banco.Database.Connection.ConnectionString = con;
                try
                {
                    banco.tipo.Add(Registro);
                    banco.SaveChanges();
                }
                catch (Exception Erro)
                {
                    MessageBox.Show("Erro ao Cadastrar:" + Erro.Message);
                }

            }
        }

        public void editar(modelo.tipo Registro)
        {
            using (var banco = new modelo.restaurantedbEntidades())
            {
                banco.Database.Connection.ConnectionString = con;
                try
                {
                    modelo.tipo velho = banco.tipo.Find(Registro.idtipo);
                    banco.Entry(velho).CurrentValues.SetValues(Registro);
                    banco.SaveChanges();
                }
                catch (Exception Erro)
                {
                    MessageBox.Show("Erro ao Editar:" + Erro.Message);
                }

            }
        }

        public void excluir(int Codigo)
        {
            using (var banco = new modelo.restaurantedbEntidades())
            {
                banco.Database.Connection.ConnectionString = con;
                modelo.tipo Registro = banco.tipo.Find(Codigo);
                try
                {
                    banco.tipo.Remove(Registro);
                    banco.SaveChanges();
                }
                catch (Exception Erro)
                {
                    MessageBox.Show("Erro ao Excluir:" + Erro.Message);
                }

            }
        }

        public int ProximoCodigo()
        {
            using (var banco = new modelo.restaurantedbEntidades())
            {
                banco.Database.Connection.ConnectionString = con;
                try
                {
                    int cod = banco.tipo.Max(i => i.idtipo);
                    return cod + 1;
                }
                catch (Exception)
                {
                    return 1;
                }

            }
        }

        public bool checarExclusao(int Codigo)
        {
            using (var banco = new modelo.restaurantedbEntidades())
            {
                banco.Database.Connection.ConnectionString = con;

                var query = (from linhas in banco.produto
                            where linhas.idtipo == Codigo
                            select linhas).FirstOrDefault();
                return query == null ? true : false;

            }
        }
    }
}
