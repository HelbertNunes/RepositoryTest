using System;
using System.Collections.Generic;
using System.Text;

namespace TesteNava.Domain.Utils
{
    public static class Consts
    {
        private static StringBuilder stringBuilder = new StringBuilder();
        public static string WaitingPayment => "Aguardando Pagamento";
        public static string PaymentApproved => "Pagamento Aprovado";
        public static string Canceled => "Cancelada";
        public static string SentToTransport => "Enviado para Transportadora";
        public static string Delivered => "Entregue";
        public static string NoSeller => "A venda não pode ser inserida sem um vendedor";
        public static string NoItems => "A venda não pode ser inserida sem itens";
        public static string SaleRegisteredAlready => "Uma venda com esse Id já foi cadastrada. Insira outro";
        public static string Ok => "Venda cadastrada";
        public static string DontExists => "O id enviado não corresponde a nenhuma venda";
        public static List<string> StatusList => new List<string> { WaitingPayment, PaymentApproved, Canceled, SentToTransport, Delivered };
        public static string StatusDontExistMessage => $"A mensagem de status de venda envida não existe.\nAs mensagens disponíveis são:\n{CreateMessage(StatusList)}";
        public static string InvalidStatusChange => "Mudança de status inválida";

        private static string CreateMessage(List<string> stringList)
        {
            foreach (var str in stringList)
            {
                stringBuilder.AppendLine($"-{str}");
            }

            var buitStr= stringBuilder.ToString();
            stringBuilder.Clear();

            return buitStr;
        }

    }
}
