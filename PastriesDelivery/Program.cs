using PastriesDelivery;
using System;

namespace PastriesDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            { 
                Messenger.GreetUser();
                var user = UserUI.DetectUser();
                if (user is "provider")
                {
                    var manager = new ProviderManager();
                    Messenger.SendOfferRequirments();
                    var pastry = new Pastry();
                    try
                    {
                        manager.AcceptData(pastry);
                        var answer = manager.ConfirmOffer();
                        if (answer is "yes")
                        {
                            manager.AddNewOffer(pastry);
                        }
                    }
                    catch (FormatException)
                    {
                        Messenger.ShowWrongDataMessage();
                    }
                }

                if (user is "end-user")
                {
                    var manager = new EndUserManager();
                    Messenger.ShowAvailableProductsMessage();
                    bool result = manager.CheckForDataPrescence();
                    if (result is true)
                    {
                        var displayer = new EndUserUI();
                        displayer.DisplayProviderData();
                        displayer.DisplayAvailableProducts();
                        Messenger.SendOrderRequirments();
                        var idAndAmount = EndUserUI.GetOrder();
                        var answer = manager.ConfirmOrder();
                        if (answer is "yes")
                        {
                            manager.ChooseProduct(idAndAmount);
                        }
                    }
                    if (result is false)
                    {
                        Messenger.ShowNoProductsMessage();
                    }
                }

                if (user is "business client")
                {
                    var manager = new BusinessClientManager();
                    Messenger.ShowAvailableProductsMessage();
                    bool result = manager.CheckForDataPrescence();
                    if (result is true)
                    {
                        var displayer = new BusinessClientUI();
                        displayer.DisplayProviderData();
                        displayer.DisplayAvailableProducts();
                        Messenger.SendOrderRequirments();
                        var idAndAmount = BusinessClientUI.GetOrder();
                        var answer = manager.ConfirmOrder();
                        if (answer is "yes")
                        {
                            manager.ChooseProduct(idAndAmount);
                        }
                    }
                    if (result is false)
                    {
                        Messenger.ShowNoProductsMessage();
                    }
                }
            }
        }
    }
}
