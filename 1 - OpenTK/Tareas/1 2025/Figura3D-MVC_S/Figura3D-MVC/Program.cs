using System;                         
using System.Threading;               
using System.Windows.Forms;           
using crearFigruas3D.Controllers;     
using crearFigruas3D.Views;           

namespace crearFigruas3D  
{
    static class Program  
    {
        [STAThread]  
        static void Main()  
        {
            
            Application.EnableVisualStyles();

            
            Application.SetCompatibleTextRenderingDefault(false);

            
            GameController controller = new GameController();

            
            Thread uiThread = new Thread(() =>
            {
                
                Application.Run(new MainForm(controller));
            });

            
            uiThread.SetApartmentState(ApartmentState.STA);

            
            uiThread.Start();

            
            
            controller.Run();
        }
    }
}
