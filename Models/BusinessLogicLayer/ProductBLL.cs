﻿using System;
using System.Collections.ObjectModel;
using Tema3.Exceptions;
using Tema3.Models;

namespace Tema3.Models
{
    public class ProductBLL
    {
        public ObservableCollection<Product> ProductsList { get; set; }
        //public string ErrorMessage { get; set; }

        //ProductDAL productDAL = new ProductDAL();
        

        //public ObservableCollection<Product> GetAllPersons()
        //{
        //    return productDAL.GetAllProducts();
        //}

        //public void AddPerson(Product product)
        //{
        //    if (string.IsNullOrEmpty(persoana.Name))
        //    {
        //        //ErrorMessage = "Numele persoanei trebuie sa fie precizat";
        //        throw new AgendaException("Numele persoanei trebuie sa fie precizat");
        //    }
        //    persoanaDAL.AddPerson(persoana);
        //    PersonsList.Add(persoana);
        //}

        //public void ModifyPerson(Person persoana)
        //{
        //    if (persoana == null)
        //    {
        //        throw new AgendaException("Trebuie selectata o persoana");
        //    }
        //    if (string.IsNullOrEmpty(persoana.Name))
        //    {
        //        throw new AgendaException("Trebuie precizat numele persoanei");
        //    }
        //    persoanaDAL.ModifyPerson(persoana);
        //}

        //public void DeletePerson(Person persoana)
        //{
        //    if (persoana == null)
        //    {
        //        throw new AgendaException("Trebuie precizata o persoana!");
        //    }
        //    else
        //    {
        //        PhoneDAL phoneDAL = new PhoneDAL();
        //        if (phoneDAL.GetAllPhonesForPerson(persoana).Count > 0)
        //        {
        //            throw new AgendaException("Trebuie sa stergeti mai intai numerele de telefon ale persoanei!");
        //        }
        //    }
        //    persoanaDAL.DeletePerson(persoana);
        //    PersonsList.Remove(persoana);
        //}
    }
}
