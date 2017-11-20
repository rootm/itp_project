using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_management
{
    public class User
    {
        private String[] sections = { "Admin", "Users Management", "Financial Management", "Employee Management", "Supplier Management", "Agent Management", "Order Management", "Vehicle Management", "Maintainance Mangement", "Inventory Management" };
        private string userName;
        private int section;
        private static User instance = new User();

        private User() {
            userName = "";
            section = -1;
        }

        public static User Instance {
            get {
                return instance;
                   
            }
        }

        public void setCurrentUser(String user) {
            userName = user;
        }

        public string getCurrentUser() {
            return userName;
        }

        public void setSection(int sectionId) {
            section = sectionId;
        }

        public int getSection() {
            return section;
        }

        public String getSection(int index) {
            return sections[index];
        }
    }
}
