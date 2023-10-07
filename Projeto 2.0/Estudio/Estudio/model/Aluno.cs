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
        private String rua;
        private String numero;
        private String bairro;
        private String complemento;
        private String cep;
        private String cidade;
        private String estado;
        private String telefone;
        private String email;
        private bool ativo;

        public Aluno(string cpf, string nome, string rua, string numero, string bairro, string complemento, string cep, string cidade, string estado, string telefone, string email, bool ativo)
        {
            this.cpf = cpf;
            this.nome = nome;
            this.rua = rua;
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

        public string getSetCpf { get => cpf; set => cpf = value; }
        public string getSetNome { get => nome; set => nome = value; }
        public string getSetRua { get => rua; set => rua = value; }
        public string getSetNumero { get => numero; set => numero = value; }
        public string getSetBairro { get => bairro; set => bairro = value; }
        public string getSetComplemento { get => complemento; set => complemento = value; }
        public string getSetCep { get => cep; set => cep = value; }
        public string getSetCidade { get => cidade; set => cidade = value; }
        public string getSetEstado { get => estado; set => estado = value; }
        public string getSetTelefone { get => telefone; set => telefone = value; }
        public string getSetEmail { get => email; set => email = value; }
        public bool getSetAtivo { get => ativo; set => ativo = value; }
    }
}
