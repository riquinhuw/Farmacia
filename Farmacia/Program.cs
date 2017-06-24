using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Farmacia
{
    class Program
    {
        //var Global

        //"banco de dados"
        public static string[] remedioNome = new string[11]; //Neusadina 40g
        public static string[] remedioDescricao = new string[11]; //Para dores de cabecas
        public static int[] remedioNumero = new int[11]; // Numeração para identificação
        public static int[] remedioQuantidade = new int[11]; //Quantidade em estoque
        public static string[] remedioPrevisao = new string[11]; // Previsão de quando vai voltar
        public static double[] remedioPreco = new double[11]; //Preço
        public static string[] remedioSintoma = new string[11];// dor - rim - meu deus
        public static string[] remedioForteNome = new string[11]; //Remedios com Receita
        public static string[] remedioForteDescricao = new string[11];//Para tonturas
        public static int[] remedioForteNumero = new int[11];
        public static int[] remedioForteQuantidade = new int[11];
        public static string[] remedioFortePrevisao = new string[11];
        public static double[] remedioFortePreco = new double[11];
        public static ArrayList clienteNome = new ArrayList(); // Seu zé
        public static ArrayList clienteIdade = new ArrayList();// 69
        public static ArrayList clienteEndereco = new ArrayList(); // Rua seu zezinho
        public static ArrayList clienteTelefone = new ArrayList();// (xx) xxx-xxx
        public static ArrayList clienteNumero = new ArrayList(); // 001
        public static ArrayList clienteCpf = new ArrayList(); // xxx.xxx.xxx-xx
        public static ArrayList clienteGoverno = new ArrayList(); // Bool ou String (string)
        public static float renda = 0;// Quanto foi que ganhou no dia
                                      //Vars comuns
        public static int menu = 1; // para o While, quando for 0 ou outra coisa o programa acaba
        public static string looping = "s";
        public static int erro1 = 0; //Caso que fique 1, ele fala "erro opção invalida"


        static void Main(string[] args)
        {
            //Declarar os remedios
            //NO DOG PLZ NO!              

            remedioNome[1] = "Neusadina 40g";
            remedioDescricao[1] = "Para dores";
            remedioNumero[1] = 1;
            remedioQuantidade[1] = 7;
            remedioPrevisao[1] = "Em estoque";
            remedioPreco[1] = 14.60;
            remedioSintoma[1] = "dor - febre - enxaqueca"; // Carlos é bonitao

            remedioNome[2] = "Paracetamol 750mg";
            remedioDescricao[2] = "Para dores e febre";
            remedioNumero[2] = 2;
            remedioQuantidade[2] = 9;
            remedioPrevisao[2] = "Em estoque";
            remedioPreco[2] = 16.83;
            remedioSintoma[2] = "dor forte - febre - resfriado";

            remedioNome[3] = "Losartana 50mg";
            remedioDescricao[3] = "Para combater a hipertensão";
            remedioNumero[3] = 3;
            remedioQuantidade[3] = 15;
            remedioPrevisao[3] = "Em estoque";
            remedioPreco[3] = 3.00;
            remedioSintoma[3] = "pressao alta - dores no peito ";

            remedioNome[4] = "Amoxicilina 500mg";
            remedioDescricao[4] = "Antibiótico";
            remedioNumero[4] = 4;
            remedioQuantidade[4] = 11;
            remedioPrevisao[4] = "Em estoque";
            remedioPreco[4] = 12.00;
            remedioSintoma[4] = "dor de garganta- bronquite - pneumonia";

            remedioNome[5] = "Buscopan 500mg";
            remedioDescricao[5] = "Para dores abdominais";
            remedioNumero[5] = 5;
            remedioQuantidade[5] = 2;
            remedioPrevisao[5] = "Em estoque - Acabando";
            remedioPreco[5] = 15.50;
            remedioSintoma[5] = "colica - dores estomacais ";

            remedioNome[6] = "Xantinon 120mg";
            remedioDescricao[6] = "Para combater doenças do fígado";
            remedioNumero[6] = 6;
            remedioQuantidade[6] = 0;
            remedioPrevisao[6] = "Em falta - chegará em breve";
            remedioPreco[6] = 2.00;
            remedioSintoma[6] = "dor forte - figado ";

            remedioNome[7] = "Diclofenaco Potássico 50mg";
            remedioDescricao[7] = "Para dores lombares";
            remedioNumero[7] = 7;
            remedioQuantidade[7] = 20;
            remedioPrevisao[7] = "Em estoque";
            remedioPreco[7] = 5.00;
            remedioSintoma[7] = "dor nas costas - reumatismo";

            remedioNome[8] = "Omeprazol 20mg";
            remedioDescricao[8] = "Para combater excesso de ácido no estômago";
            remedioNumero[8] = 8;
            remedioQuantidade[8] = 10;
            remedioPrevisao[8] = "Em estoque";
            remedioPreco[8] = 26.00;
            remedioSintoma[8] = "azia";

            remedioNome[9] = "Loratadina 10mg";
            remedioDescricao[9] = "Antialérgico";
            remedioNumero[9] = 9;
            remedioQuantidade[9] = 1;
            remedioPrevisao[9] = "Em estoque - Acabando";
            remedioPreco[9] = 15.56;
            remedioSintoma[9] = "espirros - alergias";

            remedioNome[10] = "Propranolol 40mg";
            remedioDescricao[10] = "Para doenças do coração";
            remedioNumero[10] = 10;
            remedioQuantidade[10] = 18;
            remedioPrevisao[10] = "Em estoque";
            remedioPreco[10] = 5.00;
            remedioSintoma[10] = "dor forte - dores no coraçao";

            // Codigo em si \/

            while (looping == "s")
            {
                Menu();

                switch (menu)
                {


                    //Listar os remedios
                    case 1:
                        Console.Clear();
                        ListarRemedios();
                        Sair();
                        break;

                    case 2:
                        Console.Clear();

                        break;

                    case 3:
                        Console.Clear();
                        VenderRemedios();
                        break;

                    case 4:
                        Console.Clear();
                        ReporRemedios();
                        break;

                    default:
                        erro1 = 1;
                        break;
                }

            }

        }


        static void Menu() //Nosso lindo MENU!!
        {
            Console.Clear();
            Console.WriteLine("********Farmacia dos Ricos*******\n\n\n");// Criar sistema de leitra de dados - Sistema de Receita(digite a receita)
            Console.WriteLine("1 - Ver estoque\n");//TODOS OS REMEDIOS (pode pensar em por filtros tb, usando outro Switch dentro dele)
            Console.WriteLine("2 - Consultar remedio\n");//Consultar como? nome( pesquisar sobre pesquisa)
            Console.WriteLine("3 - Vender remedio\n");// Retirar X do estoque - Desconto para pessoas do governo em base do salario
            Console.WriteLine("4 - Repor remedio  \n");
            Console.WriteLine("5 - Cadastrar cliente \n");// HU3 vamos mandar propaganda
            Console.WriteLine("6 - Pedido delivery");
            Console.WriteLine("7 - Salvar dados\n");//Pensar em um nome melhor
            Console.WriteLine("8 - Ler Dados\n");
            Console.WriteLine("9 - Sair");
            if (erro1 == 1) { Console.WriteLine("Opção invalida, por favor tente novamente"); erro1 = 0; }
            Console.WriteLine("Digite uma opção");
            menu = int.Parse(Console.ReadLine());
        }


        static void Sair()
        {
            Console.WriteLine("Você deseja continuar?(s/n)");
            looping = Console.ReadLine();
        }


        static void ListarRemedios()
        {
            int i = 1;
            for (i=1; i <= 10; i++)
            {
                Console.WriteLine("{0} - {1} - qtd {2} - {3}R$    ***{4}\n", remedioNumero[i], remedioNome[i], remedioQuantidade[i], remedioPreco[i], remedioPrevisao[i]);

            }
        }


        static void VenderRemedios()
        {
            Console.Clear();
            string[] compraNome = new string[11];
            double[] compraPreco = new double[11];
            int[] numero = new int[11];
            int i;
            int contador = 0;
            int[] qtd = new int[11];
            string resposta = "s";
            double total = 0;
            int pagamento = 0;
            double recebido = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("Digite o numero do remedio");
                numero[contador] = int.Parse(Console.ReadLine());
                Console.WriteLine("Nome:{0} - Preço:{1}R$\n", remedioNome[numero[contador]], remedioPreco[numero[contador]]);
                Console.WriteLine("Digite a quantidade:");
                qtd[contador] = int.Parse(Console.ReadLine());
                compraNome[contador] = remedioNome[numero[contador]];
                compraPreco[contador] = remedioPreco[numero[contador]];
                contador++;
                Console.WriteLine("Deseja adicionar outro remedio?(s/n)");
                resposta = Console.ReadLine();
            } while (resposta == "s");
            Console.Clear();
            Console.WriteLine("**********Carrinho de compras**********\n\n\n");
            for (i = 0; i <= contador-1; i++)
            {
                Console.WriteLine("Nome:{0} -qtd {1} preco={2}R$\n", compraNome[i], qtd[i], compraPreco[i] * qtd[i]);
                total = total + (compraPreco[i] * qtd[i]);
            }
            Console.WriteLine("\n\nTOTAL: {0}R$\n\n", total);

            Console.WriteLine("Escolha a forma de pagamento:/n");
            Console.WriteLine("1-Debito\n2-Credito\n3-A vista\n");
            pagamento = int.Parse(Console.ReadLine());
            switch (pagamento)
            {
                //Debito
                case 1:
                    Console.WriteLine("Insira o cartão");
                    Console.ReadLine();
                    Console.WriteLine("Digite a senha");
                    Console.ReadLine();
                    Console.WriteLine("Compra feito com sucesso\n\n");
                    Console.WriteLine("Obrigada pela compra, volte sempre :)");
                    break;
                //Credito
                case 2:
                    Console.WriteLine("Insira o cartão");
                    Console.ReadLine();
                    Console.WriteLine("Digite a senha");
                    Console.ReadLine();
                    Console.WriteLine("Compra feito com sucesso\n\n");
                    Console.WriteLine("Obrigada pela compra, volte sempre :)");
                    break;
                //a vista
                case 3:

                    Console.WriteLine("TOTAL A PAGAR:{0}R$", total);
                    Console.WriteLine("Digite o valor recebido");
                    recebido = int.Parse(Console.ReadLine());
                    Console.WriteLine("O Troco é de {0}", recebido - total);
                    Console.WriteLine("Ogrigada pela compra, VOLTE SEMPRE");
                    break;
            }

            Sair();
        }

        static void ConsultarRemedio()
        {
            int i = 0;
            string sintoma;
            Console.Clear();
            Console.WriteLine("Procurar por palavras-chaves de sintomas\n\n");
            Console.WriteLine("Informe um sintoma\n");
            sintoma = Console.ReadLine();
            foreach (string sintomass in remedioSintoma)
            {

                if (sintoma.ToLower().Contains(sintoma.ToLower()))
                {
                    Console.WriteLine("para {1} use: {0}   -{2}", remedioNome[i], remedioSintoma[i], remedioNumero[i]);
                }
                i++;
            }

        }

        static void ReporRemedios()
        {
            int x;
            Console.WriteLine("Digite o número remédio: ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe a quantidade: ");
            remedioQuantidade[x] = int.Parse(Console.ReadLine());
        }
    }

}