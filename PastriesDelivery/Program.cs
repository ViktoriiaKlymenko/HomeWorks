using System;

namespace PastriesDelivery
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            bool result;
            int id = default, amount = default;
            var pastry = new Pastry();
            var storage = new Storage();
            var providerManager = new BusinessProviderManager(storage);
            var consumerManager = new ConsumerManager(storage);
            var businessClientManager = new BusinessClientManager(storage);
            while (true)
            {
                Messenger.GreetUser();

                var user = Console.ReadLine();

                if (user is "provider")
                {
                    var User = new User()
                    {
                        Name = "Some Name",
                        Role = Role.Provider,
                        PhoneNumber = "+380XXXXXXXXX",
                        Address = "Some adress"
                    };

                    Messenger.SendOfferRequirments();
                    pastry = ProviderUI.AcceptData(providerManager, pastry);
                    Messenger.ShowConfirmMessage();
                    var answer = Console.ReadLine();
                    if (answer is "yes")
                    {
                        providerManager.CreateOffer(pastry, User);
                        Messenger.ShowOfferAcceptedMessage();
                    }
                }

                if (user is "consumer")
                {
                    var consumer = new User
                    {
                        Role = Role.Сustomer
                    };
                    var displayer = new ConsumerUI(consumerManager);
                    Messenger.ShowAvailableProductsMessage();
                    result = consumerManager.CheckForDataPrescence();
                    if (result is true)
                    {
                        displayer.DisplayAvailableProducts();
                        do
                        {
                            Console.Write("Please, enter id: ");
                            if (int.TryParse(Console.ReadLine(), out int res))
                            {
                                id = res;
                            }
                        } while (pastry.Price == default);
                        do
                        {
                            Console.Write("Please, enter amount: ");
                            if (int.TryParse(Console.ReadLine(), out int res))
                            {
                                amount = res;
                            }
                        } while (pastry.Price == default);
                        Messenger.ShowConfirmMessage();
                        var answer = Console.ReadLine();
                        if (answer is "yes")
                        {
                            try
                            {
                                pastry = consumerManager.ChooseProduct(id, amount);
                            }
                            catch (ArgumentOutOfRangeException)
                            {
                                Messenger.ShowUnavailableAmountMessage();
                                continue;
                            }
                            Messenger.ShowEnterAddressMessage();
                            consumer.Address = Console.ReadLine();
                            Messenger.ShowEnterPhoneNumberMessage();
                            consumer.PhoneNumber = Console.ReadLine();
                            Messenger.ShowEnterNameMessage();
                            consumer.Name = Console.ReadLine();
                            consumerManager.CreateOrder(pastry, consumer);
                            Messenger.ShowOrderAcceptedMessage();
                        }
                    }
                    if (result is false)
                    {
                        Messenger.ShowNoProductsMessage();
                    }
                }

                if (user is "business client")
                {
                    var businessClient = new User()
                    {
                        Role = Role.Сustomer
                    };
                    Messenger.ShowAvailableProductsMessage();
                    var displayer = new BusinessClientUI(businessClientManager);
                    result = businessClientManager.CheckForDataPrescence();
                    if (result is true)
                    {
                        displayer.DisplayAvailableProducts();
                        do
                        {
                            Console.Write("Please, enter id: ");
                            if (int.TryParse(Console.ReadLine(), out int res))
                            {
                                id = res;
                            }
                        } while (pastry.Price == default);
                        do
                        {
                            Console.Write("Please, enter amount: ");
                            if (int.TryParse(Console.ReadLine(), out int res))
                            {
                                amount = res;
                            }
                        } while (pastry.Price == default);
                        Messenger.ShowConfirmMessage();
                        var answer = Console.ReadLine();
                        if (answer is "yes")
                        {
                            try
                            {
                                pastry = businessClientManager.ChooseProduct(id, amount);
                            }
                            catch (ArgumentOutOfRangeException)
                            {
                                Messenger.ShowUnavailableAmountMessage();
                                continue;
                            }
                            Messenger.ShowEnterAddressMessage();
                            businessClient.Address = Console.ReadLine();
                            Messenger.ShowEnterPhoneNumberMessage();
                            businessClient.PhoneNumber = Console.ReadLine();
                            Messenger.ShowEnterNameMessage();
                            businessClient.Name = Console.ReadLine();
                            businessClientManager.CreateOrder(pastry, businessClient);
                            Messenger.ShowOrderAcceptedMessage();
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