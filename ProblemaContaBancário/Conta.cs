using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemaContaBancariaPoo
{
    internal class Conta
    {
        private string _nomeTitular;
        private string _cpf;
        private double _saldo;
        private int _idade;

        public Conta(string nomeTitular, string cpf, double saldo)
        {
            this.NomeTitular = nomeTitular;
            this.Cpf = cpf;
            this.Saldo = saldo;
            this.Idade = idade; 
        }

        public string NomeTitular { 
            get { return _nomeTitular; }
            
            set 
            { 
                if(value != null && value.Length > 2)
                {
                    _nomeTitular = value;
                }
                

        }

        public string Cpf { get; set; }
        public double Saldo { get; set; }

        public int Idade { get; set; }

        public void SetNomeTitular(string nomeTitular)
        { 
            if(nomeTitular != null && nomeTitular.Length>2)
            {
                this._nomeTitular = nomeTitular;
            }
               
        }

        public string GetNomeTitular()
        {
            return _nomeTitular;

        }
        public void Depositar(double valor)
        {
            _saldo += valor;
        }

        public bool Sacar(double valor)
        {
            if (_saldo >= valor)
            {
                _saldo -= valor;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

