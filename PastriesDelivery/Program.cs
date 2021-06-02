using System;

namespace PastriesDelivery
{
    internal class Program
    {
        private static void Main(string[] args)
        {
<<<<<<< HEAD
            Pastry pastry = new Pastry();
            Storage storage = new Storage();

=======
            bool result;
            var pastry = new Pastry();
           
            var availableProducts = new Storage()
            {
                Type = StorageType.AvailableProducts
            };

            var userOrders = new Storage()
            {
                Type = StorageType.UserOrders
            };

            var providerManager = new BusinessProviderManager(availableProducts);
            var consumerManager = new ConsumerManager(availableProducts, userOrders);
            var businessClientManager = new BusinessClientManager(availableProducts, userOrders);
>>>>>>> 6503217 (Code was improved.)
            while (true)
            {
                Messenger.GreetUser();
                var user = Console.ReadLine();

                if (user is "provider")
                {
<<<<<<< HEAD
                    WorkWithProvider(pastry, storage);
                }
=======
                    var User = new User()
                    {
                        Name = "Some Name",
                        Type = UserType.Provider,
                        PhoneNumber = "+380XXXXXXXXX",
                        Address = "Some adress"
                    };
>>>>>>> 6503217 (Code was improved.)

                if (user is "consumer")
                {
                    WorkWithConsumer(pastry, storage);

<<<<<<< HEAD
=======
                    var providerUI = new ProviderUI();
                    pastry = providerUI.AcceptData(providerManager, pastry);
                    var answer = providerUI.ConfirmOffer();

                    if (answer is "yes")
                    {
                        providerManager.AddNewOffer(pastry, User);
                        Messenger.ShowOfferAcceptedMessage();
                    }
>>>>>>> 6503217 (Code was improved.)
                }

                if (user is "business client")
                {
<<<<<<< HEAD
                    WorkWithBusinessClient(pastry, storage);
                }
            }
        }

        private static void WorkWithProvider(Pastry pastry, Storage storage)
        {
            var providerManager = new BusinessProviderManager(storage);
            var provider = new User
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
=======
                   
                    var consumer = new User
                    {
                        Type = UserType.Consumer
                    };

                    var displayer = new ConsumerUI(availableProducts);
                    Messenger.ShowAvailableProductsMessage();
                    result = consumerManager.CheckForDataPrescence();
>>>>>>> 6503217 (Code was improved.)

            if (answer is "yes")
            {
                providerManager.CreateOffer(pastry, provider);
                Messenger.ShowOfferAcceptedMessage();
            }
        }

        private static void WorkWithConsumer(Pastry pastry, Storage storage)
        {
            bool dataIsPresent;
            int id, amount;
            var consumerManager = new ConsumerManager(storage);
            var consumer = new User
            {
                Role = Role.Сustomer
            };
            var displayer = new CustomerUI(consumerManager);
            Messenger.ShowAvailableProductsMessage();
            dataIsPresent = consumerManager.CheckForDataPrescence();

            if (dataIsPresent)
            {
                displayer.DisplayAvailableProducts();

                id = GetId();
                amount = GetAmount();

                Messenger.ShowConfirmMessage();
                var answer = Console.ReadLine();

                if (answer is "yes")
                {
                    try
                    {
<<<<<<< HEAD
                        pastry = consumerManager.ChooseProduct(id, amount);
                        consumer = GetUserInformation(consumer);
                        consumerManager.CreateOrder(pastry, consumer);
                        Messenger.ShowOrderAcceptedMessage();
                    }
                    catch (ArgumentOutOfRangeException)
=======
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
                                pastry = consumerManager.ChooseProduct(id, amount);
                            }
                            catch (ArgumentOutOfRangeException)
                            {
                                Messenger.ShowUnavailableAmountMessage();
                                continue;
                            }
                            Messenger.ShowEnterAddressMessage();
                            consumer.Address = BusinessClientUI.GetAddress();
                            Messenger.ShowEnterPhoneNumberMessage();
                            consumer.PhoneNumber = BusinessClientUI.GetPhoneNumber();
                            Messenger.ShowEnterNameMessage();
                            consumer.Name = BusinessClientUI.GetUserName();
                            consumerManager.SaveOrder(pastry);
                            Messenger.ShowOrderAcceptedMessage();
                            consumerManager.SaveUser(consumer);
                        }
                    }

                    if (result is false)
>>>>>>> 6503217 (Code was improved.)
                    {
                        Messenger.ShowUnavailableAmountMessage();
                    }
                }
            }

            if (!dataIsPresent)
            {
                Messenger.ShowNoProductsMessage();
            }
        }

        private static void WorkWithBusinessClient(Pastry pastry, Storage storage)
        {
            bool dataIsPresent;
            int id, amount;
            var businessClientManager = new BusinessClientManager(storage);
            var businessClient = new User
            {
                Role = Role.Сustomer
            };
            Messenger.ShowAvailableProductsMessage();
            var displayer = new CustomerUI(businessClientManager);
            dataIsPresent = businessClientManager.CheckForDataPrescence();

            if (dataIsPresent)
            {
                displayer.DisplayAvailableProducts();
                id = GetId();
                amount = GetAmount();
                Messenger.ShowConfirmMessage();
                var answer = Console.ReadLine();

                if (answer is "yes")
                {
<<<<<<< HEAD
                    try
                    {
                        pastry = businessClientManager.ChooseProduct(id, amount);
                        businessClient = GetUserInformation(businessClient);
                        businessClientManager.CreateOrder(pastry, businessClient);
                        Messenger.ShowOrderAcceptedMessage();
=======
                    
                    var businessClient = new User()
                    {
                        Type = UserType.BusinessClient
                    };

                    Messenger.ShowAvailableProductsMessage();
                    var displayer = new BusinessClientUI(availableProducts);
                    result = businessClientManager.CheckForDataPrescence();
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
                                pastry = businessClientManager.ChooseProduct(id, amount);
                            }
                            catch (ArgumentOutOfRangeException)
                            {
                                Messenger.ShowUnavailableAmountMessage();
                                continue;
                            }
                            Messenger.ShowEnterAddressMessage();
                            businessClient.Address = BusinessClientUI.GetAddress();
                            Messenger.ShowEnterPhoneNumberMessage();
                            businessClient.PhoneNumber = BusinessClientUI.GetPhoneNumber();
                            Messenger.ShowEnterNameMessage();
                            businessClient.Name = BusinessClientUI.GetUserName();
                            businessClientManager.SaveOrder(pastry);
                            Messenger.ShowOrderAcceptedMessage();
                            businessClientManager.SaveUser(businessClient);
                        }
>>>>>>> 6503217 (Code was improved.)
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        Messenger.ShowUnavailableAmountMessage();
                    }

                }
            }

            if (!dataIsPresent)
            {
                Messenger.ShowNoProductsMessage();
            }
        }

        private static User GetUserInformation(User user)
        {
            var regex = new RegexPatterns();
            DataValidator dv = new DataValidator(regex);

            do
            {
                Messenger.ShowEnterAddressMessage();
                user.Address = Console.ReadLine();
            } while (!dv.ValidateAddress(user.Address));

            do
            {
                Messenger.ShowEnterPhoneNumberMessage();
                user.PhoneNumber = Console.ReadLine();
            } while (!dv.ValidatePhoneNumber(user.PhoneNumber));

            Messenger.ShowEnterNameMessage();
            user.Name = Console.ReadLine();
            return user;
        }

        private static int GetAmount()
        {
            int amount = default;

            do
            {
                Console.Write("Please, enter amount: ");

                if (int.TryParse(Console.ReadLine(), out int res))
                {
                    amount = res;
                    return amount;
                }

            } while (amount == default);

            return amount;
        }

        private static int GetId()
        {
            int id = default;

            do
            {
                Console.Write("Please, enter id: ");

                if (int.TryParse(Console.ReadLine(), out int res))
                {
                    id = res;
                    return id;
                }

            } while (id == default);

            return id;
        }
    }
}