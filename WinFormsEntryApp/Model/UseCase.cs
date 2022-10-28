using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace WinFormsEntryApp.Model
{
    public class UseCase

    {
        public string Name { get; set; }

        public string Description { get; set; }

        private IServiceProvider ServiceProvider { get; set; }

        private Type FormType { get; set; }


        private Form BuildForm() => (Form)this.ServiceProvider.GetRequiredService(this.FormType);


        public static UseCase Build<T>(string name, string description, IServiceProvider serviceProvider)
        where T : Form
        {
            return new UseCase()
            {
                Name = name,
                Description = description,
                ServiceProvider = serviceProvider,
                FormType = typeof(T)
            };
        }

        public void Show()
        {
            this.BuildForm().Show();
        }

    }
}
