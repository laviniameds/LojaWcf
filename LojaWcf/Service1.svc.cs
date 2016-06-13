using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace LojaWcf
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public List<Fabricante> FabricanteSelect()
        {
            LojaDataContext dc = new LojaDataContext();
            var ret = from f in dc.Fabricantes
                      orderby f.Descricao
                      select f;
            if (ret.Count() == 0) return null;
            return ret.ToList();
        }

        public void FabricanteInsert(int id, string descricao)
        {
            LojaDataContext dc = new LojaDataContext();
            Fabricante f = new Fabricante { Id = id, Descricao = descricao };
            dc.Fabricantes.InsertOnSubmit(f);
            dc.SubmitChanges();
        }

        public void FabricanteUpdate(int id, string descricao)
        {
            LojaDataContext dc = new LojaDataContext();
            var ret = from f in dc.Fabricantes where f.Id == id select f;
            if (ret.Count() >= 0)
            {
                Fabricante f = ret.Single();
                f.Descricao = descricao;
                dc.SubmitChanges();
            }
        }

        public void FabricanteDelete(int id)
        {
            LojaDataContext dc = new LojaDataContext();
            var ret = from f in dc.Fabricantes where f.Id == id select f;
            if (ret.Count() >= 0)
            {
                Fabricante f = ret.Single();
                dc.Fabricantes.DeleteOnSubmit(f);
                dc.SubmitChanges();
            }
        }

        public List<Veiculo> VeiculoSelect()
        {
            LojaDataContext dc = new LojaDataContext();
            var ret = from v in dc.Veiculos
                      orderby v.Fabricante.Descricao, v.Modelo
                      select v;
            if (ret.Count() == 0) return null;
            return ret.ToList();
        }

        public List<Veiculo> VeiculoSelectDisponiveis()
        {
            LojaDataContext dc = new LojaDataContext();
            var ret = from v in dc.Veiculos
                      where !(v.PrecoVenda.HasValue)
                      orderby v.Fabricante.Descricao, v.Modelo
                      select v;
            if (ret.Count() == 0) return null;
            return ret.ToList();
        }

        public List<Veiculo> VeiculoSelectVendidos()
        {
            LojaDataContext dc = new LojaDataContext();
            var ret = from v in dc.Veiculos
                      where v.PrecoVenda.HasValue
                      orderby v.DataVenda
                      select v;
            if (ret.Count() == 0) return null;
            return ret.ToList();
        }

        public void VeiculoInsert(int id, string modelo, int ano, int idFab, 
            DateTime dataCompra, decimal valorCompra)
        {
            LojaDataContext dc = new LojaDataContext();
            Veiculo v = new Veiculo
            {
                Id = id,
                Modelo = modelo,
                Ano = ano,
                IdFabricante = idFab,
                DataCompra = dataCompra,
                ValorCompra = valorCompra,
                PrecoVenda = null,
                DataVenda = null,
                ValorVenda = null
            };
            dc.Veiculos.InsertOnSubmit(v);
            dc.SubmitChanges();
        }

        public void VeiculoUpdate(int id, decimal precoVenda, DateTime dataVenda, decimal valorVenda)
        {
            LojaDataContext dc = new LojaDataContext();
            var ret = from v in dc.Veiculos where v.Id == id select v;
            if (ret.Count() >= 0)
            {
                Veiculo v = ret.Single();
                v.PrecoVenda = precoVenda;
                v.DataVenda = dataVenda;
                v.ValorVenda = valorVenda;
                dc.SubmitChanges();
            }
        }

        public void VeiculoDelete(int id)
        {
            LojaDataContext dc = new LojaDataContext();
            var ret = from v in dc.Veiculos where v.Id == id select v;
            if (ret.Count() >= 0)
            {
                Veiculo v = ret.Single();
                dc.Veiculos.DeleteOnSubmit(v);
                dc.SubmitChanges();
            }
        }
    }
}
