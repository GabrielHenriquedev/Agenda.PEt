using System;

namespace Agenda.PEt
{
    class Program
    {




            static void Main(string[] args)
            {
                Contatos[] agenda = new Contatos[100];
                bool sair = true;
                int opcao = 0 ;            
            while(sair)
            {
                Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                Console.WriteLine("                      Menu              ");
                Console.WriteLine("          1 - Cadastre um contato       ");
                Console.WriteLine("          2 - listar                    ");
                Console.WriteLine("          3 - buscar                    ");
                Console.WriteLine("          0 - Para sair                 ");

                var entrada = Console.ReadLine();

                switch (entrada)
                {
                    case "1":
                        //if (opcao < agenda.Length) {
                        Console.WriteLine("Criando contato");
                        Contatos NovoCont = new Contatos();
                        Console.WriteLine("Digite o primeiro nome");
                        string Nome = Console.ReadLine();
                        NovoCont.PriNome = Nome;
                        Console.WriteLine("Digite o sobre nome");
                        string SobreN = Console.ReadLine();
                        NovoCont.Segnd = SobreN;
                        NovoCont.NomeCompletp = Nome +" " + SobreN;
                        Console.WriteLine("Digite o telefone com DDD");
                        string tel = Console.ReadLine();
                        NovoCont.Numero = tel;
                        Console.WriteLine("Selecione o tipo de contato");
                        Console.WriteLine("          Celular = 1       ");
                        Console.WriteLine("          Casa =  2         ");
                        Console.WriteLine("          Trabalho = 3      ");
                        Console.WriteLine("          Principal = 4     ");
                        Console.WriteLine("          Pager = 5         ");
                        Console.WriteLine("          Fax_Trabalho = 6  ");
                        Console.WriteLine("          Fax_Casa = 7      ");
                        Console.WriteLine("          Outro =8          ");
                        Tipos tipotel = (Tipos)int.Parse(Console.ReadLine());
                        NovoCont.tipoDeContato = tipotel;
                        Console.WriteLine("Digite Email do contato");
                        string Email = Console.ReadLine();
                        NovoCont.AddEmail = Email;
                        Console.WriteLine("Digite o endereço:");
                        string EntradaEndereco = Console.ReadLine();
                        NovoCont.AddEndereco = EntradaEndereco;
                        Console.WriteLine("Digite o bairro:");
                        string EntradaBairo = Console.ReadLine();
                        NovoCont.AddBairro = EntradaBairo;
                        Console.WriteLine("Digite a cidade:");
                        string EntradaCidade = Console.ReadLine();
                        NovoCont.AddCidade = EntradaCidade;
                        Console.WriteLine("Digite o estado:");
                        string EntradaEstado = Console.ReadLine();
                        NovoCont.AddEstado = EntradaEstado;
                        NovoCont.Todoendereco = EntradaEstado + ", " + EntradaCidade + ", " + EntradaBairo + ", " + EntradaEndereco;
                        Console.WriteLine("data de aniversario *Somente numeros*");
                        int DataAni = int.Parse(Console.ReadLine());
                        NovoCont.Aniver = DataAni;
                        Console.WriteLine("Digite a observaçao");
                        string Obs = Console.ReadLine();
                        NovoCont.Obser = Obs;
                        agenda[opcao] = NovoCont;
                        opcao++;

                        break;
                    case "2":

                        ListarContatos(agenda);

                        break;
                    case "3":
                        //    for(int i=0; i < agenda.Length; i++)
                        //{
                        Console.WriteLine("escolha o tipo de busca =");
                        Console.WriteLine("          1 - Apenas nome      ");
                        Console.WriteLine("          2 - Nome completo               ");
                        Console.WriteLine("          3 - Buscar por endereço                    ");
                        Console.WriteLine("          0 - tipo de contato             ");
                        String tipoDebusca = Console.ReadLine();

                        if (tipoDebusca == "1") {
                            BuscaPorNome(agenda); }
                        else if (tipoDebusca == "2") {
                            BuscaPorNomeComplet(agenda); }
                        else if (tipoDebusca == "3") {
                            BuscaPorTipo(agenda);
                        }

                        break;
                    case "0":
                        sair = false;
                        Console.WriteLine("O programa foi finalizado");

                        break;
                    
                    default:

                        Console.WriteLine("Opção Inválida! \nEscolha uma das opções apresentadas.");

                        break;

                }

            }
                
            }
        public static void ListarContatos(Contatos[] NovoCont) {

            for (var i = 0; i < NovoCont.Length; i++)
            {
                if (NovoCont[i].PriNome != null)
                {
                    Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-= ");
                    Console.WriteLine("-=-=-=-=-=-=-=-=* imprimindo agenda *-=-=-=-=-=-=-=-=-=-=-=-= ");
                    Console.WriteLine(NovoCont[i].returlist());
                }

            }
            
        }
        public static void BuscaPorNome(Contatos[] NovoCont)
        {
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-= ");
            Console.WriteLine("Digite o nome que deseja procurar:");
            string BucarNome = Console.ReadLine();
            
            for (int i=0; i < NovoCont.Length; i++)
            {
                
                    if (string.Equals(BucarNome, NovoCont[i].PriNome))
                    {

                        Console.WriteLine(NovoCont[i].returlist());

                        }
                else
                {
                    return;
                }


            }
        }
        public static void BuscaPorNomeComplet(Contatos[] NovoCont)
        {
                    Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-= ");
            Console.WriteLine("Digite o nome Completo de quem deseja procurar :");
            string BucarNome = Console.ReadLine();

            for (int i = 0; i < NovoCont.Length; i++)
            {

                if (string.Equals(BucarNome, NovoCont[i].NomeCompletp))
                {

                    Console.WriteLine(NovoCont[i].returlist());

                }
                else{return;
                }
            }
        }

        public static void BuscaPorTipo(Contatos[] NovoCont)
        {
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-= ");
            Console.WriteLine("Selecione o tipo de contato");
            Console.WriteLine("          Celular = 1       ");
            Console.WriteLine("          Casa =  2         ");
            Console.WriteLine("          Trabalho = 3      ");
            Console.WriteLine("          Principal = 4     ");
            Console.WriteLine("          Pager = 5         ");
            Console.WriteLine("          Fax_Trabalho = 6  ");
            Console.WriteLine("          Fax_Casa = 7      ");
            Console.WriteLine("          Outro =8          ");
            int BucarNome = int.Parse(Console.ReadLine());

            for (int i = 0; i < NovoCont.Length; i++)
            {

                if ((Tipos)NovoCont[i].tipoDeContato == (Tipos)BucarNome)
                {

                    Console.WriteLine(NovoCont[i].returlist());

                }
                else
                {
                    return;
                }
            }
            }
        public static void BuscaPorcidade(Contatos[] NovoCont)
        {
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-= ");
            Console.WriteLine("Digite a cidade de quem deseja procurar :");
            string BucarNome = Console.ReadLine();

            for (int i = 0; i < NovoCont.Length; i++)
            {

                if (string.Equals(BucarNome, NovoCont[i].AddCidade))
                {

                    Console.WriteLine(NovoCont[i].returlist());

                }
                else
                {
                    return;
                }
            }
        }
}
}
// Com a explicaçao da aula eu consegui de desevolver mais da atividade mas ainda ficou faltando funçoes

    
       
    
    

