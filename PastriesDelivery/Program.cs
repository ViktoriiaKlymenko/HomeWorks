using System;

namespace PastriesDelivery
{
    internal class Program
    {
        private static void Main(string[] args)
        {
<<<<<<< HEAD
            var storageSerializer = new StorageSerializer
            {
                FileName = "serialized_storage.json"
            };

            var storage = storageSerializer.ExtractFomJsonFile();
            object locker = new object();
            var cacheService = new CacheService(new Cache(), storage);
            var pastry = new Pastry();
            
            var logger = new Logger
            {
                FileName = "logger_" + DateTime.Now.ToString("dd.MM.yyyy") + ".txt"
=======
            Pastry pastry = new Pastry();
            Storage storage = new Storage();
            var logger = new Logger();
            while (true)
            {
                Messenger.GreetUser();
                var user = Console.ReadLine();

                if (user is "provider")
                {
                    WorkWithProvider(pastry, storage, logger);
                }

                if (user is "consumer")
                {
                    WorkWithConsumer(pastry, storage, logger);
                }

                if (user is "business client")
                {
                    WorkWithBusinessClient(pastry, storage, logger);
                }
            }
        }

        private static void WorkWithProvider(Pastry pastry, IStorage storage, ILogger logger)
        {
            var providerManager = new BusinessProviderManager(storage, logger);
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

            if (answer is "yes")
            {
                providerManager.CreateOffer(pastry, provider);
                Messenger.ShowOfferAcceptedMessage();
            }
        }

        private static void WorkWithConsumer(Pastry pastry, IStorage storage, ILogger logger)
        {
            bool dataIsPresent;
            int id, amount;
            var consumerManager = new ConsumerManager(storage, logger);
            var consumer = new User
            {
                Role = Role.Сustomer
>>>>>>> main
            };
            var displayer = new CustomerUI(consumerManager);
            Messenger.ShowAvailableProductsMessage();
            dataIsPresent = consumerManager.CheckForDataPrescence();

<<<<<<< HEAD
            while (true)
            {
                logger.CreateFile();
                Messenger.GreetUser();
                var user = Console.ReadLine();

                if (user is "provider")
                {
                    WorkWithProvider(pastry, storage, logger, cacheService);
                }
=======
            if (dataIsPresent)
            {
                displayer.DisplayAvailableProducts();

                id = GetId();
                amount = GetAmount();
>>>>>>> main

                Messenger.ShowConfirmMessage();
                var answer = Console.ReadLine();

                if (answer is "yes")
                {
<<<<<<< HEAD
                    WorkWithConsumer(pastry, storage, logger, cacheService);
                }

                if (user is "business client")
                {
                    WorkWithBusinessClient(pastry, storage, logger, cacheService);
                }
                storageSerializer.SaveToJsonFile(storage);
            }
        }

        private static void WorkWithProvider(Pastry pastry, Storage storage, Logger logger, CacheService cacheService)
        {
            var providerManager = new BusinessProviderManager(storage, cacheService);
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

            if (answer is "yes")
            {
                providerManager.CreateOffer(pastry, provider);
                Messenger.ShowOfferAcceptedMessage();
            }
        }

        private static void WorkWithConsumer(Pastry pastry, Storage storage, Logger logger, CacheService cacheService)
        {
            bool dataIsPresent;
            int id, amount;
            var consumerManager = new ConsumerManager(storage, logger, cacheService);
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
=======
>>>>>>> main
                    try
                    {
                        pastry = consumerManager.ChooseProduct(id, amount);
                        consumer = GetUserInformation(consumer);
                        consumerManager.CreateOrder(pastry, consumer);
                        Messenger.ShowOrderAcceptedMessage();
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

<<<<<<< HEAD
        private static void WorkWithBusinessClient(Pastry pastry, Storage storage, Logger logger, CacheService cacheService)
        {
            bool dataIsPresent;
            int id, amount;
            var businessClientManager = new BusinessClientManager(storage, logger, cacheService);
=======
        private static void WorkWithBusinessClient(Pastry pastry, IStorage storage, ILogger logger)
        {
            bool dataIsPresent;
            int id, amount;
            var businessClientManager = new BusinessClientManager(storage, logger);
>>>>>>> main
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
                    try
                    {
                        pastry = businessClientManager.ChooseProduct(id, amount);
                        businessClient = GetUserInformation(businessClient);
                        businessClientManager.CreateOrder(pastry, businessClient);
                        Messenger.ShowOrderAcceptedMessage();
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
<<<<<<< HEAD
            var regex = new RegexPatterns();
            DataValidator dv = new DataValidator(regex);

=======
            Messenger.ShowExitMessage();
>>>>>>> main
            do
            {
                Messenger.ShowEnterAddressMessage();
                user.Address = Console.ReadLine();
<<<<<<< HEAD
            } while (!dv.ValidateAddress(user.Address));
=======
            } while (!DataValidator.IsAddressValid(user.Address));
>>>>>>> main

            do
            {
                Messenger.ShowEnterPhoneNumberMessage();
                user.PhoneNumber = Console.ReadLine();
<<<<<<< HEAD
            } while (!dv.ValidatePhoneNumber(user.PhoneNumber));
=======
            } while (!DataValidator.IsPhoneNumberValid(user.PhoneNumber));
>>>>>>> main

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
<<<<<<< HEAD

=======
>>>>>>> main
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
<<<<<<< HEAD

=======
>>>>>>> main
            } while (id == default);

            return id;
        }
    }
}