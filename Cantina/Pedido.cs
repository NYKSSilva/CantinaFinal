﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cantina
{
    public class Pedido
    {

        public string Cliente { get; set; }
        public string Pgmt { get; set; }
        public bool Viagem { get; set; }
        public List<Itens> Produtos { get; set; }
        public DateTime Hora { get; set; }
        public Status Status { get; set; }

        public Pedido(string cliente, string pgmt, DateTime hora, bool viagem, List<Itens> produtos, Status status)
        {
            Cliente = cliente;
            Pgmt = pgmt;
            Viagem = viagem;
            Produtos = produtos;
            Hora = hora;
            Status = status;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{Cliente} - ");

            if (this.Status == Status.PREPARANDO)
            {
                foreach (var produto in Produtos)
                {
                    if (produto.Chapa)
                    {
                        sb.Append($" {produto.Quantidade} x - {produto.Nome}  ");
                    }
                }

            }
            else
            {
                foreach (var produto in Produtos)
                    sb.Append($"{produto.Quantidade} X - {produto.Nome}");
            }
            return sb.ToString().TrimEnd(' ', '/');



            //  string produtoDescricao = string.Join(", ", Produtos.Select(p => $"{p.Quantidade} x {p.Nome} "));
            //return $"{Cliente} - {produtoDescricao} {Status}";
        }
    }
}