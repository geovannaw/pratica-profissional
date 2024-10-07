using Sistema_Vendas.DAO;
using Sistema_Vendas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Vendas.Controller
{
    public class UsuarioController<T> : ControllerPai<T>
    {
        protected UsuarioDAO<T> usuarioDAO;

        public UsuarioController() : base()
        {
            usuarioDAO = new UsuarioDAO<T>();
        }
        public int GetUltimoCodigo()
        {
            return usuarioDAO.GetUltimoCodigo();
        }
        public override void Alterar(T obj)
        {
            usuarioDAO.Alterar(obj);
        }

        public override void Delete(int idObj)
        {
            usuarioDAO.Delete(idObj);
        }

        public override List<T> GetAll(bool incluirInativos)
        {
            return usuarioDAO.GetAll(incluirInativos);
        }

        public override T GetById(int idObj)
        {
            return usuarioDAO.GetById(idObj);
        }

        public override void Salvar(T obj)
        {
            usuarioDAO.Salvar(obj);
        }

        public bool JaCadastrado(string nome, int idAtual)
        {
            List<T> obj = usuarioDAO.GetAll(false);

            if (typeof(T) == typeof(UsuarioModel))
            {
                var Model = obj.Cast<UsuarioModel>().ToList();

                foreach (var usuario in Model)
                {
                    if (usuario.usuario.Equals(nome, StringComparison.OrdinalIgnoreCase) && usuario.idUsuario != idAtual)
                    {
                        return true;
                    }
                }
            }
            else
            {
                Console.WriteLine("Aviso: O tipo genérico T não é compatível.");
            }
            return false;
        }
    }
}
