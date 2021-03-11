using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace restauranteDBTB.controle
{
    class MesaDB
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
                var query = from linhas in banco.mesa
                            orderby linhas.idmesa
                            select linhas;
                bs.DataSource = query.ToList();
            }
        }

        public void inserir(modelo.mesa Registro)
        {
            using (var banco = new modelo.restaurantedbEntidades())
            {
                banco.Database.Connection.ConnectionString = con;
                try
                {
                    banco.mesa.Add(Registro);
                    banco.SaveChanges();
                }
                catch (Exception Erro)
                {
                    MessageBox.Show("Erro ao Cadastrar:" + Erro.Message);
                }

            }
        }

        public void editar(modelo.mesa Registro)
        {
            using (var banco = new modelo.restaurantedbEntidades())
            {
                banco.Database.Connection.ConnectionString = con;
                try
                {
                    modelo.mesa velho = banco.mesa.Find(Registro.idmesa);
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
                modelo.mesa Registro = banco.mesa.Find(Codigo);
                try
                {
                    banco.mesa.Remove(Registro);
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
                    int cod = banco.mesa.Max(i => i.idmesa);
                    return cod + 1;
                }
                catch (Exception)
                {
                    return 1;
                }

            }
        }

        public System.Data.DataSet relatorio()
        {
            string[] array_status = new string[]{
                "0 - A MESA ESTA LIVRE",
                "1 - A MESA ESTA EM USO",
                "2 - A MESA ESTA RESERVADA",
                "3 - A MESA ESTA INDISPONIVEL"
            };

            using (var banco = new modelo.restaurantedbEntidades())
            {

                banco.Database.Connection.ConnectionString = con;
                var query = from linhas in banco.mesa
                            orderby linhas.idmesa
                            select new
                            {
                                linhas.idmesa,
                                linhas.status,
                                linhas.vagas,
                            };

                System.Data.DataSet DS = new System.Data.DataSet();
                DS.Tables.Add(new System.Data.DataTable("mesa"));

                DS.Tables["mesa"].Columns.Add("idmesa");
                DS.Tables["mesa"].Columns.Add("status");
                DS.Tables["mesa"].Columns.Add("vagas");

                foreach (var item in query)
                {
                    System.Data.DataRow row = DS.Tables["mesa"].NewRow();

                    row["idmesa"] = item.idmesa.ToString().PadLeft(10, '0');
                    int index = Convert.ToInt16(item.status);
                    row["status"] = array_status[index];
                    row["vagas"] =  item.vagas;

                    DS.Tables["mesa"].Rows.Add(row);
                }

                DS.DataSetName = "dsMesa";

                return DS;
            }
        }
    }
}
