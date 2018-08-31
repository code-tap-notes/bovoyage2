using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoVoyage.Core.Entity;
using System.IO;

namespace BoVoyage.Core.DAL
{
    class ClientDonnees
    {
        const string CheminFichier = @"..\..\Fichier\Clients.txt";
        const char SeparateurChamps = ';';

        private List<Client> Clients;
        public List<Client> GetListe()
        {
            if (this.Clients == null)
            {
                LireFichier();
            }

            return this.Clients;
        }
        public List<Client> Ajouter(Client Client)
        {
            
            {
                this.Clients.Add(Client);
            }

            return this.Clients;
        }
        public List<Client> SupprimerListe(Client Client)
        {

            {
                this.Clients.Remove(Client);
            }

            return this.Clients;
        }

        public Client Enregistrer(Client Client)
        {
            Client.Id = GetListe().Count + 1;
            if (!this.Clients.Contains(Client))
            {
                this.Clients.Add(Client);
            }

            this.EcrireFichier();
            return Client;
        }

        public void SupprimerFichier(Client Client)
        {
            this.Clients.Remove(Client);
            this.EcrireFichier();
        }

        private void LireFichier()
        {
            this.Clients = new List<Client>();
            if (File.Exists(CheminFichier))
            {
                var lignes = File.ReadAllLines(CheminFichier);
                foreach (var ligne in lignes)
                {
                    var champs = ligne.Split(SeparateurChamps);

                    var Client = new Client();
                    Client.Id = int.Parse(champs[0]);
                    
                    Client.Nom = champs[1];
                    Client.Prenom = champs[2];
                    Client.Adresse = champs[3];
                    Client.Telephone = champs[4];
                    Client.Adresse = champs[5];
                    Client.DateNaissance = DateTime.Parse(champs[7]);
                    Client.Email= champs[6];
                    Clients.Add(Client);
                }
            }
        }

        private void EcrireFichier()
        {
            var contenuFichier = new StringBuilder();
            foreach (var Client in this.Clients)
            {
                contenuFichier.AppendLine(string.Join(
                                            SeparateurChamps.ToString(),
                                            Client.Id,
                                            Client.Nom,
                                            Client.Prenom,
                                            Client.Adresse,
                                            Client.Email));
            }

            File.WriteAllText(CheminFichier, contenuFichier.ToString());
        }


    }
}
