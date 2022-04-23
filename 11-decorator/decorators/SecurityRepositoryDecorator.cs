using System;
using System.Collections.Generic;
using System.Text;

namespace _11_decorator
{
    //ConcreteDecorator
    class SecurityRepositoryDecorator<T> : DecoratorRepository<T> where T : class
    {
        readonly IRepository<T> _repository;
        public SecurityRepositoryDecorator(IRepository<T> repository) : base(repository)
        {
            _repository = repository;
        }
        public override T Get(int id)
        {
            Console.WriteLine("Güvenlik kontrolü yapılıyor...");
            return base.Get(id);
        }

        public override T GetAll()
        {
            Console.WriteLine("Güvenlik kontrolü yapılıyor...");
            return base.GetAll();
        }
    }
}
