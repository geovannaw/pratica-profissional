using Sistema_Vendas.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Vendas.Controller
{
    public class DadosEmpresaController<T> : ControllerPai<T>
    {
        private DadosEmpresaDAO<T> dadosEmpresaDAO;

        public DadosEmpresaController() : base()
        {
            dadosEmpresaDAO = new DadosEmpresaDAO<T>();
        }

        public override void Alterar(T obj)
        {
            dadosEmpresaDAO.Alterar(obj);
        }

        public override void Delete(int idObj)
        {
            throw new NotImplementedException();
        }

        public override List<T> GetAll(bool incluiInativos)
        {
            return dadosEmpresaDAO.GetAll(incluiInativos);
        }

        public override T GetById(int idObj)
        {
            throw new NotImplementedException();
        }

        public List<string> GetCEPByCidadeId(int idCidade)
        {
            return dadosEmpresaDAO.GetCEPByCidadeId(idCidade);
        }

        public override void Salvar(T obj)
        {
            dadosEmpresaDAO.Salvar(obj);
        }
    }
}
