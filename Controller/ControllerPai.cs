using Sistema_Vendas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Vendas.Controller
{
    public abstract class ControllerPai<T>
    {
        public abstract List<T> GetAll(bool incluiInativos);

        public abstract void Salvar(T obj);

        public abstract void Delete(int idObj);

        public abstract void Alterar(T obj);

        public abstract T GetById(int idObj);
    }
}
