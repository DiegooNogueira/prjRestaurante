using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace restauranteDBTB.controle
{
    class CardapioDB
    {
        string con = Conexao.Open(
                 controle.Registro.ler("restaurante", "servidor"),
                 "restaurantedb",
                controle.Registro.ler("restaurante", "user"),
                controle.Cripto.decodificar(
                controle.Registro.ler("restaurante", "senha"))
                );

        public void consultar(System.Windows.Forms.BindingSource bs)
        {
            using (var banco = new modelo.restaurantedbEntidades())
            {
                banco.Database.Connection.ConnectionString = con;
                // LINQ
                var query = from linhas in banco.cardapio
                            orderby linhas.idcardapio
                            select linhas;
                bs.DataSource = query.ToList();
            }
        }

        public void inserir(modelo.cardapio Registro)
        {
            using (var banco = new modelo.restaurantedbEntidades())
            {
                banco.Database.Connection.ConnectionString = con;
                try
                {
                    banco.cardapio.Add(Registro);
                    banco.SaveChanges();
                }
                catch (Exception Erro)
                {
                    MessageBox.Show("Erro ao Cadastrar:" + Erro.Message);
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
                    int cod = banco.cardapio.Max(i => i.idcardapio);
                    return cod + 1;
                }
                catch (Exception)
                {
                    return 1;
                }

            }
        }

        public void editar(modelo.cardapio Registro)
        {
            using (var banco = new modelo.restaurantedbEntidades())
            {
                banco.Database.Connection.ConnectionString = con;
                try
                {
                    modelo.cardapio velho = banco.cardapio.Find(Registro.idcardapio);
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
                modelo.cardapio Registro = banco.cardapio.Find(Codigo);
                try
                {
                    banco.cardapio.Remove(Registro);
                    banco.SaveChanges();
                }
                catch (Exception Erro)
                {
                    MessageBox.Show("Erro ao Excluir:" + Erro.Message);
                }

            }
        }
    }
}
