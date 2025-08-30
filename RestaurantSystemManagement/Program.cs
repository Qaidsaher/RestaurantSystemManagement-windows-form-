using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantSystemManagement
{
    static class Program
    {

        static public DbConnection dbase = new DbConnection(@"C:\Users\SaherQaid\Desktop\Reseaches\sumain alameera\dd.mdb");
        static public User user;
        static public Color mainColor = Color.FromArgb(255, 192, 128);
        static public Color secColor = ColorTranslator.FromHtml("#f2a541");
        static public Color lineColor = ColorTranslator.FromHtml("#000000");
        static public Color selectColor = ColorTranslator.FromHtml("#f2a541");
        static public string userId = "saher";
        
        [STAThread]

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());

        }
        static public int GeneratID(string tblName)
        {
            int number = 0;
            Random random = new Random();
            if (tblName == "Booking")
            {
                for(; ; )
                {
                    int id = random.Next(1, 30000);
                    if (Program.dbase.GetID("SELECT COUNT(*) FROM Booking WHERE BookingID =" + id) > 0)
                    {
                        
                    }
                    else
                    {
                        number = id;
                        break;
                    }
                }

            }
            else if(tblName == "Ordr")
            {
                for (; ; )
                {
                    int id = random.Next(1, 30000);
                    if (Program.dbase.GetID("SELECT COUNT(*) FROM Ordr WHERE OrderID =" + id) > 0)
                    {

                    }
                    else
                    {
                        number = id;
                        break;
                    }
                }
            }
            return number;
        }
    }
}
