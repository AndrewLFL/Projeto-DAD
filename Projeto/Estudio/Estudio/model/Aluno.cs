using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudio.model
{
    internal class Aluno
    {
        private String cpf;
        private String nome;
        private String endereco;
        private String numero;
        private String bairro;
        private String complemento;
        private String cep;
        private String cidade;
        private String estado;
        private String telefone;
        private String email;
        private int ativo;

        public Aluno(string cpf, string nome, string endereco, string numero, string bairro, string complemento, string cep, string cidade, string estado, string telefone, string email, int ativo)
        {
            this.cpf = cpf;
            this.nome = nome;
            this.endereco = endereco;
            this.numero = numero;
            this.bairro = bairro;
            this.complemento = complemento;
            this.cep = cep;
            this.cidade = cidade;
            this.estado = estado;
            this.telefone = telefone;
            this.email = email;
            this.ativo = ativo;
        }

        public Aluno(string cpf, string nome, string endereco, string numero, string bairro, string complemento, string cep, string cidade, string estado, string telefone, string email)
        {
            this.cpf = cpf;
            this.nome = nome;
            this.endereco = endereco;
            this.numero = numero;
            this.bairro = bairro;
            this.complemento = complemento;
            this.cep = cep;
            this.cidade = cidade;
            this.estado = estado;
            this.telefone = telefone;
            this.email = email;
        }

        public string getSetCpf { get => cpf; set => cpf = value; }
        public string getSetNome { get => nome; set => nome = value; }
        public string getSetEndereco { get => endereco; set => endereco = value; }
        public string getSetNumero { get => numero; set => numero = value; }
        public string getSetBairro { get => bairro; set => bairro = value; }
        public string getSetComplemento { get => complemento; set => complemento = value; }
        public string getSetCep { get => cep; set => cep = value; }
        public string getSetCidade { get => cidade; set => cidade = value; }
        public string getSetEstado { get => estado; set => estado = value; }
        public string getSetTelefone { get => telefone; set => telefone = value; }
        public string getSetEmail { get => email; set => email = value; }
        public int getSetAtivo { get => ativo; set => ativo = value; }
    }
}
