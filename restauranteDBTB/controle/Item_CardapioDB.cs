using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace restauranteDBTB.controle
{
    class Item_CardapioDB
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
                var query = from linhas in banco.item_cardapio.Include("produto")
                            orderby linhas.idproduto
                            select linhas;

                bs.DataSource = query.ToList();
            }
        }

        public void inserir(modelo.item_cardapio Registro)
        {
            using (var banco = new modelo.restaurantedbEntidades())
            {
                banco.Database.Connection.ConnectionString = con;
                try
                {
                    banco.item_cardapio.Add(Registro);
                    banco.SaveChanges();
                }
                catch (Exception Erro)
                {
                    MessageBox.Show("Erro ao Cadastrar:" + Erro.Message);
                }

            }
        }

        public void editar(modelo.item_cardapio Registro)
        {
            using (var banco = new modelo.restaurantedbEntidades())
            {
                banco.Database.Connection.ConnectionString = con;
                try
                {
                    modelo.item_cardapio velho = banco.item_cardapio.Find(Registro.item_cardapio1);
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
                modelo.item_cardapio Registro = banco.item_cardapio.Find(Codigo);
                try
                {
                    banco.item_cardapio.Remove(Registro);
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
                    int cod = banco.item_cardapio.Max(i => i.item_cardapio1);
                    return cod + 1;
                }
                catch (Exception)
                {
                    return 1;
                }

            }
        }

    }
}
