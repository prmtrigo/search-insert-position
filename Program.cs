namespace search_insert_position;
class Program
{
    public int AcharPosicao(int[] vetor, int numero){

        if(vetor == null || vetor.Length == 0){
            //mensagem de exceção -> erro
            Console.Write("HOUVE UM ERRO!");
            return -1;
        }

        int inicio = 0;
        int fim = vetor.Length -1;

        while(inicio <= fim){

            //definindo o meio
            int meio = fim + (inicio - fim) / 2;

            //retornando o meio, se ele for igual ao número
            if (vetor[meio] == numero){
                return meio;
            }
            else if (vetor[meio] > numero){
                //se o numero for maior que o meio
                //AUMENTA O INICIO
                fim = meio - 1;
            }
            else{
                //se for menor
                //DIMINUI O FIM
                inicio = meio + 1;
            }
        }

        return inicio;
    }

    static void Main(string[] args)
    {
        Program p = new Program();

        Console.WriteLine("Escreva o tamanho do vetor: ");

        //tamanho
        int tamanho = Convert.ToInt32(Console.ReadLine());
        //adicionando o vetor
        int[] vetor = new int[tamanho];

        //coloque o número na posição
        Console.WriteLine("Escreva o tamanho do vetor: ");

        //adicionando valor!
        for (int i = 0; i < tamanho; i++)
        {
            Console.WriteLine("Escreva a posição " + i + ":");
            vetor[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Escreva o número a ser achado: ");
        //definindo número
        int numero = Convert.ToInt32(Console.ReadLine());

        Console.Write("A posição é: ");
        Console.WriteLine(p.AcharPosicao(vetor,numero));
    }

    
}
