using InventoryManagementSystem.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem
{
    class InventorySystem
    {
        private InventoryCommand inventoryCmd;
        private ManagementCommand managementCmd;
        private string[] parameters;

        public void Run()
        {
            inventoryCmd = new InventoryCommand();
            managementCmd = new ManagementCommand();

        }

        private void PrintWelcome()
        {


        }

        private void RequestCommand()
        {


        }

        private bool IsValidParameter(int paramNumber)
        {

            return false;
        }
    }
}
