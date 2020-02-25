using DASInvoice.dao;
using DASInvoice.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DASInvoice.service
{
    static class ClientService
    {
        public static Boolean IsExist(String firstName, String lastName)
        {
            return ClientDao.IsExist(firstName, lastName);
        }

        public static Client Get(String clientID)
        {
            return ClientDao.Select(clientID);
        }

        public static Client Get(String firstName, String lastName)
        {
            return ClientDao.Select(firstName, lastName);
        }

        public static List<Client> GetAll()
        {
            return ClientDao.SelectAll();
        }

        public static List<Client> Select(String clientName, String company, String email, String clientID, String country, String clientStatus)
        {
            if (String.IsNullOrWhiteSpace(clientName)) clientName = null;
            if (String.IsNullOrWhiteSpace(company)) company = null;
            if (String.IsNullOrWhiteSpace(email)) email = null;
            if (String.IsNullOrWhiteSpace(clientID)) clientID = null;
            if (String.IsNullOrWhiteSpace(country)) country = null;
            if (String.IsNullOrWhiteSpace(clientStatus)) clientStatus = null;
            return ClientDao.Select(clientName, company, email, clientID, country, clientStatus);
        }

        public static String GetNextClientID(String clientIDAssign)
        {
            String maxID = ClientDao.SelectMaxID(clientIDAssign);
            if (maxID == null) return clientIDAssign + "0001";
            int nextSerial = Convert.ToInt32(maxID.Substring(clientIDAssign.Length)) + 1;
            return clientIDAssign + nextSerial.ToString("D4");
        }

        public static int Insert(Client m)
        {
            if (String.IsNullOrWhiteSpace(m.FirstName)) throw new NullReferenceException("FirstName is null.");
            if (String.IsNullOrWhiteSpace(m.LastName)) throw new NullReferenceException("LastName is null.");
            if (String.IsNullOrWhiteSpace(m.Company)) throw new NullReferenceException("Company is null.");
            if (String.IsNullOrWhiteSpace(m.TIN)) m.TIN = null;
            if (String.IsNullOrWhiteSpace(m.VAT)) m.VAT = null;
            if (String.IsNullOrWhiteSpace(m.Phone)) m.Phone = null;
            if (String.IsNullOrWhiteSpace(m.Email)) m.Email = null;
            if (String.IsNullOrWhiteSpace(m.Address1)) m.Address1 = null;
            if (String.IsNullOrWhiteSpace(m.Address2)) m.Address2 = null;
            if (m.Address1 == null && m.Address2 != null)
            {
                m.Address1 = m.Address2;
                m.Address2 = null;
            }
            if (String.IsNullOrWhiteSpace(m.City)) m.City = null;
            if (String.IsNullOrWhiteSpace(m.State)) m.State = null;
            if (String.IsNullOrWhiteSpace(m.PostalCode)) m.PostalCode = null;
            if (String.IsNullOrWhiteSpace(m.Country)) m.Country = null;
            if (String.IsNullOrWhiteSpace(m.ClientStatus)) throw new NullReferenceException("ClientStatus is null.");
            if (String.IsNullOrWhiteSpace(m.ClientID))
            {
                if (String.IsNullOrWhiteSpace(m.ClientIDAssign))
                    throw new NullReferenceException("ClientID and ClientIDAssign are null.");
                m.ClientID = GetNextClientID(m.ClientIDAssign);
            }
            if (String.IsNullOrWhiteSpace(m.InvoiceIDAssign)) throw new NullReferenceException("InvoiceIDAssign is null.");
            if (String.IsNullOrWhiteSpace(m.InvoiceTemplate)) m.InvoiceTemplate = null;
            if (String.IsNullOrWhiteSpace(m.VATApplicable)) m.VATApplicable = null;
            // m.VATPercent is int
            if (String.IsNullOrWhiteSpace(m.Currency)) m.Currency = null;
            if (String.IsNullOrWhiteSpace(m.Notes)) m.Notes = null;
            m.TimeRegistered = DateTime.Now;
            return ClientDao.Insert(m);
        }

        public static int Update(Client m)
        {
            if (String.IsNullOrWhiteSpace(m.ClientID)) throw new NullReferenceException("ClientID is null.");
            if (String.IsNullOrWhiteSpace(m.FirstName)) throw new NullReferenceException("FirstName is null.");
            if (String.IsNullOrWhiteSpace(m.LastName)) throw new NullReferenceException("LastName is null.");
            if (String.IsNullOrWhiteSpace(m.Company)) throw new NullReferenceException("Company is null.");
            if (String.IsNullOrWhiteSpace(m.TIN)) m.TIN = null;
            if (String.IsNullOrWhiteSpace(m.VAT)) m.VAT = null;
            if (String.IsNullOrWhiteSpace(m.Phone)) m.Phone = null;
            if (String.IsNullOrWhiteSpace(m.Email)) m.Email = null;
            if (String.IsNullOrWhiteSpace(m.Address1)) m.Address1 = null;
            if (String.IsNullOrWhiteSpace(m.Address2)) m.Address2 = null;
            if (String.IsNullOrWhiteSpace(m.City)) m.City = null;
            if (String.IsNullOrWhiteSpace(m.State)) m.State = null;
            if (String.IsNullOrWhiteSpace(m.PostalCode)) m.PostalCode = null;
            if (String.IsNullOrWhiteSpace(m.Country)) m.Country = null;
            if (String.IsNullOrWhiteSpace(m.ClientStatus)) throw new NullReferenceException("ClientStatus is null.");
            if (String.IsNullOrWhiteSpace(m.InvoiceIDAssign)) throw new NullReferenceException("InvoiceIDAssign is null.");
            if (String.IsNullOrWhiteSpace(m.InvoiceTemplate)) m.InvoiceTemplate = null;
            if (String.IsNullOrWhiteSpace(m.VATApplicable)) m.VATApplicable = null;
            // m.VATPercent is int
            if (String.IsNullOrWhiteSpace(m.Currency)) m.Currency = null;
            if (String.IsNullOrWhiteSpace(m.Notes)) m.Notes = null;
            //m.TimeRegistered = DateTime.Now;
            return ClientDao.Update(m);
        }

        public static int Delete(String clientID)
        {
            if (String.IsNullOrWhiteSpace(clientID))
            {
                throw new NullReferenceException("ClientID is null.");
            }
            return ClientDao.Delete(clientID);
        }

    }
}
