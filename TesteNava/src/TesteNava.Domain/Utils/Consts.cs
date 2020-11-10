using System;
using System.Collections.Generic;
using System.Text;

namespace TesteNava.Domain.Utils
{
    public static class Consts
    {
        public static string WaitingPayment => "Aguardando Pagamento";
        public static string PaymentApproved => "Pagamento Aprovado";
        public static string Canceled => "Cancelada";
        public static string SentToTransport => "Enviado para Transportadora";
        public static string Delivered => "Entregue";
        public static string NoSeller => "A venda não pode ser inserida sem um vendedor";
        public static string NoItems => "A venda não pode ser inserida sem itens";
        public static string SaleRegisteredAlready => "Uma venda com esse Id já foi cadastrada. Insira outro";
        public static string Ok => "Venda cadastrada";
    }
}
