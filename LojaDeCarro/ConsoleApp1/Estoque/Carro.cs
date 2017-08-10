﻿//namespace utilizado para organização do codigo, pensado no modulo de estoque
using System;

namespace Cappta.LojaDeCarro.Estoque
{
    //representa o objeto Carro , assina com a interface IVeiculo
   public class Carro : IVeiculo
    {
        //que tem as características de chassi,marca,modelo, cor, ano e valor
        //utiliza as propriedades get e set
        public string chassi { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
        public string cor { get; set; }
        public int ano { get; set; }
        public double valor { get; set; }

        //construtor da classe carro, que exige que quando o objeto seja criado seja enviado alguns valores.
        public Carro(string chassi, string marca, string modelo, string cor,int ano, double valor)
        {
            //valida os campos durante a criação do objeto Carro
            //verifica se o chassi, marca, modelo, cor, ano e valor, não tem espaço em branco e não é vazio e não é nulo
            if (string.IsNullOrEmpty(chassi)  || string.IsNullOrWhiteSpace(chassi)  || string.IsNullOrEmpty(marca) || string.IsNullOrWhiteSpace(marca)
                  || string.IsNullOrEmpty(modelo)  ||  string.IsNullOrWhiteSpace(modelo) && string.IsNullOrEmpty(cor)  || string.IsNullOrWhiteSpace(cor) 
                  || string.IsNullOrEmpty(ano.ToString())  || string.IsNullOrWhiteSpace(ano.ToString()) || string.IsNullOrEmpty(valor.ToString()) || 
                  string.IsNullOrWhiteSpace(valor.ToString()) )
              {  
                 //lança uma exceção
                throw new ArgumentNullException();

              }

            else
            {//estes atributos da classe carro representado pelo this, recebe os valores do construtor
                this.chassi = chassi;
                this.marca = marca;
                this.modelo = modelo;
                this.cor = cor;
                this.ano = ano;
                this.valor = valor;
            }

        }

    }
}
