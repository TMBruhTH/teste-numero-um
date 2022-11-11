namespace teste_numero_um
{
    public class teste_produto
    {
        public static void produto()
        {
            List<produto> listaProduto = new List<produto>();

            for (int i = 0; i < 2; i++)
            {
                produto produto = new produto();

                produto.COD_PRODUTO = i;

                Console.Write("Insira o nome do produto: ");
                produto.NOME_PRODUTO = Console.ReadLine();

                Console.Write("Insira o saldo do produto: ");
                produto.SALDO = Convert.ToSingle(Console.ReadLine());

                Console.Write("Informe se o produto é ENTRADA ou SAÍDA?: ");
                produto.ENTRADA_SAIDA = Console.ReadLine();

                Console.Write("Informe a quantidade: ");
                produto.QUANTIDADE = Convert.ToSingle(Console.ReadLine());
                
                Console.Write("Informe a posição do estoque: ");
                produto.POSICAO_ESTOQUE = Console.ReadLine();

                produto.FATIVO = true;

                listaProduto.Add(produto);
                Console.WriteLine();
            }

            for (int i = 0; i < listaProduto.Count; i++)
            {
                Console.Write("COD_PRODUTO - " + listaProduto[i].COD_PRODUTO +
                    " ,NOME_PRODUTO - " + listaProduto[i].NOME_PRODUTO + " ,SALDO - " + listaProduto[i].SALDO +
                    " ,ENTRADA/SAIDA - " + listaProduto[i].ENTRADA_SAIDA +
                    " ,QUANTIDADE - " + listaProduto[i].QUANTIDADE + " ,POSIÇÃO DO ESTOQUE - " + listaProduto[i].POSICAO_ESTOQUE);

                Console.WriteLine();
            }
        }

        public static void Menu()
        {
            int valor;
            Console.WriteLine("1 - Cadastrar produto no estoque");
            Console.WriteLine("2 - Atualizar posição de produto no estoque");
            valor = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            switch (valor)
            {
                case 1:
                    produto();
                    break;
                default:
                    break;
            }
        }
    }
}