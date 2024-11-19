using OctagonHelpdesk.Models;
using OctagonHelpdesk.Models.Enum;
using OctagonHelpdesk.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OctagonHelpdesk.Formularios
{
    public partial class CmpTicketFrm : Form
    {

        public event Action<Ticket> TicketCreated;
        private readonly TicketDao ticketDaoLocal;
        public Ticket ticket = new Ticket();
        public Ticket ticketSel = new Ticket();

        // Constructor para crear un nuevo ticket
        public CmpTicketFrm(TicketDao ticketDao)
        {
            InitializeComponent();
            ticketDaoLocal = ticketDao;
            InitializeFormWithoutTicketData();
        }

        // Constructor para editar un ticket existente
        public CmpTicketFrm(TicketDao ticketService, Ticket ticketSelected)
        {
            InitializeComponent();
            ticketDaoLocal = ticketService;
            ticketSel = ticketSelected;
            InitializeFormWithTicketData();
        }

        // Inicializar el formulario para crear un nuevo ticket
        private void InitializeFormWithoutTicketData()
        {
            ticket.IDTicket = ticketDaoLocal.AutogeneradorID();
            lblTicketID.Text = $"Ticket # {ticket.IDTicket}";
            ticket.CreationDate = DateTime.Now;
            ticket.ActiveState = true;
        }

        // Inicializar el formulario para editar un ticket existente
        private void InitializeFormWithTicketData()
        {
            if (ticketSel != null)
            {
                ticket = ticketSel;

                lblTicketID.Text = $"Ticket # {ticketSel.IDTicket}";
                txtSubject.Text = ticketSel.Subject;
                txtDescription.Text = ticketSel.Descripcion;
                cmbState.SelectedItem = ticketSel.StateProcess;
                cmbPriority.SelectedItem = ticketSel.Prioridad;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool ticketValid = false;
            string subject = txtSubject.Text;
            string description = txtDescription.Text;

            ticketValid = ValidarDatos();

            try
            {
                if (ticketValid)
                {
                   
                    ticket.Subject = subject;
                    ticket.Descripcion = description;
                    ticket.StateProcess = cmbState.SelectedItem != null ? (State)cmbState.SelectedItem : State.Creado;
                    ticket.Prioridad = (Priority)cmbPriority.SelectedItem;
                    ticket.AsignadoA = "No Asignado";

                    if (ticket.StateProcess == State.Cerrado)
                    {
                        ticket.CloseDate = DateTime.Now;
                    }

                    TicketCreated?.Invoke(ticket);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Revise el Formato de los Datos Ingresados", "¡Cuidado!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el ticket", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool ValidarDatos()
        {
            if (string.IsNullOrEmpty(txtSubject.Text) || string.IsNullOrEmpty(txtDescription.Text) || cmbState.SelectedIndex == -1 || cmbPriority.SelectedIndex == -1)
            {
                return false;
            }
            return true;
        }

        private void CmpTicketFrm_Load(object sender, EventArgs e)
        {
            cmbState.Items.Clear();
            cmbState.SelectedIndex = -1;
            cmbState.DataSource = Enum.GetValues(typeof(State));

            cmbPriority.Items.Clear();
            cmbPriority.SelectedIndex = -1;
            cmbPriority.DataSource = Enum.GetValues(typeof(Priority));

            txtCreatedBy.Enabled = false;
            btnAttachments.Enabled = false;
            cmbAsigned.Enabled = false;
        }
    }
}
