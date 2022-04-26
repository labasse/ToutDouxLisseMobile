using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ToutDouxLisse
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TachePage : ContentPage
    {
        public TachePage(Tache t)
        {
            BindingContext = t;
            InitializeComponent();
        }
    }
}