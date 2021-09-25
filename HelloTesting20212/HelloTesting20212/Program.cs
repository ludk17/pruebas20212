using System;

namespace HelloWorldTesting20212
{
    class Program
    {
        static void Main(string[] args)
        {
            new ProgramTest();


        }
    }

    class ProgramTest
    {
        public ProgramTest()
        {
            EsPalindromeCasoPrueba01();
        }
        public void EsPalindromeCasoPrueba01()
        {
            // cuatro fases 
            // 1. Intanciar la clase que voy a testear
            var utils = new StringUtilities();
            // 2. Prepar los datos a enviar
            string texto = "heeeh";
            // 3. Invocar al metodo a testear con los datos de prueba
            var result = utils.EsPalindrome(texto);
            if (result != false)
                throw new Exception("Caso de prueba fallido");
        }
    }
}
