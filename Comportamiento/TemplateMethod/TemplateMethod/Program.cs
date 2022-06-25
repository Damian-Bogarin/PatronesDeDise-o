using System;

namespace RefactoringGuru.DesignPatterns.TemplateMethod.Conceptual
{
    // La clase abstracta define un método de plantilla que contiene un esqueleto de
    // algún algoritmo, compuesto de llamadas a (normalmente) primitivas abstractas
    // operaciones.
    //
    // Las subclases concretas deberían implementar estas operaciones, pero dejar el
    // método de plantilla intacto.
    abstract class AbstractClass
    {
        // El método de plantilla define el esqueleto de un algoritmo.
        public void TemplateMethod()
        {
            this.BaseOperation1();
            this.RequiredOperations1();
            this.BaseOperation2();
            this.Hook1();
            this.RequiredOperation2();
            this.BaseOperation3();
            this.Hook2();
        }

        // Estas operaciones ya tienen implementaciones.
        protected void BaseOperation1()
        {
            Console.WriteLine("Abstract Class dice: Estoy haciendo la mayor parte del trabajo");
        }

        protected void BaseOperation2()
        {
            Console.WriteLine("AbstractClass dice: Pero dejo que las subclases anulen algunas operaciones");
        }

        protected void BaseOperation3()
        {
            Console.WriteLine("Abstract Class dice: Pero de todos modos estoy haciendo la mayor parte del trabajo");
        }

        // Estas operaciones deben implementarse en subclases.
        protected abstract void RequiredOperations1();

        protected abstract void RequiredOperation2();

        // Estos son "ganchos". Las subclases pueden anularlas, pero no es
        // obligatorio ya que los hooks ya tienen default (pero vacio)
        // implementación. Los ganchos proporcionan puntos de extensión adicionales en algunos
        // lugares cruciales del algoritmo.
        protected virtual void Hook1() { }

        protected virtual void Hook2() { }
    }

    // Las clases concretas tienen que implementar todas las operaciones abstractas de la base
    // clase. También pueden anular algunas operaciones con un valor predeterminado.
    // implementación.
    class ConcreteClass1 : AbstractClass
    {
        protected override void RequiredOperations1()
        {
            Console.WriteLine("ConcreteClass1 dice: Operación implementada1");
        }

        protected override void RequiredOperation2()
        {
            Console.WriteLine("ConcreteClass1 dice: Implementado Operation2");
        }
    }

    // Por lo general, las clases concretas anulan solo una fracción de la clase base'
    // operaciones.
    class ConcreteClass2 : AbstractClass
    {
        protected override void RequiredOperations1()
        {
            Console.WriteLine("ConcreteClass2 dice: Implementado Operation1");
        }

        protected override void RequiredOperation2()
        {
            Console.WriteLine("ConcreteClass2 says: Implemented Operation2");
        }

        protected override void Hook1()
        {
            Console.WriteLine("ConcreteClass2 dice: Anulado Hook1");
        }
    }

    class Client
    {
        // El código del cliente llama al método de plantilla para ejecutar el algoritmo.
        // El código del cliente no tiene que conocer la clase concreta de un objeto que
        // trabaja con, siempre y cuando trabaje con objetos a través de la interfaz de
        // su clase base.
        public static void ClientCode(AbstractClass abstractClass)
        {
            // ...
            abstractClass.TemplateMethod();
            // ...
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("El mismo código de cliente puede funcionar con diferentes subclases:");

            Client.ClientCode(new ConcreteClass1());

            Console.Write("\n");

            Console.WriteLine("El mismo código de cliente puede funcionar con diferentes subclases:");
            Client.ClientCode(new ConcreteClass2());
        }
    }
}