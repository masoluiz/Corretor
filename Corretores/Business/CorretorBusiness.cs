using Corretores.Models.Entity;
using Corretores.Repository;
using System;

namespace Corretores.Business
{
    public class CorretorBusiness
    {
        CorretorRepository _repository;

        public CorretorBusiness()
        {
            _repository = new CorretorRepository();
        }

        public string Add(CorretorEntity corretor)
        {
            try
            {
                corretor.Cadastro = DateTime.Now.Date;
                _repository.Add(corretor);
                return "Corretor adicionado com suscesso !!!";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public CorretorEntity GetById(int id)
        {
            return _repository.GetById(id);
        }
        public string Update(CorretorEntity corretor)
        {
            try
            {
                _repository.Update(corretor);
                return "Dados atualizados com suscesso !!!";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string Remove(object id)
        {
            try
            {
                _repository.Remove(id);
                return "Dados removidos com suscesso !!!";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public bool Existe(CorretorEntity corretor)
        {
            return _repository.Existe(corretor);
        }
    }
}
