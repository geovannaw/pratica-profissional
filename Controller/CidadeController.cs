﻿using Sistema_Vendas.DAO;
using Sistema_Vendas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Vendas.Controller
{
    public class CidadeController<T> : ControllerPai<T>
    {
        protected CidadeDAO<T> cidadeDAO;
        public CidadeController() : base()
        { 
            cidadeDAO = new CidadeDAO<T>();
        }
        public int GetUltimoCodigo()
        {
            return cidadeDAO.GetUltimoCodigo();
        }
        public override void Alterar(T obj)
        {
            cidadeDAO.Alterar(obj);
        }

        public override void Delete(int idObj)
        {
            cidadeDAO.Delete(idObj);
        }

        public override List<T> GetAll(bool incluirInativos)
        {
            return cidadeDAO.GetAll(incluirInativos);
        }

        public override T GetById(int idObj)
        {
            return cidadeDAO.GetById(idObj);
        }

        public string GetNomeEstadoByCidadeId(int idCidade)
        {
            return cidadeDAO.GetNomeEstadoByCidadeId(idCidade);
        }

        public override void Salvar(T obj)
        {
            cidadeDAO.Salvar(obj);
        }

        public bool JaCadastrado(string nome, int idEstado, int idAtual)
        {
            List<CidadeModel> cidades = cidadeDAO.GetAll(false).Cast<CidadeModel>().ToList();

            foreach (CidadeModel cidade in cidades)
            {
                if (string.Equals(cidade.Cidade, nome, StringComparison.OrdinalIgnoreCase) && cidade.idEstado == idEstado && cidade.idCidade != idAtual)
                //verifica o nome da cidade e o estado, pois podem existir cidades homônimas
                {
                    return true;
                }
            }
            return false;
        }
    }
}
