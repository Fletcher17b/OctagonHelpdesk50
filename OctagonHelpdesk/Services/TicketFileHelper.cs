﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OctagonHelpdesk.Models.Enum;
using OctagonHelpdesk.Models;

namespace OctagonHelpdesk.Services
{
    public class TicketFileHelper
    {
        private string rutaArchivo = @"data\tickets.dat";

        public TicketFileHelper()
        {

            string path = rutaArchivo;
            if (!Directory.Exists("data"))
            {
                Directory.CreateDirectory("data");
            }
            string filePath = rutaArchivo;

            if (!File.Exists(filePath))
            {
                using (FileStream fs = File.Create(filePath))
                {
                }
            }
        }

        private DateTime dateformater(string date)
        {
            return DateTime.ParseExact(date, "dd/MM/yyyy", CultureInfo.InvariantCulture);
        }

        public void SaveTickets(List<Ticket> ticketList)
        {
            using (FileStream archivo = new FileStream(rutaArchivo, FileMode.Create, FileAccess.Write))
            {
                using (BinaryWriter escritor = new BinaryWriter(archivo))
                {
                    foreach (Ticket ticket in ticketList)
                    {
                        escritor.Write(ticket.IDTicket);
                        escritor.Write(ticket.ActiveState);
                        escritor.Write(ticket.CreatedBy);
                        escritor.Write(ticket.Subject);
                        escritor.Write(ticket.Descripcion);
                        escritor.Write((int)ticket.StateProcess);
                        escritor.Write((int)ticket.Prioridad);
                        escritor.Write(ticket.AsignadoA);
                        escritor.Write(ticket.CreationDate.ToString("dd/MM/yyyy"));
                        escritor.Write(ticket.LastUpdatedDate.ToString("dd/MM/yyyy"));
                        escritor.Write(ticket.DeactivationDate.ToString("dd/MM/yyyy"));
                        escritor.Write(ticket.ReactivationDate.ToString("dd/MM/yyyy"));
                        escritor.Write(ticket.CloseDate.ToString("dd/MM/yyyy"));
                    }
                }
            }
        }

        public List<Ticket> GetTickets()
        {
            List<Ticket> tickets = new List<Ticket>();
            if (!File.Exists(rutaArchivo)) return null;

            using (FileStream archivo = new FileStream(rutaArchivo, FileMode.Open, FileAccess.Read))
            {
                using (BinaryReader lector = new BinaryReader(archivo))
                {
                    while (archivo.Position < archivo.Length)
                    {
                        try
                        {
                            Ticket ticket = new Ticket
                            {
                                IDTicket = lector.ReadInt32(),
                                ActiveState = lector.ReadBoolean(),
                                CreatedBy = lector.ReadInt32(),
                                Subject = lector.ReadString(),
                                Descripcion = lector.ReadString(),
                                StateProcess = (State)lector.ReadInt32(),
                                Prioridad = (Priority)lector.ReadInt32(),
                                AsignadoA = lector.ReadInt32(),
                                CreationDate = ParseDate(lector.ReadString()),
                                LastUpdatedDate = ParseDate(lector.ReadString()),
                                DeactivationDate = ParseDate(lector.ReadString()),
                                ReactivationDate = ParseDate(lector.ReadString()),
                                CloseDate = ParseDate(lector.ReadString())
                            };

                            tickets.Add(ticket);
                        }
                        catch (Exception ex)
                        {
                            throw new Exception($"Error al leer el ticket: {ex.Message}");
                        }
                    }
                }
            }
            return tickets;
        }

        private DateTime ParseDate(string dateString)
        {
            if (DateTime.TryParseExact(dateString, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime date))
            {
                return date;
            }
            else
            {
                throw new FormatException($"{dateString} no es una fecha válida.");
            }
        }

        public void SaveTicket(Ticket ticket)
        {
            List<Ticket> tickets = GetTickets() ?? new List<Ticket>();
            tickets.Add(ticket);
            SaveTickets(tickets);
        }


    }
}
