using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace restauranteDBTB.controle
{
    class UsuarioDB
    {
        string con = Conexao.Open(
                controle.Registro.ler("restaurante","servidor"), 
                "restaurantedb",
               controle.Registro.ler("restaurante", "user"),
               controle.Cripto.decodificar(controle.Registro.ler("restaurante", "senha"))
               );

        public bool validar(string usuario, string senha)
        {
            using (var banco = new modelo.restaurantedbEntidades())
            {
                banco.Database.Connection.ConnectionString = con;
                var query = banco.usuarios.FirstOrDefault(i => i.login.Equals(usuario)
                    && i.senha.Equals(senha));
                if (query == null) return false;
            }
            return true;
        }

        public void inserir(modelo.usuarios Registro)
        {
            using (var banco = new modelo.restaurantedbEntidades())
            {
                banco.Database.Connection.ConnectionString = con;
                try
                {
                    banco.usuarios.Add(Registro);
                    banco.SaveChanges();
                }
                catch (Exception Erro)
                {
                    MessageBox.Show("Erro ao Cadastrar:" + Erro.Message);
                }

            }
        }

        public void editar(modelo.usuarios Registro)
        {
            using (var banco = new modelo.restaurantedbEntidades())
            {
                banco.Database.Connection.ConnectionString = con;
                try
                {
                    modelo.usuarios velho = banco.usuarios.Find(Registro.cod);
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
                modelo.usuarios Registro = banco.usuarios.Find(Codigo);
                try
                {
                    banco.usuarios.Remove(Registro);
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
                    int cod = banco.usuarios.Max(i => i.cod);
                    return cod + 1;
                }
                catch (Exception)
                {
                    return 1;
                }

            }
        }


        public object listar()
        {
            using (var banco = new modelo.restaurantedbEntidades())
            {
                banco.Database.Connection.ConnectionString = con;
                var query = from linhas in banco.usuarios
                            orderby linhas.cod
                            select linhas;
                return query.ToList();
            }
        }
    }
}
