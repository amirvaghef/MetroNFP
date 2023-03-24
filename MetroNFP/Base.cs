using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using Network.BusinnesLogic;
using Common;

namespace MetroNFP
{
    public partial class Base : UserControl
    {
        private static LinkedList<String> link = new System.Collections.Generic.LinkedList<String>();
        protected static Hashtable data = new Hashtable();
        protected static Common.Utility.OperationKind opKind;
        public Base()
        {
            //InitializeComponent();
        }
        public Base(Common.Utility.OperationKind operationKind)
        {
            opKind = operationKind;
        }
        public Base(Hashtable localData, Common.Utility.OperationKind operationKind)
        {
            data = (Hashtable)localData.Clone();

            opKind = operationKind;
        }

        public void NetworkAssign()
        {
            link.Clear();
            LinkedListNode<String> first = new System.Collections.Generic.LinkedListNode<String>("MetroNFP.Network.Presentation.UserControls.StationWizard");
            LinkedListNode<String> second = new System.Collections.Generic.LinkedListNode<String>("MetroNFP.Network.Presentation.UserControls.RailRoad1Wizard");
            LinkedListNode<String> third = new System.Collections.Generic.LinkedListNode<String>("MetroNFP.Network.Presentation.UserControls.RailRoad2Wizard");
            link.AddFirst(first);
            link.AddAfter(first, second);
            link.AddAfter(second, third);
        }
        public void TicketAssign(short mediaKind, short ticketKind)
        {
            link.Clear();
            LinkedListNode<String> first = new System.Collections.Generic.LinkedListNode<String>("MetroNFP.Ticket.Presentation.UserControls.Ticket1Wizard");
            LinkedListNode<String> second = new System.Collections.Generic.LinkedListNode<String>("MetroNFP.Ticket.Presentation.UserControls.Ticket2Wizard");
            LinkedListNode<String> third = new System.Collections.Generic.LinkedListNode<String>("MetroNFP.Ticket.Presentation.UserControls.Ticket3Wizard");
            LinkedListNode<String> fourth = new System.Collections.Generic.LinkedListNode<String>("MetroNFP.Ticket.Presentation.UserControls.Ticket4Wizard");
            LinkedListNode<String> fifth = new System.Collections.Generic.LinkedListNode<String>("MetroNFP.Ticket.Presentation.UserControls.Ticket5Wizard");
            LinkedListNode<String> sixth = new System.Collections.Generic.LinkedListNode<String>("MetroNFP.Ticket.Presentation.UserControls.Ticket6Wizard");
            LinkedListNode<String> seventh = new System.Collections.Generic.LinkedListNode<String>("MetroNFP.Ticket.Presentation.UserControls.Ticket7Wizard");
            LinkedListNode<String> eighth = new System.Collections.Generic.LinkedListNode<String>("MetroNFP.Ticket.Presentation.UserControls.Ticket8Wizard");
            LinkedListNode<String> ninth = new System.Collections.Generic.LinkedListNode<String>("MetroNFP.Ticket.Presentation.UserControls.Ticket9Wizard");
            LinkedListNode<String> tenth = new System.Collections.Generic.LinkedListNode<String>("MetroNFP.Ticket.Presentation.UserControls.Ticket10Wizard");
            LinkedListNode<String> eleventh = new System.Collections.Generic.LinkedListNode<String>("MetroNFP.Ticket.Presentation.UserControls.Ticket11Wizard");
            link.AddFirst(first);
            link.AddAfter(first, second);
            if (ticketKind == 1)
            {
                link.AddAfter(second, third);
                link.AddAfter(third, fourth);
            }
            else
                link.AddAfter(second, fourth);
            link.AddAfter(fourth, fifth);
            link.AddAfter(fifth, sixth);
            if (mediaKind == 2)
            {
                link.AddAfter(sixth, seventh);
                link.AddAfter(seventh, eighth);
            }    
            else
                link.AddAfter(sixth, eighth);
            if (ticketKind == 1)
            {
                link.AddAfter(eighth, ninth);
                link.AddAfter(ninth, tenth);
                link.AddAfter(tenth, eleventh);
            }
            else
            {
                if (ticketKind == 2)
                {
                    link.AddAfter(eighth, tenth);
                    link.AddAfter(tenth, eleventh);
                }
                else
                    link.AddAfter(eighth, eleventh);
            }
        }

        public UserControl First()
        {
            Type uc = Type.GetType(link.First.Value);
            return (UserControl)Activator.CreateInstance(uc);
        }

        protected UserControl Next(String ucName)
        {
            Type uc = Type.GetType(link.Find(ucName).Next.Value);
            return (UserControl)Activator.CreateInstance(uc);
        }

        protected UserControl Previous(String ucName)
        {
            Type uc = Type.GetType(link.Find(ucName).Previous.Value);
            return (UserControl)Activator.CreateInstance(uc);
        }

        public virtual void Cancel()
        {
            data.Clear();
            link.Clear();
        }

        public virtual bool Finish()
        {
            try
            {
                Cancel();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
