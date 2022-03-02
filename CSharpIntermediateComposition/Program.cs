// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;

namespace CSharpIntermediateComposition // Note: actual namespace depends on the project name.
{
    public static class Program
    {
        static void Main(string[] args)
        {
            var dbMigrator = new DbMigrator(new Logger());

            var logger = new Logger();
            var installer = new Installer(logger);

            dbMigrator.Migrate();

            installer.Install();

  


        }
    }
}


/*
 Agenda:
1. What is Composition?
2. What are the benefits?
3. UML Notation
4. Syntax

So composition just like inheritance is another kind of relationship between two classes that allows one to contain the other.

We referred to composition as has a relationship.

For example we can say car has an engine just like inheritance with composition.

Benefits 
Code re-use
Flexiblity
A means to loose coupling

Example
DbMigrator requires logging.
Installer requires logging.


For example:

 private readonly Logger _logger;
        public Installer(Logger logger)
        {
            _logger = logger;
        }

So if you want to implement what you saw in the previous diagram would simply create an installer class

which has a private field called logger in the constructor of the installer class.

We get a logger object which we use to initialize that private field.


 */