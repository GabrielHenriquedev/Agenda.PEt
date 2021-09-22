using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.PEt
{
    public struct Contatos
    {

        public Contatos(string nome, string SobreNome, string telefone, string email, int aniversario, string obervacao,
            string endereco, string cidade,string estado, string bairro, Tipos ContTipo, string CompletEndereco)
        {

            PriNome = nome;
            Segnd = SobreNome;
            NomeCompletp = nome + " "+ SobreNome;
            Numero = telefone;
            Aniver = aniversario;
            Obser = obervacao;
            AddEmail = email;
            AddEndereco = endereco;
            AddCidade = cidade;
            AddEstado = estado;
            AddBairro = bairro;
            tipoDeContato = ContTipo;
            Todoendereco = CompletEndereco;
        }

        public string PriNome { get; set; }
        public string Segnd { get; set; }
        public string NomeCompletp { get; set; }
        public string Numero { get; set; }
        public int Aniver { get; set; }
        public string Obser { get; set; }
        public string AddEmail { get; set; }
        public string AddEndereco { get; set; }
        public string AddCidade { get; set; }
        public string AddEstado { get; set; }
        public string AddBairro { get; set; }
        public Tipos tipoDeContato { get; set; }
        public string Todoendereco { get; set; }

        public string returlist()
        {
            string fotmatoDeContato = $"\nNome: {NomeCompletp}  \nTipo de contato: {tipoDeContato} \nemail: {AddEmail} \nEndereço:{Todoendereco} \nComentario :{Obser}    ";
            return fotmatoDeContato;
        }
    }
}
