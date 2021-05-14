using System;
using System.Collections.Generic;

namespace PastriesDelivery
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var pastry = new Pastry();
            var storage = new Storage();
            var pastries = new List<Pastry>();
            while (true)
            {
                Messenger.GreetUser();

                var user = Console.ReadLine();

                if (user is "provider")
                {
                    var manager = new BusinessProviderManager(storage);
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
                        pastry = providerUI.AcceptData(manager, pastry);
                        var answer = providerUI.ConfirmOffer();

                        if (answer is "yes")
                        {
                            manager.AddNewOffer(pastry, User);
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
                    var displayer = new ConsumerUI(storage);
                    var manager = new ConsumerManager(storage);
                    var messenger = new Messenger();
                    var consumer = new User
                    {
                        Name = "Some name",
                        Type = UserType.Consumer
                    };

                    Messenger.ShowAvailableProductsMessage();
<<<<<<< HEAD
                    bool result = manager.CheckForDataPrescence();

=======
                    bool result = displayer.CheckForDataPrescence();
>>>>>>> 36b025b (Last fixes.)
                    if (result is true)
                    {                     
                        displayer.DisplayAvailableProducts();
                        Messenger.SendOrderRequirments();
                        var idAndAmount = ConsumerUI.GetOrder();
                        var id = ConsumerUI.ExtractId(idAndAmount);
                        var amount = ConsumerUI.ExtractAmount(idAndAmount);
                        Messenger.ShowConfirmMessage();
                        var answer = displayer.ConfirmOrder();
                        if (answer is "yes")
                        {
                            try
                            {
                                pastry = manager.ChooseProduct(id, amount);
                                result = manager.CheckAmount(id, amount);
                                if (result is false)
                                {
                                    messenger.ShowUnavailableAmountMessage(id, amount);
                                    continue;
                                }
                                consumer.Address = ConsumerUI.GetAddress();
                                consumer.PhoneNumber = ConsumerUI.GetPhoneNumber();
                                manager.SaveOrder(pastry);
                                Messenger.ShowOrderAcceptedMessage();
                                manager.SaveUser(consumer);
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
                    var displayer = new BusinessClientUI(storage);
                    var manager = new BusinessClientManager(storage);
                    var messenger = new Messenger();
                    var businessClient = new User()
                    {
                        Name = "Some name",
                        Type = UserType.BusinessClient
                    };

                    Messenger.ShowAvailableProductsMessage();
<<<<<<< HEAD
                    var displayer = new BusinessClientUI(storage);
                    bool result = manager.CheckForDataPrescence();
=======

                    bool result = displayer.CheckForDataPrescence();
>>>>>>> 36b025b (Last fixes.)
                    if (result is true)
                    {                      
                        displayer.DisplayAvailableProducts();
                        Messenger.SendOrderRequirments();
                        var idAndAmount = BusinessClientUI.GetOrder();
                        var id = BusinessClientUI.ExtractId(idAndAmount);
                        var amount = BusinessClientUI.ExtractAmount(idAndAmount);
                        Messenger.ShowConfirmMessage();
                        var answer = displayer.ConfirmOrder();
                        if (answer is "yes")
                        {
                            try
                            {
<<<<<<< HEAD
                                pastry = manager.ChooseProduct(id, amount);
                                messenger.ShowUnavailableAmountMessage(id, amount);
                                businessClient.Address = BusinessClientUI.GetAddress();
=======
                                var pastry = manager.ChooseProduct(id, amount);
                                messenger.ShowUnavailableAmountMessage(id, amount);
                                
                                businessClient.Address = BusinessClientUI.GetAddress();
                                Messenger.ShowEnterPhoneNumberMessage();
>>>>>>> 36b025b (Last fixes.)
                                businessClient.PhoneNumber = BusinessClientUI.GetPhoneNumber();
                                manager.SaveOrder(pastry);
                                Messenger.ShowOrderAcceptedMessage();
                                manager.SaveUser(businessClient);
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