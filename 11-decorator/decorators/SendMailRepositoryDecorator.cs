using System;
using System.Collections.Generic;
using System.Text;

namespace _11_decorator
{
    //ConcreteDecorator
    class SendMailRepositoryDecorator<T> : DecoratorRepository<T> where T : class
    {
        readonly IRepository<T> _repository;
        public SendMailRepositoryDecorator(IRepository<T> repository) : base(repository)
        {
            _repository = repository;
        }
        public override void Update(T model)
        {
            base.Update(model);
            Console.WriteLine($"{DateTime.Now} | Yöneticiye mail gönderildi...");
        }
    }
}
