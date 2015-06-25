using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using NUnit.Framework;

namespace PO
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form f = new StudentSearch(new User());
            f.Show();
            Application.Run();
        }
    }

    namespace test_Nunit
    {
        [TestFixture]
        public class StudentSearc
        {
            [Test]
            public void StudentSearch(User b, Student ne)
            {
                Assert.True(true);
            }
            }
    }
}
