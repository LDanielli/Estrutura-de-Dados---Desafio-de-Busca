class Program
{
    static void Main()
    {
        
        string[] vetor = { "Jihyo", "Mina", "Nayeon", "Sana", "Tzuyu", "Chaeyoung", "Dahyun", "Jeongyeon", "Momo","1", "2", "3","4", "5", "6"};
        
        Console.Write("Digite o nome ou número que deseja buscar: ");
        string busca = Console.ReadLine();

        
        bool encontrado = false;

        
        for (int i = 0; i < vetor.Length; i++)
        {
            if (vetor[i].Equals(busca, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"'{busca}' encontrado na posição {i} do vetor.");
                encontrado = true;
                break; 
            }
        }

        // Caso não tenha encontrado
        if (!encontrado)
        {
            Console.WriteLine("Valor não encontrado no vetor.");
        }

        Console.ReadKey();
    }
}