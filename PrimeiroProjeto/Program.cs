namespace PrimeiroProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int idade;
            string cidade;

            Console.WriteLine("digite o seu nome?");
            nome = Console.ReadLine();
            Console.WriteLine("digite sua idade?");
            idade = int.Parse (Console.ReadLine());
            Console.WriteLine("digite sua cidade?");
            cidade = Console.ReadLine();
         
            Console.WriteLine("Nome:{0}", nome);
            Console.WriteLine("idade:{0}", idade );
            Console.WriteLine("cidade:{0}", cidade);
            

           

            







        }
    }
}
