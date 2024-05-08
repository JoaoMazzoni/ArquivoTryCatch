internal class Program
{
    private static void Main(string[] args)
    {
        string line;
        try
        { 
            StreamReader sr = new StreamReader("C:\\5by5\\teste.txt");
            line = sr.ReadLine(); //Lê uma linha (primeira)

            while(line != null) //Equanto a linha não for nula
            {
                Console.WriteLine(line); //Imprime a linha
                line = sr.ReadLine(); //Le a próxima linha

            }
            sr.Close();
            Console.ReadLine();
        }
        catch (Exception e) //Só executa se ocorrer um erro
        {
            Console.WriteLine("Exception: " + e.Message); //Imprime a mensagem de erro 
        }
        finally //Executa independente se ocorreu erro ou não
        {
            Console.WriteLine("Executing finally block."); 
        }


    }
}