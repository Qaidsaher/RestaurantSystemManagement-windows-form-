using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystemManagement
{
   

        public class User
        {
        // Fields
            private int id;
            private string name;
            private string password;
            private bool canDelete;
            private bool canUpdate;
            private bool canWrite;

            // Constructor
            public User(int id ,string name, string password, bool canDelete, bool canUpdate, bool canWrite)
            {
                this.name = name;
                this.password = password;
                this.canDelete = canDelete;
                this.canUpdate = canUpdate;
                this.canWrite = canWrite;
            this.id = id;
            }

            public int GetId()
            {
            return this.id;
            }
            public string GetUsername()
            {
                return name;
            }

            public string GetPassword()
            {
                return password;
            }

            public bool CheckUpdate()
            {
                return canUpdate;
            }

            public bool CheckWrite()
            {
                return canWrite;
            }

            public bool CheckDelete()
            {
                return canDelete;
            }
            public bool IsManger()
            {
            return (canDelete && canUpdate && canWrite);
            }
        
        
        }
}
