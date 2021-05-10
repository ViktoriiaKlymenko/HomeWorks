using System;

namespace PastriesDelivery
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var storage = new Storage();
            while (true)
            {
                static string DetectUser()
                {
                    return Console.ReadLine();
                }
                Messenger.GreetUser();

                var user = DetectUser();

                if (user is "provider")
                {
                    var pastry = new Pastry();
                    var manager = new BusinessProviderManager();
                    var User = new User()
                    {
                        Name = "Some Name",
                        Type = UserType.Provider,
                        PhoneNumber = "+380XXXXXXXXX",
                        Address = "Some adress"
                    };

                    Messenger.SendOfferRequirments();

                    try
                    {
                        var providerUI = new ProviderUI(storage);
                        pastry = providerUI.AcceptData(pastry);
                        var answer = providerUI.ConfirmOffer();

                        if (answer is "yes")
                        {
                            storage = manager.AddNewOffer(storage, pastry, User);
                            Messenger.ShowOfferAcceptedMessage();
                        }
                    }
                    catch (FormatException)
                    {
                        Messenger.ShowWrongDataMessage();
                    }
                }

                if (user is "consumer")
                {
                    var manager = new ConsumerManager(storage);
                    var messenger = new Messenger(storage);
                    var consumer = new User
                    {
                        Name = "Some name",
                        Type = UserType.Consumer
                    };

                    Messenger.ShowAvailableProductsMessage();
                    bool result = manager.CheckForDataPrescence();
                    if (result is true)
                    {
                        var displayer = new ConsumerUI(storage);

                        displayer.DisplayAvailableProducts();
                        Messenger.SendOrderRequirments();
                        var idAndAmount = ConsumerUI.GetOrder();
                        Messenger.ShowConfirmMessage();
                        var answer = displayer.ConfirmOrder();
                        if (answer is "yes")
                        {
                            try
                            {
                                var pastry = manager.ChooseProduct(idAndAmount, storage);
                                messenger.ShowUnavailableAmountMessage(idAndAmount);
                                Messenger.ShowEnterAddressMessage();
                                consumer.Address = ConsumerUI.GetAddress();
                                Messenger.ShowEnterPhoneNumberMessage();
                                consumer.PhoneNumber = ConsumerUI.GetPhoneNumber();
                                storage = manager.SendOrderToStorage(storage, pastry);
                                Messenger.ShowOrderAcceptedMessage();
                                storage = manager.SendUserToStorage(storage, consumer);
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
                    var manager = new BusinessClientManager(storage);
                    var messenger = new Messenger(storage);
                    var businessClient = new User()
                    {
                        Name = "Some name",
                        Type = UserType.BusinessClient
                    };

                    Messenger.ShowAvailableProductsMessage();

                    bool result = manager.CheckForDataPrescence();
                    if (result is true)
                    {
                        var displayer = new BusinessClientUI(storage);

                        displayer.DisplayAvailableProducts();
                        Messenger.SendOrderRequirments();
                        var idAndAmount = BusinessClientUI.GetOrder();
                        Messenger.ShowConfirmMessage();
                        var answer = displayer.ConfirmOrder();
                        if (answer is "yes")
                        {
                            try
                            {
                                var pastry = manager.ChooseProduct(idAndAmount, storage);
                                messenger.ShowUnavailableAmountMessage(idAndAmount);
                                
                                businessClient.Address = BusinessClientUI.GetAddress();
                                
                                businessClient.PhoneNumber = BusinessClientUI.GetPhoneNumber();
                                storage = manager.SendOrderToStorage(storage, pastry);
                                Messenger.ShowOrderAcceptedMessage();
                                storage = manager.SendUserToStorage(storage, businessClient);
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