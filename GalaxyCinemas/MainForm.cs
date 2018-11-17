using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using GalaxyCinemas;
using Common;
namespace GalaxyCinemas
{
    public partial class MainForm : Form
    {
        private List<ISpecialPlugin> specialPlugins = new List<ISpecialPlugin>();

        public MainForm()
        {
            InitializeComponent();

        

            try
            {
                DirectoryInfo dir = new DirectoryInfo(Application.StartupPath);

                foreach (FileInfo file in dir.GetFiles("Plugin*.dll"))
                {
                   string name = Path.GetFileNameWithoutExtension(file.Name);
                    //not loading plugin 21-06-18
                    Assembly assembly = Assembly.Load(name); //here

                    var plugins = from type in assembly.GetTypes()
                                  where typeof(ISpecialPlugin).IsAssignableFrom(type) &&
                                  !type.IsInterface
                                  select type;

                    foreach (Type pluginType in plugins)
                    {
                        ISpecialPlugin plugin = Activator.CreateInstance(pluginType) as ISpecialPlugin;
                        specialPlugins.Add(plugin);
                    }
                }
              
              
            }
            catch (Exception e)
            {
                MessageBox.Show("Error while loading special plugins");
                Console.WriteLine(e);
                
            }
        }

        private void ChildFormClosed(object sender, FormClosedEventArgs e)
        {
            // To ensure the main form has focus after a child form is closed.
            this.Focus();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            ImportDataForm idf = new ImportDataForm();
            idf.FormClosed += ChildFormClosed;
            idf.Show();
        }

        private void label2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BookingForm form = new BookingForm(specialPlugins);
            form.FormClosed += ChildFormClosed;

            form.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ExportDataForm form = new ExportDataForm();
            form.FormClosed += ChildFormClosed;
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MainForm form = new MainForm();
            this.Close();
        }
    }
}
