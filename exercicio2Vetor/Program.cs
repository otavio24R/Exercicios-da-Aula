namespace exercicio2Vetor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o número de produtos: ");
            int n = int.Parse(Console.ReadLine());

            // criar o vetor para armazenar os produtos
            Produtos[] produtos = new Produtos[n];

            // ler os dados dos produtos e armazenar no vetor
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Digite o nome do produto {i + 1}: ");
                string nome = Console.ReadLine();
                Console.Write($"Digite o preço do produto {i + 1}: ");
                double preco = double.Parse(Console.ReadLine());
                produtos[i] = new Produtos(nome, preco);
            }

            // calcular o preço médio dos produtos
            double media = 0;
            for (int i = 0; i < n; i++)
            {
                media += produtos[i].Preco;
            }
            media /= n;

            // mostrar o preço médio dos produtos na tela
            Console.WriteLine($"O preço médio dos {n} produtos é: {media.ToString("F2")}");
        }
    }



}
    
