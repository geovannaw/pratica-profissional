﻿using Sistema_Vendas.DAO;
using Sistema_Vendas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Vendas.Controller
{
    public class ContasPagarController<T> : ControllerPai<T> where T : ContasPagarModel
    {
        protected ContasPagarDAO contasPagarDAO;
        public ContasPagarController() : base()
        {
            contasPagarDAO = new ContasPagarDAO();
        }
        public override void Alterar(T obj)
        {
            contasPagarDAO.Alterar(obj as ContasPagarModel);
        }

        public override void Delete(int idObj)
        {
            throw new NotImplementedException();
        }

        public override List<T> GetAll(bool incluiInativos)
        {
            List<T> lista = new List<T>();
            var ordens = contasPagarDAO.GetAll(incluiInativos);
            foreach (var item in ordens)
            {
                lista.Add(item as T);
            }
            return lista;
        }

        public override T GetById(int idObj)
        {
            throw new NotImplementedException();
        }

        public T GetContaById(int numero, int modelo, int serie, int idFornecedor, int parcela)
        {
            return contasPagarDAO.GetContaById(numero, modelo, serie, idFornecedor, parcela) as T;
        }

        public override void Salvar(T obj)
        {
            contasPagarDAO.Salvar(obj as ContasPagarModel);
        }
        public bool CancelarConta(T obj)
        {
            return contasPagarDAO.CancelarConta(obj as ContasPagarModel);
        }
        public bool JaCadastrado(int numeroNota, int modelo, int serie, int idFornecedor, int parcela, bool incluindo)
        {
            List<ContasPagarModel> contasPagar = contasPagarDAO.GetAll(false).Cast<ContasPagarModel>().ToList();

            foreach (ContasPagarModel conta in contasPagar)
            {
                if (conta.numeroNota == numeroNota &&
                    conta.modelo == modelo &&
                    conta.serie == serie &&
                    conta.idFornecedor == idFornecedor &&
                    conta.parcela == parcela)
                {
                    //se estiver incluindo e já existe uma conta com a mesma chave composta
                    if (incluindo)
                    {
                        return true;
                    }
                    else
                    {
                        //se estiver alterando e encontrou outra conta com a mesma chave composta, diferente da atual
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
