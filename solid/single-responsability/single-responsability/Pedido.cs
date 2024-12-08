using System;
using single_responsability;
using single_responsability.Services;

namespace single_respponsability 
{
    class Pedido: IPedidoService
    {
        public int Quantidade { get; set; }
        public DateTime Date {  get; set; }

        private ServiceLog infoLogger;

        private EmailService enviarEmail;


        public Pedido() 
        {
            infoLogger = new ServiceLog();
            enviarEmail = new EmailService();


        }
        public void IncluirPedido() 
        {
            try 
            {
                infoLogger.Info("Incluíndo pedido");
                enviarEmail.EMailFrom = "from_email@contato.com.br";
                enviarEmail.EMailTo = "to_email@contato.com.br";
                enviarEmail.EMailBody = "SRP";
                enviarEmail.EnviarEmail();


            } 
            catch (Exception e) 
            {
                
                Console.WriteLine(e.Message);
                
            }
        
        }

        public void DeletarPedido() 
        {

            try
            {
                //Codigo Para incluir o pedido


            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);

            }

        }
    
    }

}