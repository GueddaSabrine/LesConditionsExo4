using System;

namespace LesConditionsExo4
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Créer 2 variables : login et password, et leur attribuer une valeur. 
            ///À l’aide de la console, inviter l’utilisateur à renseigner un identifiant et un mot de passe. 
            ///Dans la console, selon les informations renseignées, afficher un des messages suivants : 
            ///« Mauvais identifiant ou mauvais mot de passe. » « Bienvenue à la Manu. » 
            ///Utiliser une condition switch.

            const string login = "Sabrine";
            const string password = "Sabrine";

            Console.WriteLine("Entrez votre identifiant");
            string enterLogin = Console.ReadLine();
            Console.WriteLine("Entrez votre MDP");
            string enterPaswword = Console.ReadLine();

            switch(enterLogin, enterPaswword)
            {
                case (login, password):
                    Console.WriteLine("Bienvenue à La Manu");
                        break;
                default:
                    Console.WriteLine("Mauvais identifiant ou mauvais mot de passe");
                        break;
            }


            /*string login = "sab";
            string password = "sab1";
            int success = 0;

            Console.WriteLine("Entrer votre login : ");
            login = Console.ReadLine();

            Console.WriteLine("Entrer votre password : ");
            password = Console.ReadLine();

            if (login == "sab" && password == "sab1")
            { success = 1; }

            switch (success)
                {
                    case 1:
                    Console.WriteLine("Connexion réussie");
                    Console.WriteLine("Bienvenue à la Manu");
                    break;

                    default:
                    Console.WriteLine("Mauvais identifiant ou mauvais mot de passe.");
                    Console.WriteLine("Bienvenue à la Manu");
                        break;
                }*/
        }
    }
}
