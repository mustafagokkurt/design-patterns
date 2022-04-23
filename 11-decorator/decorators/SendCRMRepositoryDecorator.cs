using System;
using System.Collections.Generic;
using System.Text;

namespace _11_decorator
{
    //ConcreteDecorator
    class SendCRMRepositoryDecorator<T> : DecoratorRepository<T> where T : class
    {
        readonly IRepository<T> _repository;
        public SendCRMRepositoryDecorator(IRepository<T> repository) : base(repository)
        {
            _repository = repository;
        }
        public override void Delete(T model)
        {
            base.Delete(model);
            Console.WriteLine("Kaydın silinmesi CRM veritabanına işlendi.");
        }
        public override void Update(T model)
        {
            base.Update(model);
            Console.WriteLine("Kaydın güncellenmesi CRM veritabanına işlendi.");
        }
    }
}
