using EFDemo;
using EFDemo.Models;
using EFDemo.Repositories;

using System;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using (PandaContext context = new PandaContext())
            using (PandaRepository repository = new PandaRepository(context))
            {
                repository.Add(new Panda { Name = "Chen", Age = 50 });
                throw new Exception();
            }
        }
    }
}
