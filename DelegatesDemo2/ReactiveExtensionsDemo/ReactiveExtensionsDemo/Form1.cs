using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reactive.Concurrency;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReactiveExtensionsDemo
{

    public partial class Form1 : Form
    {
        //static event Action<String> types;
        static Subject<string> obsTypes = new Subject<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //var lstTypes = new List<Dotnet>
            //{
            //    new Dotnet
            //    {
            //        AvailableDataType = "bool"
            //    },
            //    new Dotnet
            //    {
            //        AvailableDataType = "string"
            //    },
            //    new Dotnet
            //    {
            //        AvailableDataType = "decimal"
            //    }
            //};

            //types += x =>
            //{
            //    MessageBox.Show(x);
            //};

            //obsTypes.Subscribe(x =>
            //{
            //    MessageBox.Show(x);
            //});


            //for(var i = 0; i < lstTypes.Count; i++)
            //{
            //    //types(lstTypes[i].AvailableDataType);
            //    obsTypes.OnNext(lstTypes[i].AvailableDataType);
            //}

            var searchTerm = Observable
                                .FromEventPattern<EventArgs>(textBox1, "TextChanged")
                                .Select(x => ((TextBox)x.Sender).Text)
                                .Throttle(TimeSpan.FromMilliseconds(5000));

            //searchTerm.Subscribe(trm => label1.Text = trm);
            searchTerm.ObserveOn(new ControlScheduler(this)).Subscribe(trm => label1.Text = trm);
        }
    }

    public class Dotnet
    {
        public string AvailableDataType { get; set; }
    }

}
