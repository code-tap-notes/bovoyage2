﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoVoyage.Core.Entity;

namespace BoVoyage.Core.DAL
{
    public class DossierReservationSQL
    {
        public List<DossierReservation> GetList()
        {

            using (var contexte = new Contexte())
            {
                return contexte.DossierReservations.ToList();
            }
        }
        public DossierReservation Ajouter(DossierReservation DossierReservation)
        {
            using (var contexte = new Contexte())
            {
                contexte.DossierReservations.Add(DossierReservation);
                contexte.SaveChanges();
            }
            return DossierReservation;
        }
        public void CreerDossierReservation(DossierReservation DossierReservation)
        {
            using (var contexte = new Contexte())
            {
                contexte.DossierReservations.Add(DossierReservation);

                contexte.SaveChanges();
            }
        }
        public List<DossierReservation> ListerDossierReservation()
        {
            using (var contexte = new Contexte())
            {
                return contexte.DossierReservations.
                    OrderBy(x => x.DateAller).

                     ToList();
            }

        }

        public void ModifierDossierReservation(DossierReservation Client)

        {
            using (var contexte = new Contexte())
            {
                contexte.DossierReservations.Attach(DossierReservation);
                contexte.Entry(DossierReservation).State = EntityState.Modified;
                contexte.SaveChanges();

            }
        }

        public void SupprimerDossierReservation(int id)
        {
            using (var contexte = new Contexte())
            {
                var DossierReservation = contexte.DossierReservations.Find(id);
                contexte.Entry(DossierReservation).State = EntityState.Deleted;
                contexte.SaveChanges();
            }
        }

    }
}
