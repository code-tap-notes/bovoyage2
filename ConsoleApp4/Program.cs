using System;
using System.Collections.Generic;
using System.Linq;
using BoVoyage.AppConsole;

namespace Bovoyage.AppConsole
{
    class Program
    {
        static IServiceClient serviceClient = new ServiceClient();

        static void Main(string[] args)
        {
            bool continuer = true;
            while (continuer)
            {
                var choix = AfficherMenu();
                switch (choix)
                {
                    case "1":
                        continuer = GererMenuClient();
                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                    case "q":
                    case "Q":
                        continuer = false;
                        break;
                    default:
                        Console.WriteLine("Choix invalide, l'application va fermer...");
                        continuer = false;
                        break;
                }
            }

            Console.WriteLine("Au Revoir !");
        }






        static bool GererMenuClient()
        {
            var choix = AfficherMenuClient();
            switch (choix)
            {
                case "1":
                    ListerClients();
                    return true;
                case "2":
                    return true;
                case "r":
                case "R":
                    return true;
                case "q":
                case "Q":
                    return false;
                default:
                    Console.WriteLine("Choix invalide, l'application va fermer...");
                    return false;
            }

        }



        static string AfficherMenu()
        {
            Console.Clear();
            Console.WriteLine("MENU\n");
            Console.WriteLine("1. Menu Client");
            Console.WriteLine("2. Menu Voyage");
            Console.WriteLine("3. Menu Reservation");
            Console.WriteLine("Q. Quitter");
            Console.Write("\nVotre choix: ");
            return Console.ReadLine();
        }






        static string AfficherMenuClient()
        {
            Console.Clear();
            Console.WriteLine("MENU CLIENT\n");
            Console.WriteLine("1. Lister client");
            Console.WriteLine("2. Ajouter client");
            Console.WriteLine("R. Retour");
            Console.WriteLine("Q. Quitter");
            Console.Write("\nVotre choix: ");
            return Console.ReadLine();
        }

        static string AfficherMenuVoyage()
        {
            Console.Clear();
            Console.WriteLine("MENU VOYAGE\n");
            Console.WriteLine("1. Lister voyage");
            Console.WriteLine("2. Ajouter voyage");
            Console.WriteLine("R. Retour");
            Console.WriteLine("Q. Quitter");
            Console.Write("\nVotre choix: ");
            return Console.ReadLine();
        }

        static string AfficherMenuReservation()
        {
            Console.Clear();
            Console.WriteLine("MENU RESERVATION\n");
            Console.WriteLine("1. Lister destination");
            Console.WriteLine("2. Ajouter destination");
            Console.WriteLine("R. Retour");
            Console.WriteLine("Q. Quitter");
            Console.Write("\nVotre choix: ");
            return Console.ReadLine();
        }




        static void CreerClient()
        {
            Console.Clear();
            Console.WriteLine("AJOUT D'UN CLIENT\n");

            var client = new Client();

            Console.WriteLine("Civilité:");
            personne.Email = Console.ReadLine();
            personne.Nom = OutilsConsole.SaisirChaineObligatoire("Nom:");
            personne.Prenom = OutilsConsole.SaisirChaineObligatoire("Prénom:");

            Console.WriteLine("Email:");
            personne.Email = Console.ReadLine();

            Console.WriteLine("Téléphone:");
            personne.Telephone = Console.ReadLine();

            personne.DateNaissance = OutilsConsole.SaisirDate("Date de naissance:");

            service.CreerClient(client);

            OutilsConsole.AfficherMessage("Contact ajouté !", ConsoleColor.Green);
        }


        static void CreerVoyage()
        {
            Console.Clear();
            Console.WriteLine("AJOUT D'UN VOYAGE\n");

            var voyage = new Voyage();

            voyage.DateAller = OutilsConsole.SaisirDateObligatoire("Date d'aller: ");
            voyage.DateRetour = OutilsConsole.SaisirDateObligatoire("Date de retour: ");
            voyage.PlacesDisponibles = OutilsConsole.SaisirEntierObligatoire("Places Disponible: ");
            voyage.PrixParPersonne = OutilsConsole.SaisirEntierObligatoire("Prix par personne: ");
            destination.Id = OutilsConsole.SaisirEntierObligatoire("Id: ");
            destination.Continent = OutilsConsole.SaisirChaineObligatoire("Continent: ");
            destination.Pays = OutilsConsole.SaisirChaineObligatoire("Pays: ");
            destination.Region = OutilsConsole.SaisirChaineObligatoire("Region: ");
            destination.Description = OutilsConsole.SaisirChaineObligatoire("Description: ");

            service.CreerVoyage(voyage);
            OutilsConsole.AfficherMessage("Contact ajouté !", ConsoleColor.Green);
        }


        static void CreerDossierReservation()
        {
            Console.Clear();
            Console.WriteLine("AJOUT D'UNE RESERVATION\n");

            var reservation = new Reservation();
            List<Voyage> voyages = new List<Voyage>;
            voyages = GetList();
            List<Client> clients = new List<Client>;
            clients = Getlist();
            List<Personne> personne = new List<Personne>;
            personnes = Getlist();

            voyage.Id = OutilsConsole.SaisirEntierObligatoire("ID voyage ");
            client.Id = OutilsConsole.SaisirEntierObligatoire("ID client ");
            personne.Id = OutilsConsole.SaisirEntierObligatoire("ID personne ");
            service.CreerDossierReservation(reservation);
            OutilsConsole.AfficherMessage("Contact ajouté !", ConsoleColor.Green);
        }



        static void ListerClients()
        {

            Console.Clear();
            Console.WriteLine("LISTE DES CLIENTS\n");

            List<Client> listeClients = serviceClient.GetClients.ToList();

            for (int i = 0; i < listeClients.Count; i++)
            {
                Client client = listeClients[i];
                Console.WriteLine((i + 1) + ". " + client.getNom());
            }

            var numeroClient = Console.ReadLine();

            OptionClient(listeClients[numeroClient]);
        }



        static void ListerVoyages()
        {

            Console.Clear();
            Console.WriteLine("LISTE DES VOYAGES\n");

            List<Voyage> listeVoyages = serviceVoyage.GetVoyages.ToList();

            for (int i = 0; i < listeVoyages.Count; i++)
            {
                Voyage voyage = listeVoyages[i];
                Console.WriteLine((i + 1) + ". " + voyage.getDestination());
            }

            var numeroVoyage = Console.ReadLine();

            OptionVoyage(listeVoyages[numeroVoyage]);
        }



        static void ListerReservations()
        {

            Console.Clear();
            Console.WriteLine("LISTE DES RESERVATIONS\n");

            List<Reservation> listeReservations = serviceReservation.GetReservations.ToList();

            for (int i = 0; i < listeReservations.Count; i++)
            {
                Reservation reservation = listeReservations[i];
                Console.WriteLine((i + 1) + ". " + reservation.getNom());
            }

            var numeroReservation = Console.ReadLine();

            OptionReservation(listeReservations[numeroReservation]);
        }






        static void OptionClient(Client client)
        {
            OutilsConsole.AfficherChamp(client.Nom, 10);
            OutilsConsole.AfficherChamp(client.Prenom, 10);
            //OutilsConsole.AfficherChamp(client.Civilite, 10);
            OutilsConsole.AfficherChamp(client.Id, 10);
            OutilsConsole.AfficherChamp(client.Email, 20);
            OutilsConsole.AfficherChamp(client.Telephone, 15);
            OutilsConsole.AfficherChamp(client.DateNaissance?.ToShortDateString(), 10);
            Console.WriteLine();
            Console.WriteLine("1. Modifier");
            Console.WriteLine("2. Supprimer");

            var option = Console.ReadLine();
            if (option == "1")
            {
                var modifOption = AfficherMenuModifierClient();
                switch (modifOption)
                {
                    case "1":
                        var nom = OutilsConsole.SaisirChaineObligatoire("Nom:");
                        client.setNom(nom);
                        break;
                    case "2":
                        var prenom = OutilsConsole.SaisirChaineObligatoire("Prenom:");
                        client.setPrenom(prenom);
                        break;
                    case "3":
                        var email = Console.ReadLine();
                        client.setemail(email);
                        break;
                    case "4":
                        var tel = Console.ReadLine();
                        client.setTelephone(tel);
                        break;
                    default:
                        return;
                }
                serviceClient.ModifierClient(client);
            }
            if (option == "2")
            {
                serviceClient.SupprimerClient(client);
            }
            return;
        }



        static void OptionVoyage(Voyage voyage)
        {
            OutilsConsole.AfficherChamp(voyage.Destination, 20);
            OutilsConsole.AfficherChamp(voyage.PlacesDisponible, 2);
            OutilsConsole.AfficherChamp(voyage.DateAller.ToString(), 10);
            OutilsConsole.AfficherChamp(voyage.DateRetour.ToString(), 10);
            OutilsConsole.AfficherChamp(voyage.setPrixParPersonne.ToString(), 4);
            //OutilsConsole.AfficherChamp(voyage.PrixParPersonne, 10);
            Console.WriteLine();
            Console.WriteLine("1. Modifier");
            Console.WriteLine("2. Supprimer");

            var option = Console.ReadLine();
            if (option == "1")
            {
                var modifOption = AfficherMenuModifierVoyage();
                switch (modifOption)
                {
                    case "1":
                        var destination = OutilsConsole.SaisirChaineObligatoire("Destination:");
                        voyage.setDestination(destination);
                        break;
                    case "2":
                        var placesdisponible = OutilsConsole.SaisirChaineObligatoire("Places Disponibles:");
                        voyage.setPlacesDisponible(placesdisponible);
                        break;
                    case "3":
                        var datealler = OutilsConsole.SaisirDateObligatoire("Date d'aller");
                        voyage.setDateAller(datealler);
                        break;
                    case "4":
                        var dateretour = OutilsConsole.SaisirDateObligatoire("Date de retour");
                        voyage.setDateRetour(dateretour);
                        break;
                    case "5":
                        var PrixParPersonne = OutilsConsole.SaisirEntierObligatoire("Prix par personne");
                        client.setPrixParPersonne(PrixParPersonne);
                        break;

                    //case "3":
                    //var prix = Console.ReadLine();
                    // client.setPrixParPersonne = prix;
                    //break;
                    default:
                        return;
                }
                serviceVoyage.ModifierVoyage(voyage);
            }
            if (option == "2")
            {
                serviceVoyage.SupprimerVoyage(voyage);
            }
            return;
        }



        static void OptionReservation(Reservation reservation)
        {
            OutilsConsole.AfficherChamp(client.Nom, 10);
            OutilsConsole.AfficherChamp(client.Prenom, 10);
            //OutilsConsole.AfficherChamp(client.Civilite, 10);
            OutilsConsole.AfficherChamp(client.Id, 10);
            OutilsConsole.AfficherChamp(client.Email, 20);
            OutilsConsole.AfficherChamp(client.Telephone, 15);
            OutilsConsole.AfficherChamp(client.DateNaissance?.ToShortDateString(), 10);
            Console.WriteLine();
            Console.WriteLine("1. Modifier");
            Console.WriteLine("2. Supprimer");

            var option = Console.ReadLine();
            if (option == "1")
            {
                var modifOption = AfficherMenuModifierClient();
                switch (modifOption)
                {
                    case "1":
                        var nom = OutilsConsole.SaisirChaineObligatoire("Nom:");
                        client.setNom(nom);


                        static string AfficherMenuModifierClient()
                        {
                            Console.Clear();
                            Console.WriteLine("MENU MODIFIER\n");
                            Console.WriteLine("1. Modifier Nom");
                            Console.WriteLine("2. Modifier Prenom");
                            Console.WriteLine("3. Modifer Email");
                            Console.WriteLine("4. Modifer Telephone");
                            Console.Write("\nVotre choix: ");
                            return Console.ReadLine();
                        }


                        static string AfficherMenuModifierVoyage()
                        {
                            Console.Clear();
                            Console.WriteLine("MENU MODIFIER\n");
                            Console.WriteLine("1. Modifier Destination");
                            Console.WriteLine("2. Modifier Places Disponibles");
                            Console.WriteLine("3. Modifer Date Aller");
                            Console.WriteLine("4. Modifer Date Retour");
                            Console.WriteLine("4. Modifer Prix Par Personne");
                            Console.Write("\nVotre choix: ");
                            return Console.ReadLine();
                        }


                }
            }
