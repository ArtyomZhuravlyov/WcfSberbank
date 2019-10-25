using System;
using ServiceReferenceSberbank;

namespace WCF_Sber
{
    public class WcfSberbank
    {
        //https://developer.sberbank.ru/doc/v1/acquiring/webservice-requests1pay информация по документации 

        private MerchantServiceClient _merchantServiceClient;
        private orderParams _orderParams;
        // private const string LOGIN;
        // private const string PASSWORD;


        public WcfSberbank()
        {
            _merchantServiceClient = new MerchantServiceClient();
            _merchantServiceClient.ClientCredentials.UserName.UserName = "";
            _merchantServiceClient.ClientCredentials.UserName.Password = "";
        }

        /// <summary>
        /// Отправить заказ
        /// </summary>
        /// <param name="returnUrl"></param>
        /// <param name="merchantOrderNumber">Номер (идентификатор) заказа в системе магазина, уникален для каждого магазина в пределах системы</param>
        /// <param name="amount"></param>
        /// <param name="description">Описание (не более 99 символов, запрещены к использованию %, +, конец строки \r и перенос строки \n).Параметры ответа:</param>
        public void SendOrder(string returnUrl, string merchantOrderNumber, long amount, string description = null )
        {
            _orderParams = new orderParams();
            _orderParams.returnUrl = returnUrl;
            _orderParams.merchantOrderNumber = merchantOrderNumber;
            _orderParams.amount = amount;
            _orderParams.description = description;
                
           var response = _merchantServiceClient.registerOrderAsync(_orderParams);
        }


        //Запрос отмены оплаты заказа to do




        /// <summary>
        ///  Запрос возврата средств оплаты заказа
        /// </summary>
        /// <param name="orderId"></param>
        public void RefundAmountOrder(string orderId)
        {
            refundOrder 
        }
    }
}
