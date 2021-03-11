using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace restauranteDBTB.controle
{
    class ProdutoDB
    {
        string con = Conexao.Open(
                   controle.Registro.ler("restaurante", "servidor"),
                   "restaurantedb",
                  controle.Registro.ler("restaurante", "user"),
                  controle.Cripto.decodificar(controle.Registro.ler("restaurante", "senha"))
                  );

        public void consultar(System.Windows.Forms.BindingSource bs)
        {
            using (var banco = new modelo.restaurantedbEntidades())
            {
                banco.Database.Connection.ConnectionString = con;                   
                // LINQ
                var query = from linhas in banco.produto.Include("tipo")
                            orderby linhas.idproduto
                            select linhas;
                bs.DataSource = query.ToList();
            }
        }

        public void inserir(modelo.produto Registro)
        {
            using (var banco = new modelo.restaurantedbEntidades())
            {
                banco.Database.Connection.ConnectionString = con;   
                try
                {
                    banco.produto.Add(Registro);
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
                    int cod = banco.produto.Max(i => i.idproduto);
                    return cod + 1;
                }
                catch (Exception)
                {
                    return 1;
                }

            }
        }

        public void editar(modelo.produto Registro)
        {
            using (var banco = new modelo.restaurantedbEntidades())
            {          
                banco.Database.Connection.ConnectionString = con;
                try
                {
                    modelo.produto velho = banco.produto.Find(Registro.idproduto);
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
                modelo.produto Registro = banco.produto.Find(Codigo);
                try
                {
                    banco.produto.Remove(Registro);
                    banco.SaveChanges();
                }
                catch (Exception Erro)
                {
                    MessageBox.Show("Erro ao Excluir:" + Erro.Message);
                }

            }
        }

        public object pesquisar(string texto, string tipo)
        {
            using (var banco = new modelo.restaurantedbEntidades())
            {

                banco.Database.Connection.ConnectionString = con;

                if (tipo.Equals("start"))
                {
                    var query = from linhas in banco.produto
                                where linhas.nome.StartsWith(texto)
                                select new
                                {
                                    Codigo = linhas.idproduto,
                                    Descricao = linhas.nome
                                };
                    return query.ToList();
                }
                else if(tipo.Equals("contains"))
                {
                    var query = from linhas in banco.produto
                                where linhas.nome.Contains(texto)
                                select new
                                {
                                    Codigo = linhas.idproduto,
                                    Descricao = linhas.nome
                                };
                    return query.ToList();
                }

                return null;
            }
        }

        public System.Data.DataSet relatorio()
        {
            using (var banco = new modelo.restaurantedbEntidades())
            {

                banco.Database.Connection.ConnectionString = con;
                var query = from linhas in banco.produto.Include("tipo")
                            orderby linhas.idtipo
                            select new
                            {
                                linhas.idproduto,
                                linhas.nome,
                                linhas.preco,
                                tipo = linhas.tipo.descricao
                            };

                System.Data.DataSet DS = new System.Data.DataSet();
                DS.Tables.Add(new System.Data.DataTable("produto"));

                DS.Tables["produto"].Columns.Add("idproduto");
                DS.Tables["produto"].Columns.Add("nome");
                DS.Tables["produto"].Columns.Add("preco");
                DS.Tables["produto"].Columns.Add("tipo");

                foreach (var item in query)
                {
                    System.Data.DataRow row = DS.Tables["produto"].NewRow();

                    row["idproduto"] = item.idproduto.ToString().PadLeft(10,'0');
                    row["nome"] = item.nome;
                    row["preco"] = String.Format("{0:C2}",item.preco);
                    row["tipo"] = item.tipo;
                    DS.Tables["produto"].Rows.Add(row);
                }

                DS.DataSetName = "dsProduto";

                return DS;
            }
            
        }

        public System.Data.DataSet Grafico()
        {
            using (var banco = new modelo.restaurantedbEntidades())
            {

                banco.Database.Connection.ConnectionString = con;
                var query = from linhas in banco.produto.Include("tipo")
                            select new
                            {
                                linhas.idproduto,
                                linhas.idtipo,
                                tipo = linhas.tipo.descricao
                            };

                System.Data.DataSet DS = new System.Data.DataSet();
                DS.Tables.Add(new System.Data.DataTable("produto"));
                DS.Tables["produto"].Columns.Add("idproduto");
                DS.Tables["produto"].Columns.Add("idtipo");
                DS.Tables["produto"].Columns.Add("tipo");

                foreach (var item in query)
                {
                    System.Data.DataRow row = DS.Tables["produto"].NewRow();

                    row["idproduto"] = item.idproduto.ToString().PadLeft(10, '0');
                    row["tipo"] = item.tipo;
                    row["idtipo"] = item.idtipo;
                    DS.Tables["produto"].Rows.Add(row);
                }

                DS.DataSetName = "dsGraficoProduto";
                return DS;
            }
        }
    }
}
