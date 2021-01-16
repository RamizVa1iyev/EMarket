using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMarket.WindowsFormUI.Helper
{
    public static class ErrorHandlingHelper
    {
        public static void ErrorHandler(Action action)
        {
            try
            {
                action.Invoke();
            }
            catch (NullReferenceException exception)
            {
                MessageBox.Show("Plesae fill all the boxes");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
