using System;

namespace PastriesDelivery
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var availableProducts = new AvailableProducts();
            var endUserStorage = new EndUserStorage();
            var businessClientStorage = new BusinessClientStorage();
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
                        manager.AcceptData(availableProducts, pastry);
                        var answer = manager.ConfirmOffer();
                        if (answer is "yes")
                        {
                            manager.AddNewOffer(availableProducts, pastry);
                        }
                    }
                    catch (FormatException)
                    {
                        Messenger.ShowWrongDataMessage();
                    }
                }

                if (user is "end-user")
                {
                    var manager = new EndUserManager(availableProducts);
                    Messenger.ShowAvailableProductsMessage();
                    bool result = manager.CheckForDataPrescence();
                    if (result is true)
                    {
                        var displayer = new EndUserUI(availableProducts);
                        displayer.DisplayProviderData();
                        displayer.DisplayAvailableProducts();
                        Messenger.SendOrderRequirments();
                        var idAndAmount = EndUserUI.GetOrder();
                        var answer = manager.ConfirmOrder();
                        if (answer is "yes")
                        {
                            try
                            {
                                var pastry = manager.ChooseProduct(idAndAmount);
                                endUserStorage = manager.SendOrderToStorage(endUserStorage, pastry);
                            }
                            catch (FormatException)
                            {
                                Messenger.ShowWrongDataMessage();
                            }
                        }
                    }
                    if (result is false)
                    {
                        Messenger.ShowNoProductsMessage();
                    }
                }

                if (user is "business client")
                {
                    var manager = new BusinessClientManager(availableProducts);
                    Messenger.ShowAvailableProductsMessage();
                    bool result = manager.CheckForDataPrescence();
                    if (result is true)
                    {
                        var displayer = new BusinessClientUI(availableProducts);
                        displayer.DisplayProviderData();
                        displayer.DisplayAvailableProducts();
                        Messenger.SendOrderRequirments();
                        var idAndAmount = BusinessClientUI.GetOrder();
                        var answer = manager.ConfirmOrder();
                        if (answer is "yes")
                        {
                            try
                            {
                                var pastry = manager.ChooseProduct(idAndAmount);
                                businessClientStorage = manager.SendOrderToStorage(businessClientStorage, pastry);
                            }
                            catch (FormatException)
                            {
                                Messenger.ShowWrongDataMessage();
                            }
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