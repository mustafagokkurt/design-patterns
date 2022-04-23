using System;
using System.Collections.Generic;
using System.Text;

namespace _11_decorator
{
    //ConcreteDecorator
    class LoggingRepositoryDecorator<T> : DecoratorRepository<T> where T : class
    {
        readonly IRepository<T> _repository;
        public LoggingRepositoryDecorator(IRepository<T> repository) : base(repository)
        {
            _repository = repository;
        }
        public override void Add(T model)
        {
            base.Add(model);
            Console.WriteLine($"LOG : {typeof(T).Name} eklenmiştir.");
        }
        public override void Delete(T model)
        {
            base.Delete(model);
            Console.WriteLine($"LOG : {typeof(T).Name} silinmiştir.");
        }
        public override void Update(T model)
        {
            base.Update(model);
            Console.WriteLine($"LOG : {typeof(T).Name} güncellenmiştir.");
        }
    }
}
